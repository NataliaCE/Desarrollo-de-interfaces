Public Class Colores
    Private Sub Colores_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
        generarColores()
        Panel1.BackColor = Color.Red
    End Sub

    Public Sub generarColores()
        Dim MiCaja As GroupBox = GroupBox1
        For Each MiPanel As Panel In MiCaja.Controls
            Dim miColor As Color = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
            MiPanel.BackColor = miColor
        Next
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarColores()
    End Sub

    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily

        For Each MiFuente In FontFamily.Families
            ComboBox1.Items.Add(MiFuente.Name)
        Next
        ComboBox1.Text = ComboBox1.Items(0)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        lblTexto.Font = New Font(ComboBox1.Text, TrackBar1.Value)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        lblTexto.Font = New Font(ComboBox1.Text, TrackBar1.Value)
    End Sub

End Class