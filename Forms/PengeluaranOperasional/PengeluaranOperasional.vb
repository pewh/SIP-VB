Public Class PengeluaranOperasional

    Dim widthWithoutGroupbox As Integer = 502

    Sub showDetailData()
            Dim selectedQuery As String = String.Format("SELECT * FROM PengeluaranOperasional WHERE nomor = '{0}'", datagrid.SelectedCells(0).Value)
            Dim fetchedQuery As DataTable = fetch(selectedQuery)

            If fetchedQuery.Rows.Count > 0 Then
                With fetchedQuery.Rows(0)
                lblNomorPengeluaran.Text = .Item("nomor")
                    txtNamaPengeluaran.Text = .Item("nama")
                    txtJenisPengeluaran.Text = .Item("jenis")
                    nmHarga.Text = .Item("harga")
                    dtTanggalOperasional.Value = .Item("tanggal")
                    txtKeteranganPengeluaran.Text = .Item("keterangan")
                End With
            End If

            btnReset.Enabled = False
    End Sub

    Private Sub PengeluaranOperasional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbDetail.Visible = False
        Width = widthWithoutGroupbox

        fetchToDatagrid(datagrid, "SELECT * FROM PengeluaranOperasional")

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
                "SELECT * FROM PengeluaranOperasional WHERE {0} LIKE '%{1}%'",
                cbCari.Text,
                txtCari.Text))
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        PengeluaranOperasionalTambah.ShowDialog()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If datagrid.Rows.Count > 0 Then
            If MsgBox("Apakah Anda yakin untuk menghapus?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                Dim kodeOperasional As String = "'" & datagrid.SelectedCells(0).Value & "'"

                If exec("DELETE FROM PengeluaranOperasional WHERE nomor = " & kodeOperasional) = False Then
                    MsgBox("Gagal menghapus data. Silahkan coba lagi.")
                End If

                fetchToDatagrid(datagrid, "SELECT * FROM PengeluaranOperasional")
            End If
        End If
    End Sub

    Private Sub chkEditMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEditMode.CheckedChanged
        If chkEditMode.Checked And datagrid.Rows.Count > 0 Then
            gbDetail.Visible = True
            Width = widthWithoutGroupbox + gbDetail.Width + 15
            showDetailData()
        Else
            gbDetail.Visible = False
            Width = widthWithoutGroupbox
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim query As String = String.Format("UPDATE PengeluaranOperasional SET nama = '{0}', jenis = '{1}', harga = {2}, tanggal = '{3}', keterangan = '{4}' WHERE nomor = '{5}'",
                                           txtNamaPengeluaran.Text,
                                           txtJenisPengeluaran.Text,
                                           nmHarga.Text,
                                           dtTanggalOperasional.Value,
                                           txtKeteranganPengeluaran.Text,
                                           lblNomorPengeluaran.Text)

        If exec(query) = True Then
            MsgBox("Data berhasil diubah")
            fetchToDatagrid(datagrid, "SELECT * FROM PengeluaranOperasional")
        Else
            MsgBox("Data tidak bisa diubah")
            showDetailData()
        End If

        btnReset.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        showDetailData()
    End Sub

    Private Sub txtNamaPengeluaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaPengeluaran.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub txtJenisPengeluaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJenisPengeluaran.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub nmHarga_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmHarga.ValueChanged
        btnReset.Enabled = True
    End Sub

    Private Sub dtTanggalOperasional_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTanggalOperasional.ValueChanged
        btnReset.Enabled = True
    End Sub

    Private Sub txtKeteranganPengeluaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeteranganPengeluaran.TextChanged
        btnReset.Enabled = True
    End Sub
End Class