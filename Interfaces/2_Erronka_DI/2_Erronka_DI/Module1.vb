Imports System.Data.OleDb
Module Module1

    'MODULUAN aldagaiak, funtzioak, subprozesuak, ... erabiliko ditugu
    'aplikazioko formulario bat baino gehiago baditugu eta formulario
    'horietan erabili ahal izateko.

    'Dim konexioa As New OleDbConnection
    Dim acount As Integer
    Public cnstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=EMPRESA.mdb;Persist Security Info=True"
    Public conn As New OleDbConnection(cnstring)

    Public Sub konektatuDB()
        Try
            conn.Open()
            'If konexioa.State = ConnectionState.Open Then
            '    MsgBox("Konektatu da datu basera")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Ez da konexiorik lortu")
            'Finally
            '    If konexioa.State = ConnectionState.Open Then
            '        konexioa.Close()
            '    End If
        End Try
    End Sub
    Public Sub deskonektatuDB()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                'MsgBox("Konexioa itxi da", vbInformation, "Oharra")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
