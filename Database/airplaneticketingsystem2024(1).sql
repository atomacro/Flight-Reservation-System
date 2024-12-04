-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 30, 2024 at 08:00 AM
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
(3, 'Charles', 'Togle', 'charles3togle@gmail.com', '28e91b84bd4ac1d95d81b4510777d2b12f3dffa848bb6e219a42f98cdfa06d7d');

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
(3, 'NAIA', 'Ninoy Aquino Airport', 'Manila, PH'),
(4, 'DFW', 'Dallas/Fort Worth International Airport', 'Dallas, TX'),
(5, 'DEN', 'Denver International Airport', 'Denver, CO'),
(6, 'JFK', 'John F. Kennedy International Airport', 'New York, NY'),
(7, 'SFO', 'San Francisco International Airport', 'San Francisco, CA'),
(8, 'SEA', 'Seattle-Tacoma International Airport', 'Seattle, WA'),
(9, 'MIA', 'Miami International Airport', 'Miami, FL'),
(10, 'BOS', 'Logan International Airport', 'Boston, MA');

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
  `FlightPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flights`
--

INSERT INTO `flights` (`FlightID`, `AirplaneNumber`, `DepartureDate`, `ArrivalDate`, `DepartureAirportID`, `ArrivalAirportID`, `SeatsRemaining`, `SeatingCapacity`, `FlightPrice`) VALUES
(1, 'AA101', '2024-12-01 08:00:00', '2024-12-01 11:00:00', 1, 2, 150, 180, 1200),
(2, 'AA102', '2024-12-02 14:00:00', '2024-12-02 17:00:00', 2, 1, 160, 180, 2300),
(3, 'DL201', '2024-12-03 09:30:00', '2024-12-03 12:30:00', 3, 4, 170, 200, 1800),
(4, 'DL202', '2024-12-04 13:00:00', '2024-12-04 16:00:00', 4, 3, 165, 200, 2500),
(5, 'UA301', '2024-12-05 10:00:00', '2024-12-05 14:00:00', 5, 6, 180, 200, 1200),
(6, 'UA302', '2024-12-06 15:30:00', '2024-12-06 19:30:00', 6, 5, 175, 200, 1350),
(7, 'SW401', '2024-12-07 11:00:00', '2024-12-07 13:30:00', 7, 8, 90, 120, 800),
(8, 'SW402', '2024-12-08 16:00:00', '2024-12-08 18:30:00', 8, 7, 95, 120, 950),
(9, 'BA501', '2024-12-09 06:00:00', '2024-12-09 10:00:00', 9, 10, 80, 100, 1500),
(10, 'BA502', '2024-12-10 18:00:00', '2024-12-10 22:00:00', 10, 9, 85, 100, 2000),
(11, 'AF601', '2024-12-11 07:00:00', '2024-12-11 12:00:00', 1, 5, 140, 160, 2200),
(12, 'AF602', '2024-12-12 14:30:00', '2024-12-12 19:30:00', 5, 1, 135, 160, 1800),
(13, 'LH701', '2024-12-13 10:00:00', '2024-12-13 15:00:00', 2, 7, 100, 120, 1200),
(14, 'LH702', '2024-12-14 16:00:00', '2024-12-14 21:00:00', 7, 2, 105, 120, 1400),
(15, 'EK801', '2024-12-15 09:00:00', '2024-12-15 14:00:00', 3, 8, 160, 180, 3000),
(16, 'EK802', '2024-12-16 13:30:00', '2024-12-16 18:30:00', 8, 3, 155, 180, 3500),
(17, 'QF901', '2024-12-17 08:30:00', '2024-12-17 11:30:00', 4, 9, 120, 150, 2500),
(18, 'QF902', '2024-12-18 17:00:00', '2024-12-18 20:00:00', 9, 4, 115, 150, 3000),
(19, 'NH1001', '2024-12-19 06:00:00', '2024-12-19 11:00:00', 6, 10, 200, 220, 1800),
(20, 'NH1002', '2024-12-20 19:00:00', '2024-12-20 23:59:00', 10, 6, 190, 220, 2000),
(21, 'VS1101', '2024-12-21 07:45:00', '2024-12-21 11:45:00', 1, 6, 130, 150, 1500),
(22, 'VS1102', '2024-12-22 15:30:00', '2024-12-22 19:30:00', 6, 1, 125, 150, 1700),
(23, 'CX1201', '2024-12-23 09:15:00', '2024-12-23 12:15:00', 2, 8, 110, 130, 2000),
(24, 'CX1202', '2024-12-24 18:00:00', '2024-12-24 21:00:00', 8, 2, 105, 130, 2200),
(25, 'SQ1301', '2024-12-25 08:00:00', '2024-12-25 12:00:00', 3, 10, 145, 160, 1800),
(26, 'SQ1302', '2024-12-26 17:00:00', '2024-12-26 21:00:00', 10, 3, 140, 160, 1700),
(27, 'QR1401', '2024-12-27 07:30:00', '2024-12-27 11:00:00', 4, 7, 170, 200, 2600),
(28, 'QR1402', '2024-12-28 14:45:00', '2024-12-28 18:15:00', 7, 4, 165, 200, 2700),
(29, 'JL1501', '2024-12-29 05:45:00', '2024-12-29 09:45:00', 5, 9, 180, 220, 2800),
(30, 'JL1502', '2024-12-30 20:00:00', '2024-12-30 23:59:00', 9, 5, 175, 220, 3500);

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
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `airport`
--
ALTER TABLE `airport`
  MODIFY `AirportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `flights`
--
ALTER TABLE `flights`
  MODIFY `FlightID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `passengers`
--
ALTER TABLE `passengers`
  MODIFY `PassengerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT for table `ticketdetails`
--
ALTER TABLE `ticketdetails`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransactionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

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
