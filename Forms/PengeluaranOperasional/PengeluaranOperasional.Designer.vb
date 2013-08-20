<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengeluaranOperasional
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNamaPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomorPengeluaran = New System.Windows.Forms.Label()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtKeteranganPengeluaran = New System.Windows.Forms.TextBox()
        Me.chkEditMode = New System.Windows.Forms.CheckBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtJenisPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.dtTanggalOperasional = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nmHarga = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetail.SuspendLayout()
        CType(Me.nmHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNamaPengeluaran
        '
        Me.txtNamaPengeluaran.Location = New System.Drawing.Point(89, 39)
        Me.txtNamaPengeluaran.Name = "txtNamaPengeluaran"
        Me.txtNamaPengeluaran.Size = New System.Drawing.Size(153, 20)
        Me.txtNamaPengeluaran.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nomor :"
        '
        'lblNomorPengeluaran
        '
        Me.lblNomorPengeluaran.AutoSize = True
        Me.lblNomorPengeluaran.Location = New System.Drawing.Point(86, 16)
        Me.lblNomorPengeluaran.Name = "lblNomorPengeluaran"
        Me.lblNomorPengeluaran.Size = New System.Drawing.Size(28, 13)
        Me.lblNomorPengeluaran.TabIndex = 26
        Me.lblNomorPengeluaran.Text = "XXX"
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.datagrid.Location = New System.Drawing.Point(12, 34)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(475, 223)
        Me.datagrid.TabIndex = 49
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(353, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(56, 23)
        Me.btnHapus.TabIndex = 51
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtKeteranganPengeluaran
        '
        Me.txtKeteranganPengeluaran.Location = New System.Drawing.Point(89, 143)
        Me.txtKeteranganPengeluaran.Multiline = True
        Me.txtKeteranganPengeluaran.Name = "txtKeteranganPengeluaran"
        Me.txtKeteranganPengeluaran.Size = New System.Drawing.Size(153, 58)
        Me.txtKeteranganPengeluaran.TabIndex = 10
        '
        'chkEditMode
        '
        Me.chkEditMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEditMode.Location = New System.Drawing.Point(415, 3)
        Me.chkEditMode.Name = "chkEditMode"
        Me.chkEditMode.Size = New System.Drawing.Size(72, 24)
        Me.chkEditMode.TabIndex = 53
        Me.chkEditMode.Text = "&Edit Mode"
        Me.chkEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEditMode.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(172, 7)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(101, 20)
        Me.txtCari.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Cari berdasarkan:"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(287, 4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 50
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtJenisPengeluaran
        '
        Me.txtJenisPengeluaran.Location = New System.Drawing.Point(89, 65)
        Me.txtJenisPengeluaran.Name = "txtJenisPengeluaran"
        Me.txtJenisPengeluaran.Size = New System.Drawing.Size(153, 20)
        Me.txtJenisPengeluaran.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Jenis :"
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Location = New System.Drawing.Point(183, 212)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(59, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Keterangan :"
        '
        'cbCari
        '
        Me.cbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Items.AddRange(New Object() {"Nama", "Nomor", "Jenis"})
        Me.cbCari.Location = New System.Drawing.Point(109, 7)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(57, 21)
        Me.cbCari.TabIndex = 48
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.SystemColors.Control
        Me.gbDetail.Controls.Add(Me.dtTanggalOperasional)
        Me.gbDetail.Controls.Add(Me.Label5)
        Me.gbDetail.Controls.Add(Me.nmHarga)
        Me.gbDetail.Controls.Add(Me.Label6)
        Me.gbDetail.Controls.Add(Me.txtKeteranganPengeluaran)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.txtJenisPengeluaran)
        Me.gbDetail.Controls.Add(Me.Label3)
        Me.gbDetail.Controls.Add(Me.btnReset)
        Me.gbDetail.Controls.Add(Me.btnSimpan)
        Me.gbDetail.Controls.Add(Me.lblNomorPengeluaran)
        Me.gbDetail.Controls.Add(Me.txtNamaPengeluaran)
        Me.gbDetail.Controls.Add(Me.Label2)
        Me.gbDetail.Controls.Add(Me.Label1)
        Me.gbDetail.Location = New System.Drawing.Point(499, 7)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Size = New System.Drawing.Size(261, 250)
        Me.gbDetail.TabIndex = 54
        Me.gbDetail.TabStop = False
        '
        'dtTanggalOperasional
        '
        Me.dtTanggalOperasional.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.dtTanggalOperasional.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalOperasional.Location = New System.Drawing.Point(89, 117)
        Me.dtTanggalOperasional.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTanggalOperasional.Name = "dtTanggalOperasional"
        Me.dtTanggalOperasional.Size = New System.Drawing.Size(153, 20)
        Me.dtTanggalOperasional.TabIndex = 40
        Me.dtTanggalOperasional.Value = New Date(2013, 2, 28, 16, 24, 40, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tanggal :"
        '
        'nmHarga
        '
        Me.nmHarga.Location = New System.Drawing.Point(89, 91)
        Me.nmHarga.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHarga.Name = "nmHarga"
        Me.nmHarga.Size = New System.Drawing.Size(153, 20)
        Me.nmHarga.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Harga (Rp) :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(117, 212)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'PengeluaranOperasional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 270)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.chkEditMode)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cbCari)
        Me.Controls.Add(Me.gbDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PengeluaranOperasional"
        Me.Text = "Pengeluaran Operasional"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        CType(Me.nmHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNamaPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNomorPengeluaran As System.Windows.Forms.Label
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtKeteranganPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents chkEditMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtJenisPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCari As System.Windows.Forms.ComboBox
    Friend WithEvents gbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents nmHarga As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtTanggalOperasional As System.Windows.Forms.DateTimePicker
End Class
