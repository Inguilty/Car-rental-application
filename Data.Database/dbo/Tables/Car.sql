﻿CREATE TABLE [dbo].[Car] (
    [CarId]             INT          IDENTITY (1, 1) NOT NULL,
    [CurrentLocationId] INT          NOT NULL,
    [TypeId]            INT          NOT NULL,
    [Color]             VARCHAR (45) NOT NULL,
    [Brand]             VARCHAR (45) NOT NULL,
    [Model]             VARCHAR (45) NOT NULL,
    [Description]       VARCHAR (45) DEFAULT (NULL) NULL,
    [PurchaseDate]      DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    FOREIGN KEY ([CurrentLocationId]) REFERENCES [dbo].[Office] ([LocationId]),
    FOREIGN KEY ([TypeId]) REFERENCES [dbo].[CarType] ([TypeId]),
    UNIQUE NONCLUSTERED ([CurrentLocationId] ASC),
    UNIQUE NONCLUSTERED ([TypeId] ASC)
);

