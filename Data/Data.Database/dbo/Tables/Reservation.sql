CREATE TABLE [dbo].[Reservation] (
    [ReservationId]    INT         IDENTITY (1, 1) NOT NULL,
    [Amount]           MONEY       NOT NULL,
    [PickupDate]       DATETIME    NOT NULL,
    [ReturnDate]       DATETIME    NOT NULL,
    [PickupLocationId] INT         NOT NULL,
    [ReturnLocationId] VARCHAR (3) NOT NULL,
    [CustomerId]       INT         NOT NULL,
    [CarId]            INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([ReservationId] ASC),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Car] ([CarId]),
    FOREIGN KEY ([CustomerId]) REFERENCES [UserData].[User] ([UserId]),
    FOREIGN KEY ([PickupLocationId]) REFERENCES [dbo].[Office] ([LocationId])
);

