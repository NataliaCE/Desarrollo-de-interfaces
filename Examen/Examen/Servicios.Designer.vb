<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRadio = New System.Windows.Forms.Panel()
        Me.rbNinguno = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PanelSW = New System.Windows.Forms.Panel()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.PanelListas = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbprecio = New System.Windows.Forms.TextBox()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbLista = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.PanelRadio.SuspendLayout()
        Me.PanelSW.SuspendLayout()
        Me.PanelListas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitulo.Location = New System.Drawing.Point(155, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(549, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Configuración del software de dispositivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PanelRadio)
        Me.GroupBox1.Controls.Add(Me.PanelSW)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 333)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Software basico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(6, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SW de desarrollo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sistema operativo"
        '
        'PanelRadio
        '
        Me.PanelRadio.Controls.Add(Me.rbNinguno)
        Me.PanelRadio.Controls.Add(Me.RadioButton4)
        Me.PanelRadio.Controls.Add(Me.RadioButton1)
        Me.PanelRadio.Controls.Add(Me.RadioButton3)
        Me.PanelRadio.Controls.Add(Me.RadioButton2)
        Me.PanelRadio.Location = New System.Drawing.Point(6, 51)
        Me.PanelRadio.Name = "PanelRadio"
        Me.PanelRadio.Size = New System.Drawing.Size(165, 116)
        Me.PanelRadio.TabIndex = 12
        '
        'rbNinguno
        '
        Me.rbNinguno.AutoSize = True
        Me.rbNinguno.Location = New System.Drawing.Point(3, 95)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(65, 17)
        Me.rbNinguno.TabIndex = 13
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Tag = "0"
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(3, 72)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(149, 17)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Tag = "0"
        Me.RadioButton4.Text = "Android Chrome Book (0€)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "100"
        Me.RadioButton1.Text = "Windows (100€)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(3, 49)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "150"
        Me.RadioButton3.Text = "MC OS (150€)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(3, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "20"
        Me.RadioButton2.Text = "Ubuntu (20€)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PanelSW
        '
        Me.PanelSW.Controls.Add(Me.CheckBox4)
        Me.PanelSW.Controls.Add(Me.CheckBox1)
        Me.PanelSW.Controls.Add(Me.CheckBox2)
        Me.PanelSW.Controls.Add(Me.CheckBox3)
        Me.PanelSW.Location = New System.Drawing.Point(9, 208)
        Me.PanelSW.Name = "PanelSW"
        Me.PanelSW.Size = New System.Drawing.Size(153, 109)
        Me.PanelSW.TabIndex = 11
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(9, 81)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 35)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(9, 58)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'PanelListas
        '
        Me.PanelListas.Controls.Add(Me.btnAdd)
        Me.PanelListas.Controls.Add(Me.Label5)
        Me.PanelListas.Controls.Add(Me.TextBox3)
        Me.PanelListas.Controls.Add(Me.tbprecio)
        Me.PanelListas.Controls.Add(Me.tbProducto)
        Me.PanelListas.Controls.Add(Me.btnCalcular)
        Me.PanelListas.Controls.Add(Me.RichTextBox1)
        Me.PanelListas.Controls.Add(Me.Label4)
        Me.PanelListas.Controls.Add(Me.Label3)
        Me.PanelListas.Controls.Add(Me.LbLista)
        Me.PanelListas.Location = New System.Drawing.Point(257, 43)
        Me.PanelListas.Name = "PanelListas"
        Me.PanelListas.Size = New System.Drawing.Size(514, 408)
        Me.PanelListas.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(27, 378)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(173, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Añadir extra SW"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total €"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(360, 361)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(113, 23)
        Me.TextBox3.TabIndex = 18
        '
        'tbprecio
        '
        Me.tbprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprecio.Location = New System.Drawing.Point(133, 349)
        Me.tbprecio.Name = "tbprecio"
        Me.tbprecio.Size = New System.Drawing.Size(67, 23)
        Me.tbprecio.TabIndex = 17
        '
        'tbProducto
        '
        Me.tbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProducto.Location = New System.Drawing.Point(27, 348)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(100, 23)
        Me.tbProducto.TabIndex = 16
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(222, 52)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(24, 292)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular Servicio"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(277, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(196, 292)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Resumen de servicios de instalacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Aplicaciones de usuario"
        '
        'LbLista
        '
        Me.LbLista.FormattingEnabled = True
        Me.LbLista.Location = New System.Drawing.Point(27, 52)
        Me.LbLista.Name = "LbLista"
        Me.LbLista.Size = New System.Drawing.Size(173, 290)
        Me.LbLista.TabIndex = 11
        '
        'Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelListas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Servicios"
        Me.Text = "Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelRadio.ResumeLayout(False)
        Me.PanelRadio.PerformLayout()
        Me.PanelSW.ResumeLayout(False)
        Me.PanelSW.PerformLayout()
        Me.PanelListas.ResumeLayout(False)
        Me.PanelListas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PanelSW As Panel
    Friend WithEvents PanelListas As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbprecio As TextBox
    Friend WithEvents tbProducto As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LbLista As ListBox
    Friend WithEvents PanelRadio As Panel
    Friend WithEvents rbNinguno As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
End Class
