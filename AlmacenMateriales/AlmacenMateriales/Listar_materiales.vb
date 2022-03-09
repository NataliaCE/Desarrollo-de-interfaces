Imports System.Data.SqlClient

Public Class Listar_materiales

    Dim conexionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DAM2Alu3\source\repos\AlmacenMateriales\AlmacenMateriales\AlmacenBD.mdf;Integrated Security=True"
    Dim dataSet As New DataSet
    Dim adaptador As New SqlDataAdapter
    'No bindingSource

    Private Sub cargarDatos(consulta As String, tabla As String, source As BindingSource)
        adaptador.SelectCommand = New SqlCommand(consulta)
        adaptador.SelectCommand.Connection = New SqlConnection(conexionString)

        Try
            adaptador.Fill(AlmacenBDDataSet, tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cargarGrid()

    End Sub

    Private Sub TS_inicio_Click(sender As Object, e As EventArgs) Handles TS_inicio.Click
        Dim formulario As New Almacen
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub CrearMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearMaterialToolStripMenuItem.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub Listar_materiales_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cargarDatos("select * from Materiales", "Materiales", bindingSource)
            cargarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class