CREATE TABLE [dbo].[LaunchSite] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Pad]      NVARCHAR (50) NULL,
    [Location] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

