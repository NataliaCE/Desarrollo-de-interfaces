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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYSusPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasYSusProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresYSusProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.VentanasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanasToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesYSusPedidosToolStripMenuItem, Me.CategoriasYSusProductosToolStripMenuItem, Me.ProveedoresYSusProductosToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AbrirToolStripMenuItem.Text = "Abrir..."
        '
        'ClientesYSusPedidosToolStripMenuItem
        '
        Me.ClientesYSusPedidosToolStripMenuItem.Name = "ClientesYSusPedidosToolStripMenuItem"
        Me.ClientesYSusPedidosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.ClientesYSusPedidosToolStripMenuItem.Text = "Clientes y sus pedidos"
        '
        'CategoriasYSusProductosToolStripMenuItem
        '
        Me.CategoriasYSusProductosToolStripMenuItem.Name = "CategoriasYSusProductosToolStripMenuItem"
        Me.CategoriasYSusProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.CategoriasYSusProductosToolStripMenuItem.Text = "Categorias y sus productos"
        '
        'ProveedoresYSusProductosToolStripMenuItem
        '
        Me.ProveedoresYSusProductosToolStripMenuItem.Name = "ProveedoresYSusProductosToolStripMenuItem"
        Me.ProveedoresYSusProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.ProveedoresYSusProductosToolStripMenuItem.Text = "Proveedores y sus productos"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 621)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesYSusPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasYSusProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresYSusProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As ToolStripMenuItem
End Class
