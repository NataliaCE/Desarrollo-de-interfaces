Public Class Almacen
    Private Sub Btn_crear_Click(sender As Object, e As EventArgs) Handles Btn_crear.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub TS_anadir_Click(sender As Object, e As EventArgs) Handles TS_anadir.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub CrearMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearMaterialToolStripMenuItem.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub TS_listar_Click(sender As Object, e As EventArgs) Handles TS_listar.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_listar_Click(sender As Object, e As EventArgs) Handles Btn_listar.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        Dim formulario As New Listar_materiales
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_modificar_Click(sender As Object, e As EventArgs) Handles Btn_modificar.Click
        Dim formulario As New Modificar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub TS_editar_Click(sender As Object, e As EventArgs) Handles TS_editar.Click
        Dim formulario As New Modificar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        Dim formulario As New Modificar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_eliminar_Click(sender As Object, e As EventArgs) Handles Btn_eliminar.Click
        Dim formulario As New Borrar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub TS_borrar_Click(sender As Object, e As EventArgs) Handles TS_borrar.Click
        Dim formulario As New Borrar_material
        formulario.Show()
        Me.Close()
    End Sub

    Private Sub BorrarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMaterialToolStripMenuItem.Click
        Dim formulario As New Borrar_material
        formulario.Show()
        Me.Close()
    End Sub
End Class
