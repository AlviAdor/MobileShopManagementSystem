CREATE TABLE [dbo].[SaleDetails] (
    [SaleDetailID] INT             IDENTITY (100, 1) NOT NULL,
    [SaleID]       INT             NULL,
    [PhoneID]      INT             NULL,
    [Quantity]     INT             NULL,
    [Price]    MONEY NULL,
    PRIMARY KEY CLUSTERED ([SaleDetailID] ASC),
    FOREIGN KEY ([SaleID]) REFERENCES [dbo].[Sales] ([SaleID]),
    FOREIGN KEY ([PhoneID]) REFERENCES [dbo].[Phones] ([PhoneID])
);

