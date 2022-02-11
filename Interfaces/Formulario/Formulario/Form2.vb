Imports System.Globalization
Public Class Form2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim DolaresUS = New Globalization.CultureInfo("en-US")
        Dim Euro = New Globalization.CultureInfo("fr-Fr")
        Dim Yen = New Globalization.CultureInfo("ja-JP")
        Dim Libra = New Globalization.CultureInfo("en-GB")
        Dim euros As String = "0.86" + Euro.NumberFormat.CurrencySymbol
        Dim yenes As String = "110.93" + Yen.NumberFormat.CurrencySymbol
        Dim dolares As String = "1.01" + DolaresUS.NumberFormat.CurrencySymbol
        Dim libras As String = "0.73" + Libra.NumberFormat.CurrencySymbol
        If ComboBox1.SelectedItem.Equals("Euro") Then
            Label1.Text = Euro.NumberFormat.CurrencySymbol
            Label2.Text = euros
        ElseIf ComboBox1.SelectedItem.Equals("Dolar") Then
            Label1.Text = DolaresUS.NumberFormat.CurrencySymbol
            Label2.Text = dolares
        ElseIf ComboBox1.SelectedItem.Equals("Libra") Then
            Label1.Text = Libra.NumberFormat.CurrencySymbol
            Label2.Text = libras
        ElseIf ComboBox1.SelectedItem.Equals("Yen") Then
            Label1.Text = Yen.NumberFormat.CurrencySymbol
            Label2.Text = yenes
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class