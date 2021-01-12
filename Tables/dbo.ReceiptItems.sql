CREATE TABLE [dbo].[ReceiptItems] (
    [IdArticle] INT NOT NULL,
    [IdReceipt] INT NOT NULL,
    [Quantity]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdArticle] ASC, [IdReceipt] ASC),
    CONSTRAINT [FK_ReceiptItems_Article] FOREIGN KEY ([IdArticle]) REFERENCES [dbo].[Articles] ([ArticleId]),
    CONSTRAINT [FK_ReceiptItems_Receipt] FOREIGN KEY ([IdReceipt]) REFERENCES [dbo].[Receipt] ([ReceiptId])
);

