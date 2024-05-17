-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2024 at 11:45 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `d_penduduk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_penduduk`
--

CREATE TABLE `tb_penduduk` (
  `no` int(4) NOT NULL,
  `nkk` varchar(16) NOT NULL,
  `nik` varchar(16) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `tanggal` varchar(255) NOT NULL,
  `tempat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_penduduk`
--

INSERT INTO `tb_penduduk` (`no`, `nkk`, `nik`, `nama`, `gender`, `tanggal`, `tempat`) VALUES
(7, '6472031111040002', '6472030101040002', 'Muhammad Ali Wahidyan', 'Laki-laki', '2004-02-13 00:00:00 ', 'Samarinda'),
(8, '6472031111110008', '6472032306000008', 'Joy Disanto Nupa', 'Laki-laki', '2024-01-23 00:00:00 ', 'Samarinda'),
(16, '6472032211040006', '6472032211040006', 'Muhammad Rifan Fathon', 'Laki-laki', '2004-11-21 00:00:00 ', 'Balikpapan');

-- --------------------------------------------------------

--
-- Table structure for table `tb_surat`
--

CREATE TABLE `tb_surat` (
  `no_surat` int(4) NOT NULL,
  `nik` varchar(16) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `tanggal_buat` varchar(255) NOT NULL,
  `keperluan` varchar(255) NOT NULL,
  `nkk` varchar(16) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `tanggal` varchar(255) NOT NULL,
  `tempat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_surat`
--

INSERT INTO `tb_surat` (`no_surat`, `nik`, `nama`, `tanggal_buat`, `keperluan`, `nkk`, `gender`, `tanggal`, `tempat`) VALUES
(1, '6472032306000008', 'Joy Disanto Nupa', '2024-05-17 17:20:21.326', 'Mengurus Surat Nikah', '6472031111110008', 'Laki-laki', '2024-01-23 00:00:00 ', 'Samarinda');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_penduduk`
--
ALTER TABLE `tb_penduduk`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `tb_surat`
--
ALTER TABLE `tb_surat`
  ADD PRIMARY KEY (`no_surat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_penduduk`
--
ALTER TABLE `tb_penduduk`
  MODIFY `no` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
