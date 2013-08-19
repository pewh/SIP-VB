<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PembeliTambah
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
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKodePembeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPembeli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(100, 134)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(122, 20)
        Me.txtKontak.TabIndex = 61
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(98, 64)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(122, 62)
        Me.txtAlamat.TabIndex = 60
        '
        'txtKodePembeli
        '
        Me.txtKodePembeli.Location = New System.Drawing.Point(98, 9)
        Me.txtKodePembeli.MaxLength = 5
        Me.txtKodePembeli.Name = "txtKodePembeli"
        Me.txtKodePembeli.Size = New System.Drawing.Size(69, 20)
        Me.txtKodePembeli.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Kontak:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Alamat:"
        '
        'txtNamaPembeli
        '
        Me.txtNamaPembeli.Location = New System.Drawing.Point(98, 35)
        Me.txtNamaPembeli.Name = "txtNamaPembeli"
        Me.txtNamaPembeli.Size = New System.Drawing.Size(122, 20)
        Me.txtNamaPembeli.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Nama Pembeli:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Kode Pembeli:"
        '
        'btnBatal
        '
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(163, 175)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 23)
        Me.btnBatal.TabIndex = 64
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.AutoSize = True
        Me.btnTambah.Location = New System.Drawing.Point(97, 175)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 23)
        Me.btnTambah.TabIndex = 63
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'PembeliTambah
        '
        Me.AcceptButton = Me.btnTambah
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(230, 206)
        Me.Controls.Add(Me.txtKontak)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtKodePembeli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaPembeli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PembeliTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pembeli Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePembeli As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPembeli As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
End Class
