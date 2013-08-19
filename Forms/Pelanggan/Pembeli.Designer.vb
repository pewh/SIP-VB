<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembeli
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
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.txtAlamatPelanggan = New System.Windows.Forms.TextBox()
        Me.chkEditMode = New System.Windows.Forms.CheckBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.lblKodePelanggan = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(63, 91)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(179, 20)
        Me.txtKontak.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Kontak :"
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.datagrid.Location = New System.Drawing.Point(12, 37)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(261, 202)
        Me.datagrid.TabIndex = 3
        '
        'txtAlamatPelanggan
        '
        Me.txtAlamatPelanggan.Location = New System.Drawing.Point(63, 65)
        Me.txtAlamatPelanggan.Name = "txtAlamatPelanggan"
        Me.txtAlamatPelanggan.Size = New System.Drawing.Size(179, 20)
        Me.txtAlamatPelanggan.TabIndex = 9
        '
        'chkEditMode
        '
        Me.chkEditMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEditMode.Location = New System.Drawing.Point(200, 251)
        Me.chkEditMode.Name = "chkEditMode"
        Me.chkEditMode.Size = New System.Drawing.Size(72, 24)
        Me.chkEditMode.TabIndex = 7
        Me.chkEditMode.Text = "&Edit Mode"
        Me.chkEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEditMode.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(172, 10)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(101, 20)
        Me.txtCari.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Cari berdasarkan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Alamat :"
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Location = New System.Drawing.Point(185, 126)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(59, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(12, 252)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(119, 126)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbCari
        '
        Me.cbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Items.AddRange(New Object() {"Nama", "Kode"})
        Me.cbCari.Location = New System.Drawing.Point(109, 10)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(57, 21)
        Me.cbCari.TabIndex = 2
        '
        'lblKodePelanggan
        '
        Me.lblKodePelanggan.AutoSize = True
        Me.lblKodePelanggan.Location = New System.Drawing.Point(60, 16)
        Me.lblKodePelanggan.Name = "lblKodePelanggan"
        Me.lblKodePelanggan.Size = New System.Drawing.Size(28, 13)
        Me.lblKodePelanggan.TabIndex = 26
        Me.lblKodePelanggan.Text = "XXX"
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(63, 39)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(179, 20)
        Me.txtNamaPelanggan.TabIndex = 8
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.SystemColors.Control
        Me.gbDetail.Controls.Add(Me.txtKontak)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.txtAlamatPelanggan)
        Me.gbDetail.Controls.Add(Me.Label3)
        Me.gbDetail.Controls.Add(Me.btnReset)
        Me.gbDetail.Controls.Add(Me.btnSimpan)
        Me.gbDetail.Controls.Add(Me.lblKodePelanggan)
        Me.gbDetail.Controls.Add(Me.txtNamaPelanggan)
        Me.gbDetail.Controls.Add(Me.Label2)
        Me.gbDetail.Controls.Add(Me.Label1)
        Me.gbDetail.Location = New System.Drawing.Point(12, 289)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Size = New System.Drawing.Size(261, 167)
        Me.gbDetail.TabIndex = 42
        Me.gbDetail.TabStop = False
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
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kode :"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(78, 252)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(56, 23)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(140, 252)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(56, 23)
        Me.btnCetak.TabIndex = 6
        Me.btnCetak.Text = "&Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 465)
        Me.Controls.Add(Me.btnCetak)
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
        Me.Name = "Pembeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembeli"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtAlamatPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents chkEditMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents cbCari As System.Windows.Forms.ComboBox
    Friend WithEvents lblKodePelanggan As System.Windows.Forms.Label
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents gbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
