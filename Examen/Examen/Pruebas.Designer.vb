<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pruebas
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
        Me.btnPrueba1 = New System.Windows.Forms.Button()
        Me.btnPrueba2 = New System.Windows.Forms.Button()
        Me.btnPrueba3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrueba1
        '
        Me.btnPrueba1.Location = New System.Drawing.Point(77, 63)
        Me.btnPrueba1.Name = "btnPrueba1"
        Me.btnPrueba1.Size = New System.Drawing.Size(99, 43)
        Me.btnPrueba1.TabIndex = 0
        Me.btnPrueba1.Text = "Prueba 1"
        Me.btnPrueba1.UseVisualStyleBackColor = True
        '
        'btnPrueba2
        '
        Me.btnPrueba2.Location = New System.Drawing.Point(77, 158)
        Me.btnPrueba2.Name = "btnPrueba2"
        Me.btnPrueba2.Size = New System.Drawing.Size(99, 43)
        Me.btnPrueba2.TabIndex = 1
        Me.btnPrueba2.Text = "Prueba 2"
        Me.btnPrueba2.UseVisualStyleBackColor = True
        '
        'btnPrueba3
        '
        Me.btnPrueba3.Location = New System.Drawing.Point(77, 252)
        Me.btnPrueba3.Name = "btnPrueba3"
        Me.btnPrueba3.Size = New System.Drawing.Size(99, 43)
        Me.btnPrueba3.TabIndex = 2
        Me.btnPrueba3.Text = "Prueba 3"
        Me.btnPrueba3.UseVisualStyleBackColor = True
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 376)
        Me.Controls.Add(Me.btnPrueba3)
        Me.Controls.Add(Me.btnPrueba2)
        Me.Controls.Add(Me.btnPrueba1)
        Me.Name = "Pruebas"
        Me.Text = "Pruebas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrueba1 As Button
    Friend WithEvents btnPrueba2 As Button
    Friend WithEvents btnPrueba3 As Button
End Class
