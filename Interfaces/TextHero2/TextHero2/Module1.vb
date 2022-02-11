Imports System.IO
Module Module1
    Public Class Jokalaria
        Dim izena As String
        Dim erasoa As Integer
        Dim bizia As Integer
        Dim dirua As Integer
        Dim nibela As Integer
        Dim items As New Dictionary(Of String, Integer)
        Dim jok_nibela As Integer
        Dim exp As Integer

        Public Sub New(izena As String, erasoa As Integer, bizia As Integer, dirua As Integer, items As Dictionary(Of String, Integer), nibela As Integer, jok_nibela As Integer, exp As Integer)
            Me.izena = izena
            Me.erasoa = erasoa
            Me.bizia = bizia
            Me.dirua = dirua
            Me.nibela = nibela
            Me.items = items
            Me.jok_nibela = jok_nibela
            Me.exp = exp
        End Sub

        Public Property Nibela1 As Integer
            Get
                Return nibela
            End Get
            Set(value As Integer)
                nibela = value
            End Set
        End Property

        Public Property Items1 As Dictionary(Of String, Integer)
            Get
                Return items
            End Get
            Set(value As Dictionary(Of String, Integer))
                items = value
            End Set
        End Property

        Public Property Izena1 As String
            Get
                Return izena
            End Get
            Set(value As String)
                izena = value
            End Set
        End Property

        Public Property Erasoa1 As Integer
            Get
                Return erasoa
            End Get
            Set(value As Integer)
                erasoa = value
            End Set
        End Property

        Public Property Bizia1 As Integer
            Get
                Return bizia
            End Get
            Set(value As Integer)
                bizia = value
            End Set
        End Property

        Public Property Dirua1 As Integer
            Get
                Return dirua
            End Get
            Set(value As Integer)
                dirua = value
            End Set
        End Property

        Public Property Jok_nibela1 As Integer
            Get
                Return jok_nibela
            End Get
            Set(value As Integer)
                jok_nibela = value
            End Set
        End Property

        Public Property Exp1 As Integer
            Get
                Return exp
            End Get
            Set(value As Integer)
                exp = value
            End Set
        End Property
    End Class

    Public Class etsaia
        Dim izena As String
        Dim erasoa As Integer
        Dim bizia As Integer
        Dim dirua As Integer
        Dim etsaiNibela As Integer
        Dim emanExp As Integer
        Public Sub New(izena As String, erasoa As Integer, bizia As Integer, dirua As Integer, etsaiNibela As Integer, emanExp As Integer)
            Me.izena = izena
            Me.erasoa = erasoa
            Me.bizia = bizia
            Me.dirua = dirua
            Me.etsaiNibela = etsaiNibela
            Me.emanExp = emanExp
        End Sub

        Public Property Izena1 As String
            Get
                Return izena
            End Get
            Set(value As String)
                izena = value
            End Set
        End Property

        Public Property Erasoa1 As Integer
            Get
                Return erasoa
            End Get
            Set(value As Integer)
                erasoa = value
            End Set
        End Property

        Public Property Bizia1 As Integer
            Get
                Return bizia
            End Get
            Set(value As Integer)
                bizia = value
            End Set
        End Property

        Public Property Dirua1 As Integer
            Get
                Return dirua
            End Get
            Set(value As Integer)
                dirua = value
            End Set
        End Property

        Public Property EtsaiNibela1 As Integer
            Get
                Return etsaiNibela
            End Get
            Set(value As Integer)
                etsaiNibela = value
            End Set
        End Property

        Public Property EmanExp1 As Integer
            Get
                Return emanExp
            End Get
            Set(value As Integer)
                emanExp = value
            End Set
        End Property
    End Class
    Sub Main()
        Dim kk As Boolean = False
        Dim aukera As String = ""
        Dim solairuak(3, 10) As Object
        For i = 0 To 2
            For j = 0 To 9
                Dim kont As Integer = Rnd() * 10
                solairuak(i, j) = etsaiak(kont)
            Next
        Next
        Do While Not aukera.Equals("E") Or aukera.Equals("L") Or aukera.Equals("N")
            aukera = menu()
            Select Case aukera
                Case "E"
                    Console.WriteLine("Jokoa amaitu da")
                    Console.Clear()
                Case "N"
                    Console.WriteLine("Jokalari izena: ")
                    Dim izena As String = Console.ReadLine
                    Dim items As New Dictionary(Of String, Integer)
                    items.Add("health_potion", 6)
                    Dim jokalaria = New Jokalaria(izena, 150, 250, 100, items, 0, 1, 0)
                    menu3(jokalaria, solairuak)
                Case "L"
                    Dim jokalaria As Jokalaria = fitxeroaKargatu()
                    menu3(jokalaria, solairuak)
                Case Else
                    Console.WriteLine("Ez duzu aukera on bat sartu")
            End Select
        Loop
        Console.ReadLine()
    End Sub

    Sub menu3(jokalaria As Jokalaria, solairuak As Object)
        Dim solairu As Integer = CInt(Int((2 * Rnd()) + 0))
        Dim nibelak As Integer = CInt(Int((9 * Rnd()) + 0))
        Dim etsaia = solairuak(solairu, nibelak)
        Do
            If nibelak = 10 Then
                solairu = CInt(Int((2 * Rnd()) + 0))
                nibelak = CInt(Int((9 * Rnd()) + 0))
            End If

            Dim aukera2 As String = ""
            If etsaia.Bizia1 > 0 Then
                Console.WriteLine("*****************************")
                Console.WriteLine("SolairuBerria " & solairu & " Nibela " & nibelak)
                Console.WriteLine("Izena: " & etsaia.Izena1)
                Console.WriteLine("Erasoa: " & etsaia.Erasoa1)
                Console.WriteLine("Bizia: " & etsaia.Bizia1)
                Console.WriteLine("Dirua: " & etsaia.Dirua1)
                Console.WriteLine("Etsaia Nibela: " & etsaia.EtsaiNibela1)
                Console.WriteLine("Etsaia Experientzia: " & etsaia.EmanExp1)
                Console.WriteLine("*****************************")
                Do While Not aukera2.Equals("A") Or aukera2.Equals("S") Or aukera2.Equals("U") Or aukera2.Equals("C") Or aukera2.Equals("H")
                    aukera2 = menu2()
                    Select Case aukera2
                        Case "A"
                            If jokalaria.Jok_nibela1 = 10 Then
                                Console.WriteLine("Jokoa irabazi duzu")
                                jokalaria.Bizia1 = 0
                            End If
                            erasoa(etsaia, jokalaria)
                            jokalaria.Nibela1 = solairu
                            Console.WriteLine("------------------------------")
                            Console.WriteLine(jokalaria.Izena1 & " ataco " & jokalaria.Erasoa1 & " a " & etsaia.Izena1)
                            Console.WriteLine(etsaia.Izena1 & "  ataco " & etsaia.Erasoa1 & " a " & jokalaria.Izena1)
                            Console.WriteLine("Vida " & jokalaria.Izena1 & " " & jokalaria.Bizia1)
                            Console.WriteLine("Vida " & etsaia.Izena1 & " " & etsaia.Bizia1)
                            Console.WriteLine("------------------------------")
                            If jokalaria.Bizia1 <= 0 Then
                                Console.WriteLine("Jokoa bukatuata")
                            ElseIf etsaia.Bizia1 <= 0 Then
                                jokalaria.Exp1 += etsaia.EmanExp1
                                jokalaria.Bizia1 = 100 + ((jokalaria.Jok_nibela1 - 1) * 10)
                                jokalaria.Erasoa1 += 2
                                jokalaria.Dirua1 += etsaia.Dirua1
                                If jokalaria.Exp1 > 100 And jokalaria.Exp1 < 200 Then
                                    jokalaria.Jok_nibela1 = 2
                                ElseIf jokalaria.Exp1 > 200 And jokalaria.Exp1 < 300 Then
                                    jokalaria.Jok_nibela1 = 3
                                ElseIf jokalaria.Exp1 > 300 And jokalaria.Exp1 < 400 Then
                                    jokalaria.Jok_nibela1 = 4
                                ElseIf jokalaria.Exp1 > 400 And jokalaria.Exp1 < 500 Then
                                    jokalaria.Jok_nibela1 = 5
                                ElseIf jokalaria.Exp1 > 500 And jokalaria.Exp1 < 600 Then
                                    jokalaria.Jok_nibela1 = 6
                                ElseIf jokalaria.Exp1 > 600 And jokalaria.Exp1 < 700 Then
                                    jokalaria.Jok_nibela1 = 7
                                ElseIf jokalaria.Exp1 > 700 And jokalaria.Exp1 < 800 Then
                                    jokalaria.Jok_nibela1 = 8
                                ElseIf jokalaria.Exp1 > 800 And jokalaria.Exp1 < 900 Then
                                    jokalaria.Jok_nibela1 = 9
                                ElseIf jokalaria.Exp1 > 900 And jokalaria.Exp1 < 1000 Then
                                    jokalaria.Jok_nibela1 = 10
                                ElseIf jokalaria.Exp1 > 1000 Then
                                    jokalaria.Jok_nibela1 = 11
                                End If
                                fitxeroaBete(jokalaria)
                                If (etsaia.Bizia1 <= 0) Then
                                    etsaia = etsaiaAukeratu(solairuak)
                                End If
                            End If
                        Case "S"
                            Console.WriteLine("Izena: " & jokalaria.Izena1)
                            Console.WriteLine("Erasoa: " & jokalaria.Erasoa1)
                            Console.WriteLine("Bizia: " & jokalaria.Bizia1)
                            Console.WriteLine("Dirua: " & jokalaria.Dirua1)
                            Console.WriteLine("Nibela: " & jokalaria.Nibela1)
                            Console.WriteLine("Jok_Nibela: " & jokalaria.Jok_nibela1)
                            Console.WriteLine("Experientzia: " & jokalaria.Exp1)
                            For Each item In jokalaria.Items1
                                Console.WriteLine("Items: " & item.Key & " --> " & item.Value)
                            Next
                        Case "U"
                            Dim zbk As Integer = jokalaria.Items1("health_potion")
                            jokalaria.Items1.Clear()
                            jokalaria.Items1.Add("health_potion", zbk - 1)
                            jokalaria.Bizia1 += 25
                        Case "C"
                            Console.WriteLine("Items disponibles:")
                            Console.WriteLine("    health_potion --> 20 oro/unidad")
                            If jokalaria.Dirua1 >= 20 Then
                                Console.WriteLine("Erosi nahi duzu? b/e")
                                Dim opzioa As String = Console.ReadLine()
                                Console.WriteLine("Aukera: " & opzioa)
                                If opzioa.Equals("b") Then
                                    Console.WriteLine("Zenbat erosi nahi dituzu?")
                                    Dim kant As Integer = Console.ReadLine()
                                    If (kant * 20) >= jokalaria.Dirua1 Then
                                        Console.WriteLine("Ezin dituzu hainbat erosi")
                                    Else
                                        jokalaria.Dirua1 -= (kant * 20)
                                        Dim zbk As Integer = jokalaria.Items1("health_potion")
                                        jokalaria.Items1.Clear()
                                        jokalaria.Items1.Add("health_potion", zbk + kant)
                                    End If
                                End If
                            Else
                                Console.WriteLine("Ez duzu hainbeste dirurik")
                            End If
                        Case "H"
                            Console.WriteLine("Solairua sartu")
                            Dim solairuBerria As String = Console.ReadLine()
                            Console.WriteLine("Gelaxka sartu")
                            Dim gelaxka As String = Console.ReadLine()
                            etsaia = solairuak(solairuBerria, gelaxka)
                            jokalaria.Nibela1 = solairuBerria
                            If etsaia.Bizia1 > 0 Then
                                Console.WriteLine("*****************************")
                                Console.WriteLine("SolairuBerria " & solairuBerria & " Nibela " & nibelak)
                                Console.WriteLine("Izena: " & etsaia.Izena1)
                                Console.WriteLine("Erasoa: " & etsaia.Erasoa1)
                                Console.WriteLine("Bizia: " & etsaia.Bizia1)
                                Console.WriteLine("Dirua: " & etsaia.Dirua1)
                                Console.WriteLine("Etsaia Nibela: " & etsaia.EtsaiNibela1)
                                Console.WriteLine("Etsaia Experientzia: " & etsaia.EmanExp1)
                                Console.WriteLine("*****************************")
                            Else
                                Console.WriteLine("Etsaia hilda dago")
                                etsaia = etsaiaAukeratu(solairuak)
                            End If
                        Case Else
                            Console.WriteLine("Ez duzu aukera on bat sartu")
                    End Select
                Loop
            Else
                Console.WriteLine("Etsaia hilda dago")
                etsaia = etsaiaAukeratu(solairuak)
            End If
        Loop While jokalaria.Bizia1 > 0
    End Sub

    Function etsaiaAukeratu(solairuak As Object)
        Console.WriteLine("Nora mugitu nahi zara?")
        Console.WriteLine("Solairua sartu")
        Dim solairuBerria As String = Console.ReadLine()
        Console.WriteLine("Gelaxka sartu")
        Dim gelaxka As String = Console.ReadLine()
        Dim etsaia = solairuak(solairuBerria, gelaxka)
        Return etsaia
    End Function

    Function menu()
        Console.WriteLine("Elige una de las opciones inferiores :")
        Console.WriteLine("      (L) Cargar partida")
        Console.WriteLine("      (N) Nueva partida")
        Console.WriteLine("      (E) Salir")
        Console.Write("Elección:")
        Dim aukera As String = Console.ReadLine()
        Return aukera
    End Function

    Function menu2()
        Console.WriteLine("Elige una de las opciones inferiores :")
        Console.WriteLine("      (A) Eraso")
        Console.WriteLine("      (U) Itemak erabili")
        Console.WriteLine("      (C) Erosi health-potion")
        Console.WriteLine("      (S) Jokalariaren datuak")
        Console.WriteLine("      (H) Solairu/Gelaxka aldatu")
        Console.Write("Elección:")
        Dim aukera As String = Console.ReadLine()
        Return aukera
    End Function

    Sub erasoa(etsaia As etsaia, jokalaria As Jokalaria)
        etsaia.Bizia1 -= jokalaria.Erasoa1
        jokalaria.Bizia1 -= etsaia.Erasoa1
    End Sub

    Function etsaiak(i As Integer) As etsaia
        If i = 1 Then
            Dim zbk As Integer = Rnd() * 10
            Dim etsaia1 = New etsaia("Goblin", (10 + zbk), (40 + (zbk * 10)), Int((30 * Rnd()) + zbk), zbk, (40 + (zbk * 10)))
            Return etsaia1
        End If
        If i = 2 Then
            Dim zbk2 As Integer = Rnd() * 10
            Dim etsaia2 = New etsaia("Skeleton", (10 + zbk2), (40 + (zbk2 * 10)), Int((30 * Rnd()) + zbk2), zbk2, (40 + (zbk2 * 10)))
            Return etsaia2
        End If
        If i = 3 Then
            Dim zbk3 As Integer = Rnd() * 10
            Dim etsaia3 = New etsaia("Undead", (10 + zbk3), (40 + (zbk3 * 10)), Int((30 * Rnd()) + zbk3), zbk3, (40 + (zbk3 * 10)))
            Return etsaia3
        End If
        If i = 4 Then
            Dim zbk4 As Integer = Rnd() * 10
            Dim etsaia4 = New etsaia("Goblin", (10 + zbk4), (40 + (zbk4 * 10)), Int((30 * Rnd()) + zbk4), zbk4, (40 + (zbk4 * 10)))
            Return etsaia4

        End If
        If i = 5 Then
            Dim zbk5 As Integer = Rnd() * 10
            Dim etsaia5 = New etsaia("Spider", (10 + zbk5), (40 + (zbk5 * 10)), Int((30 * Rnd()) + zbk5), zbk5, (40 + (zbk5 * 10)))
            Return etsaia5
        End If
        If i = 6 Then
            Dim zbk6 As Integer = Rnd() * 10
            Dim etsaia6 = New etsaia("Golem", (10 + zbk6), (40 + (zbk6 * 10)), Int((30 * Rnd()) + zbk6), zbk6, (40 + (zbk6 * 10)))
            Return etsaia6
        End If
        If i = 7 Then
            Dim zbk7 As Integer = Rnd() * 10
            Dim etsaia7 = New etsaia("Mage", (10 + zbk7), (40 + (zbk7 * 10)), Int((30 * Rnd()) + zbk7), zbk7, (40 + (zbk7 * 10)))
            Return etsaia7
        End If
        If i = 8 Then
            Dim zbk8 As Integer = Rnd() * 10
            Dim etsaia8 = New etsaia("Demon", (10 + zbk8), (40 + (zbk8 * 10)), Int((30 * Rnd()) + zbk8), zbk8, (40 + (zbk8 * 10)))
            Return etsaia8
        End If
        If i = 9 Then
            Dim zbk9 As Integer = Rnd() * 10
            Dim etsaia9 = New etsaia("Spirit", (10 + zbk9), (40 + (zbk9 * 10)), Int((30 * Rnd()) + zbk9), zbk9, (40 + (zbk9 * 10)))
            Return etsaia9
        End If
        If i = 10 Then
            Dim zbk10 As Integer = Rnd() * 10
            Dim etsaia10 = New etsaia("Great_Demon", (10 + zbk10), (40 + (zbk10 * 10)), Int((30 * Rnd()) + zbk10), zbk10, (40 + (zbk10 * 10)))
            Return etsaia10
        End If
    End Function

    Sub fitxeroaBete(jokalaria As Jokalaria)
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\TextHero2\textHero2.txt"
            File.Delete(fitxeroa)
            Dim idatzi As StreamWriter
            idatzi = File.AppendText(fitxeroa)
            idatzi.WriteLine("*******************************")
            idatzi.WriteLine("Izena: " & jokalaria.Izena1)
            idatzi.WriteLine("Erasoa: " & jokalaria.Erasoa1)
            idatzi.WriteLine("Bizia: " & jokalaria.Bizia1)
            idatzi.WriteLine("Dirua: " & jokalaria.Dirua1)
            idatzi.WriteLine("Nibela: " & jokalaria.Nibela1)
            For Each item In jokalaria.Items1
                idatzi.WriteLine("Items: " & item.Key & " --> " & item.Value)
            Next
            idatzi.WriteLine("Jokalaria nibela: " & jokalaria.Jok_nibela1)
            idatzi.WriteLine("Experientzia: " & jokalaria.Exp1)
            idatzi.Flush()
            idatzi.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function fitxeroaKargatu()
        Dim testua As String = ""
        Dim izena As String = ""
        Dim erasoa As String = ""
        Dim bizia As String = ""
        Dim dirua As String = ""
        Dim itemZbk As String = ""
        Dim nibela As String = ""
        Dim items As New Dictionary(Of String, Integer)
        Dim jokNibela As String = ""
        Dim experientzia As String = ""
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\TextHero2\textHero2.txt"
            Dim irakurri As StreamReader
            irakurri = File.OpenText(fitxeroa)
            Do While Not irakurri.EndOfStream
                testua = irakurri.ReadLine()
                If (testua.Contains("Izena:")) Then
                    izena = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Erasoa:") Then
                    erasoa = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Bizia:") Then
                    bizia = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Dirua:") Then
                    dirua = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Items") Then
                    itemZbk = testua.Substring(testua.IndexOf(">") + 2)
                End If
                If testua.Contains("Nibela") Then
                    nibela = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Jokalaria nibela") Then
                    jokNibela = testua.Substring(testua.IndexOf(":") + 1)
                End If
                If testua.Contains("Experientzia") Then
                    experientzia = testua.Substring(testua.IndexOf(":") + 1)
                End If
            Loop
        Catch ex As Exception
        End Try
        items.Add("health_potion", Integer.Parse(itemZbk))
        Dim jokalaria = New Jokalaria(izena, erasoa, bizia, dirua, items, nibela, jokNibela, experientzia)
        Return jokalaria
    End Function
End Module