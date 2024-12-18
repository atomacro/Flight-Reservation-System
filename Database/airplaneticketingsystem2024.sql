CREATE DATABASE `airplaneticketingsystem2024`;
USE `airplaneticketingsystem2024`;

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

INSERT INTO flights (FlightID, AirplaneNumber, DepartureDate, ArrivalDate, DepartureAirportID, ArrivalAirportID, SeatsRemaining, SeatingCapacity, FlightPrice, Type)
WITH RECURSIVE numbers AS (
    SELECT 1 AS num
    UNION ALL
    SELECT num + 1 FROM numbers WHERE num < 25
),
international_flights AS (
    SELECT 
        numbers.num AS n,
        -- Outbound flight
        CONCAT('INT', LPAD(numbers.num*2-1, 3, '0')) as outbound_num,
        DATE_ADD(NOW(), INTERVAL numbers.num DAY) + INTERVAL FLOOR(6 + RAND() * 6) HOUR as outbound_dep,
        -- Return flight
        CONCAT('INT', LPAD(numbers.num*2, 3, '0')) as return_num,
        180 + FLOOR(RAND() * 40) as capacity,
        1500 + FLOOR(RAND() * 2000) as price,
        1 + MOD(numbers.num - 1, 10) as dep_airport,  -- Ensures sequential airport selection
        1 + MOD(numbers.num % 10, 10) as arr_airport  -- Different from dep_airport but still within range
    FROM numbers
),
local_flights AS (
    SELECT 
        numbers.num + 25 AS n,
        -- Outbound flight
        CONCAT('LOC', LPAD(numbers.num*2-1, 3, '0')) as outbound_num,
        DATE_ADD(NOW(), INTERVAL numbers.num DAY) + INTERVAL FLOOR(6 + RAND() * 6) HOUR as outbound_dep,
        -- Return flight
        CONCAT('LOC', LPAD(numbers.num*2, 3, '0')) as return_num,
        140 + FLOOR(RAND() * 40) as capacity,
        2500 + FLOOR(RAND() * 1500) as price,
        11 + MOD(numbers.num - 1, 5) as dep_airport,  -- Ensures sequential airport selection
        11 + MOD(numbers.num % 5, 5) as arr_airport   -- Different from dep_airport but still within range
    FROM numbers
)SELECT 
    FlightID,
    AirplaneNumber,
    DepartureDate,
    DATE_ADD(DepartureDate, 
        INTERVAL CASE 
            WHEN Type = 'International' THEN 3 + FLOOR(RAND() * 4)
            ELSE 1 + FLOOR(RAND() * 2)
        END HOUR) as ArrivalDate,
    DepartureAirportID,
    ArrivalAirportID,
    SeatingCapacity as SeatsRemaining,
    SeatingCapacity,
    FlightPrice,
    Type
FROM (
    -- Outbound International Flights
    SELECT 
        i.n*2-1 as FlightID,
        i.outbound_num as AirplaneNumber,
        i.outbound_dep as DepartureDate,
        i.dep_airport as DepartureAirportID,
        i.arr_airport as ArrivalAirportID,
        i.capacity as SeatingCapacity,
        i.price as FlightPrice,
        'International' as Type
    FROM international_flights i
    UNION ALL
    -- Return International Flights
    SELECT 
        i.n*2 as FlightID,
        i.return_num as AirplaneNumber,
        DATE_ADD(i.outbound_dep, INTERVAL 2 + FLOOR(RAND() * 2) DAY) + INTERVAL FLOOR(6 + RAND() * 6) HOUR as DepartureDate,
        i.arr_airport as DepartureAirportID,
        i.dep_airport as ArrivalAirportID,
        i.capacity as SeatingCapacity,
        i.price as FlightPrice,
        'International' as Type
    FROM international_flights i
    UNION ALL
    -- Outbound Local Flights
    SELECT 
        l.n*2-1 as FlightID,
        l.outbound_num as AirplaneNumber,
        l.outbound_dep as DepartureDate,
        l.dep_airport as DepartureAirportID,
        l.arr_airport as ArrivalAirportID,
        l.capacity as SeatingCapacity,
        l.price as FlightPrice,
        'Local' as Type
    FROM local_flights l
    UNION ALL
    -- Return Local Flights
    SELECT 
        l.n*2 as FlightID,
        l.return_num as AirplaneNumber,
        DATE_ADD(l.outbound_dep, INTERVAL 4 + FLOOR(RAND() * 4) HOUR) as DepartureDate,
        l.arr_airport as DepartureAirportID,
        l.dep_airport as ArrivalAirportID,
        l.capacity as SeatingCapacity,
        l.price as FlightPrice,
        'Local' as Type
    FROM local_flights l
) all_flights
WHERE DepartureAirportID != ArrivalAirportID
ORDER BY DepartureDate;

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