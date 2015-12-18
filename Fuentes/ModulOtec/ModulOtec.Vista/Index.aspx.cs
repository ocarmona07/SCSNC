namespace ModulOtec.Vista
{
    using System;
    using System.Web.UI;
    using Negocio;

    /// <summary>
    /// Clase principal para ingreso
    /// </summary>
    public partial class Index : Page
    {
        /// <summary>
        /// Método que se llama al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que valida el usuario
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void IngresarOnClick(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                var usuario = new UsuariosBo().ObtenerUsuario(int.Parse(txtUsuario.Text));

                if (usuario != null && txtPassword.Text.Equals(usuario.PassUsuario))
                {
                    Session.Add("RutUsuario", usuario.RUT);
                    Session.Add("NombreUsuario",
                        string.Format("{0} {1} {2}", usuario.Nombres, usuario.ApPaterno, usuario.ApMaterno));
                    Session.Add("RolUsuario", new GeneralBo().ObtenerRol(usuario.IdRol).Descripcion);
                    Response.Redirect("~/MainModulos.aspx");
                }
                else
                {
                    lblTituloModal.Text = "Error de ingreso";
                    litDetalle.Text = "<p><b>Usuario o Contraseña no válida</b></p>";
                }

                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlerta", "$('#modalAlerta').modal();",
                    true);
                upModal.Update();
            }
        }

        protected void IngreoExternoOnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/IngresarNoConformidadExterno.aspx");
        }
    }
}