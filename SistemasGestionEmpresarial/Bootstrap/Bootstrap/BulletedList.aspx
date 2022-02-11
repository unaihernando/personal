<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BulletedList.aspx.vb" Inherits="Bootstrap.BulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="1">Lehena</asp:ListItem>
            <asp:ListItem Value="2">Bigarrena</asp:ListItem>
            <asp:ListItem Value="3">Hirugarrena</asp:ListItem>
            <asp:ListItem Value="4">Laugarrena</asp:ListItem>
            <asp:ListItem Value="5">Bostgarrena</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Bertikala/Horizontala" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
    </form>
</body>
</html>
