Public Class Form1
    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click, Btn_Marca.Click, Btn_Pais.Click
        Dim MiBoton As Button = sender
        Dim MiTexto As TextBox = MiBoton.Tag
        Dim MiLista As ListBox = MiTexto.Tag
        If (MiTexto.Text.Trim = " ") Or Not (MiLista.Items.IndexOf(MiTexto.Text) = -1) Then Exit Sub

        MiLista.Items.Add(MiTexto.Text)
        MiTexto.Text = ""
        MiTexto.Focus()
    End Sub

    Private Sub Btn_BColor_Click(sender As Object, e As EventArgs) Handles Btn_BColor.Click, Btn_BMarca.Click, Btn_BPais.Click
        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Remove(MiLista.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        RelacionaListas()
    End Sub
    ''Ocurre antes de que se cargue el formulario

    Private Sub RelacionaListas()
        BtnColor.Tag = Txtb_color
        Txtb_color.Tag = Ltbx_Colores
        Btn_Marca.Tag = Txtb_Marca
        Txtb_Marca.Tag = Ltbx_Marcas
        Btn_Pais.Tag = Txtb_Pais
        Txtb_Pais.Tag = Ltbx_Paises
        Btn_BColor.Tag = Ltbx_Colores
        Btn_BMarca.Tag = Ltbx_Marcas
        Btn_BPais.Tag = Ltbx_Paises
        Ltbx_Marcas.Tag = Btn_Marca
        Ltbx_Colores.Tag = BtnColor
        Ltbx_Paises.Tag = Btn_Pais
    End Sub

    Private Sub Txtb_color_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        Txtb_color.KeyPress, Txtb_Marca.KeyPress, Txtb_Pais.KeyPress
        Dim MiTexto As TextBox = sender
        Dim MiBoton As Button = MiTexto.Tag.Tag
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            BtnColor_Click(MiBoton, New EventArgs)
        End If
    End Sub
End Class
