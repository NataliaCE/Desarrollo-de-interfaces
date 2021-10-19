Public Class Form1
    Private Sub Btn_resumen_Click(sender As Object, e As EventArgs) Handles Btn_resumen.Click

        Dim MiPanel As Panel = Panel1
        Dim MiCheck As CheckBox
        Dim MiLabel As Label = Lbl_resumen
        Dim texto As String = "RESUMEN:"
        For Each MiCheck In MiPanel.Controls
            If MiCheck.Checked Then
                texto &= Chr(10) & MiCheck.Text & " está activo."
            Else
                texto &= Chr(10) & MiCheck.Text & " está desactivado."
            End If
        Next
        MiLabel.Text = texto

    End Sub

    'Private Sub Chck1_CheckedChanged(sender As Object, e As EventArgs) _
    '    Handles Chck1.CheckedChanged, Chck2.CheckedChanged, Chck3.CheckedChanged, Chck4.CheckedChanged

    '    Dim Micheck As CheckBox = sender
    '    Dim Texto As String
    '    If Micheck.Checked Then
    '        Texto = "activo"
    '    Else
    '        Texto = "desactivado"
    '    End If
    '    MessageBox.Show("El CheckBox " & Micheck.Text & " está " & Texto, "Estado Check")
    'End Sub



End Class
