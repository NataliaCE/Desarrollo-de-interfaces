<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Me.Barra_menu = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Barra_iconos = New System.Windows.Forms.ToolStrip()
        Me.PB_logo = New System.Windows.Forms.PictureBox()
        Me.TS_anadir = New System.Windows.Forms.ToolStripButton()
        Me.TS_editar = New System.Windows.Forms.ToolStripButton()
        Me.TS_listar = New System.Windows.Forms.ToolStripButton()
        Me.TS_borrar = New System.Windows.Forms.ToolStripButton()
        Me.Lbl_nomPantalla = New System.Windows.Forms.Label()
        Me.Btn_crear = New System.Windows.Forms.Button()
        Me.Btn_modificar = New System.Windows.Forms.Button()
        Me.Btn_listar = New System.Windows.Forms.Button()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.Barra_menu.SuspendLayout()
        Me.Barra_iconos.SuspendLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra_menu
        '
        Me.Barra_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.Barra_menu.Location = New System.Drawing.Point(0, 0)
        Me.Barra_menu.Name = "Barra_menu"
        Me.Barra_menu.Size = New System.Drawing.Size(800, 24)
        Me.Barra_menu.TabIndex = 0
        Me.Barra_menu.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearMaterialToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.ListarMaterialesToolStripMenuItem, Me.BorrarMaterialToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CrearMaterialToolStripMenuItem
        '
        Me.CrearMaterialToolStripMenuItem.Name = "CrearMaterialToolStripMenuItem"
        Me.CrearMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CrearMaterialToolStripMenuItem.Text = "Crear material"
        '
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar material"
        '
        'ListarMaterialesToolStripMenuItem
        '
        Me.ListarMaterialesToolStripMenuItem.Name = "ListarMaterialesToolStripMenuItem"
        Me.ListarMaterialesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListarMaterialesToolStripMenuItem.Text = "Listar materiales"
        '
        'BorrarMaterialToolStripMenuItem
        '
        Me.BorrarMaterialToolStripMenuItem.Name = "BorrarMaterialToolStripMenuItem"
        Me.BorrarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BorrarMaterialToolStripMenuItem.Text = "Borrar material"
        '
        'Barra_iconos
        '
        Me.Barra_iconos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Barra_iconos.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.Barra_iconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_anadir, Me.TS_editar, Me.TS_listar, Me.TS_borrar})
        Me.Barra_iconos.Location = New System.Drawing.Point(0, 24)
        Me.Barra_iconos.Name = "Barra_iconos"
        Me.Barra_iconos.Size = New System.Drawing.Size(800, 29)
        Me.Barra_iconos.TabIndex = 1
        Me.Barra_iconos.Text = "ToolStrip1"
        '
        'PB_logo
        '
        Me.PB_logo.Image = Global.AlmacenMateriales.My.Resources.Resources.logo
        Me.PB_logo.Location = New System.Drawing.Point(12, 67)
        Me.PB_logo.Name = "PB_logo"
        Me.PB_logo.Size = New System.Drawing.Size(50, 50)
        Me.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo.TabIndex = 2
        Me.PB_logo.TabStop = False
        '
        'TS_anadir
        '
        Me.TS_anadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_anadir.Image = Global.AlmacenMateriales.My.Resources.Resources.añadir
        Me.TS_anadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_anadir.Name = "TS_anadir"
        Me.TS_anadir.Size = New System.Drawing.Size(26, 26)
        Me.TS_anadir.Text = "ToolStripButton1"
        '
        'TS_editar
        '
        Me.TS_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_editar.Image = Global.AlmacenMateriales.My.Resources.Resources.editar
        Me.TS_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_editar.Name = "TS_editar"
        Me.TS_editar.Size = New System.Drawing.Size(26, 26)
        Me.TS_editar.Text = "ToolStripButton1"
        '
        'TS_listar
        '
        Me.TS_listar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_listar.Image = Global.AlmacenMateriales.My.Resources.Resources.listar
        Me.TS_listar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_listar.Name = "TS_listar"
        Me.TS_listar.Size = New System.Drawing.Size(26, 26)
        Me.TS_listar.Text = "ToolStripButton2"
        '
        'TS_borrar
        '
        Me.TS_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_borrar.Image = Global.AlmacenMateriales.My.Resources.Resources.borrar
        Me.TS_borrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_borrar.Name = "TS_borrar"
        Me.TS_borrar.Size = New System.Drawing.Size(26, 26)
        Me.TS_borrar.Text = "ToolStripButton3"
        '
        'Lbl_nomPantalla
        '
        Me.Lbl_nomPantalla.AutoSize = True
        Me.Lbl_nomPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomPantalla.Location = New System.Drawing.Point(68, 81)
        Me.Lbl_nomPantalla.Name = "Lbl_nomPantalla"
        Me.Lbl_nomPantalla.Size = New System.Drawing.Size(57, 25)
        Me.Lbl_nomPantalla.TabIndex = 3
        Me.Lbl_nomPantalla.Text = "Inicio"
        '
        'Btn_crear
        '
        Me.Btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_crear.Location = New System.Drawing.Point(296, 146)
        Me.Btn_crear.Name = "Btn_crear"
        Me.Btn_crear.Size = New System.Drawing.Size(158, 40)
        Me.Btn_crear.TabIndex = 4
        Me.Btn_crear.Text = "Crear material"
        Me.Btn_crear.UseVisualStyleBackColor = True
        '
        'Btn_modificar
        '
        Me.Btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modificar.Location = New System.Drawing.Point(296, 201)
        Me.Btn_modificar.Name = "Btn_modificar"
        Me.Btn_modificar.Size = New System.Drawing.Size(158, 40)
        Me.Btn_modificar.TabIndex = 5
        Me.Btn_modificar.Text = "Modificar material"
        Me.Btn_modificar.UseVisualStyleBackColor = True
        '
        'Btn_listar
        '
        Me.Btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listar.Location = New System.Drawing.Point(296, 256)
        Me.Btn_listar.Name = "Btn_listar"
        Me.Btn_listar.Size = New System.Drawing.Size(158, 40)
        Me.Btn_listar.TabIndex = 6
        Me.Btn_listar.Text = "Listar materiales"
        Me.Btn_listar.UseVisualStyleBackColor = True
        '
        'Btn_eliminar
        '
        Me.Btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eliminar.Location = New System.Drawing.Point(296, 309)
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.Size = New System.Drawing.Size(158, 40)
        Me.Btn_eliminar.TabIndex = 7
        Me.Btn_eliminar.Text = "Eliminar material"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_eliminar)
        Me.Controls.Add(Me.Btn_listar)
        Me.Controls.Add(Me.Btn_modificar)
        Me.Controls.Add(Me.Btn_crear)
        Me.Controls.Add(Me.Lbl_nomPantalla)
        Me.Controls.Add(Me.PB_logo)
        Me.Controls.Add(Me.Barra_iconos)
        Me.Controls.Add(Me.Barra_menu)
        Me.MainMenuStrip = Me.Barra_menu
        Me.Name = "Almacen"
        Me.Text = "Almacén de materiales"
        Me.Barra_menu.ResumeLayout(False)
        Me.Barra_menu.PerformLayout()
        Me.Barra_iconos.ResumeLayout(False)
        Me.Barra_iconos.PerformLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra_menu As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Barra_iconos As ToolStrip
    Friend WithEvents TS_anadir As ToolStripButton
    Friend WithEvents TS_editar As ToolStripButton
    Friend WithEvents TS_listar As ToolStripButton
    Friend WithEvents TS_borrar As ToolStripButton
    Friend WithEvents PB_logo As PictureBox
    Friend WithEvents Lbl_nomPantalla As Label
    Friend WithEvents Btn_crear As Button
    Friend WithEvents Btn_modificar As Button
    Friend WithEvents Btn_listar As Button
    Friend WithEvents Btn_eliminar As Button
End Class
