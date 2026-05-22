CREATE TABLE [dbo].[Login]
(
	[UserID] INT, 
    [Username] NVARCHAR(100) NOT NULL UNIQUE, 
    [Password] NVARCHAR(255) NOT NULL, 
    [Role] NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Employee'))
	CONSTRAINT FK_Login_Employee FOREIGN KEY (UserID) REFERENCES Employee(EmployeeId)
	ON DELETE SET NULL
	ON UPDATE CASCADE
);
