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
            <asp:LinkButton runat="server" PostBackUrl="~/SeguimientoIncidencia.aspx" Text="Seguimiento de Incidencia" /></li>
        <li role="presentation">
            <asp:LinkButton runat="server" PostBackUrl="#" ID="lnkNotificaciones" /></li>
    </ul>
    <br />
    <ul class="list-group">
        <li class="list-group-item">
            <span class="badge">
                <asp:Label runat="server" ID="lblEtapaAnalisis" /></span>
            Etapa de análisis
        </li>
        <li class="list-group-item">
            <span class="badge">
                <asp:Label runat="server" ID="lblAccionesCorrectivas" /></span>
            Acciones correctivas
        </li>
        <li class="list-group-item">
            <span class="badge">
                <asp:Label runat="server" ID="lblIncidenciasSolucionadas" /></span>
            Incidencias solucionadas
        </li>
    </ul>

    <div class="alert alert-warning" role="alert">
        <b>Recuerda!</b> El plazo de análisis y respuesta de las incidencias es de 5 días.
    </div>
</asp:Content>
