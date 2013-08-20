Public Class Pemasok

    Dim heightWithoutGroupbox As Integer = 313

    Sub showDetailData()
        Dim selectedQuery As String = String.Format("SELECT * FROM Pemasok WHERE kode = '{0}'", datagrid.SelectedCells(0).Value)
        Dim fetchedQuery As DataTable = fetch(selectedQuery)

        If fetchedQuery.Rows.Count > 0 Then
            With fetchedQuery.Rows(0)
                lblKodePemasok.Text = .Item("kode")
                txtNamaPemasok.Text = .Item("nama")
                txtAlamatPemasok.Text = .Item("alamat")
                txtKontak.Text = .Item("kontak")
            End With
        End If

        btnReset.Enabled = False
    End Sub

    Private Sub Pemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbDetail.Visible = False
        Height = heightWithoutGroupbox

        fetchToDatagrid(datagrid, "SELECT * FROM Pemasok ORDER BY nama")

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
                "SELECT * FROM Pemasok WHERE {0} LIKE '%{1}%'",
                cbCari.Text,
                txtCari.Text))
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        PemasokTambah.ShowDialog()
    End Sub

    Private Sub btnHapus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If datagrid.Rows.Count > 0 Then
            Dim kodePemasok As String = "'" & datagrid.SelectedCells(0).Value & "'"
            
            If MsgBox("Apakah Anda yakin untuk menghapus?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                If exec("DELETE FROM Pemasok WHERE kode = " & kodePemasok) = False Then
                    MsgBox("Gagal menghapus data. Silahkan coba lagi.")
                End If
            End If

            fetchToDatagrid(datagrid, "SELECT * FROM Pemasok ORDER BY nama")
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

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim query As String = String.Format("UPDATE Pemasok SET nama = '{0}', alamat = '{1}', kontak = '{2}' WHERE kode = '{3}'",
                                           txtNamaPemasok.Text,
                                           txtAlamatPemasok.Text,
                                           txtKontak.Text,
                                           lblKodePemasok.Text)

        If exec(query) = True Then
            MsgBox("Data berhasil diubah")
            fetchToDatagrid(datagrid, "SELECT * FROM Pemasok ORDER BY nama")
        Else
            MsgBox("Data tidak bisa diubah")
            showDetailData()
        End If

        btnReset.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        showDetailData()
    End Sub

    Private Sub txtNamaPemasok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaPemasok.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub txtAlamatPemasok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlamatPemasok.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub txtKontak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKontak.TextChanged
        btnReset.Enabled = True
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        printPreview(datagrid, Home.printDoc, "Daftar pemasok")
    End Sub
End Class