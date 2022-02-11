Imports ClassLibrary1
Module Module1

    Sub Main()
        Dim ClassLibrary1 As New Class1
        Dim str1, str2 As String

        For x = -30 To 60 Step 3
            ClassLibrary1.graduakSartu(x)
            str1 = String.Format("{0,3:d}", x)
            str2 = String.Format("{0,6:f2}", ClassLibrary1.graduakFarenheit)
            Console.WriteLine(str1 & "ºC - " & str2 & " ºF")
        Next
        Console.ReadLine()
    End Sub

End Module
