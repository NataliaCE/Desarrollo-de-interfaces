Public Class Form1
    Private Sub Btn_Mxtexb_Click(sender As Object, e As EventArgs) Handles Btn_Mxtexb.Click
        Dim MitextBox As New TextBox
        Dim MiLabel As New Label

        If PanelTXTbx.Controls.Count > 9 Then Exit Sub

        MitextBox.Top = (PanelTXTbx.Controls.Count / 2) * (MitextBox.Height + 5)
        MitextBox.Top = (PanelTXTbx.Controls.Count / 2) * (MitextBox.Height + 5)
        MitextBox.Left = MiLabel.Width + 5

        AddHandler MitextBox.DoubleClick, AddressOf Mitexto
        MiLabel.Text = "TextBox nº " & (PanelTXTbx.Controls.Count / 2 + 1)
        PanelTXTbx.Controls.Add(MiLabel)
        PanelTXTbx.Controls.Add(MitextBox)
        MitextBox.Name = "TextBox_" & PanelTXTbx.Controls.Count
        ContadorTXTbx.Text = "Nº de TextBox " & PanelTXTbx.Controls.Count / 2
    End Sub

    Private Sub Btn_Mntexb_Click(sender As Object, e As EventArgs) Handles Btn_Mntexb.Click
        If PanelTXTbx.Controls.Count = 0 Then Exit Sub
        PanelTXTbx.Controls.RemoveAt(PanelTXTbx.Controls.Count - 1)
        ContadorTXTbx.Text = "Nº de TextBox " & PanelTXTbx.Controls.Count
    End Sub
    Private Sub Mitexto(Objeto As Object, Evento As EventArgs)
        Dim Mitexto As TextBox = Objeto
        MessageBox.Show("contenido de: " & Mitexto.Name & "-->" & Mitexto.Text)

    End Sub
End Class
