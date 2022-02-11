Module Module1

    Sub Main(args As String())
        Dim kont As Integer = 5
        Dim arraya(kont) As String
        arraya(0) = "e"
        arraya(1) = "e"
        arraya(2) = "e"
        arraya(3) = "e"
        arraya(4) = "e"
        mirarArray(arraya)

        ReDim arraya(10)

        arraya(9) = "d"
        arraya(8) = "d"
        arraya(7) = "d"
        arraya(6) = "d"
        arraya(5) = "d"

        ReDim Preserve arraya(15)
        mirarArray(arraya)
        Console.WriteLine(arraya.Length - 1)
        Console.ReadLine()

    End Sub

    Sub mirarArray(datos As Array)
        For Each i As String In datos
            Console.WriteLine(i)
        Next
    End Sub

End Module
