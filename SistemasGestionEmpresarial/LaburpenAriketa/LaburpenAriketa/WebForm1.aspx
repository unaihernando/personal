<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="LaburpenAriketa.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Select1 {
            height: 18px;
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    Ikasleak Kudeatzeko Aplikazioa<br />
                    <asp:Image ID="Image1" runat="server" Height="165px" ImageUrl="~/hasbulla-hasbik.gif" Width="333px" />
                    <br />
                    <br />
                    Izena/Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Abizena/Apellido:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Adina/Edad &gt; 18:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br />
                    <br />
                    Matrikulatze data/ Dia de matriculacion<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Los fines de semana no se pueden seleccionar "></asp:Label>
                    <br />
                    <br />
                    Taldea/Grupo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>DAM</asp:ListItem>
                        <asp:ListItem>DAW</asp:ListItem>
                        <asp:ListItem>ASIR</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    Hizkuntza:&nbsp;
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem>Euskara</asp:ListItem>
                        <asp:ListItem>Gaztelania</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    Hizkuntzak/Idiomas:&nbsp;&nbsp;
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="16px" Width="402px" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem>Ingelesa</asp:ListItem>
                        <asp:ListItem>Frantsesa</asp:ListItem>
                        <asp:ListItem>Alemana</asp:ListItem>
                        <asp:ListItem>Italiera</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    <br />
                    <br />
                    <br />
                    Argazkia/Foto:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    &nbsp;
                    <asp:TextBox ID="TextBox4" runat="server">Ningun archivo seleccionado</asp:TextBox>
                    &nbsp;<asp:Button ID="Button3" runat="server" Text="Igo/Subir" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" style="height: 26px" Text="Gorde/Guardar" Width="109px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button6" runat="server" Text="Hustu/Borrar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" Text="Hurrengoa/Siguiente" />
                    <br />
                </asp:View>
                <asp:View ID="View2" runat="server" EnableViewState="False">
                    <asp:Button ID="Button1" runat="server" Text="Aurrekoa/Anterior" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
