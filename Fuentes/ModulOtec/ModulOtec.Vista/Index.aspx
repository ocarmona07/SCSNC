<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ModulOtec.Vista.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ModulOTEC - Iniciar Sesión</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/modulotec.css" rel="stylesheet" type="text/css" />
    <script src="/js/jquery-1.11.3.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="IniciarSesion" runat="server">
        <asp:ScriptManager runat="server" />
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">

                    <asp:LinkButton runat="server" CssClass="navbar-brand" PostBackUrl="Index.aspx">
                        <span class="brand1">MODUL</span><span class="brand2">OTEC</span>
                    </asp:LinkButton>
                </div>
            </div>
        </nav>
        <div class="container">
            <%--<div class="row espacio-tabla">
                <div class="col-md-4 col-md-offset-4">
                    <asp:TextBox ID="txtOrganizacion" runat="server" PlaceHolder="Organización" CssClass="form-control"></asp:TextBox>
                </div>
            </div>--%>
            <div class="row espacio-tabla">
                <div class="col-md-4 col-md-offset-4">
                    <asp:TextBox ID="txtUsuario" runat="server" PlaceHolder="Usuario" CssClass="form-control" min="1" MaxLength="8" required="required" type="number"></asp:TextBox>
                </div>
            </div>
            <div class="row espacio-tabla">
                <div class="col-md-4 col-md-offset-4">
                    <asp:TextBox ID="txtPassword" runat="server" PlaceHolder="Password" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox>
                </div>
            </div>
            <div class="row espacio-tabla">
                <div class="col-md-4 col-md-offset-4">
                    <asp:LinkButton ID="lnkIngresar" runat="server" CssClass="btn btn-primary col-lg-12" Text="Ingresar" type="submit" OnClick="IngresarOnClick" />
                </div>
            </div>
        </div>
        <div id="modalAlerta" class="modal fade" tabindex="-1" role="dialog" data-backdrop="static">
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
                                <button type="button" class="btn btn-primary" data-dismiss="modal">Aceptar</button>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </form>
</body>
</html>
