USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'CUSTOMER_ORDER')
     DROP DATABASE CUSTOMER_ORDER
GO

--'D:\Yusuf\CUSTOMER_ORDER_dat.mdf',
--'H:\Yusuf\Lectures\IT140\Common Files\TEMPWORK\CUSTOMER_ORDER_dat.mdf',
CREATE DATABASE CUSTOMER_ORDER
ON 
( NAME = CUSTOMER_ORDER_dat,
    FILENAME = 'D:\Yusuf\CUSTOMER_ORDER_dat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = CUSTOMER_ORDER_log,
    FILENAME = 'D:\Yusuf\CUSTOMER_ORDER_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;

GO

USE CUSTOMER_ORDER;
GO


CREATE TABLE CUSTOMER(
		CustomerID		Int					NOT NULL IDENTITY (1,1),
		CustomerName	Char(75)			NOT NULL,
		EmailDomain		VarChar(100)		NOT NULL,
		PhoneAreaCode	Char(6)				NOT NULL,
		City			Char(35)			NULL,
		[State]			Char(2)				NULL,
		ZIP				Char(10)			NULL,
		CONSTRAINT 		CUSTOMER_PK 		PRIMARY KEY(CustomerID)
		);

CREATE TABLE [ORDER](
		OrderNum		int					NOT NULL IDENTITY (1000,1),
		ProductNumber	Char(35)			NOT NULL,
		ProductType		Char(25)			NOT NULL,
		ProductName 	VarChar(75)			NOT NULL,
		CustomerID		Int					NULL
		CONSTRAINT 		ORDER_PK			PRIMARY KEY(OrderNum), 
		CONSTRAINT 		CUSTOMER_ORDER_FK	FOREIGN KEY (CustomerID)
						REFERENCES CUSTOMER (CustomerID)
		);

INSERT INTO CUSTOMER VALUES(
	'Jacobs, Nancy', 'somewhere.com',
	'817', 'Fort Worth', 'TX', '76110');
INSERT INTO CUSTOMER VALUES(
	'Jacobs, Chantel', 'somewhere.com',
	'817', 'Fort Worth', 'TX', '76112');
INSERT INTO CUSTOMER VALUES(
	'Able, Ralph','somewhere.com', 
	'210', 'San Antonio', 'TX', '78214');
INSERT INTO CUSTOMER VALUES(
	'Baker, Susan','elsewhere.com', 
	'210', 'San Antonio', 'TX', '78216');
INSERT INTO CUSTOMER VALUES(
	'Eagleton, Sam', 'elsewhere.com', 
	'210', 'San Antonio', 'TX', '78218');
INSERT INTO CUSTOMER VALUES(
	'Foxtrot, Kathy', 'somewhere.com', 
	'972', 'Dallas', 'TX', '75220');
INSERT INTO CUSTOMER VALUES(
	'George, Sally', 'somewhere.com', 
	'972', 'Dallas', 'TX', '75223');

	
INSERT INTO [ORDER] VALUES(
		'VK001', 'DVD Video', 'Kitchen Remodeling Basics', 4);
INSERT INTO [ORDER] VALUES(
		'VK002', 'DVD Video', 'Advanced Kitchen Remodeling', 5);
INSERT INTO [ORDER] VALUES(
		'VK003', 'DVD Video', 'Kitchen Remodeling Dallas Style',2);
INSERT INTO [ORDER] VALUES(
		'VK004', 'DVD Video', 'Heather Sweeny Seminar Live in Dallas on 25-OCT-07',2 );
INSERT INTO [ORDER] VALUES(
		'VB001', 'Video Companion', 'Kitchen Remodeling Basics Video Companion', 4);
INSERT INTO [ORDER] VALUES(
		'BK002', 'Book', 'Advanced Kitchen Remodeling For Everyone', 1);
INSERT INTO [ORDER] VALUES(
		'BK004', 'Book', 'Datebase Design and Implementation',null);

SELECT COUNT(*) FROM CUSTOMER;
SELECT  C.CustomerID, C.CustomerName, C.City, C.State
 FROM CUSTOMER AS C;

SELECT O.OrderNum, O.CustomerID, O.ProductNumber, O.ProductType, O.ProductName
 FROM [ORDER] AS O ORDER BY OrderNum, CustomerID;

SELECT O.OrderNum, O.CustomerID, C.CustomerName, C.City, O.ProductName  
	FROM [ORDER] O, CUSTOMER C
	WHERE O.CustomerID = C.CustomerID;



SELECT * FROM [ORDER] ORDER BY OrderNum, CustomerID;
SELECT  * FROM CUSTOMER AS C;


--SELECT  C.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
--FROM CUSTOMER AS C, [ORDER] AS O;

-- DISPLAY All Customers who have an order
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C, [ORDER] AS O
WHERE C.CustomerID = O.CustomerID
ORDER BY C.CustomerID ASC;


/*
 JOIN: Return rows when there is at least one match in both tables
 LEFT JOIN: Return all rows from the left table, even if there are no matches in the right table
 RIGHT JOIN: Return all rows from the right table, even if there are no matches in the left table
 FULL JOIN: Return rows when there is a match in one of the tables
*/


-- DISPLAY All Customers who have an order using a join statement
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C JOIN [ORDER] AS O ON 
	C.CustomerID = O.CustomerID
ORDER BY C.CustomerID ASC;

----------------------------------------------------------------
SELECT * FROM [ORDER];
GO
-- DISPLAY All Customers who have an order using a LEFT join statement
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C LEFT JOIN [ORDER] AS O ON 
	C.CustomerID = O.CustomerID
ORDER BY C.CustomerID ASC;

----------------------------------------------------------------
SELECT * FROM [ORDER];
GO
-- DISPLAY All Customers who have an order using a LEFT join statement
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C RIGHT JOIN [ORDER] AS O ON 
	C.CustomerID = O.CustomerID
ORDER BY C.CustomerID ASC;

----------------------------------------------------------------
SELECT * FROM [ORDER];
GO
-- DISPLAY All Customers who have an order using a LEFT join statement
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C FULL JOIN [ORDER] AS O ON 
	C.CustomerID = O.CustomerID
ORDER BY C.CustomerID ASC;


