USE [TestStandDB]
GO


SELECT Shipment_Time, 
       CASE WHEN Shipment_Time IS NULL THEN 'IS NULL' ELSE 'NOT NULL' END AS CheckNull
FROM Test_Station_2;
