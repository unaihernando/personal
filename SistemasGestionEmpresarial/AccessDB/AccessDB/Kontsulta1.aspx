<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Kontsulta1.aspx.vb" Inherits="AccessDB.Kontsulta1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 403px">
            <asp:Label ID="LabelPais" runat="server" Text="Pais"></asp:Label>
            <asp:TextBox ID="TextBoxPais" runat="server"></asp:TextBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE ([Country] LIKE '%' + ? + '%')">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBoxPais" Name="Country" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1" Width="286px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <p>
&nbsp;&nbsp;
    </p>
</body>
</html>
