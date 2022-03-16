USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[GetOBBranchAndFinancialInstitutionIdentification5]    Script Date: 16/03/2022 08:24:31 ******/
DROP PROCEDURE [dbo].[GetOBBranchAndFinancialInstitutionIdentification5]
GO

/****** Object:  StoredProcedure [dbo].[GetOBBranchAndFinancialInstitutionIdentification5]    Script Date: 16/03/2022 08:24:31 ******/
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


