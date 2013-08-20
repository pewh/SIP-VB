<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.menuToolbar = New System.Windows.Forms.ToolStrip()
        Me.menuBarang = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuPemasok = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuPembeli = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFakturBeli = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFakturJual = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuTransaksiPembelian = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuTransaksiPenjualan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuStatusTransaksi = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuLunasBelumTransaksiPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLunasBelumTransaksiPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuLaporanLabaRugi = New System.Windows.Forms.ToolStripButton()
        Me.picBG = New System.Windows.Forms.PictureBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuPengeluaranOperasional = New System.Windows.Forms.ToolStripButton()
        Me.menuToolbar.SuspendLayout()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'printDoc
        '
        '
        'menuToolbar
        '
        Me.menuToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuBarang, Me.ToolStripSeparator1, Me.menuPemasok, Me.ToolStripSeparator2, Me.menuPembeli, Me.ToolStripSeparator3, Me.menuFakturBeli, Me.ToolStripSeparator4, Me.menuFakturJual, Me.ToolStripSeparator5, Me.menuTransaksiPembelian, Me.ToolStripSeparator6, Me.menuTransaksiPenjualan, Me.ToolStripSeparator9, Me.menuPengeluaranOperasional, Me.ToolStripSeparator7, Me.menuStatusTransaksi, Me.ToolStripSeparator8, Me.menuLaporanLabaRugi})
        Me.menuToolbar.Location = New System.Drawing.Point(0, 0)
        Me.menuToolbar.Name = "menuToolbar"
        Me.menuToolbar.Size = New System.Drawing.Size(905, 25)
        Me.menuToolbar.TabIndex = 41
        Me.menuToolbar.Text = "Home"
        '
        'menuBarang
        '
        Me.menuBarang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuBarang.Image = CType(resources.GetObject("menuBarang.Image"), System.Drawing.Image)
        Me.menuBarang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuBarang.Name = "menuBarang"
        Me.menuBarang.Size = New System.Drawing.Size(45, 22)
        Me.menuBarang.Text = "B&arang"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'menuPemasok
        '
        Me.menuPemasok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuPemasok.Image = CType(resources.GetObject("menuPemasok.Image"), System.Drawing.Image)
        Me.menuPemasok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuPemasok.Name = "menuPemasok"
        Me.menuPemasok.Size = New System.Drawing.Size(53, 22)
        Me.menuPemasok.Text = "P&emasok"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'menuPembeli
        '
        Me.menuPembeli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuPembeli.Image = CType(resources.GetObject("menuPembeli.Image"), System.Drawing.Image)
        Me.menuPembeli.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuPembeli.Name = "menuPembeli"
        Me.menuPembeli.Size = New System.Drawing.Size(47, 22)
        Me.menuPembeli.Text = "Pe&mbeli"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'menuFakturBeli
        '
        Me.menuFakturBeli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuFakturBeli.Image = CType(resources.GetObject("menuFakturBeli.Image"), System.Drawing.Image)
        Me.menuFakturBeli.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuFakturBeli.Name = "menuFakturBeli"
        Me.menuFakturBeli.Size = New System.Drawing.Size(61, 22)
        Me.menuFakturBeli.Text = "Faktur &Beli"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'menuFakturJual
        '
        Me.menuFakturJual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuFakturJual.Image = CType(resources.GetObject("menuFakturJual.Image"), System.Drawing.Image)
        Me.menuFakturJual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuFakturJual.Name = "menuFakturJual"
        Me.menuFakturJual.Size = New System.Drawing.Size(64, 22)
        Me.menuFakturJual.Text = "Faktur &Jual"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'menuTransaksiPembelian
        '
        Me.menuTransaksiPembelian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuTransaksiPembelian.Image = CType(resources.GetObject("menuTransaksiPembelian.Image"), System.Drawing.Image)
        Me.menuTransaksiPembelian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuTransaksiPembelian.Name = "menuTransaksiPembelian"
        Me.menuTransaksiPembelian.Size = New System.Drawing.Size(107, 22)
        Me.menuTransaksiPembelian.Text = "&Transaksi Pembelian"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'menuTransaksiPenjualan
        '
        Me.menuTransaksiPenjualan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuTransaksiPenjualan.Image = CType(resources.GetObject("menuTransaksiPenjualan.Image"), System.Drawing.Image)
        Me.menuTransaksiPenjualan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuTransaksiPenjualan.Name = "menuTransaksiPenjualan"
        Me.menuTransaksiPenjualan.Size = New System.Drawing.Size(106, 22)
        Me.menuTransaksiPenjualan.Text = "T&ransaksi Penjualan"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'menuStatusTransaksi
        '
        Me.menuStatusTransaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuStatusTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLunasBelumTransaksiPembelian, Me.menuLunasBelumTransaksiPenjualan})
        Me.menuStatusTransaksi.Image = CType(resources.GetObject("menuStatusTransaksi.Image"), System.Drawing.Image)
        Me.menuStatusTransaksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuStatusTransaksi.Name = "menuStatusTransaksi"
        Me.menuStatusTransaksi.Size = New System.Drawing.Size(83, 22)
        Me.menuStatusTransaksi.Text = "Lunas/Belum"
        '
        'menuLunasBelumTransaksiPembelian
        '
        Me.menuLunasBelumTransaksiPembelian.Name = "menuLunasBelumTransaksiPembelian"
        Me.menuLunasBelumTransaksiPembelian.Size = New System.Drawing.Size(181, 22)
        Me.menuLunasBelumTransaksiPembelian.Text = "Transaksi Pembelian"
        '
        'menuLunasBelumTransaksiPenjualan
        '
        Me.menuLunasBelumTransaksiPenjualan.Name = "menuLunasBelumTransaksiPenjualan"
        Me.menuLunasBelumTransaksiPenjualan.Size = New System.Drawing.Size(181, 22)
        Me.menuLunasBelumTransaksiPenjualan.Text = "Transaksi Penjualan"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'menuLaporanLabaRugi
        '
        Me.menuLaporanLabaRugi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuLaporanLabaRugi.Image = CType(resources.GetObject("menuLaporanLabaRugi.Image"), System.Drawing.Image)
        Me.menuLaporanLabaRugi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuLaporanLabaRugi.Name = "menuLaporanLabaRugi"
        Me.menuLaporanLabaRugi.Size = New System.Drawing.Size(100, 22)
        Me.menuLaporanLabaRugi.Text = "Laporan Lapa Rugi"
        '
        'picBG
        '
        Me.picBG.Image = Global.MarketStore.My.Resources.Resources.logo
        Me.picBG.Location = New System.Drawing.Point(37, 100)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(93, 54)
        Me.picBG.TabIndex = 43
        Me.picBG.TabStop = False
        Me.picBG.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'menuPengeluaranOperasional
        '
        Me.menuPengeluaranOperasional.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuPengeluaranOperasional.Image = CType(resources.GetObject("menuPengeluaranOperasional.Image"), System.Drawing.Image)
        Me.menuPengeluaranOperasional.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuPengeluaranOperasional.Name = "menuPengeluaranOperasional"
        Me.menuPengeluaranOperasional.Size = New System.Drawing.Size(131, 22)
        Me.menuPengeluaranOperasional.Text = "Pengeluaran Operasional"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 25)
        Me.Controls.Add(Me.picBG)
        Me.Controls.Add(Me.menuToolbar)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Home"
        Me.menuToolbar.ResumeLayout(False)
        Me.menuToolbar.PerformLayout()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents menuToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents menuBarang As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuPemasok As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuPembeli As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuFakturBeli As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuFakturJual As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuTransaksiPembelian As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuTransaksiPenjualan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents picBG As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuStatusTransaksi As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuLunasBelumTransaksiPembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLunasBelumTransaksiPenjualan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLaporanLabaRugi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuPengeluaranOperasional As System.Windows.Forms.ToolStripButton
End Class
