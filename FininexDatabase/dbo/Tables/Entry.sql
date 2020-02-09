CREATE TABLE [dbo].[Entry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Amount] FLOAT NOT NULL, 
    [Currency] NCHAR(10) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL,

)
