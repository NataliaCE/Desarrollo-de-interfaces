Imports System.ComponentModel
Public Class ControlUsuario

    Private Texto As String
    Private Elemento As String

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
        If MiTexto.Text.Trim() = "" Or Not MiLista.Items.IndexOf(MiTexto.Text) = -1 Then Exit Sub
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            MiLista.Items.Add(MiTexto.Text.Trim())
            MiTexto.Clear()
        End If
    End Sub

    Private Sub MiLista_MouseDown(sender As Object, e As MouseEventArgs) Handles MiLista.MouseDown
        Dim lista As ListBox = sender
        lista.DoDragDrop(lista, DragDropEffects.Move)
    End Sub

    Private Sub MiLista_DragDrop(sender As Object, e As DragEventArgs) Handles MiLista.DragDrop
        Dim Destino As ListBox = sender
        Dim Origen As ListBox = e.Data.GetData(MiLista.GetType)
        Do While Origen.SelectedItems.Count
            If Not Destino.Items.IndexOf(Origen.SelectedItems(0)) = -1 Then Exit Sub
            Destino.Items.Add(Origen.SelectedItems(0))
            Origen.Items.Remove(Origen.SelectedItems(0))
        Loop
    End Sub

    Private Sub MiLista_DragOver(sender As Object, e As DragEventArgs) Handles MiLista.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
End Class
