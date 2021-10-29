<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_saludo = New System.Windows.Forms.Label()
        Me.Cmbx_fuentes = New System.Windows.Forms.ComboBox()
        Me.Trackbar = New System.Windows.Forms.TrackBar()
        CType(Me.Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_saludo
        '
        Me.Lbl_saludo.AutoSize = True
        Me.Lbl_saludo.Location = New System.Drawing.Point(182, 39)
        Me.Lbl_saludo.Name = "Lbl_saludo"
        Me.Lbl_saludo.Size = New System.Drawing.Size(32, 15)
        Me.Lbl_saludo.TabIndex = 0
        Me.Lbl_saludo.Text = "Hola"
        '
        'Cmbx_fuentes
        '
        Me.Cmbx_fuentes.FormattingEnabled = True
        Me.Cmbx_fuentes.Location = New System.Drawing.Point(182, 242)
        Me.Cmbx_fuentes.Name = "Cmbx_fuentes"
        Me.Cmbx_fuentes.Size = New System.Drawing.Size(184, 23)
        Me.Cmbx_fuentes.TabIndex = 1
        '
        'Trackbar
        '
        Me.Trackbar.Location = New System.Drawing.Point(158, 191)
        Me.Trackbar.Maximum = 50
        Me.Trackbar.Minimum = 8
        Me.Trackbar.Name = "Trackbar"
        Me.Trackbar.Size = New System.Drawing.Size(258, 45)
        Me.Trackbar.TabIndex = 2
        Me.Trackbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.Trackbar.Value = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Trackbar)
        Me.Controls.Add(Me.Cmbx_fuentes)
        Me.Controls.Add(Me.Lbl_saludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_saludo As Label
    Friend WithEvents Cmbx_fuentes As ComboBox
    Friend WithEvents bar As TrackBar
    Friend WithEvents Trackbar As TrackBar
End Class
