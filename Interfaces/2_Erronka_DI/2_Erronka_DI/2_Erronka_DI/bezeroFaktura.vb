Imports System.Data.OleDb
Public Class bezeroFaktura
    Dim sql As String
    Dim cmd As New OleDbCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim account As Integer = 0
        Dim irakurri As OleDbDataReader = Nothing
        Dim Metadat As String = Nothing
        sql = "Select * From Facturas"
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            konektatuDB()
            irakurri = cmd.ExecuteReader

            For x = 0 To irakurri.FieldCount - 1
                Metadat &= irakurri.GetName(x).ToUpper & " : " & irakurri.GetFieldType(x).ToString & vbCrLf
            Next
            MsgBox(Metadat)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim account As Integer = 0
        Dim irakurri As OleDbDataReader = Nothing
        Dim fil As String = Nothing
        sql = "Select * From Clientes"
        Dim cmd As New OleDbCommand(sql, conn)
        Try
            konektatuDB()
            irakurri = cmd.ExecuteReader

            While irakurri.Read
                account += 1
                fil &= account & "--> " & irakurri.Item(0) & " " & irakurri.Item(1) & vbCrLf

                If account Mod 25 = 0 Then
                    MsgBox(fil)
                    fil = Nothing
                End If

            End While
            If fil <> Nothing Then
                MsgBox(fil)
                deskonektatuDB()
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                deskonektatuDB()
            End If
        End Try
    End Sub
End Class