Imports System.Data.OleDb
Public Class OrdenID
    Inherits System.Web.UI.Page
    Dim conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim sql As String = "select distinct OrderID from [Order Details]"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim adp As New OleDbDataAdapter(cmd)
            Dim ds As New DataSet
            adp.Fill(ds, "aaa")

            Me.DropDownList1.DataSource = ds.Tables("aaa")
            Me.DropDownList1.DataTextField = "OrderId"
            Me.DropDownList1.DataValueField = "OrderId"
            Me.DropDownList1.DataBind()
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBox2.Text = Me.GridView1.SelectedRow.Cells(1).Text
        Me.TextBox3.Text = Me.GridView1.SelectedRow.Cells(2).Text
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Label3.Text = Me.DropDownList1.SelectedValue
        Dim sql As String = "select * from [Order Details] where OrderID=@uno"
        Dim cmd2 As New OleDbCommand(sql, conn)
        cmd2.Parameters.AddWithValue("@uno", DropDownList1.SelectedValue)
        Dim adp2 As New OleDbDataAdapter(cmd2)
        Dim ds2 As New DataSet
        adp2.Fill(ds2, "aaa")

        Me.GridView1.DataSource = ds2.Tables("aaa")
        Me.GridView1.DataBind()
        Me.Label3.Text = ds2.Tables(0).Rows.Count

        Dim totala As Double
        For x = 0 To ds2.Tables("aaa").Rows.Count - 1
            totala += ds2.Tables("aaa").Rows(x).Item("UnitPrice") * ds2.Tables("aaa").Rows(x).Item("Quantity")
        Next
        Me.Label6.Text = totala.ToString("c")

    End Sub
End Class