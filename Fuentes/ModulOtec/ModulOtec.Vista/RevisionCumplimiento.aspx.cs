using ModulOtec.Entidades;

namespace ModulOtec.Vista
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;

    /// <summary>
    /// Clase principal para Revisión de cumplimiento
    /// </summary>
    public partial class SeguimientoIncidencia : Page
    {
        /// <summary>
        /// Método que se llama al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (string.IsNullOrEmpty(Request.QueryString["IdIncidencia"])) return;
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(Request.QueryString["IdIncidencia"]));
            if (incidencia == null) return;

            btnFinalizar.CommandArgument = incidencia.IdIncidencia + "";
            lblCodSNC.Text = string.Format("{0:00000}", incidencia.IdIncidencia);
            var rut = incidencia.EsExterno ? incidencia.RutExterno ?? 1 : incidencia.RutCreador;
            lblRutIngreso.Text = string.Format("{0:N0}-", rut) + new GeneralBo().ObtenerDigitoVerificador(rut);
            lblFechaIngreso.Text = incidencia.FechaIngreso.ToString("dd-MM-yyyy");
            lblFechaIdentificacion.Text = incidencia.FechaIdentificacion.ToString("dd-MM-yyyy");
            lblEstado.Text = new GeneralBo().ObtenerEstadoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblTipo.Text = new GeneralBo().ObtenerTipoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblModoDetect.Text = new GeneralBo().ObtenerModoDeteccion(incidencia.IdModoDeteccion).Descripcion;
            lblAreaAfectada.Text = incidencia.AreaAfectada;
            lblDetalle.Text = incidencia.Descripcion;

            var idAnalisis = new AnalisisCausasBo().ObtenerAnalisisExistente(incidencia.IdIncidencia).IdAnalisisCausa;
            var analisis = new AnalisisCausasBo().ObtenerAnalisisCausa(idAnalisis);
            if (analisis == null) return;
            lblCausasPotenciales.Text = analisis.CausasPotenciales;
            lblEfectosDeseados.Text = analisis.EfectosDeseados;
            var dias = new GeneralBo().ObtenerTratamiento(analisis.IdTratamiento).DiasPlazo;
            lblFechaLimite.Text = incidencia.FechaIngreso.AddDays(dias).ToString("dd-MM-yyyy");
            lblTratamiento.Text = new GeneralBo().ObtenerTratamiento(analisis.IdTratamiento).Descripcion;
            gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentosPorIncidencia(incidencia.IdIncidencia);
            gvDocumentos.DataBind();
            btnFinalizar.CommandName = analisis.IdAnalisisCausa + "";

            chklAcciones.DataSource = new AccionesBo().ObtenerAccionesPorAnalisis(analisis.IdAnalisisCausa);
            chklAcciones.DataTextField = "DescAccion";
            chklAcciones.DataValueField = "IdAccion";
            chklAcciones.DataBind();

            // Cálculo de días restantes
            var diasRestantes = (incidencia.FechaIngreso.AddDays(dias) - DateTime.Today).Days;
            var classDias = "progress-bar progress-bar-striped";
            if (diasRestantes > 0)
            {
                divProgress.Style.Add("width", "100%");
                if (diasRestantes <= 3)
                {
                    divProgress.Style.Add("width", diasRestantes * 10 + "%");
                    classDias += " progress-bar-danger";
                }
                else if (diasRestantes <= 6)
                {
                    divProgress.Style.Add("width", diasRestantes * 10 + "%");
                    classDias += " progress-bar-warning";
                }
                else if (diasRestantes <= 10)
                {
                    divProgress.Style.Add("width", diasRestantes * 10 + "%");
                    classDias += " progress-bar-success";
                }

                lblDiasRestantes.Text = diasRestantes + "";
                divProgress.Attributes.Add("class", classDias);
            }
            else
            {
                lblDiasRestantes.Text = "0";
                divProgress.Attributes.Add("class", classDias + " progress-bar-danger");
                divProgress.Style.Add("width", "100%");
            }
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
                        + "ID_" + btnFinalizar.CommandArgument + @"\";
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Type", "application/octet-stream");
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + e.CommandArgument);
                    Response.BinaryWrite(File.ReadAllBytes(rutaArchivos + e.CommandArgument));
                    Response.Flush();
                    Response.End();
                    break;
            }
        }

        /// <summary>
        /// Método que redirecciona al menú de gestión de incidencias
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void CancelarOnClick(object sender, EventArgs e)
        {
            Response.Redirect("GestionIncidencias.aspx");
        }

        /// <summary>
        /// Método que cambia el estado de la incidencia a reanálisis
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void ReAnalizarOnClick(object sender, EventArgs e)
        {
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(btnFinalizar.CommandArgument));
            incidencia.IdEstadoIncidencia = 5;
            if (new IncidenciasBo().ActualizarIncidencia(incidencia) > 0)
            {
                lblTituloModal.Text = "Incidencia en Reanálisis";
                litDetalle.Text = string.Format("<p><b>La incidencia {0:00000} ha cambiado de estado a Reanálisis</b></p>", incidencia.IdIncidencia);
                btnModalAceptar.Attributes.Add("formnovalidate", "");
                btnModalAceptar.Attributes.Remove("data-dismiss");
                btnModalAceptar.PostBackUrl = "~/GestionIncidencias.aspx";
            }
            else
            {
                lblTituloModal.Text = "Error al cambiar la incidencia";
                litDetalle.Text = "<p><b>Ha ocurrido un error al cambiar el estado de la incidencia</b></p>";
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }

        /// <summary>
        /// Método que finaliza la revisión de cumplimiento
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void FinalizarOnClick(object sender, EventArgs e)
        {
            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(btnFinalizar.CommandArgument));
            incidencia.IdEstadoIncidencia = 6;
            if (new IncidenciasBo().ActualizarIncidencia(incidencia) > 0)
            {
                foreach (ListItem item in chklAcciones.Items)
                {
                    var accion = new AccionesBo().ObtenerAccion(int.Parse(item.Value));
                    accion.IdEstado = item.Selected ? 1 : 2;
                    new AccionesBo().ActualizarAccion(accion);
                }

                var evaluacion = new EvaluacionCumplimiento
                {
                    IdAnalisisCausa = int.Parse(btnFinalizar.CommandName),
                    Observacion = txtObservaciones.Text,
                    FechaEv = DateTime.Today
                };
                if (new EvaluacionesCumplimientoBo().CrearEvaluacionCumplimiento(evaluacion) > 0)
                {
                    lblTituloModal.Text = "Incidencia Finalizada";
                    litDetalle.Text = string.Format("<p><b>La incidencia {0:00000} se ha establecido como finalizada</b></p>", incidencia.IdIncidencia);
                    btnModalAceptar.Attributes.Add("formnovalidate", "");
                    btnModalAceptar.Attributes.Remove("data-dismiss");
                    btnModalAceptar.PostBackUrl = "~/GestionIncidencias.aspx";
                }
                else
                {
                    lblTituloModal.Text = "Error al cambiar la incidencia";
                    litDetalle.Text = "<p><b>Ha ocurrido un error al cambiar el estado de la incidencia</b></p>";
                }
            }
            else
            {
                lblTituloModal.Text = "Error al cambiar la incidencia";
                litDetalle.Text = "<p><b>Ha ocurrido un error al cambiar el estado de la incidencia</b></p>";
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }
    }
}