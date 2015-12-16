<%@ Page Title="ModulOTEC - Control de Servicios No Conforme" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="GestionIncidencias.aspx.cs" Inherits="ModulOtec.Vista.GestionIncidencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h4>Control de Servicio No Conforme</h4>
    <ul class="nav nav-tabs">
        <li role="presentation">
            <asp:LinkButton runat="server" PostBackUrl="IngresarNoConformidad.aspx" Text="Registrar No Conformidad" /></li>
    </ul>
    <br />

    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="false">
        <div class="panel panel-default">
            <div class="panel-heading" role="tab" id="headingOne">
                <h4 class="panel-title">
                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                        <span class="badge">
                            <asp:Label runat="server" ID="lblEtapaAnalisis" /></span>
                        <span>Etapa de análisis</span>
                    </a>
                </h4>
            </div>
            <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                <div class="panel-body">
                    <asp:GridView runat="server" ID="gvEtapaAnalisis" CssClass="table table-striped table-hover" GridLines="None" AutoGenerateColumns="False"
                        OnRowCommand="EtapaAnalisisOnRowCommand" EmptyDataText="No hay incidencias por analizar" ShowHeaderWhenEmpty="True">
                        <Columns>
                            <asp:BoundField DataField="IdIncidencia" DataFormatString="{0:00000}" HeaderText="Cod. Incidencia" />
                            <asp:BoundField DataField="FechaIdentificacion" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Fecha Identificación" />
                            <asp:BoundField DataField="AreaAfectada" HeaderText="Área Afectada" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Detalle Incidencia" />
                            <asp:TemplateField HeaderText="Acciones" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" CssClass="glyphicon glyphicon-list-alt" ToolTip="Analizar" CommandName="Analizar" CommandArgument='<%# Eval("IdIncidencia") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-heading" role="tab" id="headingTwo">
                <h4 class="panel-title">
                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                        <span class="badge">
                            <asp:Label runat="server" ID="lblAccionesCorrectivas" /></span>
                        Etapa de evaluación de cumplimiento de acciones
                    </a>
                </h4>
            </div>
            <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                <div class="panel-body">
                    <asp:GridView runat="server" ID="gvEtapaEvaluacion" CssClass="table table-striped table-hover" GridLines="None" AutoGenerateColumns="False"
                        OnRowCommand="EtapaEvaluacionOnRowCommandOnRowCommand" EmptyDataText="No existen incidencias por revisar" ShowHeaderWhenEmpty="True">
                        <Columns>
                            <asp:BoundField DataField="IdIncidencia" DataFormatString="{0:00000}" HeaderText="Cod. Incidencia" />
                            <asp:BoundField DataField="FechaIdentificacion" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Fecha Identificación" />
                            <asp:BoundField DataField="AreaAfectada" HeaderText="Área Afectada" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Detalle Incidencia" />
                            <asp:TemplateField HeaderText="Acciones" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" CssClass="glyphicon glyphicon-list-alt" ToolTip="Evaluar" CommandName="Evaluar" CommandArgument='<%# Eval("IdIncidencia") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="panel panel-success">
            <div class="panel-heading" role="tab" id="headingThree">
                <h4 class="panel-title">
                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                        <span class="badge">
                            <asp:Label runat="server" ID="lblTotalIncidencias" /></span>
                        Total Incidencias
                    </a>
                </h4>
            </div>
            <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                <div class="panel-body">
                    <asp:GridView runat="server" ID="gvTotalIncidencias" CssClass="table table-striped table-hover" GridLines="None" AutoGenerateColumns="False"
                        EmptyDataText="No existen incidencias" ShowHeaderWhenEmpty="True" OnRowDataBound="TotalIncidenciasOnDataBound">
                        <Columns>
                            <asp:BoundField DataField="IdIncidencia" DataFormatString="{0:00000}" HeaderText="Cod. Incidencia" />
                            <asp:BoundField DataField="FechaIdentificacion" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Fecha Identificación" />
                            <asp:BoundField DataField="AreaAfectada" HeaderText="Área Afectada" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Detalle Incidencia" />
                            <asp:TemplateField HeaderText="Estado" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="txtEstadoIncidencia" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
