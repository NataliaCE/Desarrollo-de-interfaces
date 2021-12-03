<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categorias))
        Dim NombreCategoríaLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim PrecioUnidadLabel As System.Windows.Forms.Label
        Dim UnidadesEnExistenciaLabel As System.Windows.Forms.Label
        Me.NeptunoDataSet = New Datos_con_ADO.NET.NeptunoDataSet()
        Me.CategoríasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoríasTableAdapter = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.CategoríasTableAdapter()
        Me.TableAdapterManager = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.TableAdapterManager()
        Me.CategoríasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoríasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoríasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.ProductosTableAdapter()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreCategoríaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProductoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnidadTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesEnExistenciaTextBox = New System.Windows.Forms.TextBox()
        NombreCategoríaLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        PrecioUnidadLabel = New System.Windows.Forms.Label()
        UnidadesEnExistenciaLabel = New System.Windows.Forms.Label()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoríasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoríasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoríasBindingNavigator.SuspendLayout()
        CType(Me.CategoríasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NeptunoDataSet
        '
        Me.NeptunoDataSet.DataSetName = "NeptunoDataSet"
        Me.NeptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoríasBindingSource
        '
        Me.CategoríasBindingSource.DataMember = "Categorías"
        Me.CategoríasBindingSource.DataSource = Me.NeptunoDataSet
        '
        'CategoríasTableAdapter
        '
        Me.CategoríasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríasTableAdapter = Me.CategoríasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Compañías_de_envíosTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_de_pedidosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Datos_con_ADO.NET.NeptunoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoríasBindingNavigator
        '
        Me.CategoríasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoríasBindingNavigator.BindingSource = Me.CategoríasBindingSource
        Me.CategoríasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoríasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoríasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoríasBindingNavigatorSaveItem})
        Me.CategoríasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoríasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoríasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoríasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoríasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoríasBindingNavigator.Name = "CategoríasBindingNavigator"
        Me.CategoríasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoríasBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.CategoríasBindingNavigator.TabIndex = 0
        Me.CategoríasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CategoríasBindingNavigatorSaveItem
        '
        Me.CategoríasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoríasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoríasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoríasBindingNavigatorSaveItem.Name = "CategoríasBindingNavigatorSaveItem"
        Me.CategoríasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CategoríasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CategoríasDataGridView
        '
        Me.CategoríasDataGridView.AutoGenerateColumns = False
        Me.CategoríasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoríasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn1})
        Me.CategoríasDataGridView.DataSource = Me.CategoríasBindingSource
        Me.CategoríasDataGridView.Location = New System.Drawing.Point(320, 28)
        Me.CategoríasDataGridView.Name = "CategoríasDataGridView"
        Me.CategoríasDataGridView.Size = New System.Drawing.Size(472, 205)
        Me.CategoríasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCategoría"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCategoría"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreCategoría"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreCategoría"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripción"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Imagen"
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "CategoríasProductos"
        Me.ProductosBindingSource.DataSource = Me.CategoríasBindingSource
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(12, 239)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(780, 216)
        Me.ProductosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreProducto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NombreProducto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PrecioUnidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PrecioUnidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UnidadesEnExistencia"
        Me.DataGridViewTextBoxColumn10.HeaderText = "UnidadesEnExistencia"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CantidadPorUnidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CantidadPorUnidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UnidadesEnPedido"
        Me.DataGridViewTextBoxColumn11.HeaderText = "UnidadesEnPedido"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NivelNuevoPedido"
        Me.DataGridViewTextBoxColumn12.HeaderText = "NivelNuevoPedido"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdProveedor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdProveedor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Suspendido"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Suspendido"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'NombreCategoríaLabel
        '
        NombreCategoríaLabel.AutoSize = True
        NombreCategoríaLabel.Location = New System.Drawing.Point(31, 49)
        NombreCategoríaLabel.Name = "NombreCategoríaLabel"
        NombreCategoríaLabel.Size = New System.Drawing.Size(97, 13)
        NombreCategoríaLabel.TabIndex = 5
        NombreCategoríaLabel.Text = "Nombre Categoría:"
        '
        'NombreCategoríaTextBox
        '
        Me.NombreCategoríaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoríasBindingSource, "NombreCategoría", True))
        Me.NombreCategoríaTextBox.Location = New System.Drawing.Point(134, 46)
        Me.NombreCategoríaTextBox.Name = "NombreCategoríaTextBox"
        Me.NombreCategoríaTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NombreCategoríaTextBox.TabIndex = 6
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.Location = New System.Drawing.Point(35, 88)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(93, 13)
        NombreProductoLabel.TabIndex = 7
        NombreProductoLabel.Text = "Nombre Producto:"
        '
        'NombreProductoTextBox
        '
        Me.NombreProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "NombreProducto", True))
        Me.NombreProductoTextBox.Location = New System.Drawing.Point(134, 85)
        Me.NombreProductoTextBox.Name = "NombreProductoTextBox"
        Me.NombreProductoTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NombreProductoTextBox.TabIndex = 8
        '
        'PrecioUnidadLabel
        '
        PrecioUnidadLabel.AutoSize = True
        PrecioUnidadLabel.Location = New System.Drawing.Point(51, 127)
        PrecioUnidadLabel.Name = "PrecioUnidadLabel"
        PrecioUnidadLabel.Size = New System.Drawing.Size(77, 13)
        PrecioUnidadLabel.TabIndex = 8
        PrecioUnidadLabel.Text = "Precio Unidad:"
        '
        'PrecioUnidadTextBox
        '
        Me.PrecioUnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "PrecioUnidad", True))
        Me.PrecioUnidadTextBox.Location = New System.Drawing.Point(134, 124)
        Me.PrecioUnidadTextBox.Name = "PrecioUnidadTextBox"
        Me.PrecioUnidadTextBox.Size = New System.Drawing.Size(164, 20)
        Me.PrecioUnidadTextBox.TabIndex = 9
        '
        'UnidadesEnExistenciaLabel
        '
        UnidadesEnExistenciaLabel.AutoSize = True
        UnidadesEnExistenciaLabel.Location = New System.Drawing.Point(6, 167)
        UnidadesEnExistenciaLabel.Name = "UnidadesEnExistenciaLabel"
        UnidadesEnExistenciaLabel.Size = New System.Drawing.Size(122, 13)
        UnidadesEnExistenciaLabel.TabIndex = 9
        UnidadesEnExistenciaLabel.Text = "Unidades En Existencia:"
        '
        'UnidadesEnExistenciaTextBox
        '
        Me.UnidadesEnExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "UnidadesEnExistencia", True))
        Me.UnidadesEnExistenciaTextBox.Location = New System.Drawing.Point(134, 164)
        Me.UnidadesEnExistenciaTextBox.Name = "UnidadesEnExistenciaTextBox"
        Me.UnidadesEnExistenciaTextBox.Size = New System.Drawing.Size(164, 20)
        Me.UnidadesEnExistenciaTextBox.TabIndex = 10
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 475)
        Me.Controls.Add(UnidadesEnExistenciaLabel)
        Me.Controls.Add(Me.UnidadesEnExistenciaTextBox)
        Me.Controls.Add(PrecioUnidadLabel)
        Me.Controls.Add(Me.PrecioUnidadTextBox)
        Me.Controls.Add(NombreProductoLabel)
        Me.Controls.Add(Me.NombreProductoTextBox)
        Me.Controls.Add(NombreCategoríaLabel)
        Me.Controls.Add(Me.NombreCategoríaTextBox)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.CategoríasDataGridView)
        Me.Controls.Add(Me.CategoríasBindingNavigator)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoríasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoríasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoríasBindingNavigator.ResumeLayout(False)
        Me.CategoríasBindingNavigator.PerformLayout()
        CType(Me.CategoríasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NeptunoDataSet As NeptunoDataSet
    Friend WithEvents CategoríasBindingSource As BindingSource
    Friend WithEvents CategoríasTableAdapter As NeptunoDataSetTableAdapters.CategoríasTableAdapter
    Friend WithEvents TableAdapterManager As NeptunoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoríasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CategoríasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CategoríasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ProductosTableAdapter As NeptunoDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents NombreCategoríaTextBox As TextBox
    Friend WithEvents NombreProductoTextBox As TextBox
    Friend WithEvents PrecioUnidadTextBox As TextBox
    Friend WithEvents UnidadesEnExistenciaTextBox As TextBox
End Class
