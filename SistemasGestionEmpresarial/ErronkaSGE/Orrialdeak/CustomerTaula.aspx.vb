Public Class CustomerTaula
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBox1.Text = Me.GridView1.SelectedRow.Cells(4).Text
        Me.TextBox2.Text = Me.GridView1.SelectedRow.Cells(3).Text
        Me.TextBox3.Text = Me.GridView1.SelectedRow.Cells(2).Text

        'Me.TextBox1.Text = HttpUtility.HtmlDecode(Me.GridView1.SelectedRow.Cells(4).Text)
        'Me.TextBox2.Text = HttpUtility.HtmlDecode(Me.GridView1.SelectedRow.Cells(3).Text)
        'Me.TextBox3.Text = HttpUtility.HtmlDecode(Me.GridView1.SelectedRow.Cells(2).Text)

    End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class