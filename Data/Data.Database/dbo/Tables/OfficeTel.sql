CREATE TABLE [dbo].[OfficeTel] (
    [DefaultTel] INT IDENTITY (1, 1) NOT NULL,
    [Tel1]       INT DEFAULT (NULL) NULL,
    [Tel2]       INT DEFAULT (NULL) NULL,
    [Tel3]       INT DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([DefaultTel] ASC)
);

