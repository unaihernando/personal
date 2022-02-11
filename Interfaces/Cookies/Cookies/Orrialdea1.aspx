<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Orrialdea1.aspx.vb" Inherits="Cookies.Orrialdea1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 238px">
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            Idatzi zure izena:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Aplikazioaren balorea:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cookie-a gorde" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cookie-a berreskuratu" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Hurrengo orrialdea" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
