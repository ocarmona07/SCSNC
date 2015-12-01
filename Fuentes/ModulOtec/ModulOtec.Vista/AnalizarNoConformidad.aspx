<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AnalizarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.AnalizarNoConformidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
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
                            <asp:TextBox ID="txtDetalle" TextMode="MultiLine" Width="100%" Rows="5" runat="server" ReadOnly="True"></asp:TextBox>
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
                            <p><strong>Acciones Correctivas:</strong></p>
                            <p><asp:TextBox ID="txtAnadirAccion" runat="server"></asp:TextBox> <asp:Button ID="btnAnadirAccion" runat="server" Text="Añadir" class="btn btn-success btn-xs"/> <asp:Button ID="btnQuitarAccion" runat="server" Text="Quitar" class="btn btn-danger btn-xs"/></p>
                            <asp:ListBox ID="ltbAcciones" runat="server">
                                <asp:ListItem>Reparación de las 4 Sillas defectuosas de la Sala</asp:ListItem>
                            </asp:ListBox>
                        </div>
                        <div class="col-md-4">
                            <p><strong>Efectos deseados al finalizar el proceso:</strong></p>
                            <asp:TextBox ID="txtEfectosDeseados" TextMode="multiline" Width="100%" Rows="5" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <p><strong>Causas Potenciales:</strong></p>
                            <asp:TextBox ID="txtCausasPotenciales" TextMode="multiline" Width="100%" Rows="5" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">

                        <div class="col-md-3">
                            <p><strong>Tratamiento:</strong></p>
                            <asp:DropDownList ID="ddlTratamiento" runat="server">
                                <asp:ListItem>Reproceso</asp:ListItem>
                                <asp:ListItem>Reclasificación</asp:ListItem>
                                <asp:ListItem>Concesión</asp:ListItem>
                                <asp:ListItem>Desecho</asp:ListItem>
                                <asp:ListItem>Permiso de Desviación</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <p><strong>Fecha Límite:</strong></p>
                            <asp:TextBox ID="tbFechaLimite" runat="server" type="date" />
                        </div>
                        <div class="col-md-6">
                            <strong>Expediente electrónico</strong>
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
                            <div class="row">
                                <div class="col-md-7">
                                    <asp:FileUpload runat="server" ID="fileUpload1" Multiple="Multiple" CssClass="btn btn-default"></asp:FileUpload>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button runat="server" Text="Añadir Archivos" ID="uploadBtn" class="btn btn-success" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 text-center">
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-warning" />

            <asp:Button ID="btnInvalidar" runat="server" Text="Invalidar" class="btn btn-danger" />

            <asp:Button ID="btnIngresarAcciones" runat="server" Text="Ingresar" class="btn btn-success" />
        </div>
    </div>






</asp:Content>
