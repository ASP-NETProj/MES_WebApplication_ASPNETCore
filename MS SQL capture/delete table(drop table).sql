USE [TestStandDB]
GO

/****** Object:  Table [dbo].[Test_Station_1]    Script Date: 10/12/2025 4:57:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Test_Station_2]') AND type in (N'U'))
DROP TABLE [dbo].[Test_Station_2]
GO


