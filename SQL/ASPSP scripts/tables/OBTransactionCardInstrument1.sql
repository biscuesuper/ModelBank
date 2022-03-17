USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBTransactionCardInstrument1]    Script Date: 15/03/2022 01:17:14 ******/
DROP TABLE [dbo].[OBTransactionCardInstrument1]
GO

/****** Object:  Table [dbo].[OBTransactionCardInstrument1]    Script Date: 15/03/2022 01:17:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBTransactionCardInstrument1](
	[Id] [nvarchar](50) NOT NULL,
	[AuthorisationType] [nvarchar](50) NULL,
	[CardSchemeName] [nvarchar](50) NOT NULL,
	[Identification] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


