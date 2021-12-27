-- Users
INSERT INTO [ASPSP].[dbo].[User] ([Id], [Name])
VALUES(1, 'Anne')

INSERT INTO [ASPSP].[dbo].[User] ([Id], [Name])
VALUES(2, 'Bob')

-- Anne's current account
INSERT INTO [ASPSP].[dbo].[Account] ([Id], [UserId], [Balance]) 
VALUES(1, 1, 0)

-- Anne's savings account
INSERT INTO [ASPSP].[dbo].[Account] ([Id], [UserId], [Balance])
VALUES(2, 1, 300)

-- Bob's current account
INSERT INTO [ASPSP].[dbo].[Account] ([Id], [UserId], [Balance])
VALUES(3, 2, 0)

-- Transactions
DECLARE @now DATETIME = GETDATE();

-- Ac -> Bc = 10
INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(1, 1, -10, @now)

INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(2, 3, 10, @now)

-- Ac -> As = 20
INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(3, 1, -20, @now)

INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(4, 2, 20, @now)

-- As -> Ac = 30
INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(5, 2, -30, @now)

INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(6, 1, 30, @now)

-- Bc -> Ac = 40
INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(7, 3, -40, @now)

INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(8, 1, 40, @now)

-- Ac -> Bc = 50
INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(9, 1, -50, @now)

INSERT INTO [ASPSP].[dbo].[Txn] ([Id], [AccountId], [Amount], [Date])
VALUES(10, 3, 50, @now)


select * from dbo.[User]
select * from dbo.Account
select * from dbo.Txn