USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBActiveOrHistoricCurrencyAndAmount]    Script Date: 15/03/2022 01:13:43 ******/
DROP TABLE [dbo].[OBActiveOrHistoricCurrencyAndAmount]
GO

/****** Object:  Table [dbo].[OBActiveOrHistoricCurrencyAndAmount]    Script Date: 15/03/2022 01:13:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBActiveOrHistoricCurrencyAndAmount](
	[Id] [nvarchar](50) NOT NULL,
	[Amount] [nvarchar](50) NOT NULL,
	[Currency] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


