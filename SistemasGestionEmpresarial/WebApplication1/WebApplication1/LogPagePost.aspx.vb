Public Class LogPagePost
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "unai" And Me.TextBox2.Text = "1234" Then
            Server.Transfer("LogPagePostOk.aspx")
        Else
            Server.Transfer("LogPagePostError.aspx")
        End If
    End Sub
End Class