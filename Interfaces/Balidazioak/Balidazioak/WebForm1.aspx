<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Balidazioak.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 447px">
            <asp:Label ID="Label1" runat="server" Text="Adina"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Ezin da hutsik egon"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="0 baino handiagoa" Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
            <br />
            <br />
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Zenabaki osoa izan behar da" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
