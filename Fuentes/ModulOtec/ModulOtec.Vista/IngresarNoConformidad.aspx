<%@ Page Title="ModulOtec - Ingresar No Conformidad" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.IngresarNoConformidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h4>Ingresar No Conformidad</h4>
    <hr />
    <form role="form" class="form-horizontal">
        <div class="form-group">
            <label for="ddlTipoConformidad">Tipo de incidencia</label>
            <asp:DropDownList runat="server" ID="ddlTipoConformidad" CssClass="form-control" />
        </div>
        <div class="form-group">
            <label for="ddlModoDeteccion">Modo de detección</label>
            <asp:DropDownList runat="server" ID="ddlModoDeteccion" CssClass="form-control" />
        </div>
        <div class="form-group">
            <label for="tbFechaIdent">Fecha de identificación</label>
            <asp:TextBox runat="server" ID="tbFechaIdent" type="date" CssClass="form-control" required="required" />
        </div>
        <br />
        <div class="form-group">
            <label for="tbDescripcion">Descripción de la No Conformidad</label>
            <asp:TextBox runat="server" ID="tbDescripcion" TextMode="MultiLine" CssClass="form-control" Rows="4" required="required" />
        </div>

        <button type="submit" class="btn btn-default">Ingresar</button>
    </form>
</asp:Content>
