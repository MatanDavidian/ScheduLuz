CREATE TABLE [dbo].[connection_details]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [userName] NCHAR(20) NOT NULL, 
    [password] NCHAR(20) NOT NULL, 
    [permission] NCHAR(10) NOT NULL
)
