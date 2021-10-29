<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Mas = New System.Windows.Forms.Button()
        Me.Btn_Menos = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Btn_Mas
        '
        Me.Btn_Mas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Mas.Location = New System.Drawing.Point(62, 66)
        Me.Btn_Mas.Name = "Btn_Mas"
        Me.Btn_Mas.Size = New System.Drawing.Size(133, 50)
        Me.Btn_Mas.TabIndex = 0
        Me.Btn_Mas.Text = "Más TextBox"
        Me.Btn_Mas.UseVisualStyleBackColor = True
        '
        'Btn_Menos
        '
        Me.Btn_Menos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Menos.Location = New System.Drawing.Point(62, 132)
        Me.Btn_Menos.Name = "Btn_Menos"
        Me.Btn_Menos.Size = New System.Drawing.Size(133, 50)
        Me.Btn_Menos.TabIndex = 1
        Me.Btn_Menos.Text = "Menos TextBox"
        Me.Btn_Menos.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Location = New System.Drawing.Point(387, 66)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(200, 330)
        Me.Panel.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Btn_Menos)
        Me.Controls.Add(Me.Btn_Mas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Mas As Button
    Friend WithEvents Btn_Menos As Button
    Friend WithEvents Panel As Panel
End Class
