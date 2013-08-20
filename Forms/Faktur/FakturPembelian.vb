Public Class FakturPembelian

    Sub refreshData()
        ' Declare init variable
        Dim fakturQuery As String

        ' Set query based on combobox's index
        Select Case cbKategori.SelectedIndex
            Case 0
                fakturQuery = "SELECT kode FROM FakturBeli"
                If chkFilterTanggal.Checked Then
                    fakturQuery &= String.Format(" WHERE tanggal BETWEEN '{0}' AND '{1}'", dtTglMulai.Value, dtTglAkhir.Value)
                End If
            Case 1
                fakturQuery = "SELECT DISTINCT nama_pemasok FROM DetailFakturPembelian"
                If chkFilterTanggal.Checked Then
                    fakturQuery &= String.Format(" WHERE tanggal_faktur BETWEEN '{0}' AND '{1}'", dtTglMulai.Value, dtTglAkhir.Value)
                End If
            Case 2
                fakturQuery = "SELECT DISTINCT DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur) AS bulanan FROM DetailFakturPembelian"
            Case Else 'redirect to 0 if out of range
                fakturQuery = "SELECT kode FROM FakturBeli"
        End Select
        
        fetchToListbox(lstFaktur, fakturQuery)

        lblTotalFaktur.Text = lstFaktur.Items.Count
    End Sub

    Private Sub FakturPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbKategori.SelectedIndex = 0
    End Sub

    Private Sub cbKategoriPembelian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKategori.SelectedIndexChanged
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

    Private Sub dtTglMulaiPembelian_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglMulai.ValueChanged
        refreshData()
    End Sub

    Private Sub dtTglAkhirPembelian_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglAkhir.ValueChanged
        refreshData()
    End Sub

    Private Sub chkFilterTanggalPembelian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFilterTanggal.CheckedChanged
        If chkFilterTanggal.Checked Then
            dtTglMulai.Enabled = True
            dtTglAkhir.Enabled = True
        Else
            dtTglMulai.Enabled = False
            dtTglAkhir.Enabled = False
        End If

        refreshData()
    End Sub

    Private Sub lstFakturPembelian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFaktur.SelectedIndexChanged
        Dim suffix, totalItem, harga As String
        Dim hargaBeli As Integer

        btnCetak.Enabled = True
        btnHapusFaktur.Enabled = True
        btnHapusSemuaFaktur.Enabled = True
        dgDetailFaktur.Enabled = True

        Select Case cbKategori.SelectedIndex
            Case 0
                suffix = " kode_faktur = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerbeliPerFaktur"
                harga = "TotalHargaPembelianPerFaktur"
            Case 1
                suffix = " nama_pemasok = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerbeliPerPemasok"
                harga = "TotalHargaPembelianPerPemasok"
            Case 2
                suffix = " (DateName(Year, tanggal_faktur) + ' ' + DateName(Month, tanggal_faktur)) = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerbeliPerBulan"
                harga = "TotalHargaPembelianPerBulan"
            Case Else
                suffix = " kode_faktur = '" & lstFaktur.SelectedItem & "'"
                totalItem = "TotalItemTerbeliPerFaktur"
                harga = "TotalHargaPerFaktur"
        End Select

        fetchToDatagrid(dgDetailFaktur, "SELECT * FROM DetailFakturPembelian WHERE" & suffix, 0, 1, 2, 3, 6, 9)

        If cbKategori.SelectedIndex = 2 Then ' periode
            lblNamaPemasok.Text = "-"
            lblTanggal.Text = "-"
        Else
            lblNamaPemasok.Text = fetchOne("SELECT nama_pemasok FROM DetailFakturPembelian WHERE" & suffix)
            lblTanggal.Text = fetchOne("SELECT tanggal_faktur FROM DetailFakturPembelian WHERE" & suffix)
        End If

        ' It gives warning
        hargaBeli = Integer.Parse(fetchOne("SELECT harga FROM " & harga & " WHERE" & suffix))

        lblTotalStok.Text = fetchOne("SELECT total_barang FROM " & totalItem & " WHERE" & suffix)
        lblTotalBarang.Text = dgDetailFaktur.RowCount
        lblTotalHarga.Text = hargaBeli.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim head As String = String.Format("{1}{0}{0}{2}{3}{0}{4}{5}{0}{6}{7}{0}{8}{9}{0}{10}{11}{0}{12}{13}{0}{14}{15}",
                                           vbCrLf,
                                           "Faktur Pembelian",
                                           cbKategori.Text + ": ",
                                           lstFaktur.SelectedItem,
                                           "Total faktur: ",
                                           lblTotalFaktur.Text,
                                           "Tanggal: ",
                                           lblTanggal.Text,
                                           "Pemasok: ",
                                           lblNamaPemasok.Text,
                                           "Total barang: ",
                                           lblTotalBarang.Text,
                                           "Total stok terbeli: ",
                                           lblTotalStok.Text,
                                           "Total harga: ",
                                           lblTotalHarga.Text)
        printPreview(dgDetailFaktur, Home.printDoc, head)
    End Sub

    Private Sub btnHapusFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusFaktur.Click
        If lstFaktur.Items.Count > 0 Then
            If MsgBox("Apakah Anda yakin untuk menghapus faktur " & lstFaktur.SelectedItem & "?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                If exec("HapusFakturBeli '" & lstFaktur.SelectedItem & "', 1") = True Then
                    MsgBox("Faktur berhasil dihapus")
                Else
                    MsgBox("Faktur tidak bisa dihapus")
                End If
            End If

            refreshData()
        End If
    End Sub

    Private Sub btnHapusSemuaFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusSemuaFaktur.Click
        If MsgBox("Apakah Anda yakin untuk menghapus semua faktur?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
            If exec("HapusSemuaFakturBeli 1") = True Then
                MsgBox("Faktur berhasil dihapus")
            Else
                MsgBox("Faktur tidak bisa dihapus")
            End If
        End If

        refreshData()
    End Sub
End Class
