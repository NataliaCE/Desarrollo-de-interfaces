Public Class Principal

    Private Sub Btn_saludo_Click(sender As Object, e As EventArgs) Handles Btn_saludo.Click

        For Each radio As RadioButton In Pnl_radio.Controls
            If radio.Checked Then Lbl_saludo.Text = radio.Tag & " " & radio.Text
        Next

        For Each radio As RadioButton In Pnl_nombres.Controls
            If radio.Checked Then Lbl_saludo.Text += " " & radio.Text
        Next

        Me.Text = Lbl_saludo.Text

    End Sub

End Class
