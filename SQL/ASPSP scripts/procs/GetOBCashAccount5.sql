USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[GetOBCashAccount5]    Script Date: 16/03/2022 09:14:45 ******/
DROP PROCEDURE [dbo].[GetOBCashAccount5]
GO

/****** Object:  StoredProcedure [dbo].[GetOBCashAccount5]    Script Date: 16/03/2022 09:14:45 ******/
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


