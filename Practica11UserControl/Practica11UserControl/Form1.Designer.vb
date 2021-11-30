<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ControlDecha = New Practica11UserControl.ControlUsuario()
        Me.ControlCentro = New Practica11UserControl.ControlUsuario()
        Me.ControlIzq = New Practica11UserControl.ControlUsuario()
        Me.SuspendLayout()
        '
        'ControlDecha
        '
        Me.ControlDecha.AllowDrop = True
        'Me.ControlDecha.ElementoDrop = Nothing
        Me.ControlDecha.Location = New System.Drawing.Point(764, 124)
        Me.ControlDecha.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlDecha.Name = "ControlDecha"
        Me.ControlDecha.Size = New System.Drawing.Size(244, 306)
        Me.ControlDecha.TabIndex = 2
        Me.ControlDecha.TextoInicial = "Ejemplo"
        '
        'ControlCentro
        '
        Me.ControlCentro.AllowDrop = True
        'Me.ControlCentro.ElementoDrop = Nothing
        Me.ControlCentro.Location = New System.Drawing.Point(411, 124)
        Me.ControlCentro.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlCentro.Name = "ControlCentro"
        Me.ControlCentro.Size = New System.Drawing.Size(244, 306)
        Me.ControlCentro.TabIndex = 1
        Me.ControlCentro.TextoInicial = "Ejemplo"
        '
        'ControlIzq
        '
        Me.ControlIzq.AllowDrop = True
        'Me.ControlIzq.ElementoDrop = Nothing
        Me.ControlIzq.Location = New System.Drawing.Point(63, 124)
        Me.ControlIzq.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlIzq.Name = "ControlIzq"
        Me.ControlIzq.Size = New System.Drawing.Size(244, 306)
        Me.ControlIzq.TabIndex = 0
        Me.ControlIzq.TextoInicial = "Ejemplo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ControlDecha)
        Me.Controls.Add(Me.ControlCentro)
        Me.Controls.Add(Me.ControlIzq)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlIzq As ControlUsuario
    Friend WithEvents ControlCentro As ControlUsuario
    Friend WithEvents ControlDecha As ControlUsuario
End Class
