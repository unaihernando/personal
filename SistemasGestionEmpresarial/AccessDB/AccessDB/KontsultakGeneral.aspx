<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KontsultakGeneral.aspx.vb" Inherits="AccessDB.Kontsultak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 846px">
    <form id="form1" runat="server">
        <div style="height: 755px">
            Herrialdea:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Country" DataValueField="Country">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [Country] FROM [Customers]"></asp:SqlDataSource>
            Hiria:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="City" DataValueField="City">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [City] FROM [Customers] WHERE ([Country] = ?)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Country" HeaderText="Country" HtmlEncode="False" SortExpression="Country" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" HtmlEncode="False" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactName" HeaderText="ContactName" HtmlEncode="False" SortExpression="ContactName" />
                    <asp:BoundField DataField="City" HeaderText="City" HtmlEncode="False" SortExpression="City" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" HtmlEncode="False" ReadOnly="True" SortExpression="CustomerID" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [Country], [CompanyName], [ContactName], [City], [CustomerID] FROM [Customers] WHERE (([Country] = ?) AND ([City] = ?))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="DropDownList2" Name="City" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            Hiria:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Bezeroaren ID:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Konpaniaren izena:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
