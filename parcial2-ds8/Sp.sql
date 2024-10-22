-- Procedimiento para agregar un nuevo producto
CREATE PROCEDURE AddProducto
    @NombreProducto VARCHAR(50),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @FechaIngreso DATE,
    @Activo BIT = 1  -- Valor predeterminado a true
AS
BEGIN
    INSERT INTO Productos (NombreProducto, Precio, Stock, FechaIngreso, activo)
    VALUES (@NombreProducto, @Precio, @Stock, @FechaIngreso, @Activo);
END
GO

-- Procedimiento para obtener todos los productos
CREATE PROCEDURE GetAllProductos
AS
BEGIN
    SELECT * FROM Productos;
END
GO

-- Procedimiento para obtener un producto por ID
CREATE PROCEDURE GetProductoById
    @ProductoID INT
AS
BEGIN
    SELECT * FROM Productos WHERE ProductoID = @ProductoID;
END
GO

-- Procedimiento para actualizar un producto
CREATE PROCEDURE UpdateProducto
    @ProductoID INT,
    @NombreProducto VARCHAR(50),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @FechaIngreso DATE,
    @Activo BIT
AS
BEGIN
    UPDATE Productos
    SET NombreProducto = @NombreProducto,
        Precio = @Precio,
        Stock = @Stock,
        FechaIngreso = @FechaIngreso,
        activo = @Activo
    WHERE ProductoID = @ProductoID;
END
GO

-- Procedimiento para eliminar un producto
CREATE PROCEDURE DeleteProducto
    @ProductoID INT
AS
BEGIN
    DELETE FROM Productos WHERE ProductoID = @ProductoID;
END
GO

-- Procedimiento para agregar una nueva categoría
CREATE PROCEDURE AddCategoria
    @NombreCategoria VARCHAR(50)
AS
BEGIN
    INSERT INTO Categorías (NombreCategoria)
    VALUES (@NombreCategoria);
END
GO

-- Procedimiento para obtener todas las categorías
CREATE PROCEDURE GetAllCategorias
AS
BEGIN
    SELECT * FROM Categorías;
END
GO

-- Procedimiento para obtener una categoría por ID
CREATE PROCEDURE GetCategoriaById
    @CategoriaID INT
AS
BEGIN
    SELECT * FROM Categorías WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para actualizar una categoría
CREATE PROCEDURE UpdateCategoria
    @CategoriaID INT,
    @NombreCategoria VARCHAR(50)
AS
BEGIN
    UPDATE Categorías
    SET NombreCategoria = @NombreCategoria
    WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para eliminar una categoría
CREATE PROCEDURE DeleteCategoria
    @CategoriaID INT
AS
BEGIN
    DELETE FROM Categorías WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para agregar un nuevo proveedor
CREATE PROCEDURE AddProveedor
    @NombreProveedor VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    INSERT INTO Proveedores (NombreProveedor, Telefono)
    VALUES (@NombreProveedor, @Telefono);
END
GO

-- Procedimiento para obtener todos los proveedores
CREATE PROCEDURE GetAllProveedores
AS
BEGIN
    SELECT * FROM Proveedores;
END
GO

-- Procedimiento para obtener un proveedor por ID
CREATE PROCEDURE GetProveedorById
    @ProveedorID INT
AS
BEGIN
    SELECT * FROM Proveedores WHERE ProveedorID = @ProveedorID;
END
GO

-- Procedimiento para actualizar un proveedor
CREATE PROCEDURE UpdateProveedor
    @ProveedorID INT,
    @NombreProveedor VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    UPDATE Proveedores
    SET NombreProveedor = @NombreProveedor,
        Telefono = @Telefono
    WHERE ProveedorID = @ProveedorID;
END
GO

-- Procedimiento para eliminar un proveedor
CREATE PROCEDURE DeleteProveedor
    @ProveedorID INT
AS
BEGIN
    DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID;
END
GO

-- Procedimiento para agregar un nuevo cliente
CREATE PROCEDURE AddCliente
    @NombreCliente VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    INSERT INTO Clientes (NombreCliente, Correo, Telefono)
    VALUES (@NombreCliente, @Correo, @Telefono);
END
GO

-- Procedimiento para obtener todos los clientes
CREATE PROCEDURE GetAllClientes
AS
BEGIN
    SELECT * FROM Clientes;
END
GO

-- Procedimiento para obtener un cliente por ID
CREATE PROCEDURE GetClienteById
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Clientes WHERE ClienteID = @ClienteID;
END
GO

-- Procedimiento para actualizar un cliente
CREATE PROCEDURE UpdateCliente
    @ClienteID INT,
    @NombreCliente VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    UPDATE Clientes
    SET NombreCliente = @NombreCliente,
        Correo = @Correo,
        Telefono = @Telefono
    WHERE ClienteID = @ClienteID;
END
GO

-- Procedimiento para eliminar un cliente
CREATE PROCEDURE DeleteCliente
    @ClienteID INT
AS
BEGIN
    DELETE FROM Clientes WHERE ClienteID = @ClienteID;
END
GO

-- Procedimiento para agregar una nueva factura
CREATE PROCEDURE AddFactura
    @ClienteID INT,
    @FechaFactura DATE,
    @TotalFactura DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Facturas (ClienteID, FechaFactura, TotalFactura)
    VALUES (@ClienteID, @FechaFactura, @TotalFactura);
END
GO

-- Procedimiento para obtener todas las facturas
CREATE PROCEDURE GetAllFacturas
AS
BEGIN
    SELECT * FROM Facturas;
END
GO

-- Procedimiento para obtener una factura por ID
CREATE PROCEDURE GetFacturaById
    @FacturaID INT
AS
BEGIN
    SELECT * FROM Facturas WHERE FacturaID = @FacturaID;
END
GO

-- Procedimiento para actualizar una factura
CREATE PROCEDURE UpdateFactura
    @FacturaID INT,
    @ClienteID INT,
    @FechaFactura DATE,
    @TotalFactura DECIMAL(10, 2)
AS
BEGIN
    UPDATE Facturas
    SET ClienteID = @ClienteID,
        FechaFactura = @FechaFactura,
        TotalFactura = @TotalFactura
    WHERE FacturaID = @FacturaID;
END
GO

-- Procedimiento para eliminar una factura
CREATE PROCEDURE DeleteFactura
    @FacturaID INT
AS
BEGIN
    DELETE FROM Facturas WHERE FacturaID = @FacturaID;
END
GO

-- Procedimiento para agregar un detalle de factura
CREATE PROCEDURE AddDetalleFactura
    @FacturaID INT,
    @ProductoID INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO DetallesFactura (FacturaID, ProductoID, Cantidad, PrecioUnitario)
    VALUES (@FacturaID, @ProductoID, @Cantidad, @PrecioUnitario);
END
GO

-- Procedimiento para obtener todos los detalles de factura
CREATE PROCEDURE GetAllDetallesFactura
AS
BEGIN
    SELECT * FROM DetallesFactura;
END
GO

-- Procedimiento para obtener un detalle de factura por ID
CREATE PROCEDURE GetDetalleFacturaById
    @DetalleID INT
AS
BEGIN
    SELECT * FROM DetallesFactura WHERE DetalleID = @DetalleID;
END
GO

-- Procedimiento para actualizar un detalle de factura
CREATE PROCEDURE UpdateDetalleFactura
    @DetalleID INT,
    @FacturaID INT,
    @ProductoID INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    UPDATE DetallesFactura
    SET FacturaID = @FacturaID,
        ProductoID = @ProductoID,
        Cantidad = @Cantidad,
        PrecioUnitario = @PrecioUnitario
    WHERE DetalleID = @DetalleID;
END
GO

-- Procedimiento para eliminar un detalle de factura
CREATE PROCEDURE DeleteDetalleFactura
    @DetalleID INT
AS
BEGIN
    DELETE FROM DetallesFactura WHERE DetalleID = @DetalleID;
END
GO
