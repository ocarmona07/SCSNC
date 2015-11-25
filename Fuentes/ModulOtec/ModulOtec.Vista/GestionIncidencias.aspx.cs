namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class GestionIncidencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            #region Notificaciones

            var cantNotif = "2";
            lnkNotificaciones.Text = "Notificaciones <span class=\"badge\">" + cantNotif + "</span>";

            #endregion

            #region Lista de datos

            // Etapa de análisis
            lblEtapaAnalisis.Text = "2";

            // Acciones correctivas
            lblAccionesCorrectivas.Text = "3";

            // Incidencias solucionadas
            lblIncidenciasSolucionadas.Text = "35";

            #endregion
        }
    }
}