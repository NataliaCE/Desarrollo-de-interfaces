Imports System.Data.OleDb

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.NeptunoDataSet.Pedidos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.NeptunoDataSet.Clientes)

    End Sub

End Class