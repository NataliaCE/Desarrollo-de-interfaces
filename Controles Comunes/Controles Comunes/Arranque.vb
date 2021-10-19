Module Arranque

    Sub main()
        Dim MiPrincipal As Principal
        Dim Op As Integer = 0
        Op = MessageBox.Show("Sigues? Sí o No", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If Op = vbNo Then
            End
        End If

        MiPrincipal = New Principal
        MiPrincipal.ShowDialog()
    End Sub
End Module