CREATE TABLE [dbo].[Sales] (
    [SaleID]      INT             IDENTITY (1, 1) NOT NULL,
    [CustomerID]  INT             NULL,
    [SaleDate]    DATETIME        NULL,
    [TotalAmount] MONEY NULL,
    PRIMARY KEY CLUSTERED ([SaleID] ASC),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID])
);

