Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        InicializarControles()
    End Sub

    Private Sub InicializarControles()
        TextoIzq.Tag = ListaIzq
        Btn_AddIzq.Tag = ListaIzq
        TextoCentro.Tag = ListaCentro
        Btn_AddCentro.Tag = ListaCentro
        TextoDecha.Tag = ListaDecha
        Btn_AddDecha.Tag = ListaDecha
    End Sub

    Private Sub Btn_Borrar_Click(sender As Object, e As RoutedEventArgs) Handles _
        Btn_AddIzq.Click, Btn_AddCentro.Click, Btn_AddDecha.Click

        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Clear()
    End Sub

    Private Sub Texto_KeyDown(sender As Object, e As KeyEventArgs) Handles _
        TextoIzq.KeyDown, TextoCentro.KeyDown, TextoDecha.KeyDown

        Dim MiTexto As TextBox = sender
        Dim MiLista As ListBox = MiTexto.Tag

        If MiTexto.Text.Trim = "" Or Not MiLista.Items.IndexOf(MiTexto.Text) = -1 Then Exit Sub
        If e.Key = Key.Enter Then
            'e.Handled = True 'Quita el sonido de Windows
            MiLista.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
        End If
    End Sub
End Class
