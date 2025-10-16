USE [TestStandDB]
GO

/****** Object:  Table [dbo].[Test_Station_1]    Script Date: 10/11/2025 5:18:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_Station_1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUT_SerialNumber] [nvarchar](100) NULL,
	[Station] [int] NULL,
	[Operator_Name] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[Execution_Date] [date] NULL,
	[Execution_Time] [time](0) NULL,
	[Shipment_Date] [date] NULL,
	[Shipment_Time] [time](0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

