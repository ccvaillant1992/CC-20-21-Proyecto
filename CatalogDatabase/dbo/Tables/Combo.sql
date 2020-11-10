CREATE TABLE [dbo].[Combo] (
    [ComboId]   INT            IDENTITY (1, 1) NOT NULL,
    [EventId]   INT            NULL,
    [NameCombo] VARCHAR (MAX)  NULL,
    [Precio]    DECIMAL (5, 2) NULL,
    [Category]  VARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Combo] PRIMARY KEY NONCLUSTERED ([ComboId] ASC),
    CONSTRAINT [FK_Evento_Combo] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Evento] ([EventId]) ON DELETE CASCADE ON UPDATE CASCADE
);

