Module Module5
    Sub main()

        Dim kantitatea As Integer = 1
        Dim erdikoa As Integer = 1
        Dim kont As Integer
        Dim zbk As String
        Dim erdikoZenbakia As String = ""
        Dim lehenZenbakiak As String = ""
        Dim azkenZenbakiak As String = ""
        Dim zenbakiGuztiak As String = ""

        For x = 1 To 11

            For kont = 1 To Math.Truncate(kantitatea / 2)

                If (kantitatea - kont).ToString >= 10 Then
                    zbk = (kantitatea - kont).ToString.Substring((kantitatea - kont).ToString.Length - 1, (kantitatea - kont).ToString.Length - 1)
                Else
                    zbk = (kantitatea - kont).ToString
                End If

                lehenZenbakiak = zbk + lehenZenbakiak

            Next

            For l = 1 To lehenZenbakiak.Length
                azkenZenbakiak = azkenZenbakiak + lehenZenbakiak.Substring(lehenZenbakiak.Length - l, 1)
            Next

            If kantitatea.ToString >= 10 Then
                erdikoZenbakia = kantitatea.ToString.Substring(kantitatea.ToString.Length - 1, kantitatea.ToString.Length - 1)
            Else
                erdikoZenbakia = kantitatea.ToString
            End If

            zenbakiGuztiak = lehenZenbakiak + erdikoZenbakia + azkenZenbakiak

            Console.WriteLine(StrDup(11 - x, " ") & zenbakiGuztiak & StrDup(11 - x, " "))
            kantitatea = kantitatea + 2
            erdikoa = erdikoa + 2
            If kantitatea > 9 And kantitatea < 12 Then
                erdikoa = 1
            End If

            'zenbakiGuztiak = ""
            lehenZenbakiak = ""
            azkenZenbakiak = ""

        Next
        Console.ReadLine()
    End Sub
End Module