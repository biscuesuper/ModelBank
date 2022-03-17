USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[SaveOBReadConsentResponse1]    Script Date: 17/03/2022 06:17:00 ******/
DROP PROCEDURE [dbo].[SaveOBReadConsentResponse1]
GO

/****** Object:  StoredProcedure [dbo].[SaveOBReadConsentResponse1]    Script Date: 17/03/2022 06:17:00 ******/
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
END
GO


