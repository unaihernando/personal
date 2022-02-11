<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AmigosBistaratu.aspx.vb" Inherits="ErronkaSGE.AmigosBistaratu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Amigos.accdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [Id], [Nombre], [Telefono], [FechaNacimiento], [Carnet], [Cuota], [Foto], [Url] FROM [Contactos_local]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" />
                <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="/Irudiak/{0}" HeaderText="Argazkia">
                </asp:ImageField>
                <asp:HyperLinkField DataNavigateUrlFields="Url" DataTextField="Url" Text="Lotura" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
