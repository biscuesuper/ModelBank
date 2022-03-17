USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[GetOBActiveOrHistoricCurrencyAndAmount]    Script Date: 16/03/2022 08:23:47 ******/
DROP PROCEDURE [dbo].[GetOBActiveOrHistoricCurrencyAndAmount]
GO

/****** Object:  StoredProcedure [dbo].[GetOBActiveOrHistoricCurrencyAndAmount]    Script Date: 16/03/2022 08:23:47 ******/
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

   SELECT *
  FROM [dbo].[OBActiveOrHistoricCurrencyAndAmount]
  WHERE [Id] = @Id
END
GO


