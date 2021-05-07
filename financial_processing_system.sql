-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2021 at 02:53 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `financial_processing_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `AID` int(11) NOT NULL,
  `uname` varchar(50) DEFAULT NULL,
  `pass` varchar(50) DEFAULT NULL,
  `Fname` varchar(50) NOT NULL,
  `mname` varchar(10) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `posi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`AID`, `uname`, `pass`, `Fname`, `mname`, `lname`, `posi`) VALUES
(1, 'admin', 'admin123', '', '', '', ''),
(2, 'ben', 'admin', 'benedict', 'g', 'bautista', 'treasurer'),
(3, 'darusername', 'darpassword', 'dar', 'dave', 'proceso', 'pres');

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `EID` int(11) NOT NULL,
  `event_name` varchar(50) NOT NULL,
  `date` varchar(50) NOT NULL,
  `particular` varchar(255) NOT NULL,
  `cost` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `etotal` int(11) NOT NULL,
  `a_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`EID`, `event_name`, `date`, `particular`, `cost`, `quantity`, `etotal`, `a_name`) VALUES
(1, 'Basketball Summer Cup', 'May 1, 2021', 'Referees', 500, 2, 1000, 'admin'),
(2, 'Basketball Summer Cup', 'May 1, 2021', 'Basketbal court', 500, 3, 1500, 'admin'),
(3, 'clean-up drive', '04-19-2021', 'walis tambo', 30, 4, 120, 'ben'),
(5, 'clean-up drive', '04-20-2021', 'Walis Tingting', 30, 10, 300, 'ben'),
(10, '', '04-23-2021', 'blue book', 250, 3, 750, 'ben'),
(11, '', '04-23-2021', 't-shirt', 30, 50, 1500, 'admin'),
(12, '', '04-23-2021', 'sando', 30, 50, 1500, 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PID` int(11) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mname` varchar(10) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `blk` int(11) NOT NULL,
  `lot` int(11) NOT NULL,
  `street` varchar(20) NOT NULL,
  `date` varchar(20) NOT NULL,
  `amount` int(11) NOT NULL,
  `a_name` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`PID`, `fname`, `mname`, `lname`, `blk`, `lot`, `street`, `date`, `amount`, `a_name`) VALUES
(1, 'angelica', 'd', 'cruz', 24, 35, 'camio', '03-24-2021', 300, 'ben'),
(2, 'benedict', 'g', 'bautista', 23, 17, 'camio', '01-25-2021', 300, 'admin'),
(3, 'rachel', 'd', 'villigracia', 36, 17, 'manggo', '01-6-2021', 300, 'admin'),
(4, 'dariel', 'p', 'proceso', 34, 23, 'kaliwa', '01-27-2021', 300, 'admin'),
(5, 'jerilaine', 'd', 'chan', 24, 31, 'liwat', '02-17-2021', 300, 'admin'),
(6, 'angelina', 'g', 'bautista', 22, 32, 'lanete', '02-17-2021', 300, 'ben'),
(7, 'moy', 'P', 'capistrano', 23, 42, 'kaligtasan', '02-17-2021', 300, 'ben'),
(8, 'angelo', 'd', 'cumbao', 34, 23, '42', '02-17-2021', 300, 'admin'),
(9, 'benedict', 'g', 'bautista', 44, 23, 'lante', '02-17-2021', 300, 'ben'),
(11, 'camille', 'e', 'lustre', 33, 22, '12', '02-17-2021', 300, 'ben'),
(12, 'paulmer', 's', 'alcantara', 33, 23, '24', '02-17-2021', 300, 'ben'),
(13, 'angelina', 'g', 'bautista', 54, 34, 'camio', '02-17-2021', 300, 'ben'),
(14, 'sonia', 'r', 'dela cruz', 65, 34, 'kanete', '17-00-2021', 300, 'ben'),
(15, 'darius', 'e', 'salmero', 12, 32, 'langas', '02-17-2021', 300, 'ben'),
(16, 'jose', 'r', 'somio', 23, 12, 'luan', '04-14-2021', 300, 'ben'),
(17, 'paolo', 'd', 'santo', 12, 32, 'luan', '04-18-2021', 300, 'ben'),
(18, 'vince', 'd', 'palarca', 43, 23, 'street', '04-18-2021', 300, 'ben'),
(19, 'dar', 'dar', 'dar', 1, 2, 'santol', '04-18-2021', 500, 'admin'),
(20, 'roger', 'w', 'raker', 42, 23, 'santol', '04-14-2021', 1200, 'ben');

-- --------------------------------------------------------

--
-- Table structure for table `personnel`
--

CREATE TABLE `personnel` (
  `PID` int(11) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mname` varchar(10) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `con_num` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `AID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `personnel`
--

INSERT INTO `personnel` (`PID`, `fname`, `mname`, `lname`, `con_num`, `address`, `AID`) VALUES
(1, 'john', 'paulmer', 'alcantara', '09123456789', 'B-14 L-15 GwapoSiPaulmer Street ', '2'),
(2, 'moy', 'moy', 'capistrano', '09501234567', 'B-20 L-25 GwapoSiPaulmer Street ', '3');

-- --------------------------------------------------------

--
-- Table structure for table `resident`
--

CREATE TABLE `resident` (
  `RID` int(11) NOT NULL,
  `fname` varchar(20) DEFAULT NULL,
  `mname` varchar(20) DEFAULT NULL,
  `lname` varchar(20) DEFAULT NULL,
  `blk` int(11) DEFAULT NULL,
  `lot` int(11) DEFAULT NULL,
  `street` varchar(20) DEFAULT NULL,
  `contnum` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `resident`
--

INSERT INTO `resident` (`RID`, `fname`, `mname`, `lname`, `blk`, `lot`, `street`, `contnum`) VALUES
(1, 'benedict', 'g', 'bautista', 33, 17, 'lanete', '09292859961'),
(2, 'christian ', 'd', 'cullados', 24, 12, 'caimito', '09292895961'),
(3, 'System.Windows.Forms', 'System.Windows.Forms', 'System.Windows.Forms', 0, 0, 'System.Windows.Forms', 'System.Windows.Forms');

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `SID` int(11) NOT NULL,
  `AID` varchar(20) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `date` varchar(11) NOT NULL,
  `hours` int(11) NOT NULL,
  `days` int(11) NOT NULL,
  `total_sal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`SID`, `AID`, `fname`, `mname`, `lname`, `date`, `hours`, `days`, `total_sal`) VALUES
(1, 'ben', 'christian', 's', 'cullados', '2021', 23, 12, 24),
(2, 'ben', 'paulmer', 'g', 'alcantara', '42', 43, 23, 10000),
(3, 'ben', 'louis', 'd', 'moya', '44', 34, 10, 12000),
(4, 'ben', 'benedict', 'g', 'bautista', '52-17-2021', 23, 10, 8000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AID`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`EID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PID`),
  ADD KEY `AID` (`a_name`);

--
-- Indexes for table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`PID`);

--
-- Indexes for table `resident`
--
ALTER TABLE `resident`
  ADD PRIMARY KEY (`RID`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`SID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `AID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `EID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `PID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `resident`
--
ALTER TABLE `resident`
  MODIFY `RID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `SID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
