Module Module3
    Sub Main()
        Console.WriteLine("Sartu esaldia:")
        Dim esaldia As String = Console.ReadLine()
        Dim hitzak As String() = esaldia.Split(" ")
        For Each hitz As String In hitzak
            Console.Write(StrReverse(hitz) + " ")
        Next
        Console.ReadLine()
    End Sub

End Module
