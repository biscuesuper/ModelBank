USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBBankTransactionCodeStructure1]    Script Date: 15/03/2022 01:14:01 ******/
DROP TABLE [dbo].[OBBankTransactionCodeStructure1]
GO

/****** Object:  Table [dbo].[OBBankTransactionCodeStructure1]    Script Date: 15/03/2022 01:14:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBBankTransactionCodeStructure1](
	[Id] [nvarchar](50) NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[SubCode] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


