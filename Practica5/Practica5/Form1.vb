Public Class Form1

    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()
    End Sub

    Private Sub InicializarControles()
        Txtb_EntradaListIzq.Tag = Ltbx_listaIzq
        Btn_borr_lista.Tag = Ltbx_listaIzq
        Txtb_EntradaListCentro.Tag = Ltbx_listaCentro
        Btn_borr_listaCentro.Tag = Ltbx_listaCentro
    End Sub

    Private Sub Txtb_EntradaListIzq_KeyPress(sender As Object, e As KeyPressEventArgs) _
                Handles Txtb_EntradaListIzq.KeyPress, Txtb_EntradaListCentro.KeyPress

        Dim MiTexto As TextBox = sender
        Dim MiListaEntrada As ListBox = MiTexto.Tag
        If MiTexto.Text.Trim = "" Or Not MiListaEntrada.Items.IndexOf(MiTexto.Text) = -1 Then Exit Sub
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quito el sonido de Windows
            MiListaEntrada.Items.Add(MiTexto.Text.Trim)
            MiTexto.Text = ""
            MiTexto.Focus()
        End If

    End Sub

    Private Sub Btn_borr_lista_Click(sender As Object, e As EventArgs) _
                Handles Btn_borr_lista.Click, Btn_borr_listaCentro.Click
        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Clear()
    End Sub

    Private Sub IntercambioListas()
        Do While MiListaOrigen.SelectedItems.Count
            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaDestino.SelectedItems(0))
        Loop

    End Sub

    Private Sub Ltbx_listaIzq_DoubleClick(sender As Object, e As EventArgs) _
                Handles Ltbx_listaIzq.DoubleClick, Ltbx_listaCentro.DoubleClick
        Dim MiLista As ListBox = sender
        If MiLista.SelectedItem.count = 0 Then Exit Sub
        Select Case MiLista.Name.ToString
            Case "Ltbx_listaIzq"
                MiListaOrigen = Ltbx_listaIzq
                MiListaDestino = Ltbx_listaCentro
            Case "Ltbx_listaCentro"
                MiListaOrigen = Ltbx_listaCentro
                MiListaDestino = Ltbx_listaIzq
        End Select
        IntercambioListas()
    End Sub
End Class
