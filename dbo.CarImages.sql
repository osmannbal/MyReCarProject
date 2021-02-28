CREATE TABLE [dbo].[CarImages] (
    [CarImageId] INT           PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [CarId]      INT           NOT NULL,
    [ImagePath]  NVARCHAR (50) NULL,
    [Date]       DATETIME      NULL,
    CONSTRAINT [Car2] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId])
);

