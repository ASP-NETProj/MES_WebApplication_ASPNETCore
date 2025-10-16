USE [TestStandDB]
GO

/****** Object:  Table [dbo].[Test_Station_1]    Script Date: 10/11/2025 5:18:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_Station_2](
	[UUT_SerialNumber] [nvarchar](1000) NOT NULL,
	[Station] [nvarchar](20) NULL,
	[Operator_Name] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[Test_Date] [date] NULL,
	[Test_Time] [time](0) NULL,     /*----TAMBAHKAN (0) SPY FORMAT JAM TIDAK MUNCUL 0000000    */
	[Shipment_Date] [date] NULL,
	[Shipment_Time] [time](0) NULL        /*----TAMBAHKAN (0) SPY FORMAT JAM TIDAK MUNCUL 0000000    */
) 
GO

