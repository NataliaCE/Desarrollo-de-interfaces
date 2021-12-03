Public Class Form1
    Private Sub ClientesYSusPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYSusPedidosToolStripMenuItem.Click
        Dim MiFormClientes As New Clientes
        MiFormClientes.MdiParent = Me
        MiFormClientes.Text = "Clientes y sus pedidos"
        MiFormClientes.Show()
    End Sub

    Private Sub CategoriasYSusProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasYSusProductosToolStripMenuItem.Click
        Dim MiFormCategorias As New Categorias
        MiFormCategorias.MdiParent = Me
        MiFormCategorias.Text = "Categorías y sus productos"
        MiFormCategorias.Show()
    End Sub

    Private Sub ProveedoresYSusProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresYSusProductosToolStripMenuItem.Click
        Dim MiFormProveedores As New Proveedores
        MiFormProveedores.MdiParent = Me
        MiFormProveedores.Text = "Proveedores y sus productos"
        MiFormProveedores.Show()
    End Sub
End Class
