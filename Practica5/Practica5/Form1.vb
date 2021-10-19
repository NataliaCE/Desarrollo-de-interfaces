Public Class Form1

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
End Class
