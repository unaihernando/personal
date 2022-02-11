'Datu basera konektatzeko libreria
Imports System.Data.OleDb
Public Class Form1
    'Erabiliko ditugun aldagaiak
    Dim conn As OleDbConnection
    Dim sql As String
    Dim result As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ruta As String = Application.StartupPath
        Dim cn As String = Nothing
        Me.OFD1.InitialDirectory = ruta(0) & ":\"
        Me.OFD1.Filter = "Accesseko Fitxategiak | *.mdb"
        Me.OFD1.FileName = "Northwind.mdb"
        If Me.OFD1.ShowDialog = DialogResult.OK Then
            cn = Me.OFD1.FileName
        End If
        Dim cnstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & cn
        conn = New OleDbConnection(cnstring)
        Try
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("DBra konektatua")
            End If

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select count(*) from customers where country='Italy'"
        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            result = cmd.ExecuteScalar 'zenbaki balio bat emango dit
            MsgBox(result & "Aurkitu dira")

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "INSERT INTO customers (customerid, companyname, country)"
        sql &= "values ('pepe', '2dam3', 'Euskadi')"

        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            result = cmd.ExecuteNonQuery 'fila kopurua itzuliko dit
            MsgBox(result & "txertatu dira")

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "delete from customers where customerid='pepe'"

        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            result = cmd.ExecuteNonQuery 'fila ezabatuko dit
            MsgBox(result & "ezabatu dira")

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "UPDATE Products SET UnitPrice=UnitPrice + 1.10 "
        sql &= "WHERE ProductName='Chai'"

        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            result = cmd.ExecuteNonQuery 'Eguneratu prezioa
            MsgBox(result & "eguneratu dira")

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "select LastName + ' ' + FirstName, Title, City, Country "
        sql &= "from Employees Order by Country"

        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            Dim dr As OleDbDataReader 'New atzizkirik ez du erabiltzen
            dr = cmd.ExecuteReader

            Me.ListView1.Clear()
            Me.ListView1.GridLines = True
            Me.ListView1.View = View.Details

            Me.ListView1.Columns.Add("Nombre", 120, HorizontalAlignment.Right)
            Me.ListView1.Columns.Add(dr.GetName(1), 160, HorizontalAlignment.Right)
            Me.ListView1.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Right)
            Me.ListView1.Columns.Add(dr.GetName(3), 120, HorizontalAlignment.Right)

            While dr.Read
                Dim row As ListViewItem = New ListViewItem(dr.GetString(0))
                row.SubItems.Add(dr.GetString(1))
                row.SubItems.Add(dr.GetString(2))
                row.SubItems.Add(dr.GetString(3))
                ListView1.Items.Add(row)
            End While

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sql = "select count(*) from customers where country=@pais"
        'MsgBox(sql)
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.Add("@pais", OleDbType.VarChar).Value = "Spain"
        Try
            conn.Open()
            result = cmd.ExecuteScalar 'zenbaki balio bat emango dit
            MsgBox(result & "Aurkitu dira")

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
