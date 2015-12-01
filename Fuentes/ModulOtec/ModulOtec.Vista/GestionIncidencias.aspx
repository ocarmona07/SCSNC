<%@ Page Title="ModulOTEC - Control de Servicios No Conforme" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="GestionIncidencias.aspx.cs" Inherits="ModulOtec.Vista.GestionIncidencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h4>Control de Servicio No Conforme</h4>
    <ul class="nav nav-tabs">
        <li role="presentation">
            <asp:LinkButton runat="server" PostBackUrl="IngresarNoConformidad.aspx" Text="Registrar No Conformidad" /></li>
        <li role="presentation">
            <asp:LinkButton runat="server" PostBackUrl="AnalizarNoConformidad.aspx" Text="Analizar No Conformidad" /></li>
        <li role="presentation">
            <asp:LinkButton runat="server" PostBackUrl="~/RevisionCumplimiento.aspx" Text="Revisión de Cumplimiento" /></li>
    </ul>
    <br />

    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="false">
        <div class="panel panel-default">
            <div class="panel-heading" role="tab" id="headingOne">
                <h4 class="panel-title">
                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                        <span class="badge">
                            <asp:Label runat="server" ID="lblEtapaAnalisis" /></span>
                        Etapa de análisis
                    </a>
                </h4>
            </div>
            <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                <div class="panel-body">
                    <table class="table">
                        <tr>
                            <th>Cod. Incidencia</th>
                            <th>Fecha Identificación</th>
                            <th>Área Afectada</th>
                            <th>Detalle Incidencia</th>
                            <th>Acciones</th>
                        </tr>
                    </table>
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
                    <table class="table">
                        <tr>
                            <th>Cod. Incidencia</th>
                            <th>Fecha Identificación</th>
                            <th>Área Afectada</th>
                            <th>Detalle Incidencia</th>
                            <th>Acciones</th>
                        </tr>
                    </table>
                </div>
                </div>
            </div>
        </div>
        <div class="panel panel-success">
            <div class="panel-heading" role="tab" id="headingThree">
                <h4 class="panel-title">
                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                        <span class="badge">
                            <asp:Label runat="server" ID="lblIncidenciasSolucionadas" /></span>
                        Incidencias solucionadas
                    </a>
                </h4>
            </div>
            <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                <div class="panel-body">
                    <table class="table">
                        <tr>
                            <th>Cod. Incidencia</th>
                            <th>Fecha Identificación</th>
                            <th>Área Afectada</th>
                            <th>Detalle Incidencia</th>
                            <th>Acciones</th>
                        </tr>
                    </table>                </div>
            </div>
        </div>
</asp:Content>
