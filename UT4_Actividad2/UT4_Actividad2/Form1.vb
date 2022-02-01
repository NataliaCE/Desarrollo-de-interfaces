Public Class Form1
    Dim nombre
    Dim apellidos
    Dim dni
    Dim fecha
    Dim depto
    Dim periodo

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AsignarTextBox()
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        If ComprobarDatosPersonales() And ComprobarDatosEmpresa() Then
            MessageBox.Show("Datos enviados")
        End If
    End Sub

    Public Sub AsignarTextBox()
        tb_nombre.Tag = Err_nombre
        tb_apellido.Tag = Err_apellidos
        tb_dni.Tag = Err_dni
    End Sub

    Function ComprobarDatosPersonales() As Boolean
        Dim contador As Integer = 0
        Dim obliga As Label
        For Each valor In Gb_datosPersonales.Controls
            If TypeOf valor Is TextBox Then
                obliga = valor.tag
                If valor.text.trim = "" Then
                    obliga.Text = "Campo obligatorio"
                    contador += 1
                Else
                    obliga.Text = "*"
                End If
            End If
        Next
        If contador > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function ComprobarDatosEmpresa() As Boolean
        Dim siRadio As Boolean = False
        Dim siCombo As Boolean = False
        For Each check As RadioButton In Pnl_radio.Controls
            If check.Checked Then
                siRadio = True
            End If
        Next
        If Not siRadio Then
            Err_depto.Text = "Campo obligatorio"
        Else
            Err_depto.Text = "*"
        End If

        If Cbx_periodo.SelectedIndex = -1 Then
            Err_periodo.Text = "Campo obligatorio"
        Else
            Err_periodo.Text = "*"
            siCombo = True
        End If

        If siRadio And siCombo Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
