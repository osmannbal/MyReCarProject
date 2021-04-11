CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NULL,
    [UserId]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

