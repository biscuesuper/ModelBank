USE [AISP]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 06/04/2022 21:15:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
