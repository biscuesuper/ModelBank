USE [ASPSP]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 08:13:36 ******/
DROP PROCEDURE [dbo].[TryLogin]
GO

/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 17/03/2022 08:13:36 ******/
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


