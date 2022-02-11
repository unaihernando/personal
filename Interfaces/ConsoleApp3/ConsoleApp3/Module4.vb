Module Module4
    Sub main()
        Dim kontBikoiti As Integer = 0
        Dim kontBakoiti As Integer = 0
        For i = 0 To 50
            If i Mod 2 = 0 Then
                kontBikoiti += i
                Console.WriteLine(i)
            End If
        Next
        Console.WriteLine("Bikoitien gehiketa --> " & kontBikoiti)
        For i = 0 To 50
            If Not i Mod 2 = 0 Then
                Console.WriteLine(i)
                kontBakoiti += i
            End If
        Next
        Console.WriteLine("Bakoitien gehiketa --> " & kontBakoiti)

        Console.ReadLine()
    End Sub

End Module
