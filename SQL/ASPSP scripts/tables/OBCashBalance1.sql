USE [ASPSP]
GO

ALTER TABLE [dbo].[OBCashBalance1] DROP CONSTRAINT [FK__OBCashBal__Amoun__3864608B]
GO

/****** Object:  Table [dbo].[OBCashBalance1]    Script Date: 15/03/2022 01:15:22 ******/
DROP TABLE [dbo].[OBCashBalance1]
GO

/****** Object:  Table [dbo].[OBCashBalance1]    Script Date: 15/03/2022 01:15:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBCashBalance1](
	[Id] [nvarchar](50) NOT NULL,
	[AccountId] [nvarchar](50) NOT NULL,
	[CreditDebitIndicator] [nvarchar](50) NOT NULL,
	[DateTime] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[AmountId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBCashBalance1]  WITH CHECK ADD FOREIGN KEY([AmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO


