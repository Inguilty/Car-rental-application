CREATE TABLE [dbo].[Office] (
    [LocationId] INT          IDENTITY (1, 1) NOT NULL,
    [DefaultTel] INT          NOT NULL,
    [Street]     VARCHAR (45) NOT NULL,
    [Number]     VARCHAR (45) NOT NULL,
    [City]       VARCHAR (45) NOT NULL,
    [Region]     VARCHAR (45) NOT NULL,
    [Country]    VARCHAR (45) NOT NULL,
    PRIMARY KEY CLUSTERED ([LocationId] ASC),
    FOREIGN KEY ([DefaultTel]) REFERENCES [dbo].[OfficeTel] ([DefaultTel]) ON DELETE CASCADE ON UPDATE CASCADE,
    UNIQUE NONCLUSTERED ([DefaultTel] ASC)
);

