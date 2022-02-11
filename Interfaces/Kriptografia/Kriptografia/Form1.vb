Public Class Form1
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        NumericUpDown1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        NumericUpDown1.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        NumericUpDown1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String = TextBox1.Text
        If RadioButton1.Checked Then
            Dim letrak As New Dictionary(Of String, Integer)
            letrak.Add("a", 1)
            letrak.Add("b", 2)
            letrak.Add("c", 3)
            letrak.Add("d", 4)
            letrak.Add("e", 5)
            letrak.Add("f", 6)
            letrak.Add("g", 7)
            letrak.Add("h", 8)
            letrak.Add("i", 9)
            letrak.Add("j", 10)
            letrak.Add("k", 11)
            letrak.Add("m", 12)
            letrak.Add("n", 13)
            letrak.Add("o", 14)
            letrak.Add("p", 15)
            letrak.Add("q", 16)
            letrak.Add("r", 17)
            letrak.Add("s", 18)
            letrak.Add("t", 19)
            letrak.Add("u", 20)
            letrak.Add("v", 21)
            letrak.Add("w", 22)
            letrak.Add("x", 23)
            letrak.Add("y", 24)
            letrak.Add("z", 25)
            Dim letrak2 As New Dictionary(Of String, Integer)
            letrak2.Add("x", 1)
            letrak2.Add("y", 2)
            letrak2.Add("z", 3)
            letrak2.Add("a", 4)
            letrak2.Add("b", 5)
            letrak2.Add("c", 6)
            letrak2.Add("d", 7)
            letrak2.Add("e", 8)
            letrak2.Add("f", 9)
            letrak2.Add("g", 10)
            letrak2.Add("h", 11)
            letrak2.Add("i", 12)
            letrak2.Add("j", 13)
            letrak2.Add("k", 14)
            letrak2.Add("m", 15)
            letrak2.Add("n", 16)
            letrak2.Add("o", 17)
            letrak2.Add("p", 18)
            letrak2.Add("q", 19)
            letrak2.Add("r", 20)
            letrak2.Add("s", 21)
            letrak2.Add("t", 22)
            letrak2.Add("u", 23)
            letrak2.Add("v", 24)
            letrak2.Add("w", 25)
            'Encriptar
            Dim arraya As Char() = texto.ToCharArray
            Dim sus As String
            For i = 0 To arraya.Length - 1
                Dim letra As String = arraya(i)
                Dim pos = letrak(letra) - 1
                sus += letrak2.Keys(pos)
            Next
            TextBox2.Text = sus
            'Desencriptar
            Dim arraya1 As Char() = sus.ToCharArray
            Dim sus2 As String
            For i = 0 To arraya1.Length - 1
                Dim letra As String = arraya1(i)
                Dim pos = letrak2(letra) - 1
                sus2 += letrak.Keys(pos)
            Next
            TextBox3.Text = sus2
        End If
        If RadioButton2.Checked Then
            Dim primos As New ArrayList()
            Dim pares As New ArrayList()
            Dim impar As New ArrayList()
            Dim letrak = texto.ToCharArray
            Dim kont = 1
            For Each i In letrak
                If kont Mod 2 = 0 And Not kont = 2 Then
                    pares.Add(i)
                ElseIf kont Mod 3 = 0 And Not kont = 3 Then
                    impar.Add(i)
                Else
                    primos.Add(i)
                End If
                kont += 1
            Next
            For j = 0 To primos.Count - 1
                TextBox2.Text += primos(j)
            Next
            For q = 0 To pares.Count - 1
                TextBox2.Text += pares(q)
            Next
            For k = 0 To impar.Count - 1
                TextBox2.Text += impar(k)
            Next
        End If
        If RadioButton3.Checked Then
            Dim numeroDigitos = NumericUpDown1.Text
            Dim arraya(-1) As String
            Dim ondo As Boolean = False
            For i = 0 To numeroDigitos - 1
                If arraya.Length = 0 Then
                    ReDim Preserve arraya(numeroDigitos - 1)
                    arraya(i) = Int(numeroDigitos * Rnd() + 0)
                Else
                    Dim numaleratorio = Int(numeroDigitos * Rnd() + 0)
                    For Each j In arraya
                        If arraya.Contains(numaleratorio) Then
                            ondo = True
                            Exit For
                        Else
                            ondo = False
                        End If
                    Next
                    If ondo = False Then
                        arraya(i) = numaleratorio
                    Else
                        i -= 1
                    End If
                End If
            Next

            Dim letras As String
            Dim textos As Char() = texto.ToCharArray

            For Each k In arraya
                letras += textos(k)
            Next
            TextBox2.Text = letras
        End If
    End Sub
End Class