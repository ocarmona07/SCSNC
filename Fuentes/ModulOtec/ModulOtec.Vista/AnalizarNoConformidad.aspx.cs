namespace ModulOtec.Vista
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;
    using Entidades;

    /// <summary>
    /// Clase de la vista de Análisis de no conformidades
    /// </summary>
    public partial class AnalizarNoConformidad : System.Web.UI.Page
    {
        /// <summary>
        /// Método que inicia la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            var seleccione = new ListItem("Seleccione una opción...", "");
            #region Lista Tipo Conformidad

            var generalBo = new GeneralBo();

            ddlTratamiento.DataSource = generalBo.ObtenerTratamientos();
            ddlTratamiento.DataTextField = generalBo.Text;
            ddlTratamiento.DataValueField = generalBo.Value;
            ddlTratamiento.DataBind();

            ddlTratamiento.Items.Insert(0, seleccione);
            ddlTratamiento.Attributes.Add("required", "required");

            #endregion

            if (string.IsNullOrEmpty(Request.QueryString["IdIncidencia"])) return;

            var incidencia = new IncidenciasBo().ObtenerIncidencia(int.Parse(Request.QueryString["IdIncidencia"]));
            if (incidencia == null) return;

            btnIngresarAcciones.CommandArgument = incidencia.IdIncidencia + "";
            lblCodSNC.Text = string.Format("{0:00000}", incidencia.IdIncidencia);
            lblFechaIngreso.Text = incidencia.FechaIngreso.ToString("dd-MM-yyyy");
            lblFechaIdentificacion.Text = incidencia.FechaIdentificacion.ToString("dd-MM-yyyy");
            lblEstado.Text = new GeneralBo().ObtenerEstadoAccion(incidencia.IdEstadoIncidencia).Descripcion;
            lblTipo.Text = new GeneralBo().ObtenerTipoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblModoDetect.Text = new GeneralBo().ObtenerModoDeteccion(incidencia.IdModoDeteccion).Descripcion;
            lblAreaAfectada.Text = incidencia.AreaAfectada;
            txtDetalle.Text = incidencia.Descripcion;
            txtDetalle.Attributes.Add("readonly", "readonly");

            gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentos();
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

                    gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentos();
                    gvDocumentos.DataBind();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
                    upModal.Update();
                    break;
            }
        }

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

            gvDocumentos.DataSource = new DocumentosBo().ObtenerDocumentos();
            gvDocumentos.DataBind();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();", true);
            upModal.Update();
        }
    }
}