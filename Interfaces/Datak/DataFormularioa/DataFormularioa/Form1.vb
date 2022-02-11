Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim sql As String
    Dim result As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\App_Data\Northwind.mdb;Persist Security Info=True"
        conn = New OleDbConnection(cnstring)
        'Konexion frogatzen dugu.
        Try
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("konektatuta")
            End If
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        'Listview hasierako datuak kargatuko ditugu
        Me.TextBox1.Text = "1/1/1960"
        Me.TextBox2.Text = "1/1/1950"
        Me.TextBox3.Text = "1/1/1960"

        Me.ListView1.Clear()
        Me.ListView1.GridLines = True
        Me.ListView1.View = View.Details

        Me.ListView1.Columns.Add("FirstName", 120, HorizontalAlignment.Right)
        Me.ListView1.Columns.Add("LastName", 120, HorizontalAlignment.Right)
        Me.ListView1.Columns.Add("BirthName", 120, HorizontalAlignment.Right)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SQL kontsulta egin
        sql = "SELECT FirstName, LastName, BirthDate "
        sql &= "FROM Employees WHERE BirthDate > @Eguna "
        sql &= "ORDER BY BirthDate"

        'pasatu kontsulta eta konexioa
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader
            cmd.Parameters.AddWithValue("@Eguna", Me.TextBox1.Text)
            dr = cmd.ExecuteReader
            Dim x As Integer = 0
            Me.ListView1.Items.Clear()
            While dr.Read
                Me.ListView1.Items.Add(dr.Item(0))
                Me.ListView1.Items(x).SubItems.Add(dr.Item(1))
                Me.ListView1.Items(x).SubItems.Add(dr.Item(2))
                x += 1
            End While
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'SQL kontsulta egin
        sql = "SELECT FirstName, LastName, BirthDate "
        sql &= "FROM Employees WHERE BirthDate > @Eguna1 AND BirthDate < @Eguna2  "
        sql &= "ORDER BY BirthDate"
        'pasatu kontsulta eta konexioa
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader
            cmd.Parameters.AddWithValue("@Eguna1", Me.TextBox2.Text)
            cmd.Parameters.AddWithValue("@Eguna2", Me.TextBox3.Text)
            dr = cmd.ExecuteReader
            Dim x As Integer = 0
            Me.ListView1.Items.Clear()
            While dr.Read
                Me.ListView1.Items.Add(dr.Item(0))
                    Me.ListView1.Items(x).SubItems.Add(dr.Item(1))
                    Me.ListView1.Items(x).SubItems.Add(dr.Item(2))
                    x += 1
            End While
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Parametrorik gabe
        'SQL kontsulta egin
        sql = "SELECT FirstName, LastName, BirthDate "
        sql &= "FROM Employees WHERE BirthDate > #" & Me.TextBox2.Text & "# AND birthdate < #" & Me.TextBox3.Text
        sql &= "# ORDER BY BirthDate"
        'pasatu kontsulta eta konexioa
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            Dim x As Integer = 0
            Me.ListView1.Items.Clear()
            While dr.Read
                Me.ListView1.Items.Add(dr.Item(0))
                Me.ListView1.Items(x).SubItems.Add(dr.Item(1))
                Me.ListView1.Items(x).SubItems.Add(dr.Item(2))
                x += 1
            End While

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
End Class
