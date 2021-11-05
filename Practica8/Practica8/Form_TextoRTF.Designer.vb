<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TextoRTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TextoRTF))
        Me.RichT_texto = New System.Windows.Forms.RichTextBox()
        Me.MenuContextual = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuContextual.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichT_texto
        '
        Me.RichT_texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichT_texto.Location = New System.Drawing.Point(0, 0)
        Me.RichT_texto.Name = "RichT_texto"
        Me.RichT_texto.Size = New System.Drawing.Size(800, 450)
        Me.RichT_texto.TabIndex = 0
        Me.RichT_texto.Text = ""
        '
        'MenuContextual
        '
        Me.MenuContextual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.InsertarDesdePortapapelesToolStripMenuItem})
        Me.MenuContextual.Name = "MenuContextual"
        Me.MenuContextual.Size = New System.Drawing.Size(219, 48)
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'InsertarDesdePortapapelesToolStripMenuItem
        '
        Me.InsertarDesdePortapapelesToolStripMenuItem.Name = "InsertarDesdePortapapelesToolStripMenuItem"
        Me.InsertarDesdePortapapelesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InsertarDesdePortapapelesToolStripMenuItem.Text = "Insertar desde portapapeles"
        '
        'Form_TextoRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.MenuContextual
        Me.Controls.Add(Me.RichT_texto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_TextoRTF"
        Me.Text = "TextoRTF"
        Me.MenuContextual.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichT_texto As RichTextBox
    Friend WithEvents MenuContextual As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
