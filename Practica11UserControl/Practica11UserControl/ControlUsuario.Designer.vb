<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.MiLista = New System.Windows.Forms.ListBox()
        Me.MiTexto = New System.Windows.Forms.TextBox()
        Me.MiBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MiLista
        '
        Me.MiLista.AllowDrop = True
        Me.MiLista.FormattingEnabled = True
        Me.MiLista.ItemHeight = 16
        Me.MiLista.Items.AddRange(New Object() {"Rojo", "Azul", "Verde", "Amarillo"})
        Me.MiLista.Location = New System.Drawing.Point(21, 75)
        Me.MiLista.Margin = New System.Windows.Forms.Padding(4)
        Me.MiLista.Name = "MiLista"
        Me.MiLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.MiLista.Size = New System.Drawing.Size(200, 164)
        Me.MiLista.TabIndex = 0
        '
        'MiTexto
        '
        Me.MiTexto.Location = New System.Drawing.Point(23, 268)
        Me.MiTexto.Margin = New System.Windows.Forms.Padding(4)
        Me.MiTexto.Name = "MiTexto"
        Me.MiTexto.Size = New System.Drawing.Size(200, 22)
        Me.MiTexto.TabIndex = 1
        '
        'MiBoton
        '
        Me.MiBoton.Location = New System.Drawing.Point(23, 25)
        Me.MiBoton.Margin = New System.Windows.Forms.Padding(4)
        Me.MiBoton.Name = "MiBoton"
        Me.MiBoton.Size = New System.Drawing.Size(200, 28)
        Me.MiBoton.TabIndex = 3
        Me.MiBoton.Text = "Borrar lista"
        Me.MiBoton.UseVisualStyleBackColor = True
        '
        'ControlUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MiBoton)
        Me.Controls.Add(Me.MiTexto)
        Me.Controls.Add(Me.MiLista)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ControlUsuario"
        Me.Size = New System.Drawing.Size(248, 316)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiLista As ListBox
    Friend WithEvents MiTexto As TextBox
    Friend WithEvents MiBoton As Button
End Class
