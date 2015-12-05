using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModulOtec.Vista
{
    public partial class SeguimientoIncidencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CancelarOnClick(object sender, EventArgs e)
        {
            Response.Redirect("GestionIncidencias.aspx");
        }

        protected void ReAnalizarOnClick(object sender, EventArgs e)
        {
            Response.Redirect("GestionIncidencias.aspx");
        }
    }
}