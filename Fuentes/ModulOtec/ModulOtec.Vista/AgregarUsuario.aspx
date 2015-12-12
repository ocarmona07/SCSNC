<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="ModulOtec.Vista.AgregarUsuario" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function Cancelar() {
            if (confirm("¿Está seguro que desea cancelar la operación?")) {
                window.location.href = "MainModulos.aspx";
                return true;
            }
            else {
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:ScriptManager runat="server" />
    <h4>
        <asp:Label runat="server" ID="lblTitulo" /></h4>
    <hr />
    <table class="espacio-tabla table-responsive">
        <tbody>
            <tr>
                <td>
                    <label for="txtRut">RUT:</label>

                </td>
                <td>
                    <asp:TextBox ID="txtRut" runat="server" min="1" MaxLength="8" required="required" Width="100" />
                    <span>-</span>
                    <asp:TextBox ID="txtDv" runat="server" MaxLength="1" required="required" pattern="[0-9kK]" Width="20" />
                    <asp:RegularExpressionValidator ID="regularRUT" runat="server" ErrorMessage="Sólo Números" ValidationExpression="\d*" ControlToValidate="txtRut" />

                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtNombres">Nombres:</label>

                </td>
                <td>
                    <asp:TextBox ID="txtNombres" runat="server" required="required" />

                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtApellidoPaterno">Apellido Paterno:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellidoPaterno" runat="server" required="required" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtApellidoMaterno">Apellido Materno:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellidoMaterno" runat="server" required="required" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtDireccion">Dirección:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" required="required" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="ddlRegion">Región:</label>
                </td>
                <td>
                    <asp:UpdatePanel runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <asp:DropDownList runat="server" ID="ddlRegion" required="required" AutoPostBack="True" OnSelectedIndexChanged="RegionSelectedIndexChanged" />
                        </ContentTemplate>
                        <Triggers>
                            <asp:PostBackTrigger ControlID="ddlProvincia" />
                            <asp:PostBackTrigger ControlID="ddlComuna" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="ddlProvincia">Provincia:</label>
                </td>
                <td>
                    <asp:UpdatePanel runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <asp:DropDownList runat="server" ID="ddlProvincia" required="required" AutoPostBack="True" OnSelectedIndexChanged="ProvinciaSelectedIndexChanged" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="ddlComuna">Comuna:</label>
                </td>
                <td>
                    <asp:UpdatePanel runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <asp:DropDownList runat="server" ID="ddlComuna" required="required" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtTelefono">Teléfono:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" required="required" type="number" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtEmail">Email:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" required="required" />
                    <asp:RegularExpressionValidator ID="REV_Email" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="ddlRol">Rol de Acceso:</label>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlRol" required="required" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="txtPassword">Password:</label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" type="password" required="required" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-danger" OnClientClick="return Cancelar();" />
                    <asp:Button runat="server" ID="btnAgregarUsuario" Text="Agregar Usuario" type="submit" CssClass="btn btn-success" OnClick="AgregarUsuarioClick" />
                </td>
            </tr>
        </tbody>
    </table>
    <div id="modalIngresar" class="modal fade" tabindex="-1" role="dialog" data-backdrop="static">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">
                                <asp:Label runat="server" ID="lblTituloModal" /></h4>
                        </div>
                        <div class="modal-body">
                            <asp:Literal runat="server" ID="litDetalle" />
                        </div>
                        <div class="modal-footer">
                            <a href="MainModulos.aspx" class="btn btn-primary">Aceptar</a>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
