Public Class Form2
    Private Function botoiak()
        If RadioButton1.Checked Then
            Return 0
        End If
        If RadioButton2.Checked Then
            Return 1
        End If
        If RadioButton3.Checked Then
            Return 2
        End If
        If RadioButton4.Checked Then
            Return 3
        End If
        If RadioButton5.Checked Then
            Return 4
        End If
        If RadioButton6.Checked Then
            Return 5
        End If
    End Function
    Private Function ikonoak()
        If RadioButton7.Checked Then
            Return 0
        End If
        If RadioButton8.Checked Then
            Return 16
        End If
        If RadioButton9.Checked Then
            Return 32
        End If
        If RadioButton10.Checked Then
            Return 48
        End If
        If RadioButton11.Checked Then
            Return 64
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ikono = ikonoak()
        Dim botoia = botoiak()
        Dim Msg, Style, Title
        Msg = TextBox2.Text
        Style = botoia + ikono
        Title = TextBox1.Text
        MsgBox(Msg, Style, Title)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class