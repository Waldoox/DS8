<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblCorreoCliente = New System.Windows.Forms.Label()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnActualizarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnLimpiarCliente = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 160)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(760, 300)
        Me.dgvClientes.TabIndex = 0
        '
        ' txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 25)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(200, 23)
        Me.txtNombreCliente.TabIndex = 1
        '
        ' txtCorreoCliente
        '
        Me.txtCorreoCliente.Location = New System.Drawing.Point(12, 75)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.Size = New System.Drawing.Size(200, 23)
        Me.txtCorreoCliente.TabIndex = 2
        '
        ' txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(12, 125)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(200, 23)
        Me.txtTelefonoCliente.TabIndex = 3
        '
        ' lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(12, 7)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(49, 15)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "Nombre"
        '
        ' lblCorreoCliente
        '
        Me.lblCorreoCliente.AutoSize = True
        Me.lblCorreoCliente.Location = New System.Drawing.Point(12, 57)
        Me.lblCorreoCliente.Name = "lblCorreoCliente"
        Me.lblCorreoCliente.Size = New System.Drawing.Size(41, 15)
        Me.lblCorreoCliente.TabIndex = 5
        Me.lblCorreoCliente.Text = "Correo"
        '
        ' lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(12, 107)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(52, 15)
        Me.lblTelefonoCliente.TabIndex = 6
        Me.lblTelefonoCliente.Text = "Teléfono"
        '
        ' btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(250, 25)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCliente.TabIndex = 7
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        ' btnActualizarCliente
        '
        Me.btnActualizarCliente.Location = New System.Drawing.Point(250, 75)
        Me.btnActualizarCliente.Name = "btnActualizarCliente"
        Me.btnActualizarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarCliente.TabIndex = 8
        Me.btnActualizarCliente.Text = "Actualizar"
        Me.btnActualizarCliente.UseVisualStyleBackColor = True
        '
        ' btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(250, 125)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCliente.TabIndex = 9
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        ' btnLimpiarCliente
        '
        Me.btnLimpiarCliente.Location = New System.Drawing.Point(350, 75)
        Me.btnLimpiarCliente.Name = "btnLimpiarCliente"
        Me.btnLimpiarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCliente.TabIndex = 10
        Me.btnLimpiarCliente.Text = "Limpiar"
        Me.btnLimpiarCliente.UseVisualStyleBackColor = True
        '
        ' frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 457)
        Me.Controls.Add(Me.btnLimpiarCliente)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnActualizarCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.lblTelefonoCliente)
        Me.Controls.Add(Me.lblCorreoCliente)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtTelefonoCliente)
        Me.Controls.Add(Me.txtCorreoCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "frmClientes"
        Me.Text = "Gestión de Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtCorreoCliente As TextBox
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblCorreoCliente As Label
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnActualizarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnLimpiarCliente As Button
End Class