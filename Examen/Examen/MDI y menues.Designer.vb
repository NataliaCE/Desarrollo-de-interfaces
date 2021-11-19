<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_y_menues
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PizarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarPizarraActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaReloj = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusTiempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelTiempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.FechaReloj.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PizarrasToolStripMenuItem, Me.VentanasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PizarrasToolStripMenuItem
        '
        Me.PizarrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImagenesToolStripMenuItem, Me.TextosToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarPizarraActivaToolStripMenuItem, Me.CerrarTodasToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.PizarrasToolStripMenuItem.Name = "PizarrasToolStripMenuItem"
        Me.PizarrasToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PizarrasToolStripMenuItem.Text = "Pizarras"
        '
        'ImagenesToolStripMenuItem
        '
        Me.ImagenesToolStripMenuItem.Name = "ImagenesToolStripMenuItem"
        Me.ImagenesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ImagenesToolStripMenuItem.Text = "Imagenes"
        '
        'TextosToolStripMenuItem
        '
        Me.TextosToolStripMenuItem.Name = "TextosToolStripMenuItem"
        Me.TextosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TextosToolStripMenuItem.Text = "Textos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 6)
        '
        'CerrarPizarraActivaToolStripMenuItem
        '
        Me.CerrarPizarraActivaToolStripMenuItem.Name = "CerrarPizarraActivaToolStripMenuItem"
        Me.CerrarPizarraActivaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CerrarPizarraActivaToolStripMenuItem.Text = "Cerrar pizarra activa"
        '
        'CerrarTodasToolStripMenuItem
        '
        Me.CerrarTodasToolStripMenuItem.Name = "CerrarTodasToolStripMenuItem"
        Me.CerrarTodasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CerrarTodasToolStripMenuItem.Text = "Cerrar todas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'FechaReloj
        '
        Me.FechaReloj.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusTiempo, Me.LabelTiempo})
        Me.FechaReloj.Location = New System.Drawing.Point(0, 422)
        Me.FechaReloj.Name = "FechaReloj"
        Me.FechaReloj.Size = New System.Drawing.Size(800, 22)
        Me.FechaReloj.TabIndex = 2
        Me.FechaReloj.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusTiempo
        '
        Me.ToolStripStatusTiempo.Name = "ToolStripStatusTiempo"
        Me.ToolStripStatusTiempo.Size = New System.Drawing.Size(0, 17)
        '
        'LabelTiempo
        '
        Me.LabelTiempo.Name = "LabelTiempo"
        Me.LabelTiempo.Size = New System.Drawing.Size(119, 17)
        Me.LabelTiempo.Text = "ToolStripStatusLabel2"
        '
        'MDI_y_menues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 444)
        Me.Controls.Add(Me.FechaReloj)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI_y_menues"
        Me.Text = "MDI_y_menues"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FechaReloj.ResumeLayout(False)
        Me.FechaReloj.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PizarrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarPizarraActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaReloj As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusTiempo As ToolStripStatusLabel
    Friend WithEvents LabelTiempo As ToolStripStatusLabel
End Class
