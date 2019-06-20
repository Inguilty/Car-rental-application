CREATE TABLE [dbo].[Reservation] (
    [Id]    INT         IDENTITY (1, 1) NOT NULL,
    [Amount]           MONEY       NOT NULL,
    [PickupDate]       DATETIME    NOT NULL,
    [ReturnDate]       DATETIME    NOT NULL,
    [PickupLocationId] INT         NOT NULL,
    [ReturnLocationId] VARCHAR (3) NOT NULL,
    [CustomerId]       INT         NOT NULL,
    [CarId]            INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Car] ([Id]),
    FOREIGN KEY ([CustomerId]) REFERENCES [UserData].[User] ([Id]),
    FOREIGN KEY ([PickupLocationId]) REFERENCES [dbo].[Office] ([Id])
);

