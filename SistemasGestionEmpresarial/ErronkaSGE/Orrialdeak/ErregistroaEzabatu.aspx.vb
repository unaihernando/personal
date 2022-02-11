Imports System.Data.OleDb

Public Class ErregistroaEzabatu
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        'Dim sql As String = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice From Products" &
        '   " WHERE ProductID = " & Me.TextBox1.Text
        'Dim cmd As New OleDbCommand(sql, conn)
        'Dim adp As New OleDbDataAdapter(cmd)
        'Dim ds As New DataSet
        'Dim lerroak As Integer
        'Try
        '    conn.Open()
        '    Me.GridView1.Visible = True
        '    lerroak = adp.Fill(ds, "aaa")
        '    GridView1.DataSource = ds.Tables("aaa")
        '    GridView1.DataBind()
        '    conn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        datuaKargatu()

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.GridView1.Visible = True
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "DELETE FROM Products where ProductId=" & Me.TextBox1.Text
        Dim lerroak As Integer
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            conn.Open()
            lerroak = cmd.ExecuteNonQuery
            MsgBox("Erregistro bat ezabatu da")
            datuaKargatu()
            Me.TextBox1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


        'datu basearen kokapen ona
        'Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb
    End Sub
    Public Sub datuaKargatu()
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice From Products" &
           " WHERE ProductID = " & Me.TextBox1.Text
        Dim cmd As New OleDbCommand(sql, conn)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        Dim lerroak As Integer

        conn.Open()

        Me.GridView1.Visible = True
            lerroak = adp.Fill(ds, "aaa")
            GridView1.DataSource = ds.Tables("aaa")
            GridView1.DataBind()
        conn.Close()
    End Sub

End Class