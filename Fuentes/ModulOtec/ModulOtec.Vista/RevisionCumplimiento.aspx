<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RevisionCumplimiento.aspx.cs" Inherits="ModulOtec.Vista.SeguimientoIncidencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Seguimiento de Incidencias</h4>
    <hr />
    <div class="row">
        <div class="col-md-4">
            <div class="panel panel-default">
            <div class="panel-heading" role="tab" id="headingOne">
                <h4 class="panel-title">
                    Información de la No Conformidad
                </h4>
            </div>
        <div class="panel-body">
            <!-- Área de desglose de la no conformidad ingresada desde "IngresarNoConformidad" -->
                <p>
                    <strong>Código Servicio No Conforme:</strong>
                    <asp:Label ID="lblCodSNC" runat="server" Text="SNC0000"></asp:Label>
                </p>
                <div class="row">
                    <div class="col-md-4">
                        <p>
                            <strong>Fecha de Ingreso:</strong>
                            <asp:Label ID="lblFechaIngreso" runat="server" Text="00/00/0000"></asp:Label>
                        </p>
                    </div>
                    <div class="col-md-4">
                        <p>
                            <strong>Fecha Identificación:</strong>
                            <asp:Label ID="lblFechaIdentificacion" runat="server" Text="00/00/0000"></asp:Label>
                        </p>
                    </div>
                    <div class="col-md-4">
                        <p>
                            <strong>Estado:</strong>
                            <asp:Label ID="lblEstado" runat="server" Text="Análisis"></asp:Label>
                        </p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <p>
                            <strong>Tipo:</strong>
                            <asp:Label ID="lblTipo" runat="server" Text="No conformidad"></asp:Label>
                        </p>
                    </div>
                    <div class="col-md-4">
                        <p>
                            <strong>Modo de Detección:</strong>
                            <asp:Label ID="lblModoDetect" runat="server" Text="Auditoría Interna"></asp:Label>
                        </p>
                    </div>
                    <div class="col-md-4">
                        <p>
                            <strong>Área afectada:</strong>
                            <asp:Label ID="lblAreaAfectada" runat="server" Text="Departamento de Finanzas"></asp:Label>
                        </p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <p class="vertical-align"><strong>Detalle de la No Conformidad:</strong></p>
                        <asp:Label ID="lblDetalle" runat="server" Text="--"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        </div>
        <div class="col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">Acciones Correctivas</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-12">
                                <p><strong>Causas potenciales de la No Conformidad</strong>: <asp:Label ID="lblCausasPotenciales" runat="server" Text="--"></asp:Label></p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <p><strong>Efectos deseados al finalizar el proceso</strong>: <asp:Label ID="lblEfectosDeseados" runat="server" Text="--"></asp:Label></p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <p><strong>Tratamiento:</strong>: <asp:Label ID="lblTratamiento" runat="server" Text="--"></asp:Label></p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <p><strong>Fecha límite</strong>: <asp:Label ID="lblFechaLimite" runat="server" Text="00/00/000"></asp:Label></p>
                                <div class="row">
                                    <div class="col-md-6">
                                        <p>Faltan <asp:Label ID="lblDiasRestantes" runat="server" Text="6 " style="font-weight: 700"></asp:Label> Días</p>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="progress">
                                            <div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width: 40%">
                                                <span class="sr-only">Faltan 7 Días</span>
                                            </div>
                                    </div>
                                </div>

                                </div>
                            </div> <!-- Fecha y Días restantes -->
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <p><strong>Expediente electrónico:</strong></p>
                                <table class="table table-striped">
                                    <tr>
                                        <td>N°</td>
                                        <td>Descripción del Archivo</td>
                                    </tr>
                                    <tr>
                                        <td>01</td>
                                        <td>Certificado de Compromiso de Toma de Acciones</td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">

            <div class="panel panel-primary">
                <div class="panel-heading">Revisión de Cumplimiento</div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-12">
                            <p><strong>Acciones Correctivas:</strong></p>
                            <asp:CheckBoxList ID="chblAcciones" runat="server" CssClass="lift" Font-Size="Smaller" RepeatLayout="OrderedList">
                            <asp:ListItem Text="Reparación de las 4 Sillas defectuosas de la Sala" ></asp:ListItem>
                            </asp:CheckBoxList>
                            <p><strong>Observaciones:</strong></p>
                            <asp:TextBox ID="txtObservaciones" runat="server" Rows="5" width="100%" TextMode="MultiLine"></asp:TextBox>
                            <p align="center">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger btn-sm" />
                                <asp:Button ID="btnReAnalizar" runat="server" Text="Re Análisis" CssClass="btn btn-warning btn-sm" />
                                <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" CssClass="btn btn-success btn-sm" />
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
