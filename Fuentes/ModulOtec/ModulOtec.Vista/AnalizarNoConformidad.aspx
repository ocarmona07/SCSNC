<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AnalizarNoConformidad.aspx.cs" Inherits="ModulOtec.Vista.AnalizarNoConformidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h4>Analisis de No Conformidad</h4>
    <hr />
    <div class="panel panel-primary">
        <div class="panel-heading">Información de la No Conformidad</div>
        <div class="panel-body">
                <!-- Área de desglose de la no conformidad ingresada desde "IngresarNoConformidad" -->
                <p><strong>Código Servicio No Conforme:</strong>
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
                    <p><strong>Fecha Identificación:</strong>
                            <asp:Label ID="lblFechaIdentificacion" runat="server" Text="00/00/0000"></asp:Label>
                    </p>
                </div>
                <div class="col-md-4">
                    <p><strong>Estado:</strong>
                            <asp:Label ID="lblEstado" runat="server" Text="Análisis"></asp:Label>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <p><strong>Tipo:</strong>
                            <asp:Label ID="lblTipo" runat="server" Text="No conformidad"></asp:Label>
                    </p>
                </div>
                <div class="col-md-4">
                    <p><strong>Modo de Detección:</strong>
                            <asp:Label ID="lblModoDetect" runat="server" Text="Auditoría Interna"></asp:Label>
                    </p>
                </div>
                <div class="col-md-4">
                    <p><strong>Área afectada:</strong>
                            <asp:Label ID="lblAreaAfectada" runat="server" Text="Departamento de Finanzas"></asp:Label>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <p class="vertical-align"><strong>Detalle de la No Conformidad:</strong></p>
                        <asp:TextBox ID="txtDetalle" TextMode="multiline" Width="100%" Rows="5" runat="server"></asp:TextBox> 
                </div>
            </div>


         </div>
    </div>








</asp:Content>
