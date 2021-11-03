<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Imagen
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
        Me.PctBx_imagen = New System.Windows.Forms.PictureBox()
        CType(Me.PctBx_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PctBx_imagen
        '
        Me.PctBx_imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PctBx_imagen.Location = New System.Drawing.Point(0, 0)
        Me.PctBx_imagen.Name = "PctBx_imagen"
        Me.PctBx_imagen.Size = New System.Drawing.Size(682, 404)
        Me.PctBx_imagen.TabIndex = 0
        Me.PctBx_imagen.TabStop = False
        '
        'Form_Imagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 404)
        Me.Controls.Add(Me.PctBx_imagen)
        Me.Name = "Form_Imagen"
        Me.Text = "Form_Imagen"
        CType(Me.PctBx_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PctBx_imagen As PictureBox
End Class
