Public Class Images
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.DropDownList1.SelectedIndex = 0
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Image1.ImageUrl = "~/Images/" & Me.DropDownList1.SelectedValue
    End Sub
End Class