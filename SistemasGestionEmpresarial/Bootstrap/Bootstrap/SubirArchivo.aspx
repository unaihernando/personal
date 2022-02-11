<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SubirArchivo.aspx.vb" Inherits="Bootstrap.SubirArchivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 338px;
        }
    </style>
</head>
<body style="height: 373px">
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Subir Archivo" />
        <br />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" Height="30px" Text="Subir Archivo Limitado" />
    </form>
</body>
</html>
