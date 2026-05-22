CREATE TABLE [dbo].[Phones] (
    [PhoneID]     INT             IDENTITY (1, 1) NOT NULL,
    [Company]     NVARCHAR (100)  NULL,
    [ModelName]   NVARCHAR (100)  NULL,
    [Price]       DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([PhoneID] ASC)
);

