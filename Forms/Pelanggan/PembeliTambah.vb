Public Class PembeliTambah

    Private Sub PembeliTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKodePembeli.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If exec(String.Format("INSERT INTO Pembeli VALUES('{0}', '{1}', '{2}', '{3}')",
                 txtKodePembeli.Text,
                 txtNamaPembeli.Text,
                 txtAlamat.Text,
                 txtKontak.Text)) Then
            MsgBox("Data berhasil ditambah")
            fetchToDatagrid(Pembeli.datagrid, "SELECT * FROM Pembeli")
            Dispose()
        Else
            MsgBox("Silahkan memasukan data dengan benar")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub

    Private Sub txtKodePembeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodePembeli.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtKodePembeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodePembeli.TextChanged
        If txtKodePembeli.Text <> "" Then
            If countFetch("SELECT kode FROM Pembeli WHERE kode = '" & txtKodePembeli.Text & "'") > 0 Then
                MsgBox("Silahkan isi kode pemasok yang belum tersedia")
                txtKodePembeli.Focus()
            End If
        End If
    End Sub
End Class