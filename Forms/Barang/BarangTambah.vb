Public Class BarangTambah

    Private Sub BarangTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKodeBarang.Focus()
        fetchToCombobox(cbKodePemasok, "SELECT kode + ' | ' + nama FROM Pemasok")
        If cbKodePemasok.Items.Count > 0 Then
            cbKodePemasok.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If exec(String.Format("AddNewItems '{0}', '{1}', '{2}', {3}, {4}",
                 txtKodeBarang.Text,
                 txtNamaBarang.Text,
                 cbKodePemasok.Text.Split(" | ")(0),
                 nmHargaBeli.Value,
                 nmHargaJual.Value)) Then
            MsgBox("Barang berhasil ditambah")
            fetchToDatagrid(Barang.datagrid, "SELECT * FROM ShowAllItems WHERE NOT kode LIKE '%_deleted'")
            Dispose()
        Else
            MsgBox("Silahkan memasukan data dengan benar")
        End If
    End Sub

    Private Sub cbKodePemasok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKodePemasok.SelectedIndexChanged
        lblNamaPemasok.Text = fetchOne(String.Format(
                                "SELECT TOP 1 nama FROM Pemasok WHERE kode = '{0}'",
                                cbKodePemasok.Text.Split(" | ")(0)))
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub

    Private Sub txtKodeBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtKodeBarang_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKodeBarang.Leave
        If txtKodeBarang.Text <> "" Then
            If countFetch("SELECT kode FROM Barang WHERE kode = '" & txtKodeBarang.Text & "'") > 0 Then
                MsgBox("Silahkan isi kode barang yang belum tersedia")
                txtKodeBarang.Focus()
            End If
        End If
    End Sub
End Class