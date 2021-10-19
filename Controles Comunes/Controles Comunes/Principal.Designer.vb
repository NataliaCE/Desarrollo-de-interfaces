<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.Btn_saludo = New System.Windows.Forms.Button()
        Me.Lbl_saludo = New System.Windows.Forms.Label()
        Me.Radio_dia = New System.Windows.Forms.RadioButton()
        Me.Radio_tarde = New System.Windows.Forms.RadioButton()
        Me.Radio_noche = New System.Windows.Forms.RadioButton()
        Me.Pnl_radio = New System.Windows.Forms.Panel()
        Me.Radio_mediodia = New System.Windows.Forms.RadioButton()
        Me.Pnl_nombres = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Pnl_radio.SuspendLayout()
        Me.Pnl_nombres.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_saludo
        '
        Me.Btn_saludo.Location = New System.Drawing.Point(181, 211)
        Me.Btn_saludo.Name = "Btn_saludo"
        Me.Btn_saludo.Size = New System.Drawing.Size(97, 40)
        Me.Btn_saludo.TabIndex = 0
        Me.Btn_saludo.Text = "Saludo"
        Me.Btn_saludo.UseVisualStyleBackColor = True
        '
        'Lbl_saludo
        '
        Me.Lbl_saludo.AutoSize = True
        Me.Lbl_saludo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_saludo.Location = New System.Drawing.Point(310, 213)
        Me.Lbl_saludo.Name = "Lbl_saludo"
        Me.Lbl_saludo.Size = New System.Drawing.Size(73, 28)
        Me.Lbl_saludo.TabIndex = 1
        Me.Lbl_saludo.Text = "Saludo"
        '
        'Radio_dia
        '
        Me.Radio_dia.AutoSize = True
        Me.Radio_dia.Checked = True
        Me.Radio_dia.Location = New System.Drawing.Point(6, 6)
        Me.Radio_dia.Name = "Radio_dia"
        Me.Radio_dia.Size = New System.Drawing.Size(47, 19)
        Me.Radio_dia.TabIndex = 2
        Me.Radio_dia.TabStop = True
        Me.Radio_dia.Tag = "Buenos"
        Me.Radio_dia.Text = "Dias"
        Me.Radio_dia.UseVisualStyleBackColor = True
        '
        'Radio_tarde
        '
        Me.Radio_tarde.AutoSize = True
        Me.Radio_tarde.Location = New System.Drawing.Point(6, 75)
        Me.Radio_tarde.Name = "Radio_tarde"
        Me.Radio_tarde.Size = New System.Drawing.Size(58, 19)
        Me.Radio_tarde.TabIndex = 3
        Me.Radio_tarde.Tag = "Buenas"
        Me.Radio_tarde.Text = "Tardes"
        Me.Radio_tarde.UseVisualStyleBackColor = True
        '
        'Radio_noche
        '
        Me.Radio_noche.AutoSize = True
        Me.Radio_noche.Location = New System.Drawing.Point(6, 109)
        Me.Radio_noche.Name = "Radio_noche"
        Me.Radio_noche.Size = New System.Drawing.Size(65, 19)
        Me.Radio_noche.TabIndex = 4
        Me.Radio_noche.Tag = "Buenas"
        Me.Radio_noche.Text = "Noches"
        Me.Radio_noche.UseVisualStyleBackColor = True
        '
        'Pnl_radio
        '
        Me.Pnl_radio.Controls.Add(Me.Radio_mediodia)
        Me.Pnl_radio.Controls.Add(Me.Radio_tarde)
        Me.Pnl_radio.Controls.Add(Me.Radio_noche)
        Me.Pnl_radio.Controls.Add(Me.Radio_dia)
        Me.Pnl_radio.Location = New System.Drawing.Point(175, 54)
        Me.Pnl_radio.Name = "Pnl_radio"
        Me.Pnl_radio.Size = New System.Drawing.Size(103, 137)
        Me.Pnl_radio.TabIndex = 5
        '
        'Radio_mediodia
        '
        Me.Radio_mediodia.AutoSize = True
        Me.Radio_mediodia.Location = New System.Drawing.Point(6, 40)
        Me.Radio_mediodia.Name = "Radio_mediodia"
        Me.Radio_mediodia.Size = New System.Drawing.Size(88, 19)
        Me.Radio_mediodia.TabIndex = 5
        Me.Radio_mediodia.Tag = "Buenos"
        Me.Radio_mediodia.Text = "Medios días"
        Me.Radio_mediodia.UseVisualStyleBackColor = True
        '
        'Pnl_nombres
        '
        Me.Pnl_nombres.Controls.Add(Me.RadioButton1)
        Me.Pnl_nombres.Controls.Add(Me.RadioButton2)
        Me.Pnl_nombres.Controls.Add(Me.RadioButton3)
        Me.Pnl_nombres.Controls.Add(Me.RadioButton4)
        Me.Pnl_nombres.Location = New System.Drawing.Point(485, 54)
        Me.Pnl_nombres.Name = "Pnl_nombres"
        Me.Pnl_nombres.Size = New System.Drawing.Size(103, 137)
        Me.Pnl_nombres.TabIndex = 6
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(51, 19)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Tag = ""
        Me.RadioButton1.Text = "Pepe"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Tag = ""
        Me.RadioButton2.Text = "Luis"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 109)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 19)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.Tag = ""
        Me.RadioButton3.Text = "Andrés"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 6)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(49, 19)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Tag = ""
        Me.RadioButton4.Text = "Juan"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pnl_nombres)
        Me.Controls.Add(Me.Pnl_radio)
        Me.Controls.Add(Me.Lbl_saludo)
        Me.Controls.Add(Me.Btn_saludo)
        Me.Name = "Principal"
        Me.Text = "Form1"
        Me.Pnl_radio.ResumeLayout(False)
        Me.Pnl_radio.PerformLayout()
        Me.Pnl_nombres.ResumeLayout(False)
        Me.Pnl_nombres.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_saludo As Button
    Friend WithEvents Lbl_saludo As Label
    Friend WithEvents Radio_dia As RadioButton
    Friend WithEvents Radio_tarde As RadioButton
    Friend WithEvents Radio_noche As RadioButton
    Friend WithEvents Pnl_radio As Panel
    Friend WithEvents Radio_mediodia As RadioButton
    Friend WithEvents Pnl_nombres As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
