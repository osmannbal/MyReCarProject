CREATE TABLE [dbo].[Payments] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [CardNumber]     NVARCHAR (250) NOT NULL,
    [CardHolderName] NVARCHAR (250) NOT NULL,
    [CVV]            INT            NOT NULL,
    [MonthOfExp]     INT            NOT NULL,
    [YearOfExp]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

