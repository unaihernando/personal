Imports System.IO

Public Class Juego

    Public jokalaria As Jokalaria
    Public nivelActual As Integer
    Public rooms As New Dictionary(Of Integer, Etsaia)
    Public items As New Dictionary(Of String, Integer)
    Public etsaia As Etsaia

    Public Sub New(eleccion As String, nombre As String)

        InitializeComponent()
        inicializar()

        Select Case eleccion
            Case "nuevo"
                crearNuevoPlayer(nombre)
            Case "cargar"
                'cargarPartidaAnterior()
                fitxeroaKargatu()
        End Select

    End Sub

    Private Sub inicializar()

        Dim etsai1 As Etsaia = New Etsaia("Goblin", 11, 70, 10)
        Dim etsai2 As Etsaia = New Etsaia("Skeleton", 12, 75, 16)
        Dim etsai3 As Etsaia = New Etsaia("Undead", 13, 80, 22)
        Dim etsai4 As Etsaia = New Etsaia("Goblin", 14, 85, 28)
        Dim etsai5 As Etsaia = New Etsaia("Spider", 15, 90, 34)
        Dim etsai6 As Etsaia = New Etsaia("Golem", 16, 95, 40)
        Dim etsai7 As Etsaia = New Etsaia("Mage", 17, 100, 46)
        Dim etsai8 As Etsaia = New Etsaia("Demon", 18, 105, 52)
        Dim etsai9 As Etsaia = New Etsaia("Spirit", 19, 110, 58)
        Dim etsai10 As Etsaia = New Etsaia("Great_Demon", 20, 125, 64)

        rooms.Add(1, etsai1)
        rooms.Add(2, etsai2)
        rooms.Add(3, etsai3)
        rooms.Add(4, etsai4)
        rooms.Add(5, etsai5)
        rooms.Add(6, etsai6)
        rooms.Add(7, etsai7)
        rooms.Add(8, etsai8)
        rooms.Add(9, etsai9)
        rooms.Add(10, etsai10)
    End Sub
    'Carga los datos de la partida guardada anteriormente
    Private Sub cargarPartidaAnterior()
        cargarDatosJugador()
        cargarNivel()
    End Sub

    'Método para cargar los datos del jugador
    Private Sub cargarDatosJugador()
        'TODO
    End Sub

    'Crea una nueva instancia de Jugador, y luego guarda los datos en player.txt
    Private Sub crearNuevoPlayer(nombre As String)
        'TODO
        items.Add("health_potion", 6)
        jokalaria = New Jokalaria(nombre, 15, 25, 25, items, 1)
        LblRoom3.Text = jokalaria.Nibela
        LblPlayerName.Text = jokalaria.Izena
        For Each item In jokalaria.Items1
            LblPlayerItems.Text = "Items: " & item.Key & " x " & item.Value
        Next
        LblPlayerGold.Text = "Dirua: " & jokalaria.Dirua
        LblPlayerDmg.Text = "Erasoa: " & jokalaria.Erasoa
        LblHeroHealthBar.Text = jokalaria.Bizia
        etsaia = rooms.Values(jokalaria.Nibela - 1)
        LblEnemyDmg.Text = "Erasoa: " & etsaia.Erasoa
        LblEnemyGold.Text = "Dirua: " & etsaia.Dirua
        LblEnemyHealthBar.Text = etsaia.Bizia
        LblEnemyName.Text = etsaia.Izena
    End Sub

    'Guarda los datos del jugador en player.txt
    Private Sub guardarDatosJugador(jokalari As Jokalaria)
        'TODO
    End Sub

    Private Sub argazkiak()
        If jokalaria.Nibela = 2 Then
            PbEnemy.Image = My.Resources.skeleton
        ElseIf jokalaria.Nibela = 3 Then
            PbEnemy.Image = My.Resources.undead
        ElseIf jokalaria.Nibela = 4 Then
            PbEnemy.Image = My.Resources.goblin
        ElseIf jokalaria.Nibela = 5 Then
            PbEnemy.Image = My.Resources.spider
        ElseIf jokalaria.Nibela = 6 Then
            PbEnemy.Image = My.Resources.golem
        ElseIf jokalaria.Nibela = 7 Then
            PbEnemy.Image = My.Resources.mage
        ElseIf jokalaria.Nibela = 8 Then
            PbEnemy.Image = My.Resources.demon
        ElseIf jokalaria.Nibela = 9 Then
            PbEnemy.Image = My.Resources.spirit
        ElseIf jokalaria.Nibela = 10 Then
            PbEnemy.Image = My.Resources.great_demon
        End If
    End Sub


    'Este método controla los click de Atacar, Estadísticas, Usar y Comerciar
    Private Sub jugarpartida(sender As Object, e As EventArgs) Handles BtnAtacar.Click, BtnEstadi.Click, BtnUsar.Click, BtnComerciar.Click
        'TODO
        If sender.Equals(Me.BtnEstadi) Then
            BtnCerrar.Visible = True
            PbStats.Show()
            LblPlayerName.Show()
            LblPlayerGold.Show()
            LblPlayerDmg.Show()
            LblPlayerItems.Show()
        ElseIf sender.Equals(Me.BtnAtacar) Then
            Timer1.Interval = 25
            Timer1.Start()
            Timer3.Start()
            BtnAtacar.Enabled = False
            etsaia.Bizia1 -= jokalaria.Erasoa1
            jokalaria.Bizia1 -= etsaia.Erasoa1
            If jokalaria.Bizia1 <= 0 Then
                MsgBox("Jokoa bukatuata")
                BtnAtacar.Enabled = False
                BtnUsar.Enabled = False
                BtnEstadi.Enabled = False
                BtnComerciar.Enabled = False
            ElseIf etsaia.Bizia1 <= 0 Then
                jokalaria.Nibela1 += 1
                jokalaria.Dirua1 += etsaia.Dirua1
                etsaia = rooms.Values(jokalaria.Nibela - 1)
                fitxeroaBete(jokalaria)
                PbSpectacular.Show()
                LblPlayerGold.Text = "Dirua: " & jokalaria.Dirua1
            End If

            If etsaia.Izena.Equals("Great_Demon") And etsaia.Bizia <= jokalaria.Erasoa Then
                etsaia.Bizia = 0
                PbSpectacular.Show()
                MsgBox("Jokoa irabazita")
                BtnAtacar.Enabled = False
                BtnUsar.Enabled = False
                BtnEstadi.Enabled = False
                BtnComerciar.Enabled = False

            End If
        ElseIf sender.Equals(Me.BtnComerciar) Then
            GbComerciar.Visible = True
        ElseIf sender.Equals(Me.BtnUsar) Then
            Dim zbk As Integer
            For Each item In jokalaria.Items1
                zbk = item.Value
            Next
            If zbk > 0 Then
                jokalaria.Items.Clear()
                jokalaria.Items.Add("health_potion", zbk - 1)
                For Each item In jokalaria.Items1
                    LblPlayerItems.Text = "Items: " & item.Key & " x " & item.Value
                Next
                jokalaria.Bizia += 50
                LblHeroHealthBar.Text = jokalaria.Bizia
            Else
                MsgBox("Ez daude poziorik")
            End If
        End If
    End Sub

    'Este método actualiza la barra de vida del jugador y el enemigo
    Private Sub actualizarVida()
        LblEnemyHealthBar.Text = rooms.Item(nivelActual).Bizia
        LblHeroHealthBar.Text = jokalaria.Bizia
    End Sub

    'Este método carga el nivel actual en el que se encuentra el jugador
    Private Sub cargarNivel()

        'TODO

        actualizarVida()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        BtnCerrar.Hide()
        PbStats.Hide()
        LblPlayerName.Hide()
        LblPlayerGold.Hide()
        LblPlayerDmg.Hide()
        LblPlayerItems.Hide()
    End Sub

    Private Sub BtnCerrarComerciar_Click(sender As Object, e As EventArgs) Handles BtnCerrarComerciar.Click
        GbComerciar.Hide()
    End Sub

    Private Sub BtnAceptarComerciar_Click(sender As Object, e As EventArgs) Handles BtnAceptarComerciar.Click
        Dim zbk = TxtComerciar.Text
        Dim pozioak As Integer
        For Each item In jokalaria.Items1
            pozioak = item.Value
        Next
        If (zbk * 20) > jokalaria.Dirua Then
            MsgBox("Ez daukazu hainbeste dirurik")
        Else
            jokalaria.Items.Clear()
            jokalaria.Items.Add("health_potion", zbk + pozioak)
            For Each item In jokalaria.Items1
                LblPlayerItems.Text = "Items: " & item.Key & " x " & item.Value
            Next
            jokalaria.Dirua -= 20
            LblPlayerGold.Text = "Dirua: " & jokalaria.Dirua
        End If
        TxtComerciar.Text = ""
        GbComerciar.Hide()
    End Sub
    Private Sub fitxeroaBete(jokalaria As Jokalaria)
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\Graphic_Hero_Ikasleak\datuak.txt"
            Dim idatzi As New System.IO.StreamWriter(fitxeroa, False)
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

    Private Sub fitxeroaKargatu()
        Dim testua As String = ""
        Dim izena As String = ""
        Dim erasoa As String = ""
        Dim bizia As String = ""
        Dim dirua As String = ""
        Dim itemZbk As String = ""
        Dim nibela As String = ""
        Dim items As New Dictionary(Of String, Integer)
        Try
            Dim fitxeroa As String = "C:\Users\IN2DAM\source\repos\Graphic_Hero_Ikasleak\datuak.txt"
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
        jokalaria = New Jokalaria(izena, erasoa, bizia, dirua, items, nibela)
        LblRoom3.Text = jokalaria.Nibela
        LblPlayerName.Text = jokalaria.Izena
        For Each item In jokalaria.Items1
            LblPlayerItems.Text = "Items: " & item.Key & " x " & item.Value
        Next
        LblPlayerGold.Text = "Dirua: " & jokalaria.Dirua
        LblPlayerDmg.Text = "Erasoa: " & jokalaria.Erasoa
        LblHeroHealthBar.Text = jokalaria.Bizia
        etsaia = rooms.Values(jokalaria.Nibela - 1)
        LblEnemyDmg.Text = "Erasoa: " & etsaia.Erasoa
        LblEnemyGold.Text = "Dirua: " & etsaia.Dirua
        LblEnemyHealthBar.Text = etsaia.Bizia
        LblEnemyName.Text = etsaia.Izena
        argazkiak()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PbHero.Left += 15
    End Sub

    Private Sub PbHero_LocationChanged(sender As Object, e As EventArgs) Handles PbHero.LocationChanged
        If PbHero.Left >= Me.PbEnemy.Location.X - PbEnemy.Width Then
            Timer1.Stop()
            argazkiak()
            LblEnemyHealthBar.Text = etsaia.Bizia
            LblHeroHealthBar.Text = jokalaria.Bizia
            LblRoom3.Text = jokalaria.Nibela
            LblEnemyDmg.Text = "Erasoa: " & etsaia.Erasoa
            LblEnemyGold.Text = "Dirua: " & etsaia.Dirua
            LblEnemyName.Text = etsaia.Izena
            Timer2.Start()
            Timer2.Interval = 25
        End If
        If PbHero.Left = 227 Then
            Timer2.Stop()
            PbSpectacular.Hide()
            BtnAtacar.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PbHero.Left -= 15
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PbEnemy.Left -= 15
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PbEnemy.Left += 15
    End Sub
    Private Sub PbEnemy_LocationChanged(sender As Object, e As EventArgs) Handles PbEnemy.LocationChanged
        If PbEnemy.Left <= Me.PbHero.Location.X + PbHero.Width Then
            Timer3.Stop()
            Timer4.Start()
        End If
        If PbEnemy.Left = 574 Then
            Timer4.Stop()
        End If
    End Sub
End Class