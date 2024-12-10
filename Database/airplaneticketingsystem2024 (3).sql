-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2024 at 03:03 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `airplaneticketingsystem2024`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `AccountID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` char(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`AccountID`, `FirstName`, `LastName`, `Email`, `Password`) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', 'c6ba91b90d922e159893f46c387e5dc1b3dc5c101a5a4522f03b987177a24a91'),
(3, 'Charles', 'Togle', 'charles3togle@gmail.com', '28e91b84bd4ac1d95d81b4510777d2b12f3dffa848bb6e219a42f98cdfa06d7d'),
(4, 'stefanie', 'gabion', 'sgabion.k12148528@umak.edu.ph', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');

-- --------------------------------------------------------

--
-- Table structure for table `airport`
--

CREATE TABLE `airport` (
  `AirportID` int(11) NOT NULL,
  `AirportCode` varchar(10) NOT NULL,
  `AirportFullName` varchar(255) NOT NULL,
  `AirportLocation` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `airport`
--

INSERT INTO `airport` (`AirportID`, `AirportCode`, `AirportFullName`, `AirportLocation`) VALUES
(1, 'ATL', 'Hartsfield-Jackson Atlanta International Airport', 'Atlanta, GA'),
(2, 'LAX', 'Los Angeles International Airport', 'Los Angeles, CA'),
(3, 'NAIA', 'Ninoy Aquino Airport', 'Pasay City, PH'),
(4, 'DFW', 'Dallas/Fort Worth International Airport', 'Dallas, TX'),
(5, 'DEN', 'Denver International Airport', 'Denver, CO'),
(6, 'JFK', 'John F. Kennedy International Airport', 'New York, NY'),
(7, 'SFO', 'San Francisco International Airport', 'San Francisco, CA'),
(8, 'SEA', 'Seattle-Tacoma International Airport', 'Seattle, WA'),
(9, 'MIA', 'Miami International Airport', 'Miami, FL'),
(10, 'BOS', 'Logan International Airport', 'Boston, MA'),
(11, 'CEB', 'Mactan-Cebu International Airport', 'Cebu, PH'),
(12, 'DVO', 'Francisco Bangoy International Airport', 'Davao City, PH'),
(13, 'ILO', 'Iloilo International Airport', 'Iloilo City, PH'),
(14, 'BCD', 'Bacolod-Silay Airport', 'Bacolod City, PH'),
(15, 'CGY', 'Laguindingan Airport', 'Cagayan de Oro, PH');

-- --------------------------------------------------------

--
-- Table structure for table `flights`
--

CREATE TABLE `flights` (
  `FlightID` int(11) NOT NULL,
  `AirplaneNumber` varchar(255) NOT NULL,
  `DepartureDate` datetime NOT NULL,
  `ArrivalDate` datetime NOT NULL,
  `DepartureAirportID` int(11) DEFAULT NULL,
  `ArrivalAirportID` int(11) DEFAULT NULL,
  `SeatsRemaining` int(11) NOT NULL,
  `SeatingCapacity` int(11) NOT NULL,
  `TimeDifference` int(11) GENERATED ALWAYS AS (timestampdiff(HOUR,`DepartureDate`,`ArrivalDate`)) VIRTUAL,
  `FlightPrice` int(11) NOT NULL,
  `Type` varchar(13) NOT NULL DEFAULT 'Local' CHECK (`Type` in ('Local','International'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flights`
--

INSERT INTO `flights` (`FlightID`, `AirplaneNumber`, `DepartureDate`, `ArrivalDate`, `DepartureAirportID`, `ArrivalAirportID`, `SeatsRemaining`, `SeatingCapacity`, `FlightPrice`, `Type`) VALUES
(1, 'AA101', '2024-12-01 08:00:00', '2024-12-01 11:00:00', 1, 2, 147, 180, 1200, 'International'),
(2, 'AA102', '2024-12-02 14:00:00', '2024-12-02 17:00:00', 2, 1, 160, 180, 2300, 'International'),
(3, 'DL201', '2024-12-03 09:30:00', '2024-12-03 12:30:00', 3, 4, 170, 200, 1800, 'International'),
(4, 'DL202', '2024-12-04 13:00:00', '2024-12-04 16:00:00', 4, 3, 165, 200, 2500, 'International'),
(5, 'UA301', '2024-12-05 10:00:00', '2024-12-05 14:00:00', 5, 6, 180, 200, 1200, 'International'),
(6, 'UA302', '2024-12-06 15:30:00', '2024-12-06 19:30:00', 6, 5, 175, 200, 1350, 'International'),
(7, 'SW401', '2024-12-07 11:00:00', '2024-12-07 13:30:00', 7, 8, 90, 120, 800, 'International'),
(8, 'SW402', '2024-12-08 16:00:00', '2024-12-08 18:30:00', 8, 7, 95, 120, 950, 'International'),
(9, 'BA501', '2024-12-09 06:00:00', '2024-12-09 10:00:00', 9, 10, 80, 100, 1500, 'International'),
(10, 'BA502', '2024-12-10 18:00:00', '2024-12-10 22:00:00', 10, 9, 85, 100, 2000, 'International'),
(11, 'AF601', '2024-12-11 07:00:00', '2024-12-11 12:00:00', 1, 5, 140, 160, 2200, 'International'),
(12, 'AF602', '2024-12-12 14:30:00', '2024-12-12 19:30:00', 5, 1, 135, 160, 1800, 'International'),
(13, 'LH701', '2024-12-13 10:00:00', '2024-12-13 15:00:00', 2, 7, 100, 120, 1200, 'International'),
(14, 'LH702', '2024-12-14 16:00:00', '2024-12-14 21:00:00', 7, 2, 105, 120, 1400, 'International'),
(15, 'EK801', '2024-12-15 09:00:00', '2024-12-15 14:00:00', 3, 8, 160, 180, 3000, 'International'),
(16, 'EK802', '2024-12-16 13:30:00', '2024-12-16 18:30:00', 8, 3, 155, 180, 3500, 'International'),
(17, 'QF901', '2024-12-17 08:30:00', '2024-12-17 11:30:00', 4, 9, 120, 150, 2500, 'International'),
(18, 'QF902', '2024-12-18 17:00:00', '2024-12-18 20:00:00', 9, 4, 115, 150, 3000, 'International'),
(19, 'NH1001', '2024-12-19 06:00:00', '2024-12-19 11:00:00', 6, 10, 200, 220, 1800, 'International'),
(20, 'NH1002', '2024-12-20 19:00:00', '2024-12-20 23:59:00', 10, 6, 190, 220, 2000, 'International'),
(21, 'VS1101', '2024-12-21 07:45:00', '2024-12-21 11:45:00', 1, 6, 130, 150, 1500, 'International'),
(22, 'VS1102', '2024-12-22 15:30:00', '2024-12-22 19:30:00', 6, 1, 125, 150, 1700, 'International'),
(23, 'CX1201', '2024-12-23 09:15:00', '2024-12-23 12:15:00', 2, 8, 110, 130, 2000, 'International'),
(24, 'CX1202', '2024-12-24 18:00:00', '2024-12-24 21:00:00', 8, 2, 105, 130, 2200, 'International'),
(25, 'SQ1301', '2024-12-25 08:00:00', '2024-12-25 12:00:00', 3, 10, 145, 160, 1800, 'International'),
(26, 'SQ1302', '2024-12-26 17:00:00', '2024-12-26 21:00:00', 10, 3, 140, 160, 1700, 'International'),
(27, 'QR1401', '2024-12-27 07:30:00', '2024-12-27 11:00:00', 4, 7, 170, 200, 2600, 'International'),
(28, 'QR1402', '2024-12-28 14:45:00', '2024-12-28 18:15:00', 7, 4, 165, 200, 2700, 'International'),
(29, 'JL1501', '2024-12-29 05:45:00', '2024-12-29 09:45:00', 5, 9, 180, 220, 2800, 'International'),
(30, 'JL1502', '2024-12-30 20:00:00', '2024-12-30 23:59:00', 9, 5, 175, 220, 3500, 'International'),
(43, 'PR101', '2024-12-07 06:00:00', '2024-12-07 07:15:00', 3, 11, 150, 180, 3500, 'Local'),
(44, 'PR102', '2024-12-07 10:30:00', '2024-12-07 11:45:00', 11, 3, 150, 180, 3500, 'Local'),
(45, 'PR103', '2024-12-08 06:00:00', '2024-12-08 07:15:00', 3, 11, 150, 180, 3500, 'Local'),
(46, 'PR104', '2024-12-08 10:30:00', '2024-12-08 11:45:00', 11, 3, 150, 180, 3500, 'Local'),
(47, 'PR201', '2024-12-09 07:00:00', '2024-12-09 08:30:00', 3, 12, 160, 180, 4000, 'Local'),
(48, 'PR202', '2024-12-09 11:00:00', '2024-12-09 12:30:00', 12, 3, 160, 180, 4000, 'Local'),
(49, 'PR203', '2024-12-10 07:00:00', '2024-12-10 08:30:00', 3, 12, 160, 180, 4000, 'Local'),
(50, 'PR204', '2024-12-10 11:00:00', '2024-12-10 12:30:00', 12, 3, 160, 180, 4000, 'Local'),
(51, 'PR301', '2024-12-11 08:00:00', '2024-12-11 09:00:00', 3, 13, 130, 160, 2800, 'Local'),
(52, 'PR302', '2024-12-11 12:00:00', '2024-12-11 13:00:00', 13, 3, 130, 160, 2800, 'Local'),
(53, 'PR303', '2024-12-12 08:00:00', '2024-12-12 09:00:00', 3, 13, 130, 160, 2800, 'Local'),
(54, 'PR304', '2024-12-12 12:00:00', '2024-12-12 13:00:00', 13, 3, 130, 160, 2800, 'Local'),
(55, 'PR401', '2024-12-13 09:00:00', '2024-12-13 10:00:00', 3, 14, 140, 160, 2900, 'Local'),
(56, 'PR402', '2024-12-13 13:00:00', '2024-12-13 14:00:00', 14, 3, 140, 160, 2900, 'Local'),
(57, 'PR403', '2024-12-14 09:00:00', '2024-12-14 10:00:00', 3, 14, 140, 160, 2900, 'Local'),
(58, 'PR404', '2024-12-14 13:00:00', '2024-12-14 14:00:00', 14, 3, 138, 160, 2900, 'Local'),
(59, 'PR501', '2024-12-15 07:30:00', '2024-12-15 09:00:00', 3, 15, 150, 180, 3200, 'Local'),
(60, 'PR502', '2024-12-15 12:30:00', '2024-12-15 14:00:00', 15, 3, 150, 180, 3200, 'Local'),
(61, 'PR503', '2024-12-16 07:30:00', '2024-12-16 09:00:00', 3, 15, 150, 180, 3200, 'Local'),
(62, 'PR504', '2024-12-16 12:30:00', '2024-12-16 14:00:00', 15, 3, 150, 180, 3200, 'Local'),
(63, 'PR601', '2024-12-17 10:00:00', '2024-12-17 11:00:00', 11, 12, 120, 150, 2500, 'Local'),
(64, 'PR602', '2024-12-17 14:00:00', '2024-12-17 15:00:00', 12, 11, 120, 150, 2500, 'Local'),
(65, 'PR603', '2024-12-18 10:00:00', '2024-12-18 11:00:00', 11, 12, 120, 150, 2500, 'Local'),
(66, 'PR604', '2024-12-18 14:00:00', '2024-12-18 15:00:00', 12, 11, 120, 150, 2500, 'Local'),
(67, 'PR701', '2024-12-19 08:30:00', '2024-12-19 09:30:00', 11, 13, 110, 140, 2300, 'Local'),
(68, 'PR702', '2024-12-19 12:30:00', '2024-12-19 13:30:00', 13, 11, 110, 140, 2300, 'Local'),
(69, 'PR703', '2024-12-20 08:30:00', '2024-12-20 09:30:00', 11, 13, 110, 140, 2300, 'Local'),
(70, 'PR704', '2024-12-20 12:30:00', '2024-12-20 13:30:00', 13, 11, 110, 140, 2300, 'Local');

-- --------------------------------------------------------

--
-- Table structure for table `flights_backup`
--

CREATE TABLE `flights_backup` (
  `FlightID` int(11) NOT NULL DEFAULT 0,
  `AirplaneNumber` varchar(255) NOT NULL,
  `DepartureDate` datetime NOT NULL,
  `ArrivalDate` datetime NOT NULL,
  `DepartureAirportID` int(11) DEFAULT NULL,
  `ArrivalAirportID` int(11) DEFAULT NULL,
  `SeatsRemaining` int(11) NOT NULL,
  `SeatingCapacity` int(11) NOT NULL,
  `TimeDifference` int(11) DEFAULT NULL,
  `FlightPrice` int(11) NOT NULL,
  `Type` varchar(13) NOT NULL DEFAULT 'Local' CHECK (`Type` in ('Local','International'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flights_backup`
--

INSERT INTO `flights_backup` (`FlightID`, `AirplaneNumber`, `DepartureDate`, `ArrivalDate`, `DepartureAirportID`, `ArrivalAirportID`, `SeatsRemaining`, `SeatingCapacity`, `TimeDifference`, `FlightPrice`, `Type`) VALUES
(1, 'AA101', '2024-12-01 08:00:00', '2024-12-01 11:00:00', 1, 2, 150, 180, 3, 1200, 'International'),
(2, 'AA102', '2024-12-02 14:00:00', '2024-12-02 17:00:00', 2, 1, 160, 180, 3, 2300, 'International'),
(3, 'DL201', '2024-12-03 09:30:00', '2024-12-03 12:30:00', 3, 4, 170, 200, 3, 1800, 'International'),
(4, 'DL202', '2024-12-04 13:00:00', '2024-12-04 16:00:00', 4, 3, 165, 200, 3, 2500, 'International'),
(5, 'UA301', '2024-12-05 10:00:00', '2024-12-05 14:00:00', 5, 6, 180, 200, 4, 1200, 'International'),
(6, 'UA302', '2024-12-06 15:30:00', '2024-12-06 19:30:00', 6, 5, 175, 200, 4, 1350, 'International'),
(7, 'SW401', '2024-12-07 11:00:00', '2024-12-07 13:30:00', 7, 8, 90, 120, 2, 800, 'International'),
(8, 'SW402', '2024-12-08 16:00:00', '2024-12-08 18:30:00', 8, 7, 95, 120, 2, 950, 'International'),
(9, 'BA501', '2024-12-09 06:00:00', '2024-12-09 10:00:00', 9, 10, 80, 100, 4, 1500, 'International'),
(10, 'BA502', '2024-12-10 18:00:00', '2024-12-10 22:00:00', 10, 9, 85, 100, 4, 2000, 'International'),
(11, 'AF601', '2024-12-11 07:00:00', '2024-12-11 12:00:00', 1, 5, 140, 160, 5, 2200, 'International'),
(12, 'AF602', '2024-12-12 14:30:00', '2024-12-12 19:30:00', 5, 1, 135, 160, 5, 1800, 'International'),
(13, 'LH701', '2024-12-13 10:00:00', '2024-12-13 15:00:00', 2, 7, 100, 120, 5, 1200, 'International'),
(14, 'LH702', '2024-12-14 16:00:00', '2024-12-14 21:00:00', 7, 2, 105, 120, 5, 1400, 'International'),
(15, 'EK801', '2024-12-15 09:00:00', '2024-12-15 14:00:00', 3, 8, 160, 180, 5, 3000, 'International'),
(16, 'EK802', '2024-12-16 13:30:00', '2024-12-16 18:30:00', 8, 3, 155, 180, 5, 3500, 'International'),
(17, 'QF901', '2024-12-17 08:30:00', '2024-12-17 11:30:00', 4, 9, 120, 150, 3, 2500, 'International'),
(18, 'QF902', '2024-12-18 17:00:00', '2024-12-18 20:00:00', 9, 4, 115, 150, 3, 3000, 'International'),
(19, 'NH1001', '2024-12-19 06:00:00', '2024-12-19 11:00:00', 6, 10, 200, 220, 5, 1800, 'International'),
(20, 'NH1002', '2024-12-20 19:00:00', '2024-12-20 23:59:00', 10, 6, 190, 220, 4, 2000, 'International'),
(21, 'VS1101', '2024-12-21 07:45:00', '2024-12-21 11:45:00', 1, 6, 130, 150, 4, 1500, 'International'),
(22, 'VS1102', '2024-12-22 15:30:00', '2024-12-22 19:30:00', 6, 1, 125, 150, 4, 1700, 'International'),
(23, 'CX1201', '2024-12-23 09:15:00', '2024-12-23 12:15:00', 2, 8, 110, 130, 3, 2000, 'International'),
(24, 'CX1202', '2024-12-24 18:00:00', '2024-12-24 21:00:00', 8, 2, 105, 130, 3, 2200, 'International'),
(25, 'SQ1301', '2024-12-25 08:00:00', '2024-12-25 12:00:00', 3, 10, 145, 160, 4, 1800, 'International'),
(26, 'SQ1302', '2024-12-26 17:00:00', '2024-12-26 21:00:00', 10, 3, 140, 160, 4, 1700, 'International'),
(27, 'QR1401', '2024-12-27 07:30:00', '2024-12-27 11:00:00', 4, 7, 170, 200, 3, 2600, 'International'),
(28, 'QR1402', '2024-12-28 14:45:00', '2024-12-28 18:15:00', 7, 4, 165, 200, 3, 2700, 'International'),
(29, 'JL1501', '2024-12-29 05:45:00', '2024-12-29 09:45:00', 5, 9, 180, 220, 4, 2800, 'International'),
(30, 'JL1502', '2024-12-30 20:00:00', '2024-12-30 23:59:00', 9, 5, 175, 220, 3, 3500, 'International'),
(31, 'PR123', '2024-12-07 06:00:00', '2024-12-07 07:15:00', 3, 11, 150, 180, 1, 3500, 'Local'),
(32, 'PR124', '2024-12-07 08:30:00', '2024-12-07 09:45:00', 11, 3, 150, 180, 1, 3500, 'Local'),
(33, 'PR125', '2024-12-07 07:00:00', '2024-12-07 08:30:00', 3, 12, 160, 180, 1, 4000, 'Local'),
(34, 'PR126', '2024-12-07 10:00:00', '2024-12-07 11:00:00', 3, 13, 140, 160, 1, 3000, 'Local'),
(35, 'PR127', '2024-12-07 13:00:00', '2024-12-07 14:00:00', 3, 14, 130, 160, 1, 2800, 'Local'),
(36, 'PR123', '2024-12-07 06:00:00', '2024-12-07 07:15:00', 3, 11, 150, 180, 1, 3500, 'Local'),
(37, 'PR124', '2024-12-07 08:30:00', '2024-12-07 09:45:00', 11, 3, 150, 180, 1, 3500, 'Local'),
(38, 'PR125', '2024-12-07 07:00:00', '2024-12-07 08:30:00', 3, 12, 160, 180, 1, 4000, 'Local'),
(39, 'PR126', '2024-12-07 10:00:00', '2024-12-07 11:00:00', 3, 13, 140, 160, 1, 3000, 'Local'),
(40, 'PR127', '2024-12-07 13:00:00', '2024-12-07 14:00:00', 3, 14, 130, 160, 1, 2800, 'Local'),
(41, 'PR101', '2024-12-07 06:00:00', '2024-12-07 07:15:00', 3, 11, 150, 180, 1, 3500, 'Local'),
(42, 'PR102', '2024-12-07 08:30:00', '2024-12-07 09:45:00', 11, 3, 150, 180, 1, 3500, 'Local');

-- --------------------------------------------------------

--
-- Table structure for table `passengers`
--

CREATE TABLE `passengers` (
  `PassengerID` int(11) NOT NULL,
  `TransactionID` int(11) DEFAULT NULL,
  `Type` enum('Adult','Infant','Kid') NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Age` int(11) NOT NULL,
  `Birthdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `passengers`
--

INSERT INTO `passengers` (`PassengerID`, `TransactionID`, `Type`, `FirstName`, `LastName`, `Age`, `Birthdate`) VALUES
(1, 1, '', 'stefanie', 'gabion', 20, '2004-10-30 00:00:00'),
(2, 1, '', 'charles', 'togle', 19, '2005-05-17 00:00:00'),
(3, 2, '', 'stefanie', 'gabion', 20, '2004-10-30 00:00:00'),
(4, 2, '', 'charles', 'togle', 19, '2005-05-17 00:00:00'),
(5, 2, '', 'hu tao', 'togle', 2, '2023-02-28 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `TransactionID` int(11) DEFAULT NULL,
  `ModeOfPayment` varchar(255) NOT NULL,
  `ReferenceNo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `ticketdetails`
--

CREATE TABLE `ticketdetails` (
  `TicketID` int(11) NOT NULL,
  `TransactionID` int(11) DEFAULT NULL,
  `FlightID` int(11) DEFAULT NULL,
  `NumberOfTickets` int(11) NOT NULL DEFAULT 1,
  `Children` int(11) NOT NULL DEFAULT 0,
  `Infant` int(11) NOT NULL DEFAULT 0,
  `Food` enum('Yes','No') NOT NULL,
  `Baggage` enum('Yes','No') NOT NULL,
  `TransferServices` enum('Yes','No') NOT NULL,
  `TotalPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ticketdetails`
--

INSERT INTO `ticketdetails` (`TicketID`, `TransactionID`, `FlightID`, `NumberOfTickets`, `Children`, `Infant`, `Food`, `Baggage`, `TransferServices`, `TotalPrice`) VALUES
(1, 1, 58, 2, 1, 0, 'Yes', 'Yes', 'No', 6188),
(2, 2, 1, 3, 1, 1, 'No', 'Yes', 'No', 5236);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `TransactionID` int(11) NOT NULL,
  `AccountID` int(11) DEFAULT NULL,
  `BookingDate` datetime NOT NULL,
  `ReferenceNo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`TransactionID`, `AccountID`, `BookingDate`, `ReferenceNo`) VALUES
(1, 4, '2024-12-07 16:26:10', 'ATS422451223'),
(2, 4, '2024-12-07 17:43:41', 'ATS626571975');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`AccountID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `airport`
--
ALTER TABLE `airport`
  ADD PRIMARY KEY (`AirportID`),
  ADD UNIQUE KEY `AirportCode` (`AirportCode`);

--
-- Indexes for table `flights`
--
ALTER TABLE `flights`
  ADD PRIMARY KEY (`FlightID`),
  ADD KEY `DepartureAirportID` (`DepartureAirportID`),
  ADD KEY `ArrivalAirportID` (`ArrivalAirportID`);

--
-- Indexes for table `passengers`
--
ALTER TABLE `passengers`
  ADD PRIMARY KEY (`PassengerID`),
  ADD KEY `TransactionID` (`TransactionID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `TransactionID` (`TransactionID`);

--
-- Indexes for table `ticketdetails`
--
ALTER TABLE `ticketdetails`
  ADD PRIMARY KEY (`TicketID`),
  ADD KEY `TransactionID` (`TransactionID`),
  ADD KEY `FlightID` (`FlightID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransactionID`),
  ADD UNIQUE KEY `ReferenceNo` (`ReferenceNo`),
  ADD KEY `AccountID` (`AccountID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `airport`
--
ALTER TABLE `airport`
  MODIFY `AirportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `flights`
--
ALTER TABLE `flights`
  MODIFY `FlightID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `passengers`
--
ALTER TABLE `passengers`
  MODIFY `PassengerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ticketdetails`
--
ALTER TABLE `ticketdetails`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransactionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `flights`
--
ALTER TABLE `flights`
  ADD CONSTRAINT `flights_ibfk_1` FOREIGN KEY (`DepartureAirportID`) REFERENCES `airport` (`AirportID`),
  ADD CONSTRAINT `flights_ibfk_2` FOREIGN KEY (`ArrivalAirportID`) REFERENCES `airport` (`AirportID`);

--
-- Constraints for table `passengers`
--
ALTER TABLE `passengers`
  ADD CONSTRAINT `passengers_ibfk_1` FOREIGN KEY (`TransactionID`) REFERENCES `transactions` (`TransactionID`) ON UPDATE CASCADE;

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`TransactionID`) REFERENCES `transactions` (`TransactionID`) ON UPDATE CASCADE;

--
-- Constraints for table `ticketdetails`
--
ALTER TABLE `ticketdetails`
  ADD CONSTRAINT `ticketdetails_ibfk_1` FOREIGN KEY (`TransactionID`) REFERENCES `transactions` (`TransactionID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `ticketdetails_ibfk_2` FOREIGN KEY (`FlightID`) REFERENCES `flights` (`FlightID`) ON UPDATE CASCADE;

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `accounts` (`AccountID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
