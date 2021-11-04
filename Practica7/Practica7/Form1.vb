Public Class Form1
    Dim MiEstilo As FontStyle

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
        Chk_normal.Checked = True
    End Sub

    Private Sub TrckBr_tamanyo_Scroll(sender As Object, e As EventArgs) Handles TrckBr_tamanyo.Scroll
        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value, MiEstilo)
    End Sub

    Private Sub CmbBx_fuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBx_fuentes.SelectedIndexChanged
        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value, MiEstilo)
    End Sub

    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily

        For Each MiFuente In FontFamily.Families
            CmbBx_fuentes.Items.Add(MiFuente.Name)
        Next
        CmbBx_fuentes.Text = CmbBx_fuentes.Items(0)
    End Sub

    Private Sub Chk_negrita_CheckedChanged(sender As Object, e As EventArgs) Handles _
        Chk_negrita.CheckedChanged, Chk_cursiva.CheckedChanged, Chk_subrayado.CheckedChanged, Chk_tachado.CheckedChanged
        MiEstilo = FontStyle.Regular

        For Each MiCheck As CheckBox In Pnl_estilos.Controls
            If MiCheck.Checked Then
                MiEstilo += MiCheck.Font.Style
            End If
        Next

        If MiEstilo = FontStyle.Regular Then
            Chk_normal.Checked = True
        Else
            Chk_normal.Checked = False
        End If

        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value, MiEstilo)
    End Sub

    Private Sub Chk_normal_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_normal.CheckedChanged
        Dim MiCheck As CheckBox = sender

        If MiEstilo = FontStyle.Regular Then
            Chk_normal.Checked = True
        End If

        If MiCheck.Checked Then
            MiEstilo = FontStyle.Regular
            For Each Estilo As CheckBox In Pnl_estilos.Controls
                Estilo.Checked = False
            Next
        End If

        Lbl_texto.Font = New Font(CmbBx_fuentes.Text, TrckBr_tamanyo.Value, MiEstilo)
    End Sub
End Class

'variable gobal Estilo de tipo fontStyle --> Está cambiando todo el rato
'Cuando detecta un cambo de chequed --> proceso cambiar estilos (cambia variable estilo)
'Si el se detecta que Estilo está en normal, el checkbox normal se pone checked
'   También si no hay nada seleccionado