﻿CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[IdentityId] [nvarchar](max) NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[ProfilePictureUrl] [nvarchar](max) NULL,
	[LastLogin] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
	[Bio] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[CurrentApp] [nvarchar](max) NOT NULL,
	[OverallRating] [float] NOT NULL DEFAULT 0,
	[OverallReportCount] [float] NOT NULL DEFAULT 0,
	[OverallRatingCount] [float] NOT NULL DEFAULT 0,
	[OverallCommentCount] [float] NOT NULL DEFAULT 0,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [LastActiveAt] DATETIME NOT NULL, 
)