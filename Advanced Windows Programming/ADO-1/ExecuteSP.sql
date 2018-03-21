USE [CUSTOMER_ORDER]
GO

DECLARE @RC int
DECLARE @CustomerID int
DECLARE @CustomerName char(75)
DECLARE @PhoneAreaCode char(6)

 SET @CustomerName = 'Yusuf, Mohammad';
 SET @PhoneAreaCode = '603';
 SET @CustomerID = 1;

EXECUTE @RC = [dbo].[usUpdateCustomer] 
   @CustomerID
  ,@CustomerName
  ,@PhoneAreaCode
GO

select * from CUSTOMER;
