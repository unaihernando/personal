Imports System.Data.OleDb
Public Class ProduktuakBistaratu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As New OleDbConnection

        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
        Dim sql As String = "select count (ProductID) from Products"
        Dim cmd As New OleDbCommand(sql, conn)
        conn.Open()
        Dim kontatu As Integer
        kontatu = cmd.ExecuteScalar()
        Me.Label1.Text = kontatu
        conn.Close()

    End Sub

End Class