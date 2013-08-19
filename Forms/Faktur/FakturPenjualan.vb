Public Class FakturPenjualan

    Sub refreshData()
        Dim fakturQuery As String

        Select Case cbKategori.SelectedIndex
            Case 0
                fakturQuery = "SELECT kode FROM FakturJual"
                If chkFilterTanggal.Checked Then
                    fakturQuery &= String.Format(" WHERE tanggal BETWEEN '{0}' AND '{1}'", dtTglMulai.Value, dtTglAkhir.Value)
                End If
            Case 1
                fakturQuery = "SELECT DISTINCT nama_pembeli FROM DetailFakturPenjualan"
                If chkFilterTanggal.Checked Then
                    fakturQuery &= String.Format(" WHERE tanggal_faktur BETWEEN '{0}' AND '{1}'", dtTglMulai.Value, dtTglAkhir.Value)
                End If
            Case 2
                fakturQuery = "SELECT DISTINCT (DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur)) AS bulanan FROM DetailFakturPenjualan"
            Case Else 'redirect to 0 if out of range
                fakturQuery = "SELECT kode FROM FakturJual"
        End Select

        fetchToListbox(lstFaktur, fakturQuery)

        lblTotalFaktur.Text = lstFaktur.Items.Count
    End Sub

    Private Sub FakturPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cbKategori.Items.Count > 0 Then
            cbKategori.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKategori.SelectedIndexChanged
        If cbKategori.SelectedIndex = 2 Then
            chkFilterTanggal.Checked = False
            chkFilterTanggal.Enabled = False
        Else
            chkFilterTanggal.Enabled = True
        End If

        If cbKategori.SelectedIndex = 0 Then
            btnHapusFaktur.Enabled = True
            btnHapusSemuaFaktur.Enabled = True
        Else
            btnHapusFaktur.Enabled = False
            btnHapusSemuaFaktur.Enabled = False
        End If

        refreshData()
    End Sub

    Private Sub dtTglMulai_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglMulai.ValueChanged
        refreshData()
    End Sub

    Private Sub dtTglAkhir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglAkhir.ValueChanged
        refreshData()
    End Sub

    Private Sub chkFilterTanggal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFilterTanggal.CheckedChanged
        If chkFilterTanggal.Checked Then
            dtTglMulai.Enabled = True
            dtTglAkhir.Enabled = True
        Else
            dtTglMulai.Enabled = False
            dtTglAkhir.Enabled = False
        End If

        refreshData()
    End Sub

    Private Sub lstFaktur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFaktur.SelectedIndexChanged
        Dim suffix, totalItem, harga As String
        Dim hargaJual As Integer

        Select Case cbKategori.SelectedIndex
            Case 0
                suffix = " kode_faktur = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerjualPerFaktur"
                harga = "TotalHargaPenjualanPerFaktur"
            Case 1
                suffix = " nama_pembeli = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerjualPerPemasok"
                harga = "TotalHargaPenjualanPerPemasok"
            Case 2
                suffix = " (DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur)) = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerjualPerBulan"
                harga = "TotalHargaPenjualanPerBulan"
            Case Else ' redirect to case 0
                suffix = " kode_faktur = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerjualPerFaktur"
                harga = "TotalHargaPenjualanPerFaktur"
        End Select

        fetchToDatagrid(dgDetailFaktur, "SELECT * FROM DetailFakturPenjualan WHERE" & suffix, 0, 1, 2, 4, 7, 9)

        If cbKategori.SelectedIndex = 2 Then ' bulanan
            lblNamaPembeli.Text = "-"
            lblTanggal.Text = lstFaktur.SelectedItem
        Else
            lblNamaPembeli.Text = fetchOne("SELECT nama_pembeli FROM DetailFakturPenjualan WHERE" & suffix)
            lblTanggal.Text = fetchOne("SELECT tanggal_faktur FROM DetailFakturPenjualan WHERE" & suffix)
        End If

        If cbKategori.SelectedIndex = 0 Then
            lblDiskon.Text = fetchOne("SELECT diskon FROM DetailFakturPenjualan WHERE " & suffix) & "%"
        Else
            lblDiskon.Text = "-"
        End If

        hargaJual = Integer.Parse(fetchOne("SELECT harga FROM " & harga & " WHERE" & suffix))

        lblTotalStok.Text = fetchOne("SELECT total_barang FROM " & totalItem & " WHERE" & suffix)
        lblTotalBarang.Text = dgDetailFaktur.RowCount
        lblTotalHarga.Text = hargaJual.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub btnHapusFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusFaktur.Click
        If MsgBox("Apakah Anda yakin untuk menghapus faktur " & lstFaktur.SelectedItem & "?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
            If exec("HapusFakturJual '" & lstFaktur.SelectedItem & "', 1") = True Then
                MsgBox("Faktur berhasil dihapus")
            Else
                MsgBox("Faktur tidak bisa dihapus")
            End If
        End If

        refreshData()
    End Sub

    Private Sub btnHapusSemuaFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusSemuaFaktur.Click
        If MsgBox("Apakah Anda yakin untuk menghapus semua faktur?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
            If exec("HapusSemuaFakturJual 1") = True Then
                MsgBox("Faktur berhasil dihapus")
            Else
                MsgBox("Faktur tidak bisa dihapus")
            End If
        End If

        refreshData()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim head As String = String.Format("{1}{0}{0}{2}{3}{0}{4}{5}{0}{6}{7}{0}{8}{9}{0}{10}{11}{0}{12}{13}{0}{14}{15}{0}{16}{17}",
                                           vbCrLf,
                                           "Faktur Penjualan",
                                           cbKategori.Text + ": ",
                                           lstFaktur.SelectedItem,
                                           "Total faktur: ",
                                           lblTotalFaktur.Text,
                                           "Tanggal: ",
                                           lblTanggal.Text,
                                           "Pembeli: ",
                                           lblNamaPembeli.Text,
                                           "Total barang: ",
                                           lblTotalBarang.Text,
                                           "Total stok terjual: ",
                                           lblTotalStok.Text,
                                           "Diskon: ",
                                           lblDiskon.Text,
                                           "Total harga: ",
                                           lblTotalHarga.Text)
        printPreview(dgDetailFaktur, Home.printDoc, head)
    End Sub
End Class