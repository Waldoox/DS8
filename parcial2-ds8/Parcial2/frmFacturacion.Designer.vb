<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturacion
    Inherits System.Windows.Forms.Form

    ' Declaración de componentes
    Private components As System.ComponentModel.IContainer
    Private lblTitulo As Label
    Private cmbClientes As ComboBox
    Private cmbProductos As ComboBox
    Private txtCantidad As TextBox
    Private txtTotal As TextBox
    Private btnAgregarProducto As Button
    Private btnEliminarProducto As Button
    Private btnGuardarFactura As Button
    Private dgvProductosFactura As DataGridView

    ' Constructor
    Public Sub New()
        InitializeComponent()
        ' Inicializar los placeholders para los ComboBox
        ConfigurarPlaceholders()
    End Sub

    ' Método para limpiar los recursos
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Inicializa y configura los controles del formulario
    Private Sub InitializeComponent()
        Me.lblTitulo = New Label()
        Me.cmbClientes = New ComboBox()
        Me.cmbProductos = New ComboBox()
        Me.txtCantidad = New TextBox()
        Me.txtTotal = New TextBox()
        Me.btnAgregarProducto = New Button()
        Me.btnEliminarProducto = New Button()
        Me.btnGuardarFactura = New Button()
        Me.dgvProductosFactura = New DataGridView()

        ' Configuración del Formulario Principal
        Me.Text = "Facturación"
        Me.ClientSize = New Size(800, 600)
        Me.BackColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' Configuración del Título
        Me.lblTitulo.Text = "Registro de Facturación"
        Me.lblTitulo.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.FromArgb(34, 34, 34)
        Me.lblTitulo.Location = New Point(250, 20)
        Me.lblTitulo.AutoSize = True

        ' Configuración del ComboBox Clientes
        Me.cmbClientes.Location = New Point(50, 100)
        Me.cmbClientes.Size = New Size(300, 30)
        Me.cmbClientes.Font = New Font("Segoe UI", 12)

        ' Configuración del ComboBox Productos
        Me.cmbProductos.Location = New Point(50, 150)
        Me.cmbProductos.Size = New Size(300, 30)
        Me.cmbProductos.Font = New Font("Segoe UI", 12)

        ' TextBox Cantidad
        Me.txtCantidad.Location = New Point(50, 200)
        Me.txtCantidad.Size = New Size(300, 30)
        Me.txtCantidad.Font = New Font("Segoe UI", 12)
        Me.txtCantidad.PlaceholderText = "Cantidad"
        Me.txtCantidad.BorderStyle = BorderStyle.FixedSingle

        ' TextBox Total
        Me.txtTotal.Location = New Point(50, 400)
        Me.txtTotal.Size = New Size(300, 30)
        Me.txtTotal.Font = New Font("Segoe UI", 12)
        Me.txtTotal.PlaceholderText = "Total"
        Me.txtTotal.BorderStyle = BorderStyle.FixedSingle
        Me.txtTotal.ReadOnly = True

        ' Botón Agregar Producto
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.Location = New Point(400, 150)
        Me.btnAgregarProducto.Size = New Size(150, 40)
        Me.btnAgregarProducto.BackColor = Color.FromArgb(51, 153, 255)
        Me.btnAgregarProducto.ForeColor = Color.White
        Me.btnAgregarProducto.FlatStyle = FlatStyle.Flat

        ' Botón Eliminar Producto
        Me.btnEliminarProducto.Text = "Eliminar Producto"
        Me.btnEliminarProducto.Location = New Point(400, 200)
        Me.btnEliminarProducto.Size = New Size(150, 40)
        Me.btnEliminarProducto.BackColor = Color.FromArgb(255, 77, 77)
        Me.btnEliminarProducto.ForeColor = Color.White
        Me.btnEliminarProducto.FlatStyle = FlatStyle.Flat

        ' Botón Guardar Factura
        Me.btnGuardarFactura.Text = "Guardar Factura"
        Me.btnGuardarFactura.Location = New Point(400, 400)
        Me.btnGuardarFactura.Size = New Size(150, 40)
        Me.btnGuardarFactura.BackColor = Color.FromArgb(51, 204, 51)
        Me.btnGuardarFactura.ForeColor = Color.White
        Me.btnGuardarFactura.FlatStyle = FlatStyle.Flat

        ' DataGridView Productos de la Factura
        Me.dgvProductosFactura.Location = New Point(50, 250)
        Me.dgvProductosFactura.Size = New Size(700, 120)
        Me.dgvProductosFactura.BackgroundColor = Color.White
        Me.dgvProductosFactura.GridColor = Color.LightGray
        Me.dgvProductosFactura.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76)
        Me.dgvProductosFactura.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvProductosFactura.EnableHeadersVisualStyles = False

        ' Agregar los controles al formulario
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnGuardarFactura)
        Me.Controls.Add(Me.dgvProductosFactura)
    End Sub

    ' Configura placeholders para los ComboBox
    Private Sub ConfigurarPlaceholders()
        SetPlaceholder(cmbClientes, "Selecciona un Cliente")
        SetPlaceholder(cmbProductos, "Selecciona un Producto")
    End Sub

    ' Método para agregar y manejar placeholders en ComboBox
    Private Sub SetPlaceholder(cmb As ComboBox, placeholder As String)
        cmb.Items.Add(placeholder)
        cmb.SelectedIndex = 0
        cmb.ForeColor = Color.Gray

        AddHandler cmb.GotFocus, Sub()
                                     If cmb.SelectedItem.ToString() = placeholder Then
                                         cmb.SelectedIndex = -1
                                         cmb.ForeColor = Color.Black
                                     End If
                                 End Sub

        AddHandler cmb.LostFocus, Sub()
                                      If cmb.SelectedIndex = -1 Then
                                          cmb.SelectedIndex = 0
                                          cmb.ForeColor = Color.Gray
                                      End If
                                  End Sub
    End Sub
End Class
