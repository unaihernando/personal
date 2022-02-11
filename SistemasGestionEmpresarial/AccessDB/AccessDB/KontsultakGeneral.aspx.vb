Public Class Kontsultak
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBox1.Text = Me.GridView1.SelectedRow.Cells(4).Text
        Me.TextBox2.Text = Me.GridView1.SelectedRow.Cells(5).Text
        Me.TextBox3.Text = Me.GridView1.SelectedRow.Cells(2).Text
        Me.GridView1.SelectedRowStyle.BackColor = Drawing.Color.YellowGreen
        'Me.TextBox1.Text = HttpUtility.UrlEncode(Me.GridView1.SelectedRow.Cells(4).Text)
        'Editar columnas --> Htmlencode = false manual
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.TextBox2.Text = ""
        Me.TextBox1.Text = ""
        Me.TextBox3.Text = ""
        Me.GridView1.SelectedRowStyle.BackColor = Drawing.Color.White
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Me.TextBox2.Text = ""
        Me.TextBox1.Text = ""
        Me.TextBox3.Text = ""
        Me.GridView1.SelectedRowStyle.BackColor = Drawing.Color.White
    End Sub
End Class