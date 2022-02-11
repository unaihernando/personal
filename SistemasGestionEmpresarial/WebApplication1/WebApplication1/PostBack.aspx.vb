Public Class PostBack
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Label1.Text = "Primera vez"
        Else
            Me.Label1.Text = "No es primera vez"
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label2.Text = "Botoia sakatu"
    End Sub
End Class