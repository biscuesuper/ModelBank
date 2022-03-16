USE [ASPSP]
GO

ALTER TABLE [dbo].[OBTransactionCashBalance] DROP CONSTRAINT [FK__OBTransac__Amoun__3E1D39E1]
GO

/****** Object:  Table [dbo].[OBTransactionCashBalance]    Script Date: 15/03/2022 01:17:27 ******/
DROP TABLE [dbo].[OBTransactionCashBalance]
GO

/****** Object:  Table [dbo].[OBTransactionCashBalance]    Script Date: 15/03/2022 01:17:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBTransactionCashBalance](
	[Id] [nvarchar](50) NOT NULL,
	[AmountId] [nvarchar](50) NOT NULL,
	[CreditDebitIndicator] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBTransactionCashBalance]  WITH CHECK ADD FOREIGN KEY([AmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO


