Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totala As Integer
        If CheckBox1.Checked Then
            totala += 10
        End If
        If CheckBox2.Checked Then
            totala += 20
        End If
        If CheckBox3.Checked Then
            totala += 30
        End If
        totala += DropDownList1.SelectedValue
        Label2.Text = totala & "€"
    End Sub
End Class