Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AsignarTextBox()
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        AsignarTextBox()
        Comprobar()
    End Sub

    Public Sub AsignarTextBox()
        tb_nombre.Tag = Err_nombre
        tb_apellido.Tag = Err_apellidos
        tb_dni.Tag = Err_dni
    End Sub

    Public Sub Comprobar()
        Dim obliga As Label
        For Each valor In Gb_datosPersonales.Controls
            If TypeOf valor Is System.Windows.Forms.TextBox Then
                obliga = valor.tag
                If valor.text = "" Then

                End If
            End If
        Next

    End Sub
End Class
