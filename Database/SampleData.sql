-- Insert data into Airport table
INSERT INTO Airport (AirportID, AirportCode, AirportFullName) VALUES
(1, 'JFK', 'John F. Kennedy International Airport'),
(2, 'LAX', 'Los Angeles International Airport'),
(3, 'ORD', 'Ohare International Airport'),
(4, 'SFO', 'San Francisco International Airport'),
(5, 'MIA', 'Miami International Airport'),
(6, 'ATL', 'Hartsfield-Jackson Atlanta International Airport');

-- Insert data into Flights table
INSERT INTO Flights (FlightID, AirplaneNumber, DepartureDate, ArrivalDate, DepartureAirportID, ArrivalAirportID, SeatsRemaining, SeatingCapacity) VALUES
(1, 'AP123', '2024-12-01 08:00:00', '2024-12-01 12:00:00', 1, 2, 50, 100),
(2, 'AP456', '2024-12-05 14:00:00', '2024-12-05 18:30:00', 3, 4, 75, 100),
(3, 'AP789', '2024-12-10 09:00:00', '2024-12-10 13:00:00', 5, 6, 60, 80);

-- Insert data into Accounts table
INSERT INTO Accounts (AccountID, FirstName, LastName, Email, Password, PhoneNumber) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', SHA2('password123', 256), '123-456-7890'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', SHA2('password456', 256), '098-765-4321');

-- Insert data into Transactions table, ensuring AccountID 1 has three transactions
INSERT INTO Transactions (TransactionID, AccountID, BookingDate, ReferenceNo) VALUES
(1, 1, '2024-11-01 10:30:00', 'TXN123456789'),
(2, 1, '2024-11-02 11:15:00', 'TXN987654321'),
(3, 1, '2024-11-03 12:45:00', 'TXN456789123'),
(4, 2, '2024-11-04 14:00:00', 'TXN654321987'),
(5, 2, '2024-11-05 16:20:00', 'TXN321654987'),
(6, 2, '2024-11-06 09:00:00', 'TXN789123654');

-- Insert data into Passengers table
INSERT INTO Passengers (PassengerID, TransactionID, Type, FirstName, LastName, Age, Birthdate) VALUES
(1, 1, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(2, 2, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(3, 3, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(4, 4, 'Adult', 'Jane', 'Smith', 29, '1995-02-20'),
(5, 5, 'Adult', 'Jane', 'Smith', 29, '1995-02-20'),
(6, 6, 'Adult', 'Jane', 'Smith', 29, '1995-02-20');

-- Insert data into TicketDetails table
INSERT INTO TicketDetails (TicketID, TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) VALUES
(1, 1, 1, 1, 0, 0, 'Yes', 'Yes', 'No', 300),
(2, 2, 2, 1, 0, 0, 'No', 'Yes', 'Yes', 350),
(3, 3, 3, 1, 0, 0, 'Yes', 'No', 'No', 400),
(4, 4, 1, 1, 0, 0, 'Yes', 'Yes', 'Yes', 450),
(5, 5, 2, 1, 0, 0, 'No', 'No', 'Yes', 370),
(6, 6, 3, 1, 0, 0, 'Yes', 'Yes', 'No', 380);

-- Insert data into Payment table
INSERT INTO Payment (PaymentID, TransactionID, ModeOfPayment, ReferenceNo) VALUES
(1, 1, 'Credit Card', 'REF123456789'),
(2, 2, 'Debit Card', 'REF987654321'),
(3, 3, 'Paypal', 'REF456789123'),
(4, 4, 'Credit Card', 'REF654321987'),
(5, 5, 'Bank Transfer', 'REF321654987'),
(6, 6, 'Credit Card', 'REF789123654');


UPDATE `airport` SET `AirportLocation` = 'New York, USA' WHERE `airport`.`AirportID` = 1;
UPDATE `airport` SET `AirportLocation` = 'Los Angeles, California' WHERE `airport`.`AirportID` = 2;
UPDATE `airport` SET `AirportLocation` = 'Chicago, USA' WHERE `airport`.`AirportID` = 3;
UPDATE `airport` SET `AirportLocation` = 'San Francisco, California, USA' WHERE `airport`.`AirportID` = 4;
UPDATE `airport` SET `AirportLocation` = 'Miami, Florida, USA' WHERE `airport`.`AirportID` = 5;
UPDATE `airport` SET `AirportLocation` = 'Atlantis' WHERE `airport`.`AirportID` = 6 ;