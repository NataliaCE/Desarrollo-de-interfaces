Class MainWindow

    Private Sub ButtonAddNombre_Click(sender As Object, e As RoutedEventArgs)
        If Not String.IsNullOrWhiteSpace(txtNombre.Text) And Not lstNombres.Items.Contains(txtNombre.Text) Then
            lstNombres.Items.Add(txtNombre.Text)
            txtNombre.Clear()
        End If
    End Sub
End Class
