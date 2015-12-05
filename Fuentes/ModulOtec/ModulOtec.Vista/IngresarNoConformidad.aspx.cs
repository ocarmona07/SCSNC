namespace ModulOtec.Vista
{
    using System;
    using System.Web.UI.WebControls;
    using Negocio;

    /// <summary>
    /// Clase de ingreso de no conformidad
    /// </summary>
    public partial class IngresarNoConformidad : System.Web.UI.Page
    {
        /// <summary>
        /// Método inicial de la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var seleccione = new ListItem("Seleccione una opción...", "");

            #region Lista Tipo Conformidad

            var generalBo = new GeneralBo();

            ddlTipoConformidad.DataSource = generalBo.ObtenerTiposIncidencias();
            ddlTipoConformidad.DataTextField = generalBo.Text;
            ddlTipoConformidad.DataValueField = generalBo.Value;
            ddlTipoConformidad.DataBind();

            ddlTipoConformidad.Items.Insert(0, seleccione);
            ddlTipoConformidad.Attributes.Add("required", "required");

            #endregion

            #region Lista Modo Detección

            ddlModoDeteccion.DataSource = generalBo.ObtenerModosDetecciones();
            ddlModoDeteccion.DataTextField = generalBo.Text;
            ddlModoDeteccion.DataValueField = generalBo.Value;
            ddlModoDeteccion.DataBind();

            ddlModoDeteccion.Items.Insert(0, seleccione);
            ddlModoDeteccion.Attributes.Add("required", "required");

            #endregion
        }
    }
}