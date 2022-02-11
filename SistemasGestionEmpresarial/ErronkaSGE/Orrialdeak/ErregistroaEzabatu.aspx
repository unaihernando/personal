<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ErregistroaEzabatu.aspx.vb" Inherits="ErronkaSGE.ErregistroaEzabatu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Erregistroak ezabatu"></asp:Label>
    <br />
    <br />
    
    <asp:Label ID="Label2" runat="server" Text="IDa erabilita Produktua bilatu:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Bilatu" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Erregistroa ezabatu" />
</asp:Content>
