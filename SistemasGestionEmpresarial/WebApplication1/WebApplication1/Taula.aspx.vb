Public Class Taula
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim taula As String = "<table>"
        taula = "<table border=1>"
        For x = 1 To 10
            taula += "<tr>"
            For y = 1 To 10
                taula &= "<td>" & x * y & "</td>"
            Next
            taula += "</tr>"
        Next
        Me.Label1.Text = taula
    End Sub
End Class