Imports System.Data
Imports System.Data.Odbc

Public Class Form2
    Public conn As OdbcConnection
    Public cmd As OdbcCommand

    Sub koneksi()
        conn = New OdbcConnection("Dsn=dsn_kuah_kuwi")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbNoTelepon.Text = "" Or tbNamaMember.Text = "" Then
            MsgBox("Data harus diisi!", vbExclamation)
            Return
        End If

        Try
            Call koneksi()
            ' Cek Duplikat
            cmd = New OdbcCommand("SELECT * FROM tbl_member WHERE no_telepon = ?", conn)
            cmd.Parameters.AddWithValue("?", tbNoTelepon.Text)
            Dim dr As OdbcDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Nomor HP sudah terdaftar!", vbExclamation)
                Return
            End If
            dr.Close()

            ' Simpan Member Baru (Default Poin 0)
            Dim sql As String = "INSERT INTO tbl_member (no_telepon, nama_member, alamat, poin) VALUES (?, ?, ?, 0)"
            cmd = New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("?", tbNoTelepon.Text)
            cmd.Parameters.AddWithValue("?", tbNamaMember.Text)
            cmd.Parameters.AddWithValue("?", tbAlamat.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Member Berhasil Ditambahkan!", vbInformation)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    ' Supaya input telepon hanya angka
    Private Sub tbNoTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNoTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class