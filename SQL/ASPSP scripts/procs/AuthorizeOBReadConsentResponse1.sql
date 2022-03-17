USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[AuthorizeOBReadConsentResponse1]    Script Date: 17/03/2022 06:17:00 ******/
DROP PROCEDURE [dbo].[AuthorizeOBReadConsentResponse1]
GO

/****** Object:  StoredProcedure [dbo].[AuthorizeOBReadConsentResponse1]    Script Date: 17/03/2022 06:17:00 ******/
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
	@StatusUpdateDateTime [nvarchar](50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[OBReadDataConsentResponse1]
	SET [Status] = @Status, [StatusUpdateDateTime] = @StatusUpdateDateTime
	WHERE [ConsentId] = @ConsentId
END
GO


