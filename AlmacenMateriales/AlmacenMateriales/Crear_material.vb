Imports System.Data.SqlClient
Imports System.IO

Public Class Crear_material
    Dim directorio As String = Directory.GetCurrentDirectory()
    Dim dir As DirectoryInfo = Directory.GetParent(directorio)
    Dim carpeta As DirectoryInfo = Directory.GetParent(dir.ToString())
    Dim conexionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & carpeta.ToString() & "\AlmacenBD.mdf;Integrated Security=True"
    Dim conexion As New SqlConnection(conexionString)
    Dim registro As Integer
    Dim importeCompra As Single = 0

    Private Sub Crear_material_Load(sender As Object, e As EventArgs) Handles Me.Load

        obtenerRegistro()
    End Sub

    Private Sub TS_guardar_Click(sender As Object, e As EventArgs) Handles TS_guardar.Click
        If comprobarDatos() Then
            If enviarDatos() Then
                MessageBox.Show("Datos ingresados correctamente", "Información")
            End If
        End If
    End Sub

    Private Sub cbx_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_categoria.SelectedIndexChanged
        Dim combo As New ComboBox
        combo = sender

        cbx_subcat.SelectedIndex = -1
        cbx_subcat.Items.Clear()

        Select Case combo.SelectedItem.ToString()
            Case "Hardware"
                cbx_subcat.Items.Add("Equipo")
                cbx_subcat.Items.Add("Periféricos")
                importeCompra = 1.8
            Case "Software"
                cbx_subcat.Items.Add("Antivirus")
                cbx_subcat.Items.Add("Servicio")
                importeCompra = 1.7

        End Select
        calcularVenta()
    End Sub

    Private Sub tb_compra_TextChanged(sender As Object, e As EventArgs) Handles tb_compra.TextChanged
        calcularVenta()
    End Sub

    Private Sub tb_compra_LostFocus(sender As Object, e As EventArgs) Handles tb_compra.LostFocus
        If Not tb_compra.Text.Trim() = "€" And Not tb_compra.Text.Trim() = "" Then
            tb_compra.Text = String.Format("{0:C}", CDec(tb_compra.Text))
        End If
    End Sub

    Private Sub calcularVenta()
        If Not tb_compra.Text = Nothing And Not tb_compra.Text.Trim = "€" And Not tb_compra.Text.Trim = "," And Not cbx_categoria.SelectedIndex = -1 Then
            Dim calculo As Single = tb_compra.Text * importeCompra
            tb_venta.Text = String.Format("{0:C}", calculo)
        End If
    End Sub

    Private Sub obtenerRegistro()
        Dim cadena As String
        Dim comando As SqlCommand
        Dim registroSQL As SqlDataReader

        Try
            conexion.Open()
            cadena = "SELECT IDENT_CURRENT('Materiales') as total"
            comando = New SqlCommand(cadena, conexion)
            registroSQL = comando.ExecuteReader()
            If registroSQL.Read() Then
                If IsDBNull(registroSQL("total")) Then
                    tb_num_mat.Text = 1
                Else
                    tb_num_mat.Text = registroSQL("total") + 1
                End If
                registro = tb_num_mat.Text
            End If
            registroSQL.Close()
            conexion.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub TS_inicio_Click(sender As Object, e As EventArgs) Handles TS_inicio.Click
        Dim formulario As New Almacen
        formulario.Show()
        Me.Close()
    End Sub

    Function comprobarDatos() As Boolean
        Dim contador As Integer = 0

        If tb_material.Text.Trim = "" Then
            err_material.Text = "* Campo obligatorio"
            contador += 1
        Else
            err_material.Text = ""
        End If
        If cbx_categoria.SelectedIndex = -1 Then
            err_cat.Text = "* Campo obligatorio"
            contador += 1
        Else
            err_cat.Text = ""
        End If
        If cbx_subcat.SelectedIndex = -1 Then
            err_subcat.Text = "* Campo obligatorio"
            contador += 1
        Else
            err_subcat.Text = ""
        End If

        If contador = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_compra.KeyPress
        Dim caja As New TextBox
        caja = sender

        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "," And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "," And caja.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

    Function enviarDatos() As Boolean
        Dim cadena As String
        Dim comando As SqlCommand
        Dim cadena2 As String
        Dim comando2 As SqlCommand
        Dim material As String = tb_material.Text
        Dim categoria As String = cbx_categoria.SelectedItem.ToString
        Dim subcat As String = cbx_subcat.SelectedItem.ToString
        Dim fecha As Date = dtp_fecha.Value.ToString("dd/MM/yyyy HH:mm:ss")
        Dim descripcion As String = tb_desc.Text
        Dim compra As Single
        If Not compra = 0 Then
            compra = tb_compra.Text
        End If
        Dim venta As Single
        If Not venta = 0 Then
            venta = tb_venta.Text
        End If
        Dim pasillo As Integer
        If Not cbx_pasillo.SelectedIndex = -1 Then
            pasillo = cbx_pasillo.SelectedItem.ToString
        End If
        Dim seccion As Char
        Dim stock As Integer
        If Not stock = 0 Then
            stock = tb_stock.Text
        End If

        For Each check As RadioButton In pnl_seccion.Controls
            If check.Checked Then
                seccion = check.Text
            End If
        Next

        Try
            conexion.Open()
            cadena = "INSERT INTO Materiales VALUES (@material, @categoria, @subcat, @fecha, @descripcion, @compra, @venta)"
            comando = New SqlCommand(cadena, conexion)
            comando.Parameters.AddWithValue("@material", material)
            comando.Parameters.AddWithValue("@categoria", categoria)
            comando.Parameters.AddWithValue("@subcat", subcat)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@descripcion", descripcion)
            comando.Parameters.AddWithValue("@compra", compra)
            comando.Parameters.AddWithValue("@venta", venta)

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Materiales" + ex.Message)
            conexion.Close()
            Return False
        End Try

        Try
            cadena2 = "INSERT INTO Gest_Materiales VALUES (@registro, @pasillo, @seccion, @stock)"
            comando2 = New SqlCommand(cadena2, conexion)
            comando2.Parameters.AddWithValue("@registro", CInt(tb_num_mat.Text))
            comando2.Parameters.AddWithValue("@pasillo", pasillo)
            comando2.Parameters.AddWithValue("@seccion", seccion)
            comando2.Parameters.AddWithValue("@stock", stock)

            comando2.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Gestor" + ex.Message)
            conexion.Close()
            Return False
        End Try

        Return True

    End Function

    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub BorrarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMaterialToolStripMenuItem.Click
        Dim formulario As New Borrar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        Dim formulario As New Modificar_material
        formulario.Show()
        Me.Close()
    End Sub
End Class