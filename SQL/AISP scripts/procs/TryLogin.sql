USE [AISP]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 01:56:45 ******/
DROP PROCEDURE [dbo].[TryLogin]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 01:56:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TryLogin]
@Username NVARCHAR(100),
@Password NVARCHAR(100),
@Isvalid BIT OUT
AS
BEGIN
SET @Isvalid = (SELECT COUNT(1) FROM dbo.[Login] WHERE [Username] = @Username AND [Password]=@Password)
end
GO


