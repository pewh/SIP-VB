<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPembelian
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
        Me.lstDaftarBarang = New System.Windows.Forms.ListBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtKodeFaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditJumlah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnHapusSemua = New System.Windows.Forms.Button()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.cbPemasok = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.chkLunas = New System.Windows.Forms.CheckBox()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDaftarBarang
        '
        Me.lstDaftarBarang.FormattingEnabled = True
        Me.lstDaftarBarang.Location = New System.Drawing.Point(338, 73)
        Me.lstDaftarBarang.Name = "lstDaftarBarang"
        Me.lstDaftarBarang.Size = New System.Drawing.Size(128, 173)
        Me.lstDaftarBarang.TabIndex = 0
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.datagrid.Location = New System.Drawing.Point(15, 47)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(308, 225)
        Me.datagrid.TabIndex = 53
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.Location = New System.Drawing.Point(338, 287)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(67, 23)
        Me.btnSubmit.TabIndex = 54
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.AutoSize = True
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(411, 287)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 23)
        Me.btnBatal.TabIndex = 55
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtKodeFaktur
        '
        Me.txtKodeFaktur.Location = New System.Drawing.Point(81, 16)
        Me.txtKodeFaktur.MaxLength = 5
        Me.txtKodeFaktur.Name = "txtKodeFaktur"
        Me.txtKodeFaktur.Size = New System.Drawing.Size(66, 20)
        Me.txtKodeFaktur.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "No. Faktur:"
        '
        'btnEditJumlah
        '
        Me.btnEditJumlah.AutoSize = True
        Me.btnEditJumlah.Location = New System.Drawing.Point(187, 287)
        Me.btnEditJumlah.Name = "btnEditJumlah"
        Me.btnEditJumlah.Size = New System.Drawing.Size(76, 23)
        Me.btnEditJumlah.TabIndex = 102
        Me.btnEditJumlah.Text = "&Edit Jumlah"
        Me.btnEditJumlah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.AutoSize = True
        Me.btnHapus.Enabled = False
        Me.btnHapus.Location = New System.Drawing.Point(15, 287)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(76, 23)
        Me.btnHapus.TabIndex = 103
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnHapusSemua
        '
        Me.btnHapusSemua.AutoSize = True
        Me.btnHapusSemua.Enabled = False
        Me.btnHapusSemua.Location = New System.Drawing.Point(97, 287)
        Me.btnHapusSemua.Name = "btnHapusSemua"
        Me.btnHapusSemua.Size = New System.Drawing.Size(84, 23)
        Me.btnHapusSemua.TabIndex = 104
        Me.btnHapusSemua.Text = "Hapus Se&mua"
        Me.btnHapusSemua.UseVisualStyleBackColor = True
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Location = New System.Drawing.Point(339, 252)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(127, 20)
        Me.txtCariBarang.TabIndex = 106
        '
        'cbPemasok
        '
        Me.cbPemasok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPemasok.FormattingEnabled = True
        Me.cbPemasok.Location = New System.Drawing.Point(338, 47)
        Me.cbPemasok.Name = "cbPemasok"
        Me.cbPemasok.Size = New System.Drawing.Size(128, 21)
        Me.cbPemasok.TabIndex = 105
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(385, 19)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 13)
        Me.lblTotal.TabIndex = 130
        Me.lblTotal.Text = "Rp.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(347, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Tanggal:"
        '
        'dtTanggal
        '
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(206, 13)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.ShowUpDown = True
        Me.dtTanggal.Size = New System.Drawing.Size(129, 20)
        Me.dtTanggal.TabIndex = 132
        '
        'chkLunas
        '
        Me.chkLunas.AutoSize = True
        Me.chkLunas.Checked = True
        Me.chkLunas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunas.Location = New System.Drawing.Point(270, 292)
        Me.chkLunas.Name = "chkLunas"
        Me.chkLunas.Size = New System.Drawing.Size(67, 17)
        Me.chkLunas.TabIndex = 133
        Me.chkLunas.Text = "Lunas?"
        Me.chkLunas.UseVisualStyleBackColor = True
        '
        'TransaksiPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(481, 322)
        Me.Controls.Add(Me.chkLunas)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCariBarang)
        Me.Controls.Add(Me.cbPemasok)
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
        Me.Name = "TransaksiPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaksi Pembelian"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDaftarBarang As System.Windows.Forms.ListBox
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtKodeFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEditJumlah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnHapusSemua As System.Windows.Forms.Button
    Friend WithEvents txtCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents cbPemasok As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkLunas As System.Windows.Forms.CheckBox
End Class
