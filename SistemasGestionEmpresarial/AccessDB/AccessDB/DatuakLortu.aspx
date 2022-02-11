<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DatuakLortu.aspx.vb" Inherits="AccessDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 535px;
        }
    </style>
</head>
<body style="height: 235px">
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [ContactName] FROM [Customers]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ContactName" DataValueField="ContactName" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="City" DataValueField="City" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT [City] FROM [Customers] WHERE ([ContactName] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="ContactName" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplierID" DataSourceID="SqlDataSource3" Width="358px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:ButtonField Text="Botón" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT [SupplierID], [Address], [Phone] FROM [Suppliers] WHERE ([City] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="City" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>