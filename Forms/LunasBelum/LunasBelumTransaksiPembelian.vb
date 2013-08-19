Public Class LunasBelumTransaksiPembelian

    Private Sub filtering()
        Dim criteria As String = ""

        If txtCari.Text <> "" Or
            cbCari.SelectedIndex <> 0 Or
            chkFilterTanggal.Checked Then

            Dim filterCriteria As New List(Of String)()

            If txtCari.Text <> "" Then
                filterCriteria.Add("kode LIKE '%" + txtCari.Text + "%'")
            End If

            If cbCari.SelectedIndex <> 0 Then
                Dim statusLunas As Integer

                If cbCari.SelectedIndex = 1 Then
                    statusLunas = 1
                ElseIf cbCari.SelectedIndex = 2 Then
                    statusLunas = 0
                End If

                filterCriteria.Add("lunas = " & statusLunas)
            End If

            If chkFilterTanggal.Checked Then
                filterCriteria.Add(String.Format(
                    "tanggal BETWEEN('{0}', '{1}')",
                    dtTglMulai,
                    dtTglAkhir
                ))
            End If

            criteria = String.Join(" AND ", filterCriteria)
            fetchToDatagrid(datagrid, "SELECT tanggal, kode, lunas FROM FakturBeli WHERE " + criteria + " ORDER BY tanggal DESC")
        Else
            fetchToDatagrid(datagrid, "SELECT tanggal, kode, lunas FROM FakturBeli ORDER BY tanggal DESC")
        End If

        If datagrid.Rows.Count > 0 Then
            datagrid.Columns(0).ReadOnly = True
            datagrid.Columns(1).ReadOnly = True
        End If
    End Sub

    Private Sub LunasBelumTransaksiPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbCari.SelectedIndex = 0
    End Sub

    Private Sub datagrid_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid.CellValueChanged
        Dim selectedDatagrid As Object = datagrid.Rows(e.RowIndex)
        Dim kodeFaktur As String = selectedDatagrid.Cells(1).Value
        Dim statusLunas As Integer

        If selectedDatagrid.Cells(2).Value = True Then
            statusLunas = 1
        Else
            statusLunas = 0
        End If

        Dim query As String = String.Format("UPDATE FakturBeli SET lunas = {0} WHERE kode = '{1}'", statusLunas, kodeFaktur)

        exec(query)
    End Sub

    Private Sub chkFilterTanggal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFilterTanggal.CheckedChanged
        If chkFilterTanggal.Checked Then
            dtTglMulai.Enabled = True
            dtTglAkhir.Enabled = True
        Else
            dtTglMulai.Enabled = False
            dtTglAkhir.Enabled = False
        End If
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        filtering()
    End Sub

    Private Sub cbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCari.SelectedIndexChanged
        filtering()
    End Sub

    Private Sub dtTglMulai_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglMulai.ValueChanged
        filtering()
    End Sub

    Private Sub dtTglAkhir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTglAkhir.ValueChanged
        filtering()
    End Sub
End Class