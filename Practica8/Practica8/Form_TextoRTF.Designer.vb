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
        Me.CuadroTexto = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'CuadroTexto
        '
        Me.CuadroTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CuadroTexto.Location = New System.Drawing.Point(0, 0)
        Me.CuadroTexto.Name = "CuadroTexto"
        Me.CuadroTexto.Size = New System.Drawing.Size(640, 397)
        Me.CuadroTexto.TabIndex = 0
        Me.CuadroTexto.Text = ""
        '
        'Form_TextoRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 397)
        Me.Controls.Add(Me.CuadroTexto)
        Me.Name = "Form_TextoRTF"
        Me.Text = "Form_TextoRTF"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CuadroTexto As RichTextBox
End Class
