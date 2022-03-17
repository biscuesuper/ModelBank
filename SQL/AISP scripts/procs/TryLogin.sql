USE [AISP]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 02:31:13 ******/
DROP PROCEDURE [dbo].[TryLogin]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 02:31:13 ******/
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


