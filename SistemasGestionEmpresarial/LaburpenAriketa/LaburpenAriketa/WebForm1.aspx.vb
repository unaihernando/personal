Imports System.Drawing
Imports System.IO

Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim folderPath As String = Server.MapPath("~/Files/")

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        FileUpload1.SaveAs(folderPath & Path.GetFileName(FileUpload1.FileName))

        Image1.ImageUrl = "~/Files/" & Path.GetFileName(FileUpload1.FileName)

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim fitxeroa As String = Server.MapPath("info.txt")
            Dim idatzi As StreamWriter
            idatzi = File.AppendText(fitxeroa)
            idatzi.WriteLine()
            idatzi.WriteLine("*******************************")
            idatzi.WriteLine("Izena --> " & TextBox1.Text)
            idatzi.WriteLine("Abizena --> " & TextBox2.Text)
            idatzi.WriteLine("Adina --> " & TextBox3.Text)
            idatzi.WriteLine("Data --> " & Calendar1.SelectedDate.ToString)
            idatzi.WriteLine("Taldea --> " & DropDownList1.SelectedValue)
            idatzi.WriteLine("Hizkuntza --> " & RadioButtonList1.SelectedValue)
            idatzi.Write("Hizkuntzak --> ")
            For Each element In CheckBoxList1.Items
                If element.Selected Then
                    idatzi.Write(element.ToString & ", ")
                End If
            Next
            idatzi.Flush()
            idatzi.Close()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButtonList1.ClearSelection()
        CheckBoxList1.ClearSelection()
        PlaceHolder1.Controls.Clear()

    End Sub
    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged
        Dim BulletedListHizkuntza As New BulletedList
        PlaceHolder1.Controls.Add(BulletedListHizkuntza)
        BulletedListHizkuntza.ForeColor = Color.Red
        BulletedListHizkuntza.Items.Clear()
        For Each item In sender.Items
            If item.Selected Then
                BulletedListHizkuntza.Items.Add(item.Text)
            End If
        Next
        PlaceHolder1.Visible = True
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MultiView1.ActiveViewIndex += 1
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MultiView1.ActiveViewIndex -= 1
    End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Convert.ToInt32(TextBox3.Text) < 18 Then
            Label1.ForeColor = Color.Red
            Label1.Text = "18 urte baino gehiago izan behar ditu"
            TextBox3.Focus()
        Else
            Label1.Text = ""
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        If Calendar1.SelectedDate.DayOfWeek = 6 Or Calendar1.SelectedDate.DayOfWeek = 7 Then
            Button4.Enabled = False
            Button6.Enabled = False
            Label2.ForeColor = Color.Red
        End If

        If Calendar1.SelectedDate.DayOfWeek = 1 Or Calendar1.SelectedDate.DayOfWeek = 2 Or Calendar1.SelectedDate.DayOfWeek = 3 Or
            Calendar1.SelectedDate.DayOfWeek = 4 Or Calendar1.SelectedDate.DayOfWeek = 5 Then
            Button4.Enabled = True
            Button6.Enabled = True
            Label2.ForeColor = Color.Black
        End If
    End Sub
End Class