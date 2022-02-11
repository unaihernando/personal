Imports System.Data.OleDb
Public Class XjarriXkendu

    Dim ad As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim ds As DataSet
    Dim sql As String

    Private Sub XjarriXkendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            konektatuDB()
            sql = "Select * from Vendedores"
            cmd = New OleDbCommand(sql, conn)
            ad = New OleDbDataAdapter(cmd)

            ds = New DataSet
            ad.Fill(ds, "saltzaileak")

            Me.DataGridView1.DataSource = ds.Tables("saltzaileak")
            Me.DataGridView1.Columns(0).Width = 80
            Me.DataGridView1.Columns(1).Width = 200
            Me.DataGridView1.Columns(2).Width = 150
            Me.DataGridView1.Columns(3).Width = 200
            Me.DataGridView1.Columns(4).Width = 150
            Me.DataGridView1.Columns(5).Width = 150
            Me.DataGridView1.Columns(6).Width = 150
            Me.DataGridView1.Columns(7).Width = 150
            Me.DataGridView1.Columns(8).Width = 150


            Dim cmb As New OleDbCommandBuilder(ad)
            Button1.Enabled = True
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ds.Tables(0).Rows((TextBox1.Text) - 1)(3) &= "X"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim caract = Me.ds.Tables(0).Rows((TextBox1.Text) - 1)(3)
        Me.ds.Tables(0).Rows((TextBox1.Text) - 1)(3) = caract.Substring(0, caract.Length - 1)

    End Sub
End Class