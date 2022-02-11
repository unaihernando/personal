Public Class CustomValidator
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Try
            Dim zenbakia As Integer = Convert.ToInt32(Me.TextBox1.Text)
            If zenbakia Mod 2 = 0 Then
                args.IsValid = True
            Else
                args.IsValid = False
            End If
        Catch ex As Exception
            args.IsValid = False
        End Try
    End Sub
End Class