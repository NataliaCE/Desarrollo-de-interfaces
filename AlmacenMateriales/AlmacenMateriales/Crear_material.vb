Imports System.Data.SqlClient

Public Class Crear_material

    Dim conexionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DAM2Alu3\source\repos\AlmacenMateriales\AlmacenMateriales\AlmacenBD.mdf;Integrated Security=True"
    Dim conexion As New SqlConnection(conexionString)
    Dim listaHardware As New Collection
    Dim listaSoftware As New Collection
    Dim importeCompra As Single = 0

    Private Sub Crear_material_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        obtenerRegistro()
    End Sub

    Private Sub TS_guardar_Click(sender As Object, e As EventArgs) Handles TS_guardar.Click
        If comprobarDatos() Then
            EnviarDatos()
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
        'And tb_compra.Text.Trim() = ","
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
        Dim registro As SqlDataReader

        Try
            cadena = "SELECT IDENT_CURRENT('Material') as total"
            comando = New SqlCommand(cadena, conexion)
            registro = comando.ExecuteReader()
            If registro.Read() Then
                'If IsDBNull(registro("total")) Then
                '    tb_num_mat.Text = 1
                'Else
                '    tb_num_mat.Text = registro("total") + 1
                'End If
                tb_num_mat.Text = registro("total") + 1
            End If
                registro.Close()

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

    Private Sub enviarDatos()
        Dim cadena As String
        Dim comando As SqlCommand
        Dim material As String = tb_material.Text
        Dim categoria As String = cbx_categoria.SelectedItem.ToString
        Dim subcat As String = cbx_subcat.SelectedItem.ToString
        Dim fecha As Date = dtp_fecha.Value.ToString("dd/MM/yyyy HH:mm:ss")
        Dim descripcion As String = tb_desc.Text
        Dim compra As Single = tb_compra.Text
        Dim venta As Single = tb_venta.Text

        Try
            cadena = "INSERT INTO Materiales VALUES (@material, @categoria, @subcat, @fecha, @descripcion, @compra, @venta)"
            comando = New SqlCommand(cadena, conexion)
            comando.Parameters.AddWithValue("material", material)
            comando.Parameters.AddWithValue("categoria", categoria)
            comando.Parameters.AddWithValue("subcat", subcat)
            comando.Parameters.AddWithValue("fecha", fecha)
            comando.Parameters.AddWithValue("descripcion", descripcion)
            comando.Parameters.AddWithValue("compra", compra)
            comando.Parameters.AddWithValue("venta", venta)

            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class