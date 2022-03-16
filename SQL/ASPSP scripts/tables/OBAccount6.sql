USE [ASPSP]
GO

ALTER TABLE [dbo].[OBAccount6] DROP CONSTRAINT [FK__OBAccount__Servi__2DE6D218]
GO

/****** Object:  Table [dbo].[OBAccount6]    Script Date: 15/03/2022 01:12:35 ******/
DROP TABLE [dbo].[OBAccount6]
GO

/****** Object:  Table [dbo].[OBAccount6]    Script Date: 15/03/2022 01:12:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBAccount6](
	[AccountId] [nvarchar](50) NOT NULL,
	[AccountSubType] [nvarchar](50) NULL,
	[AccountType] [nvarchar](50) NULL,
	[Currency] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[MaturityDate] [nvarchar](50) NULL,
	[Nickname] [nvarchar](50) NULL,
	[OpeningDate] [nvarchar](50) NULL,
	[ServicerId] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StatusUpdateDateTime] [nvarchar](50) NULL,
	[SwitchStatus] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBAccount6]  WITH CHECK ADD FOREIGN KEY([ServicerId])
REFERENCES [dbo].[OBBranchAndFinancialInstitutionIdentification5] ([Identification])
GO


