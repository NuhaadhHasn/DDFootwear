-- DDFootwear demo database (SQL Server)
-- Creates the DDFootwear database with the same tables the EF Core migrations create,
-- plus made-up demo data (customers, products, sales) so the apps have something to show.
--
-- Run it with sqlcmd and tell it where the API's product images live, because the
-- Products and Sales tables store full image paths:
--
--   sqlcmd -S "(localdb)\MSSQLLocalDB" -E ^
--          -v ImageDir="C:\path\to\DDFootwear.API\DDFootwear.API\Resources\images" ^
--          -i DDFootwear-demo.sql
--
-- Use -S localhost instead of (localdb)\MSSQLLocalDB for a full SQL Server install.
-- Run it on a fresh server: it fails if the DDFootwear tables already exist.
-- All people, emails and phone numbers below are fictional.

IF DB_ID('DDFootwear') IS NULL CREATE DATABASE DDFootwear;
GO
USE DDFootwear;
GO

CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId]    nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
);

CREATE TABLE [Customers] (
    [CustomerId]   int IDENTITY(1,1) NOT NULL,
    [CustomerName] nvarchar(max) NOT NULL,
    [Email]        nvarchar(max) NOT NULL,
    [Password]     nvarchar(max) NOT NULL,
    [Phone]        nvarchar(max) NOT NULL,
    [Address]      nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
);

CREATE TABLE [Products] (
    [ProductId]          int IDENTITY(1,1) NOT NULL,
    [ProductName]        nvarchar(max) NOT NULL,
    [ProductDescription] nvarchar(max) NOT NULL,
    [WholeSalePrice]     decimal(18,2) NOT NULL,
    [RetailPrice]        decimal(18,2) NOT NULL,
    [CostPrice]          decimal(18,2) NOT NULL,
    [Stock]              int NOT NULL,
    [ProductImg]         nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId])
);

CREATE TABLE [Sales] (
    [Id]                 int IDENTITY(1,1) NOT NULL,
    [ProductName]        nvarchar(max) NOT NULL,
    [ProductDescription] nvarchar(max) NOT NULL,
    [ProductPrice]       int NOT NULL,
    [Quantity]           int NOT NULL,
    [TotalPrice]         int NOT NULL,
    [CustomerName]       nvarchar(max) NOT NULL,
    [CustomerPhone]      nvarchar(max) NOT NULL,
    [ProductImagePath]   nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY ([Id])
);
GO

-- Tell EF Core the three migrations are already applied
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES
    (N'20231022180834_first',  N'7.0.12'),
    (N'20231023151433_second', N'7.0.12'),
    (N'20231025000726_third',  N'7.0.12');

-- Demo customers (fictional)
INSERT INTO [Customers] ([CustomerName], [Email], [Password], [Phone], [Address]) VALUES
    (N'Demo Customer 1', N'customer1@example.com', N'demo123', N'0770000001', N'1 Sample Street, Colombo'),
    (N'Demo Customer 2', N'customer2@example.com', N'demo123', N'0770000002', N'2 Sample Road, Kandy'),
    (N'Demo Customer 3', N'customer3@example.com', N'demo123', N'0770000003', N'3 Sample Lane, Galle'),
    -- 'Nuhaadh' is the customer the client app is hardwired to (its login user and its
    -- "Manage Your Order Details" query), so the client screens have data to show
    (N'Nuhaadh',         N'client@example.com',    N'demo123', N'0770000000', N'4 Sample Avenue, Colombo');

-- Demo products (the four image files ship in DDFootwear.API/Resources/images)
INSERT INTO [Products] ([ProductName], [ProductDescription], [WholeSalePrice], [RetailPrice], [CostPrice], [Stock], [ProductImg]) VALUES
    (N'Leather Brown Shoe',  N'Brown leather casual shoe',            17000, 35000, 7000, 80,  N'$(ImageDir)\5177fef7-27e3-4a33-bd3b-d70523df8014.png'),
    (N'Leather Casual Shoe', N'Casual leather shoe, everyday wear',   15000, 30000, 6000, 40,  N'$(ImageDir)\00c64934-1c59-4880-898a-f6e3c05f063e.png'),
    (N'Nike Branded Mens',   N'Branded men''s sports shoe, high quality', 50000, 70000, 5000, 100, N'$(ImageDir)\5853fd16-1b2a-47f3-8581-b6af169c854a.jpeg'),
    (N'Sports Shoe',         N'Lightweight sports shoe',              40000, 60000, 4000, 60,  N'$(ImageDir)\5423fa57-1325-4b0f-adc8-1a8b1851186e.jpeg');

-- Demo sales (fictional customers)
INSERT INTO [Sales] ([ProductName], [ProductDescription], [ProductPrice], [Quantity], [TotalPrice], [CustomerName], [CustomerPhone], [ProductImagePath]) VALUES
    (N'Leather Brown Shoe',  N'Brown leather casual shoe',          35000, 1, 35000,  N'Demo Customer 1', N'0770000001', N'$(ImageDir)\5177fef7-27e3-4a33-bd3b-d70523df8014.png'),
    (N'Nike Branded Mens',   N'Branded men''s sports shoe, high quality', 70000, 2, 140000, N'Demo Customer 2', N'0770000002', N'$(ImageDir)\5853fd16-1b2a-47f3-8581-b6af169c854a.jpeg'),
    (N'Leather Casual Shoe', N'Casual leather shoe, everyday wear', 30000, 3, 90000,  N'Demo Customer 1', N'0770000001', N'$(ImageDir)\00c64934-1c59-4880-898a-f6e3c05f063e.png'),
    (N'Sports Shoe',         N'Lightweight sports shoe',            60000, 1, 60000,  N'Demo Customer 3', N'0770000003', N'$(ImageDir)\5423fa57-1325-4b0f-adc8-1a8b1851186e.jpeg'),
    (N'Leather Brown Shoe',  N'Brown leather casual shoe',          35000, 2, 70000,  N'Demo Customer 3', N'0770000003', N'$(ImageDir)\5177fef7-27e3-4a33-bd3b-d70523df8014.png'),
    (N'Nike Branded Mens',   N'Branded men''s sports shoe, high quality', 70000, 1, 70000,  N'Demo Customer 1', N'0770000001', N'$(ImageDir)\5853fd16-1b2a-47f3-8581-b6af169c854a.jpeg'),
    -- orders for the client app's built-in customer 'Nuhaadh' (the client stamps a placeholder phone on every order)
    (N'Leather Brown Shoe',  N'Brown leather casual shoe',          35000, 1, 35000,  N'Nuhaadh', N'0770000000', N'$(ImageDir)\5177fef7-27e3-4a33-bd3b-d70523df8014.png'),
    (N'Sports Shoe',         N'Lightweight sports shoe',            60000, 2, 120000, N'Nuhaadh', N'0770000000', N'$(ImageDir)\5423fa57-1325-4b0f-adc8-1a8b1851186e.jpeg'),
    (N'Nike Branded Mens',   N'Branded men''s sports shoe, high quality', 70000, 1, 70000,  N'Nuhaadh', N'0770000000', N'$(ImageDir)\5853fd16-1b2a-47f3-8581-b6af169c854a.jpeg');
GO
