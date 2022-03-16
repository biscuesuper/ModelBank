USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification5]    Script Date: 15/03/2022 01:14:19 ******/
DROP TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification5]
GO

/****** Object:  Table [dbo].[OBBranchAndFinancialInstitutionIdentification5]    Script Date: 15/03/2022 01:14:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBBranchAndFinancialInstitutionIdentification5](
	[Identification] [nvarchar](50) NOT NULL,
	[SchemeName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Identification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


