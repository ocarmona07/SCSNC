namespace ModulOtec.Vista
{
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;
    using Negocio;

    /// <summary>
    /// 
    /// </summary>
    public partial class GestionIncidencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            
            // Etapa de análisis
            var listaIncidencias = new IncidenciasBo().ObtenerIncidencias();
            if (listaIncidencias.Count > 0)
            {
                gvEtapaAnalisis.DataSource = listaIncidencias;
                gvEtapaAnalisis.DataBind();
                gvEtapaAnalisis.HeaderRow.TableSection = TableRowSection.TableHeader;
            }

            // Todo: Contar solo incidencias que estén en análisis
            lblEtapaAnalisis.Text = listaIncidencias.Count + "";

            // Acciones correctivas
            lblAccionesCorrectivas.Text = "3";

            // Incidencias solucionadas
            lblIncidenciasSolucionadas.Text = "35";
        }

        /// <summary>
        /// Método que se llama al presionar un botón de la tabla
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EtapaAnalisisOnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":

                    break;
            }
        }
    }
}