Public Class UpdatePanel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = DateTime.Now.ToString
        Me.Label3.Text = DateTime.Now.ToString
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Label1.Text = DateTime.Now.ToString 'No sirve porque no esta dentro del panel
        Me.Label3.Text = DateTime.Now.ToString
    End Sub
End Class