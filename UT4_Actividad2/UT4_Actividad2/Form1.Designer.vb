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
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.Lbl_apellidos = New System.Windows.Forms.Label()
        Me.tb_apellido = New System.Windows.Forms.TextBox()
        Me.tb_dni = New System.Windows.Forms.TextBox()
        Me.Lbl_dni = New System.Windows.Forms.Label()
        Me.Lbl_ = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_departamento = New System.Windows.Forms.Label()
        Me.Pnl_radio = New System.Windows.Forms.Panel()
        Me.Rb_logistica = New System.Windows.Forms.RadioButton()
        Me.Rb_RRHH = New System.Windows.Forms.RadioButton()
        Me.Rb_finanzas = New System.Windows.Forms.RadioButton()
        Me.Lbl_periodo = New System.Windows.Forms.Label()
        Me.Cbx_periodo = New System.Windows.Forms.ComboBox()
        Me.Gb_datosPersonales = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_obligatorio1 = New System.Windows.Forms.Label()
        Me.Gb_empresa = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_obligatorio = New System.Windows.Forms.Label()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.Pnl_radio.SuspendLayout()
        Me.Gb_datosPersonales.SuspendLayout()
        Me.Gb_empresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.AutoSize = True
        Me.Lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titulo.Location = New System.Drawing.Point(35, 35)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(204, 24)
        Me.Lbl_titulo.TabIndex = 0
        Me.Lbl_titulo.Text = "Registro de personal"
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(17, 27)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.Lbl_nombre.TabIndex = 1
        Me.Lbl_nombre.Tag = ""
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(20, 47)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(165, 23)
        Me.tb_nombre.TabIndex = 2
        Me.tb_nombre.Tag = "nombre"
        '
        'Lbl_apellidos
        '
        Me.Lbl_apellidos.AutoSize = True
        Me.Lbl_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_apellidos.Location = New System.Drawing.Point(17, 82)
        Me.Lbl_apellidos.Name = "Lbl_apellidos"
        Me.Lbl_apellidos.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_apellidos.TabIndex = 3
        Me.Lbl_apellidos.Tag = ""
        Me.Lbl_apellidos.Text = "Apellidos:"
        '
        'tb_apellido
        '
        Me.tb_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_apellido.Location = New System.Drawing.Point(20, 102)
        Me.tb_apellido.Name = "tb_apellido"
        Me.tb_apellido.Size = New System.Drawing.Size(167, 23)
        Me.tb_apellido.TabIndex = 4
        Me.tb_apellido.Tag = "apellidos"
        '
        'tb_dni
        '
        Me.tb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dni.Location = New System.Drawing.Point(20, 157)
        Me.tb_dni.Name = "tb_dni"
        Me.tb_dni.Size = New System.Drawing.Size(165, 23)
        Me.tb_dni.TabIndex = 6
        Me.tb_dni.Tag = "dni"
        '
        'Lbl_dni
        '
        Me.Lbl_dni.AutoSize = True
        Me.Lbl_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dni.Location = New System.Drawing.Point(17, 137)
        Me.Lbl_dni.Name = "Lbl_dni"
        Me.Lbl_dni.Size = New System.Drawing.Size(35, 17)
        Me.Lbl_dni.TabIndex = 5
        Me.Lbl_dni.Tag = ""
        Me.Lbl_dni.Text = "DNI:"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_.Location = New System.Drawing.Point(17, 193)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(143, 17)
        Me.Lbl_.TabIndex = 7
        Me.Lbl_.Tag = ""
        Me.Lbl_.Text = "Fecha de nacimiento:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(20, 213)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(167, 24)
        Me.dtp_fecha.TabIndex = 8
        Me.dtp_fecha.Tag = "fecha"
        '
        'Lbl_departamento
        '
        Me.Lbl_departamento.AutoSize = True
        Me.Lbl_departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_departamento.Location = New System.Drawing.Point(22, 27)
        Me.Lbl_departamento.Name = "Lbl_departamento"
        Me.Lbl_departamento.Size = New System.Drawing.Size(178, 17)
        Me.Lbl_departamento.TabIndex = 9
        Me.Lbl_departamento.Tag = ""
        Me.Lbl_departamento.Text = "Departamento autorizador:"
        '
        'Pnl_radio
        '
        Me.Pnl_radio.Controls.Add(Me.Rb_logistica)
        Me.Pnl_radio.Controls.Add(Me.Rb_RRHH)
        Me.Pnl_radio.Controls.Add(Me.Rb_finanzas)
        Me.Pnl_radio.Location = New System.Drawing.Point(25, 57)
        Me.Pnl_radio.Name = "Pnl_radio"
        Me.Pnl_radio.Size = New System.Drawing.Size(200, 79)
        Me.Pnl_radio.TabIndex = 10
        Me.Pnl_radio.Tag = "dept"
        '
        'Rb_logistica
        '
        Me.Rb_logistica.AutoSize = True
        Me.Rb_logistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_logistica.Location = New System.Drawing.Point(27, 57)
        Me.Rb_logistica.Name = "Rb_logistica"
        Me.Rb_logistica.Size = New System.Drawing.Size(82, 21)
        Me.Rb_logistica.TabIndex = 2
        Me.Rb_logistica.Text = "Logística"
        Me.Rb_logistica.UseVisualStyleBackColor = True
        '
        'Rb_RRHH
        '
        Me.Rb_RRHH.AutoSize = True
        Me.Rb_RRHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RRHH.Location = New System.Drawing.Point(27, 30)
        Me.Rb_RRHH.Name = "Rb_RRHH"
        Me.Rb_RRHH.Size = New System.Drawing.Size(148, 21)
        Me.Rb_RRHH.TabIndex = 1
        Me.Rb_RRHH.Text = "Recursos humanos"
        Me.Rb_RRHH.UseVisualStyleBackColor = True
        '
        'Rb_finanzas
        '
        Me.Rb_finanzas.AutoSize = True
        Me.Rb_finanzas.Checked = True
        Me.Rb_finanzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_finanzas.Location = New System.Drawing.Point(27, 3)
        Me.Rb_finanzas.Name = "Rb_finanzas"
        Me.Rb_finanzas.Size = New System.Drawing.Size(83, 21)
        Me.Rb_finanzas.TabIndex = 0
        Me.Rb_finanzas.TabStop = True
        Me.Rb_finanzas.Text = "Finanzas"
        Me.Rb_finanzas.UseVisualStyleBackColor = True
        '
        'Lbl_periodo
        '
        Me.Lbl_periodo.AutoSize = True
        Me.Lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_periodo.Location = New System.Drawing.Point(22, 157)
        Me.Lbl_periodo.Name = "Lbl_periodo"
        Me.Lbl_periodo.Size = New System.Drawing.Size(130, 17)
        Me.Lbl_periodo.TabIndex = 11
        Me.Lbl_periodo.Tag = ""
        Me.Lbl_periodo.Text = "Periodo de acceso:"
        '
        'Cbx_periodo
        '
        Me.Cbx_periodo.FormattingEnabled = True
        Me.Cbx_periodo.Items.AddRange(New Object() {"Matutino (08:00 - 14:00)", "Vespertino (14:00 - 22:00)", "Nocturno (22:00 - 08:00)"})
        Me.Cbx_periodo.Location = New System.Drawing.Point(25, 177)
        Me.Cbx_periodo.Name = "Cbx_periodo"
        Me.Cbx_periodo.Size = New System.Drawing.Size(231, 23)
        Me.Cbx_periodo.TabIndex = 12
        Me.Cbx_periodo.Tag = "periodo"
        '
        'Gb_datosPersonales
        '
        Me.Gb_datosPersonales.Controls.Add(Me.Label2)
        Me.Gb_datosPersonales.Controls.Add(Me.Label1)
        Me.Gb_datosPersonales.Controls.Add(Me.Lbl_obligatorio1)
        Me.Gb_datosPersonales.Controls.Add(Me.tb_nombre)
        Me.Gb_datosPersonales.Controls.Add(Me.Lbl_nombre)
        Me.Gb_datosPersonales.Controls.Add(Me.Lbl_apellidos)
        Me.Gb_datosPersonales.Controls.Add(Me.tb_apellido)
        Me.Gb_datosPersonales.Controls.Add(Me.Lbl_dni)
        Me.Gb_datosPersonales.Controls.Add(Me.dtp_fecha)
        Me.Gb_datosPersonales.Controls.Add(Me.tb_dni)
        Me.Gb_datosPersonales.Controls.Add(Me.Lbl_)
        Me.Gb_datosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_datosPersonales.Location = New System.Drawing.Point(54, 83)
        Me.Gb_datosPersonales.Name = "Gb_datosPersonales"
        Me.Gb_datosPersonales.Size = New System.Drawing.Size(272, 248)
        Me.Gb_datosPersonales.TabIndex = 13
        Me.Gb_datosPersonales.TabStop = False
        Me.Gb_datosPersonales.Text = "Datos personales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(48, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Tag = "dni"
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(82, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Tag = "apellidos"
        Me.Label1.Text = "*"
        '
        'Lbl_obligatorio1
        '
        Me.Lbl_obligatorio1.AutoSize = True
        Me.Lbl_obligatorio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_obligatorio1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_obligatorio1.Location = New System.Drawing.Point(73, 27)
        Me.Lbl_obligatorio1.Name = "Lbl_obligatorio1"
        Me.Lbl_obligatorio1.Size = New System.Drawing.Size(13, 17)
        Me.Lbl_obligatorio1.TabIndex = 15
        Me.Lbl_obligatorio1.Tag = "nombre"
        Me.Lbl_obligatorio1.Text = "*"
        '
        'Gb_empresa
        '
        Me.Gb_empresa.Controls.Add(Me.Label5)
        Me.Gb_empresa.Controls.Add(Me.Label4)
        Me.Gb_empresa.Controls.Add(Me.Lbl_departamento)
        Me.Gb_empresa.Controls.Add(Me.Pnl_radio)
        Me.Gb_empresa.Controls.Add(Me.Cbx_periodo)
        Me.Gb_empresa.Controls.Add(Me.Lbl_periodo)
        Me.Gb_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_empresa.Location = New System.Drawing.Point(413, 83)
        Me.Gb_empresa.Name = "Gb_empresa"
        Me.Gb_empresa.Size = New System.Drawing.Size(291, 251)
        Me.Gb_empresa.TabIndex = 14
        Me.Gb_empresa.TabStop = False
        Me.Gb_empresa.Text = "Datos de empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(148, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Tag = "periodo"
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(196, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Tag = "dept"
        Me.Label4.Text = "*"
        '
        'Lbl_obligatorio
        '
        Me.Lbl_obligatorio.AutoSize = True
        Me.Lbl_obligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_obligatorio.ForeColor = System.Drawing.Color.Red
        Me.Lbl_obligatorio.Location = New System.Drawing.Point(53, 357)
        Me.Lbl_obligatorio.Name = "Lbl_obligatorio"
        Me.Lbl_obligatorio.Size = New System.Drawing.Size(155, 17)
        Me.Lbl_obligatorio.TabIndex = 18
        Me.Lbl_obligatorio.Tag = "nombre"
        Me.Lbl_obligatorio.Text = "(Campos obligatorios *)"
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.Ivory
        Me.btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_enviar.Location = New System.Drawing.Point(306, 405)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(118, 45)
        Me.btn_enviar.TabIndex = 19
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(800, 514)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.Lbl_obligatorio)
        Me.Controls.Add(Me.Gb_empresa)
        Me.Controls.Add(Me.Gb_datosPersonales)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Name = "Form1"
        Me.Text = "Enviar"
        Me.Pnl_radio.ResumeLayout(False)
        Me.Pnl_radio.PerformLayout()
        Me.Gb_datosPersonales.ResumeLayout(False)
        Me.Gb_datosPersonales.PerformLayout()
        Me.Gb_empresa.ResumeLayout(False)
        Me.Gb_empresa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_titulo As Label
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Lbl_apellidos As Label
    Friend WithEvents tb_apellido As TextBox
    Friend WithEvents tb_dni As TextBox
    Friend WithEvents Lbl_dni As Label
    Friend WithEvents Lbl_ As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Lbl_departamento As Label
    Friend WithEvents Pnl_radio As Panel
    Friend WithEvents Rb_logistica As RadioButton
    Friend WithEvents Rb_RRHH As RadioButton
    Friend WithEvents Rb_finanzas As RadioButton
    Friend WithEvents Lbl_periodo As Label
    Friend WithEvents Cbx_periodo As ComboBox
    Friend WithEvents Gb_datosPersonales As GroupBox
    Friend WithEvents Gb_empresa As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_obligatorio1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_obligatorio As Label
    Friend WithEvents btn_enviar As Button
End Class
