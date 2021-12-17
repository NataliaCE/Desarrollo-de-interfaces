Public Class Form1
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NeptunoDataSet.Productos)

    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    'IMPRIMIR en printdoc+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Friend WithEvents MiPrint As PrintPreviewDialog
    Friend WithEvents MiPrintDocumento As Drawing.Printing.PrintDocument
    Friend WithEvents MiImpresora As New PrintDialog
    'PrintPreviewDialog --> Dialogo que contiene la vista previa de impresión
    'PrintDocument --> Clase que envia el documento a la impresora y establece la configuración de impresion
    'PrintDialog --> Permite elegir una impresora y las secciones del documento a imprimir

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        MiPrint = New PrintPreviewDialog
        MiPrintDocumento = New Printing.PrintDocument

        'Rellena el documento previo
        MiPrint.Document = MiPrintDocumento 'Vista previa del documento
        MiPrintDocumento.PrinterSettings = MiImpresora.PrinterSettings 'Se usa la configuración de impresion definida en la vista previa
        MiPrintDocumento.DefaultPageSettings.Landscape = True 'Documento apaisado

        If MiPrint.ShowDialog() = DialogResult.OK Then
            If MiImpresora.ShowDialog() = DialogResult.OK Then
                MiPrint.Document.Print() 'Se imprime el documento
            End If
        End If
    End Sub
End Class
