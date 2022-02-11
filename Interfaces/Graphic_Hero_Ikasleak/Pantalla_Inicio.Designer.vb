<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.PbName = New System.Windows.Forms.PictureBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.PbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(357, 208)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(115, 40)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "JUEGO NUEVO"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(357, 296)
        Me.BtnCargar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(115, 41)
        Me.BtnCargar.TabIndex = 1
        Me.BtnCargar.Text = "CARGAR PARTIDA"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'PbName
        '
        Me.PbName.BackColor = System.Drawing.Color.Transparent
        Me.PbName.Image = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.header
        Me.PbName.Location = New System.Drawing.Point(317, 230)
        Me.PbName.Margin = New System.Windows.Forms.Padding(2)
        Me.PbName.Name = "PbName"
        Me.PbName.Size = New System.Drawing.Size(195, 61)
        Me.PbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbName.TabIndex = 3
        Me.PbName.TabStop = False
        Me.PbName.Visible = False
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtName.Location = New System.Drawing.Point(357, 242)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(116, 20)
        Me.TxtName.TabIndex = 4
        Me.TxtName.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(491, 228)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(20, 19)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        Me.BtnCerrar.Visible = False
        '
        'Pantalla_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Graphic_Hero_Ikasleak.My.Resources.Resources.mainscreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 507)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PbName)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pantalla_Inicio"
        Me.Text = "Form1"
        CType(Me.PbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCargar As Button
    Friend WithEvents PbName As PictureBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnCerrar As Button
End Class
