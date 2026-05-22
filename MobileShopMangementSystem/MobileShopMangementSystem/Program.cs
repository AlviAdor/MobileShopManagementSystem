using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MobileShopMangementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string masterConnStr = "Data Source=192.168.0.48,1433;Initial Catalog=master;User ID=sa;Password=YourStrongPassword123;TrustServerCertificate=True;";
            string mobileShopConnStr = "Data Source=192.168.0.48,1433;Initial Catalog=MobileShop;User ID=sa;Password=YourStrongPassword123;TrustServerCertificate=True;";

            string createDbQuery = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'MobileShop') CREATE DATABASE MobileShop;";

            try
            {
                using (SqlConnection conn = new SqlConnection(masterConnStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(createDbQuery, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating database: " + ex.Message);
                return;
            }

            string createTables = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Phones')
BEGIN
    CREATE TABLE Phones (
        PhoneID INT PRIMARY KEY IDENTITY(1,1),
        Brand NVARCHAR(100),
        Model NVARCHAR(100),
        Price DECIMAL(10,2),
        Description NVARCHAR(MAX)
    );
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
BEGIN
    CREATE TABLE Customers (
        CustomerID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(100),
        Phone NVARCHAR(20),
        Address NVARCHAR(255)
    );
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Sales')
BEGIN
    CREATE TABLE Sales (
        SaleID INT PRIMARY KEY IDENTITY(1,1),
        CustomerID INT,
        SaleDate DATETIME,
        TotalAmount DECIMAL(10,2),
        FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
    );
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SaleDetails')
BEGIN
    CREATE TABLE SaleDetails (
        SaleDetailID INT PRIMARY KEY IDENTITY(1,1),
        SaleID INT,
        PhoneID INT,
        Quantity INT,
        UnitPrice DECIMAL(10,2),
        FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
        FOREIGN KEY (PhoneID) REFERENCES Phones(PhoneID)
    );
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Stock')
BEGIN
    CREATE TABLE Stock (
        PhoneID INT PRIMARY KEY,
        QuantityAvailable INT,
        FOREIGN KEY (PhoneID) REFERENCES Phones(PhoneID)
    );
END
";

            try
            {
                using (SqlConnection conn = new SqlConnection(mobileShopConnStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(createTables, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating tables: " + ex.Message);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
