<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="SeguimientoIncidencia.aspx.cs" Inherits="ModulOtec.Vista.SeguimientoIncidencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Seguimiento de Incidencias</h4>
    <hr />
    <div class="panel panel-default">
        <div class="panel-heading">No Conformidades mes de Noviembre</div>
        <div class="panel-body">
            <table class="table">
                <tr>
                    <th>N°</th><th>Cod. Incidencia</th><th>Descripción</th><th>Días Restantes</th><th>Estado</th><th>Acción</th>
                </tr>
                <tr>
                    <td>1</td>
                    <td>SNC0000</td>
                    <td>Descripción del Servicio no Conforme</td>
                    <td>5 Días Restantes</td>
                    <td>
                        <div class="progress">
                            <div class="progress-bar progress-bar-success" style="width: 10%">
                                <span class="sr-only">10%</span>
                            </div>
                        </div>
                    </td>
                    <td>
                        <span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-envelope" aria-hidden="true"></span>
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>SNC0001</td>
                    <td>Descripción del Servicio no Conforme</td>
                    <td>3 Días Restantes</td>
                    <td>
                        <div class="progress">
                            <div class="progress-bar progress-bar-warning" style="width: 60%">
                                <span class="sr-only">60%</span>
                            </div>
                        </div>
                    </td>
                    <td>
                        <span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-envelope" aria-hidden="true"></span>
                    </td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>SNC0002</td>
                    <td>Descripción del Servicio no Conforme</td>
                    <td>1 Día Restante</td>
                    <td>
                        <div class="progress">
                            <div class="progress-bar progress-bar-danger" style="width: 90%">
                                <span class="sr-only">90%</span>
                            </div>
                        </div>
                    </td>
                    <td>
                        <span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
                        <span class="glyphicon glyphicon-envelope" aria-hidden="true"></span>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
