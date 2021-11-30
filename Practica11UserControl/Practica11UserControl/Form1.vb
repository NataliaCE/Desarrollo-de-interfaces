Public Class Form1
    'Dim Elemento As String
    'Private Sub ControlIzq_MouseDown(sender As Object, e As MouseEventArgs) _
    '    Handles ControlIzq.MouseDown, ControlDecha.MouseDown, ControlCentro.MouseDown
    '    Dim MiControl As ControlUsuario = sender
    '    Elemento = MiControl.ElementoDrop
    'End Sub

    'Private Sub Ltbx_DragOver(sender As Object, e As DragEventArgs) _
    '    Handles ControlCentro.DragOver, ControlDecha.DragOver, ControlIzq.DragOver
    '    e.Effect = DragDropEffects.Move
    'End Sub

    'Private Sub ControlCentro_MouseUp(sender As Object, e As MouseEventArgs) _
    '    Handles ControlCentro.MouseUp, ControlDecha.MouseUp, ControlIzq.MouseUp
    '    Dim MiControl As ControlUsuario = sender
    '    MiControl.ElementoDrop = Elemento
    'End Sub

    'Private Sub ControlCentro_MouseEnter(sender As Object, e As EventArgs) _
    '    Handles ControlCentro.MouseEnter, ControlDecha.MouseEnter, ControlIzq.MouseEnter
    '    Dim MiControl As ControlUsuario = sender
    '    MiControl.ElementoDrop = Elemento
    'End Sub

    'Private Sub Ltbx_DragDrop(sender As Object, e As DragEventArgs) _
    '    Handles ControlCentro.DragDrop, ControlDecha.DragDrop, ControlIzq.DragDrop
    '    Dim MiControl As ControlUsuario = sender
    '    ListaDestino = MiControl.MiLista
    '    IntercambioListas()
    'End Sub

    'Private Sub IntercambioListas()
    '    Do While ListaOrigen.SelectedItems.Count
    '        If Not ListaDestino.Items.IndexOf(ListaOrigen.SelectedItems(0)) = -1 Then Exit Sub
    '        ListaDestino.Items.Add(ListaOrigen.SelectedItems(0))
    '        ListaOrigen.Items.Remove(ListaOrigen.SelectedItems(0))
    '    Loop

    'End Sub
End Class
