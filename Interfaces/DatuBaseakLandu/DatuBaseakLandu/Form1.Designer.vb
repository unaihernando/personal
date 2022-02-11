<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TelefonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TFNOSDataSet = New DatuBaseakLandu.TFNOSDataSet()
        Me.TelefonosTableAdapter = New DatuBaseakLandu.TFNOSDataSetTableAdapters.telefonosTableAdapter()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.TelefonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFNOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Kargatu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(500, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Garbitu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TelefonosBindingSource
        '
        Me.TelefonosBindingSource.DataMember = "telefonos"
        Me.TelefonosBindingSource.DataSource = Me.TFNOSDataSet
        '
        'TFNOSDataSet
        '
        Me.TFNOSDataSet.DataSetName = "TFNOSDataSet"
        Me.TFNOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TelefonosTableAdapter
        '
        Me.TelefonosTableAdapter.ClearBeforeFill = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(121, 104)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(248, 189)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TelefonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFNOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TFNOSDataSet As TFNOSDataSet
    Friend WithEvents TelefonosBindingSource As BindingSource
    Friend WithEvents TelefonosTableAdapter As TFNOSDataSetTableAdapters.telefonosTableAdapter
    Friend WithEvents ListView1 As ListView
End Class
