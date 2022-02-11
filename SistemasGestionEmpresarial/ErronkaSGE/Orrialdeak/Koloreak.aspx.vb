Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim azkenZenbakia As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        Try
            If e.Row.Cells(3).Text = "PostalCode" Then
                e.Row.BackColor = Drawing.Color.LightYellow
            End If
            If e.Row.RowType = DataControlRowType.DataRow Then
                azkenZenbakia = Convert.ToDouble(e.Row.Cells(3).Text)
                If azkenZenbakia Mod 2 = 0 Then
                    e.Row.BackColor = Drawing.Color.Pink
                Else
                    e.Row.BackColor = Drawing.Color.Green
                End If
            End If
        Catch ex As Exception
            e.Row.BackColor = Drawing.Color.Green
        End Try
    End Sub
End Class