Imports System.Data.OleDb
Public Class DatasetEzabatu
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Private Sub DatasetEzabatu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        datuaKargatu()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            konektatuDB()
            sql = "Delete * from Vendedores where CodVend=" & Me.TextBox1.Text & ""
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
        datuaKargatu()
    End Sub
    Public Sub datuaKargatu()
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

End Class