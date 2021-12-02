Public Class Form1
    Private Sub ClientesYSusPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYSusPedidosToolStripMenuItem.Click
        Dim MiFormClientes As New Clientes
        MiFormClientes.MdiParent = Me
        MiFormClientes.Text = "Clientes y sus pedidos"
        MiFormClientes.Show()
    End Sub
End Class
