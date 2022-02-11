Public Class CustomerValidator2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Dim a, b, c, d, e As Boolean
        Dim akum As String = ""
        Try
            If IsNumeric(Me.TextBox1.Text) Then
                a = True
            Else
                a = False
                akum &= "IsNumeric" & "<br>"
            End If
            If Me.TextBox1.Text.Length = 8 Then
                b = True
            Else
                b = False
                akum &= "Length" & "<br>"
            End If
            If Me.TextBox1.Text.StartsWith(8) Then
                c = True
            Else
                c = False
                akum &= "StartsWith" & "<br>"
            End If
            If Convert.ToInt32(Me.TextBox1.Text) Mod 2 = 0 Then
                d = True
            Else
                d = False
                akum &= "Bikoitia" & "<br>"
            End If
            If Me.TextBox1.Text(2) = "8" Then
                e = True
            Else
                e = False
                akum &= "3.Posizioa" & "<br>"
            End If
            If a And b And c And d And e Then
                args.IsValid = True
            Else
                args.IsValid = False
            End If
        Catch ex As Exception
            args.IsValid = False
        End Try
        Me.Label1.Text = akum
    End Sub
End Class