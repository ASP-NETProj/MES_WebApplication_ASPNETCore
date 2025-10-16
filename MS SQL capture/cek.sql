USE [TestStandDB];
GO

SELECT * FROM sys.tables WHERE name LIKE '%Test%';  --Confirm table exists:
EXEC sp_columns Test_Station_1;  --Confirm column names:
