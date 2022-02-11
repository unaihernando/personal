Imports System.Data.OleDb
Public Class Saltzaileak
    Dim sql As String
    Dim dr As OleDbDataReader

    Private Sub Saltzaileak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Select * From Vendedores"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim ds As New DataSet
        Try
            konektatuDB()
            cmd = New OleDbCommand(sql, conn)
            Dim ad As New OleDbDataAdapter(cmd)
            ds.Clear()
            ad.Fill(ds, "Saltzaileak")

            Me.DataGridView1.DataSource = ds.Tables(0)
            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class