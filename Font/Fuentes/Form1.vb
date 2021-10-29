Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
    End Sub

    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families
            Cmbx_fuentes.Items.Add(MiFuente.Name)
        Next
        Cmbx_fuentes.Text = Cmbx_fuentes.Items(0)
    End Sub

    Private Sub Cmbx_fuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbx_fuentes.SelectedIndexChanged
        Lbl_saludo.Font = New Drawing.Font(Cmbx_fuentes.Text, Trackbar.Value)
    End Sub

    Private Sub Trackbar_Scroll(sender As Object, e As EventArgs) Handles Trackbar.Scroll
        Lbl_saludo.Font = New Font(Cmbx_fuentes.Text, Trackbar.Value)
    End Sub
End Class
