namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class IngresarNoConformidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var seleccione = new ListItem("Seleccione una opción...", "");

            #region Lista Tipo Conformidad

            var listaTipoConformidad = new DataTable();
            listaTipoConformidad.Columns.Add("Text");
            listaTipoConformidad.Columns.Add("Value");
            listaTipoConformidad.Rows.Add("No conformidad", "1");
            listaTipoConformidad.Rows.Add("No conformidad potencial", "2");

            ddlTipoConformidad.DataSource = listaTipoConformidad;
            ddlTipoConformidad.DataTextField = "Text";
            ddlTipoConformidad.DataValueField = "Value";
            ddlTipoConformidad.DataBind();

            ddlTipoConformidad.Items.Insert(0, seleccione);
            ddlTipoConformidad.Attributes.Add("required", "required");

            #endregion

            #region Lista Modo Detección

            var listaModoDeteccion = new DataTable();
            listaModoDeteccion.Columns.Add("Text");
            listaModoDeteccion.Columns.Add("Value");
            listaModoDeteccion.Rows.Add("Auditoría Interna", "1");
            listaModoDeteccion.Rows.Add("Reclamo", "2");

            ddlModoDeteccion.DataSource = listaModoDeteccion;
            ddlModoDeteccion.DataTextField = "Text";
            ddlModoDeteccion.DataValueField = "Value";
            ddlModoDeteccion.DataBind();

            ddlModoDeteccion.Items.Insert(0, seleccione);
            ddlModoDeteccion.Attributes.Add("required", "required");

            #endregion
        }
    }
}