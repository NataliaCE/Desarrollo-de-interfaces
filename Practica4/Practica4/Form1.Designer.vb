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
        Me.Ltbx_Colores = New System.Windows.Forms.ListBox()
        Me.Txtb_color = New System.Windows.Forms.TextBox()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.Btn_Marca = New System.Windows.Forms.Button()
        Me.Txtb_Marca = New System.Windows.Forms.TextBox()
        Me.Ltbx_Marcas = New System.Windows.Forms.ListBox()
        Me.Btn_Pais = New System.Windows.Forms.Button()
        Me.Txtb_Pais = New System.Windows.Forms.TextBox()
        Me.Ltbx_Paises = New System.Windows.Forms.ListBox()
        Me.Btn_BColor = New System.Windows.Forms.Button()
        Me.Btn_BMarca = New System.Windows.Forms.Button()
        Me.Btn_BPais = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ltbx_Colores
        '
        Me.Ltbx_Colores.FormattingEnabled = True
        Me.Ltbx_Colores.ItemHeight = 15
        Me.Ltbx_Colores.Location = New System.Drawing.Point(95, 93)
        Me.Ltbx_Colores.Name = "Ltbx_Colores"
        Me.Ltbx_Colores.Size = New System.Drawing.Size(140, 139)
        Me.Ltbx_Colores.TabIndex = 0
        '
        'Txtb_color
        '
        Me.Txtb_color.Location = New System.Drawing.Point(95, 255)
        Me.Txtb_color.Name = "Txtb_color"
        Me.Txtb_color.Size = New System.Drawing.Size(140, 23)
        Me.Txtb_color.TabIndex = 1
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(95, 296)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(140, 23)
        Me.BtnColor.TabIndex = 2
        Me.BtnColor.Text = "Ingresar color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'Btn_Marca
        '
        Me.Btn_Marca.Location = New System.Drawing.Point(308, 296)
        Me.Btn_Marca.Name = "Btn_Marca"
        Me.Btn_Marca.Size = New System.Drawing.Size(140, 23)
        Me.Btn_Marca.TabIndex = 5
        Me.Btn_Marca.Text = "Ingresar marca"
        Me.Btn_Marca.UseVisualStyleBackColor = True
        '
        'Txtb_Marca
        '
        Me.Txtb_Marca.Location = New System.Drawing.Point(308, 255)
        Me.Txtb_Marca.Name = "Txtb_Marca"
        Me.Txtb_Marca.Size = New System.Drawing.Size(140, 23)
        Me.Txtb_Marca.TabIndex = 4
        '
        'Ltbx_Marcas
        '
        Me.Ltbx_Marcas.FormattingEnabled = True
        Me.Ltbx_Marcas.ItemHeight = 15
        Me.Ltbx_Marcas.Location = New System.Drawing.Point(308, 93)
        Me.Ltbx_Marcas.Name = "Ltbx_Marcas"
        Me.Ltbx_Marcas.Size = New System.Drawing.Size(140, 139)
        Me.Ltbx_Marcas.TabIndex = 3
        '
        'Btn_Pais
        '
        Me.Btn_Pais.Location = New System.Drawing.Point(526, 296)
        Me.Btn_Pais.Name = "Btn_Pais"
        Me.Btn_Pais.Size = New System.Drawing.Size(140, 23)
        Me.Btn_Pais.TabIndex = 8
        Me.Btn_Pais.Text = "Ingresar pais"
        Me.Btn_Pais.UseVisualStyleBackColor = True
        '
        'Txtb_Pais
        '
        Me.Txtb_Pais.Location = New System.Drawing.Point(526, 255)
        Me.Txtb_Pais.Name = "Txtb_Pais"
        Me.Txtb_Pais.Size = New System.Drawing.Size(140, 23)
        Me.Txtb_Pais.TabIndex = 7
        '
        'Ltbx_Paises
        '
        Me.Ltbx_Paises.FormattingEnabled = True
        Me.Ltbx_Paises.ItemHeight = 15
        Me.Ltbx_Paises.Location = New System.Drawing.Point(526, 93)
        Me.Ltbx_Paises.Name = "Ltbx_Paises"
        Me.Ltbx_Paises.Size = New System.Drawing.Size(140, 139)
        Me.Ltbx_Paises.TabIndex = 6
        '
        'Btn_BColor
        '
        Me.Btn_BColor.Location = New System.Drawing.Point(95, 325)
        Me.Btn_BColor.Name = "Btn_BColor"
        Me.Btn_BColor.Size = New System.Drawing.Size(140, 23)
        Me.Btn_BColor.TabIndex = 9
        Me.Btn_BColor.Text = "Borrar color"
        Me.Btn_BColor.UseVisualStyleBackColor = True
        '
        'Btn_BMarca
        '
        Me.Btn_BMarca.Location = New System.Drawing.Point(308, 325)
        Me.Btn_BMarca.Name = "Btn_BMarca"
        Me.Btn_BMarca.Size = New System.Drawing.Size(140, 23)
        Me.Btn_BMarca.TabIndex = 10
        Me.Btn_BMarca.Text = "Borrar marca"
        Me.Btn_BMarca.UseVisualStyleBackColor = True
        '
        'Btn_BPais
        '
        Me.Btn_BPais.Location = New System.Drawing.Point(526, 325)
        Me.Btn_BPais.Name = "Btn_BPais"
        Me.Btn_BPais.Size = New System.Drawing.Size(140, 23)
        Me.Btn_BPais.TabIndex = 11
        Me.Btn_BPais.Text = "Borrar pais"
        Me.Btn_BPais.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_BPais)
        Me.Controls.Add(Me.Btn_BMarca)
        Me.Controls.Add(Me.Btn_BColor)
        Me.Controls.Add(Me.Btn_Pais)
        Me.Controls.Add(Me.Txtb_Pais)
        Me.Controls.Add(Me.Ltbx_Paises)
        Me.Controls.Add(Me.Btn_Marca)
        Me.Controls.Add(Me.Txtb_Marca)
        Me.Controls.Add(Me.Ltbx_Marcas)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.Txtb_color)
        Me.Controls.Add(Me.Ltbx_Colores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ltbx_Colores As ListBox
    Friend WithEvents Txtb_color As TextBox
    Friend WithEvents BtnColor As Button
    Friend WithEvents Btn_Marca As Button
    Friend WithEvents Txtb_Marca As TextBox
    Friend WithEvents Ltbx_Marcas As ListBox
    Friend WithEvents Btn_Pais As Button
    Friend WithEvents Txtb_Pais As TextBox
    Friend WithEvents Ltbx_Paises As ListBox
    Friend WithEvents Btn_BColor As Button
    Friend WithEvents Btn_BMarca As Button
    Friend WithEvents Btn_BPais As Button
End Class
