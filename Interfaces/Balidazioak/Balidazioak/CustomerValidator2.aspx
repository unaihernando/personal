<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CustomerValidator2.aspx.vb" Inherits="Balidazioak.CustomerValidator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 231px">
            Zenbakia<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Balidazio errorea" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Zenbaki bat da, 8 digitu, 8-rekin hasten da eta 3. digitua 8 da<br />
        </div>
    </form>
</body>
</html>
