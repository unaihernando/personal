Public Class Orrialdea2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "Aplikazioko aldagaiaren balorea:" & Application("UsuariosActivos")
        Label2.Text = "Sesioaren aldagaiaren balorea:" & Session("usuario")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Orrialdea1.aspx")
    End Sub
End Class