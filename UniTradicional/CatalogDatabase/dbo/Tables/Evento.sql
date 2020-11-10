CREATE TABLE [dbo].[Evento] (
    [EventId]     INT           IDENTITY (1, 1) NOT NULL,
    [NameEvento]  VARCHAR (MAX) NULL,
    [DateEvento]  DATE          NULL,
    [Descripcion] VARCHAR (MAX) NULL,
    [Pais]        VARCHAR (MAX) NULL,
    PRIMARY KEY NONCLUSTERED ([EventId] ASC)
);

