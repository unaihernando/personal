Module Module1

    Sub Main()

        Console.WriteLine("Sartu kantitatea")
        Dim kantitatea As Double = Console.ReadLine
        Dim b500 As Integer = 0
        Dim b200 As Integer = 0
        Dim b100 As Integer = 0
        Dim b50 As Integer = 0
        Dim b20 As Integer = 0
        Dim b10 As Integer = 0
        Dim b5 As Integer = 0
        Dim m2 As Integer = 0
        Dim m1 As Integer = 0



        While kantitatea >= 500
            b500 += 1
            kantitatea -= 500
        End While
        While kantitatea >= 200
            b200 += 1
            kantitatea -= 200
        End While
        While kantitatea >= 100
            b100 += 1
            kantitatea -= 100
        End While
        While kantitatea >= 50
            b50 += 1
            kantitatea -= 50
        End While
        While kantitatea >= 20
            b20 += 1
            kantitatea -= 20
        End While
        While kantitatea >= 10
            b10 += 1
            kantitatea -= 10
        End While
        While kantitatea >= 5
            b5 += 1
            kantitatea -= 5
        End While
        While kantitatea >= 200
            b200 += 1
            kantitatea -= 200
        End While
        While kantitatea >= 2
            m2 += 1
            kantitatea -= 2
        End While
        While kantitatea >= 1
            m1 += 1
            kantitatea -= 1
        End While

        Console.WriteLine("500 billetak --> " & b500)
        Console.WriteLine("200 billetak --> " & b200)
        Console.WriteLine("100 billetak --> " & b100)
        Console.WriteLine("50 billetak --> " & b50)
        Console.WriteLine("20 billetak --> " & b20)
        Console.WriteLine("10 billetak --> " & b10)
        Console.WriteLine("5 billetak --> " & b5)
        Console.WriteLine("2 monedak --> " & m2)
        Console.WriteLine("1 monedak --> " & m1)
        Console.ReadLine()
    End Sub

End Module
