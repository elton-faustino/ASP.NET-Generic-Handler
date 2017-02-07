<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="handler.ui.Forms.Cliente.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="../../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../../Handlers/ClienteHandler.js"></script>
</head>
<body onload="cliente.init()">
    <form id="form1" runat="server">
    <div>
        <input type="button" id="cliCadastrar" value="Enviar" onclick="cliente.cadastrar()"/>
    </div>
    </form>
</body>
</html>
