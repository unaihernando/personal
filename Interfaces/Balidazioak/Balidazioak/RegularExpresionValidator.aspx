<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegularExpresionValidator.aspx.vb" Inherits="Balidazioak.RegularExpresionValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 410px">
            Balorea (digitu-digitu)<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Sartu ezazu digitu-digitu" SetFocusOnError="True" ValidationExpression="[0-9]-[0-9]"></asp:RegularExpressionValidator>
            <br />
            <br />
            Balorea (digitu-digitu)<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Sartu ezazu digitu-digitu" SetFocusOnError="True" ValidationExpression="\d{2}-\d{2}"></asp:RegularExpressionValidator>
            <br />
            <br />
            2000-2029<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Balidazio errorea" SetFocusOnError="True" ValidationExpression="20[0-2][0-9]"></asp:RegularExpressionValidator>
        </div>
    </form>
</body>
</html>
