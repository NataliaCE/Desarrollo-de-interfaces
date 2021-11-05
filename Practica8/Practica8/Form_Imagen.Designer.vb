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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Imagen))
        Me.PcBx_imagen = New System.Windows.Forms.PictureBox()
        CType(Me.PcBx_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcBx_imagen
        '
        Me.PcBx_imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PcBx_imagen.Location = New System.Drawing.Point(0, 0)
        Me.PcBx_imagen.Name = "PcBx_imagen"
        Me.PcBx_imagen.Size = New System.Drawing.Size(476, 298)
        Me.PcBx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBx_imagen.TabIndex = 0
        Me.PcBx_imagen.TabStop = False
        '
        'Form_Imagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 298)
        Me.Controls.Add(Me.PcBx_imagen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Imagen"
        Me.Text = "Imagen"
        CType(Me.PcBx_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PcBx_imagen As PictureBox
End Class
