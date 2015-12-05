namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;

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
        }
    }
}