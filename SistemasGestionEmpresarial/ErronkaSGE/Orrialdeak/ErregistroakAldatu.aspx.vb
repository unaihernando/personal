Imports System.Data.OleDb
Public Class ErregistroakAldatu
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datuaKargatu()

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.GridView1.Visible = True

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "UPDATE Products SET ProductName ='" &
             Me.TextBox4.Text & "', QuantityPerUnit='" &
             Me.TextBox2.Text & "', UnitPrice ='" &
             Me.TextBox3.Text & "'" &
             " WHERE ProductID=" & Me.TextBox1.Text

        Dim cmd As New OleDbCommand(sql, conn)
        conn.Open()
        Dim lerroak As Integer
        lerroak = cmd.ExecuteNonQuery
        conn.Close()
        MsgBox(lerroak & " erregistro aldatu da")

    End Sub
    Public Sub datuaKargatu()
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        'Dim conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Esteban\Desktop\2_Erronka_DI_SGE\2_SGE\ErronkaSGE\App_Data\Northwind.mdb")
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


