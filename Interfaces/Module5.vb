Module Module5

    Dim Ath() As String = {"Simon", "Yeray", "Iñigo", "Vivian", "Lekue", "Muniain", "Dani", "Vencedor", "Berenguer", "Williams", "Raul"}
    Dim PSG() As String = {"Gigi", "Bernat", "Ramos", "Marquinos", "Achraf", "Paredes", "Wijnaldum", "Verratti", "Messi", "Mbappe", "Neymar"}
    Dim golak1() As String = {"Williams", "Messi", "Mbappe", "Williams", "Mbappe"}
    Dim golak2() As String = {"Muniain", "Williams", "Neymar", "Berenguer", "Raul"}
    Dim kantitateaAO() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim kantitateaPO() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Sub main()
        Console.WriteLine("Lehenego partiduaren emaitza: ")
        emaitza(golak1)
        golegileak(golak1)
        Console.WriteLine("")
        Console.WriteLine("Bigarren partiduaren emaitza:")
        emaitza(golak2)
        golegileak(golak2)
        Console.WriteLine("")
        Console.WriteLine("Golegile nagusiena:")
        golegileakNagusienaPantailatu(kantitateaAO, kantitateaPO, Ath, PSG)
        Console.WriteLine("")
        Console.WriteLine("Golegileak:")
        golegileakPantailatu(kantitateaAO, Ath)
        golegileakPantailatu(kantitateaPO, PSG)
        Console.ReadLine()
    End Sub

    Sub emaitza(ByVal golak As String())
        Dim AG As Integer = 0
        Dim PP As Integer = 0
        Dim i As Integer
        Dim j As Integer
        For i = 0 To Ath.Length - 1
            For j = 0 To golak1.Length - 1
                If Ath(i).Equals(golak(j)) Then
                    AG = AG + 1
                ElseIf PSG(i).Equals(golak(j)) Then
                    PP = PP + 1
                End If
            Next
        Next
        Console.WriteLine("Athletic " & AG & " - " & PP & " PSG")
        Console.WriteLine("Athletic --> " & AG)
        Console.WriteLine("PSG golak --> " & PP)
    End Sub

    Sub golegileak(ByVal golak As String())
        Dim i, j As Integer
        Dim kantitateaA() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim kantitateaP() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        For i = 0 To golak.Length - 1
            For j = 0 To Ath.Length - 1
                If golak(i).Equals(Ath(j)) Then
                    kantitateaA(j) += 1
                    kantitateaAO(j) += 1
                ElseIf golak(i).Equals(PSG(j)) Then
                    kantitateaP(j) += 1
                    kantitateaPO(j) += 1
                End If
            Next
        Next
        Console.WriteLine("Partiduaren golegileak:")
        golegileakPantailatu(kantitateaA, Ath)
        golegileakPantailatu(kantitateaP, PSG)
    End Sub
    Sub golegileakPantailatu(ByVal golegileak As Integer(), ByVal taldea As String())
        Dim i, j As Integer
        For i = 0 To golegileak.Length - 1
            If Not golegileak(i) = 0 Then
                Console.WriteLine(taldea(i) & " --> " & golegileak(i))
            End If
        Next
    End Sub

    Sub golegileakNagusienaPantailatu(ByVal golak1 As Integer(), ByVal golak2 As Integer(), ByVal talde1 As String(), ByVal talde2 As String())
        Dim kont1 As Integer
        Dim kont2 As Integer
        Dim pos1 As Integer
        Dim pos2 As Integer
        For i = 0 To golak1.Length - 1
            If golak1(i) > kont1 Then
                kont1 = golak1(i)
                pos1 = i
            End If
            If golak2(i) > kont2 Then
                kont2 = golak2(i)
                pos2 = i
            End If
        Next
        If kont1 > kont2 Then
            Console.WriteLine(talde1(pos1) & " --> " & kont1)
        ElseIf kont2 > kont1 Then
            Console.WriteLine(talde2(pos2) & " --> " & kont2)
        End If
    End Sub

End Module
