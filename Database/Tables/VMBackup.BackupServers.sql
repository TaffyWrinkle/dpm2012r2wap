﻿CREATE TABLE [VMBackup].[BackupServers]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [ServerId] UNIQUEIDENTIFIER NOT NULL, 
    [ServerName] NVARCHAR(128) NOT NULL, 
    [UserName] NVARCHAR(128) NOT NULL, 
    [Password] VARBINARY(2048) NOT NULL, 
    [State] INT NOT NULL,
	[ServerGroupId] INT NOT NULL,

 CONSTRAINT [PK_BackupServers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],

 CONSTRAINT [UX_BackupServerId] UNIQUE NONCLUSTERED 
(
	[ServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],

 CONSTRAINT [UX_BackupServerName] UNIQUE NONCLUSTERED 
(
	[ServerName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 

 CONSTRAINT [FK_BackupServers_has_BackupServerState] FOREIGN KEY ([State]) REFERENCES [VMBackup].[BackupServerState]([Id]),

  CONSTRAINT [FK_BackupServers_has_ServerGroup] FOREIGN KEY ([ServerGroupId]) REFERENCES [VMBackup].[ServerGroups]([Id])
) ON [PRIMARY]
