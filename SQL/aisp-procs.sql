USE [AISP]
GO
/****** Object:  StoredProcedure [dbo].[TryLogin]    Script Date: 06/04/2022 21:09:16 ******/
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
