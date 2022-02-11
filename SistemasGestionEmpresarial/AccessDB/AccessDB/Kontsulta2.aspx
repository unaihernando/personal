<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Kontsulta2.aspx.vb" Inherits="AccessDB.Kontsulta2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 482px">
    <form id="form1" runat="server">
        <asp:Label ID="lblPais" runat="server" Text="Pais"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Country" DataValueField="Country">
        </asp:DropDownList>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [Country] FROM [Customers]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="lblCiudad" runat="server" Text="Ciudad empieza por"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers] WHERE (([Country] LIKE '%' + ? + '%') AND ([City] LIKE '%' + ? + '%'))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="TextBox1" Name="City" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
