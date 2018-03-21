/****** Script for SelectTopNRows command from SSMS  ******/
use IT215_CUSTOMER;
go
SELECT CustomerID, CompanyName FROM CUSTOMERS

use IT215_CUSTOMER;
go
Delete CUSTOMERS;
go

-- drop procedure spExecSEL;
-- go

CREATE PROCEDURE spExecSEL
AS
BEGIN
	EXECUTE sp_executesql N'USE IT215_CUSTOMER;'
	SELECT * FROM CUSTOMERS
END
GO

exec spExecSEL
GO