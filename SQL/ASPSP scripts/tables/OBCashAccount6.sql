USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBCashAccount6]    Script Date: 15/03/2022 01:15:06 ******/
DROP TABLE [dbo].[OBCashAccount6]
GO

/****** Object:  Table [dbo].[OBCashAccount6]    Script Date: 15/03/2022 01:15:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBCashAccount6](
	[SchemeName] [nvarchar](50) NOT NULL,
	[Identification] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SecondaryIdentification] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Identification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


