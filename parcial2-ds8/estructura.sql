-- Crear la base de datos
GO
CREATE DATABASE "parcial2";
GO
USE "parcial2";
GO

-- Tabla de Productos
CREATE TABLE Productos (
    ProductoID INT IDENTITY NOT NULL PRIMARY KEY,
    NombreProducto VARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    FechaIngreso DATE NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Tabla de Categorías
CREATE TABLE Categorías (
    CategoriaID INT IDENTITY NOT NULL PRIMARY KEY,
    NombreCategoria VARCHAR(50) NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Tabla de Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT IDENTITY NOT NULL PRIMARY KEY,
    NombreProveedor VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT IDENTITY NOT NULL PRIMARY KEY,
    NombreCliente VARCHAR(50) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Tabla de Facturas
CREATE TABLE Facturas (
    FacturaID INT IDENTITY NOT NULL PRIMARY KEY,
    ClienteID INT NOT NULL,
    FechaFactura DATE NOT NULL,
    TotalFactura DECIMAL(10, 2) NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Tabla de DetallesFactura
CREATE TABLE DetallesFactura (
    DetalleID INT IDENTITY NOT NULL PRIMARY KEY,
    FacturaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- Agregar restricciones UNIQUE
ALTER TABLE Productos
ADD CONSTRAINT UQ_Productos_NombreProducto UNIQUE (NombreProducto);
GO

ALTER TABLE Categorías
ADD CONSTRAINT UQ_Categorías_NombreCategoria UNIQUE (NombreCategoria);
GO

ALTER TABLE Clientes
ADD CONSTRAINT UQ_Clientes_Correo UNIQUE (Correo);
GO

-- Agregar restricciones FOREIGN KEY
ALTER TABLE Facturas
ADD CONSTRAINT FK_Facturas_Clientes FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID);
GO

ALTER TABLE DetallesFactura
ADD CONSTRAINT FK_DetallesFactura_Facturas FOREIGN KEY (FacturaID) REFERENCES Facturas(FacturaID);
GO

ALTER TABLE DetallesFactura
ADD CONSTRAINT FK_DetallesFactura_Productos FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID);
GO
