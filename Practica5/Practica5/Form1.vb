Public Class Form1

    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()
    End Sub

    Private Sub InicializarControles()
        Txtb_EntradaListIzq.Tag = Ltbx_listaIzq
        Btn_borr_listaIzq.Tag = Ltbx_listaIzq
        Txtb_EntradaListCentro.Tag = Ltbx_listaCentro
        Btn_borr_listaCentro.Tag = Ltbx_listaCentro
        Txtb_EntradaListDecha.Tag = Ltbx_listaDecha
        Btn_borr_listaDecha.Tag = Ltbx_listaDecha
    End Sub

    Private Sub Txtb_EntradaListIzq_KeyPress(sender As Object, e As KeyPressEventArgs) _
                Handles Txtb_EntradaListIzq.KeyPress, Txtb_EntradaListCentro.KeyPress, Txtb_EntradaListDecha.KeyPress

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
                Handles Btn_borr_listaIzq.Click, Btn_borr_listaCentro.Click, Btn_borr_listaDecha.Click
        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Clear()
    End Sub

    Private Sub IntercambioListas()
        Do While MiListaOrigen.SelectedItems.Count
            If Not MiListaDestino.Items.IndexOf(MiListaOrigen.SelectedItems(0)) = -1 Then Exit Sub
            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))
        Loop

    End Sub

    'Se envia un elemento haciendo doble-click en él
    Private Sub Ltbx_listaIzq_DoubleClick(sender As Object, e As EventArgs) _
                Handles Ltbx_listaIzq.DoubleClick, Ltbx_listaCentro.DoubleClick, Ltbx_listaDecha.DoubleClick
        Dim MiLista As ListBox = sender
        If MiLista.SelectedItems.Count = 0 Then Exit Sub
        Select Case MiLista.Name
            Case "Ltbx_listaIzq"
                MiListaOrigen = Ltbx_listaIzq
                MiListaDestino = Ltbx_listaCentro
            Case "Ltbx_listaCentro"
                MiListaOrigen = Ltbx_listaCentro
                MiListaDestino = Ltbx_listaDecha
            Case "Ltbx_listaDecha"
                MiListaOrigen = Ltbx_listaDecha
                MiListaDestino = Ltbx_listaIzq
        End Select
        IntercambioListas()
    End Sub

    'Se envian elementos selecionados mediante los botones
    Private Sub Btn_Enviar_Click(sender As Object, e As EventArgs) _
        Handles Btn_IzqACentro.Click, Btn_CentroAIzq.Click, Btn_DechaACentro.Click, Btn_CentroADecha.Click
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "Btn_IzqACentro"
                MiListaOrigen = Ltbx_listaIzq
                MiListaDestino = Ltbx_listaCentro
            Case "Btn_CentroAIzq"
                MiListaOrigen = Ltbx_listaCentro
                MiListaDestino = Ltbx_listaIzq
            Case "Btn_DechaACentro"
                MiListaOrigen = Ltbx_listaDecha
                MiListaDestino = Ltbx_listaCentro
            Case "Btn_CentroADecha"
                MiListaOrigen = Ltbx_listaCentro
                MiListaDestino = Ltbx_listaDecha
        End Select
        IntercambioListas()
    End Sub
End Class
