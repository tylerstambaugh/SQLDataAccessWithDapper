CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	BirthDate DATE NULL,
    FirstName VARCHAR(14) NOT NULL,
    LastName VARCHAR(16) NOT NULL,
    Gender VARCHAR(2) NOT NULL,    
    HireDate DATE NULL
)
