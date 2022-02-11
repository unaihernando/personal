Imports System.Data.OleDb
Public Class GeneroPelikula
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EMPRESADataSet.Generos' Puede moverla o quitarla según sea necesario.
        Me.GenerosTableAdapter.Fill(Me.EMPRESADataSet.Generos)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.GenerosTableAdapter.FillBy(Me.EMPRESADataSet.Generos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sql As String = "Select * From Peliculas Where CodGenero = " & ComboBox1.SelectedValue
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            konektatuDB()
            Dim shw As OleDbDataReader
            shw = cmd.ExecuteReader

            Me.ListView1.Clear()
            Me.ListView1.GridLines = True
            Me.ListView1.View = View.Details

            Me.ListView1.Columns.Add("CodPelicula", 60, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(1), 110, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(2), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(3), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(4), 90, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(5), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(6), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(7), 100, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(shw.GetName(8), 100, HorizontalAlignment.Left)

            Dim x As Integer = 0
            While shw.Read
                Me.ListView1.Items.Add(shw.Item(0))
                Me.ListView1.Items(x).SubItems.Add(shw.Item(1).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(2).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(3).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(4).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(5).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(6).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(7).ToString)
                Me.ListView1.Items(x).SubItems.Add(shw.Item(8).ToString)
                x += 1
            End While
        Catch ex As Exception
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try

    End Sub


End Class