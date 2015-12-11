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
    /// Clase principal para Agregar o Modificar un Usuario
    /// </summary>
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        /// <summary>
        /// Método que se llama al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            lblTitulo.Text = Request.QueryString["IdUsuario"] != "0" ? "Actualizar" : "Ingresar Nuevo";

            var seleccione = new ListItem("Seleccione una opción...", "");

            #region Lista Regiones

            var generalBo = new GeneralBo();

            ddlRegion.DataSource = generalBo.ObtenerRegiones();
            ddlRegion.DataTextField = generalBo.Text;
            ddlRegion.DataValueField = generalBo.Value;
            ddlRegion.DataBind();

            ddlRegion.Items.Insert(0, seleccione);
            ddlRegion.Attributes.Add("required", "required");
            ddlProvincia.Items.Insert(0, seleccione);
            ddlProvincia.Attributes.Add("required", "required");
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

        /// <summary>
        /// Método que se llama al guardar o modificar un usuario
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void AgregarUsuarioClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que se llama al cambiar una Región
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void RegionSelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlRegion.SelectedValue)) return;

            var seleccione = new ListItem("Seleccione una opción...", "");

            var generalBo = new GeneralBo();

            ddlProvincia.DataSource = generalBo.ObtenerProvinciasPorRegion(int.Parse(ddlRegion.SelectedValue));
            ddlProvincia.DataTextField = generalBo.Text;
            ddlProvincia.DataValueField = generalBo.Value;
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, seleccione);
            ddlProvincia.Attributes.Add("required", "required");
        }

        /// <summary>
        /// Método que se llama al cambiar una provincia
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void ProvinciaSelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlRegion.SelectedValue)) return;

            var seleccione = new ListItem("Seleccione una opción...", "");

            var generalBo = new GeneralBo();
            ddlComuna.DataSource = generalBo.ObtenerComunasPorProvincia(int.Parse(ddlProvincia.SelectedValue));
            ddlComuna.DataTextField = generalBo.Text;
            ddlComuna.DataValueField = generalBo.Value;
            ddlComuna.DataBind();

            ddlComuna.Items.Insert(0, seleccione);
            ddlComuna.Attributes.Add("required", "required");
        }
    }
}