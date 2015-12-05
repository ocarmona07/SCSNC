<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="ModulOtec.Vista.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Ingresar Nuevo Usuario</h4>
    <hr/>
    <form>
        <div class="form-group">
            <label for="txtRut">RUT: </label>
            <asp:TextBox ID="txtRut" runat="server" min="1" max="99999999" required="required" type="number" Width="100"></asp:TextBox>
            -<asp:TextBox ID="txtDv" runat="server" MaxLength="1" required="required" Width="20"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtNombres">Nombres: </label>
            <asp:TextBox ID="txtNombres" runat="server" required="required"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtApellidoPaterno">Apellido Paterno: </label>
            <asp:TextBox ID="txtApellidoPaterno" runat="server" required="required"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtApellidoMaterno">Apellido Materno: </label>
            <asp:TextBox ID="txtApellidoMaterno" runat="server" required="required"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDireccion">Dirección: </label>
            <asp:TextBox ID="txtDireccion" runat="server" required="required"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="ddlComuna">Comuna</label>
            <asp:DropDownList runat="server" ID="ddlComuna" required="required"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="txtTelefono">Teléfono: </label>
            <asp:TextBox ID="txtTelefono" runat="server" required="required" type="number"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEmail">Email: </label>
            <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
            <asp:RegularExpressionValidator ID="REV_Email" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <label for="ddlRol">Rol de Acceso: </label>
            <asp:DropDownList runat="server" ID="ddlRol" required="required"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="txtPassword">Password: </label>
            <asp:TextBox runat="server" ID="txtPassword" type="password" required="required"></asp:TextBox>
        </div>
        <div class="form-group">
        <button type="reset" class="btn btn-danger">Cancelar</button>
        <button type="submit" class="btn btn-success">Agregar Usuario</button>
        </div>
    </form>
</asp:Content>
