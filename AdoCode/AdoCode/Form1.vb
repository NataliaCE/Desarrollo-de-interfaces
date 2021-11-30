Public Class Form1
    Dim MiAdaptador As OleDbDataAdapter
    Dim MiConexionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\Neptuno.mdb"
    Dim MiConexion As New OleDbConnection(MiConexionString)
    Dim MiTablaDatos As New DataTable 'Source del BindingSource
    Dim MiBindingSource As New BindingSource 'Crear en tiempo de ejecución
    Dim MiConstructor As New OleDbCommandBuilder 'Constructor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MiConexion.Open()
            MessageBox.Show("Conexion exitosa.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        'Cargar datos
        Dim MiSQL As String = "Select * from Productos"
        MiAdaptador = New OleDbDataAdapter(MiSQL, MiConexion)
        Try
            MiAdaptador.Fill(MiTablaDatos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MiConstructor.DataAdapter = MiAdaptador
        MiAdaptador.UpdateCommand = MiConstructor.GetUpdateCommand
        MiAdaptador.DeleteCommand = MiConstructor.GetDeleteCommand
        MiAdaptador.InsertCommand = MiConstructor.GetInsertCommand

        MiBindingSource.DataSource = MiTablaDatos
        MiNavigator.BindingSource = MiBindingSource
        MiRejilla.DataSource = MiBindingSource
        enclaceDBControl()
    End Sub

    Sub enclaceDBControl()
        TxtProducto.DataBindings.Add(New Binding("Text", MiBindingSource, "NombreProducto"))
    End Sub

    Sub actualizar()
        Dim Nreg As Integer
        Try
            Nreg = MiAdaptador.Update(MiTablaDatos)
            MessageBox.Show("Nº de registros actualizados: " & Nreg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        actualizar()
    End Sub
End Class
