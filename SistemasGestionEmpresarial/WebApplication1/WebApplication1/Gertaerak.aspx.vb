Public Class Gertaerak
    Inherits System.Web.UI.Page
    Dim var1 As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        var1 += 1
        Response.Write(var1 & "  -Form1 - Load <br>")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Button1 - Click <br>")
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Button1 - Click <br>")
    End Sub

End Class