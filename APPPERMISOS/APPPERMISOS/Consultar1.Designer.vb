<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TipopermisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaactualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorainicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorafinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoratotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JefesupervisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LSDREGISTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCURSADataSet = New APPPERMISOS.CONCURSADataSet()
        Me.LSDREGISTERTableAdapter = New APPPERMISOS.CONCURSADataSetTableAdapters.LSDREGISTERTableAdapter()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDREGISTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCURSADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 16)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Seleccione cédula"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightBlue
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(237, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(104, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 23)
        Me.TextBox2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Cédula: *"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 44)
        Me.Panel1.TabIndex = 86
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(465, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(311, 23)
        Me.TextBox1.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Nombre:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipopermisoDataGridViewTextBoxColumn, Me.OtrosDataGridViewTextBoxColumn, Me.FechainicialDataGridViewTextBoxColumn, Me.FechafinalDataGridViewTextBoxColumn, Me.FechaactualDataGridViewTextBoxColumn, Me.HorainicialDataGridViewTextBoxColumn, Me.HorafinalDataGridViewTextBoxColumn, Me.HoratotalDataGridViewTextBoxColumn, Me.JefesupervisorDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LSDREGISTERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(789, 298)
        Me.DataGridView1.TabIndex = 88
        '
        'TipopermisoDataGridViewTextBoxColumn
        '
        Me.TipopermisoDataGridViewTextBoxColumn.DataPropertyName = "tipopermiso"
        Me.TipopermisoDataGridViewTextBoxColumn.HeaderText = "tipopermiso"
        Me.TipopermisoDataGridViewTextBoxColumn.Name = "TipopermisoDataGridViewTextBoxColumn"
        Me.TipopermisoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OtrosDataGridViewTextBoxColumn
        '
        Me.OtrosDataGridViewTextBoxColumn.DataPropertyName = "otros"
        Me.OtrosDataGridViewTextBoxColumn.HeaderText = "otros"
        Me.OtrosDataGridViewTextBoxColumn.Name = "OtrosDataGridViewTextBoxColumn"
        Me.OtrosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechainicialDataGridViewTextBoxColumn
        '
        Me.FechainicialDataGridViewTextBoxColumn.DataPropertyName = "fechainicial"
        Me.FechainicialDataGridViewTextBoxColumn.HeaderText = "fechainicial"
        Me.FechainicialDataGridViewTextBoxColumn.Name = "FechainicialDataGridViewTextBoxColumn"
        Me.FechainicialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechafinalDataGridViewTextBoxColumn
        '
        Me.FechafinalDataGridViewTextBoxColumn.DataPropertyName = "fechafinal"
        Me.FechafinalDataGridViewTextBoxColumn.HeaderText = "fechafinal"
        Me.FechafinalDataGridViewTextBoxColumn.Name = "FechafinalDataGridViewTextBoxColumn"
        Me.FechafinalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaactualDataGridViewTextBoxColumn
        '
        Me.FechaactualDataGridViewTextBoxColumn.DataPropertyName = "fechaactual"
        Me.FechaactualDataGridViewTextBoxColumn.HeaderText = "fechaactual"
        Me.FechaactualDataGridViewTextBoxColumn.Name = "FechaactualDataGridViewTextBoxColumn"
        Me.FechaactualDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorainicialDataGridViewTextBoxColumn
        '
        Me.HorainicialDataGridViewTextBoxColumn.DataPropertyName = "horainicial"
        Me.HorainicialDataGridViewTextBoxColumn.HeaderText = "horainicial"
        Me.HorainicialDataGridViewTextBoxColumn.Name = "HorainicialDataGridViewTextBoxColumn"
        Me.HorainicialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorafinalDataGridViewTextBoxColumn
        '
        Me.HorafinalDataGridViewTextBoxColumn.DataPropertyName = "horafinal"
        Me.HorafinalDataGridViewTextBoxColumn.HeaderText = "horafinal"
        Me.HorafinalDataGridViewTextBoxColumn.Name = "HorafinalDataGridViewTextBoxColumn"
        Me.HorafinalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoratotalDataGridViewTextBoxColumn
        '
        Me.HoratotalDataGridViewTextBoxColumn.DataPropertyName = "horatotal"
        Me.HoratotalDataGridViewTextBoxColumn.HeaderText = "horatotal"
        Me.HoratotalDataGridViewTextBoxColumn.Name = "HoratotalDataGridViewTextBoxColumn"
        Me.HoratotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JefesupervisorDataGridViewTextBoxColumn
        '
        Me.JefesupervisorDataGridViewTextBoxColumn.DataPropertyName = "jefe_supervisor"
        Me.JefesupervisorDataGridViewTextBoxColumn.HeaderText = "jefe_supervisor"
        Me.JefesupervisorDataGridViewTextBoxColumn.Name = "JefesupervisorDataGridViewTextBoxColumn"
        Me.JefesupervisorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LSDREGISTERBindingSource
        '
        Me.LSDREGISTERBindingSource.DataMember = "LSDREGISTER"
        Me.LSDREGISTERBindingSource.DataSource = Me.CONCURSADataSet
        '
        'CONCURSADataSet
        '
        Me.CONCURSADataSet.DataSetName = "CONCURSADataSet"
        Me.CONCURSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LSDREGISTERTableAdapter
        '
        Me.LSDREGISTERTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(104, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 23)
        Me.TextBox3.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Dirección:"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(386, 85)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(161, 23)
        Me.TextBox4.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Departamento:"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(630, 85)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(161, 23)
        Me.TextBox5.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(554, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Sección:"
        '
        'Consultar1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 441)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Consultar1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar permisos por cédula"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDREGISTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCURSADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CONCURSADataSet As APPPERMISOS.CONCURSADataSet
    Friend WithEvents LSDREGISTERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LSDREGISTERTableAdapter As APPPERMISOS.CONCURSADataSetTableAdapters.LSDREGISTERTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TipopermisoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaactualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorainicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorafinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoratotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JefesupervisorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
