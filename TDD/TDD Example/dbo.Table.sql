CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NCHAR(10) NULL, 
    [date] DATETIME2 NULL, 
    [json] VARCHAR(MAX) NULL, 
    [active] BIT NULL
)
