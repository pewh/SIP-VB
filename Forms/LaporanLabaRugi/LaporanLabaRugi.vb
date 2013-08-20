Public Class LaporanLabaRugi

    Private Sub LaporanLabaRugi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim periodeList As String = "SELECT DISTINCT DateName(Year, tanggal) + ' ' + DateName(Month, tanggal) AS bulanan FROM PengeluaranOperasional"

        fetchToListbox(lstFaktur, periodeList)

        Dim biayaOperasional As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM PengeluaranOperasional"))
        Dim hargaPembelian As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPembelianPerBulan"))
        Dim hargaPenjualan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPenjualanPerBulan"))

        lblBiayaOperasional.Text = biayaOperasional.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPembelian.Text = hargaPembelian.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPenjualan.Text = hargaPenjualan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPengeluaran.Text = (hargaPembelian + biayaOperasional).ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotal.Text = (hargaPenjualan - (hargaPembelian + biayaOperasional)).ToString("c", New Globalization.CultureInfo("id-ID", False))

        If lstFaktur.Items.Count > 0 Then
            lstFaktur.SelectedIndex = 0
        End If
    End Sub

    Private Sub lstFaktur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFaktur.SelectedIndexChanged
        Dim suffix As String = " WHERE (DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur)) = '" & lstFaktur.SelectedItem & "'"

        Dim q As String = "SELECT SUM(harga) FROM PengeluaranOperasional WHERE (DateName(Year, tanggal) + ' ' + DateName(Month, tanggal)) = '" & lstFaktur.SelectedItem & "' GROUP BY (DateName(Year, tanggal) + ' ' + DateName(Month, tanggal))"

        Dim biayaOperasionalPerBulan As Integer = Integer.Parse(fetchOne(q))

        Dim hargaPembelianPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPembelianPerBulan" + suffix))
        Dim hargaPenjualanPerBulan As Integer = Integer.Parse(fetchOne("SELECT SUM(harga) FROM TotalHargaPenjualanPerBulan" + suffix))

        lblBiayaOperasionalPeriode.Text = biayaOperasionalPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPembelianPeriode.Text = hargaPembelianPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPenjualanPeriode.Text = hargaPenjualanPerBulan.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPengeluaranPeriode.Text = (biayaOperasionalPerBulan + hargaPembelianPerBulan).ToString("c", New Globalization.CultureInfo("id-ID", False))
        lblTotalPeriode.Text = (hargaPenjualanPerBulan - (biayaOperasionalPerBulan + hargaPembelianPerBulan)).ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
End Class