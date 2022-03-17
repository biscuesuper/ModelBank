USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[DeleteOBReadDataConsentResponse1]    Script Date: 17/03/2022 08:44:41 ******/
DROP PROCEDURE [dbo].[DeleteOBReadDataConsentResponse1]
GO

/****** Object:  StoredProcedure [dbo].[DeleteOBReadDataConsentResponse1]    Script Date: 17/03/2022 08:44:41 ******/
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


