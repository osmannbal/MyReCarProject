CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           NOT NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
    [CarName] NVARCHAR (50) NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [ModelYear]   INT           NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_ToTable] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [FK_Cars_ToTable_1] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);

