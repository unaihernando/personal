Imports System.Data.OleDb
Public Class Erlazioak
    Dim sql, sql2 As String
    Dim cmd, cmd2 As New OleDbCommand

    'Dataseteko aldagaiak
    Dim ds As New DataSet
    Dim adp, adp2 As New OleDbDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DataGridView1.CurrentCell = DataGridView1.Rows(Convert.ToInt32(Me.TextBox1.Text) - 1).Cells(0)
        Catch ex As Exception
            MsgBox("aukeratutako fila ez dago")
        End Try
    End Sub

    Private Sub Erlazioak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            konektatuDB()
            sql = "Select * From Clientes"
            sql2 = "Select * From Facturas"

            adp = New OleDbDataAdapter(sql, conn)
            adp.Fill(ds, "aita")

            adp2 = New OleDbDataAdapter(sql2, conn)
            adp2.Fill(ds, "semea")

            Dim zutabe, zutabe2 As DataColumn
            zutabe = ds.Tables("aita").Columns("CodCli")
            zutabe2 = ds.Tables("semea").Columns("CodCli")
            ds.Relations.Add("Erlazioa", zutabe, zutabe2)

            Me.DataGridView1.DataSource = ds
            Me.DataGridView1.DataMember = "aita"
            Me.DataGridView2.DataSource = ds
            Me.DataGridView2.DataMember = "aita.Erlazioa"

            Dim cmb As New OleDbCommandBuilder(adp)
            Dim cmb2 As New OleDbCommandBuilder(adp2)

            ds.Tables("aita").PrimaryKey = New DataColumn() {Me.ds.Tables(0).Columns("CodCli")}
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim CodCli As Integer = Me.DataGridView1.CurrentRow.Cells(0).Value
        Try
            sql = "Select * From Facturas Where CodCli=" & CodCli

            cmd = New OleDbCommand(sql, conn)
            adp = New OleDbDataAdapter(cmd)

            adp.Fill(ds, "Fakturas")
            Me.DataGridView2.DataSource = ds.Tables("Fakturas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class