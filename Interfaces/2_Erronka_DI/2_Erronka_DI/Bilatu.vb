Imports System.Data.OleDb
Public Class Bilatu
    Dim sql As String
    Dim acount As Integer
    Dim cmd As OleDbCommand


    Private Sub Bilatu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        sql = "select CodPelicula, Titulo, Duración, CodGenero, Año, Productora, Pais, Precio, Director "
        sql &= "from peliculas"
        cmd = New OleDbCommand(sql, conn)
        kargatuDB()
    End Sub
    Private Sub kargatuDB()

        Try
            conn.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            Dim acount As Integer = 0


            Me.ListView1.Clear()
            Me.ListView1.GridLines = True
            Me.ListView1.View = View.Details

            Me.ListView1.Columns.Add(dr.GetName(0), 100, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("Titulo", 120, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("Duración", 120, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("CodGenero", 120, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("Año", 80, HorizontalAlignment.Right)
            Me.ListView1.Columns.Add("Productora", 100, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("Pais", 90, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("Precio", 90, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("Director", 100, HorizontalAlignment.Left)

            While dr.Read
                Dim row As ListViewItem = New ListViewItem(dr(0).ToString)
                If Not IsDBNull(dr(1).ToString) Then
                    row.SubItems.Add(dr(1).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(2).ToString) Then
                    row.SubItems.Add(dr(2).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(3).ToString) Then
                    row.SubItems.Add(dr(3).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(4).ToString) Then
                    row.SubItems.Add(dr(4).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(5).ToString) Then
                    row.SubItems.Add(dr(5).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(6).ToString) Then
                    row.SubItems.Add(dr(6).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(7).ToString) Then
                    row.SubItems.Add(dr(7).ToString)
                Else
                    row.SubItems.Add("")
                End If

                If Not IsDBNull(dr(8).ToString) Then
                    row.SubItems.Add(dr(8).ToString)
                Else
                    row.SubItems.Add("")
                End If

                ListView1.Items.Add(row)
                acount += 1
            End While
            Me.TextBox1.Text = acount
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim country As String = Me.TextBox2.Text
        If country <> "" Then
            sql = "SELECT * FROM Peliculas WHERE Pais = '" & country & "'"
        Else
            sql = "SELECT * FROM Peliculas"
        End If
        cmd = New OleDbCommand(sql, conn)
        kargatuDB()

    End Sub
End Class
