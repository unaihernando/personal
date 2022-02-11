Imports System.IO
Module Module1
    Public Class Jokalaria
        Dim izena As String
        Dim erasoa As Integer
        Dim bizia As Integer
        Dim dirua As Integer
        Dim nibela As Integer
        Dim items As New Dictionary(Of String, Integer)

        Public Sub New(izena As String, erasoa As Integer, bizia As Integer, dirua As Integer, items As Dictionary(Of String, Integer), nibela As Integer)
            Me.izena = izena
            Me.erasoa = erasoa
            Me.bizia = bizia
            Me.dirua = dirua
            Me.nibela = nibela
            Me.items = items
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
    End Class

    Public Class etsaia
        Dim izena As String
        Dim erasoa As Integer
        Dim bizia As Integer
        Dim dirua As Integer
        Public Sub New(izena As String, erasoa As Integer, bizia As Integer, dirua As Integer)
            Me.izena = izena
            Me.erasoa = erasoa
            Me.bizia = bizia
            Me.dirua = dirua
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
    End Class
    Sub Main()
        Dim kk As Boolean = False
        Dim aukera As String = ""
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
                    Dim jokalaria = New Jokalaria(izena, 150, 250, 100, items, 1)
                    menu3(jokalaria)
                Case "L"
                    Dim jokalaria As Jokalaria = fitxeroaKargatu()
                    menu3(jokalaria)
                Case Else
                    Console.WriteLine("Ez duzu aukera on bat sartu")
            End Select
        Loop
        Console.ReadLine()
    End Sub

    Sub menu3(jokalaria As Jokalaria)
        Do
            Dim etsaiakArraya As Object() = etsaiak()
            Dim etsaia = etsaiakArraya(jokalaria.Nibela1 - 1)
            Console.WriteLine("*****************************")
            Console.WriteLine("Nibela: " & jokalaria.Nibela1)
            Console.WriteLine("Izena: " & etsaia.Izena1)
            Console.WriteLine("Erasoa: " & etsaia.Erasoa1)
            Console.WriteLine("Bizia: " & etsaia.Bizia1)
            Console.WriteLine("Dirua: " & etsaia.Dirua1)
            Console.WriteLine("*****************************")
            Dim aukera2 As String = ""
            Do While Not aukera2.Equals("A") Or aukera2.Equals("S") Or aukera2.Equals("U") Or aukera2.Equals("C")
                aukera2 = menu2()
                Select Case aukera2
                    Case "A"
                        erasoa(etsaia, jokalaria)
                        Console.WriteLine("------------------------------")
                        Console.WriteLine(jokalaria.Izena1 & " ataco " & jokalaria.Erasoa1 & " a " & etsaia.Izena1)
                        Console.WriteLine(etsaia.Izena1 & "  ataco " & etsaia.Erasoa1 & " a " & jokalaria.Izena1)
                        Console.WriteLine("Vida " & jokalaria.Izena1 & " " & jokalaria.Bizia1)
                        Console.WriteLine("Vida " & etsaia.Izena1 & " " & etsaia.Bizia1)
                        Console.WriteLine("------------------------------")
                        If jokalaria.Bizia1 <= 0 Then
                            Console.WriteLine("Jokoa bukatuata")
                        ElseIf etsaia.Bizia1 <= 0 Then
                            jokalaria.Nibela1 += 1
                            jokalaria.Erasoa1 += 1
                            jokalaria.Dirua1 += etsaia.Dirua1
                            fitxeroaBete(jokalaria)
                            If etsaia.Izena1.Equals("Great Demon") Then
                                Console.WriteLine("Jokoa irabazi duzu")
                                jokalaria.Bizia1 = 0
                            End If
                        End If
                    Case "S"
                        Console.WriteLine("Izena: " & jokalaria.Izena1)
                        Console.WriteLine("Erasoa: " & jokalaria.Erasoa1)
                        Console.WriteLine("Bizia: " & jokalaria.Bizia1)
                        Console.WriteLine("Dirua: " & jokalaria.Dirua1)
                        Console.WriteLine("Nibela: " & jokalaria.Nibela1)
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
                    Case Else
                        Console.WriteLine("Ez duzu aukera on bat sartu")
                End Select
            Loop
        Loop While jokalaria.Bizia1 > 0
    End Sub

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
        Console.Write("Elección:")
        Dim aukera As String = Console.ReadLine()
        Return aukera
    End Function

    Sub erasoa(etsaia As etsaia, jokalaria As Jokalaria)
        etsaia.Bizia1 -= jokalaria.Erasoa1
        jokalaria.Bizia1 -= etsaia.Erasoa1
    End Sub

    Function etsaiak()
        Dim etsaia1 = New etsaia("Goblin", 11, 70, 10)
        Dim etsaia2 = New etsaia("Skeleton", 12, 75, 16)
        Dim etsaia3 = New etsaia("Undead", 13, 80, 22)
        Dim etsaia4 = New etsaia("Goblin", 14, 85, 28)
        Dim etsaia5 = New etsaia("Spider", 15, 90, 34)
        Dim etsaia6 = New etsaia("Golem", 16, 95, 40)
        Dim etsaia7 = New etsaia("Mage", 17, 100, 46)
        Dim etsaia8 = New etsaia("Demon", 18, 105, 52)
        Dim etsaia9 = New etsaia("Spirit", 19, 110, 58)
        Dim etsaia10 = New etsaia("Great Demon", 20, 115, 64)
        Dim arraya As Object() = {etsaia1, etsaia2, etsaia3, etsaia4, etsaia5, etsaia6, etsaia7, etsaia8, etsaia9, etsaia10}
        Return arraya
    End Function

    Sub fitxeroaBete(jokalaria As Jokalaria)
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\TextHero\textHero.txt"
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
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\TextHero\textHero.txt"
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
            Loop
        Catch ex As Exception
        End Try
        items.Add("health_potion", Integer.Parse(itemZbk))
        Dim jokalaria = New Jokalaria(izena, erasoa, bizia, dirua, items, nibela)
        Return jokalaria
    End Function
End Module