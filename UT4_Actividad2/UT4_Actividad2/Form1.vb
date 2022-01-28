Public Class Form1
    Dim nombre
    Dim apellidos
    Dim dni
    Dim fecha
    Dim dpto
    Dim periodo
    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click

    End Sub

    Private Sub Comprobar()
        tb_nombre.Text = nombre
        tb_apellido.Text = apellidos
        tb_dni.Text = dni
        dtp_fecha.Value = fecha
        For Each radio As RadioButton In Pnl_radio.Controls
            If radio.Checked Then
                radio.Text = dpto
            End If
        Next
        Cbx_periodo.SelectedItem = periodo

    End Sub
End Class
