Public Class Form1
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    BackColor = Color.Red
    'End Sub

    Private Sub onClick(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click
        If sender Is Button3 Then
            Me.BackColor = Color.Green
        End If
        If sender Is Button2 Then
            Me.BackColor = Color.Red
        End If
        If sender Is Button4 Then
            Me.BackColor = Color.Blue
        End If
        If sender Is Button5 Then
            Me.BackColor = DefaultBackColor
        End If
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    BackColor = Color.Green
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    BackColor = Color.Blue
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    BackColor = DefaultBackColor
    'End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = DefaultBackColor
        'Button1.ResetBackColor()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Yellow
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Kargatuta", MsgBoxStyle.Information)
    End Sub
End Class
