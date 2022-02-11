<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ErregistroakGehitu.aspx.vb" Inherits="ErronkaSGE.ErregistroakGehitu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Erregistroak Gehitu"></asp:Label>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="ProductName: "></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="QuantityPerUnit:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<br />
UnitPrice:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Erregistroak Gehitu" />
<br />
</asp:Content>
