CREATE TABLE [UserData].[User] (
    [UserId]            INT                IDENTITY (1, 1) NOT NULL,
    [FirstName]         VARCHAR (45)       NOT NULL,
    [LastName]          VARCHAR (45)       NOT NULL,
    [Region]            VARCHAR (45)       NOT NULL,
    [Country]           VARCHAR (45)       NOT NULL,
    [Email]             VARCHAR (45)       NOT NULL,
    [EmailConfirmed]    BIT                NOT NULL,
    [UserName]          VARCHAR (45)       NOT NULL,
    [Password]          VARCHAR (45)       NOT NULL,
    [PasswordConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]  BIT                NOT NULL,
    [LockoutEndDateUtc] DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]    BIT                DEFAULT ((0)) NOT NULL,
    [AccessFailedCount] INT                NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);



