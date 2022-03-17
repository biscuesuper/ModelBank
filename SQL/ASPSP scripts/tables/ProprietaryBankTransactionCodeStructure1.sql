USE [ASPSP]
GO

/****** Object:  Table [dbo].[ProprietaryBankTransactionCodeStructure1]    Script Date: 15/03/2022 01:17:41 ******/
DROP TABLE [dbo].[ProprietaryBankTransactionCodeStructure1]
GO

/****** Object:  Table [dbo].[ProprietaryBankTransactionCodeStructure1]    Script Date: 15/03/2022 01:17:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProprietaryBankTransactionCodeStructure1](
	[Id] [nvarchar](50) NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[Issuer] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


