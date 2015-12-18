namespace ModulOtec.Vista
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;
    using Entidades;

    /// <summary>
    /// Clase de la vista de Análisis de no conformidades
    /// </summary>
    public partial class AnalizarNoConformidad : Page
    {
        /// <summary>
        /// Método que inicia la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            #region Carga DDL Tratamientos

            var generalBo = new GeneralBo();
            ddlTratamiento.DataSource = generalBo.ObtenerTratamientos();
            ddlTratamiento.DataTextField = generalBo.Text;
            ddlTratamiento.DataValueField = generalBo.Value;
            ddlTratamiento.DataBind();

            ddlTratamiento.Items.Insert(0, new ListItem("Seleccione una opción...", ""));
            ddlTratamiento.Attributes.Add("required", "required");

            #endregion

            if (string.IsNullOrEmpty(Request.QueryString["IdIncidencia"])) return;
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(Request.QueryString["IdIncidencia"]));
            if (incidencia == null) return;

            btnIngresarAcciones.CommandArgument = incidencia.IdIncidencia + "";
            lblCodSNC.Text = string.Format("{0:00000}", incidencia.IdIncidencia);
            lblFechaIngreso.Text = incidencia.FechaIngreso.ToString("dd-MM-yyyy");
            btnInvalidar.CommandArgument = incidencia.FechaIngreso.ToString("yyyy-MM-dd");
            lblFechaIdentificacion.Text = incidencia.FechaIdentificacion.ToString("dd-MM-yyyy");
            lblEstado.Text = new GeneralBo().ObtenerEstadoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblTipo.Text = new GeneralBo().ObtenerTipoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblModoDetect.Text = new GeneralBo().ObtenerModoDeteccion(incidencia.IdModoDeteccion).Descripcion;
            lblAreaAfectada.Text = incidencia.AreaAfectada;
            txtDetalle.Text = incidencia.Descripcion;
            txtDetalle.Attributes.Add("readonly", "readonly");

            var reanalisis = new AnalisisCausasBo().ObtenerAnalisisExistente(incidencia.IdIncidencia);
            if (reanalisis != null && incidencia.IdEstadoIncidencia == 5)
            {
                txtCausas.Text = reanalisis.CausasPotenciales;
                txtEfectosDeseados.Text = reanalisis.EfectosDeseados;
                ddlTratamiento.SelectedValue = reanalisis.IdTratamiento.ToString();
                var dias = generalBo.ObtenerTratamiento(reanalisis.IdTratamiento).DiasPlazo;
                lblFechaLimite.Text = incidencia.FechaIngreso.AddDays(dias).ToString("dd-MM-yyyy");
                lbxAcciones.DataSource = new AccionesBo().ObtenerAccionesPorAnalisis(reanalisis.IdAnalisisCausa);
                lbxAcciones.DataTextField = "DescAccion";
                lbxAcciones.DataValueField = "DescAccion";
                lbxAcciones.DataBind();

                btnIngresarAcciones.CommandName = reanalisis.IdAnalisisCausa + "";
            }

            gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentosPorIncidencia(incidencia.IdIncidencia);
            gvDocumentos.DataBind();
        }

        /// <summary>
        /// Método que realiza acciones en la grilla de documentos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void DocumentosOnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Descargar":
                    var rutaArchivos = ConfigurationManager.AppSettings["RutaArchivos"]
                        + "ID_" + btnIngresarAcciones.CommandArgument + @"\";
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Type", "application/octet-stream");
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + e.CommandArgument);
                    Response.BinaryWrite(File.ReadAllBytes(rutaArchivos + e.CommandArgument));
                    Response.Flush();
                    Response.End();
                    break;

                case "Quitar":
                    if (new DocumentosBo().EliminarDocumento(int.Parse(e.CommandArgument + "")) > 0)
                    {
                        lblTituloModal.Text = "Documento eliminado";
                        litDetalle.Text = "<p>Documento eliminado correctamente</p>";
                    }
                    else
                    {
                        lblTituloModal.Text = "Error al eliminar";
                        litDetalle.Text = "<p><b>Ha ocurrido un error al eliminar el documento</b></p>";
                    }

                    gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentosPorIncidencia(int.Parse(btnIngresarAcciones.CommandArgument));
                    gvDocumentos.DataBind();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
                    upModal.Update();
                    break;
            }
        }

        /// <summary>
        /// Método que almacena un archivo en el servidor
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void SubirArchivo(object sender, EventArgs e)
        {
            if (!fupDocumentos.HasFile) return;

            try
            {
                var rutaArchivos = ConfigurationManager.AppSettings["RutaArchivos"]
                    + "ID_" + btnIngresarAcciones.CommandArgument + @"\";
                if (!Directory.Exists(rutaArchivos)) Directory.CreateDirectory(rutaArchivos);
                fupDocumentos.SaveAs(rutaArchivos + fupDocumentos.FileName);
                var documento = new Documentos
                {
                    IdIncidencia = int.Parse(btnIngresarAcciones.CommandArgument),
                    RutaDocumento = fupDocumentos.FileName
                };
                if (new DocumentosBo().CrearDocumento(documento) > 0)
                {
                    lblTituloModal.Text = "Documento guardado";
                    litDetalle.Text = "<p>Documento almacenado correctamente</p>";
                }
                else
                {
                    lblTituloModal.Text = "Error al guardar";
                    litDetalle.Text = "<p><b>Ha ocurrido un error al guardar el documento</b></p>";
                }
            }
            catch (Exception ex)
            {
                lblTituloModal.Text = "Error al guardar";
                litDetalle.Text = "<p><b>Ha ocurrido un error al guardar el documento:</b></p><p>" + ex.Message + "</p>";
            }

            gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentosPorIncidencia(int.Parse(btnIngresarAcciones.CommandArgument));
            gvDocumentos.DataBind();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }

        /// <summary>
        /// Método que almacena las acciones establecidas en la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void IngresarAnalisis(object sender, EventArgs e)
        {
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(btnIngresarAcciones.CommandArgument));
            var analisis = new AnalisisCausa
            {
                IdIncidencia = incidencia.IdIncidencia,
                CausasPotenciales = txtCausas.Text,
                EfectosDeseados = txtEfectosDeseados.Text,
                IdTratamiento = int.Parse(ddlTratamiento.SelectedValue)
            };
            if (!string.IsNullOrEmpty(btnIngresarAcciones.CommandName))
                analisis.IdAnalisisCausa = int.Parse(btnIngresarAcciones.CommandName);
            var ingresoAnalisis = string.IsNullOrEmpty(btnIngresarAcciones.CommandName)
                ? new AnalisisCausasBo().CrearAnalisisCausa(analisis)
                : new AnalisisCausasBo().ActualizarAnalisisCausa(analisis);
            if (ingresoAnalisis > 0)
            {
                var items = "";
                foreach (var item in hdnItems.Value.Split('|'))
                {
                    var accion = new Acciones { IdAnalisisCausa = ingresoAnalisis, DescAccion = item };
                    new AccionesBo().CrearAccion(accion);
                    items += item + "<br/>";
                }

                incidencia.IdEstadoIncidencia = 3;
                new IncidenciasBo().ActualizarIncidencia(incidencia);

                lblTituloModal.Text = "Análisis ingresado";
                var detalle = "<p><b>Se ha ingresado el análisis correctamente:</b></p>";
                detalle += "<p><b>Causas de No Conformidad:</b> " + txtCausas.Text + "</p>";
                detalle += "<p><b>Efectos deseados al finalizar el proceso:</b> " + txtEfectosDeseados.Text + "</p>";
                detalle += "<p><b>Tratamiento:</b> " + ddlTratamiento.SelectedItem.Text + "</p>";
                var dias = new GeneralBo().ObtenerTratamiento(int.Parse(ddlTratamiento.SelectedValue)).DiasPlazo;
                detalle += "<p><b>Fecha Límite:</b> " + incidencia.FechaIngreso.AddDays(dias).ToString("dd-MM-yyyy") + "</p>";
                detalle += "<p><b>Acciones Correctivas:</b> " + items + "</p>";
                detalle += "<p><b>Expediente electrónico:</b> ";
                var documentos = new DocumentosBo().ObtenerDocumentos()
                    .Where(o => incidencia.IdIncidencia.Equals(o.IdIncidencia)).ToList();
                foreach (var doc in documentos)
                {
                    detalle += doc.RutaDocumento + "<br/>";
                }

                detalle += documentos.Count == 0 ? "No existen documentos asociados</p>" : "</p>";
                litDetalle.Text = detalle;
                btnModalAceptar.Attributes.Remove("data-dismiss");
                btnModalAceptar.PostBackUrl = "~/GestionIncidencias.aspx";
            }
            else
            {
                lblTituloModal.Text = "Error al ingresar el análisis";
                litDetalle.Text = "<p><b>Ha ocurrido un error en el ingreso</b></p>";
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }

        /// <summary>
        /// Método que redirecciona al menú de gestión
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void VolverOnClick(object sender, EventArgs e)
        {
            Response.Redirect("GestionIncidencias.aspx");
        }

        /// <summary>
        /// Método que invalida el análisis
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void InvalidarOnClick(object sender, EventArgs e)
        {
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(btnIngresarAcciones.CommandArgument));
            incidencia.IdEstadoIncidencia = 2;
            incidencia.Descripcion += "\nInvalida: " + txtCausas.Text;
            if (new IncidenciasBo().ActualizarIncidencia(incidencia) > 0)
            {
                lblTituloModal.Text = "Incidencia invalidada";
                var detalle = string.Format("<p><b>Se ha invalidado la incidencia {0:00000} </b></p>", incidencia.IdIncidencia);
                litDetalle.Text = detalle + "<p><b>La causa es:</b> " + txtCausas.Text + "</p>";
                btnModalAceptar.Attributes.Add("formnovalidate", "");
                btnModalAceptar.Attributes.Remove("data-dismiss");
                btnModalAceptar.PostBackUrl = "~/GestionIncidencias.aspx";
            }
            else
            {
                lblTituloModal.Text = "Error al actualizar la incidencia";
                litDetalle.Text = "<p><b>Ha ocurrido un error al actualizar</b></p>";
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }

        /// <summary>
        /// Método que calcula los días restantes para la solución de la incidencia
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void TratamientoOnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlTratamiento.SelectedValue))
            {
                lblFechaLimite.Text = string.Empty;
            }
            else
            {
                var dias = new GeneralBo().ObtenerTratamiento(int.Parse(ddlTratamiento.SelectedValue)).DiasPlazo;
                lblFechaLimite.Text = DateTime.Parse(btnInvalidar.CommandArgument).AddDays(dias).ToString("dd-MM-yyyy");
            }
        }
    }
}