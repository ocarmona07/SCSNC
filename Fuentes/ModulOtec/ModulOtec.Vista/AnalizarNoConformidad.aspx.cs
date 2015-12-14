namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
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

            lblCodSNC.Text = string.Format("{0:00000}", incidencia.IdIncidencia);
            lblFechaIngreso.Text = incidencia.FechaIngreso.ToString("dd-MM-yyyy");
            lblFechaIdentificacion.Text = incidencia.FechaIdentificacion.ToString("dd-MM-yyyy");
            lblEstado.Text = new GeneralBo().ObtenerEstadoAccion(incidencia.IdEstadoIncidencia).Descripcion;
            lblTipo.Text = new GeneralBo().ObtenerTipoIncidencia(incidencia.IdEstadoIncidencia).Descripcion;
            lblModoDetect.Text = new GeneralBo().ObtenerModoDeteccion(incidencia.IdModoDeteccion).Descripcion;
            lblAreaAfectada.Text = incidencia.AreaAfectada;
            txtDetalle.Text = incidencia.Descripcion;
            txtDetalle.Attributes.Add("readonly", "readonly");
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
                case "Quitar":

                    break;
            }
        }
    }
}