Public Class Panelak
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedItem.Text.ToLower = "administratzailea" Then
            Me.Panel1.Visible = True
            Me.Panel2.Visible = False
            Me.Label1.Text = "Administratzailea zara"
        ElseIf Me.DropDownList1.SelectedItem.Text.ToLower = "erabiltzailea" Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = True
            Me.Label2.Text = "Erabiltzailea zara"
        Else
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
        End If
    End Sub
End Class