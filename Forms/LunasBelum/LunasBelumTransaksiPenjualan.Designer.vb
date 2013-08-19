<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LunasBelumTransaksiPenjualan
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.chkFilterTanggal = New System.Windows.Forms.CheckBox()
        Me.dtTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.dtTglMulai = New System.Windows.Forms.DateTimePicker()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(70, 11)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(131, 20)
        Me.txtCari.TabIndex = 113
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.datagrid.Location = New System.Drawing.Point(12, 12)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.RowHeadersWidth = 10
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(220, 264)
        Me.datagrid.TabIndex = 113
        '
        'chkFilterTanggal
        '
        Me.chkFilterTanggal.AutoSize = True
        Me.chkFilterTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFilterTanggal.Location = New System.Drawing.Point(12, 15)
        Me.chkFilterTanggal.Name = "chkFilterTanggal"
        Me.chkFilterTanggal.Size = New System.Drawing.Size(174, 17)
        Me.chkFilterTanggal.TabIndex = 9
        Me.chkFilterTanggal.Text = "Filter berdasarkan tanggal"
        Me.chkFilterTanggal.UseVisualStyleBackColor = True
        '
        'dtTglAkhir
        '
        Me.dtTglAkhir.Enabled = False
        Me.dtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTglAkhir.Location = New System.Drawing.Point(115, 38)
        Me.dtTglAkhir.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTglAkhir.Name = "dtTglAkhir"
        Me.dtTglAkhir.Size = New System.Drawing.Size(96, 20)
        Me.dtTglAkhir.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Filter lunas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Kode:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbCari)
        Me.Panel1.Location = New System.Drawing.Point(12, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 71)
        Me.Panel1.TabIndex = 115
        '
        'cbCari
        '
        Me.cbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Items.AddRange(New Object() {"Semua", "Lunas", "Tidak Lunas"})
        Me.cbCari.Location = New System.Drawing.Point(70, 40)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(131, 21)
        Me.cbCari.TabIndex = 112
        '
        'panelInfo
        '
        Me.panelInfo.Controls.Add(Me.chkFilterTanggal)
        Me.panelInfo.Controls.Add(Me.dtTglAkhir)
        Me.panelInfo.Controls.Add(Me.dtTglMulai)
        Me.panelInfo.Location = New System.Drawing.Point(12, 359)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(220, 71)
        Me.panelInfo.TabIndex = 114
        '
        'dtTglMulai
        '
        Me.dtTglMulai.Enabled = False
        Me.dtTglMulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTglMulai.Location = New System.Drawing.Point(12, 38)
        Me.dtTglMulai.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtTglMulai.Name = "dtTglMulai"
        Me.dtTglMulai.Size = New System.Drawing.Size(97, 20)
        Me.dtTglMulai.TabIndex = 10
        Me.dtTglMulai.Value = New Date(2013, 2, 28, 16, 24, 40, 0)
        '
        'LunasBelumTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 442)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LunasBelumTransaksiPenjualan"
        Me.Text = "Status Transaksi Penjualan"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents chkFilterTanggal As System.Windows.Forms.CheckBox
    Friend WithEvents dtTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbCari As System.Windows.Forms.ComboBox
    Friend WithEvents panelInfo As System.Windows.Forms.Panel
    Friend WithEvents dtTglMulai As System.Windows.Forms.DateTimePicker
End Class
