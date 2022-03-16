USE [ASPSP]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Suppl__0E391C95]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Propr__0D44F85C]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Merch__0C50D423]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Debto__0B5CAFEA]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Debto__0A688BB1]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Curre__09746778]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Credi__0880433F]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Credi__078C1F06]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Charg__0697FACD]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__CardI__05A3D694]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__BankT__04AFB25B]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Balan__03BB8E22]
GO

ALTER TABLE [dbo].[OBTransaction6] DROP CONSTRAINT [FK__OBTransac__Amoun__02C769E9]
GO

/****** Object:  Table [dbo].[OBTransaction6]    Script Date: 15/03/2022 01:16:51 ******/
DROP TABLE [dbo].[OBTransaction6]
GO

/****** Object:  Table [dbo].[OBTransaction6]    Script Date: 15/03/2022 01:16:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBTransaction6](
	[AccountId] [nvarchar](50) NOT NULL,
	[AddressLine] [nvarchar](50) NULL,
	[BookingDateTime] [nvarchar](50) NOT NULL,
	[CreditDebitIndicator] [nvarchar](50) NOT NULL,
	[StatementReference] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[TransactionId] [nvarchar](50) NULL,
	[TransactionInformation] [nvarchar](50) NULL,
	[TransactionMutability] [nvarchar](50) NULL,
	[TransactionReference] [nvarchar](50) NULL,
	[ValueDateTime] [nvarchar](50) NULL,
	[AmountId] [nvarchar](50) NOT NULL,
	[BalanceId] [nvarchar](50) NULL,
	[BankTransactionCodeId] [nvarchar](50) NULL,
	[CardInstrumentId] [nvarchar](50) NULL,
	[ChargeAmountId] [nvarchar](50) NULL,
	[CreditorAccountId] [nvarchar](50) NULL,
	[CreditorAgentId] [nvarchar](50) NULL,
	[CurrencyExchangeId] [nvarchar](50) NULL,
	[DebtorAccountId] [nvarchar](50) NULL,
	[DebtorAgentId] [nvarchar](50) NULL,
	[MerchantDetailsId] [nvarchar](50) NULL,
	[ProprietaryBankTransactionCodeId] [nvarchar](50) NULL,
	[SupplementaryDataId] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([AmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([BalanceId])
REFERENCES [dbo].[OBTransactionCashBalance] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([BankTransactionCodeId])
REFERENCES [dbo].[OBBankTransactionCodeStructure1] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([CardInstrumentId])
REFERENCES [dbo].[OBTransactionCardInstrument1] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([ChargeAmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([CreditorAccountId])
REFERENCES [dbo].[OBCashAccount6] ([Identification])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([CreditorAgentId])
REFERENCES [dbo].[OBBranchAndFinancialInstitutionIdentification6] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([CurrencyExchangeId])
REFERENCES [dbo].[OBCurrencyExchange5] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([DebtorAccountId])
REFERENCES [dbo].[OBCashAccount6] ([Identification])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([DebtorAgentId])
REFERENCES [dbo].[OBBranchAndFinancialInstitutionIdentification6] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([MerchantDetailsId])
REFERENCES [dbo].[OBMerchantDetails1] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([ProprietaryBankTransactionCodeId])
REFERENCES [dbo].[ProprietaryBankTransactionCodeStructure1] ([Id])
GO

ALTER TABLE [dbo].[OBTransaction6]  WITH CHECK ADD FOREIGN KEY([SupplementaryDataId])
REFERENCES [dbo].[OBSupplementaryData1] ([Id])
GO


