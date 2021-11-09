Public Class Form1

    Private Sub Texto_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click, TS_texto.Click
        Static contadorTexto As Integer = 0
        Dim MiFormTexto As New Form_TextoRTF

        contadorTexto += 1
        MiFormTexto.MdiParent = Me
        MiFormTexto.Text = "Formulario hijo para Texto RTF -- Nº" & contadorTexto
        MiFormTexto.Show()
    End Sub

    Private Sub Imagen_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click, TS_imagen.Click
        Static contadorImagen As Integer = 0
        Dim MiFormImagen As New Form_Imagen

        contadorImagen += 1
        MiFormImagen.MdiParent = Me
        MiFormImagen.Text = "Formulario hijo para Imagen BMP -- Nº" & contadorImagen
        MiFormImagen.Show()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, TS_About.Click
        Dim MiFormAbout As New Form_About
        MiFormAbout.ShowDialog()
    End Sub

    Private Sub CerrarVentanaActualMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActualToolStripMenuItem.Click
        If MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub

    Private Sub CerrarTodasLasVentanasMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click, TS_cerrar.Click
        If MdiChildren.Length = 0 Then Exit Sub
        For Each Hijo As Form In Me.MdiChildren
            Hijo.Close()
        Next
    End Sub

    Private Sub SalirDeLaAplicaciónMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicaciónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadaMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub VerticalpMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
End Class
