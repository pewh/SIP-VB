Public Class LaporanLabaRugi

    Private Sub LaporanLabaRugi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim periodeList As String = "SELECT DISTINCT DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur) AS bulanan FROM DetailFakturPembelian"

        fetchToListbox(lstFaktur, periodeList)

        Dim hargaPembelianPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPembelianPerBulan"))
        Dim hargaPenjualanPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPenjualanPerBulan"))
        lblTotalPembelian.Text = hargaPembelianPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPenjualan.Text = hargaPenjualanPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotal.Text = (hargaPenjualanPerBulan - hargaPembelianPerBulan).ToString("c", New Globalization.CultureInfo("id-ID", False))

        If lstFaktur.Items.Count > 0 Then
            lstFaktur.SelectedIndex = 0
        End If
    End Sub

    Private Sub lstFaktur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFaktur.SelectedIndexChanged
        Dim suffix As String = " WHERE (DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur)) = '" & lstFaktur.SelectedItem & "'"

        Dim hargaPembelianPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPembelianPerBulan" + suffix))
        Dim hargaPenjualanPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPenjualanPerBulan" + suffix))
        lblTotalPembelianPeriode.Text = hargaPembelianPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPenjualanPeriode.Text = hargaPenjualanPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPeriode.Text = (hargaPenjualanPerBulan - hargaPembelianPerBulan).ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
End Class