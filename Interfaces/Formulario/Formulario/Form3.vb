Public Class Form3
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If MonthCalendar1.SelectionRange.Start.Year = Date.Now.Year And
            MonthCalendar1.SelectionRange.Start.DayOfYear <= Date.Now.DayOfYear Or
            MonthCalendar1.SelectionRange.Start.Year < Date.Now.Year Then
            TextBox1.Text = Math.Round(Rnd() * 100000, 0)
        Else
            MsgBox("Oraindik ez gara egunera heldu")
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
End Class