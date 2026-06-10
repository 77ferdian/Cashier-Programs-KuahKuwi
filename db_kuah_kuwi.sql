-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 16 Des 2025 pada 13.12
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kuah_kuwi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_transaksi`
--

CREATE TABLE `tbl_detail_transaksi` (
  `id_detail` int(11) NOT NULL,
  `no_nota` varchar(30) NOT NULL,
  `kode_menu` varchar(20) NOT NULL,
  `nama_menu` varchar(100) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_detail_transaksi`
--

INSERT INTO `tbl_detail_transaksi` (`id_detail`, `no_nota`, `kode_menu`, `nama_menu`, `harga`, `jumlah`, `subtotal`) VALUES
(1, 'NOTA/001/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(2, 'NOTA/001/12/2025', 'MNM001', 'Jasmine Tea', 5000, 1, 5000),
(3, 'NOTA/002/12/2025', 'MIE001', 'Mie Jebew', 10000, 3, 30000),
(4, 'NOTA/003/12/2025', 'MIE001', 'Mie Jebew', 10000, 9, 90000),
(5, 'NOTA/003/12/2025', 'RWD001', 'REWARD FREE SNACK', 0, 1, 0),
(6, 'NOTA/004/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(7, 'NOTA/005/12/2025', 'RWD001', 'REWARD FREE SNACK', 0, 1, 0),
(8, 'NOTA/006/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(9, 'NOTA/006/12/2025', 'MNM004', 'Matcha', 10000, 1, 10000),
(10, 'NOTA/007/12/2025', 'MIE003', 'Mie Gurih', 10000, 10, 100000),
(11, 'NOTA/007/12/2025', 'MNM001', 'Jasmine Tea', 5000, 5, 25000),
(12, 'NOTA/007/12/2025', 'MNM002', 'Lemon Tea', 7000, 3, 21000),
(13, 'NOTA/007/12/2025', 'MNM003', 'Lychee Tea', 7000, 2, 14000),
(14, 'NOTA/008/12/2025', 'MNM002', 'Lemon Tea', 7000, 1, 7000),
(15, 'NOTA/008/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(16, 'NOTA/009/12/2025', 'GYZ001', 'Kuah Keju', 15000, 2, 30000),
(17, 'NOTA/010/12/2025', 'GYZ001', 'Kuah Keju', 15000, 5, 75000),
(18, 'NOTA/011/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(19, 'NOTA/011/12/2025', 'GYZ002', 'Kuah Ori', 14000, 2, 28000),
(20, 'NOTA/012/12/2025', 'MIE001', 'Mie Jebew', 10000, 1, 10000),
(21, 'NOTA/012/12/2025', 'MNM002', 'Lemon Tea', 7000, 1, 7000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kategori`
--

CREATE TABLE `tbl_kategori` (
  `kode_kategori` varchar(10) NOT NULL,
  `nama_kategori` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_kategori`
--

INSERT INTO `tbl_kategori` (`kode_kategori`, `nama_kategori`) VALUES
('KAT001', 'Mie'),
('KAT002', 'Gyoza'),
('KAT003', 'Snack'),
('KAT004', 'Drink');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_member`
--

CREATE TABLE `tbl_member` (
  `no_telepon` varchar(15) NOT NULL,
  `nama_member` varchar(100) NOT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `tgl_daftar` date DEFAULT curdate(),
  `poin` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_member`
--

INSERT INTO `tbl_member` (`no_telepon`, `nama_member`, `alamat`, `tgl_daftar`, `poin`) VALUES
('081234567890', 'Budi Santoso', 'Surabaya', '2025-12-09', 80),
('082345678901', 'Siti Nurhaliza', 'Sidoarjo', '2025-12-09', 18),
('083456789012', 'Ahmad Yani', 'Surabaya', '2025-12-09', 0),
('085721082776', 'Ferdian', 'Sukabumi', '2025-12-16', 0),
('093042384', 'Siapa Aja', 'Dimana aja', '2025-12-16', 3);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_menu`
--

CREATE TABLE `tbl_menu` (
  `kode_menu` varchar(20) NOT NULL,
  `nama_menu` varchar(100) NOT NULL,
  `kode_kategori` varchar(10) NOT NULL,
  `harga` int(11) NOT NULL,
  `stok` int(11) DEFAULT 999
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_menu`
--

INSERT INTO `tbl_menu` (`kode_menu`, `nama_menu`, `kode_kategori`, `harga`, `stok`) VALUES
('GYZ001', 'Kuah Keju', 'KAT002', 15000, 0),
('GYZ002', 'Kuah Ori', 'KAT002', 14000, 997),
('GYZ003', 'Kuah Pedas', 'KAT002', 14000, 999),
('GYZ004', 'Saus Pedas', 'KAT002', 14000, 999),
('GYZ005', 'Goreng Pedas', 'KAT002', 14000, 999),
('GYZ006', 'Gyoza Goreng', 'KAT002', 13000, 999),
('GYZ007', 'Gyoza Panggang', 'KAT002', 13000, 999),
('GYZ008', 'Gyoza Mentai', 'KAT002', 15000, 999),
('GYZ009', 'Gyoza Mix', 'KAT002', 23000, 999),
('MIE001', 'Mie Jebew', 'KAT001', 10000, 985),
('MIE002', 'Mie Jebew Bakar Keju', 'KAT001', 13000, 999),
('MIE003', 'Mie Gurih', 'KAT001', 10000, 989),
('MIE004', 'Bakmi Polos', 'KAT001', 9000, 999),
('MIE005', 'Bakmi Original', 'KAT001', 13000, 999),
('MIE006', 'Bakmi Ayam Panggang', 'KAT001', 16000, 999),
('MNM001', 'Jasmine Tea', 'KAT004', 5000, 994),
('MNM002', 'Lemon Tea', 'KAT004', 7000, 994),
('MNM003', 'Lychee Tea', 'KAT004', 7000, 997),
('MNM004', 'Matcha', 'KAT004', 10000, 998),
('MNM005', 'Thai Tea', 'KAT004', 10000, 999),
('MNM006', 'Americano', 'KAT004', 8000, 999),
('MNM007', 'Kopi Susu Aren', 'KAT004', 12000, 999),
('MNM008', 'Kopi Susu Vanilla', 'KAT004', 12000, 999),
('MNM009', 'Kopi Susu Caramel', 'KAT004', 12000, 999),
('MNM010', 'Mineral Water', 'KAT004', 4000, 999),
('RWD001', 'REWARD FREE SNACK', 'KAT003', 0, 999),
('SNK001', 'Lumpia Kulit Tahu', 'KAT003', 10000, 999),
('SNK002', 'Cireng Kuah Keju', 'KAT003', 10000, 999),
('SNK003', 'Chicken Cheese Balls', 'KAT003', 10000, 999);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `no_nota` varchar(30) NOT NULL,
  `tgl_transaksi` datetime NOT NULL DEFAULT current_timestamp(),
  `no_telepon` varchar(15) DEFAULT NULL,
  `nama_order` varchar(100) NOT NULL,
  `is_member` tinyint(1) DEFAULT 0,
  `total_harga` int(11) NOT NULL,
  `total_bayar` int(11) DEFAULT 0,
  `kembalian` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`no_nota`, `tgl_transaksi`, `no_telepon`, `nama_order`, `is_member`, `total_harga`, `total_bayar`, `kembalian`) VALUES
('NOTA/001/12/2025', '2025-12-09 18:00:35', '081234567890', 'Budi Santoso', 1, 15000, 20000, 5000),
('NOTA/002/12/2025', '2025-12-09 18:01:15', '082345678901', 'Siti Nurhaliza', 1, 30000, 30000, 0),
('NOTA/003/12/2025', '2025-12-09 18:14:40', '081234567890', 'Budi Santoso', 1, 90000, 100000, 10000),
('NOTA/004/12/2025', '2025-12-09 18:15:38', NULL, 'Aku bukan member', 0, 10000, 20000, 10000),
('NOTA/005/12/2025', '2025-12-09 18:22:49', '081234567890', 'Budi Santoso', 1, 0, 0, 0),
('NOTA/006/12/2025', '2025-12-09 19:02:50', NULL, 'Ahmad Ghilman', 0, 20000, 50000, 30000),
('NOTA/007/12/2025', '2025-12-09 19:04:25', '082345678901', 'Siti Nurhaliza', 1, 160000, 200000, 40000),
('NOTA/008/12/2025', '2025-12-09 20:03:22', NULL, 'grfds', 0, 17000, 20000, 3000),
('NOTA/009/12/2025', '2025-12-09 20:22:05', NULL, 'sdgfdhgfhj', 0, 30000, 50000, 20000),
('NOTA/010/12/2025', '2025-12-09 20:31:34', NULL, 'werfwef', 0, 75000, 75000, 0),
('NOTA/011/12/2025', '2025-12-16 19:00:39', '093042384', 'Siapa Aja', 1, 38000, 50000, 12000),
('NOTA/012/12/2025', '2025-12-16 19:03:02', NULL, 'Ferdian', 0, 17000, 17000, 0);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_detail_transaksi`
--
ALTER TABLE `tbl_detail_transaksi`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `no_nota` (`no_nota`),
  ADD KEY `kode_menu` (`kode_menu`);

--
-- Indeks untuk tabel `tbl_kategori`
--
ALTER TABLE `tbl_kategori`
  ADD PRIMARY KEY (`kode_kategori`);

--
-- Indeks untuk tabel `tbl_member`
--
ALTER TABLE `tbl_member`
  ADD PRIMARY KEY (`no_telepon`);

--
-- Indeks untuk tabel `tbl_menu`
--
ALTER TABLE `tbl_menu`
  ADD PRIMARY KEY (`kode_menu`),
  ADD KEY `kode_kategori` (`kode_kategori`);

--
-- Indeks untuk tabel `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`no_nota`),
  ADD KEY `no_telepon` (`no_telepon`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_detail_transaksi`
--
ALTER TABLE `tbl_detail_transaksi`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_detail_transaksi`
--
ALTER TABLE `tbl_detail_transaksi`
  ADD CONSTRAINT `fk_detail_menu` FOREIGN KEY (`kode_menu`) REFERENCES `tbl_menu` (`kode_menu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_detail_transaksi` FOREIGN KEY (`no_nota`) REFERENCES `tbl_transaksi` (`no_nota`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_menu`
--
ALTER TABLE `tbl_menu`
  ADD CONSTRAINT `fk_menu_kategori` FOREIGN KEY (`kode_kategori`) REFERENCES `tbl_kategori` (`kode_kategori`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD CONSTRAINT `fk_transaksi_member` FOREIGN KEY (`no_telepon`) REFERENCES `tbl_member` (`no_telepon`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
