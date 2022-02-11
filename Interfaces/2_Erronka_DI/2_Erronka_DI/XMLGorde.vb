Imports System.Data.OleDb

Public Class XMLGorde
    Dim sql As String
    Dim dr As OleDbDataReader
    Private Sub XMLGorde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Select * From Vendedores"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim ds As New DataSet
        Try
            konektatuDB()
            cmd = New OleDbCommand(sql, conn)
            Dim ad As New OleDbDataAdapter(cmd)
            ds.Clear()
            ad.Fill(ds, "Saltzaileak")

            Me.DataGridView1.DataSource = ds.Tables(0)
            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds1 As New DataSet
        sql = "Select * From Vendedores"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim ad As New OleDbDataAdapter(cmd)
        ds1.Clear()
        ad.Fill(ds1, "Saltzaileak")

        ds1.WriteXml("..\..\XML\artxioboa.xml")
        MsgBox("XML artxiboa sortua izan da")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds1 As New DataSet

        sql = "Select * From Vendedores"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim ad As New OleDbDataAdapter(cmd)
        DataGridView1.DataSource = Nothing
        ad.Fill(ds1, "Saltzaileak")

        MsgBox("Nahi dituzu datuak ezabatu XML artxiboa kargatzeko?", vbYesNo)
        If vbYes Then
            DataGridView1.DataSource = Nothing
            Me.DataGridView1.DataSource = ds1.Tables(0)
            ds1.ReadXml("..\..\xml\artxioboa.xml")
            MsgBox("XML artxiboa kargatu izan da")
        Else
            MsgBox("Datuak mantendu nahi dituzu, beraz ez da kargatuko XML artxiboa")
        End If

    End Sub
End Class