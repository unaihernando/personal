Public Class Form1
    Dim jugadas, ganadas As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2_Ayuda.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'para que funcione el F1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
        Label6.Text = numAleatorioEntre(1, 10)
        Label7.Text = numAleatorioEntre(1, 10)
        Label8.Text = numAleatorioEntre(1, 10)
        jugadas += 1
        If Label6.Text = 7 Or Label7.Text = 7 Or Label8.Text = 7 Then
            ganadas += 1
            PictureBox1.Image = My.Resources.PayCoins
        End If
        Label3.Text = "Partidas jugadas: " & jugadas
        Label4.Text = "Partidas ganadas: " & ganadas
        Label5.Text = Math.Round((ganadas / jugadas * 100), 2) & "%"
    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim kont As Integer = 0
        While kont < 30
            System.Threading.Thread.Sleep(200)
            Button1_Click(sender, e)
            Me.Refresh()
            kont += 1
        End While
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Button2.PerformClick()
        End If
    End Sub

End Class