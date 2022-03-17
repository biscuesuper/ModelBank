USE [ASPSP]
GO

/****** Object:  Table [dbo].[AccountConsentMappings]    Script Date: 17/03/2022 08:40:35 ******/
DROP TABLE [dbo].[AccountConsentMappings]
GO

/****** Object:  Table [dbo].[AccountConsentMappings]    Script Date: 17/03/2022 08:40:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AccountConsentMappings](
	[ConsentId] [nvarchar](100) NOT NULL,
	[AccountId] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO


