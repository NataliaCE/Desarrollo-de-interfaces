Public Class MDI_y_menues
    Dim FormTexto As New Form
    Dim FormImagenes As New Form
    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MessageBox.Show("Ayuda sin instalar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub ImagenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenesToolStripMenuItem.Click
        Dim menu As ToolStripMenuItem = ImagenesToolStripMenuItem

        Dim Caja As New PictureBox

        menu.Enabled = False
        FormImagenes.MdiParent = Me
        FormImagenes.Text = "Imagen"
        FormImagenes.Controls.Add(Caja)
        Caja.Dock = DockStyle.Fill

        FormImagenes.Show()

    End Sub

    Private Sub TextosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextosToolStripMenuItem.Click
        Dim menu As ToolStripMenuItem = TextosToolStripMenuItem
        Dim Caja As New RichTextBox

        menu.Enabled = False
        FormTexto.MdiParent = Me
        FormTexto.Text = "Texto"
        FormTexto.Controls.Add(Caja)
        Caja.Dock = DockStyle.Fill

        FormTexto.Show()
    End Sub

    Private Sub CerrarPizarraActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarPizarraActivaToolStripMenuItem.Click
        If MdiChildren.Length = 0 Then Exit Sub
        If MdiChildren.Contains(FormTexto) Then TextosToolStripMenuItem.Enabled = True
        If MdiChildren.Contains(FormImagenes) Then ImagenesToolStripMenuItem.Enabled = True
        ActiveMdiChild.Close()
    End Sub

    Private Sub CerrarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasToolStripMenuItem.Click
        If MdiChildren.Length = 0 Then Exit Sub
        For Each Hijo As Form In Me.MdiChildren
            Hijo.Close()
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MDI_y_menues_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tiempo As Timer
    End Sub
End Class