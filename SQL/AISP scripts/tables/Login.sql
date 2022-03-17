USE [AISP]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 17/03/2022 02:27:44 ******/
DROP TABLE [dbo].[Login]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 17/03/2022 02:27:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[Id] [nvarchar] (100) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO

