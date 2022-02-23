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
        tb_compra.Text = String.Format("{0:C}", CDec(tb_compra.Text))
    End Sub

    Private Sub calcularVenta()
        If Not tb_compra.Text = Nothing And Not cbx_categoria.SelectedIndex = -1 Then
            Dim calculo As Single = tb_compra.Text * importeCompra
            tb_venta.Text = String.Format("{0:C}", calculo)
        End If
    End Sub

    Private Sub obtenerRegistro()
        Dim cadena As String
        Dim comando As SqlCommand
        Dim registro As SqlDataReader

        Try
            cadena = "SELECT IDENT_CURRENT('num_mat') as total"
            comando = New SqlCommand(cadena, conexion)
            registro = comando.ExecuteReader()
            If registro.Read() Then
                If IsDBNull(registro("total")) Then
                    tb_num_mat.Text = 1
                Else
                    tb_num_mat.Text = registro("total") + 1
                End If
            End If
                registro.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class