<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangTambah
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
        Me.nmHargaJual = New System.Windows.Forms.NumericUpDown()
        Me.nmHargaBeli = New System.Windows.Forms.NumericUpDown()
        Me.lblNamaPemasok = New System.Windows.Forms.Label()
        Me.cbKodePemasok = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        CType(Me.nmHargaJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmHargaBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nmHargaJual
        '
        Me.nmHargaJual.Location = New System.Drawing.Point(104, 90)
        Me.nmHargaJual.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHargaJual.Name = "nmHargaJual"
        Me.nmHargaJual.Size = New System.Drawing.Size(105, 20)
        Me.nmHargaJual.TabIndex = 34
        '
        'nmHargaBeli
        '
        Me.nmHargaBeli.Location = New System.Drawing.Point(104, 64)
        Me.nmHargaBeli.Maximum = New Decimal(New Integer() {500000000, 0, 0, 0})
        Me.nmHargaBeli.Name = "nmHargaBeli"
        Me.nmHargaBeli.Size = New System.Drawing.Size(105, 20)
        Me.nmHargaBeli.TabIndex = 32
        '
        'lblNamaPemasok
        '
        Me.lblNamaPemasok.Location = New System.Drawing.Point(101, 148)
        Me.lblNamaPemasok.Name = "lblNamaPemasok"
        Me.lblNamaPemasok.Size = New System.Drawing.Size(145, 39)
        Me.lblNamaPemasok.TabIndex = 41
        Me.lblNamaPemasok.Text = "-"
        '
        'cbKodePemasok
        '
        Me.cbKodePemasok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKodePemasok.FormattingEnabled = True
        Me.cbKodePemasok.Location = New System.Drawing.Point(104, 119)
        Me.cbKodePemasok.Name = "cbKodePemasok"
        Me.cbKodePemasok.Size = New System.Drawing.Size(142, 21)
        Me.cbKodePemasok.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Harga Jual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Harga Beli:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nama Pemasok:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Kode Pemasok:"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(104, 37)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(142, 20)
        Me.txtNamaBarang.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nama Barang:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Kode Barang:"
        '
        'btnTambah
        '
        Me.btnTambah.AutoSize = True
        Me.btnTambah.Location = New System.Drawing.Point(121, 206)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 37
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(104, 11)
        Me.txtKodeBarang.MaxLength = 5
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(69, 20)
        Me.txtKodeBarang.TabIndex = 28
        '
        'btnBatal
        '
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(187, 206)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 23)
        Me.btnBatal.TabIndex = 38
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'BarangTambah
        '
        Me.AcceptButton = Me.btnTambah
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(258, 241)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.nmHargaJual)
        Me.Controls.Add(Me.nmHargaBeli)
        Me.Controls.Add(Me.lblNamaPemasok)
        Me.Controls.Add(Me.cbKodePemasok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarangTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Barang Baru"
        CType(Me.nmHargaJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmHargaBeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nmHargaJual As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmHargaBeli As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNamaPemasok As System.Windows.Forms.Label
    Friend WithEvents cbKodePemasok As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
