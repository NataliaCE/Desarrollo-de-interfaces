Imports System.Data.SqlClient
Imports System.IO

Public Class Listar_materiales

    Dim directorio As String = Directory.GetCurrentDirectory()
    Dim dir As DirectoryInfo = Directory.GetParent(directorio)
    Dim carpeta As DirectoryInfo = Directory.GetParent(dir.ToString())
    Dim conexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & carpeta.ToString() & "\AlmacenBD.mdf;Integrated Security=True"

    Dim adaptador As New SqlDataAdapter
    Dim dataSet As New DataSet
    Dim consulta As String = "SELECT Materiales.num_mat, mat, cat, sub_cat, fe_reg, [desc], imp_com, imp_ven, pas, sec, stock FROM Materiales JOIN Gest_Materiales ON Materiales.num_mat = Gest_Materiales.num_mat"
    Dim filtro As Integer = 0


    Private Sub cargarDatos(cadena As String, tabla As String)

        Try
            adaptador = New SqlDataAdapter(consulta, conexionString)
            dataSet.Tables.Add(tabla)
            adaptador.Fill(dataSet.Tables(tabla))
            GridMateriales.DataSource = dataSet.Tables(tabla)

        Catch ex As Exception
            MessageBox.Show(ex.Message & cadena)
        End Try


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
            cargarDatos(consulta, "Materiales")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Filtros()
        consulta = "SELECT Materiales.num_mat, mat, cat, sub_cat, fe_reg, [desc], imp_com, imp_ven, pas, sec, stock FROM Materiales JOIN Gest_Materiales ON Materiales.num_mat = Gest_Materiales.num_mat"
        Dim numero As Single
        Dim categoria As String
        Dim subcat As String
        Dim fecha As Date = dtp_fecha.Value.ToString("dd/MM/yyyy")
        Dim pasillo As Integer
        Dim seccion As String

        For Each check As RadioButton In pnl_seccion.Controls
            If check.Checked Then
                seccion = check.Text
            End If
        Next

        Dim contador = 0

        If Not tb_num_mat.Text.Trim = "" Then
            numero = tb_num_mat.Text.Trim
            consulta = consulta & " WHERE Materiales.num_mat = " & numero
            contador += 1
        End If

        If Not cbx_categoria.SelectedIndex = -1 Then
            categoria = cbx_categoria.SelectedItem.ToString
            If contador = 0 Then
                consulta = consulta & " WHERE cat = '" & categoria & "'"
            Else
                consulta = consulta & " AND cat = '" & categoria & "'"
            End If
            contador += 1
        End If

        If Not cbx_subcat.SelectedIndex = -1 Then
            subcat = cbx_subcat.SelectedItem.ToString
            If contador = 0 Then
                consulta = consulta & " WHERE sub_cat = '" & subcat & "'"
            Else
                consulta = consulta & " AND sub_cat = '" & subcat & "'"
            End If
            contador += 1
        End If

        'If contador = 0 Then
        '    consulta = consulta & " WHERE fe_reg = '" & fecha & "'"
        'Else
        '    consulta = consulta & " AND fe_reg = '" & fecha & "'"
        'End If
        'contador += 1

        If Not cbx_pasillo.SelectedIndex = -1 Then
            pasillo = cbx_pasillo.SelectedItem.ToString
            If contador = 0 Then
                consulta = consulta & " WHERE pas = " & pasillo
            Else
                consulta = consulta & " AND pas = " & pasillo
            End If
            contador += 1
        End If

        If Not seccion = "" Then
            If contador = 0 Then
                consulta = consulta & " WHERE sec = '" & seccion & "'"
            Else
                consulta = consulta & " AND sec = '" & seccion & "'"
            End If
            contador += 1
        End If

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        filtro += 1
        Filtros()
        cargarDatos(consulta, filtro)
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
            Case "Software"
                cbx_subcat.Items.Add("Antivirus")
                cbx_subcat.Items.Add("Servicio")

        End Select
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