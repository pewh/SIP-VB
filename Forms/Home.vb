Public Class Home

    Private Sub printDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Dim more As Boolean

        Try
            more = dgPrinter.DrawDataGridView(e.Graphics)
            If more Then e.HasMorePages = True
        Catch Ex As Exception
            'MessageBox.Show(Ex.Message & vbCrLf & Ex.StackTrace, MyConstants.CaptionFehler, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub menuBarang_Click(sender As System.Object, e As System.EventArgs) Handles menuBarang.Click
        Dim frm As New Barang
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuPemasok_Click(sender As System.Object, e As System.EventArgs) Handles menuPemasok.Click
        Dim frm As New Pemasok
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuPembeli_Click(sender As System.Object, e As System.EventArgs) Handles menuPembeli.Click
        Dim frm As New Pembeli
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuFakturBeli_Click(sender As System.Object, e As System.EventArgs) Handles menuFakturBeli.Click
        Dim frm As New FakturPembelian
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuFakturJual_Click(sender As System.Object, e As System.EventArgs) Handles menuFakturJual.Click
        Dim frm As New FakturPenjualan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuTransaksiPembelian_Click(sender As System.Object, e As System.EventArgs) Handles menuTransaksiPembelian.Click
        Dim frm As New TransaksiPembelian
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuTransaksiPenjualan_Click(sender As System.Object, e As System.EventArgs) Handles menuTransaksiPenjualan.Click
        Dim frm As New TransaksiPenjualan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each c As Control In Me.Controls
            If TypeOf c Is MdiClient Then
                AddHandler c.Paint, AddressOf MDIControlPaint
                AddHandler c.SizeChanged, AddressOf MDIControlResize
            End If
        Next
    End Sub

    Private Sub MDIControlPaint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        'e.Graphics.DrawImage(picBG.Image, 0, 0, Width, Height)
    End Sub

    Private Sub MDIControlResize(sender As Object, e As System.EventArgs)
        CType(sender, MdiClient).Invalidate()
    End Sub

    Private Sub menuLunasBelumTransaksiPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLunasBelumTransaksiPembelian.Click
        Dim frm As New LunasBelumTransaksiPembelian
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuLunasBelumTransaksiPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLunasBelumTransaksiPenjualan.Click
        Dim frm As New LunasBelumTransaksiPenjualan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuLaporanLabaRugi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLaporanLabaRugi.Click
        Dim frm As New LaporanLabaRugi
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class