-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2022 at 09:58 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.0.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_uji_level_muhamad_fardan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbljurusan`
--

CREATE TABLE `tbljurusan` (
  `id_jurusan` varchar(50) CHARACTER SET utf8 NOT NULL,
  `nama_jurusan` varchar(50) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbljurusan`
--

INSERT INTO `tbljurusan` (`id_jurusan`, `nama_jurusan`) VALUES
('001', 'Multimedia'),
('002', 'Teknik Komputer dan Jaringan'),
('003', 'Rekayasa Perangkat Lunak'),
('004', 'Teknik Komputer dan Jaringan');

-- --------------------------------------------------------

--
-- Table structure for table `tblsiswa`
--

CREATE TABLE `tblsiswa` (
  `nik` varchar(50) CHARACTER SET utf8 NOT NULL,
  `nama` varchar(50) CHARACTER SET utf8 NOT NULL,
  `jenis_kelamin` varchar(50) CHARACTER SET utf8 NOT NULL,
  `tanggal_lahir` varchar(50) CHARACTER SET utf8 NOT NULL,
  `id_jurusan` varchar(50) CHARACTER SET utf8 NOT NULL,
  `nama_jurusan` varchar(50) CHARACTER SET utf8 NOT NULL,
  `umur` varchar(50) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsiswa`
--

INSERT INTO `tblsiswa` (`nik`, `nama`, `jenis_kelamin`, `tanggal_lahir`, `id_jurusan`, `nama_jurusan`, `umur`) VALUES
('1101201', 'Muhamad Fardan', 'Laki-laki', '23 November 2006', '001', 'Multimedia', '16'),
('1101202', 'Vincent Noval', 'Perempuan', '18 November 2007', '004', 'Teknik Komputer dan Jaringan', '10'),
('1101204', 'Julian', 'Perempuan', '90 november ', '001', 'Multimedia', '11'),
('1101205', 'Mario ', 'Perempuan', '11 april', '002', 'Teknik Komputer dan Jaringan', '1'),
('1101206', 'Agata', 'Perempuan', '20 maret', '002', 'Teknik Komputer dan Jaringan', '16'),
('1101208', 'Pram', 'Laki-laki', '15 desewmber 2006', '001', 'Multimedia', '17'),
('1107675775', 'rabil', 'Laki-laki', '65 january 2007', '002', 'Teknik Komputer dan Jaringan', '86');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbljurusan`
--
ALTER TABLE `tbljurusan`
  ADD PRIMARY KEY (`id_jurusan`);

--
-- Indexes for table `tblsiswa`
--
ALTER TABLE `tblsiswa`
  ADD PRIMARY KEY (`nik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
