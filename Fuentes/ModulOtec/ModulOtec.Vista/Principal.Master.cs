﻿namespace ModulOtec.Vista
{
    using System;

    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["RutUsuario"] + ""))
            {
                CerrarSesion(sender, e);
            }

            if (IsPostBack) return;

            lblUsuario.Text = Session["NombreUsuario"] + "";
            lblCargo.Text = Session["RolUsuario"] + "";
        }

        protected void CerrarSesion(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Index.aspx");
        }

        protected void ActualizarUsuario(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarUsuario.aspx?RutUsuario=" + Session["RutUsuario"]);
        }
    }
}