using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModulOtec.Vista
{
    using Negocio;
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var seleccione = new ListItem("Seleccione una opción...", "");

                #region Lista Regiones

                var generalBo = new GeneralBo();

                ddlRegion.DataSource = generalBo.ObtenerRegiones();
                ddlRegion.DataTextField = generalBo.Text;
                ddlRegion.DataValueField = generalBo.Value;
                ddlRegion.DataBind();

                ddlRegion.Items.Insert(0, seleccione);
                ddlRegion.Attributes.Add("required", "required");

                #endregion

                #region Lista Roles

                var generalBo2 = new GeneralBo();

                ddlRol.DataSource = generalBo2.ObtenerTratamientos();
                ddlRol.DataTextField = generalBo2.Text;
                ddlRol.DataValueField = generalBo2.Value;
                ddlRol.DataBind();

                ddlRol.Items.Insert(0, seleccione);
                ddlRol.Attributes.Add("required", "required");

                #endregion
            }

        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {

        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccione = new ListItem("Seleccione una opción...", "");
            #region Lista Provincias

            var generalBo = new GeneralBo();

            ddlProvincia.DataSource = generalBo.ObtenerProvinciasPorRegion(ddlRegion.SelectedIndex);
            ddlProvincia.DataTextField = generalBo.Text;
            ddlProvincia.DataValueField = generalBo.Value;
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, seleccione);
            ddlProvincia.Attributes.Add("required", "required");

            #endregion
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccione = new ListItem("Seleccione una opción...", "");
            #region Lista Comunas

            var generalBo = new GeneralBo();

            ddlComuna.DataSource = generalBo.ObtenerComunasPorProvincia(ddlProvincia.SelectedIndex);
            ddlComuna.DataTextField = generalBo.Text;
            ddlComuna.DataValueField = generalBo.Value;
            ddlComuna.DataBind();

            ddlComuna.Items.Insert(0, seleccione);
            ddlComuna.Attributes.Add("required", "required");

            #endregion
        }
    }
}