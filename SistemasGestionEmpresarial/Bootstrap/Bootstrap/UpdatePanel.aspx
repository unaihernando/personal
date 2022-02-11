<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdatePanel.aspx.vb" Inherits="Bootstrap.UpdatePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 480px">

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="UpdatePanel kanpoko botoia" />
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label2" runat="server" Text="UpdatePanel barruan dagoena"></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <asp:Button ID="Button2" runat="server" Text="UpdatePanel barruko botoia" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        </asp:UpdatePanel>
    </form>
</body>
</html>
