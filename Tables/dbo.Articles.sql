CREATE TABLE [dbo].[Articles] (
    [ArticleId]   INT           NOT NULL,
    [ArticleName] NVARCHAR (50) NOT NULL,
    [Price]       DECIMAL (18)  NOT NULL,
    [InStock]     BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ArticleId] ASC)
);

