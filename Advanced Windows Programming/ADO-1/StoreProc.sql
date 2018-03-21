/****** Script for SelectTopNRows command from SSMS  ******/
use CUSTOMER_ORDER;
go
SELECT CustomerID, CompanyName FROM CUSTOMERS

use CUSTOMER_ORDER;
go
Delete CUSTOMERS;
go

-- drop procedure spExecSEL;
-- go

CREATE PROCEDURE spExecSEL
AS
BEGIN
	EXECUTE sp_executesql N'USE CUSTOMER_ORDER;'
	SELECT * FROM CUSTOMERS
END
GO

exec spExecSEL
GO