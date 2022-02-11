Public Class Pantalla_Inicio

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        mostrar()
    End Sub

    'Este método pasa los elemenos necesarios para cargar una partida anterior
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Dim JuegoForm As New Juego("cargar", "")
        JuegoForm.Show()
    End Sub

    'Cuando se pulsa el botón "enter", se pasarán a otro formulario los elementos necesarios para crear nueva partida
    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim JuegoForm As New Juego("nuevo", TxtName.Text)
            JuegoForm.Show()

            ocultar()
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ocultar()
    End Sub

    Private Sub Pantalla_Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        ocultar()
    End Sub

    'Oculta los datos referentes a nuevo jugador
    Private Sub ocultar()
        Me.TxtName.Text = ""
        Me.TxtName.Visible = False
        Me.PbName.Visible = False
        Me.BtnCerrar.Visible = False
    End Sub

    'Muestra los datos referentes al nuevo jugador
    Private Sub mostrar()
        Me.BtnCerrar.Visible = True
        Me.TxtName.Text = ""
        Me.TxtName.Visible = True
        Me.PbName.Visible = True
    End Sub
End Class
