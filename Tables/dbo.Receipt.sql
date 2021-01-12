CREATE TABLE [dbo].[Receipt] (
    [ReceiptId]  INT          NOT NULL,
    [Time]       TIME (7)     NOT NULL,
    [TotalPrice] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([ReceiptId] ASC)
);

