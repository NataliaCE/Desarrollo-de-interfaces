Public Class Servicios
    Dim valoresSw() As Integer = {}
    Private Sub Servicios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim miradio As RadioButton = rbNinguno
        miradio.Checked = True
    End Sub

    Private Sub rbNinguno_CheckedChanged(sender As Object, e As EventArgs) Handles rbNinguno.CheckedChanged
        Dim MiRadio As RadioButton = sender
        Dim MiLista As ListBox = LbLista
        If MiRadio.Checked = True Then
            PanelListas.Enabled = False
            PanelSW.Enabled = False
        Else
            PanelListas.Enabled = True
            PanelSW.Enabled = True
        End If
    End Sub

    Public Sub escribirLista()
        Dim MiLista As ListBox = LbLista
        MiLista.Items.Clear()
        For Each MiRadio As RadioButton In PanelRadio.Controls
            If Not MiRadio.Text = "Ninguno" Then
                If MiRadio.Checked Then MiLista.Items.Add(MiRadio.Text)
                valoresSw(0) = CInt(MiRadio.Tag)
            End If
        Next
        Dim contador As Integer = 1
        For Each MiCheck As CheckBox In PanelSW.Controls
            If MiCheck.Checked Then
                MiLista.Items.Add(MiCheck.Text)
                valoresSw(1) = CInt(MiCheck.Tag)
                contador += 1
            End If
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles _
         RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        escribirLista()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles _
        CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged
        escribirLista()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not Char.IsDigit(tbprecio.Text) Then Exit Sub
        Dim producto As String = tbProducto.Text.Trim
        Dim MiLista As ListBox = LbLista
        Dim miItem As String = producto & " (" & CInt(tbprecio.Text) & "€)"


        If Not MiLista.Items.Contains(miItem) And Not producto.Length = 0 Then
            MiLista.Items.Add(miItem)
            ReDim Preserve valoresSw(valoresSw.Count)
            valoresSw(valoresSw.Count - 1) = CInt(tbprecio.Text)
        End If


        ' MiLista.Items.Add(producto.Text & " (" & precio.Text & ")")
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim milista As ListBox = LbLista
        Dim total As Integer
        Dim listatotal As RichTextBox = RichTextBox1
        Dim texto As String = ""
        For Each miItem As String In milista.SelectedItems
            listatotal.Text &= texto & vbCrLf
        Next
    End Sub
End Class