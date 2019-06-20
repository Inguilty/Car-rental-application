CREATE TABLE [UserData].[UserRole] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([RoleId]) REFERENCES [UserData].[Role] ([Id]),
    FOREIGN KEY ([UserId]) REFERENCES [UserData].[User] ([Id])
);

