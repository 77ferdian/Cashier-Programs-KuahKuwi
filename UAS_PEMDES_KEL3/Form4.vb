Imports System.Data
Imports System.Data.Odbc

Public Class Form4
    Public conn As OdbcConnection
    Public cmd As OdbcCommand

    ' 1. Sub Koneksi (Standard)
    Sub koneksi()
        conn = New OdbcConnection("Dsn=dsn_kuah_kuwi")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' 2. Sub untuk Menghitung Total dari Database
    Sub TampilTotal()
        Try
            Call koneksi()

            ' Query: Menjumlahkan semua subtotal di tabel detail
            ' IFNULL digunakan agar jika tabel kosong, hasilnya 0 (bukan Error)
            Dim query As String = "SELECT IFNULL(SUM(subtotal), 0) FROM tbl_detail_transaksi"

            cmd = New OdbcCommand(query, conn)

            ' ExecuteScalar sangat cocok untuk mengambil 1 nilai saja (hasil SUM)
            Dim hasil As Object = cmd.ExecuteScalar()

            ' Tampilkan ke Label atau Textbox
            ' Format "N0" akan memberi pemisah ribuan (contoh: 1.500.000)
            lblTotalPendapatan.Text = "Rp " & Val(hasil).ToString("N0")

        Catch ex As Exception
            MsgBox("Gagal Hitung: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' 3. Event saat Form dibuka
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTotal()
    End Sub

    ' 4. Event Tombol Refresh (Opsional)
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TampilTotal()
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class