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
        Me.Ltbx_listaIzq = New System.Windows.Forms.ListBox()
        Me.Txtb_EntradaListIzq = New System.Windows.Forms.TextBox()
        Me.Btn_borr_lista = New System.Windows.Forms.Button()
        Me.Btn_borr_listaCentro = New System.Windows.Forms.Button()
        Me.Txtb_EntradaListCentro = New System.Windows.Forms.TextBox()
        Me.Ltbx_listaCentro = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Ltbx_listaIzq
        '
        Me.Ltbx_listaIzq.FormattingEnabled = True
        Me.Ltbx_listaIzq.ItemHeight = 15
        Me.Ltbx_listaIzq.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.Ltbx_listaIzq.Location = New System.Drawing.Point(99, 138)
        Me.Ltbx_listaIzq.Name = "Ltbx_listaIzq"
        Me.Ltbx_listaIzq.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltbx_listaIzq.Size = New System.Drawing.Size(120, 154)
        Me.Ltbx_listaIzq.TabIndex = 0
        '
        'Txtb_EntradaListIzq
        '
        Me.Txtb_EntradaListIzq.Location = New System.Drawing.Point(99, 309)
        Me.Txtb_EntradaListIzq.Name = "Txtb_EntradaListIzq"
        Me.Txtb_EntradaListIzq.Size = New System.Drawing.Size(120, 23)
        Me.Txtb_EntradaListIzq.TabIndex = 1
        '
        'Btn_borr_lista
        '
        Me.Btn_borr_lista.Location = New System.Drawing.Point(99, 100)
        Me.Btn_borr_lista.Name = "Btn_borr_lista"
        Me.Btn_borr_lista.Size = New System.Drawing.Size(120, 23)
        Me.Btn_borr_lista.TabIndex = 2
        Me.Btn_borr_lista.Text = "Borrar lista"
        Me.Btn_borr_lista.UseVisualStyleBackColor = True
        '
        'Btn_borr_listaCentro
        '
        Me.Btn_borr_listaCentro.Location = New System.Drawing.Point(289, 100)
        Me.Btn_borr_listaCentro.Name = "Btn_borr_listaCentro"
        Me.Btn_borr_listaCentro.Size = New System.Drawing.Size(120, 23)
        Me.Btn_borr_listaCentro.TabIndex = 5
        Me.Btn_borr_listaCentro.Text = "Borrar lista"
        Me.Btn_borr_listaCentro.UseVisualStyleBackColor = True
        '
        'Txtb_EntradaListCentro
        '
        Me.Txtb_EntradaListCentro.Location = New System.Drawing.Point(289, 309)
        Me.Txtb_EntradaListCentro.Name = "Txtb_EntradaListCentro"
        Me.Txtb_EntradaListCentro.Size = New System.Drawing.Size(120, 23)
        Me.Txtb_EntradaListCentro.TabIndex = 4
        '
        'Ltbx_listaCentro
        '
        Me.Ltbx_listaCentro.FormattingEnabled = True
        Me.Ltbx_listaCentro.ItemHeight = 15
        Me.Ltbx_listaCentro.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.Ltbx_listaCentro.Location = New System.Drawing.Point(289, 138)
        Me.Ltbx_listaCentro.Name = "Ltbx_listaCentro"
        Me.Ltbx_listaCentro.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltbx_listaCentro.Size = New System.Drawing.Size(120, 154)
        Me.Ltbx_listaCentro.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_borr_listaCentro)
        Me.Controls.Add(Me.Txtb_EntradaListCentro)
        Me.Controls.Add(Me.Ltbx_listaCentro)
        Me.Controls.Add(Me.Btn_borr_lista)
        Me.Controls.Add(Me.Txtb_EntradaListIzq)
        Me.Controls.Add(Me.Ltbx_listaIzq)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ltbx_listaIzq As ListBox
    Friend WithEvents Txtb_EntradaListIzq As TextBox
    Friend WithEvents Btn_borr_lista As Button
    Friend WithEvents Btn_borr_listaCentro As Button
    Friend WithEvents Txtb_EntradaListCentro As TextBox
    Friend WithEvents Ltbx_listaCentro As ListBox
End Class
