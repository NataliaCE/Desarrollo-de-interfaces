Public Class Form1

    'Friend WithEvents MiBoton As Button + Handles MiBoton.click en el método click_Boton

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim MiBoton = New Button
        'En Button, click derecho e ir a definición

        AddHandler MiBoton.Click, AddressOf click_Boton
        Me.Controls.Add(MiBoton)
    End Sub

    Sub click_Boton(MiObjeto As Object, evento As EventArgs)
        MessageBox.Show("Hola")
    End Sub

End Class

''Cada vez que se pulsa un botón, se crean textboxes.