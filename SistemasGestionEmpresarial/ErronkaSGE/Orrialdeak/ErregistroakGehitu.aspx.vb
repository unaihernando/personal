Imports System.Data.OleDb
Public Class ErregistroakGehitu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "INSERT INTO Products ( ProductName, QuantityPerUnit, UnitPrice)" &
        "VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "')"

        Dim cmd As New OleDbCommand(sql, conn)
        conn.Open()
        Dim kontatu As Integer
        kontatu = cmd.ExecuteNonQuery()
        Me.Label1.Text = kontatu
        conn.Close()
        MsgBox(kontatu & " erregistroa gehitu da")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
    End Sub
End Class