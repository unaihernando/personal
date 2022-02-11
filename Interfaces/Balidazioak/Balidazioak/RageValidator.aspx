<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RageValidator.aspx.vb" Inherits="Balidazioak.RageValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 348px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 106px">
        </div>
        Adina<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="0 eta 90 artean egon behar da" MaximumValue="90" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        Adina 0 eta 90 artean egon behar da<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
