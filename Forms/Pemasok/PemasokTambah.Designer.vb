<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PemasokTambah
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
        Me.txtKodePemasok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPemasok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtKodePemasok
        '
        Me.txtKodePemasok.Location = New System.Drawing.Point(104, 6)
        Me.txtKodePemasok.MaxLength = 5
        Me.txtKodePemasok.Name = "txtKodePemasok"
        Me.txtKodePemasok.Size = New System.Drawing.Size(69, 20)
        Me.txtKodePemasok.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Kontak:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Alamat:"
        '
        'txtNamaPemasok
        '
        Me.txtNamaPemasok.Location = New System.Drawing.Point(104, 32)
        Me.txtNamaPemasok.Name = "txtNamaPemasok"
        Me.txtNamaPemasok.Size = New System.Drawing.Size(122, 20)
        Me.txtNamaPemasok.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nama Pemasok:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Kode Pemasok:"
        '
        'btnBatal
        '
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(169, 172)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 23)
        Me.btnBatal.TabIndex = 54
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.AutoSize = True
        Me.btnTambah.Location = New System.Drawing.Point(103, 172)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 52
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 61)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(122, 62)
        Me.txtAlamat.TabIndex = 46
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(106, 131)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(122, 20)
        Me.txtKontak.TabIndex = 47
        '
        'PemasokTambah
        '
        Me.AcceptButton = Me.btnTambah
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(240, 207)
        Me.Controls.Add(Me.txtKontak)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtKodePemasok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaPemasok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PemasokTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pemasok Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodePemasok As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPemasok As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
End Class
