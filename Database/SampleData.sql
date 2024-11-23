USE `AirplaneTicketingSystem2024`;

-- Insert data into Airport table
INSERT INTO Airport (AirportCode, AirportFullName, AirportLocation) VALUES
('JFK', 'John F. Kennedy International Airport', 'New York, USA'),
('LAX', 'Los Angeles International Airport', 'Los Angeles, California, USA'),
('ORD', 'Ohare International Airport', 'Chicago, USA'),
('SFO', 'San Francisco International Airport', 'San Francisco, California, USA'),
('MIA', 'Miami International Airport', 'Miami, Florida, USA'),
('ATL', 'Hartsfield-Jackson Atlanta International Airport', 'Atlantis');

-- Insert data into Flights table
INSERT INTO Flights (AirplaneNumber, DepartureDate, ArrivalDate, DepartureAirportID, ArrivalAirportID, SeatsRemaining, SeatingCapacity) VALUES
('AP123', '2024-12-01 08:00:00', '2024-12-01 12:00:00', 1, 2, 50, 100, 1500),
('AP456', '2024-12-05 14:00:00', '2024-12-05 18:30:00', 3, 4, 75, 100 2000),
('AP789', '2024-12-10 09:00:00', '2024-12-10 13:00:00', 5, 6, 60, 80 2500);

-- Insert data into Accounts table
INSERT INTO Accounts (FirstName, LastName, Email, Password) VALUES
('John', 'Doe', 'john.doe@example.com', SHA2('password123', 256)),
('Jane', 'Smith', 'jane.smith@example.com', SHA2('password456', 256));

-- Insert data into Transactions table
INSERT INTO Transactions (AccountID, BookingDate, ReferenceNo) VALUES
(1, '2024-11-01 10:30:00', 'TXN123456789'),
(1, '2024-11-02 11:15:00', 'TXN987654321'),
(1, '2024-11-03 12:45:00', 'TXN456789123'),
(2, '2024-11-04 14:00:00', 'TXN654321987'),
(2, '2024-11-05 16:20:00', 'TXN321654987'),
(2, '2024-11-06 09:00:00', 'TXN789123654');

-- Insert data into Passengers table
INSERT INTO Passengers (TransactionID, Type, FirstName, LastName, Age, Birthdate) VALUES
(1, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(2, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(3, 'Adult', 'John', 'Doe', 35, '1989-06-15'),
(4, 'Adult', 'Jane', 'Smith', 29, '1995-02-20'),
(5, 'Adult', 'Jane', 'Smith', 29, '1995-02-20'),
(6, 'Adult', 'Jane', 'Smith', 29, '1995-02-20');

-- Insert data into TicketDetails table
INSERT INTO TicketDetails (TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) VALUES
(1, 1, 1, 0, 0, 'Yes', 'Yes', 'No', 300),
(2, 2, 1, 0, 0, 'No', 'Yes', 'Yes', 350),
(3, 3, 1, 0, 0, 'Yes', 'No', 'No', 400),
(4, 1, 1, 0, 0, 'Yes', 'Yes', 'Yes', 450),
(5, 2, 1, 0, 0, 'No', 'No', 'Yes', 370),
(6, 3, 1, 0, 0, 'Yes', 'Yes', 'No', 380);

-- Insert data into Payment table
INSERT INTO Payment (TransactionID, ModeOfPayment, ReferenceNo) VALUES
(1, 'Credit Card', 'REF123456789'),
(2, 'Debit Card', 'REF987654321'),
(3, 'Paypal', 'REF456789123'),
(4, 'Credit Card', 'REF654321987'),
(5, 'Bank Transfer', 'REF321654987'),
(6, 'Credit Card', 'REF789123654');