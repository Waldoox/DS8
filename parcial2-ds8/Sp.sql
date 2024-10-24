-- Procedimiento para agregar un nuevo producto
CREATE PROCEDURE AgregarProducto
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
CREATE PROCEDURE ObtenerTodosProductos
AS
BEGIN
    SELECT * FROM Productos;
END
GO

-- Procedimiento para obtener un producto por ID
CREATE PROCEDURE ObtenerProductoPorId
    @ProductoID INT
AS
BEGIN
    SELECT * FROM Productos WHERE ProductoID = @ProductoID;
END
GO

-- Procedimiento para actualizar un producto
CREATE PROCEDURE ActualizarProducto
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

-- Procedimiento para "eliminar" un producto
CREATE PROCEDURE EliminarProducto
    @ProductoID INT
AS
BEGIN
    UPDATE Productos
    SET activo = 0
    WHERE ProductoID = @ProductoID;
END
GO

-- Procedimiento para agregar una nueva categoría
CREATE PROCEDURE AgregarCategoria
    @NombreCategoria VARCHAR(50)
AS
BEGIN
    INSERT INTO Categorías (NombreCategoria)
    VALUES (@NombreCategoria);
END
GO

-- Procedimiento para obtener todas las categorías
CREATE PROCEDURE ObtenerTodasCategorias
AS
BEGIN
    SELECT * FROM Categorías;
END
GO

-- Procedimiento para obtener una categoría por ID
CREATE PROCEDURE ObtenerCategoriaPorId
    @CategoriaID INT
AS
BEGIN
    SELECT * FROM Categorías WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para actualizar una categoría
CREATE PROCEDURE ActualizarCategoria
    @CategoriaID INT,
    @NombreCategoria VARCHAR(50)
AS
BEGIN
    UPDATE Categorías
    SET NombreCategoria = @NombreCategoria
    WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para "eliminar" una categoría
CREATE PROCEDURE EliminarCategoria
    @CategoriaID INT
AS
BEGIN
    UPDATE Categorías
    SET activo = 0
    WHERE CategoriaID = @CategoriaID;
END
GO

-- Procedimiento para agregar un nuevo proveedor
CREATE PROCEDURE AgregarProveedor
    @NombreProveedor VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    INSERT INTO Proveedores (NombreProveedor, Telefono)
    VALUES (@NombreProveedor, @Telefono);
END
GO

-- Procedimiento para obtener todos los proveedores
CREATE PROCEDURE ObtenerTodosProveedores
AS
BEGIN
    SELECT * FROM Proveedores;
END
GO

-- Procedimiento para obtener un proveedor por ID
CREATE PROCEDURE ObtenerProveedorPorId
    @ProveedorID INT
AS
BEGIN
    SELECT * FROM Proveedores WHERE ProveedorID = @ProveedorID;
END
GO

-- Procedimiento para actualizar un proveedor
CREATE PROCEDURE ActualizarProveedor
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

-- Procedimiento para "eliminar" un proveedor
CREATE PROCEDURE EliminarProveedor
    @ProveedorID INT
AS
BEGIN
    UPDATE Proveedores
    SET activo = 0
    WHERE ProveedorID = @ProveedorID;
END
GO

-- Procedimiento para agregar un nuevo cliente
CREATE PROCEDURE AgregarCliente
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
CREATE PROCEDURE ObtenerTodosClientes
AS
BEGIN
    SELECT * FROM Clientes;
END
GO

-- Procedimiento para obtener un cliente por ID
CREATE PROCEDURE ObtenerClientePorId
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Clientes WHERE ClienteID = @ClienteID;
END
GO

-- Procedimiento para actualizar un cliente
CREATE PROCEDURE ActualizarCliente
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

-- Procedimiento para "eliminar" un cliente
CREATE PROCEDURE EliminarCliente
    @ClienteID INT
AS
BEGIN
    UPDATE Clientes
    SET activo = 0
    WHERE ClienteID = @ClienteID;
END
GO

-- Procedimiento para agregar una nueva factura
CREATE PROCEDURE AgregarFactura
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
CREATE PROCEDURE ObtenerTodasFacturas
AS
BEGIN
    SELECT * FROM Facturas;
END
GO

-- Procedimiento para obtener una factura por ID
CREATE PROCEDURE ObtenerFacturaPorId
    @FacturaID INT
AS
BEGIN
    SELECT * FROM Facturas WHERE FacturaID = @FacturaID;
END
GO

-- Procedimiento para actualizar una factura
CREATE PROCEDURE ActualizarFactura
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

-- Procedimiento para "eliminar" una factura
CREATE PROCEDURE EliminarFactura
    @FacturaID INT
AS
BEGIN
    UPDATE Facturas
    SET activo = 0
    WHERE FacturaID = @FacturaID;
END
GO

-- Procedimiento para agregar un detalle de factura
CREATE PROCEDURE AgregarDetalleFactura
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
CREATE PROCEDURE ObtenerTodosDetallesFactura
AS
BEGIN
    SELECT * FROM DetallesFactura;
END
GO

-- Procedimiento para obtener un detalle de factura por ID
CREATE PROCEDURE ObtenerDetalleFacturaPorId
    @DetalleID INT
AS
BEGIN
    SELECT * FROM DetallesFactura WHERE DetalleID = @DetalleID;
END
GO

-- Procedimiento para actualizar un detalle de factura
CREATE PROCEDURE ActualizarDetalleFactura
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

-- Procedimiento para "eliminar" un detalle de factura
CREATE PROCEDURE EliminarDetalleFactura
    @DetalleID INT
AS
BEGIN
    UPDATE DetallesFactura
    SET activo = 0
    WHERE DetalleID = @DetalleID;
END
GO
