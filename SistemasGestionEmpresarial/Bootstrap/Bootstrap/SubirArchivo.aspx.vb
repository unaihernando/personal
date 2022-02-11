Public Class SubirArchivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsPostBack Then
            Dim path As String = Server.MapPath("~/")
            If FileUpload1.HasFile Then
                Try
                    FileUpload1.PostedFile.SaveAs(path & FileUpload1.FileName)
                    Label1.Text = "Fitxategia igo da"
                Catch ex As Exception
                    Label1.Text = "Fitxategia ezin izan da igo"
                End Try
            End If
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim path As String = Server.MapPath("~/")
        Dim fileOk As Boolean = False
        If FileUpload1.HasFile Then
            Dim fileExtension As String
            fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower()
            Dim extensionesAdmitidas As String() = {".jpg", ".png", ".jpeg", ".gif"}
            For i As Integer = 0 To extensionesAdmitidas.Length - 1
                If fileExtension = extensionesAdmitidas(i) Then
                    fileOk = True
                End If
            Next
            If fileOk Then
                Try
                    FileUpload1.PostedFile.SaveAs(path & FileUpload1.FileName)
                    Label1.Text = "Fitxategia igo da"
                Catch ex As Exception
                    Label1.Text = "Fitxategia ezin izan da igo"
                End Try
            Else
                Label1.Text = "Fitxategia ezin izan da igo"
            End If
        End If
    End Sub
End Class