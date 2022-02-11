<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ErregistroakAldatu.aspx.vb" Inherits="ErronkaSGE.ErregistroakAldatu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Erregistroak aldatu"></asp:Label>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="IDa erabilita Produktua bilatu:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Bilatu" />
<br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
<br />
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="ProductName: "></asp:Label>
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="QuantityPerUnit:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<br />
UnitPrice:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
<asp:Button ID="Button2" runat="server" Text="Erregistroa aldatu" />
<br />
<br />
</asp:Content>
