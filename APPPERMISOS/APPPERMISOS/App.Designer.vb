
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCédulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCédulaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNombreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevoToolStripMenuItem, Me.ActualizarPermisoToolStripMenuItem, Me.EliminarPermisoToolStripMenuItem, Me.ConsultarPermisosToolStripMenuItem, Me.ImprimirPermisoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearNuevoToolStripMenuItem
        '
        Me.CrearNuevoToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearNuevoToolStripMenuItem.Name = "CrearNuevoToolStripMenuItem"
        Me.CrearNuevoToolStripMenuItem.Size = New System.Drawing.Size(103, 21)
        Me.CrearNuevoToolStripMenuItem.Text = "Crear Nuevo"
        '
        'ActualizarPermisoToolStripMenuItem
        '
        Me.ActualizarPermisoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorCédulaToolStripMenuItem, Me.PorNombreToolStripMenuItem})
        Me.ActualizarPermisoToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarPermisoToolStripMenuItem.Name = "ActualizarPermisoToolStripMenuItem"
        Me.ActualizarPermisoToolStripMenuItem.Size = New System.Drawing.Size(84, 21)
        Me.ActualizarPermisoToolStripMenuItem.Text = "Actualizar"
        '
        'PorCédulaToolStripMenuItem
        '
        Me.PorCédulaToolStripMenuItem.Name = "PorCédulaToolStripMenuItem"
        Me.PorCédulaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PorCédulaToolStripMenuItem.Text = "Por cédula"
        '
        'PorNombreToolStripMenuItem
        '
        Me.PorNombreToolStripMenuItem.Name = "PorNombreToolStripMenuItem"
        Me.PorNombreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PorNombreToolStripMenuItem.Text = "Por nombre"
        '
        'EliminarPermisoToolStripMenuItem
        '
        Me.EliminarPermisoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorCédulaToolStripMenuItem1, Me.PorNombreToolStripMenuItem1})
        Me.EliminarPermisoToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarPermisoToolStripMenuItem.Name = "EliminarPermisoToolStripMenuItem"
        Me.EliminarPermisoToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.EliminarPermisoToolStripMenuItem.Text = "Eliminar"
        '
        'PorCédulaToolStripMenuItem1
        '
        Me.PorCédulaToolStripMenuItem1.Name = "PorCédulaToolStripMenuItem1"
        Me.PorCédulaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PorCédulaToolStripMenuItem1.Text = "Por cédula"
        '
        'PorNombreToolStripMenuItem1
        '
        Me.PorNombreToolStripMenuItem1.Name = "PorNombreToolStripMenuItem1"
        Me.PorNombreToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PorNombreToolStripMenuItem1.Text = "Por nombre"
        '
        'ConsultarPermisosToolStripMenuItem
        '
        Me.ConsultarPermisosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarPermisosToolStripMenuItem.Name = "ConsultarPermisosToolStripMenuItem"
        Me.ConsultarPermisosToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.ConsultarPermisosToolStripMenuItem.Text = "Consultar"
        '
        'ImprimirPermisoToolStripMenuItem
        '
        Me.ImprimirPermisoToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirPermisoToolStripMenuItem.Name = "ImprimirPermisoToolStripMenuItem"
        Me.ImprimirPermisoToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.ImprimirPermisoToolStripMenuItem.Text = "Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(735, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de permiso"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CrearNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarPermisoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCédulaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPermisoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCédulaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorNombreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImprimirPermisoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
