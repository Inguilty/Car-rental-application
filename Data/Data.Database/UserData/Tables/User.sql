CREATE TABLE [UserData].[User] (
    [Id]            INT                IDENTITY (1, 1) NOT NULL,
    [FirstName]         VARCHAR (45)       NOT NULL,
    [LastName]          VARCHAR (45)       NOT NULL,
    [Region]            VARCHAR (45)       NOT NULL,
    [Country]           VARCHAR (45)       NOT NULL,
    [Email]             VARCHAR (45)       NOT NULL,
    [EmailConfirmed]    BIT                NOT NULL,
    [UserName]          VARCHAR (45)       NOT NULL,
    [TwoFactorEnabled]  BIT                NOT NULL,
    [LockoutEndDateUtc] DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]    BIT                DEFAULT ((0)) NOT NULL,
    [AccessFailedCount] INT                NULL,
    [PasswordHash] NVARCHAR(256) NOT NULL, 
    [SecurityStamp] NVARCHAR(256) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



