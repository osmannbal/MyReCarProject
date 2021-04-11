CREATE TABLE [dbo].[CreditCards] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]     INT            NOT NULL,
    [CardNumber]     NVARCHAR (250) NOT NULL,
    [CardHolderName] NVARCHAR (250) NOT NULL,
    [CVV]            INT            NOT NULL,
    [MonthOfExp]     INT            NOT NULL,
    [YearOfExp]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CreditCards_ToTable] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

