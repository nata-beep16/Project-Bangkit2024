-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2022 at 02:12 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pro_kos`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(3) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `no_hp` varchar(15) NOT NULL,
  `ID_user` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ID`, `nama`, `no_hp`, `ID_user`) VALUES
(1, 'natalia', '111', 1),
(2, 'jojo', '444', 2);

-- --------------------------------------------------------

--
-- Table structure for table `kos`
--

CREATE TABLE `kos` (
  `ID` int(3) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `lokasi` varchar(30) NOT NULL,
  `owner` varchar(45) NOT NULL,
  `penjaga` varchar(45) NOT NULL,
  `no_hp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kos`
--

INSERT INTO `kos` (`ID`, `nama`, `lokasi`, `owner`, `penjaga`, `no_hp`) VALUES
(1, 'aaa', 'aaa', 'ss', 'sss', '111');

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `ID` int(3) NOT NULL,
  `name` varchar(45) NOT NULL,
  `no_hp` varchar(15) NOT NULL,
  `ID_user` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`ID`, `name`, `no_hp`, `ID_user`) VALUES
(1, 'student1', '222', 3);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(3) NOT NULL,
  `username` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL,
  `level` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `password`, `level`) VALUES
(1, 'admin1', 'admin1', 1),
(2, 'dosen1', 'dosen1', 2),
(3, 'student1', 'student1', 3),
(4, 'user1', 'user1', 3),
(5, 'user2', 'user2', 1),
(6, 'user6', 'user6', 3),
(7, 'user4', 'user4', 1),
(8, 'nicolas1', 'nicolas1', 3);

-- --------------------------------------------------------

--
-- Table structure for table `vd`
--

CREATE TABLE `vd` (
  `ID` int(3) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `no_hp` varchar(15) NOT NULL,
  `ID_user` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vd`
--

INSERT INTO `vd` (`ID`, `nama`, `no_hp`, `ID_user`) VALUES
(1, 'dosen1', '333', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_user` (`ID_user`);

--
-- Indexes for table `kos`
--
ALTER TABLE `kos`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_user` (`ID_user`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `vd`
--
ALTER TABLE `vd`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_user` (`ID_user`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`ID_user`) REFERENCES `user` (`ID`);

--
-- Constraints for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD CONSTRAINT `mahasiswa_ibfk_1` FOREIGN KEY (`ID_user`) REFERENCES `user` (`ID`);

--
-- Constraints for table `vd`
--
ALTER TABLE `vd`
  ADD CONSTRAINT `vd_ibfk_1` FOREIGN KEY (`ID_user`) REFERENCES `user` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
