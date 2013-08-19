Public Class TransaksiPembelian

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

    Private Sub TransaksiPembelian_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        FakturPembelian.refreshData()
    End Sub

    Private Sub TransaksiPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fetchToCombobox(cbPemasok, "SELECT kode FROM Pemasok")
        If cbPemasok.Items.Count > 0 Then
            cbPemasok.SelectedIndex = 0
        End If
        dtTanggal.CustomFormat = "yyy-MM-dd HH:mm:ss"

        With bufferTable.Columns
            .Add("Kode", GetType(String))
            .Add("Nama", GetType(String))
            .Add("Stok", GetType(Integer))
            .Add("Harga", GetType(Integer))
            .Add("Total", GetType(Integer))
        End With

        datagrid.DataSource = bufferTable
    End Sub

    Private Sub cbPemasok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPemasok.SelectedIndexChanged
        If datagrid.RowCount > 0 Then
            If cbPemasok.SelectedIndex <> prevSelectedIndex Then
                If MsgBox("Mengganti kode pemasok dapat menyebabkan faktur akan dihapus. Apakah Anda yakin?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                    txtCariBarang.Clear()
                    fetchToListbox(lstDaftarBarang, "SELECT Barang.nama FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode WHERE NOT Barang.kode LIKE '%_deleted%' AND Pemasok.kode = '" & cbPemasok.Text & "'")
                    bufferTable.Clear()
                    datagrid.DataSource = bufferTable
                Else
                    cbPemasok.SelectedIndex = prevSelectedIndex
                End If
            End If
        Else
            txtCariBarang.Clear()
            fetchToListbox(lstDaftarBarang, "SELECT Barang.nama FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode WHERE NOT Barang.kode LIKE '%_deleted%' AND Pemasok.kode = '" & cbPemasok.Text & "'")
        End If

        prevSelectedIndex = cbPemasok.SelectedIndex
    End Sub

    Private Sub txtCariBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariBarang.TextChanged
        Dim query As String = "SELECT Barang.nama FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode WHERE NOT Barang.kode LIKE '%_deleted%' AND Pemasok.kode = '" & cbPemasok.Text & "'"

        If txtCariBarang.Text <> "" Then
            query &= " AND Barang.nama LIKE '%" & txtCariBarang.Text & "%'"
        End If

        fetchToListbox(lstDaftarBarang, query)
    End Sub

    Private Sub lstDaftarBarang_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDaftarBarang.DoubleClick
        Dim fetchedTable As DataTable = fetch("SELECT * FROM BarangTersedia WHERE nama LIKE '" & lstDaftarBarang.SelectedItem & "'")
        Dim row As DataRow = bufferTable.NewRow
        Dim stokInput As String = InputBox("Berapa stok yang diinginkan?", fetchedTable.Rows(0).Item("nama"), "0")
        Dim stok As Integer
        Dim isDataExists As Boolean = False

        Try
            stok = Integer.Parse(stokInput)

            If stok > 0 Then
                Dim kode As String = fetchedTable.Rows(0).Item("kode")
                Dim namaBarang As String = fetchedTable.Rows(0).Item("nama")
                Dim harga As Integer = fetchedTable.Rows(0).Item("harga_beli")
                Dim total As Integer = 0

                For index = 0 To datagrid.Rows.Count - 1
                    If datagrid.Item("kode", index).Value = kode Then
                        bufferTable.Rows(index)("stok") += stok
                        bufferTable.Rows(index)("total") = bufferTable.Rows(index)("stok") * bufferTable.Rows(index)("harga")
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
        If txtKodeFaktur.Text <> "" And bufferTable.Rows.Count > 0 Then
            If submitToDatabasePembelian(bufferTable, txtKodeFaktur.Text, dtTanggal.Value, chkLunas.Checked) = True Then
                MsgBox("Faktur pembelian sudah diterima")
                Dispose()
            Else
                MsgBox("Faktur pembelian tidak bisa disimpan")
            End If
        Else
            MsgBox("Silahkan mengisi kode faktur dan memilih barang yang mau dibeli")
        End If
    End Sub

    Private Sub txtKodeFaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeFaktur.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtKodeFaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeFaktur.TextChanged
        If countFetch("SELECT kode FROM FakturBeli WHERE kode = '" & txtKodeFaktur.Text & "'") > 0 Then
            MsgBox("Kode faktur sudah ada.")
        End If
    End Sub

    Private Sub btnEditJumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditJumlah.Click
        Try
            Dim stok As Integer = Integer.Parse(InputBox("Berapa stok yang diinginkan?", "Stok", "0"))

            If stok <= 0 Then
                MsgBox("Stok yang diinginkan tidak valid")
            Else
                bufferTable.Rows(datagrid.CurrentRow.Index)("stok") = stok
                bufferTable.Rows(datagrid.CurrentRow.Index)("total") = bufferTable.Rows(datagrid.CurrentRow.Index)("stok") * bufferTable.Rows(datagrid.CurrentRow.Index)("harga")
            End If
        Catch ex As Exception
            MsgBox("Input stok tidak valid")
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub
End Class