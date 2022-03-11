Imports System.Data.SqlClient
Imports System.IO

Public Class Modificar_material
    Dim directorio As String = Directory.GetCurrentDirectory()
    Dim dir As DirectoryInfo = Directory.GetParent(directorio)
    Dim carpeta As DirectoryInfo = Directory.GetParent(dir.ToString())
    Dim conexionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & carpeta.ToString() & "\AlmacenBD.mdf;Integrated Security=True"
    Dim conexion As New SqlConnection(conexionString)
    Dim importeCompra As Single = 0

    Private Sub TS_guardar_Click(sender As Object, e As EventArgs) Handles TS_guardar.Click
        If enviarDatos() Then
            MessageBox.Show("Datos ingresados correctamente", "Información")
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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim registro As Integer = CInt(tb_buscar.Text)
        Dim cadena As String
        Dim comando As SqlCommand
        Dim registroSQL As SqlDataReader

        cadena = "SELECT Materiales.num_mat, mat, cat, sub_cat, fe_reg, imp_com, imp_ven, pas, sec, stock FROM Materiales JOIN Gest_Materiales ON Materiales.num_mat = Gest_Materiales.num_mat WHERE Materiales.num_mat = " & registro
        Try
            conexion.Open()
            comando = New SqlCommand(cadena, conexion)
            registroSQL = comando.ExecuteReader()
            tb_buscar.Text = ""

            If registroSQL.Read() Then
                tb_num_mat.Text = registro
                tb_material.Text = registroSQL("mat")
                cbx_categoria.SelectedItem = registroSQL("cat")
                cbx_subcat.SelectedItem = registroSQL("sub_cat")
                dtp_fecha.Value = registroSQL("fe_reg")
                'tb_desc.Text = registroSQL("desc")
                tb_compra.Text = registroSQL("imp_com")
                tb_venta.Text = registroSQL("imp_ven")
                cbx_pasillo.SelectedItem = registroSQL("pas").ToString
                tb_stock.Text = registroSQL("stock")
                For Each radio As RadioButton In pnl_seccion.Controls
                    If radio.Text = registroSQL("sec").ToString() Then
                        radio.Checked = True
                    End If
                Next
            Else
                MessageBox.Show("No existe un artículo con el código ingresado")

            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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
        Dim compra As Single = tb_compra.Text
        Dim venta As Single = tb_venta.Text
        Dim pasillo As Integer = cbx_pasillo.SelectedItem.ToString
        Dim seccion As Char
        Dim stock As Integer = tb_stock.Text

        For Each check As RadioButton In pnl_seccion.Controls
            If check.Checked Then
                seccion = check.Text
            End If
        Next

        Try
            cadena = "UPDATE Materiales SET mat = @material, cat = @categoria, sub_cat = @subcat, fe_reg = @fecha, imp_com = @compra, imp_ven = @venta WHERE num_mat = @registro"
            conexion.Open()
            comando = New SqlCommand(cadena, conexion)
            comando.Parameters.AddWithValue("@material", material)
            comando.Parameters.AddWithValue("@categoria", categoria)
            comando.Parameters.AddWithValue("@subcat", subcat)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@descripcion", descripcion)
            comando.Parameters.AddWithValue("@compra", compra)
            comando.Parameters.AddWithValue("@venta", venta)
            comando.Parameters.AddWithValue("@registro", CInt(tb_num_mat.Text))

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Materiales" + ex.Message)
            Return False
        End Try

        Try
            cadena2 = "UPDATE Gest_Materiales SET pas = @pasillo, sec = @seccion, stock = @stock WHERE num_mat = @registro"
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

    Private Sub calcularVenta()
        If Not tb_compra.Text = Nothing And Not tb_compra.Text.Trim = "€" And Not tb_compra.Text.Trim = "," And Not cbx_categoria.SelectedIndex = -1 Then
            Dim calculo As Single = tb_compra.Text * importeCompra
            tb_venta.Text = String.Format("{0:C}", calculo)
        End If
    End Sub

    Private Sub TS_inicio_Click(sender As Object, e As EventArgs) Handles TS_inicio.Click
        Dim formulario As New Almacen
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub
End Class