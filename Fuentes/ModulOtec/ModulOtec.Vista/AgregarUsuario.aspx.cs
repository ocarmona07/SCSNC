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

                #region Lista Comunas

                var generalBo = new GeneralBo();

                ddlComuna.DataSource = generalBo.ObtenerComunasPorProvincia(34);
                ddlComuna.DataTextField = generalBo.Text;
                ddlComuna.DataValueField = generalBo.Value;
                ddlComuna.DataBind();

                ddlComuna.Items.Insert(0, seleccione);
                ddlComuna.Attributes.Add("required", "required");

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
    }
}