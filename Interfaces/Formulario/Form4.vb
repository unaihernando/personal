Public Class Form4
    Dim form5 As New Form5
    Sub formularioAldatu()
        form5.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBoxEscudos_Click(sender As Object, e As EventArgs) Handles PictureBoxEscudos.Click
        System.Diagnostics.Process.Start("https://www.athletic-club.eus/")
    End Sub
    Sub PictureBox_Click(sender As Object, ByVal e As EventArgs) Handles PictureBoxUV.Click, PictureBoxYB.Click, PictureBoxIM.Click, PictureBoxDG.Click, PictureBoxAL.Click, PictureBoxUS.Click, PictureBoxIL.Click, PictureBoxY.Click, PictureBoxW.Click, PictureBoxMu.Click, PictureBoxRG.Click
        If (CType(sender, PictureBox).Name = "PictureBoxUS") Then
            jokalariaAtera("Unai Simon", PictureBoxUS)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxIL") Then
            jokalariaAtera("Iñigo Lekue", PictureBoxIL)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxY") Then
            jokalariaAtera("Yeray Alvarez", PictureBoxY)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxW") Then
            jokalariaAtera("Iñaki Williams", PictureBoxW)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxRG") Then
            jokalariaAtera("Raul Garcia", PictureBoxRG)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxMu") Then
            jokalariaAtera("Iker Muniain", PictureBoxMu)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxAL") Then
            jokalariaAtera("Alex Berenguer", PictureBoxAL)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxUV") Then
            jokalariaAtera("Unai Vencedor", PictureBoxUV)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxDG") Then
            jokalariaAtera("Dani Garcia", PictureBoxDG)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxYB") Then
            jokalariaAtera("Yuri Berchiche", PictureBoxYB)
        ElseIf (CType(sender, PictureBox).Name = "PictureBoxIM") Then
            jokalariaAtera("Iñigo Martinez", PictureBoxIM)
        End If
    End Sub
    Sub jokalariaAtera(izena As String, argazkia As PictureBox)
        formularioAldatu()
        form5.Label6.Text = izena
        form5.Label7.Text = posizioak1(izena)
        form5.Label8.Text = adinak1(izena)
        form5.Label9.Text = dortsalak1(izena)
        form5.PictureBox1.Image = argazkia.Image
    End Sub
    Function posizioak1()
        Dim posizioak As New Dictionary(Of String, String)
        posizioak.Add("Unai Simon", "Atezaina")
        posizioak.Add("Iñigo Martinez", "Atzelaria")
        posizioak.Add("Yeray Alvarez", "Atzelaria")
        posizioak.Add("Iñigo Lekue", "Atzelaria")
        posizioak.Add("Yuri Berchiche", "Atzelaria")
        posizioak.Add("Dani Garcia", "Erdilaria")
        posizioak.Add("Unai Vencedor", "Erdilaria")
        posizioak.Add("Alex Berenguer", "Erdilaria")
        posizioak.Add("Iker Muniain", "Aurrelaria")
        posizioak.Add("Iñaki Williams", "Aurrelaria")
        posizioak.Add("Raul Garcia", "Aurrelaria")
        Return posizioak
    End Function
    Function dortsalak1()
        Dim dortsalak As New Dictionary(Of String, Integer)
        dortsalak.Add("Unai Simon", 1)
        dortsalak.Add("Iñigo Martinez", 4)
        dortsalak.Add("Yeray Alvarez", 5)
        dortsalak.Add("Iñigo Lekue", 15)
        dortsalak.Add("Yuri Berchiche", 17)
        dortsalak.Add("Dani Garcia", 14)
        dortsalak.Add("Unai Vencedor", 16)
        dortsalak.Add("Alex Berenguer", 7)
        dortsalak.Add("Iker Muniain", 10)
        dortsalak.Add("Iñaki Williams", 9)
        dortsalak.Add("Raul Garcia", 22)
        Return dortsalak
    End Function
    Function adinak1()
        Dim adinak As New Dictionary(Of String, Integer)
        adinak.Add("Unai Simon", 24)
        adinak.Add("Iñigo Martinez", 30)
        adinak.Add("Yeray Alvarez", 26)
        adinak.Add("Iñigo Lekue", 28)
        adinak.Add("Yuri Berchiche", 31)
        adinak.Add("Dani Garcia", 31)
        adinak.Add("Unai Vencedor", 20)
        adinak.Add("Alex Berenguer", 26)
        adinak.Add("Iker Muniain", 28)
        adinak.Add("Iñaki Williams", 27)
        adinak.Add("Raul Garcia", 35)
        Return adinak
    End Function
End Class