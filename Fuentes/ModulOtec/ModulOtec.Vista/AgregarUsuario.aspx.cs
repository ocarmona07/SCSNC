namespace ModulOtec.Vista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;
    using Entidades;

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

            if (!string.IsNullOrEmpty(Request.QueryString["RutUsuario"] + ""))
            {
                lblTitulo.Text = "Actualizar Usuario";
                btnAgregarUsuario.Text = "Actualizar Usuario";
                var usuario = new UsuariosBo().ObtenerUsuario(int.Parse(Request.QueryString["RutUsuario"] + ""));
                if (usuario != null)
                {
                    txtRut.Enabled = false;
                    txtRut.Text = usuario.RUT.ToString();
                    btnAgregarUsuario.CommandArgument = usuario.RUT.ToString();
                    txtDv.Enabled = false;
                    txtDv.Text = usuario.DV;
                    txtNombres.Text = usuario.Nombres;
                    txtApellidoPaterno.Text = usuario.ApPaterno;
                    txtApellidoMaterno.Text = usuario.ApMaterno;
                    txtDireccion.Text = usuario.Direccion;

                    var idProvincia = new GeneralBo().ObtenerComunas().First(o => usuario.IdComuna.Equals(o.IdComuna)).IdProvincia;
                    var idRegion = new GeneralBo().ObtenerProvincias().First(o => idProvincia.Equals(o.IdProvincia)).IdRegion;
                    ddlRegion.SelectedValue = idRegion + "";
                    RegionSelectedIndexChanged(null, null);
                    ddlProvincia.SelectedValue = idProvincia + "";
                    ProvinciaSelectedIndexChanged(null, null);
                    ddlComuna.SelectedValue = usuario.IdComuna + "";

                    txtTelefono.Text = usuario.Telefono + "";
                    txtEmail.Text = usuario.Email;
                    ddlRol.SelectedValue = usuario.IdRol.ToString();
                }
                else
                {
                    // Usuario no encontrado
                }
            }
            else
            {
                lblTitulo.Text = "Ingresar Nuevo Usuario";
                btnAgregarUsuario.Text = "Agregar Usuario";
            }
        }

        /// <summary>
        /// Método que se llama al guardar o modificar un usuario
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void AgregarUsuarioClick(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            usuario.DV = txtDv.Text;
            usuario.Nombres = txtNombres.Text;
            usuario.ApPaterno = txtApellidoPaterno.Text;
            usuario.ApMaterno = txtApellidoMaterno.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.IdComuna = int.Parse(ddlComuna.SelectedValue);
            usuario.Telefono = int.Parse(txtTelefono.Text);
            usuario.Email = txtEmail.Text;
            usuario.IdRol = int.Parse(ddlRol.SelectedValue);
            if (!string.IsNullOrEmpty(txtPassword.Text)) usuario.PassUsuario = txtPassword.Text;

            var usuarioBo = new UsuariosBo();
            if (!string.IsNullOrEmpty(btnAgregarUsuario.CommandArgument))
            {
                usuario.RUT = int.Parse(btnAgregarUsuario.CommandArgument);
                if (usuarioBo.ActualizarUsuario(usuario) > 0)
                {
                    // Actualizado OK!
                }
                else
                {
                    // Error
                }
            }
            else
            {
                usuario.RUT = int.Parse(txtRut.Text);
                if (usuarioBo.CrearUsuario(usuario) > 0)
                {
                    // Creado OK!
                }
                else
                {
                    // Error
                }
            }
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

            ddlComuna.Items.Clear();
            ddlComuna.Items.Insert(0, seleccione);
            ddlComuna.Attributes.Add("required", "required");
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