Imports System.Data.SqlClient
Imports System.IO

Public Class Borrar_material
    Dim registro As Integer
    Dim material As String
    Dim directorio As String = Directory.GetCurrentDirectory()
    Dim dir As DirectoryInfo = Directory.GetParent(directorio)
    Dim carpeta As DirectoryInfo = Directory.GetParent(dir.ToString())
    Dim conexionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & carpeta.ToString() & "\AlmacenBD.mdf;Integrated Security=True"
    Dim conexion As New SqlConnection(conexionString)

    Private Sub BorrarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMaterialToolStripMenuItem.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        Dim formulario As New Modificar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub TS_inicio_Click(sender As Object, e As EventArgs) Handles TS_inicio.Click
        Dim formulario As New Almacen
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        registro = CInt(tb_num_mat.Text)
        If buscar(registro) Then
            Dim cadena As String = "¿Está seguro de que desea eliminar el Material?" & vbCrLf & "Número de material: " & registro.ToString & vbCrLf & "Material: " & material
            Dim respuesta = MessageBox.Show(cadena, "Aviso", MessageBoxButtons.YesNo)
            If respuesta = vbYes Then
                If Borrar(registro) Then
                    MessageBox.Show("Se ha borrado el material.")
                Else
                    MessageBox.Show("No se ha podido borrar el material")
                End If
            Else

            End If
        Else
            MessageBox.Show("Este registro no existe.")
        End If
        tb_num_mat.Text = ""
    End Sub

    Function buscar(reg As Integer) As Boolean
        Dim cadena As String
        Dim comando As SqlCommand
        Dim registroSQL As SqlDataReader

        Try
            cadena = "SELECT mat FROM Materiales WHERE num_mat = " & registro
            conexion.Open()
            comando = New SqlCommand(cadena, conexion)
            registroSQL = comando.ExecuteReader()
            If registroSQL.Read Then
                material = registroSQL("mat")
                conexion.Close()
                Return True
            End If
            conexion.Close()
            Return False
        Catch ex As Exception
            MessageBox.Show("Error al buscar " + ex.Message)
            conexion.Close()
            Return False
        End Try
    End Function

    Function Borrar(registro As String) As Boolean
        Dim cadena As String
        Dim comando As SqlCommand

        Dim cadena2 As String
        Dim comando2 As SqlCommand

        Try
            cadena = "DELETE FROM Gest_Materiales WHERE num_mat = @registro"
            conexion.Open()
            comando = New SqlCommand(cadena, conexion)
            comando.Parameters.AddWithValue("@registro", registro)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexion.Close()
            Return False
        End Try

        Try
            cadena2 = "DELETE FROM Materiales WHERE num_mat = @registro"
            conexion.Open()
            comando2 = New SqlCommand(cadena2, conexion)
            comando2.Parameters.AddWithValue("@registro", registro)
            comando2.ExecuteNonQuery()
            conexion.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexion.Close()
            Return False
        End Try
    End Function
End Class