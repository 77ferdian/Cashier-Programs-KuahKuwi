<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbFaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaOrder = New System.Windows.Forms.TextBox()
        Me.cbbNoTelepon = New System.Windows.Forms.ComboBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbKategori = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkMember = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbJumlahOrder = New System.Windows.Forms.TextBox()
        Me.btnTambahMember = New System.Windows.Forms.Button()
        Me.tbMenu = New System.Windows.Forms.TextBox()
        Me.dgvDaftarMenu = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lvOrderan = New System.Windows.Forms.ListView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.tbTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTukarPoin = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbKembalian = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPoin = New System.Windows.Forms.Label()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvDaftarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbFaktur
        '
        Me.tbFaktur.Location = New System.Drawing.Point(145, 92)
        Me.tbFaktur.Name = "tbFaktur"
        Me.tbFaktur.Size = New System.Drawing.Size(259, 22)
        Me.tbFaktur.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Faktur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nama Order"
        '
        'tbNamaOrder
        '
        Me.tbNamaOrder.Location = New System.Drawing.Point(145, 215)
        Me.tbNamaOrder.Name = "tbNamaOrder"
        Me.tbNamaOrder.Size = New System.Drawing.Size(259, 22)
        Me.tbNamaOrder.TabIndex = 6
        '
        'cbbNoTelepon
        '
        Me.cbbNoTelepon.FormattingEnabled = True
        Me.cbbNoTelepon.Location = New System.Drawing.Point(145, 140)
        Me.cbbNoTelepon.Name = "cbbNoTelepon"
        Me.cbbNoTelepon.Size = New System.Drawing.Size(174, 24)
        Me.cbbNoTelepon.TabIndex = 8
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(12, 12)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(233, 22)
        Me.dtTanggal.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kategori"
        '
        'cbbKategori
        '
        Me.cbbKategori.FormattingEnabled = True
        Me.cbbKategori.Location = New System.Drawing.Point(549, 92)
        Me.cbbKategori.Name = "cbbKategori"
        Me.cbbKategori.Size = New System.Drawing.Size(174, 24)
        Me.cbbKategori.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Menu"
        '
        'chkMember
        '
        Me.chkMember.AutoSize = True
        Me.chkMember.Location = New System.Drawing.Point(325, 142)
        Me.chkMember.Name = "chkMember"
        Me.chkMember.Size = New System.Drawing.Size(79, 20)
        Me.chkMember.TabIndex = 25
        Me.chkMember.Text = "Member"
        Me.chkMember.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Harga"
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(549, 187)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(174, 22)
        Me.tbHarga.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Jumlah Order"
        '
        'tbJumlahOrder
        '
        Me.tbJumlahOrder.Location = New System.Drawing.Point(549, 235)
        Me.tbJumlahOrder.Name = "tbJumlahOrder"
        Me.tbJumlahOrder.Size = New System.Drawing.Size(174, 22)
        Me.tbJumlahOrder.TabIndex = 28
        '
        'btnTambahMember
        '
        Me.btnTambahMember.Location = New System.Drawing.Point(145, 170)
        Me.btnTambahMember.Name = "btnTambahMember"
        Me.btnTambahMember.Size = New System.Drawing.Size(174, 23)
        Me.btnTambahMember.TabIndex = 30
        Me.btnTambahMember.Text = "Tambah Member"
        Me.btnTambahMember.UseVisualStyleBackColor = True
        '
        'tbMenu
        '
        Me.tbMenu.Location = New System.Drawing.Point(549, 143)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(174, 22)
        Me.tbMenu.TabIndex = 31
        '
        'dgvDaftarMenu
        '
        Me.dgvDaftarMenu.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvDaftarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarMenu.Location = New System.Drawing.Point(751, 112)
        Me.dgvDaftarMenu.Name = "dgvDaftarMenu"
        Me.dgvDaftarMenu.RowHeadersWidth = 51
        Me.dgvDaftarMenu.RowTemplate.Height = 24
        Me.dgvDaftarMenu.Size = New System.Drawing.Size(295, 145)
        Me.dgvDaftarMenu.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Orderan"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Gold
        Me.btnTambah.Location = New System.Drawing.Point(893, 317)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(125, 50)
        Me.btnTambah.TabIndex = 35
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Gold
        Me.btnHapus.Location = New System.Drawing.Point(893, 391)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(125, 50)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'lvOrderan
        '
        Me.lvOrderan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lvOrderan.HideSelection = False
        Me.lvOrderan.Location = New System.Drawing.Point(42, 317)
        Me.lvOrderan.Name = "lvOrderan"
        Me.lvOrderan.Size = New System.Drawing.Size(806, 261)
        Me.lvOrderan.TabIndex = 37
        Me.lvOrderan.UseCompatibleStateImageBehavior = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Gold
        Me.btnSimpan.Location = New System.Drawing.Point(893, 467)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(125, 50)
        Me.btnSimpan.TabIndex = 38
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 595)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Total Harga"
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.Location = New System.Drawing.Point(145, 592)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(174, 22)
        Me.tbTotalHarga.TabIndex = 40
        '
        'tbTotalBayar
        '
        Me.tbTotalBayar.Location = New System.Drawing.Point(145, 631)
        Me.tbTotalBayar.Name = "tbTotalBayar"
        Me.tbTotalBayar.Size = New System.Drawing.Size(174, 22)
        Me.tbTotalBayar.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 634)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Total Bayar"
        '
        'btnTukarPoin
        '
        Me.btnTukarPoin.Location = New System.Drawing.Point(279, 253)
        Me.btnTukarPoin.Name = "btnTukarPoin"
        Me.btnTukarPoin.Size = New System.Drawing.Size(125, 37)
        Me.btnTukarPoin.TabIndex = 43
        Me.btnTukarPoin.Text = "Tukar 20 Poin"
        Me.btnTukarPoin.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(748, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Daftar Menu"
        '
        'tbKembalian
        '
        Me.tbKembalian.Location = New System.Drawing.Point(484, 589)
        Me.tbKembalian.Name = "tbKembalian"
        Me.tbKembalian.Size = New System.Drawing.Size(174, 22)
        Me.tbKembalian.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(378, 592)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Kembalian"
        '
        'lblPoin
        '
        Me.lblPoin.AutoSize = True
        Me.lblPoin.Location = New System.Drawing.Point(142, 253)
        Me.lblPoin.Name = "lblPoin"
        Me.lblPoin.Size = New System.Drawing.Size(47, 16)
        Me.lblPoin.TabIndex = 47
        Me.lblPoin.Text = "Poin: 0"
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.Gold
        Me.btnLaporan.Location = New System.Drawing.Point(893, 543)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(125, 50)
        Me.btnLaporan.TabIndex = 48
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.Font = New System.Drawing.Font("Cooper Black", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(450, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 54)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Kasir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UAS_PEMDES_KEL3.My.Resources.Resources.logo_lunch_box1
        Me.PictureBox2.Location = New System.Drawing.Point(905, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UAS_PEMDES_KEL3.My.Resources.Resources.logo_cewe
        Me.PictureBox1.Location = New System.Drawing.Point(949, 595)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1074, 683)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.lblPoin)
        Me.Controls.Add(Me.tbKembalian)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnTukarPoin)
        Me.Controls.Add(Me.tbTotalBayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbTotalHarga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lvOrderan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvDaftarMenu)
        Me.Controls.Add(Me.tbMenu)
        Me.Controls.Add(Me.btnTambahMember)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbJumlahOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.chkMember)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbKategori)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.cbbNoTelepon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbNamaOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbFaktur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Kasir Kuah Kuwi"
        CType(Me.dgvDaftarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFaktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNamaOrder As TextBox
    Friend WithEvents cbbNoTelepon As ComboBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbKategori As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbJumlahOrder As TextBox
    Friend WithEvents btnTambahMember As Button
    Friend WithEvents tbMenu As TextBox
    Friend WithEvents dgvDaftarMenu As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lvOrderan As ListView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTotalHarga As TextBox
    Friend WithEvents tbTotalBayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTukarPoin As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents tbKembalian As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPoin As Label
    Friend WithEvents btnLaporan As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
