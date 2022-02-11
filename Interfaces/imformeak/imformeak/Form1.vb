Imports System.Data.OleDb

Public Class Form1
    Dim conn As OleDbConnection
    Dim cmd, cmd2, cmd3 As OleDbCommand
    Dim adapt As OleDbDataAdapter
    Dim ds, ds2, ds3 As DataSet
    Dim sql As String
    Dim hasiera As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\App_Data\Northwind.mdb;Persist Security Info=True")
        ds = New DataSet
        Try
            conn.Open()
            sql = "SELECT DISTINCT OrderId FROM OrderDetails"
            cmd = New OleDbCommand(sql, conn)
            adapt = New OleDbDataAdapter(cmd)
            adapt.Fill(ds, "aaa")
            Me.ComboBox1.DataSource = ds.Tables("aaa")
            Me.ComboBox1.DisplayMember = "OrderId"
            hasiera = True
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim num As Integer
        Dim acum As String = Nothing
        ds2 = New DataSet
        Try
            sql = "SELECT OrderId FROM Orders WHERE OrderId >=" & Me.ComboBox1.SelectedItem(0)
            cmd2 = New OleDbCommand(sql, conn)
            adapt = New OleDbDataAdapter(cmd2)
            adapt.Fill(ds2, "bbb")
            For x = 0 To Me.ds2.Tables("bbb").Rows.Count - 1
                acum &= Me.ds2.Tables("bbb").Rows(x).Item(0)
                acum &= " --- " & String.Format("{0:C}", calcular(Me.ds2.Tables("bbb").Rows(x).Item(0)))
                acum &= vbNewLine
                num += 1
                If num = 10 Then Exit For
            Next
            If hasiera Then
                MsgBox(acum)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Function calcular(inportea As Integer) As Double
        Dim total As Double
        ds3 = New DataSet
        Try
            sql = "SELECT * FROM [OrderDetails] WHERE OrderId=" & inportea
            cmd3 = New OleDbCommand(sql, conn)
            adapt = New OleDbDataAdapter(cmd3)
            adapt.Fill(ds3, "ccc")
            For x = 0 To Me.ds3.Tables("ccc").Rows.Count - 1
                total += Me.ds3.Tables("ccc").Rows(x).Item("UnitPrice") *
                    Me.ds3.Tables("ccc").Rows(x).Item("Quantity") *
                    (1 - Me.ds3.Tables("ccc").Rows(x).Item("Discount"))
            Next

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
        Return total
    End Function
End Class
