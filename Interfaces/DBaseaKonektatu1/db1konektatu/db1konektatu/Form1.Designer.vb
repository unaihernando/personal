<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1. DBsera konektatu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2. Kontatu Customer-ExecuteScalar "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(227, 62)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3-Txertatu Customers_ExecuteNonQuery"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(34, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(227, 62)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4-Ezabatu Customers_ExecuteNonQuery"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(34, 357)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(227, 62)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5-Eguneratu Prices_ExecuteNonQuery"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(34, 442)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(227, 62)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6- Irakurri Customers_ExecuteReader"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(364, 43)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(608, 553)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(34, 521)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(227, 62)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7. Kontatu Parametroekin Customer-ExecuteScalar "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 608)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button7 As Button
End Class
