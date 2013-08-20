<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkEditMode = New System.Windows.Forms.CheckBox()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.nmHargaJual = New System.Windows.Forms.NumericUpDown()
        Me.nmHargaBeli = New System.Windows.Forms.NumericUpDown()
        Me.lblNamaPemasok = New System.Windows.Forms.Label()
        Me.nmStokBarang = New System.Windows.Forms.NumericUpDown()
        Me.cbKodePemasok = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetail.SuspendLayout()
        CType(Me.nmHargaJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmHargaBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmStokBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(302, 250)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(57, 23)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.datagrid.Location = New System.Drawing.Point(13, 13)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(538, 225)
        Me.datagrid.TabIndex = 1
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(365, 250)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(51, 23)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(171, 252)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(121, 20)
        Me.txtCari.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Cari berdasarkan:"
        '
        'chkEditMode
        '
        Me.chkEditMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEditMode.Location = New System.Drawing.Point(479, 250)
        Me.chkEditMode.Name = "chkEditMode"
        Me.chkEditMode.Size = New System.Drawing.Size(72, 24)
        Me.chkEditMode.TabIndex = 7
        Me.chkEditMode.Text = "&Edit Mode"
        Me.chkEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEditMode.UseVisualStyleBackColor = True
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.SystemColors.Control
        Me.gbDetail.Controls.Add(Me.btnReset)
        Me.gbDetail.Controls.Add(Me.btnSimpan)
        Me.gbDetail.Controls.Add(Me.Label11)
        Me.gbDetail.Controls.Add(Me.Label10)
        Me.gbDetail.Controls.Add(Me.Label9)
        Me.gbDetail.Controls.Add(Me.lblKodeBarang)
        Me.gbDetail.Controls.Add(Me.nmHargaJual)
        Me.gbDetail.Controls.Add(Me.nmHargaBeli)
        Me.gbDetail.Controls.Add(Me.lblNamaPemasok)
        Me.gbDetail.Controls.Add(Me.nmStokBarang)
        Me.gbDetail.Controls.Add(Me.cbKodePemasok)
        Me.gbDetail.Controls.Add(Me.Label7)
        Me.gbDetail.Controls.Add(Me.Label6)
        Me.gbDetail.Controls.Add(Me.Label5)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.Label3)
        Me.gbDetail.Controls.Add(Me.txtNamaBarang)
        Me.gbDetail.Controls.Add(Me.Label2)
        Me.gbDetail.Controls.Add(Me.Label1)
        Me.gbDetail.Location = New System.Drawing.Point(13, 288)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Size = New System.Drawing.Size(538, 151)
        Me.gbDetail.TabIndex = 26
        Me.gbDetail.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Location = New System.Drawing.Point(457, 118)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(59, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(391, 118)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(346, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Pemasok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(203, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(8, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Barang"
        '
        'lblKodeBarang
        '
        Me.lblKodeBarang.AutoSize = True
        Me.lblKodeBarang.Location = New System.Drawing.Point(56, 51)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(28, 13)
        Me.lblKodeBarang.TabIndex = 26
        Me.lblKodeBarang.Text = "XXX"
        '
        'nmHargaJual
        '
        Me.nmHargaJual.Location = New System.Drawing.Point(244, 75)
        Me.nmHargaJual.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHargaJual.Name = "nmHargaJual"
        Me.nmHargaJual.Size = New System.Drawing.Size(87, 20)
        Me.nmHargaJual.TabIndex = 11
        '
        'nmHargaBeli
        '
        Me.nmHargaBeli.Location = New System.Drawing.Point(244, 49)
        Me.nmHargaBeli.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHargaBeli.Name = "nmHargaBeli"
        Me.nmHargaBeli.Size = New System.Drawing.Size(87, 20)
        Me.nmHargaBeli.TabIndex = 10
        '
        'lblNamaPemasok
        '
        Me.lblNamaPemasok.AutoSize = True
        Me.lblNamaPemasok.Location = New System.Drawing.Point(394, 77)
        Me.lblNamaPemasok.Name = "lblNamaPemasok"
        Me.lblNamaPemasok.Size = New System.Drawing.Size(28, 13)
        Me.lblNamaPemasok.TabIndex = 23
        Me.lblNamaPemasok.Text = "XXX"
        '
        'nmStokBarang
        '
        Me.nmStokBarang.Location = New System.Drawing.Point(59, 100)
        Me.nmStokBarang.Name = "nmStokBarang"
        Me.nmStokBarang.Size = New System.Drawing.Size(42, 20)
        Me.nmStokBarang.TabIndex = 9
        '
        'cbKodePemasok
        '
        Me.cbKodePemasok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKodePemasok.FormattingEnabled = True
        Me.cbKodePemasok.Location = New System.Drawing.Point(397, 48)
        Me.cbKodePemasok.Name = "cbKodePemasok"
        Me.cbKodePemasok.Size = New System.Drawing.Size(119, 21)
        Me.cbKodePemasok.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Jual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Beli:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nama :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Kode :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Stok :"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(59, 74)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(124, 20)
        Me.txtNamaBarang.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kode :"
        '
        'cbCari
        '
        Me.cbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Items.AddRange(New Object() {"Nama", "Kode"})
        Me.cbCari.Location = New System.Drawing.Point(108, 252)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(57, 21)
        Me.cbCari.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(565, 449)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 291
        Me.LineShape1.X2 = 291
        Me.LineShape1.Y1 = 283
        Me.LineShape1.Y2 = 305
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(422, 251)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(51, 23)
        Me.btnCetak.TabIndex = 6
        Me.btnCetak.Text = "&Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 449)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkEditMode)
        Me.Controls.Add(Me.gbDetail)
        Me.Controls.Add(Me.cbCari)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        CType(Me.nmHargaJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmHargaBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmStokBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkEditMode As System.Windows.Forms.CheckBox
    Friend WithEvents gbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents lblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents nmHargaJual As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmHargaBeli As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNamaPemasok As System.Windows.Forms.Label
    Friend WithEvents nmStokBarang As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbKodePemasok As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCari As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
