Imports System.Data.OleDb

Public Class Clientes
    Dim MiAdaptador As OleDbDataAdapter
    Dim MiConexionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Neptuno.mdb"
    Dim MiConexion As New OleDbConnection(MiConexionString)
    Dim MiBindingSource As New BindingSource 'Se crea en tiempo de ejecución
    Dim MiTablaDatos As New DataTable 'Fuente de datos para el BindingSource
    Dim MiConstructor As New OleDbCommandBuilder

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MiConexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        'Cargar datos
        Dim MiSQL As String = "Select * from Clientes"
        MiAdaptador = New OleDbDataAdapter(MiSQL, MiConexion)
        Try
            MiAdaptador.Fill(MiTablaDatos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MiConstructor.DataAdapter = MiAdaptador
        MiAdaptador.UpdateCommand = MiConstructor.GetUpdateCommand
        MiAdaptador.InsertCommand = MiConstructor.GetInsertCommand
        MiAdaptador.DeleteCommand = MiConstructor.GetDeleteCommand

        MiBindingSource.DataSource = MiTablaDatos
        MiNavegador.BindingSource = MiBindingSource
        MiGrid.DataSource = MiBindingSource
    End Sub
End Class