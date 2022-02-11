<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblRoom1 = New System.Windows.Forms.Label()
        Me.LblRoom2 = New System.Windows.Forms.Label()
        Me.LblRoom3 = New System.Windows.Forms.Label()
        Me.BtnAtacar = New System.Windows.Forms.Button()
        Me.BtnEstadi = New System.Windows.Forms.Button()
        Me.BtnUsar = New System.Windows.Forms.Button()
        Me.BtnComerciar = New System.Windows.Forms.Button()
        Me.LblPlayerName = New System.Windows.Forms.Label()
        Me.LblPlayerDmg = New System.Windows.Forms.Label()
        Me.LblPlayerGold = New System.Windows.Forms.Label()
        Me.LblPlayerItems = New System.Windows.Forms.Label()
        Me.LblHeroHealthBar = New System.Windows.Forms.Label()
        Me.LblEnemyHealthBar = New System.Windows.Forms.Label()
        Me.LblEnemyGold = New System.Windows.Forms.Label()
        Me.LblEnemyDmg = New System.Windows.Forms.Label()
        Me.LblEnemyName = New System.Windows.Forms.Label()
        Me.LblNPociones = New System.Windows.Forms.Label()
        Me.GbComerciar = New System.Windows.Forms.GroupBox()
        Me.BtnCerrarComerciar = New System.Windows.Forms.Button()
        Me.TxtComerciar = New System.Windows.Forms.TextBox()
        Me.BtnAceptarComerciar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PbSpectacular = New System.Windows.Forms.PictureBox()
        Me.PbEnemyHealth = New System.Windows.Forms.PictureBox()
        Me.PbEnemy = New System.Windows.Forms.PictureBox()
        Me.PbStats = New System.Windows.Forms.PictureBox()
        Me.PbHeroHealth = New System.Windows.Forms.PictureBox()
        Me.PbHero = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.GbComerciar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbSpectacular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEnemyHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbHeroHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(204, 134)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(19, 23)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        Me.BtnCerrar.Visible = False
        '
        'LblRoom1
        '
        Me.LblRoom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoom1.Location = New System.Drawing.Point(202, 34)
        Me.LblRoom1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRoom1.Name = "LblRoom1"
        Me.LblRoom1.Size = New System.Drawing.Size(33, 27)
        Me.LblRoom1.TabIndex = 6
        Me.LblRoom1.Text = "1"
        Me.LblRoom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRoom2
        '
        Me.LblRoom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoom2.Location = New System.Drawing.Point(239, 34)
        Me.LblRoom2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRoom2.Name = "LblRoom2"
        Me.LblRoom2.Size = New System.Drawing.Size(33, 27)
        Me.LblRoom2.TabIndex = 7
        Me.LblRoom2.Text = "-"
        Me.LblRoom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRoom3
        '
        Me.LblRoom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoom3.Location = New System.Drawing.Point(277, 34)
        Me.LblRoom3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRoom3.Name = "LblRoom3"
        Me.LblRoom3.Size = New System.Drawing.Size(33, 27)
        Me.LblRoom3.TabIndex = 8
        Me.LblRoom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAtacar
        '
        Me.BtnAtacar.Location = New System.Drawing.Point(260, 379)
        Me.BtnAtacar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAtacar.Name = "BtnAtacar"
        Me.BtnAtacar.Size = New System.Drawing.Size(60, 28)
        Me.BtnAtacar.TabIndex = 11
        Me.BtnAtacar.Tag = "atacar"
        Me.BtnAtacar.Text = "ATACAR"
        Me.BtnAtacar.UseVisualStyleBackColor = True
        '
        'BtnEstadi
        '
        Me.BtnEstadi.Location = New System.Drawing.Point(339, 379)
        Me.BtnEstadi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEstadi.Name = "BtnEstadi"
        Me.BtnEstadi.Size = New System.Drawing.Size(95, 28)
        Me.BtnEstadi.TabIndex = 12
        Me.BtnEstadi.Tag = "stats"
        Me.BtnEstadi.Text = "ESTADISTICAS"
        Me.BtnEstadi.UseVisualStyleBackColor = True
        '
        'BtnUsar
        '
        Me.BtnUsar.Location = New System.Drawing.Point(456, 379)
        Me.BtnUsar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUsar.Name = "BtnUsar"
        Me.BtnUsar.Size = New System.Drawing.Size(76, 28)
        Me.BtnUsar.TabIndex = 13
        Me.BtnUsar.Tag = "usar"
        Me.BtnUsar.Text = "USAR"
        Me.BtnUsar.UseVisualStyleBackColor = True
        '
        'BtnComerciar
        '
        Me.BtnComerciar.Location = New System.Drawing.Point(554, 379)
        Me.BtnComerciar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnComerciar.Name = "BtnComerciar"
        Me.BtnComerciar.Size = New System.Drawing.Size(80, 28)
        Me.BtnComerciar.TabIndex = 14
        Me.BtnComerciar.Tag = "comerciar"
        Me.BtnComerciar.Text = "COMERCIAR"
        Me.BtnComerciar.UseVisualStyleBackColor = True
        '
        'LblPlayerName
        '
        Me.LblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerName.Location = New System.Drawing.Point(53, 144)
        Me.LblPlayerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPlayerName.Name = "LblPlayerName"
        Me.LblPlayerName.Size = New System.Drawing.Size(127, 19)
        Me.LblPlayerName.TabIndex = 15
        Me.LblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblPlayerName.Visible = False
        '
        'LblPlayerDmg
        '
        Me.LblPlayerDmg.Location = New System.Drawing.Point(55, 253)
        Me.LblPlayerDmg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPlayerDmg.Name = "LblPlayerDmg"
        Me.LblPlayerDmg.Size = New System.Drawing.Size(127, 19)
        Me.LblPlayerDmg.TabIndex = 17
        Me.LblPlayerDmg.Text = "Daño: "
        Me.LblPlayerDmg.Visible = False
        '
        'LblPlayerGold
        '
        Me.LblPlayerGold.Location = New System.Drawing.Point(55, 273)
        Me.LblPlayerGold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPlayerGold.Name = "LblPlayerGold"
        Me.LblPlayerGold.Size = New System.Drawing.Size(127, 19)
        Me.LblPlayerGold.TabIndex = 18
        Me.LblPlayerGold.Text = "Oro: "
        Me.LblPlayerGold.Visible = False
        '
        'LblPlayerItems
        '
        Me.LblPlayerItems.Location = New System.Drawing.Point(55, 293)
        Me.LblPlayerItems.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPlayerItems.Name = "LblPlayerItems"
        Me.LblPlayerItems.Size = New System.Drawing.Size(127, 19)
        Me.LblPlayerItems.TabIndex = 19
        Me.LblPlayerItems.Text = "Items: "
        Me.LblPlayerItems.Visible = False
        '
        'LblHeroHealthBar
        '
        Me.LblHeroHealthBar.Location = New System.Drawing.Point(248, 339)
        Me.LblHeroHealthBar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHeroHealthBar.Name = "LblHeroHealthBar"
        Me.LblHeroHealthBar.Size = New System.Drawing.Size(84, 15)
        Me.LblHeroHealthBar.TabIndex = 20
        Me.LblHeroHealthBar.Text = "0"
        Me.LblHeroHealthBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEnemyHealthBar
        '
        Me.LblEnemyHealthBar.Location = New System.Drawing.Point(595, 339)
        Me.LblEnemyHealthBar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnemyHealthBar.Name = "LblEnemyHealthBar"
        Me.LblEnemyHealthBar.Size = New System.Drawing.Size(84, 15)
        Me.LblEnemyHealthBar.TabIndex = 21
        Me.LblEnemyHealthBar.Text = "0"
        Me.LblEnemyHealthBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEnemyGold
        '
        Me.LblEnemyGold.Location = New System.Drawing.Point(716, 256)
        Me.LblEnemyGold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnemyGold.Name = "LblEnemyGold"
        Me.LblEnemyGold.Size = New System.Drawing.Size(118, 19)
        Me.LblEnemyGold.TabIndex = 27
        Me.LblEnemyGold.Text = "Oro: "
        '
        'LblEnemyDmg
        '
        Me.LblEnemyDmg.Location = New System.Drawing.Point(716, 236)
        Me.LblEnemyDmg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnemyDmg.Name = "LblEnemyDmg"
        Me.LblEnemyDmg.Size = New System.Drawing.Size(118, 19)
        Me.LblEnemyDmg.TabIndex = 26
        Me.LblEnemyDmg.Text = "Daño: "
        '
        'LblEnemyName
        '
        Me.LblEnemyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnemyName.Location = New System.Drawing.Point(706, 144)
        Me.LblEnemyName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnemyName.Name = "LblEnemyName"
        Me.LblEnemyName.Size = New System.Drawing.Size(127, 19)
        Me.LblEnemyName.TabIndex = 28
        Me.LblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNPociones
        '
        Me.LblNPociones.AutoSize = True
        Me.LblNPociones.Location = New System.Drawing.Point(17, 32)
        Me.LblNPociones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNPociones.Name = "LblNPociones"
        Me.LblNPociones.Size = New System.Drawing.Size(66, 13)
        Me.LblNPociones.TabIndex = 29
        Me.LblNPociones.Text = "Nº Pociones"
        '
        'GbComerciar
        '
        Me.GbComerciar.Controls.Add(Me.BtnCerrarComerciar)
        Me.GbComerciar.Controls.Add(Me.TxtComerciar)
        Me.GbComerciar.Controls.Add(Me.BtnAceptarComerciar)
        Me.GbComerciar.Controls.Add(Me.LblNPociones)
        Me.GbComerciar.Location = New System.Drawing.Point(292, 427)
        Me.GbComerciar.Margin = New System.Windows.Forms.Padding(2)
        Me.GbComerciar.Name = "GbComerciar"
        Me.GbComerciar.Padding = New System.Windows.Forms.Padding(2)
        Me.GbComerciar.Size = New System.Drawing.Size(268, 81)
        Me.GbComerciar.TabIndex = 30
        Me.GbComerciar.TabStop = False
        Me.GbComerciar.Text = "Comerciar"
        Me.GbComerciar.Visible = False
        '
        'BtnCerrarComerciar
        '
        Me.BtnCerrarComerciar.Location = New System.Drawing.Point(246, 0)
        Me.BtnCerrarComerciar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarComerciar.Name = "BtnCerrarComerciar"
        Me.BtnCerrarComerciar.Size = New System.Drawing.Size(22, 19)
        Me.BtnCerrarComerciar.TabIndex = 32
        Me.BtnCerrarComerciar.Text = "X"
        Me.BtnCerrarComerciar.UseVisualStyleBackColor = True
        '
        'TxtComerciar
        '
        Me.TxtComerciar.Location = New System.Drawing.Point(86, 32)
        Me.TxtComerciar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtComerciar.Name = "TxtComerciar"
        Me.TxtComerciar.Size = New System.Drawing.Size(76, 20)
        Me.TxtComerciar.TabIndex = 31
        '
        'BtnAceptarComerciar
        '
        Me.BtnAceptarComerciar.Location = New System.Drawing.Point(184, 30)
        Me.BtnAceptarComerciar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptarComerciar.Name = "BtnAceptarComerciar"
        Me.BtnAceptarComerciar.Size = New System.Drawing.Size(56, 23)
        Me.BtnAceptarComerciar.TabIndex = 30
        Me.BtnAceptarComerciar.Text = "Aceptar"
        Me.BtnAceptarComerciar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.statistics
        Me.PictureBox1.Location = New System.Drawing.Point(688, 134)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 247)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PbSpectacular
        '
        Me.PbSpectacular.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.combo_spectacular
        Me.PbSpectacular.Location = New System.Drawing.Point(370, 107)
        Me.PbSpectacular.Margin = New System.Windows.Forms.Padding(2)
        Me.PbSpectacular.Name = "PbSpectacular"
        Me.PbSpectacular.Size = New System.Drawing.Size(172, 60)
        Me.PbSpectacular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSpectacular.TabIndex = 22
        Me.PbSpectacular.TabStop = False
        Me.PbSpectacular.Visible = False
        '
        'PbEnemyHealth
        '
        Me.PbEnemyHealth.BackColor = System.Drawing.Color.Transparent
        Me.PbEnemyHealth.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.health_frame
        Me.PbEnemyHealth.Location = New System.Drawing.Point(574, 335)
        Me.PbEnemyHealth.Margin = New System.Windows.Forms.Padding(2)
        Me.PbEnemyHealth.Name = "PbEnemyHealth"
        Me.PbEnemyHealth.Size = New System.Drawing.Size(109, 27)
        Me.PbEnemyHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEnemyHealth.TabIndex = 10
        Me.PbEnemyHealth.TabStop = False
        '
        'PbEnemy
        '
        Me.PbEnemy.BackColor = System.Drawing.Color.Transparent
        Me.PbEnemy.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.goblin
        Me.PbEnemy.Location = New System.Drawing.Point(574, 173)
        Me.PbEnemy.Margin = New System.Windows.Forms.Padding(2)
        Me.PbEnemy.Name = "PbEnemy"
        Me.PbEnemy.Size = New System.Drawing.Size(116, 157)
        Me.PbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEnemy.TabIndex = 9
        Me.PbEnemy.TabStop = False
        '
        'PbStats
        '
        Me.PbStats.BackColor = System.Drawing.Color.Transparent
        Me.PbStats.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.statistics
        Me.PbStats.Location = New System.Drawing.Point(9, 134)
        Me.PbStats.Margin = New System.Windows.Forms.Padding(2)
        Me.PbStats.Name = "PbStats"
        Me.PbStats.Size = New System.Drawing.Size(214, 284)
        Me.PbStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbStats.TabIndex = 3
        Me.PbStats.TabStop = False
        Me.PbStats.Visible = False
        '
        'PbHeroHealth
        '
        Me.PbHeroHealth.BackColor = System.Drawing.Color.Transparent
        Me.PbHeroHealth.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.health_frame
        Me.PbHeroHealth.Location = New System.Drawing.Point(227, 335)
        Me.PbHeroHealth.Margin = New System.Windows.Forms.Padding(2)
        Me.PbHeroHealth.Name = "PbHeroHealth"
        Me.PbHeroHealth.Size = New System.Drawing.Size(109, 27)
        Me.PbHeroHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHeroHealth.TabIndex = 2
        Me.PbHeroHealth.TabStop = False
        '
        'PbHero
        '
        Me.PbHero.BackColor = System.Drawing.Color.Transparent
        Me.PbHero.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.hero
        Me.PbHero.Location = New System.Drawing.Point(227, 173)
        Me.PbHero.Margin = New System.Windows.Forms.Padding(2)
        Me.PbHero.Name = "PbHero"
        Me.PbHero.Size = New System.Drawing.Size(109, 157)
        Me.PbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHero.TabIndex = 1
        Me.PbHero.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.game_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(849, 533)
        Me.Controls.Add(Me.GbComerciar)
        Me.Controls.Add(Me.LblEnemyName)
        Me.Controls.Add(Me.LblEnemyGold)
        Me.Controls.Add(Me.LblEnemyDmg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PbSpectacular)
        Me.Controls.Add(Me.LblEnemyHealthBar)
        Me.Controls.Add(Me.LblHeroHealthBar)
        Me.Controls.Add(Me.LblPlayerItems)
        Me.Controls.Add(Me.LblPlayerGold)
        Me.Controls.Add(Me.LblPlayerDmg)
        Me.Controls.Add(Me.LblPlayerName)
        Me.Controls.Add(Me.BtnComerciar)
        Me.Controls.Add(Me.BtnUsar)
        Me.Controls.Add(Me.BtnEstadi)
        Me.Controls.Add(Me.BtnAtacar)
        Me.Controls.Add(Me.PbEnemyHealth)
        Me.Controls.Add(Me.PbEnemy)
        Me.Controls.Add(Me.LblRoom3)
        Me.Controls.Add(Me.LblRoom2)
        Me.Controls.Add(Me.LblRoom1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PbStats)
        Me.Controls.Add(Me.PbHeroHealth)
        Me.Controls.Add(Me.PbHero)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Juego"
        Me.Text = "Juego"
        Me.GbComerciar.ResumeLayout(False)
        Me.GbComerciar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbSpectacular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEnemyHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbHeroHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PbHero As PictureBox
    Friend WithEvents PbHeroHealth As PictureBox
    Friend WithEvents PbStats As PictureBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblRoom1 As Label
    Friend WithEvents LblRoom2 As Label
    Friend WithEvents LblRoom3 As Label
    Friend WithEvents PbEnemy As PictureBox
    Friend WithEvents PbEnemyHealth As PictureBox
    Friend WithEvents BtnAtacar As Button
    Friend WithEvents BtnEstadi As Button
    Friend WithEvents BtnUsar As Button
    Friend WithEvents BtnComerciar As Button
    Friend WithEvents LblPlayerName As Label
    Friend WithEvents LblPlayerDmg As Label
    Friend WithEvents LblPlayerGold As Label
    Friend WithEvents LblPlayerItems As Label
    Friend WithEvents LblHeroHealthBar As Label
    Friend WithEvents LblEnemyHealthBar As Label
    Friend WithEvents PbSpectacular As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblEnemyGold As Label
    Friend WithEvents LblEnemyDmg As Label
    Friend WithEvents LblEnemyName As Label
    Friend WithEvents LblNPociones As Label
    Friend WithEvents GbComerciar As GroupBox
    Friend WithEvents TxtComerciar As TextBox
    Friend WithEvents BtnAceptarComerciar As Button
    Friend WithEvents BtnCerrarComerciar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
End Class
