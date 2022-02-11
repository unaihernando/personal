<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneroaZerrenda
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GenerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESADataSet = New _2_Erronka_DI.EMPRESADataSet()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GenerosTableAdapter = New _2_Erronka_DI.EMPRESADataSetTableAdapters.GenerosTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GenerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GenerosBindingSource
        Me.ComboBox1.DisplayMember = "NomGenero"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(657, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 26)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CodGenero"
        '
        'GenerosBindingSource
        '
        Me.GenerosBindingSource.DataMember = "Generos"
        Me.GenerosBindingSource.DataSource = Me.EMPRESADataSet
        '
        'EMPRESADataSet
        '
        Me.EMPRESADataSet.DataSetName = "EMPRESADataSet"
        Me.EMPRESADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(48, 165)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(820, 241)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GenerosTableAdapter
        '
        Me.GenerosTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(916, 25)
        Me.FillByToolStrip.TabIndex = 2
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(825, 30)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "GENEROA AUKERATU ETA BISTARATU GENERO HORRETAKO PELIKULAK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "AUKERATU GENEROA: "
        '
        'GeneroaZerrenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 418)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "GeneroaZerrenda"
        Me.Text = "GeneroaZerrenda"
        CType(Me.GenerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents EMPRESADataSet As EMPRESADataSet
    Friend WithEvents GenerosBindingSource As BindingSource
    Friend WithEvents GenerosTableAdapter As EMPRESADataSetTableAdapters.GenerosTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
