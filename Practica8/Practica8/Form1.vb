Public Class Form1
    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MiFormImagen As New Form_Imagen
        Dim MiImagen As Image = Nothing

        MiFormImagen.MdiParent = Me
        AbrirFichero.ShowDialog()

        'MessageBox.Show(AbrirFichero.FileName)
        MiImagen = Image.FromFile(AbrirFichero.FileName)
        MiFormImagen.PctBx_imagen.Image = MiImagen

        MiFormImagen.Show()
    End Sub

    Private Sub TextoRTFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoRTFToolStripMenuItem.Click
        Dim MiFormTexto As New Form_TextoRTF

        MiFormTexto.MdiParent = Me
        AbrirFichero.ShowDialog()

        MiFormTexto.CuadroTexto.LoadFile(AbrirFichero.FileName)

        MiFormTexto.Show()
    End Sub
End Class
