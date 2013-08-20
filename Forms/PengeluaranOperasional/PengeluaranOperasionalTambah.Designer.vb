<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengeluaranOperasionalTambah
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
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dtTanggalOperasional = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nmHarga = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKeteranganPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJenisPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nmHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(88, 12)
        Me.txtNomor.MaxLength = 5
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(69, 20)
        Me.txtNomor.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nomor:"
        '
        'btnBatal
        '
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(184, 209)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 23)
        Me.btnBatal.TabIndex = 74
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.AutoSize = True
        Me.btnTambah.Location = New System.Drawing.Point(118, 209)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 73
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dtTanggalOperasional
        '
        Me.dtTanggalOperasional.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.dtTanggalOperasional.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalOperasional.Location = New System.Drawing.Point(88, 115)
        Me.dtTanggalOperasional.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTanggalOperasional.Name = "dtTanggalOperasional"
        Me.dtTanggalOperasional.Size = New System.Drawing.Size(153, 20)
        Me.dtTanggalOperasional.TabIndex = 84
        Me.dtTanggalOperasional.Value = New Date(2013, 2, 28, 16, 24, 40, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Tanggal :"
        '
        'nmHarga
        '
        Me.nmHarga.Location = New System.Drawing.Point(88, 89)
        Me.nmHarga.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHarga.Name = "nmHarga"
        Me.nmHarga.Size = New System.Drawing.Size(153, 20)
        Me.nmHarga.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Harga (Rp) :"
        '
        'txtKeteranganPengeluaran
        '
        Me.txtKeteranganPengeluaran.Location = New System.Drawing.Point(88, 141)
        Me.txtKeteranganPengeluaran.Multiline = True
        Me.txtKeteranganPengeluaran.Name = "txtKeteranganPengeluaran"
        Me.txtKeteranganPengeluaran.Size = New System.Drawing.Size(153, 58)
        Me.txtKeteranganPengeluaran.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Keterangan :"
        '
        'txtJenisPengeluaran
        '
        Me.txtJenisPengeluaran.Location = New System.Drawing.Point(88, 63)
        Me.txtJenisPengeluaran.Name = "txtJenisPengeluaran"
        Me.txtJenisPengeluaran.Size = New System.Drawing.Size(153, 20)
        Me.txtJenisPengeluaran.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Jenis :"
        '
        'txtNamaPengeluaran
        '
        Me.txtNamaPengeluaran.Location = New System.Drawing.Point(88, 37)
        Me.txtNamaPengeluaran.Name = "txtNamaPengeluaran"
        Me.txtNamaPengeluaran.Size = New System.Drawing.Size(153, 20)
        Me.txtNamaPengeluaran.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Nama :"
        '
        'PengeluaranOperasionalTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 245)
        Me.Controls.Add(Me.dtTanggalOperasional)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nmHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKeteranganPengeluaran)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJenisPengeluaran)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaPengeluaran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "PengeluaranOperasionalTambah"
        Me.Text = "Tambah Pengeluaran Operasional"
        CType(Me.nmHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dtTanggalOperasional As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nmHarga As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKeteranganPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJenisPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
