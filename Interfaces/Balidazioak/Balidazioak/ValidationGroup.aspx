<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ValidationGroup.aspx.vb" Inherits="Balidazioak.ValidationGroup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 333px">
    <form id="form1" runat="server">
        <div style="height: 250px">
            Izena:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Izena sartu behar duzu" ValidationGroup="group1"></asp:RequiredFieldValidator>
            <br />
            <br />
            Abizenak:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Abizena sartu behar duzu" ValidationGroup="group1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Bidali" ValidationGroup="group1" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="group1" />
        </div>
        <p style="height: 55px">
            Telefonoa:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Sartu telefonoa" ValidationGroup="group2"></asp:RequiredFieldValidator>
            <asp:Button ID="Bidali" runat="server" Text="Button" ValidationGroup="group2" />
        </p>
    </form>
</body>
</html>
