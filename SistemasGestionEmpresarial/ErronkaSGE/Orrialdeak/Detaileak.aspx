<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Detaileak.aspx.vb" Inherits="ErronkaSGE.Detaileak" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Amigos.accdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [Contactos_local]"></asp:SqlDataSource>
</p>
<p>
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
        </Columns>
    </asp:GridView>
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Amigos.accdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [Contactos_local] WHERE ([Id] = ?)">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="Id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
            <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
            <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
            <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
            <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
            <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" />
        </Fields>
    </asp:DetailsView>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
