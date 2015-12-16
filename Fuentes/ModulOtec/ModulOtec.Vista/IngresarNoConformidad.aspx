<%@ Page Title="ModulOtec - Ingresar No Conformidad" Language="C#" MasterPageFile="~/Principal.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="IngresarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.IngresarNoConformidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Cancelar() {
            if (confirm("¿Está seguro que desea cancelar la operación?")) {
                window.location.href = "GestionIncidencias.aspx";
                return true;
            }
            else {
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:ScriptManager runat="server" />
    <h4>Ingresar No Conformidad</h4>
    <hr />
    <form role="form" class="form-horizontal">
        <div class="form-group">
            <label for="ddlTipoConformidad">Tipo de incidencia:</label>
            <asp:DropDownList runat="server" ID="ddlTipoConformidad" CssClass="form-control" required="required" />
        </div>
        <div class="form-group">
            <label for="ddlModoDeteccion">Modo de detección:</label>
            <asp:DropDownList runat="server" ID="ddlModoDeteccion" CssClass="form-control" required="required" />
        </div>
        <div class="form-group">
            <label for="txtFechaIdent">Fecha de identificación:</label>
            <asp:TextBox runat="server" ID="txtFechaIdent" type="date" CssClass="form-control" required="required" />
        </div>
        <div class="form-group">
            <label for="txtAreaAfectada">Área afectada:</label>
            <asp:TextBox runat="server" ID="txtAreaAfectada" CssClass="form-control" MaxLength="150" required="required" />
        </div>
        <div class="form-group">
            <label for="txtProcesoAfectado">Proceso afectado:</label>
            <asp:TextBox runat="server" ID="txtProcesoAfectado" CssClass="form-control" MaxLength="150" required="required" />
        </div>
        <br />
        <div class="form-group">
            <label for="txtDescripcion">Descripción de la No Conformidad:</label>
            <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control" Rows="4" required="required" />
        </div>
        <div class="form-group">
            <div class="col-md-3"></div>
            <button type="button" class="btn btn-danger col-md-2" onclick="return Cancelar();">Cancelar</button>
            <div class="col-md-1"></div>
            <asp:Button runat="server" ID="btnIngresar" CssClass="btn btn-primary col-md-2" OnClick="IngresarIncidencia" Text="Ingresar" />
        </div>
        <br />
        <br />
        <br />
    </form>
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
                            <a href="GestionIncidencias.aspx" class="btn btn-primary">Aceptar</a>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
