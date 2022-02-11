Module Module1
    Sub Main()
        Console.WriteLine("Sartu zenbaki bat")
        Dim zbk As Integer = Console.ReadLine

        Dim zenbakia As String = zbk.ToString
        Dim kont As Integer = 0
        While kont < zenbakia.Length
            kont += 1
        End While
        Console.WriteLine("Zenbakia " & kont & " karaktere ditu")
        Console.ReadLine()
    End Sub

End Module
