CREATE TABLE [dbo].[OrderItems] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [OrderId]  UNIQUEIDENTIFIER NOT NULL,
    [ItemId]   UNIQUEIDENTIFIER NOT NULL,
    [Quantity] INT              NOT NULL,
    CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderItems_CustomerOrders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[CustomerOrders] ([Id]),
    CONSTRAINT [FK_OrderItems_Items] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Items] ([Id])
);

