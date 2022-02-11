Public Class Form1
    Private a As Integer = 3
    Private konprobatu As Boolean
    Private karak As Integer = 0
    Private hitzak As Integer = 0
    Private berezia As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Unai"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.ResetText()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "VisualBasic" Then
            Label1.Text = "Kaixo"
        Else Label1.Text = "Agur"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Equals("unai2021") Then
            Label2.Text = "Ondo"
        Else
            Label2.Text = "Txarto"
            a = a - 1
        End If
        If a = 0 Then
            Label2.Text = "Blokeatuta"
            Button3.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f2 As New Form2
        If Len(TextBox2.Text) > 8 Then
            konprobatu = balioztatu(TextBox2.Text)
            If konprobatu = True Then
                TextBox2.Text = ""
                Label2.Text = "Pasahitza ona"
                f2.Show()
                Me.Hide()
            Else
                TextBox2.Text = ""
                Label2.Text = "Pasahitza Txarti"
            End If
        Else
            Label2.Text = "Pasahitza 8 digito baino luzeagoa izan behar da"
            TextBox2.Text = ""
        End If


    End Sub

    Function balioztatu(pasahitza As String) As Boolean
        Dim c As Char
        For Each c In pasahitza
            If Not Char.IsLetterOrDigit(c.ToString, 0) Then
                berezia += 1
            ElseIf Char.IsDigit(c.ToString(), 0) Then
                hitzak += 1
            ElseIf Char.IsLetter(c.ToString(), 0) Then
                karak += 1
            End If
        Next
        If hitzak = 0 Or karak = 0 Or berezia = 0 Then
            Return False
        Else Return True
        End If

    End Function
End Class
