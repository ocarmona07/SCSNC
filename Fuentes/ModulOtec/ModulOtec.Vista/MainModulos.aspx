<%@ Page Title="ModulOTEC - Menú Principal" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MainModulos.aspx.cs" Inherits="ModulOtec.Vista.MainModulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h3>Módulos</h3>
    <div class="row">
        <div class="col-sm-6 col-md-2">
            <div class="thumbnail text-center">
                <asp:Image runat="server" ImageUrl="/images/csnc.png" AlternateText="Control de Servicio No Conforme" />
                <div class="caption">
                    <h4>Control de Servicio no conforme</h4>
                    <p>
                        <asp:LinkButton runat="server" PostBackUrl="GestionIncidencias.aspx" CssClass="btn btn-primary" Text="Ingresar" />
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
