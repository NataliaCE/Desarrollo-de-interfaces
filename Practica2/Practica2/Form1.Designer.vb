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
        Me.Chck1 = New System.Windows.Forms.CheckBox()
        Me.Chck2 = New System.Windows.Forms.CheckBox()
        Me.Chck3 = New System.Windows.Forms.CheckBox()
        Me.Chck4 = New System.Windows.Forms.CheckBox()
        Me.Btn_resumen = New System.Windows.Forms.Button()
        Me.Lbl_resumen = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chck1
        '
        Me.Chck1.AutoSize = True
        Me.Chck1.Location = New System.Drawing.Point(3, 3)
        Me.Chck1.Name = "Chck1"
        Me.Chck1.Size = New System.Drawing.Size(74, 19)
        Me.Chck1.TabIndex = 0
        Me.Chck1.Text = "Opción 1"
        Me.Chck1.UseVisualStyleBackColor = True
        '
        'Chck2
        '
        Me.Chck2.AutoSize = True
        Me.Chck2.Location = New System.Drawing.Point(3, 28)
        Me.Chck2.Name = "Chck2"
        Me.Chck2.Size = New System.Drawing.Size(74, 19)
        Me.Chck2.TabIndex = 1
        Me.Chck2.Text = "Opción 2"
        Me.Chck2.UseVisualStyleBackColor = True
        '
        'Chck3
        '
        Me.Chck3.AutoSize = True
        Me.Chck3.Location = New System.Drawing.Point(3, 53)
        Me.Chck3.Name = "Chck3"
        Me.Chck3.Size = New System.Drawing.Size(74, 19)
        Me.Chck3.TabIndex = 2
        Me.Chck3.Text = "Opción 3"
        Me.Chck3.UseVisualStyleBackColor = True
        '
        'Chck4
        '
        Me.Chck4.AutoSize = True
        Me.Chck4.Location = New System.Drawing.Point(3, 78)
        Me.Chck4.Name = "Chck4"
        Me.Chck4.Size = New System.Drawing.Size(74, 19)
        Me.Chck4.TabIndex = 3
        Me.Chck4.Text = "Opción 4"
        Me.Chck4.UseVisualStyleBackColor = True
        '
        'Btn_resumen
        '
        Me.Btn_resumen.Location = New System.Drawing.Point(101, 201)
        Me.Btn_resumen.Name = "Btn_resumen"
        Me.Btn_resumen.Size = New System.Drawing.Size(89, 30)
        Me.Btn_resumen.TabIndex = 4
        Me.Btn_resumen.Text = "Resumen"
        Me.Btn_resumen.UseVisualStyleBackColor = True
        '
        'Lbl_resumen
        '
        Me.Lbl_resumen.AutoSize = True
        Me.Lbl_resumen.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_resumen.Location = New System.Drawing.Point(255, 64)
        Me.Lbl_resumen.Name = "Lbl_resumen"
        Me.Lbl_resumen.Size = New System.Drawing.Size(0, 30)
        Me.Lbl_resumen.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Chck1)
        Me.Panel1.Controls.Add(Me.Chck2)
        Me.Panel1.Controls.Add(Me.Chck3)
        Me.Panel1.Controls.Add(Me.Chck4)
        Me.Panel1.Location = New System.Drawing.Point(101, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(82, 105)
        Me.Panel1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_resumen)
        Me.Controls.Add(Me.Btn_resumen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chck1 As CheckBox
    Friend WithEvents Chck2 As CheckBox
    Friend WithEvents Chck3 As CheckBox
    Friend WithEvents Chck4 As CheckBox
    Friend WithEvents Btn_resumen As Button
    Friend WithEvents Lbl_resumen As Label
    Friend WithEvents Panel1 As Panel
End Class
