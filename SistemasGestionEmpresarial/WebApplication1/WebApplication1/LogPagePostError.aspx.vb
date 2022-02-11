Public Class LogPagePostError
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = "Erabiltzailea <b>" & Me.Request.Form("TextBox1") &
            "<b> Error"
    End Sub

End Class