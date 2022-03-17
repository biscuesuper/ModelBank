USE [ASPSP]
GO

ALTER TABLE [dbo].[OBCreditLine1] DROP CONSTRAINT [FK__OBCreditL__Balan__3A4CA8FD]
GO

/****** Object:  Table [dbo].[OBCreditLine1]    Script Date: 15/03/2022 01:15:39 ******/
DROP TABLE [dbo].[OBCreditLine1]
GO

/****** Object:  Table [dbo].[OBCreditLine1]    Script Date: 15/03/2022 01:15:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBCreditLine1](
	[AmountId] [nvarchar](50) NULL,
	[Included] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[BalanceId] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBCreditLine1]  WITH CHECK ADD FOREIGN KEY([BalanceId])
REFERENCES [dbo].[OBCashBalance1] ([Id])
GO


