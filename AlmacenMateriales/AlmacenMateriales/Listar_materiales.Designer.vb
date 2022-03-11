<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listar_materiales
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listar_materiales))
        Me.Barra_menu = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TS_inicio = New System.Windows.Forms.ToolStripButton()
        Me.Lbl_nomPantalla = New System.Windows.Forms.Label()
        Me.PB_logo = New System.Windows.Forms.PictureBox()
        Me.tb_num_mat = New System.Windows.Forms.TextBox()
        Me.lbl_num_mat = New System.Windows.Forms.Label()
        Me.err_subcat = New System.Windows.Forms.Label()
        Me.err_cat = New System.Windows.Forms.Label()
        Me.cbx_subcat = New System.Windows.Forms.ComboBox()
        Me.lbl_subcat = New System.Windows.Forms.Label()
        Me.cbx_categoria = New System.Windows.Forms.ComboBox()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.pnl_seccion = New System.Windows.Forms.Panel()
        Me.rb_F = New System.Windows.Forms.RadioButton()
        Me.rb_E = New System.Windows.Forms.RadioButton()
        Me.rb_D = New System.Windows.Forms.RadioButton()
        Me.rb_C = New System.Windows.Forms.RadioButton()
        Me.rb_B = New System.Windows.Forms.RadioButton()
        Me.rb_A = New System.Windows.Forms.RadioButton()
        Me.lbl_seccion = New System.Windows.Forms.Label()
        Me.cbx_pasillo = New System.Windows.Forms.ComboBox()
        Me.lbl_pasillo = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.GridMateriales = New System.Windows.Forms.DataGridView()
        Me.num_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imp_com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imp_ven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenBDDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenBDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Barra_menu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_seccion.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBDDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra_menu
        '
        Me.Barra_menu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Barra_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Barra_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.Barra_menu.Location = New System.Drawing.Point(0, 0)
        Me.Barra_menu.Name = "Barra_menu"
        Me.Barra_menu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.Barra_menu.Size = New System.Drawing.Size(1028, 24)
        Me.Barra_menu.TabIndex = 1
        Me.Barra_menu.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearMaterialToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.BorrarMaterialToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CrearMaterialToolStripMenuItem
        '
        Me.CrearMaterialToolStripMenuItem.Name = "CrearMaterialToolStripMenuItem"
        Me.CrearMaterialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CrearMaterialToolStripMenuItem.Text = "Crear material"
        '
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar material"
        '
        'BorrarMaterialToolStripMenuItem
        '
        Me.BorrarMaterialToolStripMenuItem.Name = "BorrarMaterialToolStripMenuItem"
        Me.BorrarMaterialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorrarMaterialToolStripMenuItem.Text = "Borrar material"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_inicio})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 29)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TS_inicio
        '
        Me.TS_inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_inicio.Image = Global.AlmacenMateriales.My.Resources.Resources.inicio
        Me.TS_inicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_inicio.Name = "TS_inicio"
        Me.TS_inicio.Size = New System.Drawing.Size(26, 26)
        Me.TS_inicio.Text = "ToolStripButton1"
        Me.TS_inicio.ToolTipText = "Inicio"
        '
        'Lbl_nomPantalla
        '
        Me.Lbl_nomPantalla.AutoSize = True
        Me.Lbl_nomPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomPantalla.Location = New System.Drawing.Point(68, 78)
        Me.Lbl_nomPantalla.Name = "Lbl_nomPantalla"
        Me.Lbl_nomPantalla.Size = New System.Drawing.Size(153, 25)
        Me.Lbl_nomPantalla.TabIndex = 6
        Me.Lbl_nomPantalla.Text = "Listar materiales"
        '
        'PB_logo
        '
        Me.PB_logo.Image = Global.AlmacenMateriales.My.Resources.Resources.logo
        Me.PB_logo.Location = New System.Drawing.Point(12, 62)
        Me.PB_logo.Name = "PB_logo"
        Me.PB_logo.Size = New System.Drawing.Size(50, 50)
        Me.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo.TabIndex = 5
        Me.PB_logo.TabStop = False
        '
        'tb_num_mat
        '
        Me.tb_num_mat.Location = New System.Drawing.Point(354, 131)
        Me.tb_num_mat.Name = "tb_num_mat"
        Me.tb_num_mat.Size = New System.Drawing.Size(130, 20)
        Me.tb_num_mat.TabIndex = 8
        '
        'lbl_num_mat
        '
        Me.lbl_num_mat.AutoSize = True
        Me.lbl_num_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_mat.Location = New System.Drawing.Point(212, 132)
        Me.lbl_num_mat.Name = "lbl_num_mat"
        Me.lbl_num_mat.Size = New System.Drawing.Size(136, 17)
        Me.lbl_num_mat.TabIndex = 7
        Me.lbl_num_mat.Text = "Número de material:"
        '
        'err_subcat
        '
        Me.err_subcat.AutoSize = True
        Me.err_subcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_subcat.ForeColor = System.Drawing.Color.Red
        Me.err_subcat.Location = New System.Drawing.Point(485, 204)
        Me.err_subcat.Name = "err_subcat"
        Me.err_subcat.Size = New System.Drawing.Size(0, 13)
        Me.err_subcat.TabIndex = 36
        '
        'err_cat
        '
        Me.err_cat.AutoSize = True
        Me.err_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_cat.ForeColor = System.Drawing.Color.Red
        Me.err_cat.Location = New System.Drawing.Point(485, 168)
        Me.err_cat.Name = "err_cat"
        Me.err_cat.Size = New System.Drawing.Size(0, 13)
        Me.err_cat.TabIndex = 35
        '
        'cbx_subcat
        '
        Me.cbx_subcat.FormattingEnabled = True
        Me.cbx_subcat.Location = New System.Drawing.Point(354, 201)
        Me.cbx_subcat.Name = "cbx_subcat"
        Me.cbx_subcat.Size = New System.Drawing.Size(130, 21)
        Me.cbx_subcat.TabIndex = 34
        '
        'lbl_subcat
        '
        Me.lbl_subcat.AutoSize = True
        Me.lbl_subcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subcat.Location = New System.Drawing.Point(252, 202)
        Me.lbl_subcat.Name = "lbl_subcat"
        Me.lbl_subcat.Size = New System.Drawing.Size(96, 17)
        Me.lbl_subcat.TabIndex = 33
        Me.lbl_subcat.Text = "Subcategoría:"
        '
        'cbx_categoria
        '
        Me.cbx_categoria.FormattingEnabled = True
        Me.cbx_categoria.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cbx_categoria.Location = New System.Drawing.Point(354, 165)
        Me.cbx_categoria.Name = "cbx_categoria"
        Me.cbx_categoria.Size = New System.Drawing.Size(130, 21)
        Me.cbx_categoria.TabIndex = 32
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(275, 166)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(73, 17)
        Me.lbl_categoria.TabIndex = 31
        Me.lbl_categoria.Text = "Categoría:"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(226, 236)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(123, 17)
        Me.lbl_fecha.TabIndex = 38
        Me.lbl_fecha.Text = "Fecha de registro:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(355, 236)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.ShowCheckBox = True
        Me.dtp_fecha.Size = New System.Drawing.Size(130, 20)
        Me.dtp_fecha.TabIndex = 37
        '
        'pnl_seccion
        '
        Me.pnl_seccion.Controls.Add(Me.rb_F)
        Me.pnl_seccion.Controls.Add(Me.rb_E)
        Me.pnl_seccion.Controls.Add(Me.rb_D)
        Me.pnl_seccion.Controls.Add(Me.rb_C)
        Me.pnl_seccion.Controls.Add(Me.rb_B)
        Me.pnl_seccion.Controls.Add(Me.rb_A)
        Me.pnl_seccion.Location = New System.Drawing.Point(355, 296)
        Me.pnl_seccion.Name = "pnl_seccion"
        Me.pnl_seccion.Size = New System.Drawing.Size(230, 24)
        Me.pnl_seccion.TabIndex = 42
        '
        'rb_F
        '
        Me.rb_F.AutoSize = True
        Me.rb_F.Location = New System.Drawing.Point(194, 3)
        Me.rb_F.Name = "rb_F"
        Me.rb_F.Size = New System.Drawing.Size(31, 17)
        Me.rb_F.TabIndex = 28
        Me.rb_F.TabStop = True
        Me.rb_F.Text = "F"
        Me.rb_F.UseVisualStyleBackColor = True
        '
        'rb_E
        '
        Me.rb_E.AutoSize = True
        Me.rb_E.Location = New System.Drawing.Point(156, 3)
        Me.rb_E.Name = "rb_E"
        Me.rb_E.Size = New System.Drawing.Size(32, 17)
        Me.rb_E.TabIndex = 27
        Me.rb_E.TabStop = True
        Me.rb_E.Text = "E"
        Me.rb_E.UseVisualStyleBackColor = True
        '
        'rb_D
        '
        Me.rb_D.AutoSize = True
        Me.rb_D.Location = New System.Drawing.Point(117, 3)
        Me.rb_D.Name = "rb_D"
        Me.rb_D.Size = New System.Drawing.Size(33, 17)
        Me.rb_D.TabIndex = 26
        Me.rb_D.TabStop = True
        Me.rb_D.Text = "D"
        Me.rb_D.UseVisualStyleBackColor = True
        '
        'rb_C
        '
        Me.rb_C.AutoSize = True
        Me.rb_C.Location = New System.Drawing.Point(79, 3)
        Me.rb_C.Name = "rb_C"
        Me.rb_C.Size = New System.Drawing.Size(32, 17)
        Me.rb_C.TabIndex = 25
        Me.rb_C.TabStop = True
        Me.rb_C.Text = "C"
        Me.rb_C.UseVisualStyleBackColor = True
        '
        'rb_B
        '
        Me.rb_B.AutoSize = True
        Me.rb_B.Location = New System.Drawing.Point(41, 3)
        Me.rb_B.Name = "rb_B"
        Me.rb_B.Size = New System.Drawing.Size(32, 17)
        Me.rb_B.TabIndex = 24
        Me.rb_B.TabStop = True
        Me.rb_B.Text = "B"
        Me.rb_B.UseVisualStyleBackColor = True
        '
        'rb_A
        '
        Me.rb_A.AutoSize = True
        Me.rb_A.Location = New System.Drawing.Point(3, 3)
        Me.rb_A.Name = "rb_A"
        Me.rb_A.Size = New System.Drawing.Size(32, 17)
        Me.rb_A.TabIndex = 23
        Me.rb_A.TabStop = True
        Me.rb_A.Text = "A"
        Me.rb_A.UseVisualStyleBackColor = True
        '
        'lbl_seccion
        '
        Me.lbl_seccion.AutoSize = True
        Me.lbl_seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seccion.Location = New System.Drawing.Point(287, 299)
        Me.lbl_seccion.Name = "lbl_seccion"
        Me.lbl_seccion.Size = New System.Drawing.Size(62, 17)
        Me.lbl_seccion.TabIndex = 41
        Me.lbl_seccion.Text = "Sección:"
        '
        'cbx_pasillo
        '
        Me.cbx_pasillo.FormattingEnabled = True
        Me.cbx_pasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbx_pasillo.Location = New System.Drawing.Point(355, 269)
        Me.cbx_pasillo.Name = "cbx_pasillo"
        Me.cbx_pasillo.Size = New System.Drawing.Size(74, 21)
        Me.cbx_pasillo.TabIndex = 40
        '
        'lbl_pasillo
        '
        Me.lbl_pasillo.AutoSize = True
        Me.lbl_pasillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pasillo.Location = New System.Drawing.Point(296, 270)
        Me.lbl_pasillo.Name = "lbl_pasillo"
        Me.lbl_pasillo.Size = New System.Drawing.Size(53, 17)
        Me.lbl_pasillo.TabIndex = 39
        Me.lbl_pasillo.Text = "Pasillo:"
        '
        'btn_listar
        '
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.Location = New System.Drawing.Point(626, 281)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(105, 39)
        Me.btn_listar.TabIndex = 43
        Me.btn_listar.Text = "Listar"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'GridMateriales
        '
        Me.GridMateriales.AllowUserToOrderColumns = True
        Me.GridMateriales.AutoGenerateColumns = False
        Me.GridMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_mat, Me.mat, Me.cat, Me.sub_cat, Me.fe_reg, Me.desc, Me.imp_com, Me.imp_ven, Me.pas, Me.sec, Me.stock})
        Me.GridMateriales.DataSource = Me.AlmacenBDDataSet1BindingSource
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridMateriales.Location = New System.Drawing.Point(0, 346)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.RowHeadersWidth = 51
        Me.GridMateriales.Size = New System.Drawing.Size(1028, 235)
        Me.GridMateriales.TabIndex = 44
        '
        'num_mat
        '
        Me.num_mat.DataPropertyName = "num_mat"
        Me.num_mat.HeaderText = "Número de material"
        Me.num_mat.MinimumWidth = 6
        Me.num_mat.Name = "num_mat"
        Me.num_mat.Width = 125
        '
        'mat
        '
        Me.mat.DataPropertyName = "mat"
        Me.mat.HeaderText = "Material"
        Me.mat.MinimumWidth = 6
        Me.mat.Name = "mat"
        Me.mat.Width = 125
        '
        'cat
        '
        Me.cat.DataPropertyName = "cat"
        Me.cat.HeaderText = "Categoría"
        Me.cat.MinimumWidth = 6
        Me.cat.Name = "cat"
        Me.cat.Width = 125
        '
        'sub_cat
        '
        Me.sub_cat.DataPropertyName = "sub_cat"
        Me.sub_cat.HeaderText = "Subcategoría"
        Me.sub_cat.MinimumWidth = 6
        Me.sub_cat.Name = "sub_cat"
        Me.sub_cat.Width = 125
        '
        'fe_reg
        '
        Me.fe_reg.DataPropertyName = "fe_reg"
        Me.fe_reg.HeaderText = "Fecha de registro"
        Me.fe_reg.MinimumWidth = 6
        Me.fe_reg.Name = "fe_reg"
        Me.fe_reg.Width = 125
        '
        'desc
        '
        Me.desc.DataPropertyName = "desc"
        Me.desc.HeaderText = "Descripción"
        Me.desc.MinimumWidth = 6
        Me.desc.Name = "desc"
        Me.desc.Width = 125
        '
        'imp_com
        '
        Me.imp_com.DataPropertyName = "imp_com"
        Me.imp_com.HeaderText = "Importe Compra"
        Me.imp_com.MinimumWidth = 6
        Me.imp_com.Name = "imp_com"
        Me.imp_com.Width = 125
        '
        'imp_ven
        '
        Me.imp_ven.DataPropertyName = "imp_ven"
        Me.imp_ven.HeaderText = "Importe Venta"
        Me.imp_ven.MinimumWidth = 6
        Me.imp_ven.Name = "imp_ven"
        Me.imp_ven.Width = 125
        '
        'pas
        '
        Me.pas.DataPropertyName = "pas"
        Me.pas.HeaderText = "Pasillo"
        Me.pas.MinimumWidth = 6
        Me.pas.Name = "pas"
        Me.pas.Width = 125
        '
        'sec
        '
        Me.sec.DataPropertyName = "sec"
        Me.sec.HeaderText = "Sección"
        Me.sec.MinimumWidth = 6
        Me.sec.Name = "sec"
        Me.sec.Width = 125
        '
        'stock
        '
        Me.stock.DataPropertyName = "stock"
        Me.stock.HeaderText = "Stock"
        Me.stock.MinimumWidth = 6
        Me.stock.Name = "stock"
        Me.stock.Width = 125
        '
        'Listar_materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 581)
        Me.Controls.Add(Me.GridMateriales)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.pnl_seccion)
        Me.Controls.Add(Me.lbl_seccion)
        Me.Controls.Add(Me.cbx_pasillo)
        Me.Controls.Add(Me.lbl_pasillo)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.err_subcat)
        Me.Controls.Add(Me.err_cat)
        Me.Controls.Add(Me.cbx_subcat)
        Me.Controls.Add(Me.lbl_subcat)
        Me.Controls.Add(Me.cbx_categoria)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.tb_num_mat)
        Me.Controls.Add(Me.lbl_num_mat)
        Me.Controls.Add(Me.Lbl_nomPantalla)
        Me.Controls.Add(Me.PB_logo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Barra_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listar_materiales"
        Me.Text = "Listar Materiales"
        Me.Barra_menu.ResumeLayout(False)
        Me.Barra_menu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_seccion.ResumeLayout(False)
        Me.pnl_seccion.PerformLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBDDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra_menu As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TS_inicio As ToolStripButton
    Friend WithEvents Lbl_nomPantalla As Label
    Friend WithEvents PB_logo As PictureBox
    Friend WithEvents tb_num_mat As TextBox
    Friend WithEvents lbl_num_mat As Label
    Friend WithEvents err_subcat As Label
    Friend WithEvents err_cat As Label
    Friend WithEvents cbx_subcat As ComboBox
    Friend WithEvents lbl_subcat As Label
    Friend WithEvents cbx_categoria As ComboBox
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents pnl_seccion As Panel
    Friend WithEvents rb_F As RadioButton
    Friend WithEvents rb_E As RadioButton
    Friend WithEvents rb_D As RadioButton
    Friend WithEvents rb_C As RadioButton
    Friend WithEvents rb_B As RadioButton
    Friend WithEvents rb_A As RadioButton
    Friend WithEvents lbl_seccion As Label
    Friend WithEvents cbx_pasillo As ComboBox
    Friend WithEvents lbl_pasillo As Label
    Friend WithEvents btn_listar As Button
    Friend WithEvents GridMateriales As DataGridView
    Friend WithEvents AlmacenBDDataSetBindingSource As BindingSource
    Friend WithEvents AlmacenBDDataSet As AlmacenBDDataSet
    Friend WithEvents AlmacenBDDataSet1BindingSource As BindingSource
    Friend WithEvents AlmacenBDDataSet1 As AlmacenBDDataSet
    Friend WithEvents num_mat As DataGridViewTextBoxColumn
    Friend WithEvents mat As DataGridViewTextBoxColumn
    Friend WithEvents cat As DataGridViewTextBoxColumn
    Friend WithEvents sub_cat As DataGridViewTextBoxColumn
    Friend WithEvents fe_reg As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents imp_com As DataGridViewTextBoxColumn
    Friend WithEvents imp_ven As DataGridViewTextBoxColumn
    Friend WithEvents pas As DataGridViewTextBoxColumn
    Friend WithEvents sec As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
