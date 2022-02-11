Public Class BulletedList
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal
            Me.CheckBox1.Text = "Vertical"
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bulletedListKargatu()
    End Sub
    Private Sub bulletedListKargatu()
        Dim item As ListItem
        Me.BulletedList1.Items.Clear()
        For Each item In Me.CheckBoxList1.Items
            If item.Selected Then
                Me.BulletedList1.Items.Add(item.Text & " " & item.Value)
            End If
        Next
    End Sub
    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal
            Me.CheckBox1.Text = "Vertical"
        Else
            Me.CheckBoxList1.RepeatDirection = RepeatDirection.Vertical
            Me.CheckBox1.Text = "Horizontal"
        End If
    End Sub
End Class