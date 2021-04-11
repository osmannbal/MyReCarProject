CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [CarName]     VARCHAR (50)  NOT NULL,
    [DailyPrice]  DECIMAL (18)  NOT NULL,
    [ModelYear]   INT           NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [FindexPoint] INT           NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [Color] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);

