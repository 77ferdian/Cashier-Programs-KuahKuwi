<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNamaMember = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. Telepon"
        '
        'tbNoTelepon
        '
        Me.tbNoTelepon.Location = New System.Drawing.Point(135, 29)
        Me.tbNoTelepon.Name = "tbNoTelepon"
        Me.tbNoTelepon.Size = New System.Drawing.Size(259, 22)
        Me.tbNoTelepon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Member"
        '
        'tbNamaMember
        '
        Me.tbNamaMember.Location = New System.Drawing.Point(135, 70)
        Me.tbNamaMember.Name = "tbNamaMember"
        Me.tbNamaMember.Size = New System.Drawing.Size(259, 22)
        Me.tbNamaMember.TabIndex = 4
        '
        'Alamat
        '
        Me.Alamat.AutoSize = True
        Me.Alamat.Location = New System.Drawing.Point(29, 117)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(49, 16)
        Me.Alamat.TabIndex = 7
        Me.Alamat.Text = "Alamat"
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(135, 114)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(259, 22)
        Me.tbAlamat.TabIndex = 6
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Gold
        Me.btnSimpan.Location = New System.Drawing.Point(190, 172)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(125, 50)
        Me.btnSimpan.TabIndex = 36
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Gold
        Me.btnBatal.Location = New System.Drawing.Point(349, 172)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(125, 50)
        Me.btnBatal.TabIndex = 37
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UAS_PEMDES_KEL3.My.Resources.Resources.logo_cewe
        Me.PictureBox1.Location = New System.Drawing.Point(401, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNamaMember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNoTelepon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Tambah Membership"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbNoTelepon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNamaMember As TextBox
    Friend WithEvents Alamat As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
