namespace ModulOtec.Vista
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;
    using Entidades;

    /// <summary>
    /// Clase de ingreso de no conformidad
    /// </summary>
    public partial class IngresarNoConformidad : Page
    {
        /// <summary>
        /// Método inicial de la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
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

        /// <summary>
        /// Método que almacena o actualiza una no conformidad
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void IngresarIncidencia(object sender, EventArgs e)
        {
            var incidencia = new Incidencias
            {
                RutCreador = int.Parse(Session["RutUsuario"] + ""),
                FechaIngreso = DateTime.Today,
                IdTipoIncidencia = int.Parse(ddlTipoConformidad.SelectedValue),
                IdModoDeteccion = int.Parse(ddlModoDeteccion.SelectedValue),
                FechaIdentificacion = DateTime.Parse(txtFechaIdent.Text),
                AreaAfectada = txtAreaAfectada.Text,
                ProcesoAfectado = txtProcesoAfectado.Text,
                Descripcion = txtDescripcion.Text,
                IdEstadoIncidencia = 1
            };

            var idIncidencia = new IncidenciasBo().CrearIncidencia(incidencia);
            if (idIncidencia > 0)
            {
                lblTituloModal.Text = "Guardado correctamente";
                var detalle = "<p><b>Código de la Incidencia:</b> " + string.Format("{0:00000}", idIncidencia) + "</p>";
                detalle += "<p><b>Tipo de incidencia:</b> " + ddlTipoConformidad.SelectedItem.Text + "</p>";
                detalle += "<p><b>Modo de detección:</b> " + ddlModoDeteccion.SelectedItem.Text + "</p>";
                detalle += "<p><b>Fecha de identificación:</b> " + DateTime.Parse(txtFechaIdent.Text).ToString("dd-MM-yyyy") + "</p>";
                detalle += "<p><b>Área afectada:</b> " + txtAreaAfectada.Text + "</p>";
                detalle += "<p><b>Proceso afectado:</b> " + txtProcesoAfectado.Text + "</p>";
                detalle += "<p><b>Descripción de la No Conformidad:</b> " + txtDescripcion.Text + "</p>";
                litDetalle.Text = detalle;
            }
            else
            {
                lblTituloModal.Text = "Error al guardar";
                litDetalle.Text = "<p><b>Ha ocurrido un error al guardar</b></p>";
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalIngresar", "$('#modalIngresar').modal();", true);
            upModal.Update();
        }
    }
}