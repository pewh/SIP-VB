Public Class PengeluaranOperasionalTambah

    Private Sub PengeluaranOperasionalTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNomor.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If exec(String.Format("INSERT INTO PengeluaranOperasional VALUES('{0}', '{1}', '{2}', {3}, '{4}', '{5}')",
                 txtNomor.Text,
                 txtNamaPengeluaran.Text,
                 txtJenisPengeluaran.Text,
                 nmHarga.Value,
                 dtTanggalOperasional.Value,
                 txtKeteranganPengeluaran.Text)) Then
            MsgBox("Pengeluaran operasional berhasil ditambah")
            fetchToDatagrid(PengeluaranOperasional.datagrid, "SELECT * FROM PengeluaranOperasional")
            Dispose()
        Else
            MsgBox("Silahkan memasukan data dengan benar")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub

    Private Sub txtNomor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomor.KeyPress
        preventSpecialChar(e)
    End Sub

    Private Sub txtNomor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomor.Leave
        If txtNomor.Text <> "" Then
            If countFetch("SELECT nomor FROM PengeluaranOperasional WHERE nomor = '" & txtNomor.Text & "'") > 0 Then
                MsgBox("Silahkan isi nomor yang belum tersedia")
                txtNomor.Focus()
            End If
        End If
    End Sub
    
End Class