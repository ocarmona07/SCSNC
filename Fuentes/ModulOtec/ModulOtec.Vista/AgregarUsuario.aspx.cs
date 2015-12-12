namespace ModulOtec.Vista
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Negocio;
    using Entidades;

    /// <summary>
    /// Clase principal para Agregar o Modificar un Usuario
    /// </summary>
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private readonly ListItem _seleccione = new ListItem("Seleccione una opción...", "");

        /// <summary>
        /// Método que se llama al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            #region Lista Regiones

            var generalBo = new GeneralBo();

            ddlRegion.DataSource = generalBo.ObtenerRegiones();
            ddlRegion.DataTextField = generalBo.Text;
            ddlRegion.DataValueField = generalBo.Value;
            ddlRegion.DataBind();

            ddlRegion.Items.Insert(0, _seleccione);
            ddlRegion.Attributes.Add("required", "required");
            ddlProvincia.Items.Insert(0, _seleccione);
            ddlProvincia.Attributes.Add("required", "required");
            ddlComuna.Items.Insert(0, _seleccione);
            ddlComuna.Attributes.Add("required", "required");

            #endregion

            #region Lista Roles

            ddlRol.DataSource = generalBo.ObtenerRoles();
            ddlRol.DataTextField = generalBo.Text;
            ddlRol.DataValueField = generalBo.Value;
            ddlRol.DataBind();

            ddlRol.Items.Insert(0, _seleccione);
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
                    txtTelefono.Text = usuario.Telefono + "";
                    txtEmail.Text = usuario.Email;
                    ddlRol.SelectedValue = usuario.IdRol.ToString();

                    var idProvincia = new GeneralBo().ObtenerComunas().First(o => usuario.IdComuna.Equals(o.IdComuna)).IdProvincia;
                    var idRegion = new GeneralBo().ObtenerProvincias().First(o => idProvincia.Equals(o.IdProvincia)).IdRegion;
                    ddlRegion.SelectedValue = idRegion + "";
                    RegionSelectedIndexChanged(null, null);
                    ddlProvincia.SelectedValue = idProvincia + "";
                    ProvinciaSelectedIndexChanged(null, null);
                    ddlComuna.SelectedValue = usuario.IdComuna + "";
                }
                else
                {
                    lblTituloModal.Text = "Usuario no encontrado";
                    litDetalle.Text = "<p><b>Ha ocurrido un error al buscar el usuario</b></p>";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalIngresar", "$('#modalIngresar').modal();", true);
                    upModal.Update();
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
            var usuarioBo = new UsuariosBo();
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

            if (!string.IsNullOrEmpty(btnAgregarUsuario.CommandArgument))
            {
                usuario.RUT = int.Parse(btnAgregarUsuario.CommandArgument);
                if (usuarioBo.ActualizarUsuario(usuario) > 0)
                {
                    Session.Add("NombreUsuario", string.Format("{0} {1} {2}", usuario.Nombres, usuario.ApPaterno, usuario.ApMaterno));
                    Session.Add("RolUsuario", new GeneralBo().ObtenerRol(usuario.IdRol).Descripcion);
                    lblTituloModal.Text = "Actualizado correctamente";
                    var detalle = "<p>Se ha actualizado el usuario RUT <b>" + usuario.RUT + "-" + usuario.DV.ToUpper() + "</b>.</p>";
                    litDetalle.Text = detalle;
                }
                else
                {
                    lblTituloModal.Text = "Error al actualizar";
                    litDetalle.Text = "<p><b>Ha ocurrido un error al actualizar el usuario ó no se han realizado modificaciones</b></p>";
                }
            }
            else
            {
                usuario.RUT = int.Parse(txtRut.Text);
                if (usuarioBo.CrearUsuario(usuario) > 0)
                {
                    lblTituloModal.Text = "Guardado correctamente";
                    var detalle = "<p>Se ha creado al usuario RUT <b>" + usuario.RUT + "-" + usuario.DV.ToUpper() + "</b>.</p>";
                    litDetalle.Text = detalle;
                }
                else
                {
                    lblTituloModal.Text = "Error al guardar";
                    litDetalle.Text = "<p><b>Ha ocurrido un error al guardar</b></p>";
                }
            }

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalIngresar", "$('#modalIngresar').modal();", true);
            upModal.Update();
        }

        /// <summary>
        /// Método que se llama al cambiar una Región
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void RegionSelectedIndexChanged(object sender, EventArgs e)
        {
            ddlComuna.Items.Clear();
            ddlComuna.Items.Insert(0, _seleccione);
            ddlComuna.Attributes.Add("required", "required");

            if (string.IsNullOrEmpty(ddlRegion.SelectedValue))
            {
                ddlProvincia.Items.Clear();
                ddlProvincia.Items.Insert(0, _seleccione);
                ddlProvincia.Attributes.Add("required", "required");
                return;
            }

            var generalBo = new GeneralBo();
            ddlProvincia.DataSource = generalBo.ObtenerProvinciasPorRegion(int.Parse(ddlRegion.SelectedValue));
            ddlProvincia.DataTextField = generalBo.Text;
            ddlProvincia.DataValueField = generalBo.Value;
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, _seleccione);
            ddlProvincia.Attributes.Add("required", "required");
        }

        /// <summary>
        /// Método que se llama al cambiar una provincia
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void ProvinciaSelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlProvincia.SelectedValue))
            {
                ddlComuna.Items.Clear();
                ddlComuna.Items.Insert(0, _seleccione);
                ddlComuna.Attributes.Add("required", "required");
                return;
            }

            var generalBo = new GeneralBo();
            ddlComuna.DataSource = generalBo.ObtenerComunasPorProvincia(int.Parse(ddlProvincia.SelectedValue));
            ddlComuna.DataTextField = generalBo.Text;
            ddlComuna.DataValueField = generalBo.Value;
            ddlComuna.DataBind();

            ddlComuna.Items.Insert(0, _seleccione);
            ddlComuna.Attributes.Add("required", "required");
        }
    }
}