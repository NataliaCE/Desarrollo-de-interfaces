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
        Me.rbNinguno = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbRadio = New System.Windows.Forms.GroupBox()
        Me.rbMacOS = New System.Windows.Forms.RadioButton()
        Me.rbWindows = New System.Windows.Forms.RadioButton()
        Me.rbLinux = New System.Windows.Forms.RadioButton()
        Me.gbCheck = New System.Windows.Forms.GroupBox()
        Me.cbAlgoCaro = New System.Windows.Forms.CheckBox()
        Me.cbAntivirus = New System.Windows.Forms.CheckBox()
        Me.cbImpresora = New System.Windows.Forms.CheckBox()
        Me.cbAdobe = New System.Windows.Forms.CheckBox()
        Me.lbListaCompra = New System.Windows.Forms.ListBox()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.gbRadio.SuspendLayout()
        Me.gbCheck.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbNinguno
        '
        Me.rbNinguno.AutoSize = True
        Me.rbNinguno.Location = New System.Drawing.Point(20, 144)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(82, 21)
        Me.rbNinguno.TabIndex = 3
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Tag = "0.00"
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.UseVisualStyleBackColor = True
        '
        'gbRadio
        '
        Me.gbRadio.Controls.Add(Me.rbMacOS)
        Me.gbRadio.Controls.Add(Me.rbWindows)
        Me.gbRadio.Controls.Add(Me.rbLinux)
        Me.gbRadio.Controls.Add(Me.rbNinguno)
        Me.gbRadio.Location = New System.Drawing.Point(39, 66)
        Me.gbRadio.Name = "gbRadio"
        Me.gbRadio.Size = New System.Drawing.Size(202, 206)
        Me.gbRadio.TabIndex = 4
        Me.gbRadio.TabStop = False
        Me.gbRadio.Text = "GroupBox1"
        '
        'rbMacOS
        '
        Me.rbMacOS.AutoSize = True
        Me.rbMacOS.Location = New System.Drawing.Point(20, 78)
        Me.rbMacOS.Name = "rbMacOS"
        Me.rbMacOS.Size = New System.Drawing.Size(75, 21)
        Me.rbMacOS.TabIndex = 5
        Me.rbMacOS.TabStop = True
        Me.rbMacOS.Tag = "99.99"
        Me.rbMacOS.Text = "MacOS"
        Me.rbMacOS.UseVisualStyleBackColor = True
        '
        'rbWindows
        '
        Me.rbWindows.AutoSize = True
        Me.rbWindows.Location = New System.Drawing.Point(20, 42)
        Me.rbWindows.Name = "rbWindows"
        Me.rbWindows.Size = New System.Drawing.Size(85, 21)
        Me.rbWindows.TabIndex = 4
        Me.rbWindows.Tag = "80.00"
        Me.rbWindows.Text = "Windows"
        Me.rbWindows.UseVisualStyleBackColor = True
        '
        'rbLinux
        '
        Me.rbLinux.AutoSize = True
        Me.rbLinux.Location = New System.Drawing.Point(20, 105)
        Me.rbLinux.Name = "rbLinux"
        Me.rbLinux.Size = New System.Drawing.Size(62, 21)
        Me.rbLinux.TabIndex = 6
        Me.rbLinux.Tag = "0.00"
        Me.rbLinux.Text = "Linux"
        Me.rbLinux.UseVisualStyleBackColor = True
        '
        'gbCheck
        '
        Me.gbCheck.Controls.Add(Me.cbAlgoCaro)
        Me.gbCheck.Controls.Add(Me.cbAntivirus)
        Me.gbCheck.Controls.Add(Me.cbImpresora)
        Me.gbCheck.Controls.Add(Me.cbAdobe)
        Me.gbCheck.Location = New System.Drawing.Point(39, 308)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(202, 214)
        Me.gbCheck.TabIndex = 5
        Me.gbCheck.TabStop = False
        Me.gbCheck.Text = "GroupBox2"
        '
        'cbAlgoCaro
        '
        Me.cbAlgoCaro.AutoSize = True
        Me.cbAlgoCaro.Location = New System.Drawing.Point(22, 165)
        Me.cbAlgoCaro.Name = "cbAlgoCaro"
        Me.cbAlgoCaro.Size = New System.Drawing.Size(90, 21)
        Me.cbAlgoCaro.TabIndex = 9
        Me.cbAlgoCaro.Tag = "260.05"
        Me.cbAlgoCaro.Text = "Algo caro"
        Me.cbAlgoCaro.UseVisualStyleBackColor = True
        '
        'cbAntivirus
        '
        Me.cbAntivirus.AutoSize = True
        Me.cbAntivirus.Location = New System.Drawing.Point(22, 42)
        Me.cbAntivirus.Name = "cbAntivirus"
        Me.cbAntivirus.Size = New System.Drawing.Size(84, 21)
        Me.cbAntivirus.TabIndex = 6
        Me.cbAntivirus.Tag = "45.99"
        Me.cbAntivirus.Text = "Antivirus"
        Me.cbAntivirus.UseVisualStyleBackColor = True
        '
        'cbImpresora
        '
        Me.cbImpresora.AutoSize = True
        Me.cbImpresora.Location = New System.Drawing.Point(22, 122)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(93, 21)
        Me.cbImpresora.TabIndex = 8
        Me.cbImpresora.Tag = "25.99"
        Me.cbImpresora.Text = "Impresora"
        Me.cbImpresora.UseVisualStyleBackColor = True
        '
        'cbAdobe
        '
        Me.cbAdobe.AutoSize = True
        Me.cbAdobe.Location = New System.Drawing.Point(22, 80)
        Me.cbAdobe.Name = "cbAdobe"
        Me.cbAdobe.Size = New System.Drawing.Size(71, 21)
        Me.cbAdobe.TabIndex = 7
        Me.cbAdobe.Tag = "120.90"
        Me.cbAdobe.Text = "Adobe"
        Me.cbAdobe.UseVisualStyleBackColor = True
        '
        'lbListaCompra
        '
        Me.lbListaCompra.FormattingEnabled = True
        Me.lbListaCompra.ItemHeight = 16
        Me.lbListaCompra.Location = New System.Drawing.Point(14, 43)
        Me.lbListaCompra.Name = "lbListaCompra"
        Me.lbListaCompra.Size = New System.Drawing.Size(302, 452)
        Me.lbListaCompra.TabIndex = 6
        '
        'lbTotal
        '
        Me.lbTotal.FormattingEnabled = True
        Me.lbTotal.ItemHeight = 16
        Me.lbTotal.Location = New System.Drawing.Point(428, 43)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(310, 452)
        Me.lbTotal.TabIndex = 7
        '
        'tbProducto
        '
        Me.tbProducto.Location = New System.Drawing.Point(14, 524)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(182, 22)
        Me.tbProducto.TabIndex = 8
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(219, 524)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(97, 22)
        Me.tbPrecio.TabIndex = 9
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(349, 43)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(43, 452)
        Me.btnTotal.TabIndex = 10
        Me.btnTotal.Text = "TOTAL"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbTotal)
        Me.Panel1.Controls.Add(Me.lbListaCompra)
        Me.Panel1.Controls.Add(Me.btnTotal)
        Me.Panel1.Controls.Add(Me.lbTotal)
        Me.Panel1.Controls.Add(Me.tbPrecio)
        Me.Panel1.Controls.Add(Me.tbProducto)
        Me.Panel1.Location = New System.Drawing.Point(332, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 572)
        Me.Panel1.TabIndex = 11
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(428, 524)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(310, 22)
        Me.tbTotal.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 642)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbCheck)
        Me.Controls.Add(Me.gbRadio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbRadio.ResumeLayout(False)
        Me.gbRadio.PerformLayout()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbNinguno As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbRadio As GroupBox
    Friend WithEvents gbCheck As GroupBox
    Friend WithEvents cbAlgoCaro As CheckBox
    Friend WithEvents cbAntivirus As CheckBox
    Friend WithEvents cbImpresora As CheckBox
    Friend WithEvents cbAdobe As CheckBox
    Friend WithEvents lbListaCompra As ListBox
    Friend WithEvents lbTotal As ListBox
    Friend WithEvents tbProducto As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents rbMacOS As RadioButton
    Friend WithEvents rbWindows As RadioButton
    Friend WithEvents rbLinux As RadioButton
End Class
