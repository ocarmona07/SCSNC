<%@  Language="C#" AutoEventWireup="true" CodeBehind="IngresarNoConformidadExterno.aspx.cs" EnableEventValidation="false" Inherits="ModulOtec.Vista.IngresarNoConformidadExterno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ModulOTEC</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/modulotec.css" rel="stylesheet" type="text/css" />
    <script src="/js/jquery-1.11.3.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
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
</head>
<body>
    <form runat="server" id="frmMain">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <asp:LinkButton runat="server" CssClass="navbar-brand" PostBackUrl="Index.aspx">
                        <span class="brand1">MODUL</span><span class="brand2">OTEC</span>
                    </asp:LinkButton>
                </div>
            </div>
        </nav>
        <div class="container">
            <asp:ScriptManager runat="server" />
            <h4>Ingresar No Conformidad</h4>
            <hr />
            <form role="form" class="form-horizontal">
                <div class="form-group">
                    <label for="txtRutExterno">Rut:</label>
                    <asp:TextBox runat="server" ID="txtRutExterno" CssClass="form-control" required="required" placeholder="Ej: 12.345.678-9" />
                </div>
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
                                    <asp:Button runat="server" ID="btnModalAceptar" class="btn btn-primary" data-dismiss="modal" Text="Aceptar" />
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
