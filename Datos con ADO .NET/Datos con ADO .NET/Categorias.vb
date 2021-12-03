Public Class Categorias
    Private Sub CategoríasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoríasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoríasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet)

    End Sub

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NeptunoDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Categorías' Puede moverla o quitarla según sea necesario.
        Me.CategoríasTableAdapter.Fill(Me.NeptunoDataSet.Categorías)

    End Sub
End Class