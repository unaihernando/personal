<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Calendario.aspx.vb" Inherits="Bootstrap.Calendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 497px">
            <asp:Calendar ID="Calendar1" runat="server" BackColor ="YellowGreen" BorderColor="Tomato"></asp:Calendar>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
