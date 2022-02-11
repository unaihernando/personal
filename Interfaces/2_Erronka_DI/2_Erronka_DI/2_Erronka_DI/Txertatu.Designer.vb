<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Txertatu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnInsertPar = New System.Windows.Forms.Button()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtProductora = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtCodGenero = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ERREGISTRO BERRIA TXERTATU"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(236, 65)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(482, 325)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnInsertPar
        '
        Me.btnInsertPar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInsertPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertPar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInsertPar.Location = New System.Drawing.Point(15, 315)
        Me.btnInsertPar.Name = "btnInsertPar"
        Me.btnInsertPar.Size = New System.Drawing.Size(205, 35)
        Me.btnInsertPar.TabIndex = 78
        Me.btnInsertPar.Text = "Gorde (parametrorik gabe)"
        Me.btnInsertPar.UseVisualStyleBackColor = False
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(76, 263)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(144, 20)
        Me.txtDirector.TabIndex = 77
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(76, 237)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(144, 20)
        Me.txtPrecio.TabIndex = 76
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(76, 211)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(144, 20)
        Me.txtPais.TabIndex = 75
        '
        'txtProductora
        '
        Me.txtProductora.Location = New System.Drawing.Point(76, 185)
        Me.txtProductora.Name = "txtProductora"
        Me.txtProductora.Size = New System.Drawing.Size(144, 20)
        Me.txtProductora.TabIndex = 74
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(76, 159)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(144, 20)
        Me.txtAño.TabIndex = 73
        '
        'txtCodGenero
        '
        Me.txtCodGenero.Location = New System.Drawing.Point(76, 133)
        Me.txtCodGenero.Name = "txtCodGenero"
        Me.txtCodGenero.Size = New System.Drawing.Size(144, 20)
        Me.txtCodGenero.TabIndex = 72
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(76, 107)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(144, 20)
        Me.txtDuracion.TabIndex = 71
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(76, 81)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(144, 20)
        Me.txtTitulo.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Director:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Pais:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Productora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "CodGenero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Duración:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Título:"
        '
        'Txertatu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 425)
        Me.Controls.Add(Me.btnInsertPar)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtProductora)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtCodGenero)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Txertatu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnInsertPar As Button
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtProductora As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtCodGenero As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
End Class
