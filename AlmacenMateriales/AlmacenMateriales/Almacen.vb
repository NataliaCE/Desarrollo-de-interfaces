﻿Public Class Almacen
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
End Class
