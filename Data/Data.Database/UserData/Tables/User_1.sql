CREATE TABLE [UserData].[User] (
    [UserId]         INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]      VARCHAR (45) NOT NULL,
    [LastName]       VARCHAR (45) NOT NULL,
    [Mobile]         VARCHAR (45) NOT NULL,
    [Region]         VARCHAR (45) NOT NULL,
    [Country]        VARCHAR (45) NOT NULL,
    [Email]          VARCHAR (45) NOT NULL,
    [EmailConfirmed] BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

