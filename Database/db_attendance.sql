-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 02, 2022 at 04:29 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_attendance`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_dtr`
--

CREATE TABLE `tb_dtr` (
  `id` int(11) NOT NULL,
  `HashKey` varchar(128) NOT NULL,
  `Day` date NOT NULL,
  `TimeIn` time NOT NULL,
  `TimeOut` time NOT NULL,
  `HoursWorked` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_dtr`
--

INSERT INTO `tb_dtr` (`id`, `HashKey`, `Day`, `TimeIn`, `TimeOut`, `HoursWorked`) VALUES
(17, '36b3fc0d-e12d-44f6-a675-73d4470e5c8c', '2022-07-30', '18:25:47', '18:26:03', 0),
(18, '589081a9-95ea-46ed-9341-0ed1cad86eae', '2022-07-30', '23:18:32', '23:18:39', 0),
(20, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-24', '09:24:25', '21:24:25', 8),
(21, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-26', '14:24:25', '18:24:25', 0),
(22, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-25', '10:27:01', '12:27:01', 8.2),
(25, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-26', '16:27:30', '18:27:30', 2),
(26, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-27', '06:27:30', '18:27:30', 2),
(27, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-28', '06:27:30', '18:27:30', 10),
(28, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', '2022-07-29', '13:27:30', '18:27:30', 7);

-- --------------------------------------------------------

--
-- Table structure for table `tb_employee_details`
--

CREATE TABLE `tb_employee_details` (
  `em_Id` int(11) NOT NULL,
  `em_uid` varchar(128) NOT NULL,
  `em_FullName` varchar(128) NOT NULL,
  `em_Description` varchar(128) NOT NULL,
  `em_Gender` tinyint(1) NOT NULL,
  `em_Address` varchar(256) NOT NULL,
  `em_Performance` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_employee_details`
--

INSERT INTO `tb_employee_details` (`em_Id`, `em_uid`, `em_FullName`, `em_Description`, `em_Gender`, `em_Address`, `em_Performance`) VALUES
(1, 'd526d1cc-fc8d-457e-bec1-35f69ac53256', 'Yrielly Lee D. Esguerra', 'Waiter', 0, 'Malusak Atimonan, Quezon', 0),
(3, 'a0bc4b34-0d44-4e81-8adc-6ff56c144892', 'Gernel M. Esguerra', 'Janitor', 1, 'Malusak Atimonan, Quezon', 13.39),
(4, '21485e0f-d0ac-4e4e-8a97-0d35d6e99b6e', 'Keren Jemima M. Parcon', 'Clerk', 0, 'Ba-ay Calbayog, Samar', 0),
(7, '0a8cd377-2e47-4992-9e2c-0ca0fd62adcc', 'Liezel Cavite', 'Teacher', 0, 'CAvite', 0),
(21, '83c1eeb1-5859-4880-8b20-cec3618b88b4', 'Natoy', 'Janitor', 1, 'Doon', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tb_role`
--

CREATE TABLE `tb_role` (
  `id` int(11) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_role`
--

INSERT INTO `tb_role` (`id`, `Username`, `Password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_dtr`
--
ALTER TABLE `tb_dtr`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_employee_details`
--
ALTER TABLE `tb_employee_details`
  ADD PRIMARY KEY (`em_Id`);

--
-- Indexes for table `tb_role`
--
ALTER TABLE `tb_role`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_dtr`
--
ALTER TABLE `tb_dtr`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `tb_employee_details`
--
ALTER TABLE `tb_employee_details`
  MODIFY `em_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `tb_role`
--
ALTER TABLE `tb_role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
