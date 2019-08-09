CREATE TABLE [dbo].[LaunchProvider] (
    [Id]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NULL,
    [Country] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

