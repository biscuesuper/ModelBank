USE [ASPSP]
GO

ALTER TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6] DROP CONSTRAINT [FK__OBBranchA__Posta__4D5F7D71]
GO

/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification6]    Script Date: 15/03/2022 01:14:34 ******/
DROP TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6]
GO

/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification6]    Script Date: 15/03/2022 01:14:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6](
	[Id] [nvarchar](50) NOT NULL,
	[Identification] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[SchemeName] [nvarchar](50) NULL,
	[PostalAddressId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification6]  WITH CHECK ADD FOREIGN KEY([PostalAddressId])
REFERENCES [dbo].[OBPostalAddress6] ([Id])
GO


