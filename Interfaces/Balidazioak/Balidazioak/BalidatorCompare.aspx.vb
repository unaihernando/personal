Public Class BalidatorCompare
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label2.Text = "Balidatua"
        Else
            Me.Label2.Text = "Ez Balidatua"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.CompareValidator1.Operator = Me.ListBox1.SelectedIndex
    End Sub
End Class