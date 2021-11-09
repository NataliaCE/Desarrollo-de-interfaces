Public Class Form_Imagen
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        PcBx_imagen.Image = Nothing
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        PcBx_imagen.Image = Clipboard.GetImage()
    End Sub
End Class