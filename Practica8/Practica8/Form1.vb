Public Class Form1

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click, TS_texto.Click
        Dim MiFormTexto As New Form_TextoRTF
        MiFormTexto.MdiParent = Me
        MiFormTexto.Show()

    End Sub
End Class
