Imports System.Drawing.Printing

Module Printing
    Public dgPrinter As DataGridViewPrinter

    Private Function SetupPrinting(ByVal dgView As DataGridView, ByVal printDoc As PrintDocument, ByVal title As String) As Boolean
        Dim printDialog As PrintDialog = New PrintDialog()

        With printDialog
            .AllowCurrentPage = False
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = True
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = False
        End With

        If printDialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return False

        With printDoc
            .DocumentName = "Sistem Informasi Penjualan"
            .PrinterSettings = printDialog.PrinterSettings
            .DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings
            .DefaultPageSettings.Margins = New Margins(60, 60, 60, 60)
        End With

        dgPrinter = New DataGridViewPrinter(dgView, printDoc, False, True, title, New Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)

        Return True
    End Function

    Sub printPreview(ByVal dgView As DataGridView, ByVal printDoc As PrintDocument, ByVal title As String)
        If SetupPrinting(dgView, printDoc, title) Then
            Dim printPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()

            printPreviewDialog.Document = printDoc
            printPreviewDialog.ShowDialog()
        End If
    End Sub

    Sub printReport(ByVal dgView As DataGridView, ByVal printDoc As PrintDocument, ByVal title As String)
        If SetupPrinting(dgView, printDoc, title) Then printDoc.Print()
    End Sub
End Module