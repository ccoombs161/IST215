USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'CUSTOMER_ORDER')
     DROP DATABASE CUSTOMER_ORDER
GO

CREATE DATABASE CUSTOMER_ORDER

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
	'Jacobs, Nancy', 'somewhere.com', '817', 'Fort Worth', 'TX', '76110');
INSERT INTO CUSTOMER VALUES(
	'Jacobs, Chantel', 'somewhere.com', '817', 'Fort Worth', 'TX', '76112');
INSERT INTO CUSTOMER VALUES(
	'Able, Ralph','somewhere.com', '210', 'San Antonio', 'TX', '78214');
INSERT INTO CUSTOMER VALUES(
	'Baker, Susan','elsewhere.com', '210', 'San Antonio', 'TX', '78216');
INSERT INTO CUSTOMER VALUES(
	'Eagleton, Sam', 'elsewhere.com', '210', 'San Antonio', 'TX', '78218');
INSERT INTO CUSTOMER VALUES(
	'Foxtrot, Kathy', 'somewhere.com', '972', 'Dallas', 'TX', '75220');
INSERT INTO CUSTOMER VALUES(
	'George, Sally', 'somewhere.com', '972', 'Dallas', 'TX', '75223');
INSERT INTO CUSTOMER VALUES(
	'Hullett, Shawn', 'elsewhere.com', '972', 'Dallas', 'TX', '75224');
INSERT INTO CUSTOMER VALUES(
	'Pearson, Bobbi', 'elsewhere.com', '512', 'Austin', 'TX', '78710');
INSERT INTO CUSTOMER VALUES(
	'Ranger, Terry', 'somewhere.com', '512', 'Austin', 'TX', '78712');
INSERT INTO CUSTOMER VALUES(
	'Tyler, Jenny', 'somewhere.com', '972', 'Dallas', 'TX', '75225');
INSERT INTO CUSTOMER VALUES(
	'Wayne, Joan', 'elsewhere.com', '817', 'Fort Worth', 'TX', '76115');
		
	
INSERT INTO [ORDER] VALUES(
		'VK001', 'DVD Video', 'Kitchen Remodeling Basics', 4);
INSERT INTO [ORDER] VALUES(
		'VK002', 'DVD Video', 'Advanced Kitchen Remodeling', 5);
INSERT INTO [ORDER] VALUES(
		'VK003', 'DVD Video', 'Kitchen Remodeling Dallas Style',2);
INSERT INTO [ORDER] VALUES(
		'VK004', 'DVD Video', 'Heather Sweeny Seminar Live in Dallas on 25-OCT-07',2 );
INSERT INTO [ORDER] VALUES(
		'VB001', 'Video Companion', 'Kitchen Remodeling Basics Video Companion', 8);
INSERT INTO [ORDER] VALUES(
		'VB002', 'Video Companion', 'Advanced Kitchen Remodeling Video Companion',2);
INSERT INTO [ORDER] VALUES(
		'VB003', 'Video Companion', 'Kitchen Remodeling Dallas Style Video Companion',10);
INSERT INTO [ORDER] VALUES(
		'BK001', 'Book', 'Kitchen Remodeling Basics For Everyone', 12);
INSERT INTO [ORDER] VALUES(
		'BK002', 'Book', 'Advanced Kitchen Remodeling For Everyone', 1);
INSERT INTO [ORDER] VALUES(
		'BK003', 'Book', 'How to Program in C#',null);
INSERT INTO [ORDER] VALUES(
		'BK004', 'Book', 'Datebase Design and Implementation',null);

SELECT COUNT(*) [ORDERS] FROM [ORDER];
SELECT COUNT(*) CUSTOMERS FROM CUSTOMER;
SELECT  * FROM CUSTOMER;
SELECT  * FROM [ORDER];

-- Get all customers who have orders. A valid CustomerID is present in Order table.
-- Orders can only exist for valid CustomerIDs. 
-- It does not matter which table is listed first.
SELECT O.OrderNum, O.ProductName, O.CustomerID, CustomerName 
FROM [ORDER] O, CUSTOMER C
WHERE O.CustomerID = C.CustomerID

SELECT O.OrderNum, O.CustomerID, O.ProductName, C.CustomerID, C.CustomerName 
FROM CUSTOMER C, [ORDER] O
--WHERE C.CustomerID = O.CustomerID
----------------------------------------------------------------------------

-- DISPLAY All Customers who have an order using a join statement
SELECT O.OrderNum, O.ProductName, O.ProductType, O.CustomerID, C.CustomerName
FROM CUSTOMER AS C JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

-- JOIN AND INNER JOIN
SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C INNER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

-- LEFT JOIN AND LEFT OUTER JOIN
SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C LEFT JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C LEFT OUTER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

--FULL AND FULL OUTER JOIN
SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C FULL JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C FULL OUTER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

--------------------------------------------------------------------------------
-- RIGHT AND RIGHT OUTER JOIN 
SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C RIGHT JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C RIGHT OUTER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID


SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C RIGHT OUTER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C, [ORDER] AS O 
-- WHERE C.CustomerID = O.CustomerID;

-- CROSS JOIN
SELECT O.OrderNum, O.ProductNumber, O.CustomerID AS [O-CustID], 
C.CustomerID AS [C-CustID], C.CustomerName, C.City, C.State, C.ZIP
FROM CUSTOMER AS C CROSS JOIN [ORDER] AS O

SELECT * FROM [ORDER];
GO
--FULL JOIN ------------------------------------------------------------
-- DISPLAY All Customers who have an order AND who do NOT have an Order
-- Also display all Orders that have a Customer and who do NOT have a Customer
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C FULL JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C FULL OUTER JOIN [ORDER] AS O ON C.CustomerID = O.CustomerID

-- CROSS JOIN
SELECT  C.CustomerID, O.CustomerID, C.CustomerName,  O.OrderNum, O.ProductName, O.ProductType
FROM CUSTOMER AS C CROSS JOIN [ORDER] AS O

