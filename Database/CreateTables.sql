CREATE DATABASE `AirplaneTicketingSystem2024`;
USE `AirplaneTicketingSystem2024`;

-- Create Airport table
CREATE TABLE Airport (
    AirportID INT PRIMARY KEY,
    AirportCode VARCHAR(10) NOT NULL UNIQUE,
    AirportFullName VARCHAR(255) NOT NULL
);

-- Create Flights table with foreign keys referencing Airport table
CREATE TABLE Flights (
    FlightID INT PRIMARY KEY,
    AirplaneNumber VARCHAR(255) NOT NULL,
    DepartureDate DATETIME NOT NULL,
    ArrivalDate DATETIME NOT NULL,
    DepartureAirportID INT,
    ArrivalAirportID INT,
    SeatsRemaining INT NOT NULL,
    SeatingCapacity INT NOT NULL,
    TimeDifference INT GENERATED ALWAYS AS (TIMESTAMPDIFF(HOUR, DepartureDate, ArrivalDate)),
    FOREIGN KEY (DepartureAirportID) REFERENCES Airport(AirportID),
    FOREIGN KEY (ArrivalAirportID) REFERENCES Airport(AirportID)
);

-- Create Accounts table
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Password CHAR(64) NOT NULL,  -- Assuming a hashed password
    PhoneNumber VARCHAR(255) NOT NULL
);

-- Create Transactions table with added ReferenceNo column
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY,
    AccountID INT,
    BookingDate DATETIME NOT NULL,
    ReferenceNo VARCHAR(255) NOT NULL UNIQUE,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID) ON UPDATE CASCADE
);

-- Create Passengers table
CREATE TABLE Passengers (
    PassengerID INT PRIMARY KEY,
    TransactionID INT,
    Type ENUM('Adult', 'Infant', 'Kid') NOT NULL,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Age INT NOT NULL,
    Birthdate DATETIME NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON UPDATE CASCADE
);

-- Create TicketDetails table
CREATE TABLE TicketDetails (
    TicketID INT PRIMARY KEY,
    TransactionID INT,
    FlightID INT,
    NumberOfTickets INT NOT NULL DEFAULT 1,
    Children INT NOT NULL DEFAULT 0,
    Infant INT NOT NULL DEFAULT 0,
    Food ENUM('Yes', 'No') NOT NULL,
    Baggage ENUM('Yes', 'No') NOT NULL,
    TransferServices ENUM('Yes', 'No') NOT NULL,
    TotalPrice INT NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON UPDATE CASCADE,
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID) ON UPDATE CASCADE
);

-- Create Payment table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    TransactionID INT,
    ModeOfPayment VARCHAR(255) NOT NULL,
    ReferenceNo VARCHAR(255) NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON UPDATE CASCADE
);
