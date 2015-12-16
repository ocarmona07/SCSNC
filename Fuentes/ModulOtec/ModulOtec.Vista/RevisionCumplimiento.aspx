<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RevisionCumplimiento.aspx.cs" Inherits="ModulOtec.Vista.SeguimientoIncidencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:ScriptManager runat="server" />
    <h4>Seguimiento de Incidencias</h4>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading" role="tab" id="headingOne">
                    <h4 class="panel-title">Información de la No Conformidad
                    </h4>
                </div>
                <div class="panel-body">
                    <!-- Área de desglose de la no conformidad ingresada desde "IngresarNoConformidad" -->
                    <p>
                        <strong>Código Servicio No Conforme:</strong>
                        <asp:Label ID="lblCodSNC" runat="server" Text="00000"></asp:Label>
                    </p>
                    <div class="row">
                        <div class="col-md-4">
                            <p>
                                <strong>Fecha de Ingreso:</strong><br />
                                <asp:Label ID="lblFechaIngreso" runat="server" Text="00/00/0000"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Fecha Identificación:</strong><br />
                                <asp:Label ID="lblFechaIdentificacion" runat="server" Text="00/00/0000"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Estado:</strong><br />
                                <asp:Label ID="lblEstado" runat="server" Text="Análisis"></asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <p>
                                <strong>Tipo:</strong><br />
                                <asp:Label ID="lblTipo" runat="server" Text="No conformidad"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Modo de Detección:</strong><br />
                                <asp:Label ID="lblModoDetect" runat="server" Text="Auditoría Interna"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-4">
                            <p>
                                <strong>Área afectada:</strong><br />
                                <asp:Label ID="lblAreaAfectada" runat="server" Text="Departamento de Finanzas"></asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p class="vertical-align">
                                <strong>Detalle de la No Conformidad:</strong><br />
                                <asp:Label ID="lblDetalle" runat="server" Text="--"></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading">Acciones Correctivas</div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-12">
                            <p>
                                <strong>Causas potenciales de la No Conformidad:</strong>
                                <asp:Label ID="lblCausasPotenciales" runat="server" Text=""></asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p>
                                <strong>Efectos deseados al finalizar el proceso:</strong>
                                <asp:Label ID="lblEfectosDeseados" runat="server" Text="--"></asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p>
                                <strong>Tratamiento:</strong>
                                <asp:Label ID="lblTratamiento" runat="server" Text="--"></asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p>
                                <strong>Fecha límite:</strong>
                                <asp:Label ID="lblFechaLimite" runat="server" Text="00/00/000"></asp:Label>
                            </p>
                            <div class="row">
                                <div class="col-md-6">
                                    <p>
                                        Faltan
                                        <asp:Label ID="lblDiasRestantes" runat="server" Text="0" Font-Bold="True" />
                                        Días
                                    </p>
                                </div>
                                <div class="col-md-6">
                                    <div class="progress">
                                        <div runat="server" ID="divProgress" class="progress-bar progress-bar-striped" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100">
                                            <span class="sr-only">Faltan <%= lblDiasRestantes.Text %> Días</span>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <p><strong>Expediente electrónico:</strong></p>
                            <asp:GridView runat="server" ID="gvDocumentos" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="False" OnRowCommand="DocumentosOnRowCommand"
                                EmptyDataText="No existen archivos registrados" ShowHeaderWhenEmpty="True" AllowPaging="True" PageSize="5">
                                <Columns>
                                    <asp:BoundField DataField="RutaDocumento" HeaderText="Nombre del Archivo" />
                                    <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="90px" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" CssClass="glyphicon glyphicon-download-alt" formnovalidate CommandName="Descargar" ToolTip="Descargar Archivo" CommandArgument='<%# Eval("RutaDocumento") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerSettings Mode="NextPrevious" PreviousPageText="Atrás" NextPageText="Siguiente" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="panel panel-primary">
                <div class="panel-heading">Revisión de Cumplimiento</div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-12">
                            <label for="chklAcciones">Acciones Correctivas:</label>
                            <table class="table table-condensed">
                                <thead>
                                    <tr>
                                        <th style="width: 40px;">Cumple</th>
                                        <th>Acción</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBoxList ID="chklAcciones" runat="server" RepeatLayout="OrderedList" ToolTip="¿Cumple?" CssClass="checkbox" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col-md-12">
                            <label for="txtObservaciones">Observaciones Generales:</label>
                            <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control" Rows="5" TextMode="MultiLine" required="required" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger btn-md-5" formnovalidate OnClientClick="return confirm('¿Está seguro de que desea cancelar?')" OnClick="CancelarOnClick" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnReanalizar" runat="server" Text="Reanálisis" CssClass="btn btn-warning btn-md-5" formnovalidate OnClientClick="return confirm('¿Desea hacer un Reanálisis?')" OnClick="ReAnalizarOnClick" />
                        </div>
                        <div class="col-md-1"></div>
                        <div class="col-md-3">
                            <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" CssClass="btn btn-success btn-md-4" OnClick="FinalizarOnClick" />
                        </div>
                    </div>
                </div>
            </div>
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
