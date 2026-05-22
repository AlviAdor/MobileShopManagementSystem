USE MobileShop;
GO
-- Phone Table
CREATE TABLE Phones (
   PhoneID INT PRIMARY KEY IDENTITY(1,1),
   Brand NVARCHAR(100),
   Model NVARCHAR(100),
   Price DECIMAL(10,2),
   Description NVARCHAR(MAX)
);
-- Customer Table
CREATE TABLE Customers (
   CustomerID INT PRIMARY KEY IDENTITY(1,1),
   Name NVARCHAR(100),
   Phone NVARCHAR(20),
   Address NVARCHAR(255)
);
-- Sales Table
CREATE TABLE Sales (
   SaleID INT PRIMARY KEY IDENTITY(1,1),
   CustomerID INT,
   SaleDate DATETIME,
   TotalAmount DECIMAL(10,2),
   FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
-- SaleDetails Table
CREATE TABLE SaleDetails (
   SaleDetailID INT PRIMARY KEY IDENTITY(1,1),
   SaleID INT,
   PhoneID INT,
   Quantity INT,
   UnitPrice DECIMAL(10,2),
   FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
   FOREIGN KEY (PhoneID) REFERENCES Phones(PhoneID)
);
-- Stock Table
CREATE TABLE Stock (
   PhoneID INT PRIMARY KEY,
   QuantityAvailable INT,
   FOREIGN KEY (PhoneID) REFERENCES Phones(PhoneID)
);