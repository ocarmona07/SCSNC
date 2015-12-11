<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="ModulOtec.Vista.WebForm1" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Ingresar Nuevo Usuario</h4>
    <hr/>
    <form>
        <table class="espacio-tabla">
            <tbody>
                <tr>
                    <td>
                        <label for="txtRut">RUT: </label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtRut" runat="server" min="1" MaxLength="8" required="required" Width="100"></asp:TextBox>
                        - 
                        <asp:TextBox ID="txtDv" runat="server" MaxLength="1" required="required" pattern="[0-9kK]" Width="20"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularRUT" runat="server" ErrorMessage="Sólo Números" ValidationExpression="\d*" ControlToValidate="txtRut"></asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtNombres">Nombres: </label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtNombres" runat="server" required="required"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtApellidoPaterno">Apellido Paterno: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellidoPaterno" runat="server" required="required"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtApellidoMaterno">Apellido Materno: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellidoMaterno" runat="server" required="required"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtDireccion">Dirección: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDireccion" runat="server" required="required"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="ddlRegion">Región</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlRegion" required="required" AutoPostBack="True" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="ddlProvincia">Provincia</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlProvincia" required="required" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="ddlComuna">Comuna</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlComuna" required="required"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtTelefono">Teléfono: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefono" runat="server" required="required" type="number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtEmail">Email: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="REV_Email" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="ddlRol">Rol de Acceso: </label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlRol" required="required"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtPassword">Password: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtPassword" type="password" required="required"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <button type="reset" class="btn btn-danger">Cancelar</button>
                        <asp:button runat="server" ID="AgregarUsuario" Text="Agregar Usuario" type="submit" CssClass="btn btn-success" OnClick="AgregarUsuario_Click"></asp:button>
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</asp:Content>
