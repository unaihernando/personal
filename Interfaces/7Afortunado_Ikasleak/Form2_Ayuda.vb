Imports System.IO
Public Class Form2_Ayuda
    Private Sub Form2_Ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aaa As New StreamReader("Readme.txt", System.Text.Encoding.UTF8)
        Me.TextBox1.Text = aaa.ReadToEnd
        aaa.Close()

        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Select(0, 0) 'para quitar la seleccion azul
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class