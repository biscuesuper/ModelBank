USE [ASPSP]
GO
/****** Object:  StoredProcedure [dbo].[AuthorizeOBReadConsentResponse1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AuthorizeOBReadConsentResponse1]
	@ConsentId [nvarchar](50),
	@Status [nvarchar](50),
	@StatusUpdateDateTime [nvarchar](50),
	@AccountId [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[OBReadDataConsentResponse1]
	SET [Status] = @Status, [StatusUpdateDateTime] = @StatusUpdateDateTime
	WHERE [ConsentId] = @ConsentId

	INSERT INTO [dbo].[AccountConsentMappings] ([ConsentId],[AccountId])
	values(@ConsentId, @AccountId)

	select * from [dbo].[OBReadDataConsentResponse1]
	where [ConsentId] = @ConsentId
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteOBReadDataConsentResponse1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteOBReadDataConsentResponse1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


  DELETE FROM [dbo].[OBReadDataConsentResponse1]
  WHERE [ConsentId] = @Id

  DELETE FROM [dbo].[AccountConsentMappings]
  WHERE [ConsentId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBAccount6]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBAccount6]
	@AccountId [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBAccount6]
  WHERE [AccountId] = @AccountId
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBActiveOrHistoricCurrencyAndAmount]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBActiveOrHistoricCurrencyAndAmount]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   SELECT [Id]
      ,[Amount]
      ,[Currency]
  FROM [dbo].[OBActiveOrHistoricCurrencyAndAmount]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBBankTransactionCodeStructure1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBBankTransactionCodeStructure1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBBankTransactionCodeStructure1]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBBranchAndFinancialInstitutionIdentification5]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBBranchAndFinancialInstitutionIdentification5]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBBranchAndFinancialInstitutionIdentification5]
  WHERE [Identification] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBBranchAndFinancialInstitutionIdentification6]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBBranchAndFinancialInstitutionIdentification6]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBBranchAndFinancialInstitutionIdentification6]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBCashAccount5]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBCashAccount5]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBCashAccount5]
  WHERE [AccountId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBCashAccount6]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBCashAccount6]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBOBCashAccount6]
  WHERE [Identification] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBCashBalance1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBCashBalance1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBCashBalance1]
  WHERE [AccountId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBCreditLine1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBCreditLine1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBCreditLine1]
  WHERE [BalanceId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBCurrencyExchange5]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBCurrencyExchange5]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBCurrencyExchange5]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBMerchantDetails1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBMerchantDetails1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBMerchantDetails1]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBPostalAddress6]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBPostalAddress6]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBPostalAddress6]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBReadDataConsentResponse1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBReadDataConsentResponse1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBReadDataConsentResponse1]
  WHERE [ConsentId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBSupplementaryData1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBSupplementaryData1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBSupplementaryData1]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBTransaction6]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBTransaction6]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBTransaction6]
  WHERE [AccountId] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBTransactionCardInstrument1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBTransactionCardInstrument1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBTransactionCardInstrument1]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOBTransactionCashBalance]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetOBTransactionCashBalance]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[OBTransactionCashBalance]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetProprietaryBankTransactionCodeStructure1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProprietaryBankTransactionCodeStructure1]
	@Id [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
  FROM [dbo].[ProprietaryBankTransactionCodeStructure1]
  WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SaveOBReadConsentResponse1]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveOBReadConsentResponse1]
	@CreationDateTime [nvarchar](50),
	@Status [nvarchar](50),
	@StatusUpdateDateTime [nvarchar](50),
	@Permissions [nvarchar](max),
	@ExpirationDateTime [nvarchar](50),
	@TransactionFromDateTime [nvarchar](50),
	@TransactionToDateTime [nvarchar](50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @myid uniqueidentifier  
	SET @myid = NEWID()  

	INSERT INTO  [dbo].[OBReadDataConsentResponse1] (
	[ConsentId],
	[CreationDateTime],
	[Status],
	[StatusUpdateDateTime],
	[Permissions],
	[ExpirationDateTime],
	[TransactionFromDateTime],
	[TransactionToDateTime]
	)
	VALUES(
	@myid,
	@CreationDateTime,
	@Status,
	@StatusUpdateDateTime,
	@Permissions,
	@ExpirationDateTime,
	@TransactionFromDateTime,
	@TransactionToDateTime
	)

	select * from [dbo].[OBReadDataConsentResponse1]
	where [ConsentId] = @myid
END
GO
/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 06/04/2022 20:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[TryLogin]
@Username NVARCHAR(100),
@Password NVARCHAR(100)
AS
BEGIN
SELECT top (1) * FROM dbo.[Login] WHERE [Username] = @Username AND [Password]=@Password
end
GO
