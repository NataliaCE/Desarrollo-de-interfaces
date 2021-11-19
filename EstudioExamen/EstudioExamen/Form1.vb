Public Class Form1

    Private Sub rbWindows_CheckedChanged(sender As Object, e As EventArgs) Handles _
           rbNinguno.CheckedChanged, rbLinux.CheckedChanged, rbWindows.CheckedChanged, rbMacOS.CheckedChanged

        Dim MiRadio As RadioButton = sender
        Dim MiLista As ListBox = lbListaCompra

        If MiRadio.Text = "Ninguno" Then
            If MiRadio.Checked = True Then
                MiLista.Items.Clear()
                Panel1.Enabled = False
                gbCheck.Enabled = False
            Else
                Panel1.Enabled = True
                gbCheck.Enabled = True
            End If
            Exit Sub
        End If

        EscribirListaCompra()
    End Sub

    Private Sub cbAntivirus_CheckedChanged(sender As Object, e As EventArgs) Handles _
        cbAntivirus.CheckedChanged, cbAdobe.CheckedChanged, cbImpresora.CheckedChanged, cbAlgoCaro.CheckedChanged

        EscribirListaCompra()
    End Sub

    Private Sub EscribirListaCompra()
        Dim MiLista As ListBox = lbListaCompra
        MiLista.Items.Clear()
        For Each MiRadio As RadioButton In gbRadio.Controls
            If Not MiRadio.Text = "Ninguno" Then
                If MiRadio.Checked Then MiLista.Items.Add(MiRadio.Text & " - " & MiRadio.Tag)
            End If
        Next
        For Each MiCheck As CheckBox In gbCheck.Controls
            If MiCheck.Checked Then MiLista.Items.Add(MiCheck.Text & " - " & MiCheck.Tag)
        Next
        Dim p As Panel = New Panel
    End Sub
End Class

'AddHandler --> Colores y añadir textbox programaticamente
'Practica2 --> CheckBox
'Practica 4 --> Listbox y keypress
'Practica 5 --> Listbox y drag and drop
'Practica 7 --> Fuentes
'Practica 8 --> Menus
