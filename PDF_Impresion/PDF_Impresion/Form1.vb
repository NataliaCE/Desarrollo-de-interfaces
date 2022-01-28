Imports System.Drawing.Printing

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

        MiImpresora.ShowDialog()
        MiPrint.Document = MiPrintDocumento 'Vista previa del documento MiPrintDocumento
        MiPrintDocumento.PrinterSettings = MiImpresora.PrinterSettings 'Se usa la configuración de impresion definida en la vista previa
        MiPrintDocumento.DefaultPageSettings.Landscape = True 'Documento apaisado

        If MiPrint.ShowDialog() = DialogResult.OK Then
            If MiImpresora.ShowDialog() = DialogResult.OK Then
                MiPrint.Document.Print() 'Se imprime el documento
            End If
        End If
    End Sub


    '************************
    ' Imprimir DataGridView Variables de paginación
    ' Configurar MiPrintDocumento
    '************************
    Dim ColumnasIzq As ArrayList
    Dim ColumnaAnchuras As ArrayList
    Dim ColumnaTipos As ArrayList
    Dim ColumnaFormatos As ArrayList

    Dim AnchuraTotal As Int16
    Dim PosicionFila As Short
    Dim FilasPPagina As Integer
    Dim AlturaPagina As Integer
    Dim AnchuraPagina As Integer
    Dim NumPagina As Integer

    Private Sub MiPrintDocumento_BeginPrint(ByVal sender As Object, ByVale As PrintEventArgs) Handles MiPrintDocumento.BeginPrint

        ColumnasIzq = New ArrayList
        ColumnaAnchuras = New ArrayList
        ColumnaTipos = New ArrayList
        AnchuraTotal = 0
        PosicionFila = 0
        FilasPPagina = 25
        AlturaPagina = 0
        AnchuraPagina = 0
        NumPagina = 1

    End Sub

    Private Sub MiPrintDocumento_PrintPage(sender As Object, e As PrintPageEventArgs) Handles MiPrintDocumento.PrintPage

        Dim MiFuenteCabecera As New Font("Arial", 8, FontStyle.Bold)
        Dim MiFuenteFila As New Font("Arial", 7, FontStyle.Regular)
        'Dim pHeader As String = Me.Text
        Dim i As Integer '?
        Dim MargenTop As Integer = e.MarginBounds.Top
        Dim MargenIzq As Integer = e.MarginBounds.Left
        Dim PagNueva As Boolean = True
        Dim CuentaFilas As Int16
        'AnchuraTotal = 0

        'La anchura total es la suma de la anchura de cada columna en la rejilla
        For Each DGColumna As DataGridViewColumn In RejillaProductos.Columns
            AnchuraTotal += DGColumna.Width
        Next

        'En la primera página se dan valores a margenes y demás
        If NumPagina = 1 Then
            For Each DGColumna As DataGridViewColumn In RejillaProductos.Columns
                AnchuraPagina = CType(Math.Floor(DGColumna.Width / AnchuraTotal * AnchuraTotal * (e.MarginBounds.Width / AnchuraTotal)), Int16)
                AlturaPagina = e.Graphics.MeasureString(DGColumna.HeaderText, MiFuenteCabecera, AnchuraPagina).Height + 11
                ColumnasIzq.Add(MargenIzq)
                ColumnaAnchuras.Add(AnchuraPagina)
                ColumnaTipos.Add(DGColumna.GetType)
                MargenIzq += AnchuraPagina
            Next
        End If

        'Recorre todas las filas de la rejilla
        Do While PosicionFila <= RejillaProductos.Rows.Count - 1
            Dim Fila As DataGridViewRow = RejillaProductos.Rows(PosicionFila)
            CuentaFilas += 1

            'Si se llega al maximo de filas por página
            If FilasPPagina = CuentaFilas Then
                DibujaFooter(e, FilasPPagina, NumPagina)
                NumPagina += 1
                e.HasMorePages = True 'Activa la recursividad mientras haya más páginas
                Exit Sub

            Else
                e.HasMorePages = False 'No se necesitan más páginas
                If PagNueva Then
                    MargenTop = e.MarginBounds.Top
                    i = 0

                    'Titulos de cabecera
                    Dim MiPincel As New SolidBrush(Color.Black)
                    Dim MiMiniatura As Image.GetThumbnailImageAbort = Nothing

                End If
            End If
        Loop

    End Sub

    Private Sub DibujaFooter(ByRef e As PrintPageEventArgs, ByVal FilasPPagina As Int32, ByVal NumPagina As Int16)

    End Sub
End Class
