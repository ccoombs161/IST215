USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'IT215_Teachers')
     DROP DATABASE IT215_Teachers
GO

CREATE DATABASE IT215_Teachers

GO

USE IT215_Teachers;
GO

CREATE TABLE Teachers (
		TeacherName		CHAR(30)			NOT NULL,
		Classroom		Char(10)			NOT NULL,
		[Subject]		Char(20)			NULL,
		CONSTRAINT 		CUSTOMER_PK 		PRIMARY KEY(TeacherName)
);