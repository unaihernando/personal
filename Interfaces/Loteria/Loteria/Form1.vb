Public Class Form1
    Public matrizea(5, 0) As Object
    Public arraya(5) As Object
    Public labels(5) As Object
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim top As Integer = 40
        Dim left As Integer = 30
        Dim con As Control
        For n = Me.Controls.Count - 1 To 0 Step -1
            con = Me.Controls(n)
            If TypeOf con Is TextBox Then
                Me.Controls.Remove(con)
                con.Dispose()
            End If
            If TypeOf con Is Label And con.Name <> "label1" Then
                Me.Controls.Remove(con)
                con.Dispose()
            End If
        Next
        ReDim matrizea(5, NumericUpDown1.Value - 1)
        ReDim labels(NumericUpDown1.Value - 1)
        For i = 0 To NumericUpDown1.Value - 1
            For j = 0 To 5
                left += 50
                matrizea(j, i) = New TextBox
                matrizea(j, i).Top = top
                matrizea(j, i).Left = left
                matrizea(j, i).Width = 30
                matrizea(j, i).Text = "12"
                Me.Controls.Add(matrizea(j, i))
                labels(i) = New Label
                labels(i).Text = "0"
                labels(i).Top = top
                labels(i).ForeColor = Color.Blue
                labels(i).Left = 400
                labels(i).Width = 30
                Me.Controls.Add(labels(i))
            Next
            top += 30
            left = 30
        Next
        For j = 0 To 5
            left += 50
            arraya(j) = New TextBox
            arraya(j).Top = 400
            arraya(j).Left = left
            arraya(j).Width = 30
            arraya(j).Text = "12"
            Me.Controls.Add(arraya(j))
        Next
        If NumericUpDown1.Value = 0 Then
            For k = 0 To arraya.Length - 1
                Me.Controls.Remove(arraya(k))
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For j = 0 To NumericUpDown1.Value - 1
            Dim kont = 0
            For i = 0 To 5
                For k = 0 To arraya.Length - 1
                    If (matrizea(i, j).Text).Equals(arraya(k).Text) Then
                        matrizea(i, j).BackColor = Color.Green
                        kont += 1
                    End If
                Next
            Next
            labels(j).Text = kont
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For j = 0 To NumericUpDown1.Value - 1
            For i = 0 To 5
                matrizea(i, j).BackColor = Color.White
            Next
        Next
        Dim arrayZBk2 As New ArrayList
        While arrayZBk2.Count < 6
            Dim zbk2 = CInt(Rnd() * 50)
            If Not arrayZBk2.Contains(zbk2) Then
                arrayZBk2.Add(zbk2)
            End If
        End While
        For i = 0 To NumericUpDown1.Value - 1
            Dim arrayZBk As New ArrayList
            While arrayZBk.Count < 6
                Dim zbk = CInt(Rnd() * 50)
                If Not arrayZBk.Contains(zbk) Then
                    arrayZBk.Add(zbk)
                End If
            End While
            arrayZBk.Sort()
            For k = 0 To 5
                matrizea(k, i).Text = arrayZBk(k)
            Next
        Next
        arrayZBk2.Sort()
        For j = 0 To 5
            arraya(j).Text = arrayZBk2(j)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For j = 0 To NumericUpDown1.Value - 1
            For i = 0 To 5
                matrizea(i, j).BackColor = Color.White
                matrizea(i, j).Text = "12"
            Next
        Next
        For j = 0 To NumericUpDown1.Value - 1
            labels(j).Text = "0"
        Next
        For j = 0 To 5
            arraya(j).Text = "12"
        Next
    End Sub
End Class
