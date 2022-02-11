<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Images.aspx.vb" Inherits="Bootstrap.Images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 159px;
            width: 998px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 352px">
            <asp:Image ID="Image1" runat="server" Height="220px" ImageUrl ="~/Images/1625238302722.jpg" Width="303px" />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack ="True">
                <asp:ListItem Value="1625238302722.jpg">Hasbulla1</asp:ListItem>
                <asp:ListItem Value="VXIQMR5OGNMP5C7F7G5KSRHJ7Y.jpg">Hasbulla2</asp:ListItem>
                <asp:ListItem Value="1690d8dd-090b-42b7-b66f-4e8f2faa84cd_source-aspect-ratio_default_0.jpg">Hasbulla3</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
