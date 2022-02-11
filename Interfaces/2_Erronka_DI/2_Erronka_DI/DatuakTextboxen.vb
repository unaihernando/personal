Imports System.Data.OleDb
Public Class DatuakTextboxen
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Private Sub DatuakTextboxen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            konektatuDB()
            sql = "Select * From Vendedores"
            cmd = New OleDbCommand(sql, conn)
            Dim ds As New DataSet
            Dim ad As New OleDbDataAdapter(cmd)
            ds.Clear()
            ad.Fill(ds, "Saltzaileak")

            Me.DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Me.TextBox1.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        Me.TextBox2.Text = Me.DataGridView1.CurrentRow.Cells(6).Value
    End Sub
End Class