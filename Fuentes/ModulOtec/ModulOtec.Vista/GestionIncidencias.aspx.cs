using ModulOtec.Entidades;

namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using Negocio;

    /// <summary>
    /// Clase principal de Gestión de Incidencias
    /// </summary>
    public partial class GestionIncidencias : System.Web.UI.Page
    {
        private Dictionary<int, string> _estadosIncidencias;

        /// <summary>
        /// Método que se llama al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            // Etapa de análisis
            var listaAnalisis = new IncidenciasBo().ObtenerIncidenciasEnAnalisis();
            gvEtapaAnalisis.DataSource = listaAnalisis;
            gvEtapaAnalisis.DataBind();
            lblEtapaAnalisis.Text = listaAnalisis.Count + "";
            if (listaAnalisis.Count > 0)
            {
                gvEtapaAnalisis.HeaderRow.TableSection = TableRowSection.TableHeader;
            }

            // Etapa de revisión
            var listaRevision = new IncidenciasBo().ObtenerIncidenciasEnRevision();
            gvEtapaEvaluacion.DataSource = listaRevision;
            gvEtapaEvaluacion.DataBind();
            lblAccionesCorrectivas.Text = listaRevision.Count + "";
            if (listaRevision.Count > 0)
            {
                gvEtapaEvaluacion.HeaderRow.TableSection = TableRowSection.TableHeader;
            }

            // Total Incidenciasvar listaRevision = new IncidenciasBo().ObtenerIncidenciasEnRevision();
            var listaIncidencias = new IncidenciasBo().ObtenerIncidencias();
            gvTotalIncidencias.DataSource = listaIncidencias;
            gvTotalIncidencias.DataBind();
            lblTotalIncidencias.Text = listaIncidencias.Count + "";
            if (listaIncidencias.Count > 0)
            {
                gvTotalIncidencias.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }

        /// <summary>
        /// Método que se llama al presionar un botón de la tabla de etapa de análisis
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EtapaAnalisisOnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":

                    break;

                case "Analizar":
                    Response.Redirect("AnalizarNoConformidad.aspx?IdIncidencia=" + e.CommandArgument);
                    break;
            }
        }

        /// <summary>
        /// Método que se llama al presionar un botón de la tabla de etapa de evaluación
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EtapaEvaluacionOnRowCommandOnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":

                    break;

                case "Evaluar":
                    Response.Redirect("RevisionCumplimiento.aspx?IdAnalisis=" + e.CommandArgument);
                    break;
            }
        }

        /// <summary>
        /// Método que carga todas las incidencias y chequea su estado
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void TotalIncidenciasOnDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.DataRow) return;
            if (_estadosIncidencias == null)
            {
                _estadosIncidencias = new GeneralBo().ObtenerEstadosIncidencias()
                    .ToDictionary(estado => estado.IdEstadoIncidencia, estado => estado.Descripcion);
            }

            var txtEstadoIncidencia = (Label)e.Row.FindControl("txtEstadoIncidencia");
            txtEstadoIncidencia.Text = _estadosIncidencias[((Incidencias) e.Row.DataItem).IdEstadoIncidencia];
        }
    }
}