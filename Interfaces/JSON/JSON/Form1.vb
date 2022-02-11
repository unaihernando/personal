Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim json As String = File.ReadAllText("C:\Users\IN2DAM\source\repos\JSON\JSON\Json.json")
        MsgBox(json)
        TextBox1.Enabled = False
        TextBox1.Text = json
        Dim dt As DataTable
        dt = JsonConvert.DeserializeObject(json)
    End Sub
End Class
