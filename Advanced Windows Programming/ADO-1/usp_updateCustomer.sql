use CUSTOMER_ORDER;
go 

CREATE PROCEDURE dbo.[usUpdateCustomer]
    @CustomerID [int], 
    @CustomerName [char](75), 
    @PhoneAreaCode [char](6)
WITH EXECUTE AS CALLER
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE [CUSTOMER] 
        SET CustomerName = @CustomerName, 
            [PhoneAreaCode] = @PhoneAreaCode 
        WHERE [CustomerID] = @CustomerID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback any active or uncommittable transactions before
        -- inserting information in the ErrorLog
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END

    END CATCH;
END;
