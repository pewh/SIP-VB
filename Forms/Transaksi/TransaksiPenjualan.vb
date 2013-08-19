Public Class TransaksiPenjualan

    Dim bufferTable As New DataTable
    Dim prevSelectedIndex As Integer = 0

    Sub disableClearButtonIfEmpty()
        If datagrid.RowCount = 0 Then
            btnHapus.Enabled = False
            btnHapusSemua.Enabled = False
        Else
            btnHapus.Enabled = True
            btnHapusSemua.Enabled = True
        End If
    End Sub

    Private Sub TransaksiPenjualan_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        FakturPembelian.refreshData()
    End Sub

    Private Sub TransaksiPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fetchToCombobox(cbPelanggan, "SELECT kode + ' | ' + nama FROM Pembeli")

        If cbPelanggan.Items.Count > 0 Then
            cbPelanggan.SelectedIndex = 0
        End If

        With bufferTable.Columns
            .Add("Kode", GetType(String))
            .Add("Nama", GetType(String))
            .Add("Stok", GetType(Integer))
            .Add("Harga", GetType(Integer))
            .Add("Total", GetType(Integer))
        End With

        datagrid.DataSource = bufferTable

        fetchToListbox(lstDaftarBarang, "SELECT nama FROM Barang WHERE NOT kode LIKE '%_deleted%'")
    End Sub

    Private Sub cbPelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPelanggan.SelectedIndexChanged
        If datagrid.RowCount > 0 Then
            If cbPelanggan.SelectedIndex <> prevSelectedIndex Then
                If MsgBox("Mengganti nama pelanggan dapat menyebabkan faktur akan dihapus. Apakah Anda yakin?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                    txtCariBarang.Clear()
                    bufferTable.Clear()
                    datagrid.DataSource = bufferTable
                Else
                    cbPelanggan.SelectedIndex = prevSelectedIndex
                End If
            End If
        Else
            txtCariBarang.Clear()
        End If

        prevSelectedIndex = cbPelanggan.SelectedIndex

        lblNamaPelanggan.Text = cbPelanggan.Text.Split(" | ")(2)
    End Sub

    Private Sub txtCariBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariBarang.TextChanged
        Dim query As String = "SELECT nama FROM Barang WHERE NOT Barang.kode LIKE '%_deleted%'"

        If txtCariBarang.Text <> "" Then
            query &= " AND nama LIKE '%" & txtCariBarang.Text & "%'"
        End If

        fetchToListbox(lstDaftarBarang, query)
    End Sub

    Private Sub lstDaftarBarang_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDaftarBarang.DoubleClick
        Dim fetchedTable As DataTable = fetch("SELECT * FROM BarangTersedia WHERE nama LIKE '" & lstDaftarBarang.SelectedItem & "'")
        Dim row As DataRow = bufferTable.NewRow
        Dim stokInput As String = InputBox("Berapa stok yang diinginkan?", fetchedTable.Rows(0).Item("nama"), "0")
        Dim stok As Integer
        Dim maxStok As Integer = Integer.Parse(fetch("SELECT stok FROM Barang WHERE nama ='" & lstDaftarBarang.SelectedItem & "'").Rows(0).Item(0))
        Dim isDataExists As Boolean = False

        Try
            stok = Integer.Parse(stokInput)

            If stok > 0 And stok <= maxStok Then
                Dim kode As String = fetchedTable.Rows(0).Item("kode")
                Dim namaBarang As String = fetchedTable.Rows(0).Item("nama")
                Dim harga As Integer = fetchedTable.Rows(0).Item("harga_jual")
                Dim total As Integer = 0

                For index = 0 To datagrid.Rows.Count - 1
                    If datagrid.Item("kode", index).Value = kode Then
                        ' ensure demand stok is not more than available stok
                        Dim bufferCollectedStok As Integer = bufferTable.Rows(index)("stok") + stok

                        If bufferCollectedStok > maxStok Then
                            MsgBox("Jumlah stok melebihi kuota")
                        Else
                            bufferTable.Rows(index)("stok") = bufferCollectedStok
                            bufferTable.Rows(index)("total") = bufferTable.Rows(index)("stok") * bufferTable.Rows(index)("harga")
                        End If
                        isDataExists = True
                    End If
                Next

                If isDataExists = False Then
                    row("Kode") = kode
                    row("Nama") = namaBarang
                    row("Stok") = stok
                    row("Harga") = harga
                    row("Total") = stok * harga

                    bufferTable.Rows.Add(row)
                End If

                For index = 0 To bufferTable.Rows.Count - 1
                    total += bufferTable.Rows(index)("Total")
                Next

                lblTotal.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
                datagrid.DataSource = bufferTable
            Else
                MsgBox("Jumlah stok melebihi kuota")
            End If
        Catch ex As Exception
            MsgBox("Jumlah stok tidak valid")
        End Try

        disableClearButtonIfEmpty()
    End Sub

    Private Sub btnHapusSemua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusSemua.Click
        If MsgBox("Apakah Anda yakin untuk menghapus daftar transaksi?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
            bufferTable.Clear()
            datagrid.DataSource = bufferTable
            disableClearButtonIfEmpty()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda yakin untuk menghapus '" & datagrid.Item(1, datagrid.CurrentRow.Index).Value & "' dari daftar transaksi?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
            bufferTable.Rows(datagrid.CurrentRow.Index).Delete()
            datagrid.DataSource = bufferTable
            disableClearButtonIfEmpty()
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try
            If txtKodeFaktur.Text <> "" And txtDiskon.Text <> "" And bufferTable.Rows.Count > 0 Then
                If submitToDatabasePenjualan(bufferTable, txtKodeFaktur.Text, cbPelanggan.Text.Split(" | ")(0), Integer.Parse(txtDiskon.Text), chkLunas.Checked) = True Then
                    MsgBox("Faktur penjualan sudah diterima")
                    Dispose()
                Else
                    MsgBox("Faktur penjualan tidak bisa disimpan")
                End If
            Else
                MsgBox("Silahkan mengisi kode faktur dan memilih barang yang mau dibeli")
            End If
        Catch ex As Exception
            MsgBox("Input diskon tidak valid")
        End Try
    End Sub

    Private Sub txtKodeFaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeFaktur.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtKodeFaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeFaktur.TextChanged
        If countFetch("SELECT kode FROM FakturJual WHERE kode = '" & txtKodeFaktur.Text & "'") > 0 Then
            MsgBox("Kode faktur sudah ada.")
        End If
    End Sub

    Private Sub btnEditJumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditJumlah.Click
        Try
            Dim stok As Integer = Integer.Parse(InputBox("Berapa stok yang diinginkan?", "Stok", "0"))
            Dim maxStok As Integer = Integer.Parse(fetch("SELECT stok FROM Barang WHERE nama ='" & lstDaftarBarang.SelectedItem & "'").Rows(0).Item(0))
            Dim total As Integer = 0

            If stok > maxStok Then
                MsgBox("Stok yang diinginkan melebihi kuota")
            ElseIf stok <= 0 Then
                MsgBox("Stok yang diinginkan tidak valid")
            Else
                bufferTable.Rows(datagrid.CurrentRow.Index)("stok") = stok
                bufferTable.Rows(datagrid.CurrentRow.Index)("total") = bufferTable.Rows(datagrid.CurrentRow.Index)("stok") * bufferTable.Rows(datagrid.CurrentRow.Index)("harga")

                For index = 0 To bufferTable.Rows.Count - 1
                    total += bufferTable.Rows(index)("Total")
                Next

                lblTotal.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            End If
        Catch ex As Exception
            MsgBox("Input stok tidak valid")
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub
End Class