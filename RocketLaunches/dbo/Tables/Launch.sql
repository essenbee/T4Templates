CREATE TABLE [dbo].[Launch] (
    [Id]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [Mission]        NVARCHAR (50) NULL,
    [LaunchProvider] BIGINT        NOT NULL,
    [Rocket]         BIGINT        NOT NULL,
    [LaunchSite]     BIGINT        NOT NULL,
    [NET]            NVARCHAR (50) NULL,
    [StageRecovery]  BIT           NOT NULL,
    [LaunchdateTime] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Launch_LaunchProvider] FOREIGN KEY ([Id]) REFERENCES [dbo].[LaunchProvider] ([Id]),
    CONSTRAINT [FK_Launch_LaunchSite] FOREIGN KEY ([Id]) REFERENCES [dbo].[LaunchSite] ([Id]),
    CONSTRAINT [FK_Launch_Rocket] FOREIGN KEY ([Id]) REFERENCES [dbo].[Rocket] ([Id])
);

