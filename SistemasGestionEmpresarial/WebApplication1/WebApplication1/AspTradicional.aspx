<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AspTradicional.aspx.vb" Inherits="WebApplication1.AspTradicional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ASP Tradicional</h1>
            <%For x = 1 To 6 %>
            <h<%=x%>> Ongi Etorri</h<%=x %>>
            <%Next%>
        </div>
    </form>
</body>
</html>
