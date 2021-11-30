Imports System.ComponentModel
Public Class ControlUsuario

    Private Texto As String

    'Con esta propiedad se puede acceder a la variable Texto que es privada
    <Description("Propiedad de texto")>
    Public Property TextoInicial() As String
        'Getter
        Get
            Return Texto
        End Get
        'Setter
        Set(value As String)
            Texto = value
        End Set
    End Property

    Private Sub MiBoton_Click(sender As Object, e As EventArgs) Handles MiBoton.Click
        MiLista.Items.Clear()
    End Sub

    Private Sub ControlUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiTexto.Text = Me.TextoInicial
    End Sub

    Private Sub MiTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiTexto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            MiLista.Items.Add(MiTexto.Text)
        End If
    End Sub
End Class
