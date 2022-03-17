USE [ASPSP]
GO

ALTER TABLE [dbo].[OBCurrencyExchange5] DROP CONSTRAINT [FK__OBCurrenc__Instr__540C7B00]
GO

/****** Object:  Table [dbo].[OBCurrencyExchange5]    Script Date: 15/03/2022 01:15:54 ******/
DROP TABLE [dbo].[OBCurrencyExchange5]
GO

/****** Object:  Table [dbo].[OBCurrencyExchange5]    Script Date: 15/03/2022 01:15:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBCurrencyExchange5](
	[Id] [nvarchar](50) NOT NULL,
	[ContractIdentification] [nvarchar](50) NULL,
	[ExchangeRate] [nvarchar](50) NOT NULL,
	[QuotationDate] [nvarchar](50) NULL,
	[SourceCurrency] [nvarchar](50) NOT NULL,
	[TargetCurrency] [nvarchar](50) NULL,
	[UnitCurrency] [nvarchar](50) NULL,
	[InstructedAmountId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBCurrencyExchange5]  WITH CHECK ADD FOREIGN KEY([InstructedAmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO


