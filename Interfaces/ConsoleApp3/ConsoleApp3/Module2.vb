Module Module2
    Sub main()

        Console.WriteLine("Sartu lerro kopurua")
        Dim zbk As Integer = Console.ReadLine

        Dim numFilas As Integer = zbk / 2 + 1
        For altura = 1 To numFilas
            For blancos = 1 To numFilas - altura
                Console.Write(" ")
            Next
            For asteriscos = 1 To (2 * altura) - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        For altura = 1 To numFilas
            For blancos = 1 To altura
                Console.Write(" ")
            Next
            For asteriscos = 1 To (numFilas - altura) * 2 - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()


    End Sub
End Module
