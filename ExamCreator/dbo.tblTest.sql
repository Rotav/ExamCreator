CREATE TABLE [dbo].[tblTest] (
    [TestId]      INT  IDENTITY (1, 1) NOT NULL,
    [Privacy]     BIT  NOT NULL,
    [TestTitle]   TEXT NOT NULL,
    [LevelID]       INT  NOT NULL,
    [Description] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([TestId] ASC), 
    CONSTRAINT [FK_LevelOfTest] FOREIGN KEY ([LevelID]) REFERENCES [tblTestLevel]([Id])
);

