CREATE TABLE [dbo].[users] (
    [Id]          INT         NOT NULL,
    [name]        NCHAR (20)  NOT NULL,
    [lastName]    NCHAR (20)  NOT NULL,
    [permission]  NCHAR (10)  NOT NULL,
    [phoneNumber] INT         NULL,
    [Email]       NCHAR (30)  NULL,
    [address]     NCHAR (30)  NULL,
    [birthDate]   DATETIME    NULL,
    [grade]       NCHAR (1)   NULL,
    [classNumber] INT         NULL,
    [hobies]      NCHAR (255) NULL,
    [free Text]   NCHAR (255) NULL,
    [picture]     IMAGE       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

