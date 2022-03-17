USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBAccount6]    Script Date: 17/03/2022 06:13:09 ******/
DROP TABLE [dbo].[OBReadDataConsentResponse1]
GO

/****** Object:  Table [dbo].[OBAccount6]    Script Date: 17/03/2022 06:13:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBReadDataConsentResponse1](
	[ConsentId] [nvarchar](50) NOT NULL,
	[CreationDateTime] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StatusUpdateDateTime] [nvarchar](50) NULL,
	[Permissions] [nvarchar](max) NULL,
	[ExpirationDateTime] [nvarchar](50) NULL,
	[TransactionFromDateTime] [nvarchar](50) NULL,
	[TransactionToDateTime] [nvarchar](50) NULL
)




