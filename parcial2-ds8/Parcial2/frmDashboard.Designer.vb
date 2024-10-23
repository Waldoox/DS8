<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    ' Declaración de controles del formulario
    Private pnlMenu As Panel
    Private pnlContenido As Panel
    Private btnClientes As Button
    Private btnProductos As Button
    Private btnFacturacion As Button
    Private btnProveedores As Button
    Private btnReportes As Button
    Private components As System.ComponentModel.IContainer

    ' Constructor
    Public Sub New()
        MyBase.New() ' Asegura la inicialización de la clase base
        InitializeComponent() ' Inicializa los controles
    End Sub

    ' Dispose: Limpia los recursos utilizados por el formulario
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Inicializa los controles del formulario
    Private Sub InitializeComponent()
        Me.pnlMenu = New Panel()
        Me.pnlContenido = New Panel()
        Me.btnClientes = New Button()
        Me.btnProductos = New Button()
        Me.btnFacturacion = New Button()
        Me.btnProveedores = New Button()
        Me.btnReportes = New Button()

        ' Configuración del Panel de Menú
        Me.pnlMenu.BackColor = Color.FromArgb(51, 51, 76)
        Me.pnlMenu.Dock = DockStyle.Top
        Me.pnlMenu.Size = New Size(1000, 50)

        ' Configuración del Panel de Contenido
        Me.pnlContenido.Dock = DockStyle.Fill
        Me.pnlContenido.BackColor = Color.White

        ' Botón Clientes
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.Size = New Size(100, 30)
        Me.btnClientes.Location = New Point(10, 10)
        Me.btnClientes.BackColor = Color.FromArgb(51, 153, 255)
        Me.btnClientes.FlatStyle = FlatStyle.Flat
        Me.btnClientes.ForeColor = Color.White
        AddHandler Me.btnClientes.Click, AddressOf Me.btnClientes_Click

        ' Botón Productos
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.Size = New Size(100, 30)
        Me.btnProductos.Location = New Point(120, 10)
        Me.btnProductos.BackColor = Color.FromArgb(51, 204, 51)
        Me.btnProductos.FlatStyle = FlatStyle.Flat
        Me.btnProductos.ForeColor = Color.White
        AddHandler Me.btnProductos.Click, AddressOf Me.btnProductos_Click

        ' Botón Facturación
        Me.btnFacturacion.Text = "Facturación"
        Me.btnFacturacion.Size = New Size(100, 30)
        Me.btnFacturacion.Location = New Point(230, 10)
        Me.btnFacturacion.BackColor = Color.FromArgb(255, 153, 51)
        Me.btnFacturacion.FlatStyle = FlatStyle.Flat
        Me.btnFacturacion.ForeColor = Color.White
        AddHandler Me.btnFacturacion.Click, AddressOf Me.btnFacturacion_Click

        ' Botón Proveedores
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.Size = New Size(100, 30)
        Me.btnProveedores.Location = New Point(340, 10)
        Me.btnProveedores.BackColor = Color.FromArgb(204, 102, 255)
        Me.btnProveedores.FlatStyle = FlatStyle.Flat
        Me.btnProveedores.ForeColor = Color.White
        AddHandler Me.btnProveedores.Click, AddressOf Me.btnProveedores_Click

        ' Botón Reportes
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.Size = New Size(100, 30)
        Me.btnReportes.Location = New Point(450, 10)
        Me.btnReportes.BackColor = Color.FromArgb(255, 204, 0)
        Me.btnReportes.FlatStyle = FlatStyle.Flat
        Me.btnReportes.ForeColor = Color.White
        AddHandler Me.btnReportes.Click, AddressOf Me.btnReportes_Click

        ' Agrega los botones al panel de menú
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.btnProductos)
        Me.pnlMenu.Controls.Add(Me.btnFacturacion)
        Me.pnlMenu.Controls.Add(Me.btnProveedores)
        Me.pnlMenu.Controls.Add(Me.btnReportes)

        ' Configuración del formulario principal
        Me.Text = "Dashboard Principal"
        Me.ClientSize = New Size(1000, 600)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
    End Sub

    ' Métodos para abrir formularios

    Private Sub btnClientes_Click(sender As Object, e As EventArgs)
        AbrirFormulario(New frmClientes())
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs)
        AbrirFormulario(New frmProductos())
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs)
        AbrirFormulario(New frmFacturacion())
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs)
        AbrirFormulario(New frmProveedores())
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs)
        AbrirFormulario(New frmReportes())
    End Sub

    ' Método para abrir un formulario dentro del panel de contenido
    Private Sub AbrirFormulario(frm As Form)
        Me.pnlContenido.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        Me.pnlContenido.Controls.Add(frm)
        frm.Show()
    End Sub
End Class
