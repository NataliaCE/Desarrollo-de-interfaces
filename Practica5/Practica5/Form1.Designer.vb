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
        Me.Btn_borr_listaIzq = New System.Windows.Forms.Button()
        Me.Btn_borr_listaCentro = New System.Windows.Forms.Button()
        Me.Txtb_EntradaListCentro = New System.Windows.Forms.TextBox()
        Me.Ltbx_listaCentro = New System.Windows.Forms.ListBox()
        Me.Btn_borr_listaDecha = New System.Windows.Forms.Button()
        Me.Txtb_EntradaListDecha = New System.Windows.Forms.TextBox()
        Me.Ltbx_listaDecha = New System.Windows.Forms.ListBox()
        Me.Btn_IzqACentro = New System.Windows.Forms.Button()
        Me.Btn_CentroAIzq = New System.Windows.Forms.Button()
        Me.Btn_DechaACentro = New System.Windows.Forms.Button()
        Me.Btn_CentroADecha = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ltbx_listaIzq
        '
        Me.Ltbx_listaIzq.FormattingEnabled = True
        Me.Ltbx_listaIzq.ItemHeight = 15
        Me.Ltbx_listaIzq.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.Ltbx_listaIzq.Location = New System.Drawing.Point(78, 138)
        Me.Ltbx_listaIzq.Name = "Ltbx_listaIzq"
        Me.Ltbx_listaIzq.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Ltbx_listaIzq.Size = New System.Drawing.Size(120, 154)
        Me.Ltbx_listaIzq.TabIndex = 0
        '
        'Txtb_EntradaListIzq
        '
        Me.Txtb_EntradaListIzq.Location = New System.Drawing.Point(78, 309)
        Me.Txtb_EntradaListIzq.Name = "Txtb_EntradaListIzq"
        Me.Txtb_EntradaListIzq.Size = New System.Drawing.Size(120, 23)
        Me.Txtb_EntradaListIzq.TabIndex = 1
        '
        'Btn_borr_listaIzq
        '
        Me.Btn_borr_listaIzq.Location = New System.Drawing.Point(78, 100)
        Me.Btn_borr_listaIzq.Name = "Btn_borr_listaIzq"
        Me.Btn_borr_listaIzq.Size = New System.Drawing.Size(120, 23)
        Me.Btn_borr_listaIzq.TabIndex = 2
        Me.Btn_borr_listaIzq.Text = "Borrar lista"
        Me.Btn_borr_listaIzq.UseVisualStyleBackColor = True
        '
        'Btn_borr_listaCentro
        '
        Me.Btn_borr_listaCentro.Location = New System.Drawing.Point(335, 100)
        Me.Btn_borr_listaCentro.Name = "Btn_borr_listaCentro"
        Me.Btn_borr_listaCentro.Size = New System.Drawing.Size(120, 23)
        Me.Btn_borr_listaCentro.TabIndex = 5
        Me.Btn_borr_listaCentro.Text = "Borrar lista"
        Me.Btn_borr_listaCentro.UseVisualStyleBackColor = True
        '
        'Txtb_EntradaListCentro
        '
        Me.Txtb_EntradaListCentro.Location = New System.Drawing.Point(335, 309)
        Me.Txtb_EntradaListCentro.Name = "Txtb_EntradaListCentro"
        Me.Txtb_EntradaListCentro.Size = New System.Drawing.Size(120, 23)
        Me.Txtb_EntradaListCentro.TabIndex = 4
        '
        'Ltbx_listaCentro
        '
        Me.Ltbx_listaCentro.FormattingEnabled = True
        Me.Ltbx_listaCentro.ItemHeight = 15
        Me.Ltbx_listaCentro.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.Ltbx_listaCentro.Location = New System.Drawing.Point(335, 138)
        Me.Ltbx_listaCentro.Name = "Ltbx_listaCentro"
        Me.Ltbx_listaCentro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Ltbx_listaCentro.Size = New System.Drawing.Size(120, 154)
        Me.Ltbx_listaCentro.TabIndex = 3
        '
        'Btn_borr_listaDecha
        '
        Me.Btn_borr_listaDecha.Location = New System.Drawing.Point(596, 100)
        Me.Btn_borr_listaDecha.Name = "Btn_borr_listaDecha"
        Me.Btn_borr_listaDecha.Size = New System.Drawing.Size(120, 23)
        Me.Btn_borr_listaDecha.TabIndex = 8
        Me.Btn_borr_listaDecha.Text = "Borrar lista"
        Me.Btn_borr_listaDecha.UseVisualStyleBackColor = True
        '
        'Txtb_EntradaListDecha
        '
        Me.Txtb_EntradaListDecha.Location = New System.Drawing.Point(596, 309)
        Me.Txtb_EntradaListDecha.Name = "Txtb_EntradaListDecha"
        Me.Txtb_EntradaListDecha.Size = New System.Drawing.Size(120, 23)
        Me.Txtb_EntradaListDecha.TabIndex = 7
        '
        'Ltbx_listaDecha
        '
        Me.Ltbx_listaDecha.FormattingEnabled = True
        Me.Ltbx_listaDecha.ItemHeight = 15
        Me.Ltbx_listaDecha.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.Ltbx_listaDecha.Location = New System.Drawing.Point(596, 138)
        Me.Ltbx_listaDecha.Name = "Ltbx_listaDecha"
        Me.Ltbx_listaDecha.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Ltbx_listaDecha.Size = New System.Drawing.Size(120, 154)
        Me.Ltbx_listaDecha.TabIndex = 6
        '
        'Btn_IzqACentro
        '
        Me.Btn_IzqACentro.Location = New System.Drawing.Point(230, 168)
        Me.Btn_IzqACentro.Name = "Btn_IzqACentro"
        Me.Btn_IzqACentro.Size = New System.Drawing.Size(75, 23)
        Me.Btn_IzqACentro.TabIndex = 9
        Me.Btn_IzqACentro.Text = "---->"
        Me.Btn_IzqACentro.UseVisualStyleBackColor = True
        '
        'Btn_CentroAIzq
        '
        Me.Btn_CentroAIzq.Location = New System.Drawing.Point(230, 224)
        Me.Btn_CentroAIzq.Name = "Btn_CentroAIzq"
        Me.Btn_CentroAIzq.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CentroAIzq.TabIndex = 10
        Me.Btn_CentroAIzq.Text = "<----"
        Me.Btn_CentroAIzq.UseVisualStyleBackColor = True
        '
        'Btn_DechaACentro
        '
        Me.Btn_DechaACentro.Location = New System.Drawing.Point(492, 224)
        Me.Btn_DechaACentro.Name = "Btn_DechaACentro"
        Me.Btn_DechaACentro.Size = New System.Drawing.Size(75, 23)
        Me.Btn_DechaACentro.TabIndex = 12
        Me.Btn_DechaACentro.Text = "<----"
        Me.Btn_DechaACentro.UseVisualStyleBackColor = True
        '
        'Btn_CentroADecha
        '
        Me.Btn_CentroADecha.Location = New System.Drawing.Point(492, 168)
        Me.Btn_CentroADecha.Name = "Btn_CentroADecha"
        Me.Btn_CentroADecha.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CentroADecha.TabIndex = 11
        Me.Btn_CentroADecha.Text = "---->"
        Me.Btn_CentroADecha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_DechaACentro)
        Me.Controls.Add(Me.Btn_CentroADecha)
        Me.Controls.Add(Me.Btn_CentroAIzq)
        Me.Controls.Add(Me.Btn_IzqACentro)
        Me.Controls.Add(Me.Btn_borr_listaDecha)
        Me.Controls.Add(Me.Txtb_EntradaListDecha)
        Me.Controls.Add(Me.Ltbx_listaDecha)
        Me.Controls.Add(Me.Btn_borr_listaCentro)
        Me.Controls.Add(Me.Txtb_EntradaListCentro)
        Me.Controls.Add(Me.Ltbx_listaCentro)
        Me.Controls.Add(Me.Btn_borr_listaIzq)
        Me.Controls.Add(Me.Txtb_EntradaListIzq)
        Me.Controls.Add(Me.Ltbx_listaIzq)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ltbx_listaIzq As ListBox
    Friend WithEvents Txtb_EntradaListIzq As TextBox
    Friend WithEvents Btn_borr_listaIzq As Button
    Friend WithEvents Btn_borr_listaCentro As Button
    Friend WithEvents Txtb_EntradaListCentro As TextBox
    Friend WithEvents Ltbx_listaCentro As ListBox
    Friend WithEvents Btn_borr_listaDecha As Button
    Friend WithEvents Txtb_EntradaListDecha As TextBox
    Friend WithEvents Ltbx_listaDecha As ListBox
    Friend WithEvents Btn_IzqACentro As Button
    Friend WithEvents Btn_CentroAIzq As Button
    Friend WithEvents Btn_DechaACentro As Button
    Friend WithEvents Btn_CentroADecha As Button
End Class
