USE master;
GO

 IF EXISTS(SELECT name FROM sys.databases
     WHERE name = 'AddressBook')
     DROP DATABASE AddressBook
GO

CREATE DATABASE AddressBook
ON 
( NAME = AddressBook_dat,
    FILENAME = 'D:\myusuf\AddressBook\AddressBook_dat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = AddressBook_log,
    FILENAME = 'D:\myusuf\AddressBook\AddressBook_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;
GO

USE AddressBook;
GO

CREATE TABLE [AddressBook].[dbo].[Addresses](
	AddressID INT NOT NULL IDENTITY (1000,1),
	FirstName VARCHAR (15) NOT NULL,
	LastName VARCHAR (30) NOT NULL,
	Email VARCHAR (50) NOT NULL,
	PhoneNumber VARCHAR (15) NOT NULL
	CONSTRAINT 		Addresses_PK 	PRIMARY KEY(AddressID)	
);

INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES ('Willis', 'John', 'JWillis@students.ccsnh.edu', '555-5555');

INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES ('Anderson', 'Joshua', 'JAnderson@students.ccsnh.edu','555-5555');

INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Therrien', 'Valerie', 'VTherrien@students.ccsnh.edu', '555-5555');


INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES ('Carter', 'Keegan', 'KCarter@students.ccsnh.edu', '555-5555');

INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Eaton', 'Nicholas', 'NEaton@students.ccsnh.edu', '555-5555');
INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Griffin', 'Stephen', 'SGriffin@students.ccsnh.edu', '555-5555');
INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Maville', 'Mindy', 'MMaville@students.ccsnh.edu', '555-5555');
INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Nelson', 'Darren', 'DNelson@students.ccsnh.edu', '555-5555');
INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Odom', 'Brendan',  'BOdom@students.ccsnh.edu', '555-5555');

INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Tuttle', 'Andrew', 'ATuttle@students.ccsnh.edu', '555-5555');
INSERT INTO AddressBook..Addresses (LastName, FirstName, Email, PhoneNumber)
VALUES 	('Willis', 'John', 'JWillis@students.ccsnh.edu', '555-5555');
	


