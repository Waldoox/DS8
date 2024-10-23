<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso productsComponents IsNot Nothing Then
                productsComponents.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private productsComponents As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtNombreProducto = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        dtpFechaIngreso = New DateTimePicker()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        dgvProductos = New DataGridView()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ContextMenuStrip2 = New ContextMenuStrip(components)
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(14, 100)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.PlaceholderText = "Nombre del Producto"
        txtNombreProducto.Size = New Size(200, 23)
        txtNombreProducto.TabIndex = 0
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(14, 140)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.PlaceholderText = "Precio"
        txtPrecio.Size = New Size(200, 23)
        txtPrecio.TabIndex = 1
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(14, 180)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(200, 23)
        txtStock.TabIndex = 2
        ' 
        ' dtpFechaIngreso
        ' 
        dtpFechaIngreso.Location = New Point(14, 220)
        dtpFechaIngreso.Name = "dtpFechaIngreso"
        dtpFechaIngreso.Size = New Size(200, 23)
        dtpFechaIngreso.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(14, 260)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(95, 30)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(119, 260)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(95, 30)
        btnActualizar.TabIndex = 5
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(14, 300)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(95, 30)
        btnEliminar.TabIndex = 6
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(119, 300)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(95, 30)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' dgvProductos
        ' 
        dgvProductos.BackgroundColor = SystemColors.Control
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.GridColor = SystemColors.Window
        dgvProductos.Location = New Point(230, 33)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(680, 400)
        dgvProductos.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Segoe UI", 24.0F)
        Label1.Location = New Point(31, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 45)
        Label1.TabIndex = 9
        Label1.Text = "Productos"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 457)
        Controls.Add(Label1)
        Controls.Add(dgvProductos)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(dtpFechaIngreso)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombreProducto)
        Name = "frmProductos"
        Text = "Gestión de Productos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Private components As System.ComponentModel.IContainer
End Class