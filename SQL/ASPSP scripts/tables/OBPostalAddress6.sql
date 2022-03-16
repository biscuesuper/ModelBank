USE [ASPSP]
GO

/****** Object:  Table [dbo].[OBPostalAddress6]    Script Date: 15/03/2022 01:16:24 ******/
DROP TABLE [dbo].[OBPostalAddress6]
GO

/****** Object:  Table [dbo].[OBPostalAddress6]    Script Date: 15/03/2022 01:16:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBPostalAddress6](
	[Id] [nvarchar](50) NOT NULL,
	[AddressType] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[SubDepartment] [nvarchar](50) NULL,
	[StreetName] [nvarchar](50) NULL,
	[BuildingNumber] [nvarchar](50) NULL,
	[PostCode] [nvarchar](50) NULL,
	[TownName] [nvarchar](50) NULL,
	[CountrySubDivision] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[AddressLine] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


