﻿CREATE TABLE [dbo].[Currencys]
(
	[Id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL, 
    [Name] NVARCHAR(500) NOT NULL, 
    [Address] NVARCHAR(42) NOT NULL, 
    [Abi] NVARCHAR(MAX) NOT NULL, 
    [IsTest] BIT NOT NULL DEFAULT 0, 
    [Network] NVARCHAR(500) NOT NULL, 
    [AdminAddress] NVARCHAR(100) NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    [Timestamp] DATETIME NOT NULL DEFAULT GETDATE()
)
