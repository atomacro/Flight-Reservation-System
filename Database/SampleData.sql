-- Flights Table
INSERT INTO Flights (FlightID, AirplaneNumber, DepartureDate, DepartureFrom, DepartureTo, SeatsRemaining, SeatingCapacity) VALUES
(1, '1A', '2024-10-30 08:00:00', 'Manila', 'Siargao', 55, 100),
(2, '2A', '2024-11-03 14:00:00', 'Siargao', 'Manila', 55, 100),
(3, '3B', '2024-11-05 09:00:00', 'Manila', 'Cebu', 75, 120),
(4, '4C', '2024-11-07 12:00:00', 'Manila', 'Davao', 45, 90),
(5, '5D', '2024-11-09 16:00:00', 'Manila', 'Boracay', 30, 80),
(6, '6E', '2024-11-10 10:30:00', 'Cebu', 'Manila', 60, 120),
(7, '7F', '2024-11-12 11:45:00', 'Davao', 'Cebu', 50, 100),
(8, '8G', '2024-11-14 13:20:00', 'Manila', 'Palawan', 70, 100),
(9, '9H', '2024-11-16 17:00:00', 'Palawan', 'Manila', 40, 80),
(10, '10I', '2024-11-18 08:00:00', 'Manila', 'Batanes', 30, 60);

-- Accounts Table
INSERT INTO Accounts (AccountID, FirstName, LastName, Email, Password, PhoneNumber) VALUES
(1, 'Stefanie', 'Gabion', 'stefanie@gmail.com', '123', '1234567890'),
(2, 'John', 'Doe', 'johndoe@gmail.com', 'abc123', '2345678901'),
(3, 'Jane', 'Smith', 'janesmith@gmail.com', 'pass456', '3456789012'),
(4, 'Michael', 'Johnson', 'mjohnson@gmail.com', 'pass789', '4567890123'),
(5, 'Lisa', 'Brown', 'lisa_brown@gmail.com', 'password', '5678901234'),
(6, 'Charles', 'Togle', 'charlestogle@gmail.com', 'securepass', '6789012345'),
(7, 'Oliver', 'Clark', 'oliverclark@gmail.com', 'mypassword', '7890123456'),
(8, 'Sophia', 'Lee', 'sophialee@gmail.com', 'soph123', '8901234567'),
(9, 'James', 'Wilson', 'jwilson@gmail.com', 'wilpass', '9012345678'),
(10, 'Emily', 'Martinez', 'emartinez@gmail.com', 'martinez', '0123456789');

-- Transactions Table
INSERT INTO Transactions (TransactionID, AccountID, BookingDate) VALUES
(1, 1, '2024-10-24 10:00:00'),
(2, 2, '2024-10-25 12:00:00'),
(3, 3, '2024-10-26 14:30:00'),
(4, 4, '2024-10-27 09:00:00'),
(5, 5, '2024-10-28 15:00:00'),
(6, 6, '2024-10-29 16:00:00'),
(7, 7, '2024-10-30 18:30:00'),
(8, 8, '2024-10-31 20:00:00'),
(9, 9, '2024-11-01 10:15:00'),
(10, 10, '2024-11-02 13:45:00');


-- Passengers Table
INSERT INTO Passengers (PassengerID, TransactionID, Type, FirstName, LastName, Age, Birthdate) VALUES
(1, 1, 'Adult', 'Stefanie', 'Gabion', 20, '2004-10-30'),
(2, 1, 'Infant', 'Charles', 'Togle', 5, '2005-05-17'),
(3, 2, 'Adult', 'John', 'Doe', 35, '1989-02-12'),
(4, 3, 'Adult', 'Jane', 'Smith', 28, '1996-04-08'),
(5, 3, 'Kid', 'Mia', 'Smith', 6, '2018-11-25'),
(6, 2, 'Kid', 'Liam', 'Doe', 10, '2014-05-15'),
(7, 6, 'Adult', 'Emma', 'White', 32, '1992-03-14'),
(8, 7, 'Adult', 'Oliver', 'Clark', 45, '1979-08-23'),
(9, 8, 'Infant', 'Sophia', 'Lee', 1, '2023-09-11'),
(10, 9, 'Adult', 'James', 'Wilson', 55, '1969-12-02');

-- Payment Table
INSERT INTO Payment (PaymentID, TransactionID, ModeOfPayment, ReferenceNo) VALUES
(1, 1, 'Gcash', '12345 6789'),
(2, 2, 'Credit Card', '98765 4321'),
(3, 3, 'PayPal', '45678 1234'),
(4, 4, 'Credit Card', '65432 1987'),
(5, 5, 'Gcash', '11111 2222'),
(6, 6, 'PayPal', '1234567890'),
(7, 7, 'Credit Card', '2345678901'),
(8, 8, 'Gcash', '3456789012'),
(9, 9, 'PayPal', '4567890123'),
(10, 10, 'Credit Card', '5678901234');


-- TicketDetails Table
INSERT INTO TicketDetails (TicketID, TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) VALUES
(1, 1, 1, 3, 1, 1, 'Yes', 'Yes', 'Yes', 100),
(2, 1, 2, 5, 3, 1, 'Yes', 'Yes', 'Yes', 150),
(3, 2, 3, 1, 0, 0, 'No', 'Yes', 'No', 70),
(4, 3, 4, 2, 1, 0, 'Yes', 'No', 'Yes', 90),
(5, 4, 5, 1, 0, 0, 'No', 'Yes', 'Yes', 80),
(6, 2, 6, 2, 1, 0, 'Yes', 'No', 'Yes', 120),
(7, 6, 7, 3, 1, 1, 'Yes', 'Yes', 'No', 150),
(8, 7, 8, 1, 0, 0, 'No', 'Yes', 'Yes', 70),
(9, 8, 9, 4, 2, 0, 'Yes', 'No', 'No', 200),
(10, 9, 10, 2, 0, 0, 'No', 'Yes', 'Yes', 80);
