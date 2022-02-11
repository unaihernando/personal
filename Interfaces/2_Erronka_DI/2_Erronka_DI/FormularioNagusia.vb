Public Class FormularioNagusia
    Private Sub FormularioNagusia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub BezeroFakturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BezeroFakturaToolStripMenuItem.Click
        bezeroFaktura.MdiParent = Me
        bezeroFaktura.Show()
        bezeroFaktura.Activate()
    End Sub

    Private Sub BilatuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilatuToolStripMenuItem.Click
        Bilatu.MdiParent = Me
        Bilatu.Show()
        Bilatu.Activate()
    End Sub

    Private Sub DatakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatakToolStripMenuItem.Click
        datak.MdiParent = Me
        datak.Show()
        datak.Activate()
    End Sub

    Private Sub FormularioNagusia_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then

            Txertatu.ShowDialog()

        End If
    End Sub

    Private Sub TxertatuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TxertatuToolStripMenuItem.Click
        Txertatu.MdiParent = Me
        Txertatu.Show()
        Txertatu.Activate()
    End Sub

    Private Sub DatasetEzabatuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatasetEzabatuToolStripMenuItem.Click
        DatasetEzabatu.MdiParent = Me
        DatasetEzabatu.Show()
        DatasetEzabatu.Activate()
    End Sub

    Private Sub DatuakTexboxeanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatuakTexboxeanToolStripMenuItem.Click
        DatuakTextboxen.MdiParent = Me
        DatuakTextboxen.Show()
        DatuakTextboxen.Activate()
    End Sub

    Private Sub EguneratuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EguneratuToolStripMenuItem.Click
        Eguneratu.MdiParent = Me
        Eguneratu.Show()
        Eguneratu.Activate()
    End Sub


End Class