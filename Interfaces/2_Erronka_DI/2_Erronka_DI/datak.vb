Imports System.Data.OleDb
Public Class datak
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data1 As Date = DateTimePicker1.Value
        Dim data2 As Date = DateTimePicker2.Value

        Dim sql As String = "select * from Facturas where Fecha > #" & data1 & "# and Fecha < #" & data2 & "#"
        Dim cmd As New OleDbCommand(sql, conn)

        Try
            konektatuDB()
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader

            Me.ListView1.Clear()
            Me.ListView1.GridLines = True
            Me.ListView1.View = View.Details

            Me.ListView1.Columns.Add("CodFac", 60, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(1), 110, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(2), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(3), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(4), 90, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(5), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(6), 80, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(7), 100, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add(reader.GetName(8), 100, HorizontalAlignment.Left)

            Dim x As Integer = 0
            While reader.Read

                Me.ListView1.Items.Add(reader.Item(0))
                Me.ListView1.Items(x).SubItems.Add(reader.Item(1).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(2).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(3).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(4).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(5).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(6).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(7).ToString)
                Me.ListView1.Items(x).SubItems.Add(reader.Item(8).ToString)
                x += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub

    Private Sub datak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class