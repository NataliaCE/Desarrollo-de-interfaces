<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim NombreContactoLabel As System.Windows.Forms.Label
        Dim IdPedidoLabel As System.Windows.Forms.Label
        Dim FechaPedidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.NeptunoDataSet = New Datos_con_ADO.NET.NeptunoDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.TableAdapterManager()
        Me.PedidosTableAdapter = New Datos_con_ADO.NET.NeptunoDataSetTableAdapters.PedidosTableAdapter()
        Me.MiGridClientes = New System.Windows.Forms.DataGridView()
        Me.NombreCompañíaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegiónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CódPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaísDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.DirecciónTextBox = New System.Windows.Forms.TextBox()
        Me.TeléfonoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreContactoTextBox = New System.Windows.Forms.TextBox()
        Me.IdPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaPedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        IdClienteLabel = New System.Windows.Forms.Label()
        DirecciónLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        NombreContactoLabel = New System.Windows.Forms.Label()
        IdPedidoLabel = New System.Windows.Forms.Label()
        FechaPedidoLabel = New System.Windows.Forms.Label()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(43, 41)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(54, 13)
        IdClienteLabel.TabIndex = 3
        IdClienteLabel.Text = "Id Cliente:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.Location = New System.Drawing.Point(42, 124)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(55, 13)
        DirecciónLabel.TabIndex = 9
        DirecciónLabel.Text = "Dirección:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Location = New System.Drawing.Point(45, 163)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(52, 13)
        TeléfonoLabel.TabIndex = 11
        TeléfonoLabel.Text = "Teléfono:"
        '
        'NombreContactoLabel
        '
        NombreContactoLabel.AutoSize = True
        NombreContactoLabel.Location = New System.Drawing.Point(4, 81)
        NombreContactoLabel.Name = "NombreContactoLabel"
        NombreContactoLabel.Size = New System.Drawing.Size(93, 13)
        NombreContactoLabel.TabIndex = 12
        NombreContactoLabel.Text = "Nombre Contacto:"
        '
        'IdPedidoLabel
        '
        IdPedidoLabel.AutoSize = True
        IdPedidoLabel.Location = New System.Drawing.Point(42, 279)
        IdPedidoLabel.Name = "IdPedidoLabel"
        IdPedidoLabel.Size = New System.Drawing.Size(55, 13)
        IdPedidoLabel.TabIndex = 13
        IdPedidoLabel.Text = "Id Pedido:"
        '
        'FechaPedidoLabel
        '
        FechaPedidoLabel.AutoSize = True
        FechaPedidoLabel.Location = New System.Drawing.Point(21, 318)
        FechaPedidoLabel.Name = "FechaPedidoLabel"
        FechaPedidoLabel.Size = New System.Drawing.Size(76, 13)
        FechaPedidoLabel.TabIndex = 14
        FechaPedidoLabel.Text = "Fecha Pedido:"
        '
        'NeptunoDataSet
        '
        Me.NeptunoDataSet.DataSetName = "NeptunoDataSet"
        Me.NeptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.NeptunoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.Compañías_de_envíosTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_de_pedidosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Datos_con_ADO.NET.NeptunoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'MiGridClientes
        '
        Me.MiGridClientes.AutoGenerateColumns = False
        Me.MiGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiGridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreCompañíaDataGridViewTextBoxColumn, Me.NombreContactoDataGridViewTextBoxColumn, Me.CargoContactoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.RegiónDataGridViewTextBoxColumn, Me.CódPostalDataGridViewTextBoxColumn, Me.PaísDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn})
        Me.MiGridClientes.DataSource = Me.ClientesBindingSource
        Me.MiGridClientes.Location = New System.Drawing.Point(219, 29)
        Me.MiGridClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.MiGridClientes.Name = "MiGridClientes"
        Me.MiGridClientes.RowHeadersWidth = 51
        Me.MiGridClientes.RowTemplate.Height = 24
        Me.MiGridClientes.Size = New System.Drawing.Size(525, 212)
        Me.MiGridClientes.TabIndex = 0
        '
        'NombreCompañíaDataGridViewTextBoxColumn
        '
        Me.NombreCompañíaDataGridViewTextBoxColumn.DataPropertyName = "NombreCompañía"
        Me.NombreCompañíaDataGridViewTextBoxColumn.HeaderText = "NombreCompañía"
        Me.NombreCompañíaDataGridViewTextBoxColumn.Name = "NombreCompañíaDataGridViewTextBoxColumn"
        '
        'NombreContactoDataGridViewTextBoxColumn
        '
        Me.NombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto"
        Me.NombreContactoDataGridViewTextBoxColumn.HeaderText = "NombreContacto"
        Me.NombreContactoDataGridViewTextBoxColumn.Name = "NombreContactoDataGridViewTextBoxColumn"
        '
        'CargoContactoDataGridViewTextBoxColumn
        '
        Me.CargoContactoDataGridViewTextBoxColumn.DataPropertyName = "CargoContacto"
        Me.CargoContactoDataGridViewTextBoxColumn.HeaderText = "CargoContacto"
        Me.CargoContactoDataGridViewTextBoxColumn.Name = "CargoContactoDataGridViewTextBoxColumn"
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        '
        'RegiónDataGridViewTextBoxColumn
        '
        Me.RegiónDataGridViewTextBoxColumn.DataPropertyName = "Región"
        Me.RegiónDataGridViewTextBoxColumn.HeaderText = "Región"
        Me.RegiónDataGridViewTextBoxColumn.Name = "RegiónDataGridViewTextBoxColumn"
        '
        'CódPostalDataGridViewTextBoxColumn
        '
        Me.CódPostalDataGridViewTextBoxColumn.DataPropertyName = "CódPostal"
        Me.CódPostalDataGridViewTextBoxColumn.HeaderText = "CódPostal"
        Me.CódPostalDataGridViewTextBoxColumn.Name = "CódPostalDataGridViewTextBoxColumn"
        '
        'PaísDataGridViewTextBoxColumn
        '
        Me.PaísDataGridViewTextBoxColumn.DataPropertyName = "País"
        Me.PaísDataGridViewTextBoxColumn.HeaderText = "País"
        Me.PaísDataGridViewTextBoxColumn.Name = "PaísDataGridViewTextBoxColumn"
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "ClientesPedidos"
        Me.PedidosBindingSource.DataSource = Me.ClientesBindingSource
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPedido, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PedidosDataGridView.DataSource = Me.PedidosBindingSource
        Me.PedidosDataGridView.Location = New System.Drawing.Point(301, 246)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.Size = New System.Drawing.Size(442, 193)
        Me.PedidosDataGridView.TabIndex = 2
        '
        'IdPedido
        '
        Me.IdPedido.DataPropertyName = "IdPedido"
        Me.IdPedido.HeaderText = "IdPedido"
        Me.IdPedido.Name = "IdPedido"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaPedido"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaPedido"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaEntrega"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaEntrega"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaEnvío"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FechaEnvío"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FormaEnvío"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FormaEnvío"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Destinatario"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Destinatario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DirecciónDestinatario"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DirecciónDestinatario"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CiudadDestinatario"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CiudadDestinatario"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "RegiónDestinatario"
        Me.DataGridViewTextBoxColumn12.HeaderText = "RegiónDestinatario"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CódPostalDestinatario"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CódPostalDestinatario"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PaísDestinatario"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PaísDestinatario"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(103, 38)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdClienteTextBox.TabIndex = 4
        '
        'DirecciónTextBox
        '
        Me.DirecciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Dirección", True))
        Me.DirecciónTextBox.Location = New System.Drawing.Point(103, 121)
        Me.DirecciónTextBox.Name = "DirecciónTextBox"
        Me.DirecciónTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DirecciónTextBox.TabIndex = 10
        '
        'TeléfonoTextBox
        '
        Me.TeléfonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Teléfono", True))
        Me.TeléfonoTextBox.Location = New System.Drawing.Point(103, 160)
        Me.TeléfonoTextBox.Name = "TeléfonoTextBox"
        Me.TeléfonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeléfonoTextBox.TabIndex = 12
        '
        'NombreContactoTextBox
        '
        Me.NombreContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NombreContacto", True))
        Me.NombreContactoTextBox.Location = New System.Drawing.Point(103, 78)
        Me.NombreContactoTextBox.Name = "NombreContactoTextBox"
        Me.NombreContactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreContactoTextBox.TabIndex = 13
        '
        'IdPedidoTextBox
        '
        Me.IdPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdPedido", True))
        Me.IdPedidoTextBox.Location = New System.Drawing.Point(103, 276)
        Me.IdPedidoTextBox.Name = "IdPedidoTextBox"
        Me.IdPedidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdPedidoTextBox.TabIndex = 14
        '
        'FechaPedidoDateTimePicker
        '
        Me.FechaPedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "FechaPedido", True))
        Me.FechaPedidoDateTimePicker.Location = New System.Drawing.Point(103, 312)
        Me.FechaPedidoDateTimePicker.Name = "FechaPedidoDateTimePicker"
        Me.FechaPedidoDateTimePicker.Size = New System.Drawing.Size(192, 20)
        Me.FechaPedidoDateTimePicker.TabIndex = 15
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ClientesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(755, 25)
        Me.BindingNavigator1.TabIndex = 16
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 448)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(FechaPedidoLabel)
        Me.Controls.Add(Me.FechaPedidoDateTimePicker)
        Me.Controls.Add(IdPedidoLabel)
        Me.Controls.Add(Me.IdPedidoTextBox)
        Me.Controls.Add(NombreContactoLabel)
        Me.Controls.Add(Me.NombreContactoTextBox)
        Me.Controls.Add(TeléfonoLabel)
        Me.Controls.Add(Me.TeléfonoTextBox)
        Me.Controls.Add(DirecciónLabel)
        Me.Controls.Add(Me.DirecciónTextBox)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteTextBox)
        Me.Controls.Add(Me.PedidosDataGridView)
        Me.Controls.Add(Me.MiGridClientes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeptunoDataSet As NeptunoDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As NeptunoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As NeptunoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidosTableAdapter As NeptunoDataSetTableAdapters.PedidosTableAdapter
    Friend WithEvents MiGridClientes As DataGridView
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosDataGridView As DataGridView
    Friend WithEvents NombreCompañíaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreContactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargoContactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegiónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CódPostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaísDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPedido As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents DirecciónTextBox As TextBox
    Friend WithEvents TeléfonoTextBox As TextBox
    Friend WithEvents NombreContactoTextBox As TextBox
    Friend WithEvents IdPedidoTextBox As TextBox
    Friend WithEvents FechaPedidoDateTimePicker As DateTimePicker
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
End Class
