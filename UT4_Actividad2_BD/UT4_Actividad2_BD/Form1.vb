Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet1.Customers' Puede moverla o quitarla según sea necesario.
        Me.CustomersTableAdapter.Fill(Me.Database1DataSet1.Customers)

    End Sub
End Class
