Imports System.Data.OleDb
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'error de web UnobtrusiveValidation
        'ondorengoa jarri

        Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None

        Login1.UserName = "Nancy"
        Master.FindControl("Menu1").Visible = False
        Master.FindControl("LoginStatus1").Visible = True
    End Sub

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "SELECT * FROM employees Where FirstName='" +
            Login1.UserName + "' And LastName='" + Login1.Password + "'"
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand(sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Response.Redirect("ProduktuakBistaratu.aspx")
        Else
            Response.Redirect("login.aspx")
        End If
        dr.Close()
        conn.Close()

    End Sub
End Class