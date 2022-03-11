<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crear_material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crear_material))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Lbl_nomPantalla = New System.Windows.Forms.Label()
        Me.lbl_num_mat = New System.Windows.Forms.Label()
        Me.tb_num_mat = New System.Windows.Forms.TextBox()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.tb_material = New System.Windows.Forms.TextBox()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.cbx_categoria = New System.Windows.Forms.ComboBox()
        Me.lbl_subcat = New System.Windows.Forms.Label()
        Me.cbx_subcat = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_compra = New System.Windows.Forms.Label()
        Me.tb_compra = New System.Windows.Forms.TextBox()
        Me.lbl_venta = New System.Windows.Forms.Label()
        Me.tb_venta = New System.Windows.Forms.TextBox()
        Me.lbl_pasillo = New System.Windows.Forms.Label()
        Me.cbx_pasillo = New System.Windows.Forms.ComboBox()
        Me.lbl_seccion = New System.Windows.Forms.Label()
        Me.pnl_seccion = New System.Windows.Forms.Panel()
        Me.rb_F = New System.Windows.Forms.RadioButton()
        Me.rb_E = New System.Windows.Forms.RadioButton()
        Me.rb_D = New System.Windows.Forms.RadioButton()
        Me.rb_C = New System.Windows.Forms.RadioButton()
        Me.rb_B = New System.Windows.Forms.RadioButton()
        Me.rb_A = New System.Windows.Forms.RadioButton()
        Me.tb_stock = New System.Windows.Forms.TextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.err_material = New System.Windows.Forms.Label()
        Me.err_cat = New System.Windows.Forms.Label()
        Me.err_subcat = New System.Windows.Forms.Label()
        Me.PB_logo = New System.Windows.Forms.PictureBox()
        Me.TS_inicio = New System.Windows.Forms.ToolStripButton()
        Me.TS_guardar = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnl_seccion.SuspendLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarMaterialToolStripMenuItem, Me.ListarMaterialesToolStripMenuItem, Me.BorrarMaterialToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar material"
        '
        'ListarMaterialesToolStripMenuItem
        '
        Me.ListarMaterialesToolStripMenuItem.Name = "ListarMaterialesToolStripMenuItem"
        Me.ListarMaterialesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ListarMaterialesToolStripMenuItem.Text = "Listar materiales"
        '
        'BorrarMaterialToolStripMenuItem
        '
        Me.BorrarMaterialToolStripMenuItem.Name = "BorrarMaterialToolStripMenuItem"
        Me.BorrarMaterialToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BorrarMaterialToolStripMenuItem.Text = "Borrar material"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_inicio, Me.TS_guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1039, 29)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Lbl_nomPantalla
        '
        Me.Lbl_nomPantalla.AutoSize = True
        Me.Lbl_nomPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomPantalla.Location = New System.Drawing.Point(91, 96)
        Me.Lbl_nomPantalla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_nomPantalla.Name = "Lbl_nomPantalla"
        Me.Lbl_nomPantalla.Size = New System.Drawing.Size(173, 29)
        Me.Lbl_nomPantalla.TabIndex = 4
        Me.Lbl_nomPantalla.Text = "Crear material"
        '
        'lbl_num_mat
        '
        Me.lbl_num_mat.AutoSize = True
        Me.lbl_num_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_mat.Location = New System.Drawing.Point(236, 162)
        Me.lbl_num_mat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_num_mat.Name = "lbl_num_mat"
        Me.lbl_num_mat.Size = New System.Drawing.Size(161, 20)
        Me.lbl_num_mat.TabIndex = 5
        Me.lbl_num_mat.Text = "Número de material:"
        '
        'tb_num_mat
        '
        Me.tb_num_mat.Enabled = False
        Me.tb_num_mat.Location = New System.Drawing.Point(425, 161)
        Me.tb_num_mat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_num_mat.Name = "tb_num_mat"
        Me.tb_num_mat.Size = New System.Drawing.Size(172, 22)
        Me.tb_num_mat.TabIndex = 6
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(335, 204)
        Me.lbl_material.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(74, 20)
        Me.lbl_material.TabIndex = 7
        Me.lbl_material.Text = "Material:"
        '
        'tb_material
        '
        Me.tb_material.Location = New System.Drawing.Point(425, 203)
        Me.tb_material.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_material.Name = "tb_material"
        Me.tb_material.Size = New System.Drawing.Size(172, 22)
        Me.tb_material.TabIndex = 8
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(320, 247)
        Me.lbl_categoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(86, 20)
        Me.lbl_categoria.TabIndex = 9
        Me.lbl_categoria.Text = "Categoría:"
        '
        'cbx_categoria
        '
        Me.cbx_categoria.FormattingEnabled = True
        Me.cbx_categoria.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cbx_categoria.Location = New System.Drawing.Point(425, 246)
        Me.cbx_categoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbx_categoria.Name = "cbx_categoria"
        Me.cbx_categoria.Size = New System.Drawing.Size(172, 24)
        Me.cbx_categoria.TabIndex = 10
        '
        'lbl_subcat
        '
        Me.lbl_subcat.AutoSize = True
        Me.lbl_subcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subcat.Location = New System.Drawing.Point(289, 292)
        Me.lbl_subcat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_subcat.Name = "lbl_subcat"
        Me.lbl_subcat.Size = New System.Drawing.Size(112, 20)
        Me.lbl_subcat.TabIndex = 11
        Me.lbl_subcat.Text = "Subcategoría:"
        '
        'cbx_subcat
        '
        Me.cbx_subcat.FormattingEnabled = True
        Me.cbx_subcat.Location = New System.Drawing.Point(425, 290)
        Me.cbx_subcat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbx_subcat.Name = "cbx_subcat"
        Me.cbx_subcat.Size = New System.Drawing.Size(172, 24)
        Me.cbx_subcat.TabIndex = 12
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(425, 334)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(172, 22)
        Me.dtp_fecha.TabIndex = 13
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(253, 334)
        Me.lbl_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(145, 20)
        Me.lbl_fecha.TabIndex = 14
        Me.lbl_fecha.Text = "Fecha de registro:"
        '
        'lbl_compra
        '
        Me.lbl_compra.AutoSize = True
        Me.lbl_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_compra.Location = New System.Drawing.Point(244, 476)
        Me.lbl_compra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_compra.Name = "lbl_compra"
        Me.lbl_compra.Size = New System.Drawing.Size(154, 20)
        Me.lbl_compra.TabIndex = 15
        Me.lbl_compra.Text = "Importe de compra:"
        '
        'tb_compra
        '
        Me.tb_compra.Location = New System.Drawing.Point(425, 475)
        Me.tb_compra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_compra.Name = "tb_compra"
        Me.tb_compra.Size = New System.Drawing.Size(97, 22)
        Me.tb_compra.TabIndex = 16
        '
        'lbl_venta
        '
        Me.lbl_venta.AutoSize = True
        Me.lbl_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_venta.Location = New System.Drawing.Point(260, 517)
        Me.lbl_venta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_venta.Name = "lbl_venta"
        Me.lbl_venta.Size = New System.Drawing.Size(138, 20)
        Me.lbl_venta.TabIndex = 17
        Me.lbl_venta.Text = "Importe de venta:"
        '
        'tb_venta
        '
        Me.tb_venta.Enabled = False
        Me.tb_venta.Location = New System.Drawing.Point(425, 516)
        Me.tb_venta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_venta.Name = "tb_venta"
        Me.tb_venta.Size = New System.Drawing.Size(97, 22)
        Me.tb_venta.TabIndex = 18
        '
        'lbl_pasillo
        '
        Me.lbl_pasillo.AutoSize = True
        Me.lbl_pasillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pasillo.Location = New System.Drawing.Point(347, 556)
        Me.lbl_pasillo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pasillo.Name = "lbl_pasillo"
        Me.lbl_pasillo.Size = New System.Drawing.Size(64, 20)
        Me.lbl_pasillo.TabIndex = 19
        Me.lbl_pasillo.Text = "Pasillo:"
        '
        'cbx_pasillo
        '
        Me.cbx_pasillo.FormattingEnabled = True
        Me.cbx_pasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbx_pasillo.Location = New System.Drawing.Point(425, 555)
        Me.cbx_pasillo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbx_pasillo.Name = "cbx_pasillo"
        Me.cbx_pasillo.Size = New System.Drawing.Size(97, 24)
        Me.cbx_pasillo.TabIndex = 20
        '
        'lbl_seccion
        '
        Me.lbl_seccion.AutoSize = True
        Me.lbl_seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seccion.Location = New System.Drawing.Point(335, 592)
        Me.lbl_seccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_seccion.Name = "lbl_seccion"
        Me.lbl_seccion.Size = New System.Drawing.Size(74, 20)
        Me.lbl_seccion.TabIndex = 21
        Me.lbl_seccion.Text = "Sección:"
        '
        'pnl_seccion
        '
        Me.pnl_seccion.Controls.Add(Me.rb_F)
        Me.pnl_seccion.Controls.Add(Me.rb_E)
        Me.pnl_seccion.Controls.Add(Me.rb_D)
        Me.pnl_seccion.Controls.Add(Me.rb_C)
        Me.pnl_seccion.Controls.Add(Me.rb_B)
        Me.pnl_seccion.Controls.Add(Me.rb_A)
        Me.pnl_seccion.Location = New System.Drawing.Point(425, 588)
        Me.pnl_seccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_seccion.Name = "pnl_seccion"
        Me.pnl_seccion.Size = New System.Drawing.Size(307, 30)
        Me.pnl_seccion.TabIndex = 22
        '
        'rb_F
        '
        Me.rb_F.AutoSize = True
        Me.rb_F.Location = New System.Drawing.Point(259, 4)
        Me.rb_F.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_F.Name = "rb_F"
        Me.rb_F.Size = New System.Drawing.Size(37, 21)
        Me.rb_F.TabIndex = 28
        Me.rb_F.TabStop = True
        Me.rb_F.Text = "F"
        Me.rb_F.UseVisualStyleBackColor = True
        '
        'rb_E
        '
        Me.rb_E.AutoSize = True
        Me.rb_E.Location = New System.Drawing.Point(208, 4)
        Me.rb_E.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_E.Name = "rb_E"
        Me.rb_E.Size = New System.Drawing.Size(38, 21)
        Me.rb_E.TabIndex = 27
        Me.rb_E.TabStop = True
        Me.rb_E.Text = "E"
        Me.rb_E.UseVisualStyleBackColor = True
        '
        'rb_D
        '
        Me.rb_D.AutoSize = True
        Me.rb_D.Location = New System.Drawing.Point(156, 4)
        Me.rb_D.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_D.Name = "rb_D"
        Me.rb_D.Size = New System.Drawing.Size(39, 21)
        Me.rb_D.TabIndex = 26
        Me.rb_D.TabStop = True
        Me.rb_D.Text = "D"
        Me.rb_D.UseVisualStyleBackColor = True
        '
        'rb_C
        '
        Me.rb_C.AutoSize = True
        Me.rb_C.Location = New System.Drawing.Point(105, 4)
        Me.rb_C.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_C.Name = "rb_C"
        Me.rb_C.Size = New System.Drawing.Size(38, 21)
        Me.rb_C.TabIndex = 25
        Me.rb_C.TabStop = True
        Me.rb_C.Text = "C"
        Me.rb_C.UseVisualStyleBackColor = True
        '
        'rb_B
        '
        Me.rb_B.AutoSize = True
        Me.rb_B.Location = New System.Drawing.Point(55, 4)
        Me.rb_B.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_B.Name = "rb_B"
        Me.rb_B.Size = New System.Drawing.Size(38, 21)
        Me.rb_B.TabIndex = 24
        Me.rb_B.TabStop = True
        Me.rb_B.Text = "B"
        Me.rb_B.UseVisualStyleBackColor = True
        '
        'rb_A
        '
        Me.rb_A.AutoSize = True
        Me.rb_A.Location = New System.Drawing.Point(4, 4)
        Me.rb_A.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_A.Name = "rb_A"
        Me.rb_A.Size = New System.Drawing.Size(38, 21)
        Me.rb_A.TabIndex = 23
        Me.rb_A.TabStop = True
        Me.rb_A.Text = "A"
        Me.rb_A.UseVisualStyleBackColor = True
        '
        'tb_stock
        '
        Me.tb_stock.Location = New System.Drawing.Point(424, 625)
        Me.tb_stock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_stock.Name = "tb_stock"
        Me.tb_stock.Size = New System.Drawing.Size(97, 22)
        Me.tb_stock.TabIndex = 23
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.Location = New System.Drawing.Point(355, 625)
        Me.lbl_stock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(56, 20)
        Me.lbl_stock.TabIndex = 24
        Me.lbl_stock.Text = "Stock:"
        '
        'tb_desc
        '
        Me.tb_desc.Location = New System.Drawing.Point(424, 374)
        Me.tb_desc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_desc.Multiline = True
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(173, 84)
        Me.tb_desc.TabIndex = 25
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(303, 375)
        Me.lbl_descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(104, 20)
        Me.lbl_descripcion.TabIndex = 26
        Me.lbl_descripcion.Text = "Descripcion:"
        '
        'err_material
        '
        Me.err_material.AutoSize = True
        Me.err_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_material.ForeColor = System.Drawing.Color.Red
        Me.err_material.Location = New System.Drawing.Point(600, 207)
        Me.err_material.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_material.Name = "err_material"
        Me.err_material.Size = New System.Drawing.Size(0, 17)
        Me.err_material.TabIndex = 28
        '
        'err_cat
        '
        Me.err_cat.AutoSize = True
        Me.err_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_cat.ForeColor = System.Drawing.Color.Red
        Me.err_cat.Location = New System.Drawing.Point(600, 250)
        Me.err_cat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_cat.Name = "err_cat"
        Me.err_cat.Size = New System.Drawing.Size(0, 17)
        Me.err_cat.TabIndex = 29
        '
        'err_subcat
        '
        Me.err_subcat.AutoSize = True
        Me.err_subcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_subcat.ForeColor = System.Drawing.Color.Red
        Me.err_subcat.Location = New System.Drawing.Point(600, 294)
        Me.err_subcat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_subcat.Name = "err_subcat"
        Me.err_subcat.Size = New System.Drawing.Size(0, 17)
        Me.err_subcat.TabIndex = 30
        '
        'PB_logo
        '
        Me.PB_logo.Image = Global.AlmacenMateriales.My.Resources.Resources.logo
        Me.PB_logo.Location = New System.Drawing.Point(16, 76)
        Me.PB_logo.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_logo.Name = "PB_logo"
        Me.PB_logo.Size = New System.Drawing.Size(67, 62)
        Me.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo.TabIndex = 3
        Me.PB_logo.TabStop = False
        '
        'TS_inicio
        '
        Me.TS_inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_inicio.Image = Global.AlmacenMateriales.My.Resources.Resources.inicio
        Me.TS_inicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_inicio.Name = "TS_inicio"
        Me.TS_inicio.Size = New System.Drawing.Size(29, 26)
        Me.TS_inicio.Text = "ToolStripButton1"
        Me.TS_inicio.ToolTipText = "Inicio"
        '
        'TS_guardar
        '
        Me.TS_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_guardar.Image = Global.AlmacenMateriales.My.Resources.Resources.guardar
        Me.TS_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_guardar.Name = "TS_guardar"
        Me.TS_guardar.Size = New System.Drawing.Size(29, 26)
        Me.TS_guardar.Text = "ToolStripButton2"
        Me.TS_guardar.ToolTipText = "Guardar"
        '
        'Crear_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1039, 693)
        Me.Controls.Add(Me.err_subcat)
        Me.Controls.Add(Me.err_cat)
        Me.Controls.Add(Me.err_material)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.tb_desc)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.tb_stock)
        Me.Controls.Add(Me.pnl_seccion)
        Me.Controls.Add(Me.lbl_seccion)
        Me.Controls.Add(Me.cbx_pasillo)
        Me.Controls.Add(Me.lbl_pasillo)
        Me.Controls.Add(Me.tb_venta)
        Me.Controls.Add(Me.lbl_venta)
        Me.Controls.Add(Me.tb_compra)
        Me.Controls.Add(Me.lbl_compra)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.cbx_subcat)
        Me.Controls.Add(Me.lbl_subcat)
        Me.Controls.Add(Me.cbx_categoria)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.tb_material)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.tb_num_mat)
        Me.Controls.Add(Me.lbl_num_mat)
        Me.Controls.Add(Me.Lbl_nomPantalla)
        Me.Controls.Add(Me.PB_logo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Crear_material"
        Me.Text = "Crear material"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnl_seccion.ResumeLayout(False)
        Me.pnl_seccion.PerformLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PB_logo As PictureBox
    Friend WithEvents Lbl_nomPantalla As Label
    Friend WithEvents TS_inicio As ToolStripButton
    Friend WithEvents TS_guardar As ToolStripButton
    Friend WithEvents lbl_num_mat As Label
    Friend WithEvents tb_num_mat As TextBox
    Friend WithEvents lbl_material As Label
    Friend WithEvents tb_material As TextBox
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents cbx_categoria As ComboBox
    Friend WithEvents lbl_subcat As Label
    Friend WithEvents cbx_subcat As ComboBox
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_compra As Label
    Friend WithEvents tb_compra As TextBox
    Friend WithEvents lbl_venta As Label
    Friend WithEvents tb_venta As TextBox
    Friend WithEvents lbl_pasillo As Label
    Friend WithEvents cbx_pasillo As ComboBox
    Friend WithEvents lbl_seccion As Label
    Friend WithEvents pnl_seccion As Panel
    Friend WithEvents rb_F As RadioButton
    Friend WithEvents rb_E As RadioButton
    Friend WithEvents rb_D As RadioButton
    Friend WithEvents rb_C As RadioButton
    Friend WithEvents rb_B As RadioButton
    Friend WithEvents rb_A As RadioButton
    Friend WithEvents tb_stock As TextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents tb_desc As TextBox
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents err_material As Label
    Friend WithEvents err_cat As Label
    Friend WithEvents err_subcat As Label
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarMaterialToolStripMenuItem As ToolStripMenuItem
End Class
