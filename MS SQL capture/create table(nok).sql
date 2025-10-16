
JANGAN MENGUBAH TYPE DATA SEPERTI DATE TIME KE STRING





USE [TestStandDB]
GO

/****** Object:  Table [dbo].[Test_Station_1]    Script Date: 10/11/2025 5:18:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_Station_1](
	[UUT_SerialNumber] [nvarchar](1000) NOT NULL,
	[Station] [nvarchar](20) NULL,
	[Operator_Name] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[Execution_Date] [nvarchar](20) NULL,
	[Execution_Time] [nvarchar](20) NULL,
	[Shipment_Date] [nvarchar](20) NULL,
	[Shipment_Time] [nvarchar](20) NULL
) 
GO

