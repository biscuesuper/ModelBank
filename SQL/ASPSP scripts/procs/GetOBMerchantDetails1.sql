USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[GetOBMerchantDetails1]    Script Date: 16/03/2022 08:46:48 ******/
DROP PROCEDURE [dbo].[GetOBMerchantDetails1]
GO

/****** Object:  StoredProcedure [dbo].[GetOBMerchantDetails1]    Script Date: 16/03/2022 08:46:48 ******/
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


