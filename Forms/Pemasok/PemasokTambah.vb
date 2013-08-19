Public Class PemasokTambah

    Private Sub PemasokTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKodePemasok.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If exec(String.Format("INSERT INTO Pemasok VALUES('{0}', '{1}', '{2}', '{3}')",
                 txtKodePemasok.Text,
                 txtNamaPemasok.Text,
                 txtAlamat.Text,
                 txtKontak.Text)) Then
            MsgBox("Data berhasil ditambah")
            fetchToDatagrid(Pemasok.datagrid, "SELECT * FROM Pemasok")
            Dispose()
        Else
            MsgBox("Silahkan memasukan data dengan benar")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub

    Private Sub txtKodePemasok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodePemasok.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtKodePemasok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodePemasok.TextChanged
        If txtKodePemasok.Text <> "" Then
            If countFetch("SELECT kode FROM Pemasok WHERE kode = '" & txtKodePemasok.Text & "'") > 0 Then
                MsgBox("Silahkan isi kode pemasok yang belum tersedia")
                txtKodePemasok.Focus()
            End If
        End If
    End Sub
End Class