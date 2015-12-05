﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ModulOtec.Vista.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar Sesión</title>
    <link href="/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/modulotec.css" rel="stylesheet" type="text/css" />
    <script src="/js/jquery-1.11.3.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="IniciarSesion" runat="server">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">

                    <asp:LinkButton runat="server" CssClass="navbar-brand" PostBackUrl="MainModulos.aspx">
                        <span class="brand1">MODUL</span><span class="brand2">OTEC</span>
                    </asp:LinkButton>
                </div>
            </div>
        </nav>
    <div class="container">
        <div class="row">
            <div class="col-md-12" >
                            <table align="center">
                                <tr>
                                    <td><asp:TextBox ID="txtOrganizacion" runat="server" PlaceHolder="Organización" CssClass="form-control"></asp:TextBox><br /></td>
                                </tr>
                                <tr>
                                    <td><asp:TextBox ID="txtUsuario" runat="server" PlaceHolder="Usuario" CssClass="form-control"></asp:TextBox><br /></td>
                                </tr>
                                <tr>
                                    <td><asp:TextBox ID="txtPassword" runat="server" PlaceHolder="Password" CssClass="form-control"></asp:TextBox></td>
                                </tr>
                            </table>
                </div>
            </div>

    </div>
        </form>
</body>
</html>