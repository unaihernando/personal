<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="OrdenID.aspx.vb" Inherits="ErronkaSGE.OrdenID" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="kopurua"></asp:Label>
&nbsp;
<asp:Label ID="Label4" runat="server" Text="Lerro"></asp:Label>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="Guztira eurotan:"></asp:Label>
&nbsp;
<asp:Label ID="Label6" runat="server" Text="Inportea"></asp:Label>
<br />
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True">
    </asp:GridView>
<br />
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<br />
</asp:Content>
