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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasLasVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirDeLaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSitem_ventanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHerramientas = New System.Windows.Forms.ToolStrip()
        Me.TS_texto = New System.Windows.Forms.ToolStripButton()
        Me.TS_imagen = New System.Windows.Forms.ToolStripButton()
        Me.TS_cerrar = New System.Windows.Forms.ToolStripButton()
        Me.TS_About = New System.Windows.Forms.ToolStripButton()
        Me.MenuPrincipal.SuspendLayout()
        Me.MenuHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.TSitem_ventanas, Me.ToolStripMenuItem2})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.TSitem_ventanas
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(787, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarHijosToolStripMenuItem, Me.CerrarVentanaActualToolStripMenuItem, Me.CerrarTodasLasVentanasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirDeLaAplicaciónToolStripMenuItem})
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'CargarHijosToolStripMenuItem
        '
        Me.CargarHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextoToolStripMenuItem, Me.ImagenToolStripMenuItem})
        Me.CargarHijosToolStripMenuItem.Name = "CargarHijosToolStripMenuItem"
        Me.CargarHijosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CargarHijosToolStripMenuItem.Text = "Cargar hijos"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'CerrarVentanaActualToolStripMenuItem
        '
        Me.CerrarVentanaActualToolStripMenuItem.Name = "CerrarVentanaActualToolStripMenuItem"
        Me.CerrarVentanaActualToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CerrarVentanaActualToolStripMenuItem.Text = "Cerrar ventana actual"
        '
        'CerrarTodasLasVentanasToolStripMenuItem
        '
        Me.CerrarTodasLasVentanasToolStripMenuItem.Name = "CerrarTodasLasVentanasToolStripMenuItem"
        Me.CerrarTodasLasVentanasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar todas las ventanas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'SalirDeLaAplicaciónToolStripMenuItem
        '
        Me.SalirDeLaAplicaciónToolStripMenuItem.Name = "SalirDeLaAplicaciónToolStripMenuItem"
        Me.SalirDeLaAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SalirDeLaAplicaciónToolStripMenuItem.Text = "Salir de la aplicación"
        '
        'TSitem_ventanas
        '
        Me.TSitem_ventanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.TSitem_ventanas.Name = "TSitem_ventanas"
        Me.TSitem_ventanas.Size = New System.Drawing.Size(140, 20)
        Me.TSitem_ventanas.Text = "Ventanas Hijos (Childs)"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'MenuHerramientas
        '
        Me.MenuHerramientas.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_texto, Me.TS_imagen, Me.TS_cerrar, Me.TS_About})
        Me.MenuHerramientas.Location = New System.Drawing.Point(0, 24)
        Me.MenuHerramientas.Name = "MenuHerramientas"
        Me.MenuHerramientas.Size = New System.Drawing.Size(787, 32)
        Me.MenuHerramientas.TabIndex = 1
        Me.MenuHerramientas.Text = "ToolStrip1"
        '
        'TS_texto
        '
        Me.TS_texto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_texto.Image = CType(resources.GetObject("TS_texto.Image"), System.Drawing.Image)
        Me.TS_texto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_texto.Name = "TS_texto"
        Me.TS_texto.Size = New System.Drawing.Size(29, 29)
        Me.TS_texto.Text = "Abrir texto"
        '
        'TS_imagen
        '
        Me.TS_imagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_imagen.Image = CType(resources.GetObject("TS_imagen.Image"), System.Drawing.Image)
        Me.TS_imagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_imagen.Name = "TS_imagen"
        Me.TS_imagen.Size = New System.Drawing.Size(29, 29)
        Me.TS_imagen.Text = "Abrir imagen"
        '
        'TS_cerrar
        '
        Me.TS_cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_cerrar.Image = CType(resources.GetObject("TS_cerrar.Image"), System.Drawing.Image)
        Me.TS_cerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_cerrar.Name = "TS_cerrar"
        Me.TS_cerrar.Size = New System.Drawing.Size(29, 29)
        Me.TS_cerrar.Text = "Cerrar ventanas"
        '
        'TS_About
        '
        Me.TS_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_About.Image = CType(resources.GetObject("TS_About.Image"), System.Drawing.Image)
        Me.TS_About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_About.Name = "TS_About"
        Me.TS_About.Size = New System.Drawing.Size(29, 29)
        Me.TS_About.Text = "Acerca de..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 467)
        Me.Controls.Add(Me.MenuHerramientas)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "Form1"
        Me.Text = "Formulario MDI"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.MenuHerramientas.ResumeLayout(False)
        Me.MenuHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarVentanaActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasLasVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirDeLaAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSitem_ventanas As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuHerramientas As ToolStrip
    Friend WithEvents TS_texto As ToolStripButton
    Friend WithEvents TS_imagen As ToolStripButton
    Friend WithEvents TS_cerrar As ToolStripButton
    Friend WithEvents TS_About As ToolStripButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
