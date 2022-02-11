<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Orrialdea2.aspx.vb" Inherits="Cookies.Orrialdea2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 285px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Aplikazaioko aldagaiaren balorea:"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Sesioaren aldagaiaren balorea:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Aurreko orrialdea" />
    </form>
</body>
</html>
