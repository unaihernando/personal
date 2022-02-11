Module Module1

    Sub Main()
        Dim paswd As String = "bzva"
        Dim kont As Integer = 0
        Dim strings As String() = {"a", "b", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim atera As Boolean
        For i = 0 To strings.Length - 1
            For k = 0 To strings.Length - 1
                For j = 0 To strings.Length - 1
                    For x = 0 To strings.Length - 1
                        kont += 1
                        Dim e = strings(i) & strings(k) & strings(j) & strings(x)
                        Console.WriteLine(e)
                        If e.Equals(paswd) Then
                            Console.WriteLine("Se ha encontrado la contraseña al " & kont & " intento")
                            Console.WriteLine("Pasahitza --> " & paswd)
                            Console.ReadLine()
                            atera = True
                        End If
                        If atera = True Then
                            Exit For
                        End If
                    Next
                    If atera = True Then
                        Exit For
                    End If
                Next
                If atera = True Then
                    Exit For
                End If
            Next
            If atera = True Then
                Exit For
            End If
        Next






    End Sub
End Module