Public Class TaulaMultip
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Response.Redirect("WebForm2.aspx?q=" + Me.TextBox1.Text)
    End Sub
End Class