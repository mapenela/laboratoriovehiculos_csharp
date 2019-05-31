
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/29/2016 19:08:42
-- Generated from EDMX file: C:\PROYECTO_VEHICULOS\PRUEBALABORATORIO\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PRUEBASLOCAL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[VEHICULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VEHICULOS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VEHICULOS'
CREATE TABLE [dbo].[VEHICULOS] (
    [IdVehiculo] int IDENTITY(1,1) NOT NULL,
    [Marca] varchar(50)  NULL,
    [Modelo] varchar(50)  NULL,
    [Precio] decimal(18,2)  NULL,
    [FechaFabrica] datetime  NULL,
    [Estado] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdVehiculo] in table 'VEHICULOS'
ALTER TABLE [dbo].[VEHICULOS]
ADD CONSTRAINT [PK_VEHICULOS]
    PRIMARY KEY CLUSTERED ([IdVehiculo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------