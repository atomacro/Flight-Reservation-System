CREATE DATABASE `Airplane Ticketing System 2024`;

USE `Airplane Ticketing System 2024`;

CREATE TABLE Flights (
    FlightID INT PRIMARY KEY,
    AirplaneNumber VARCHAR(255) NOT NULL,
    DepartureDate DATETIME NOT NULL,
    DepartureFrom VARCHAR(255) NOT NULL,
    DepartureTo VARCHAR(255) NOT NULL,
    SeatsRemaining INT NOT NULL,
    SeatingCapacity INT NOT NULL
);

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(255) NOT NULL
);

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY,
    AccountID INT,
    BookingDate DATETIME NOT NULL,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID) ON UPDATE CASCADE
);

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

CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    TransactionID INT,
    ModeOfPayment VARCHAR(255) NOT NULL,
    ReferenceNo VARCHAR(255) NOT NULL,
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON UPDATE CASCADE
);
