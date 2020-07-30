CREATE TABLE [dbo].[Items] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (50)    NOT NULL,
    [StockCount] INT NOT NULL, 
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC)
);

