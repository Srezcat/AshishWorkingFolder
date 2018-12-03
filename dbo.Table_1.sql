CREATE TABLE [dbo].[Login]
(
	[Username] VARCHAR(50) NOT NULL PRIMARY KEY IDENTITY, 
    [Password] NCHAR(10) NULL, 
    [Re-type] NCHAR(10) NULL, 
    [Details] NCHAR(10) NULL
)
