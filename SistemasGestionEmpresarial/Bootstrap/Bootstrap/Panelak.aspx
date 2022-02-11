<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Panelak.aspx.vb" Inherits="Bootstrap.Panelak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #form1 {
            height: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>Aukeratu erabiltzailea</asp:ListItem>
            <asp:ListItem>Administratzailea</asp:ListItem>
            <asp:ListItem>Erabiltzailea</asp:ListItem>
        </asp:DropDownList>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>
