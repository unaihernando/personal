<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AjaxEzabatu.aspx.vb" Inherits="ErronkaSGE.AjaxEzabatu" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            margin-right: 9px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>"
            DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?"
            InsertCommand="INSERT INTO [Customers] ( [CompanyName], [City], [Country]) VALUES (?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers]" 
            UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [City] = ?, [Country] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="auto-style5" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Seleccionar"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" TargetControlID="LinkButton3"></asp:LinkButton>
                    <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" 
                        TargetControlID="LinkButton3" ValidateRequestMode="Inherit" ConfirmText="Ezabatu nahi duzu?" />
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = ?" InsertCommand="INSERT INTO [Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT * FROM [Products]" UpdateCommand="UPDATE [Products] SET [ProductName] = ?, [SupplierID] = ?, [CategoryID] = ?, [QuantityPerUnit] = ?, [UnitPrice] = ?, [UnitsInStock] = ?, [UnitsOnOrder] = ?, [ReorderLevel] = ?, [Discontinued] = ? WHERE [ProductID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="ProductID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ProductID" Type="Int32" />
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="QuantityPerUnit" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="UnitsInStock" Type="Int16" />
                <asp:Parameter Name="UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="ReorderLevel" Type="Int16" />
                <asp:Parameter Name="Discontinued" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="QuantityPerUnit" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="UnitsInStock" Type="Int16" />
                <asp:Parameter Name="UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="ReorderLevel" Type="Int16" />
                <asp:Parameter Name="Discontinued" Type="Boolean" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource2" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock" />
                <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder" />
                <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" SortExpression="ReorderLevel" />
                <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                <asp:CommandField />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" TargetControlID="LinkButton1" BorderStyle="Ridge"></asp:LinkButton>
                        <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server"
                            TargetControlID="Linkbutton1" ConfirmText="Ziur zaude egin nahi duzuna<?" />
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>

        &nbsp;</asp:Content>
