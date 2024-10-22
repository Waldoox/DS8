-- Crear la base de datos
GO
CREATE DATABASE "parcial2";
GO
USE "parcial2";
GO
-- Tabla de Productos
CREATE TABLE Productos (
    ProductoID INT IDENTITY NOT NULL,
    NombreProducto VARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    FechaIngreso DATE NOT NULL
);
GO

-- Tabla de Categorías
CREATE TABLE Categorías (
    CategoriaID INT IDENTITY NOT NULL,
    NombreCategoria VARCHAR(50) NOT NULL
);
GO

-- Tabla de Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT identity NOT NULL ,
    NombreProveedor VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL
);

GO

-- Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT IDENTITY NOT NULL ,
    NombreCliente VARCHAR(50) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL
);

GO

-- Tabla de Facturas
CREATE TABLE Facturas (
    FacturaID INT IDENTITY NOT NULL,
    ClienteID INT NOT NULL,
    FechaFactura DATE NOT NULL,
    TotalFactura DECIMAL(10, 2) NOT NULL
);

GO
-- Tabla de DetallesFactura
CREATE TABLE DetallesFactura (
    DetalleID INT IDENTITY NOT NULL ,
    FacturaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL
);

GO
-- Agregar claves primarias
ALTER TABLE Productos
ADD CONSTRAINT PK_Productos PRIMARY KEY (ProductoID);

GO
ALTER TABLE Categorías
ADD CONSTRAINT PK_Categorías PRIMARY KEY (CategoriaID);

GO
ALTER TABLE Proveedores
ADD CONSTRAINT PK_Proveedores PRIMARY KEY (ProveedorID);

GO
ALTER TABLE Clientes
ADD CONSTRAINT PK_Clientes PRIMARY KEY (ClienteID);

GO
ALTER TABLE Facturas
ADD CONSTRAINT PK_Facturas PRIMARY KEY (FacturaID);

GO
ALTER TABLE DetallesFactura
ADD CONSTRAINT PK_DetallesFactura PRIMARY KEY (DetalleID);

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
