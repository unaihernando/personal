Imports System.Data.OleDb
Public Class ErregistrotikIbili
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim ds As DataSet = Nothing
    Dim adp As New OleDbDataAdapter
    Dim posizioa, lerroak As Integer
    Dim i As Integer


    Private Sub ErregistrotikIbili_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            konektatuDB()
            sql = "Select * from Vendedores"
            cmd = New OleDbCommand(sql, conn)
            ds = New DataSet
            adp = New OleDbDataAdapter(cmd)

            adp.Fill(ds, posizioa, lerroak, "Saltzaileak")
            DataGridView1.DataSource = ds.Tables("Saltzaileak")

            lerroak = Me.DataGridView1.Rows.Count - 1
            posizioa = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        posizioa = 0
        If (posizioa <= 0) Then
            posizioa = 0
        End If
        ds.Clear()
        adp.Fill(ds, posizioa, lerroak, "Saltzaileak")
        MsgBox("Leheneko erregistroan zaude")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (posizioa <= 0) Then
            posizioa = 0
        End If
        posizioa -= 1
        ds.Clear()
        adp.Fill(ds, posizioa, lerroak, "Saltzaileak")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If posizioa = ds.Tables("Saltzaileak").Rows.Count - 1 Then
            MsgBox("Azkeneko erregistroan zaude")
        Else
            posizioa += 1
            ds.Clear()
            adp.Fill(ds, posizioa, lerroak, "Saltzaileak")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            DataGridView1.CurrentCell = DataGridView1.Rows(Convert.ToInt32(Me.TextBox1.Text) - 1).Cells(0)
        Catch ex As Exception
            MsgBox("aukeratutako fila ez dago")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        posizioa = ds.Tables("Saltzaileak").Rows.Count - 1

        ds.Clear()
        adp.Fill(ds, posizioa, lerroak, "Saltzaileak")
        MsgBox("Azkeneko erregistroan zaude")
    End Sub

End Class