USE [ASPSP]
GO

ALTER TABLE [dbo].[OBCashAccount5] DROP CONSTRAINT [FK__OBCashAcc__Accou__30C33EC3]
GO

/****** Object:  Table [dbo].[OBCashAccount5]    Script Date: 15/03/2022 01:14:53 ******/
DROP TABLE [dbo].[OBCashAccount5]
GO

/****** Object:  Table [dbo].[OBCashAccount5]    Script Date: 15/03/2022 01:14:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBCashAccount5](
	[Identification] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SchemeName] [nvarchar](50) NOT NULL,
	[SecondaryIdentification] [nvarchar](50) NULL,
	[AccountId] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Identification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBCashAccount5]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[OBAccount6] ([AccountId])
GO


