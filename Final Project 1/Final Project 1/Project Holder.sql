﻿CREATE TABLE [dbo].[ProjectHolder]
(
	[Id] INT IDENTITY NOT NULL,
	[Name]	NVARCHAR	(100)	NOT NULL,
	[ProjectDescription]	NVARCHAR	(150)	NOT NULL,
	[Screenshot]	NVARCHAR	(100)	NOT NULL,
	[LinkToRepository] NVARCHAR	(150)	NOT NULL,
	[LanguagesUsed]	NVARCHAR (150)	NOT NULL,
	PRIMARY KEY CLUSTERED ([Id]ASC)
)
