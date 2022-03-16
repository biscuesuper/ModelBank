USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[GetOBAccount6]    Script Date: 15/03/2022 01:20:10 ******/
DROP PROCEDURE [dbo].[GetOBAccount6]
GO

/****** Object:  StoredProcedure [dbo].[GetOBAccount6]    Script Date: 15/03/2022 01:20:10 ******/
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


