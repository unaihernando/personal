Imports System.Xml

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objektu As Object
        Dim artxiboa As Object
        objektu = CreateObject("Scripting.FileSystemObject")
        artxiboa = objektu.CreateTextFile("C:\Users\IN2DAM\source\repos\XmlAdibidea\ArtxiboXml.xml", True)
        artxiboa.WriteLine("<?xml version='1.0' encoding='UTF-8'?>")
        artxiboa.WriteLine("<root>")
        For x = 0 To 3
            artxiboa.WriteLine("<Irudia id= '" & CStr(x) & "'>")
            artxiboa.WriteLine("<Subnodo1>kaixo</Subnodo1>")
            artxiboa.WriteLine("<Subnodo2>hola</Subnodo2>")
            artxiboa.WriteLine("</Irudia>")
        Next
        artxiboa.WriteLine("</root>")
        artxiboa.Close
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim dokumentua As XmlDocument
            Dim zerrenda As XmlNodeList
            Dim nodo As XmlNode
            dokumentua = New XmlDocument
            dokumentua.Load("C:\Users\IN2DAM\source\repos\XmlAdibidea\ArtxiboXml.xml")
            zerrenda = dokumentua.SelectNodes("/root/Irudia")
            For Each nodo In zerrenda
                Dim IrudiaID = nodo.Attributes.GetNamedItem("id").Value
                Dim nodo1 = nodo.ChildNodes(0).InnerText
                Dim nodo2 = nodo.ChildNodes(1).InnerText
                MsgBox("Irudia id_a: " & IrudiaID & "Nodo 1:" & nodo1 & "Nodo 2:" & nodo2)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Datuak fitxategi batetik jaso, aukeraketarekin
        Dim FOp As New OpenFileDialog()
        FOp.Filter = "XML File | *.xml"
        FOp.FileName = ""

        'FOp fitxategiaren dialogoa bistaratzen den ziurtatu
        If FOp.ShowDialog = DialogResult.OK Then
            Dim ds As New DataSet
            ds.ReadXml(FOp.FileName)
            DataGridView1.DataSource = ds.Tables("Irudia")
        End If
    End Sub
End Class
