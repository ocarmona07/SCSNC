<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RevisionCumplimiento.aspx.cs" Inherits="ModulOtec.Vista.SeguimientoIncidencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Seguimiento de Incidencias</h4>
    <hr />
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-primary">
            <div class="panel-heading" role="tab" id="headingOne">
                <h4 class="panel-title">
                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">Información de la No Conformidad
                    </a>
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
                        <asp:TextBox ID="txtDetalle" TextMode="MultiLine" Width="100%" Rows="5" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        </div>
        <div class="col-md-6">

        </div>
    </div>
</asp:Content>
