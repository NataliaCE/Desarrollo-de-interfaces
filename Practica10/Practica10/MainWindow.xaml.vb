Class MainWindow
    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        InicializarControles()
    End Sub

    Private Sub InicializarControles()
        TextoIzq.Tag = ListaIzq
        Btn_BorrarIzq.Tag = ListaIzq
        TextoCentro.Tag = ListaCentro
        Btn_BorrarCentro.Tag = ListaCentro
        TextoDecha.Tag = ListaDecha
        Btn_BorrarDecha.Tag = ListaDecha
    End Sub

    Private Sub Click_borrar(sender As Object, e As RoutedEventArgs)

        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Clear()
    End Sub

    Private Sub Texto_KeyDown(sender As Object, e As KeyEventArgs)

        Dim MiTexto As TextBox = sender
        Dim MiLista As ListBox = MiTexto.Tag

        If MiTexto.Text.Trim = "" Or Not MiLista.Items.IndexOf(MiTexto.Text) = -1 Then Exit Sub
        If e.Key = Key.Enter Then
            'e.Handled = True 'Quita el sonido de Windows
            MiLista.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
            MiTexto.Focus()
        End If
    End Sub

    Private Sub IntercambioListas()
        Do While MiListaOrigen.SelectedItems.Count
            If Not MiListaDestino.Items.IndexOf(MiListaOrigen.SelectedItems(0)) = -1 Then Exit Sub
            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))
        Loop
    End Sub

    Private Sub Click_enviar(sender As Object, e As RoutedEventArgs)
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "Btn_IzqCentro"
                MiListaOrigen = ListaIzq
                MiListaDestino = ListaCentro
            Case "Btn_CentroIzq"
                MiListaOrigen = ListaCentro
                MiListaDestino = ListaIzq
            Case "Btn_DechaCentro"
                MiListaOrigen = ListaDecha
                MiListaDestino = ListaCentro
            Case "Btn_CentroDecha"
                MiListaOrigen = ListaCentro
                MiListaDestino = ListaDecha
        End Select
        IntercambioListas()
    End Sub

    Private Sub Click_doble(sender As Object, e As MouseButtonEventArgs) _
        Handles ListaIzq.MouseDoubleClick, ListaCentro.MouseDoubleClick, ListaDecha.MouseDoubleClick
        Dim MiLista As ListBox = sender
        If MiLista.SelectedItems.Count = 0 Then Exit Sub

        Select Case MiLista.Name
            Case "ListaIzq"
                MiListaOrigen = ListaIzq
                MiListaDestino = ListaCentro
            Case "ListaCentro"
                MiListaOrigen = ListaCentro
                MiListaDestino = ListaDecha
            Case "ListaDecha"
                MiListaOrigen = ListaDecha
                MiListaDestino = ListaIzq
        End Select
        IntercambioListas()
    End Sub

    Private Sub Lista_MouseDown(sender As Object, e As MouseButtonEventArgs) _
        Handles ListaIzq.MouseDown, ListaCentro.MouseDown, ListaDecha.MouseDown
        MiListaOrigen = sender
        Select Case MiListaOrigen.Name
            Case "Ltbx_listaIzq"
                MiListaDestino = ListaCentro
            Case "Ltbx_listaCentro"
                MiListaDestino = ListaDecha
            Case "Ltbx_listaDecha"
                MiListaDestino = ListaIzq
        End Select

        If e.ClickCount = 2 Then
            IntercambioListas()
        End If

        'While MiListaOrigen.SelectedItems IsNot Nothing
        '    If e.LeftButton = MouseButtonState.Pressed Then
        '        DragDrop.DoDragDrop(MiListaOrigen, MiListaOrigen.SelectedItems, DragDropEffects.Move)
        '    End If
        'End While

    End Sub

    'Private Sub Lista_Drop(sender As Object, e As DragEventArgs) Handles ListaCentro.Drop
    '    MiListaDestino = sender
    '    IntercambioListas()
    'End Sub

    'Private Sub Lista_DragOver(sender As Object, e As DragEventArgs)
    '    'e.Effects = DragDropEffects.Move
    'End Sub
End Class
