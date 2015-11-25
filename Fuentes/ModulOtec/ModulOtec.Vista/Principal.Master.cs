namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Test user
            Session["RutUsuario"] = "159888207";

            if (string.IsNullOrEmpty(Session["RutUsuario"] + ""))
            {
                CerrarSesion(sender, e);
            }

            if (IsPostBack) return;

            lblUsuario.Text = "Oscar Ibáñez Tagle";
            lblCargo.Text = "Encargado de Capacitación";
        }

        protected void CerrarSesion(object sender, EventArgs e)
        {
            Session["RutUsuario"] = string.Empty;
            Response.Redirect("MainModulos.aspx");
        }
    }
}