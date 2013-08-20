Public Class Barang

    Dim heightWithoutGroupbox As Integer = 315

    Sub showDetailData()
        Dim selectedQuery As String = String.Format("SELECT * FROM ShowAllItems WHERE kode = '{0}'", datagrid.SelectedCells(0).Value)
        Dim fetchedQuery As DataTable = fetch(selectedQuery)

        If fetchedQuery.Rows.Count > 0 Then
            With fetchedQuery.Rows(0)
                lblKodeBarang.Text = .Item("kode")
                txtNamaBarang.Text = .Item("nama")
                cbKodePemasok.SelectedItem = .Item("kode_pemasok") & " | " & .Item("nama_pemasok")
                lblNamaPemasok.Text = .Item("nama_pemasok")
                nmStokBarang.Value = .Item("stok")
                nmHargaBeli.Value = .Item("harga_beli")
                nmHargaJual.Value = .Item("harga_jual")
            End With
        End If

        btnReset.Enabled = False
    End Sub

    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbDetail.Visible = False
        Height = heightWithoutGroupbox

        fetchToCombobox(cbKodePemasok, "SELECT kode + ' | ' + nama FROM Pemasok")
        fetchToDatagrid(datagrid, "SELECT * FROM ShowAllItems WHERE NOT kode LIKE '%_deleted%' ORDER BY nama", 3, 7)

        cbCari.SelectedIndex = 0
    End Sub

    Private Sub datagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid.CellClick
        If chkEditMode.Checked = True Then
            showDetailData()
        End If
    End Sub

    Private Sub datagrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datagrid.KeyUp
        If chkEditMode.Checked = True Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
                showDetailData()
            End If
        End If
    End Sub

    Private Sub cbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCari.SelectedIndexChanged
        With txtCari
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        fetchToDatagrid(datagrid, String.Format(
                "SELECT * FROM ShowAllItems WHERE NOT kode LIKE '%_deleted%' AND {0} LIKE '%{1}%'",
                cbCari.Text,
                txtCari.Text))
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If datagrid.Rows.Count > 0 Then
            Dim kodeBarang As String = "'" & datagrid.SelectedCells(0).Value & "'"

            If MsgBox("Apakah Anda yakin untuk menghapus?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                If exec("SafelyDeleteItem " & kodeBarang) = False Then
                    MsgBox("Gagal menghapus barang. Coba lagi.")
                End If

                fetchToDatagrid(datagrid, "SELECT * FROM ShowAllItems WHERE NOT kode LIKE '%_deleted%' ORDER BY nama")
            End If
        End If
    End Sub

    Private Sub chkEditMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEditMode.CheckedChanged
        If chkEditMode.Checked And datagrid.Rows.Count > 0 Then
            gbDetail.Visible = True
            Height = heightWithoutGroupbox + gbDetail.Height + 15
            showDetailData()
        Else
            gbDetail.Visible = False
            Height = heightWithoutGroupbox
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        BarangTambah.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim query As String = String.Format("AlterSelectedItem '{0}', '{1}', {2}, '{3}', {4}, {5}",
                                           lblKodeBarang.Text,
                                           txtNamaBarang.Text,
                                           nmStokBarang.Value,
                                           cbKodePemasok.Text.Split(" | ")(0),
                                           nmHargaBeli.Value,
                                           nmHargaJual.Value)

        If exec(query) = True Then
            MsgBox("Data berhasil diubah")
            fetchToDatagrid(datagrid, "SELECT * FROM ShowAllItems WHERE NOT kode LIKE '%_deleted%' ORDER BY nama")
        Else
            MsgBox("Data tidak bisa diubah")
            showDetailData()
        End If

        btnReset.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        showDetailData()
    End Sub

    Private Sub txtNamaBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaBarang.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub nmStokBarang_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmStokBarang.ValueChanged
        btnReset.Enabled = True
    End Sub

    Private Sub nmHargaBeli_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmHargaBeli.ValueChanged
        btnReset.Enabled = True
    End Sub

    Private Sub nmHargaJual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmHargaJual.ValueChanged
        btnReset.Enabled = True
    End Sub

    Private Sub cbKodePemasok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKodePemasok.SelectedIndexChanged
        btnReset.Enabled = True

        lblNamaPemasok.Text = fetchOne(String.Format(
                                "SELECT TOP 1 nama FROM Pemasok WHERE kode = '{0}'",
                                cbKodePemasok.Text.Split(" | ")(0)))
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        printPreview(datagrid, Home.printDoc, "Daftar Barang")
    End Sub
End Class