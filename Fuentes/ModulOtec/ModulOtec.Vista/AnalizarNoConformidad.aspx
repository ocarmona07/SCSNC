<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="AnalizarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.AnalizarNoConformidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function confirmation() {
            if (confirm("¿Está seguro que desea cancelar la operación?")) {
                window.location.href = "GestionIncidencias.aspx";
                return true;
            }
            else {
                return false;
            }
        }

        function AddValues() {
            var txtValue = document.getElementById("<%= txtAnadirAccion.ClientID %>");
            if (txtValue.value.trim() === "") return false;
            var listBox = document.getElementById("<%= lbxAcciones.ClientID %>");
            var option = document.createElement("OPTION");
            option.innerHTML = txtValue.value;
            option.value = txtValue.value;
            listBox.appendChild(option);
            txtValue.value = "";
            return false;
        }

        function DeleteValues() {
            var listBox = document.getElementById("<%= lbxAcciones.ClientID %>");
            for (var i = listBox.options.length - 1; i >= 0; i--) {
                if (listBox.options[i].selected) {
                    listBox.removeChild(listBox.options[i]);
                }
            }
            return false;
        }

        function ObtenerItems() {
            var items = $("#<%= lbxAcciones.ClientID %> option").map(function () { return $(this).val(); }).get().join("|");
            $("#<%= hdnItems.ClientID %>").val(items);
            return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:ScriptManager runat="server" />
    <h4>Analisis de No Conformidad</h4>
    <hr />
    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
        <div class="panel panel-default">
            <div class="panel-heading" role="tab" id="headingOne">
                <h4 class="panel-title">
                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">Información de la No Conformidad
                    </a>
                </h4>
            </div>
            <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                <div class="panel-body">
                    <p>
                        <strong>Código Servicio No Conforme:</strong>
                        <asp:Label ID="lblCodSNC" runat="server" Text="00000" />
                    </p>
                    <div class="row">
                        <div class="col-md-4">
                            <p>
                                <strong>Fecha de Ingreso:</strong>
                                <asp:Label ID="lblFechaIngreso" runat="server" Text="00/00/0000" />
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Fecha Identificación:</strong>
                                <asp:Label ID="lblFechaIdentificacion" runat="server" Text="00/00/0000" />
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Estado:</strong>
                                <asp:Label ID="lblEstado" runat="server" Text="Análisis" />
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <p>
                                <strong>Tipo de Incidencia:</strong>
                                <asp:Label ID="lblTipo" runat="server" Text="No conformidad" />
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Modo de Detección:</strong>
                                <asp:Label ID="lblModoDetect" runat="server" Text="Auditoría Interna" />
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Área afectada:</strong>
                                <asp:Label ID="lblAreaAfectada" runat="server" Text="Departamento de Finanzas" />
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p class="vertical-align"><strong>Detalle de la No Conformidad:</strong></p>
                            <asp:TextBox runat="server" ID="txtDetalle" CssClass="form-control" BackColor="white" ForeColor="black" TextMode="MultiLine" Width="100%" Rows="5" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading" role="tab" id="headingTwo">
                <h4 class="panel-title">
                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">Análisis de las Causas
                    </a>
                </h4>
            </div>
            <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-4">
                            <p><strong>Causas de No Conformidad:</strong></p>
                            <asp:TextBox ID="txtCausas" runat="server" CssClass="form-control" TextMode="MultiLine" Width="100%" Rows="5" required="required" />
                        </div>
                        <div class="col-md-4">
                            <p><strong>Efectos deseados al finalizar el proceso:</strong></p>
                            <asp:TextBox ID="txtEfectosDeseados" runat="server" CssClass="form-control" TextMode="MultiLine" Width="100%" Rows="5" required="required" />
                        </div>
                        <div class="col-md-4">
                            <p><strong>Acciones Correctivas:</strong></p>
                            <p>
                                <asp:TextBox ID="txtAnadirAccion" runat="server" CssClass="col-md-8" />&nbsp;
                                <asp:Button ID="btnAnadirAccion" runat="server" Text="Añadir" CssClass="btn btn-success btn-xs" formnovalidate OnClientClick="return AddValues();" />
                                <asp:Button ID="btnQuitarAccion" runat="server" Text="Quitar" CssClass="btn btn-danger btn-xs" formnovalidate OnClientClick="return DeleteValues();" />
                            </p>
                            <asp:HiddenField runat="server" ID="hdnItems" />
                            <asp:ListBox ID="lbxAcciones" runat="server" CssClass="form-control" EnableViewState="True" />
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-6">
                            <strong>Expediente electrónico:</strong>
                            <asp:GridView runat="server" ID="gvDocumentos" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="False" OnRowCommand="DocumentosOnRowCommand"
                                EmptyDataText="No existen archivos registrados" ShowHeaderWhenEmpty="True" AllowPaging="True" PageSize="5">
                                <Columns>
                                    <asp:BoundField DataField="RutaDocumento" HeaderText="Nombre del Archivo" />
                                    <asp:TemplateField HeaderText="Acciones">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" CssClass="glyphicon glyphicon-download-alt" formnovalidate CommandName="Descargar" ToolTip="Descargar Archivo" CommandArgument='<%# Eval("RutaDocumento") %>' />
                                            <asp:LinkButton runat="server" CssClass="glyphicon glyphicon-remove" formnovalidate CommandName="Quitar" ToolTip="Eliminar Archivo" CommandArgument='<%# Eval("IdDocumento") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerSettings Mode="NextPrevious" PreviousPageText="Atrás" NextPageText="Siguiente" />
                            </asp:GridView>
                            <div class="row">
                                <div class="col-md-8">
                                    <asp:FileUpload runat="server" ID="fupDocumentos" CssClass="btn btn-default" />
                                </div>
                                <div class="col-md-4">
                                    <asp:Button runat="server" Text="Añadir Archivo" ID="btnSubirArchivo" formnovalidate class="btn btn-success" OnClick="SubirArchivo" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <p><strong>Fecha Límite:</strong></p>
                            <asp:TextBox ID="txtFechaLimite" runat="server" CssClass="form-control" type="date" required="required" />
                        </div>
                        <div class="col-md-3">
                            <p><strong>Tratamiento:</strong></p>
                            <asp:DropDownList ID="ddlTratamiento" runat="server" CssClass="form-control" required="required" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-6 col-sm-4 text-right">
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" formnovalidate OnClientClick="return confirmation();" />
        </div>
        <div class="col-xs-6 col-sm-4 text-center">
            <asp:Button ID="btnInvalidar" runat="server" Text="Invalidar" CssClass="btn btn-danger" />
        </div>
        <div class="col-xs-6 col-sm-4 text-left">
            <asp:Button ID="btnIngresarAcciones" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClientClick="return ObtenerItems();" OnClick="IngresarAnalisis" />
        </div>
    </div>
    <div id="modalAlerta" class="modal fade" tabindex="-1" role="dialog">
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
                            <asp:Button ID="btnModalAceptar" runat="server" CssClass="btn btn-primary" data-dismiss="modal" Text="Aceptar" />
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
