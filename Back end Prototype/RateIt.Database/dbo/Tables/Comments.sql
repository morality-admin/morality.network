﻿CREATE TABLE [dbo].[Comments](
	[Id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[CreatedAt] [datetime] NOT NULL DEFAULT GETDATE(),
	[ModifiedAt] [datetime] NOT NULL DEFAULT GETDATE(),
	[Content] [nvarchar](2000) NOT NULL,
	[ContentId] [bigint] NOT NULL,
	[Pings] BIGINT NOT NULL DEFAULT 0,
	[Fullname] [nvarchar](100) NOT NULL,
	[ProfilePictureUrl] [nvarchar](max) NOT NULL,
	[CreatedByAdmin] [bit] NOT NULL DEFAULT 0,
	[Upvotes] [int] NOT NULL DEFAULT 0,
	[CreatorId] [bigint] NOT NULL,
	[ParentId] [bigint] NULL,
	[Sitename] [nvarchar](max) NOT NULL,
    [FlagCount] BIGINT NOT NULL DEFAULT 0, 
	[TipAmount] FLOAT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Comments_ToUsers] FOREIGN KEY ([CreatorId]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_Comments_ToComments] FOREIGN KEY ([ParentId]) REFERENCES [Comments]([Id]), 
    CONSTRAINT [FK_Comments_ToContents] FOREIGN KEY ([ContentId]) REFERENCES [Contents]([Id])
)