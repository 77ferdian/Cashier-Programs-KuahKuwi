Imports System.Data
Imports System.Data.Odbc
Imports System.Text

Public Class Form1
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader

    Private totalHarga As Integer = 0
    Private poinMemberSaatIni As Integer = 0
    Private sedangTukarPoin As Boolean = False
    Private poinYangAkanDitukar As Integer = 0

    Private stokSaatIni As Integer = 0

    Sub koneksi()
        conn = New OdbcConnection("Dsn=dsn_kuah_kuwi")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateNoNota()
        IsiComboTelepon()
        IsiComboKategori()
        SetupListViewOrderan()

        cbbNoTelepon.Enabled = False
        tbNamaOrder.ReadOnly = False
        dtTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
        BersihkanForm()
    End Sub

    Sub BersihkanForm()
        chkMember.Checked = False
        cbbNoTelepon.SelectedIndex = -1
        cbbNoTelepon.Enabled = False
        tbNamaOrder.Text = ""
        tbNamaOrder.ReadOnly = False
        btnTambahMember.Enabled = True

        cbbKategori.SelectedIndex = -1
        dgvDaftarMenu.DataSource = Nothing

        tbMenu.Text = ""
        tbHarga.Text = ""
        tbHarga.Tag = ""
        tbJumlahOrder.Text = ""

        tbJumlahOrder.Enabled = True
        stokSaatIni = 0

        lvOrderan.Items.Clear()
        totalHarga = 0
        tbTotalHarga.Text = "0"
        tbTotalBayar.Text = ""
        tbKembalian.Text = "0"

        lblPoin.Text = "Poin: 0"
        poinMemberSaatIni = 0
        sedangTukarPoin = False
        poinYangAkanDitukar = 0
        btnTukarPoin.Enabled = False

        GenerateNoNota()
    End Sub

    Sub GenerateNoNota()
        Try
            Call koneksi()
            Dim query As String = "SELECT CONCAT('NOTA/', LPAD(IFNULL(MAX(CONVERT(SUBSTRING(no_nota, 6, 3), UNSIGNED)), 0) + 1, 3, '0'), '/', DATE_FORMAT(NOW(), '%m/%Y')) AS nomor FROM tbl_transaksi WHERE MONTH(tgl_transaksi)=MONTH(NOW()) AND YEAR(tgl_transaksi)=YEAR(NOW())"
            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                tbFaktur.Text = result.ToString()
            Else
                tbFaktur.Text = "NOTA/001/" & Format(Now, "MM/yyyy")
            End If
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Sub SetupListViewOrderan()
        lvOrderan.View = View.Details
        lvOrderan.GridLines = True
        lvOrderan.FullRowSelect = True
        lvOrderan.Columns.Clear()
        lvOrderan.Columns.Add("Kode", 110)
        lvOrderan.Columns.Add("Nama Menu", 200)
        lvOrderan.Columns.Add("Harga", 110)
        lvOrderan.Columns.Add("Jumlah", 70)
        lvOrderan.Columns.Add("Subtotal", 110)
    End Sub

    Sub IsiComboTelepon()
        Try
            Call koneksi()
            cmd = New OdbcCommand("SELECT no_telepon FROM tbl_member ORDER BY nama_member", conn)
            dr = cmd.ExecuteReader()
            cbbNoTelepon.Items.Clear()
            While dr.Read()
                cbbNoTelepon.Items.Add(dr("no_telepon").ToString())
            End While
            dr.Close()
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub chkMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkMember.CheckedChanged
        If chkMember.Checked Then
            cbbNoTelepon.Enabled = True
            tbNamaOrder.ReadOnly = True
            tbNamaOrder.Text = ""
            btnTambahMember.Enabled = True
        Else
            cbbNoTelepon.Enabled = False
            cbbNoTelepon.SelectedIndex = -1
            tbNamaOrder.ReadOnly = False
            tbNamaOrder.Text = ""
            btnTambahMember.Enabled = False
            BersihkanForm()
        End If
    End Sub

    Private Sub cbbNoTelepon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbNoTelepon.SelectedIndexChanged
        If cbbNoTelepon.Text = "" Then Return
        Try
            Call koneksi()
            cmd = New OdbcCommand("SELECT nama_member, poin FROM tbl_member WHERE no_telepon=?", conn)
            cmd.Parameters.AddWithValue("?", cbbNoTelepon.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                tbNamaOrder.Text = dr("nama_member").ToString()
                poinMemberSaatIni = Val(dr("poin").ToString())
                lblPoin.Text = "Poin: " & poinMemberSaatIni

                If poinMemberSaatIni >= 20 Then
                    btnTukarPoin.Enabled = True
                Else
                    btnTukarPoin.Enabled = False
                End If
            End If
            dr.Close()
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Function HitungPoinDapat(totalBelanja As Integer) As Integer
        If totalBelanja >= 15000 And totalBelanja <= 20000 Then
            Return 1
        ElseIf totalBelanja >= 21000 And totalBelanja <= 50000 Then
            Return 3
        ElseIf totalBelanja >= 51000 And totalBelanja <= 100000 Then
            Return 5
        ElseIf totalBelanja > 100000 Then
            Return 10
        Else
            Return 0
        End If
    End Function

    Private Sub btnTukarPoin_Click(sender As Object, e As EventArgs) Handles btnTukarPoin.Click
        If sedangTukarPoin Then
            MsgBox("Hanya bisa tukar 1x per transaksi!", vbExclamation)
            Return
        End If

        If poinMemberSaatIni >= 20 Then
            Dim jawab As Integer
            jawab = MessageBox.Show("Apakah Anda yakin ingin menukar 20 Poin dengan Snack Gratis?", "Konfirmasi Tukar Poin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If jawab = vbYes Then
                Dim lvItem As New ListViewItem("RWD001")
                lvItem.SubItems.Add("REWARD FREE SNACK")
                lvItem.SubItems.Add("0")
                lvItem.SubItems.Add("1")
                lvItem.SubItems.Add("0")
                lvOrderan.Items.Add(lvItem)

                sedangTukarPoin = True
                poinYangAkanDitukar = 20
                poinMemberSaatIni = poinMemberSaatIni - 20
                lblPoin.Text = "Poin: " & poinMemberSaatIni

                btnTukarPoin.Enabled = False
                MsgBox("Poin berhasil ditukar!", vbInformation)
            End If
        End If
    End Sub

    Sub IsiComboKategori()
        Try
            Call koneksi()
            cmd = New OdbcCommand("SELECT nama_kategori FROM tbl_kategori", conn)
            dr = cmd.ExecuteReader()
            cbbKategori.Items.Clear()
            While dr.Read()
                cbbKategori.Items.Add(dr("nama_kategori").ToString())
            End While
            dr.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbKategori.SelectedIndexChanged
        If cbbKategori.Text = "" Then Return
        Try
            Call koneksi()
            Dim query As String = "SELECT m.kode_menu, m.nama_menu, m.harga, m.stok FROM tbl_menu m JOIN tbl_kategori k ON m.kode_kategori = k.kode_kategori WHERE k.nama_kategori = ? AND m.kode_menu <> 'RWD001'"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", cbbKategori.Text)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvDaftarMenu.DataSource = dt
            dgvDaftarMenu.Columns("harga").DefaultCellStyle.Format = "N0"
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvDaftarMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDaftarMenu.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDaftarMenu.Rows(e.RowIndex)

            stokSaatIni = Val(row.Cells("stok").Value.ToString())

            tbMenu.Text = row.Cells("nama_menu").Value.ToString()
            tbHarga.Text = row.Cells("harga").Value.ToString()
            tbHarga.Tag = row.Cells("kode_menu").Value.ToString()

            If stokSaatIni <= 0 Then
                MsgBox("Maaf, Stok Menu Ini Sedang Habis!", vbExclamation, "Stok Kosong")
                tbJumlahOrder.Text = ""
                tbJumlahOrder.Enabled = False
            Else
                tbJumlahOrder.Enabled = True
                tbJumlahOrder.Focus()
            End If
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbMenu.Text = "" Or Val(tbJumlahOrder.Text) <= 0 Then
            MsgBox("Pilih menu dan isi jumlah yang valid!", vbExclamation)
            Return
        End If

        If stokSaatIni <= 0 Then
            MsgBox("Stok habis! Tidak bisa menambahkan menu ini.", vbCritical)
            Return
        End If

        Dim kode As String = tbHarga.Tag.ToString()
        Dim harga As Integer = Val(tbHarga.Text)
        Dim jumlahMinta As Integer = Val(tbJumlahOrder.Text)

        Dim jumlahDiList As Integer = 0
        Dim itemExists As Boolean = False
        Dim existingItem As ListViewItem = Nothing

        For Each item As ListViewItem In lvOrderan.Items
            If item.SubItems(0).Text = kode Then
                jumlahDiList = Val(item.SubItems(3).Text)
                itemExists = True
                existingItem = item
                Exit For
            End If
        Next

        If (jumlahMinta + jumlahDiList) > stokSaatIni Then
            MsgBox("Stok tidak mencukupi!" & vbCrLf &
                   "Sisa Stok: " & stokSaatIni & vbCrLf &
                   "Sudah di keranjang: " & jumlahDiList & vbCrLf &
                   "Anda meminta: " & jumlahMinta, vbExclamation, "Stok Kurang")
            Return
        End If

        Dim subtotal As Integer = harga * jumlahMinta

        If itemExists Then
            Dim jumlahBaru As Integer = jumlahDiList + jumlahMinta
            existingItem.SubItems(3).Text = jumlahBaru.ToString()
            existingItem.SubItems(4).Text = (harga * jumlahBaru).ToString("N0")
        Else
            Dim lvItem As New ListViewItem(kode)
            lvItem.SubItems.Add(tbMenu.Text)
            lvItem.SubItems.Add(harga.ToString("N0"))
            lvItem.SubItems.Add(jumlahMinta.ToString())
            lvItem.SubItems.Add(subtotal.ToString("N0"))
            lvOrderan.Items.Add(lvItem)
        End If

        HitungTotalHarga()
        tbMenu.Text = "" : tbHarga.Text = "" : tbJumlahOrder.Text = ""
        stokSaatIni = 0
    End Sub

    Private Sub tbJumlahOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbJumlahOrder.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lvOrderan.SelectedItems.Count > 0 Then
            If MessageBox.Show("Apakah Anda yakin ingin menghapus item ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                If lvOrderan.SelectedItems(0).Text = "RWD001" Then
                    sedangTukarPoin = False
                    poinYangAkanDitukar = 0
                    poinMemberSaatIni = poinMemberSaatIni + 20
                    lblPoin.Text = "Poin: " & poinMemberSaatIni
                    btnTukarPoin.Enabled = True
                End If

                lvOrderan.Items.Remove(lvOrderan.SelectedItems(0))
                HitungTotalHarga()
            End If
        Else
            MsgBox("Pilih item yang ingin dihapus!", vbExclamation)
        End If
    End Sub

    Sub HitungTotalHarga()
        totalHarga = 0
        For Each item As ListViewItem In lvOrderan.Items
            totalHarga += Val(item.SubItems(4).Text.Replace(".", "").Replace(",", ""))
        Next
        tbTotalHarga.Text = totalHarga.ToString("N0")
    End Sub

    Private Sub tbTotalBayar_TextChanged(sender As Object, e As EventArgs) Handles tbTotalBayar.TextChanged
        Dim bayar As Integer = Val(tbTotalBayar.Text)
        Dim kembalian As Integer = bayar - totalHarga
        If kembalian >= 0 Then tbKembalian.Text = kembalian.ToString("N0") Else tbKembalian.Text = "0"
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If lvOrderan.Items.Count = 0 Or tbNamaOrder.Text = "" Then
            MsgBox("Data belum lengkap! Pastikan ada menu yang dipesan dan nama pelanggan terisi.", vbExclamation)
            Return
        End If
        If Val(tbTotalBayar.Text) < totalHarga Then
            MsgBox("Uang pembayaran kurang!", vbExclamation)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menyelesaikan transaksi ini?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Return

        Try
            Call koneksi()
            Dim poinDapat As Integer = 0
            Dim isMember As Integer = If(chkMember.Checked, 1, 0)
            Dim noTelp As Object = If(chkMember.Checked, cbbNoTelepon.Text, DBNull.Value)

            If isMember = 1 Then
                poinDapat = HitungPoinDapat(totalHarga)
                Dim updatePoin As Integer = poinDapat - poinYangAkanDitukar
                cmd = New OdbcCommand("UPDATE tbl_member SET poin = poin + ? WHERE no_telepon = ?", conn)
                cmd.Parameters.AddWithValue("?", updatePoin)
                cmd.Parameters.AddWithValue("?", noTelp)
                cmd.ExecuteNonQuery()
            End If

            Dim sqlHead As String = "INSERT INTO tbl_transaksi (no_nota, no_telepon, nama_order, is_member, total_harga, total_bayar, kembalian) VALUES (?, ?, ?, ?, ?, ?, ?)"
            cmd = New OdbcCommand(sqlHead, conn)
            cmd.Parameters.AddWithValue("?", tbFaktur.Text)
            cmd.Parameters.AddWithValue("?", noTelp)
            cmd.Parameters.AddWithValue("?", tbNamaOrder.Text)
            cmd.Parameters.AddWithValue("?", isMember)
            cmd.Parameters.AddWithValue("?", totalHarga)
            cmd.Parameters.AddWithValue("?", Val(tbTotalBayar.Text))
            cmd.Parameters.AddWithValue("?", Val(tbKembalian.Text.Replace(".", "")))
            cmd.ExecuteNonQuery()

            Dim sqlDet As String = "INSERT INTO tbl_detail_transaksi (no_nota, kode_menu, nama_menu, harga, jumlah, subtotal) VALUES (?, ?, ?, ?, ?, ?)"
            Dim sqlStok As String = "UPDATE tbl_menu SET stok = stok - ? WHERE kode_menu = ?"

            For Each item As ListViewItem In lvOrderan.Items
                cmd = New OdbcCommand(sqlDet, conn)
                cmd.Parameters.AddWithValue("?", tbFaktur.Text)
                cmd.Parameters.AddWithValue("?", item.SubItems(0).Text)
                cmd.Parameters.AddWithValue("?", item.SubItems(1).Text)
                cmd.Parameters.AddWithValue("?", Val(item.SubItems(2).Text.Replace(".", "")))
                cmd.Parameters.AddWithValue("?", Val(item.SubItems(3).Text))
                cmd.Parameters.AddWithValue("?", Val(item.SubItems(4).Text.Replace(".", "")))
                cmd.ExecuteNonQuery()

                If item.SubItems(0).Text <> "RWD001" Then
                    cmd = New OdbcCommand(sqlStok, conn)
                    cmd.Parameters.AddWithValue("?", Val(item.SubItems(3).Text))
                    cmd.Parameters.AddWithValue("?", item.SubItems(0).Text)
                    cmd.ExecuteNonQuery()
                End If
            Next

            Dim struk As New StringBuilder()
            struk.AppendLine("========= KUAH KUWI =========")
            struk.AppendLine("Jl. Rungkut No. 6, Surabaya")
            struk.AppendLine("=============================")
            struk.AppendLine("Nota    : " & tbFaktur.Text)
            struk.AppendLine("Tanggal : " & Format(Now, "dd/MM/yyyy HH:mm"))
            struk.AppendLine("Pelanggan: " & tbNamaOrder.Text)
            struk.AppendLine("-----------------------------")

            For Each item As ListViewItem In lvOrderan.Items
                Dim namaMenu As String = item.SubItems(1).Text
                If namaMenu.Length > 20 Then namaMenu = namaMenu.Substring(0, 20)
                struk.AppendLine(String.Format("{0,-20} {1,3} {2,10}", namaMenu, item.SubItems(3).Text, item.SubItems(4).Text))
            Next

            struk.AppendLine("-----------------------------")
            struk.AppendLine("Total      : Rp " & totalHarga.ToString("N0"))
            struk.AppendLine("Bayar      : Rp " & Val(tbTotalBayar.Text).ToString("N0"))
            struk.AppendLine("Kembali    : Rp " & Val(tbKembalian.Text).ToString("N0") & ".000")

            If isMember = 1 Then
                struk.AppendLine("-----------------------------")
                struk.AppendLine("Poin Awal  : " & poinMemberSaatIni + poinYangAkanDitukar)
                struk.AppendLine("Poin Dapat : " & poinDapat)
                struk.AppendLine("Poin Tukar : -" & poinYangAkanDitukar)
                struk.AppendLine("Sisa Poin  : " & (poinMemberSaatIni + poinDapat))
            End If

            struk.AppendLine("=============================")
            struk.AppendLine("    TERIMA KASIH KAKAK :)    ")
            struk.AppendLine("=============================")

            MessageBox.Show(struk.ToString(), "STRUK PEMBAYARAN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BersihkanForm()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnTambahMember_Click(sender As Object, e As EventArgs) Handles btnTambahMember.Click
        Dim f2 As New Form2()
        f2.ShowDialog()
        IsiComboTelepon()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub
End Class