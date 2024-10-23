<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
    Inherits System.Windows.Forms.Form

    ' Declaración de los componentes
    Private components As System.ComponentModel.IContainer
    Private lblTitulo As Label
    Private txtNombreProveedor As TextBox
    Private txtTelefonoProveedor As TextBox
    Private btnAgregarProveedor As Button
    Private btnActualizarProveedor As Button
    Private btnEliminarProveedor As Button
    Private btnLimpiarProveedor As Button
    Private dgvProveedores As DataGridView

    ' Constructor
    Public Sub New()
        InitializeComponent() ' Inicializa los controles
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitulo = New Label()
        txtNombreProveedor = New TextBox()
        txtTelefonoProveedor = New TextBox()
        btnAgregarProveedor = New Button()
        btnActualizarProveedor = New Button()
        btnEliminarProveedor = New Button()
        btnLimpiarProveedor = New Button()
        dgvProveedores = New DataGridView()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        lblTitulo.Location = New Point(230, 10)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(377, 45)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Gestión de Proveedores"
        ' 
        ' txtNombreProveedor
        ' 
        txtNombreProveedor.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtNombreProveedor.BorderStyle = BorderStyle.FixedSingle
        txtNombreProveedor.Font = New Font("Segoe UI", 12.0F)
        txtNombreProveedor.Location = New Point(50, 80)
        txtNombreProveedor.Name = "txtNombreProveedor"
        txtNombreProveedor.PlaceholderText = "Nombre del Proveedor"
        txtNombreProveedor.Size = New Size(300, 29)
        txtNombreProveedor.TabIndex = 1
        ' 
        ' txtTelefonoProveedor
        ' 
        txtTelefonoProveedor.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtTelefonoProveedor.BorderStyle = BorderStyle.FixedSingle
        txtTelefonoProveedor.Font = New Font("Segoe UI", 12.0F)
        txtTelefonoProveedor.Location = New Point(50, 130)
        txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        txtTelefonoProveedor.PlaceholderText = "Teléfono del Proveedor"
        txtTelefonoProveedor.Size = New Size(300, 29)
        txtTelefonoProveedor.TabIndex = 2
        ' 
        ' btnAgregarProveedor
        ' 
        btnAgregarProveedor.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnAgregarProveedor.FlatStyle = FlatStyle.Flat
        btnAgregarProveedor.ForeColor = Color.White
        btnAgregarProveedor.Location = New Point(400, 80)
        btnAgregarProveedor.Name = "btnAgregarProveedor"
        btnAgregarProveedor.Size = New Size(120, 40)
        btnAgregarProveedor.TabIndex = 3
        btnAgregarProveedor.Text = "Agregar"
        btnAgregarProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnActualizarProveedor
        ' 
        btnActualizarProveedor.BackColor = Color.FromArgb(CByte(51), CByte(204), CByte(51))
        btnActualizarProveedor.FlatStyle = FlatStyle.Flat
        btnActualizarProveedor.ForeColor = Color.White
        btnActualizarProveedor.Location = New Point(400, 130)
        btnActualizarProveedor.Name = "btnActualizarProveedor"
        btnActualizarProveedor.Size = New Size(120, 40)
        btnActualizarProveedor.TabIndex = 4
        btnActualizarProveedor.Text = "Actualizar"
        btnActualizarProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnEliminarProveedor
        ' 
        btnEliminarProveedor.BackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        btnEliminarProveedor.FlatStyle = FlatStyle.Flat
        btnEliminarProveedor.ForeColor = Color.White
        btnEliminarProveedor.Location = New Point(530, 80)
        btnEliminarProveedor.Name = "btnEliminarProveedor"
        btnEliminarProveedor.Size = New Size(120, 40)
        btnEliminarProveedor.TabIndex = 5
        btnEliminarProveedor.Text = "Eliminar"
        btnEliminarProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiarProveedor
        ' 
        btnLimpiarProveedor.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        btnLimpiarProveedor.FlatStyle = FlatStyle.Flat
        btnLimpiarProveedor.ForeColor = Color.White
        btnLimpiarProveedor.Location = New Point(530, 130)
        btnLimpiarProveedor.Name = "btnLimpiarProveedor"
        btnLimpiarProveedor.Size = New Size(120, 40)
        btnLimpiarProveedor.TabIndex = 6
        btnLimpiarProveedor.Text = "Limpiar"
        btnLimpiarProveedor.UseVisualStyleBackColor = False
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProveedores.EnableHeadersVisualStyles = False
        dgvProveedores.GridColor = Color.LightGray
        dgvProveedores.Location = New Point(50, 200)
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.Size = New Size(700, 200)
        dgvProveedores.TabIndex = 7
        ' 
        ' frmProveedores
        ' 
        BackColor = Color.White
        ClientSize = New Size(934, 457)
        Controls.Add(lblTitulo)
        Controls.Add(txtNombreProveedor)
        Controls.Add(txtTelefonoProveedor)
        Controls.Add(btnAgregarProveedor)
        Controls.Add(btnActualizarProveedor)
        Controls.Add(btnEliminarProveedor)
        Controls.Add(btnLimpiarProveedor)
        Controls.Add(dgvProveedores)
        Name = "frmProveedores"
        Text = "Gestión de Proveedores"
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
