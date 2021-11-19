Public Class Pruebas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrueba1.Click
        Dim MisServicos = New Servicios
        MisServicos.ShowDialog()
    End Sub

    Private Sub btnPrueba2_Click(sender As Object, e As EventArgs) Handles btnPrueba2.Click
        Dim MisColores = New Colores
        MisColores.ShowDialog()
    End Sub

    Private Sub btnPrueba3_Click(sender As Object, e As EventArgs) Handles btnPrueba3.Click
        Dim MisMenus = New MDI_y_menues
        MisMenus.ShowDialog()
    End Sub
End Class
