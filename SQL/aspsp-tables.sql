USE [ASPSP]
GO
/****** Object:  Table [dbo].[AccountConsentMappings]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountConsentMappings](
	[ConsentId] [nvarchar](100) NOT NULL,
	[AccountId] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[AccountId] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBAccount6]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBAccount6](
	[AccountId] [nvarchar](50) NOT NULL,
	[AccountSubType] [nvarchar](50) NULL,
	[AccountType] [nvarchar](50) NULL,
	[Currency] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[MaturityDate] [nvarchar](50) NULL,
	[Nickname] [nvarchar](50) NULL,
	[OpeningDate] [nvarchar](50) NULL,
	[ServicerId] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StatusUpdateDateTime] [nvarchar](50) NULL,
	[SwitchStatus] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBActiveOrHistoricCurrencyAndAmount]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBActiveOrHistoricCurrencyAndAmount](
	[Id] [nvarchar](50) NOT NULL,
	[Amount] [nvarchar](50) NOT NULL,
	[Currency] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBBankTransactionCodeStructure1]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification5]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification5](
	[Identification] [nvarchar](50) NOT NULL,
	[SchemeName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Identification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification6]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6](
	[Id] [nvarchar](50) NOT NULL,
	[Identification] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[SchemeName] [nvarchar](50) NULL,
	[PostalAddressId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBCashAccount5]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBCashAccount6]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBCashBalance1]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBCreditLine1]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBCreditLine1](
	[AmountId] [nvarchar](50) NULL,
	[Included] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[BalanceId] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBCurrencyExchange5]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBMerchantDetails1]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBMerchantDetails1](
	[Id] [nvarchar](50) NOT NULL,
	[MerchantName] [nvarchar](50) NULL,
	[MerchantCategoryCode] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBPostalAddress6]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBPostalAddress6](
	[Id] [nvarchar](50) NOT NULL,
	[AddressType] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[SubDepartment] [nvarchar](50) NULL,
	[StreetName] [nvarchar](50) NULL,
	[BuildingNumber] [nvarchar](50) NULL,
	[PostCode] [nvarchar](50) NULL,
	[TownName] [nvarchar](50) NULL,
	[CountrySubDivision] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[AddressLine] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBReadDataConsentResponse1]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBReadDataConsentResponse1](
	[ConsentId] [nvarchar](50) NOT NULL,
	[CreationDateTime] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StatusUpdateDateTime] [nvarchar](50) NULL,
	[Permissions] [nvarchar](max) NULL,
	[ExpirationDateTime] [nvarchar](50) NULL,
	[TransactionFromDateTime] [nvarchar](50) NULL,
	[TransactionToDateTime] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBSupplementaryData1]    Script Date: 06/04/2022 20:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBSupplementaryData1](
	[Id] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBTransaction6]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBTransactionCardInstrument1]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[OBTransactionCashBalance]    Script Date: 06/04/2022 20:12:40 ******/
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
/****** Object:  Table [dbo].[ProprietaryBankTransactionCodeStructure1]    Script Date: 06/04/2022 20:12:40 ******/
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
ALTER TABLE [dbo].[OBAccount6]  WITH CHECK ADD FOREIGN KEY([ServicerId])
REFERENCES [dbo].[OBBranchAndFinancialInstitutionIdentification5] ([Identification])
GO
ALTER TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6]  WITH CHECK ADD FOREIGN KEY([PostalAddressId])
REFERENCES [dbo].[OBPostalAddress6] ([Id])
GO
ALTER TABLE [dbo].[OBCashAccount5]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[OBAccount6] ([AccountId])
GO
ALTER TABLE [dbo].[OBCashBalance1]  WITH CHECK ADD FOREIGN KEY([AmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO
ALTER TABLE [dbo].[OBCreditLine1]  WITH CHECK ADD FOREIGN KEY([BalanceId])
REFERENCES [dbo].[OBCashBalance1] ([Id])
GO
ALTER TABLE [dbo].[OBCurrencyExchange5]  WITH CHECK ADD FOREIGN KEY([InstructedAmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
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
ALTER TABLE [dbo].[OBTransactionCashBalance]  WITH CHECK ADD FOREIGN KEY([AmountId])
REFERENCES [dbo].[OBActiveOrHistoricCurrencyAndAmount] ([Id])
GO
