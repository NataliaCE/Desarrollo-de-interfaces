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
        Me.GBx_estilos = New System.Windows.Forms.GroupBox()
        Me.Pnl_estilos = New System.Windows.Forms.Panel()
        Me.Chk_tachado = New System.Windows.Forms.CheckBox()
        Me.Chk_subrayado = New System.Windows.Forms.CheckBox()
        Me.Chk_cursiva = New System.Windows.Forms.CheckBox()
        Me.Chk_negrita = New System.Windows.Forms.CheckBox()
        Me.Chk_normal = New System.Windows.Forms.CheckBox()
        Me.Lbl_texto = New System.Windows.Forms.Label()
        Me.TrckBr_tamanyo = New System.Windows.Forms.TrackBar()
        Me.CmbBx_fuentes = New System.Windows.Forms.ComboBox()
        Me.GBx_estilos.SuspendLayout()
        Me.Pnl_estilos.SuspendLayout()
        CType(Me.TrckBr_tamanyo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBx_estilos
        '
        Me.GBx_estilos.Controls.Add(Me.Pnl_estilos)
        Me.GBx_estilos.Controls.Add(Me.Chk_normal)
        Me.GBx_estilos.Location = New System.Drawing.Point(124, 91)
        Me.GBx_estilos.Name = "GBx_estilos"
        Me.GBx_estilos.Size = New System.Drawing.Size(140, 160)
        Me.GBx_estilos.TabIndex = 0
        Me.GBx_estilos.TabStop = False
        Me.GBx_estilos.Text = "Estilos"
        '
        'Pnl_estilos
        '
        Me.Pnl_estilos.Controls.Add(Me.Chk_tachado)
        Me.Pnl_estilos.Controls.Add(Me.Chk_subrayado)
        Me.Pnl_estilos.Controls.Add(Me.Chk_cursiva)
        Me.Pnl_estilos.Controls.Add(Me.Chk_negrita)
        Me.Pnl_estilos.Location = New System.Drawing.Point(17, 40)
        Me.Pnl_estilos.Name = "Pnl_estilos"
        Me.Pnl_estilos.Size = New System.Drawing.Size(94, 102)
        Me.Pnl_estilos.TabIndex = 1
        '
        'Chk_tachado
        '
        Me.Chk_tachado.AutoSize = True
        Me.Chk_tachado.Location = New System.Drawing.Point(3, 72)
        Me.Chk_tachado.Name = "Chk_tachado"
        Me.Chk_tachado.Size = New System.Drawing.Size(69, 17)
        Me.Chk_tachado.TabIndex = 4
        Me.Chk_tachado.Text = "Tachado"
        Me.Chk_tachado.UseVisualStyleBackColor = True
        '
        'Chk_subrayado
        '
        Me.Chk_subrayado.AutoSize = True
        Me.Chk_subrayado.Location = New System.Drawing.Point(3, 49)
        Me.Chk_subrayado.Name = "Chk_subrayado"
        Me.Chk_subrayado.Size = New System.Drawing.Size(77, 17)
        Me.Chk_subrayado.TabIndex = 3
        Me.Chk_subrayado.Text = "Subrayado"
        Me.Chk_subrayado.UseVisualStyleBackColor = True
        '
        'Chk_cursiva
        '
        Me.Chk_cursiva.AutoSize = True
        Me.Chk_cursiva.Location = New System.Drawing.Point(3, 26)
        Me.Chk_cursiva.Name = "Chk_cursiva"
        Me.Chk_cursiva.Size = New System.Drawing.Size(61, 17)
        Me.Chk_cursiva.TabIndex = 2
        Me.Chk_cursiva.Text = "Cursiva"
        Me.Chk_cursiva.UseVisualStyleBackColor = True
        '
        'Chk_negrita
        '
        Me.Chk_negrita.AutoSize = True
        Me.Chk_negrita.Location = New System.Drawing.Point(3, 3)
        Me.Chk_negrita.Name = "Chk_negrita"
        Me.Chk_negrita.Size = New System.Drawing.Size(60, 17)
        Me.Chk_negrita.TabIndex = 1
        Me.Chk_negrita.Text = "Negrita"
        Me.Chk_negrita.UseVisualStyleBackColor = True
        '
        'Chk_normal
        '
        Me.Chk_normal.AutoSize = True
        Me.Chk_normal.Checked = True
        Me.Chk_normal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_normal.Location = New System.Drawing.Point(20, 20)
        Me.Chk_normal.Name = "Chk_normal"
        Me.Chk_normal.Size = New System.Drawing.Size(59, 17)
        Me.Chk_normal.TabIndex = 0
        Me.Chk_normal.Text = "Normal"
        Me.Chk_normal.UseVisualStyleBackColor = True
        '
        'Lbl_texto
        '
        Me.Lbl_texto.AutoSize = True
        Me.Lbl_texto.Location = New System.Drawing.Point(365, 111)
        Me.Lbl_texto.Name = "Lbl_texto"
        Me.Lbl_texto.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_texto.TabIndex = 1
        Me.Lbl_texto.Text = "Hola"
        '
        'TrckBr_tamanyo
        '
        Me.TrckBr_tamanyo.Location = New System.Drawing.Point(328, 203)
        Me.TrckBr_tamanyo.Maximum = 50
        Me.TrckBr_tamanyo.Minimum = 8
        Me.TrckBr_tamanyo.Name = "TrckBr_tamanyo"
        Me.TrckBr_tamanyo.Size = New System.Drawing.Size(235, 45)
        Me.TrckBr_tamanyo.TabIndex = 2
        Me.TrckBr_tamanyo.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrckBr_tamanyo.Value = 8
        '
        'CmbBx_fuentes
        '
        Me.CmbBx_fuentes.FormattingEnabled = True
        Me.CmbBx_fuentes.Location = New System.Drawing.Point(328, 255)
        Me.CmbBx_fuentes.Name = "CmbBx_fuentes"
        Me.CmbBx_fuentes.Size = New System.Drawing.Size(235, 21)
        Me.CmbBx_fuentes.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbBx_fuentes)
        Me.Controls.Add(Me.TrckBr_tamanyo)
        Me.Controls.Add(Me.Lbl_texto)
        Me.Controls.Add(Me.GBx_estilos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBx_estilos.ResumeLayout(False)
        Me.GBx_estilos.PerformLayout()
        Me.Pnl_estilos.ResumeLayout(False)
        Me.Pnl_estilos.PerformLayout()
        CType(Me.TrckBr_tamanyo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBx_estilos As GroupBox
    Friend WithEvents Pnl_estilos As Panel
    Friend WithEvents Chk_tachado As CheckBox
    Friend WithEvents Chk_subrayado As CheckBox
    Friend WithEvents Chk_cursiva As CheckBox
    Friend WithEvents Chk_negrita As CheckBox
    Friend WithEvents Chk_normal As CheckBox
    Friend WithEvents Lbl_texto As Label
    Friend WithEvents TrckBr_tamanyo As TrackBar
    Friend WithEvents CmbBx_fuentes As ComboBox
End Class
