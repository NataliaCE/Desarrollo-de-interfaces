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
        Me.Btn_Mxtexb = New System.Windows.Forms.Button()
        Me.Btn_Mntexb = New System.Windows.Forms.Button()
        Me.PanelTXTbx = New System.Windows.Forms.Panel()
        Me.ContadorTXTbx = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Mxtexb
        '
        Me.Btn_Mxtexb.Location = New System.Drawing.Point(29, 57)
        Me.Btn_Mxtexb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Mxtexb.Name = "Btn_Mxtexb"
        Me.Btn_Mxtexb.Size = New System.Drawing.Size(139, 58)
        Me.Btn_Mxtexb.TabIndex = 0
        Me.Btn_Mxtexb.Text = "Más TextBox"
        Me.Btn_Mxtexb.UseVisualStyleBackColor = True
        '
        'Btn_Mntexb
        '
        Me.Btn_Mntexb.Location = New System.Drawing.Point(29, 121)
        Me.Btn_Mntexb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Mntexb.Name = "Btn_Mntexb"
        Me.Btn_Mntexb.Size = New System.Drawing.Size(139, 58)
        Me.Btn_Mntexb.TabIndex = 0
        Me.Btn_Mntexb.Text = "Menos TextBox"
        Me.Btn_Mntexb.UseVisualStyleBackColor = True
        '
        'PanelTXTbx
        '
        Me.PanelTXTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTXTbx.Location = New System.Drawing.Point(383, 57)
        Me.PanelTXTbx.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelTXTbx.Name = "PanelTXTbx"
        Me.PanelTXTbx.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelTXTbx.Size = New System.Drawing.Size(355, 339)
        Me.PanelTXTbx.TabIndex = 1
        '
        'ContadorTXTbx
        '
        Me.ContadorTXTbx.AutoSize = True
        Me.ContadorTXTbx.Location = New System.Drawing.Point(380, 25)
        Me.ContadorTXTbx.Name = "ContadorTXTbx"
        Me.ContadorTXTbx.Size = New System.Drawing.Size(109, 17)
        Me.ContadorTXTbx.TabIndex = 2
        Me.ContadorTXTbx.Text = "Nº de TextBox 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ContadorTXTbx)
        Me.Controls.Add(Me.PanelTXTbx)
        Me.Controls.Add(Me.Btn_Mntexb)
        Me.Controls.Add(Me.Btn_Mxtexb)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Mxtexb As Button
    Friend WithEvents Btn_Mntexb As Button
    Friend WithEvents PanelTXTbx As Panel
    Friend WithEvents ContadorTXTbx As Label
End Class
