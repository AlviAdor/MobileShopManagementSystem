CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Salary] MONEY NOT NULL
)
