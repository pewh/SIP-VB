<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPenjualan
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
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.btnHapusSemua = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEditJumlah = New System.Windows.Forms.Button()
        Me.txtKodeFaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.lstDaftarBarang = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.chkLunas = New System.Windows.Forms.CheckBox()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Location = New System.Drawing.Point(336, 269)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(127, 20)
        Me.txtCariBarang.TabIndex = 119
        '
        'btnHapusSemua
        '
        Me.btnHapusSemua.AutoSize = True
        Me.btnHapusSemua.Enabled = False
        Me.btnHapusSemua.Location = New System.Drawing.Point(94, 304)
        Me.btnHapusSemua.Name = "btnHapusSemua"
        Me.btnHapusSemua.Size = New System.Drawing.Size(84, 23)
        Me.btnHapusSemua.TabIndex = 117
        Me.btnHapusSemua.Text = "Hapus Se&mua"
        Me.btnHapusSemua.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.AutoSize = True
        Me.btnHapus.Enabled = False
        Me.btnHapus.Location = New System.Drawing.Point(12, 304)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(76, 23)
        Me.btnHapus.TabIndex = 116
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEditJumlah
        '
        Me.btnEditJumlah.AutoSize = True
        Me.btnEditJumlah.Location = New System.Drawing.Point(184, 304)
        Me.btnEditJumlah.Name = "btnEditJumlah"
        Me.btnEditJumlah.Size = New System.Drawing.Size(76, 23)
        Me.btnEditJumlah.TabIndex = 115
        Me.btnEditJumlah.Text = "&Edit Jumlah"
        Me.btnEditJumlah.UseVisualStyleBackColor = True
        '
        'txtKodeFaktur
        '
        Me.txtKodeFaktur.Location = New System.Drawing.Point(78, 11)
        Me.txtKodeFaktur.Name = "txtKodeFaktur"
        Me.txtKodeFaktur.Size = New System.Drawing.Size(66, 20)
        Me.txtKodeFaktur.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "No. Nota:"
        '
        'btnBatal
        '
        Me.btnBatal.AutoSize = True
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(408, 304)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 23)
        Me.btnBatal.TabIndex = 110
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.Location = New System.Drawing.Point(335, 304)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(67, 23)
        Me.btnSubmit.TabIndex = 109
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.datagrid.Location = New System.Drawing.Point(12, 64)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(308, 225)
        Me.datagrid.TabIndex = 108
        '
        'lstDaftarBarang
        '
        Me.lstDaftarBarang.FormattingEnabled = True
        Me.lstDaftarBarang.Location = New System.Drawing.Point(335, 64)
        Me.lstDaftarBarang.Name = "lstDaftarBarang"
        Me.lstDaftarBarang.Size = New System.Drawing.Size(128, 199)
        Me.lstDaftarBarang.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Pelanggan:"
        '
        'cbPelanggan
        '
        Me.cbPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(227, 11)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(93, 21)
        Me.cbPelanggan.TabIndex = 123
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.AutoSize = True
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(224, 41)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(28, 13)
        Me.lblNamaPelanggan.TabIndex = 124
        Me.lblNamaPelanggan.Text = "XXX"
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(81, 38)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(66, 20)
        Me.txtDiskon.TabIndex = 126
        Me.txtDiskon.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Diskon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(372, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 13)
        Me.lblTotal.TabIndex = 128
        Me.lblTotal.Text = "Rp.0"
        '
        'chkLunas
        '
        Me.chkLunas.AutoSize = True
        Me.chkLunas.Checked = True
        Me.chkLunas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunas.Location = New System.Drawing.Point(266, 308)
        Me.chkLunas.Name = "chkLunas"
        Me.chkLunas.Size = New System.Drawing.Size(67, 17)
        Me.chkLunas.TabIndex = 134
        Me.chkLunas.Text = "Lunas?"
        Me.chkLunas.UseVisualStyleBackColor = True
        '
        'TransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 342)
        Me.Controls.Add(Me.chkLunas)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCariBarang)
        Me.Controls.Add(Me.btnHapusSemua)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEditJumlah)
        Me.Controls.Add(Me.txtKodeFaktur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.lstDaftarBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransaksiPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaksi Penjualan"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnHapusSemua As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEditJumlah As System.Windows.Forms.Button
    Friend WithEvents txtKodeFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents lstDaftarBarang As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents txtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents chkLunas As System.Windows.Forms.CheckBox
End Class
