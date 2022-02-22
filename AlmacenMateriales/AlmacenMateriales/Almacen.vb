Public Class Almacen
    Private Sub Btn_crear_Click(sender As Object, e As EventArgs) Handles Btn_crear.Click
        Dim formulario As New Crear_material
        formulario.Show()
        Me.Close()
    End Sub
End Class
