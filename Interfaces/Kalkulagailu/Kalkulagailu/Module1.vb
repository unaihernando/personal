Imports kalkulagailuDLL
Module Module1

    Sub Main()
        Dim dll As New Class1
        Dim zbk As Double = 2
        Dim zbk2 As Double = 3
        Dim emaitza As Integer
        emaitza = dll.gehitu(zbk, zbk2)
        Console.WriteLine("Gehiketa : " & emaitza)
        emaitza = dll.kendu(zbk, zbk2)
        Console.WriteLine("Kenketa : " & emaitza)
        emaitza = dll.bider(zbk, zbk2)
        Console.WriteLine("Biderketa : " & emaitza)
        emaitza = dll.zati(zbk, zbk2)
        Console.WriteLine("Zatiketa : " & emaitza)
        Console.ReadLine()
    End Sub

End Module
