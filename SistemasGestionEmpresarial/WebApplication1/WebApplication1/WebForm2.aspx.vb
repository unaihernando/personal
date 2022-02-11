Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zbk As Integer = CInt(Me.Request.QueryString("q"))
        Dim taula As String = "<table>"
        taula = "<table border=1>"
        For x = 1 To 10
            taula += "<tr>"
            taula &= "<td>" & zbk & "x" & x & "=" & "</td>" & "<td>" & zbk * x & "</td>"
            taula += "</tr>"
        Next
        Me.Label1.Text = taula
    End Sub

End Class