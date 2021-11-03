Public Class Form1
    Dim MiEstilo As FontStyle

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
    End Sub

    Private Sub TrckBr_tamanyo_Scroll(sender As Object, e As EventArgs) Handles TrckBr_tamanyo.Scroll
        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value)
    End Sub

    Private Sub CmbBx_fuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBx_fuentes.SelectedIndexChanged
        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value)
    End Sub

    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily

        For Each MiFuente In FontFamily.Families
            CmbBx_fuentes.Items.Add(MiFuente.Name)
        Next
        CmbBx_fuentes.Text = CmbBx_fuentes.Items(0)
    End Sub

End Class

'variable gobal Estilo de tipo fontStyle --> Está cambiando todo el rato
'Cuando detecta un cambo de chequed --> proceso cambiar estilos (cambia variable estilo)
'Si el se detecta que Estilo está en normal, el checkbox normal se pone checked
'   También si no hay nada seleccionado