CREATE TABLE [dbo].[CarType] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [TypeLabel]       VARCHAR (45) NOT NULL,
    [TypeDescription] VARCHAR (45) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

