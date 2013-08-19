<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FakturPembelian
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
        Me.panelInput = New System.Windows.Forms.Panel()
        Me.chkFilterTanggal = New System.Windows.Forms.CheckBox()
        Me.dtTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtTglMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.lstFaktur = New System.Windows.Forms.ListBox()
        Me.dgDetailFaktur = New System.Windows.Forms.DataGridView()
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotalStok = New System.Windows.Forms.Label()
        Me.lblNamaPemasok = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTotalBarang = New System.Windows.Forms.Label()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblTotalFaktur = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.btnHapusSemuaFaktur = New System.Windows.Forms.Button()
        Me.btnHapusFaktur = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.panelInput.SuspendLayout()
        CType(Me.dgDetailFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelInput
        '
        Me.panelInput.Controls.Add(Me.chkFilterTanggal)
        Me.panelInput.Controls.Add(Me.dtTglAkhir)
        Me.panelInput.Controls.Add(Me.dtTglMulai)
        Me.panelInput.Controls.Add(Me.Label1)
        Me.panelInput.Controls.Add(Me.cbKategori)
        Me.panelInput.Controls.Add(Me.lstFaktur)
        Me.panelInput.Location = New System.Drawing.Point(3, 2)
        Me.panelInput.Name = "panelInput"
        Me.panelInput.Size = New System.Drawing.Size(193, 223)
        Me.panelInput.TabIndex = 53
        '
        'chkFilterTanggal
        '
        Me.chkFilterTanggal.AutoSize = True
        Me.chkFilterTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFilterTanggal.Location = New System.Drawing.Point(14, 172)
        Me.chkFilterTanggal.Name = "chkFilterTanggal"
        Me.chkFilterTanggal.Size = New System.Drawing.Size(174, 17)
        Me.chkFilterTanggal.TabIndex = 3
        Me.chkFilterTanggal.Text = "Filter berdasarkan tanggal"
        Me.chkFilterTanggal.UseVisualStyleBackColor = True
        '
        'dtTglAkhir
        '
        Me.dtTglAkhir.Enabled = False
        Me.dtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTglAkhir.Location = New System.Drawing.Point(103, 195)
        Me.dtTglAkhir.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTglAkhir.Name = "dtTglAkhir"
        Me.dtTglAkhir.Size = New System.Drawing.Size(79, 20)
        Me.dtTglAkhir.TabIndex = 5
        '
        'dtTglMulai
        '
        Me.dtTglMulai.Enabled = False
        Me.dtTglMulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTglMulai.Location = New System.Drawing.Point(14, 195)
        Me.dtTglMulai.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTglMulai.Name = "dtTglMulai"
        Me.dtTglMulai.Size = New System.Drawing.Size(79, 20)
        Me.dtTglMulai.TabIndex = 4
        Me.dtTglMulai.Value = New Date(2013, 2, 28, 16, 24, 40, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Kategori:"
        '
        'cbKategori
        '
        Me.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Items.AddRange(New Object() {"No. Faktur", "Pemasok", "Periode"})
        Me.cbKategori.Location = New System.Drawing.Point(74, 13)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(108, 21)
        Me.cbKategori.TabIndex = 1
        '
        'lstFaktur
        '
        Me.lstFaktur.FormattingEnabled = True
        Me.lstFaktur.Location = New System.Drawing.Point(14, 45)
        Me.lstFaktur.Name = "lstFaktur"
        Me.lstFaktur.Size = New System.Drawing.Size(165, 121)
        Me.lstFaktur.TabIndex = 2
        '
        'dgDetailFaktur
        '
        Me.dgDetailFaktur.AllowUserToAddRows = False
        Me.dgDetailFaktur.AllowUserToDeleteRows = False
        Me.dgDetailFaktur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgDetailFaktur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgDetailFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetailFaktur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgDetailFaktur.Location = New System.Drawing.Point(204, 8)
        Me.dgDetailFaktur.MultiSelect = False
        Me.dgDetailFaktur.Name = "dgDetailFaktur"
        Me.dgDetailFaktur.ReadOnly = True
        Me.dgDetailFaktur.RowHeadersWidth = 10
        Me.dgDetailFaktur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetailFaktur.Size = New System.Drawing.Size(403, 183)
        Me.dgDetailFaktur.TabIndex = 0
        '
        'panelInfo
        '
        Me.panelInfo.Controls.Add(Me.lblTanggal)
        Me.panelInfo.Controls.Add(Me.Label18)
        Me.panelInfo.Controls.Add(Me.lblTotalStok)
        Me.panelInfo.Controls.Add(Me.lblNamaPemasok)
        Me.panelInfo.Controls.Add(Me.Label21)
        Me.panelInfo.Controls.Add(Me.lblTotalBarang)
        Me.panelInfo.Controls.Add(Me.lblTotalHarga)
        Me.panelInfo.Controls.Add(Me.Label24)
        Me.panelInfo.Controls.Add(Me.Label25)
        Me.panelInfo.Controls.Add(Me.Label26)
        Me.panelInfo.Controls.Add(Me.lblTotalFaktur)
        Me.panelInfo.Controls.Add(Me.label)
        Me.panelInfo.Location = New System.Drawing.Point(615, 2)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(240, 219)
        Me.panelInfo.TabIndex = 107
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(75, 37)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(10, 13)
        Me.lblTanggal.TabIndex = 114
        Me.lblTanggal.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Tanggal :"
        '
        'lblTotalStok
        '
        Me.lblTotalStok.AutoSize = True
        Me.lblTotalStok.Location = New System.Drawing.Point(120, 110)
        Me.lblTotalStok.Name = "lblTotalStok"
        Me.lblTotalStok.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalStok.TabIndex = 112
        Me.lblTotalStok.Text = "-"
        '
        'lblNamaPemasok
        '
        Me.lblNamaPemasok.AutoSize = True
        Me.lblNamaPemasok.Location = New System.Drawing.Point(83, 60)
        Me.lblNamaPemasok.Name = "lblNamaPemasok"
        Me.lblNamaPemasok.Size = New System.Drawing.Size(10, 13)
        Me.lblNamaPemasok.TabIndex = 111
        Me.lblNamaPemasok.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "Pemasok :"
        '
        'lblTotalBarang
        '
        Me.lblTotalBarang.AutoSize = True
        Me.lblTotalBarang.Location = New System.Drawing.Point(96, 84)
        Me.lblTotalBarang.Name = "lblTotalBarang"
        Me.lblTotalBarang.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalBarang.TabIndex = 109
        Me.lblTotalBarang.Text = "-"
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.AutoSize = True
        Me.lblTotalHarga.Location = New System.Drawing.Point(89, 136)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalHarga.TabIndex = 108
        Me.lblTotalHarga.Text = "-"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 107
        Me.Label24.Text = "Total harga :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 13)
        Me.Label25.TabIndex = 106
        Me.Label25.Text = "Total stok terbeli :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 13)
        Me.Label26.TabIndex = 105
        Me.Label26.Text = "Total barang :"
        '
        'lblTotalFaktur
        '
        Me.lblTotalFaktur.AutoSize = True
        Me.lblTotalFaktur.Location = New System.Drawing.Point(88, 14)
        Me.lblTotalFaktur.Name = "lblTotalFaktur"
        Me.lblTotalFaktur.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalFaktur.TabIndex = 104
        Me.lblTotalFaktur.Text = "-"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(15, 14)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(81, 13)
        Me.label.TabIndex = 103
        Me.label.Text = "Total faktur :"
        '
        'btnHapusSemuaFaktur
        '
        Me.btnHapusSemuaFaktur.AutoSize = True
        Me.btnHapusSemuaFaktur.Location = New System.Drawing.Point(490, 199)
        Me.btnHapusSemuaFaktur.Name = "btnHapusSemuaFaktur"
        Me.btnHapusSemuaFaktur.Size = New System.Drawing.Size(117, 23)
        Me.btnHapusSemuaFaktur.TabIndex = 117
        Me.btnHapusSemuaFaktur.Text = "Hapus &Semua Faktur"
        Me.btnHapusSemuaFaktur.UseVisualStyleBackColor = True
        '
        'btnHapusFaktur
        '
        Me.btnHapusFaktur.AutoSize = True
        Me.btnHapusFaktur.Location = New System.Drawing.Point(390, 199)
        Me.btnHapusFaktur.Name = "btnHapusFaktur"
        Me.btnHapusFaktur.Size = New System.Drawing.Size(93, 23)
        Me.btnHapusFaktur.TabIndex = 116
        Me.btnHapusFaktur.Text = "&Hapus Faktur"
        Me.btnHapusFaktur.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.AutoSize = True
        Me.btnCetak.Location = New System.Drawing.Point(204, 199)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(93, 23)
        Me.btnCetak.TabIndex = 118
        Me.btnCetak.Text = "&Cetak Faktur"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'FakturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 230)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnHapusSemuaFaktur)
        Me.Controls.Add(Me.btnHapusFaktur)
        Me.Controls.Add(Me.panelInfo)
        Me.Controls.Add(Me.dgDetailFaktur)
        Me.Controls.Add(Me.panelInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FakturPembelian"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faktur Pembelian"
        Me.panelInput.ResumeLayout(False)
        Me.panelInput.PerformLayout()
        CType(Me.dgDetailFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelInput As System.Windows.Forms.Panel
    Friend WithEvents chkFilterTanggal As System.Windows.Forms.CheckBox
    Friend WithEvents dtTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTglMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lstFaktur As System.Windows.Forms.ListBox
    Friend WithEvents dgDetailFaktur As System.Windows.Forms.DataGridView
    Friend WithEvents panelInfo As System.Windows.Forms.Panel
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblTotalStok As System.Windows.Forms.Label
    Friend WithEvents lblNamaPemasok As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTotalBarang As System.Windows.Forms.Label
    Friend WithEvents lblTotalHarga As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFaktur As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents btnHapusSemuaFaktur As System.Windows.Forms.Button
    Friend WithEvents btnHapusFaktur As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button

End Class
