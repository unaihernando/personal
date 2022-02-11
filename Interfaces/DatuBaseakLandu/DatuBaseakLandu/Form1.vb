Imports System.Data.OleDb

Public Class Form1

    Dim conn As OleDbConnection
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ruta As String = Application.StartupPath
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\IN2DAM\source\repos\DatuBaseakLandu\TFNOS.MDB")
        Try
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("Konekzioa eginda")
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
                MsgBox("Konekzioa itxi egin da")
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select nombre, telefono from telefonos"
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader

            Me.ListView1.Clear()
            Me.ListView1.GridLines = True
            Me.ListView1.View = View.Details

            Me.ListView1.Columns.Add("Izena", 120, HorizontalAlignment.Right)
            Me.ListView1.Columns.Add("Telefonoa", 120, HorizontalAlignment.Right)

            While dr.Read
                Dim row As ListViewItem = New ListViewItem(dr.GetString(0))
                row.SubItems.Add(dr.GetString(1))
                ListView1.Items.Add(row)
            End While
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
                MsgBox("Konekzioa itxi egin da")
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ListView1.Clear()
        Me.ListView1.GridLines = False
    End Sub
End Class
