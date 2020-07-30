CREATE TABLE [dbo].[CustomerOrders] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [CustomerId] UNIQUEIDENTIFIER NOT NULL,
    [OrderDate]  DATETIME         NOT NULL,
    CONSTRAINT [PK_CustomerOrders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CustomerOrders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);

