<%@ Page Title="ModulOtec - Ingresar No Conformidad" Language="C#" MasterPageFile="~/Principal.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="IngresarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.IngresarNoConformidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript">
    function confirmation() {
        if (confirm("Está seguro que desea cancelar la operación?")) {
            window.location.href = "GestionIncidencias.aspx";
        }
        else {
            return false;
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h4>Ingresar No Conformidad</h4>
    <hr />
    <form role="form" class="form-horizontal">
        <div class="form-group">
            <label for="ddlTipoConformidad">Tipo de incidencia</label>
            <asp:DropDownList runat="server" ID="ddlTipoConformidad" CssClass="form-control" required="required"/>
        </div>
        <div class="form-group">
            <label for="ddlModoDeteccion">Modo de detección</label>
            <asp:DropDownList runat="server" ID="ddlModoDeteccion" CssClass="form-control" required="required"/>
        </div>
        <div class="form-group">
            <label for="tbFechaIdent">Fecha de identificación</label>
            <asp:TextBox runat="server" ID="tbFechaIdent" type="date" CssClass="form-control" required="required" />
        </div>
        <div class="form-group">
            <label for="txtAreaAfectada">Área afectada:</label>
            <asp:TextBox runat="server" ID="txtAreaAfectada" CssClass="form-control" required="required" />
        </div>
        <div class="form-group">
            <label for="txtProcesoAfectado">Proceso afectado:</label>
            <asp:TextBox runat="server" ID="txtProcesoAfectado" CssClass="form-control" required="required" />
        </div>
        <br />
        <div class="form-group">
            <label for="tbDescripcion">Descripción de la No Conformidad</label>
            <asp:TextBox runat="server" ID="tbDescripcion" TextMode="MultiLine" CssClass="form-control" Rows="4" required="required" />
        </div>
        <asp:button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-danger" OnClientClick="return confirmation();"></asp:button>
        <asp:button runat="server" ID="btnIngresar" Text="Ingresar" CssClass="btn btn-primary"></asp:button>
    </form>
</asp:Content>
