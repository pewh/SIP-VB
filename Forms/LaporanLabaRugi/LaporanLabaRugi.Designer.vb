<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanLabaRugi
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
        Me.lstFaktur = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPeriode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPenjualanPeriode = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBiayaOperasionalPeriode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblTotalPembelianPeriode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblTotalPengeluaranPeriode = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPengeluaran = New System.Windows.Forms.Label()
        Me.lblTotalPembelian = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalPenjualan = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblBiayaOperasional = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFaktur
        '
        Me.lstFaktur.FormattingEnabled = True
        Me.lstFaktur.Location = New System.Drawing.Point(12, 12)
        Me.lstFaktur.Name = "lstFaktur"
        Me.lstFaktur.Size = New System.Drawing.Size(138, 329)
        Me.lstFaktur.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalPengeluaranPeriode)
        Me.GroupBox2.Controls.Add(Me.lblTotalPembelianPeriode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotalPeriode)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblTotalPenjualanPeriode)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblBiayaOperasionalPeriode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox2.Location = New System.Drawing.Point(165, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 162)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Per periode"
        '
        'lblTotalPeriode
        '
        Me.lblTotalPeriode.AutoSize = True
        Me.lblTotalPeriode.Location = New System.Drawing.Point(126, 124)
        Me.lblTotalPeriode.Name = "lblTotalPeriode"
        Me.lblTotalPeriode.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPeriode.TabIndex = 16
        Me.lblTotalPeriode.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Keuntungan:"
        '
        'lblTotalPenjualanPeriode
        '
        Me.lblTotalPenjualanPeriode.AutoSize = True
        Me.lblTotalPenjualanPeriode.Location = New System.Drawing.Point(124, 94)
        Me.lblTotalPenjualanPeriode.Name = "lblTotalPenjualanPeriode"
        Me.lblTotalPenjualanPeriode.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPenjualanPeriode.TabIndex = 14
        Me.lblTotalPenjualanPeriode.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Penjualan:"
        '
        'lblBiayaOperasionalPeriode
        '
        Me.lblBiayaOperasionalPeriode.AutoSize = True
        Me.lblBiayaOperasionalPeriode.Location = New System.Drawing.Point(124, 21)
        Me.lblBiayaOperasionalPeriode.Name = "lblBiayaOperasionalPeriode"
        Me.lblBiayaOperasionalPeriode.Size = New System.Drawing.Size(10, 13)
        Me.lblBiayaOperasionalPeriode.TabIndex = 12
        Me.lblBiayaOperasionalPeriode.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Biaya Operasional:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(214, 143)
        Me.ShapeContainer2.TabIndex = 17
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 203
        Me.LineShape2.Y1 = 101
        Me.LineShape2.Y2 = 101
        '
        'lblTotalPembelianPeriode
        '
        Me.lblTotalPembelianPeriode.AutoSize = True
        Me.lblTotalPembelianPeriode.Location = New System.Drawing.Point(124, 42)
        Me.lblTotalPembelianPeriode.Name = "lblTotalPembelianPeriode"
        Me.lblTotalPembelianPeriode.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPembelianPeriode.TabIndex = 19
        Me.lblTotalPembelianPeriode.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total Pembelian:"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 11
        Me.LineShape3.X2 = 203
        Me.LineShape3.Y1 = 46
        Me.LineShape3.Y2 = 46
        '
        'lblTotalPengeluaranPeriode
        '
        Me.lblTotalPengeluaranPeriode.AutoSize = True
        Me.lblTotalPengeluaranPeriode.Location = New System.Drawing.Point(124, 71)
        Me.lblTotalPengeluaranPeriode.Name = "lblTotalPengeluaranPeriode"
        Me.lblTotalPengeluaranPeriode.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPengeluaranPeriode.TabIndex = 20
        Me.lblTotalPengeluaranPeriode.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalPengeluaran)
        Me.GroupBox3.Controls.Add(Me.lblTotalPembelian)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblTotalPenjualan)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lblBiayaOperasional)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox3.Location = New System.Drawing.Point(168, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 162)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grand Total"
        '
        'lblTotalPengeluaran
        '
        Me.lblTotalPengeluaran.AutoSize = True
        Me.lblTotalPengeluaran.Location = New System.Drawing.Point(124, 71)
        Me.lblTotalPengeluaran.Name = "lblTotalPengeluaran"
        Me.lblTotalPengeluaran.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPengeluaran.TabIndex = 20
        Me.lblTotalPengeluaran.Text = "-"
        '
        'lblTotalPembelian
        '
        Me.lblTotalPembelian.AutoSize = True
        Me.lblTotalPembelian.Location = New System.Drawing.Point(124, 42)
        Me.lblTotalPembelian.Name = "lblTotalPembelian"
        Me.lblTotalPembelian.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPembelian.TabIndex = 19
        Me.lblTotalPembelian.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Pembelian:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(126, 124)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Keuntungan:"
        '
        'lblTotalPenjualan
        '
        Me.lblTotalPenjualan.AutoSize = True
        Me.lblTotalPenjualan.Location = New System.Drawing.Point(124, 94)
        Me.lblTotalPenjualan.Name = "lblTotalPenjualan"
        Me.lblTotalPenjualan.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPenjualan.TabIndex = 14
        Me.lblTotalPenjualan.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Total Penjualan:"
        '
        'lblBiayaOperasional
        '
        Me.lblBiayaOperasional.AutoSize = True
        Me.lblBiayaOperasional.Location = New System.Drawing.Point(124, 21)
        Me.lblBiayaOperasional.Name = "lblBiayaOperasional"
        Me.lblBiayaOperasional.Size = New System.Drawing.Size(10, 13)
        Me.lblBiayaOperasional.TabIndex = 12
        Me.lblBiayaOperasional.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Biaya Operasional:"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape5})
        Me.ShapeContainer3.Size = New System.Drawing.Size(214, 143)
        Me.ShapeContainer3.TabIndex = 17
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape3"
        Me.LineShape4.X1 = 11
        Me.LineShape4.X2 = 203
        Me.LineShape4.Y1 = 46
        Me.LineShape4.Y2 = 46
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape2"
        Me.LineShape5.X1 = 11
        Me.LineShape5.X2 = 203
        Me.LineShape5.Y1 = 101
        Me.LineShape5.Y2 = 101
        '
        'LaporanLabaRugi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 354)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstFaktur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanLabaRugi"
        Me.Text = "Laporan Laba Rugi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFaktur As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPeriode As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPenjualanPeriode As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBiayaOperasionalPeriode As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTotalPengeluaranPeriode As System.Windows.Forms.Label
    Friend WithEvents lblTotalPembelianPeriode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPengeluaran As System.Windows.Forms.Label
    Friend WithEvents lblTotalPembelian As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPenjualan As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBiayaOperasional As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
