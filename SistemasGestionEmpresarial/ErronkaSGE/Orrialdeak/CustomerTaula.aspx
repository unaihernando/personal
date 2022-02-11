<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="CustomerTaula.aspx.vb" Inherits="ErronkaSGE.CustomerTaula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 214px;
    }
        .auto-style4 {
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
            width: 193px;
        }
        .auto-style7 {
            width: 193px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="Herrialdea:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Country" DataValueField="Country" Width="192px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT DISTINCT [CustomerID], [ContactName], [City], [Country] FROM [Customers]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label4" runat="server" Text="Hiriak:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="City" DataValueField="City" Width="192px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT DISTINCT [City], [Country] FROM [Customers] WHERE ([Country] = ?)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
</table>
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource3">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
            <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" HtmlEncode="False" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" HtmlEncode="False" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" HtmlEncode="False" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT DISTINCT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE ([City] = ?)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" Name="City" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label5" runat="server" Text="Herria:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label7" runat="server" Text="Herrialdea:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Enpresaren izena</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox3" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
<br />
<br />
<br />
</asp:Content>
