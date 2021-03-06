﻿USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'IT215_CUSTOMER')
	 DROP DATABASE IT215_CUSTOMER
GO

CREATE DATABASE IT215_CUSTOMER

GO

USE IT215_CUSTOMER;
GO

CREATE TABLE CUSTOMERS(
		CustomerID		CHAR(5)				NOT NULL,
		CompanyName		VarChar(40)			NOT NULL,
		CONSTRAINT 		CUSTOMER_PK 		PRIMARY KEY(CustomerID)
);