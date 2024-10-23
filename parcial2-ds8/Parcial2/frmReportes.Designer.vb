<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes
    Inherits System.Windows.Forms.Form

    ' Declaración de los componentes
    Private components As System.ComponentModel.IContainer
    Private lblTitulo As Label
    Private cmbTipoReporte As ComboBox
    Private dtpFechaInicio As DateTimePicker
    Private dtpFechaFin As DateTimePicker
    Private btnGenerarReporte As Button
    Private btnExportarPDF As Button
    Private btnExportarExcel As Button
    Private dgvReporte As DataGridView

    ' Constructor del formulario
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Método para limpiar los recursos
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Inicializa los controles del formulario
    Private Sub InitializeComponent()
        Me.lblTitulo = New Label()
        Me.cmbTipoReporte = New ComboBox()
        Me.dtpFechaInicio = New DateTimePicker()
        Me.dtpFechaFin = New DateTimePicker()
        Me.btnGenerarReporte = New Button()
        Me.btnExportarPDF = New Button()
        Me.btnExportarExcel = New Button()
        Me.dgvReporte = New DataGridView()

        ' Configuración del Formulario Principal
        Me.Text = "Gestión de Reportes"
        Me.ClientSize = New Size(900, 550)
        Me.BackColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' Configuración del Título
        Me.lblTitulo.Text = "Generador de Reportes"
        Me.lblTitulo.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.FromArgb(34, 34, 34)
        Me.lblTitulo.Location = New Point(250, 20)
        Me.lblTitulo.AutoSize = True

        ' ComboBox Tipo de Reporte
        Me.cmbTipoReporte.Location = New Point(50, 100)
        Me.cmbTipoReporte.Size = New Size(300, 30)
        Me.cmbTipoReporte.Font = New Font("Segoe UI", 12)
        Me.cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbTipoReporte.Items.AddRange(New String() {
            "Ventas por Cliente", "Ventas por Producto", "Productos Agotados", "Facturación por Fecha"})

        ' DateTimePicker Fecha Inicio
        Me.dtpFechaInicio.Location = New Point(50, 150)
        Me.dtpFechaInicio.Size = New Size(300, 30)
        Me.dtpFechaInicio.Font = New Font("Segoe UI", 12)

        ' DateTimePicker Fecha Fin
        Me.dtpFechaFin.Location = New Point(400, 150)
        Me.dtpFechaFin.Size = New Size(300, 30)
        Me.dtpFechaFin.Font = New Font("Segoe UI", 12)

        ' Botón Generar Reporte
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.Location = New Point(50, 200)
        Me.btnGenerarReporte.Size = New Size(150, 40)
        Me.btnGenerarReporte.BackColor = Color.FromArgb(51, 204, 51)
        Me.btnGenerarReporte.ForeColor = Color.White
        Me.btnGenerarReporte.FlatStyle = FlatStyle.Flat

        ' Botón Exportar a PDF
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.Location = New Point(220, 200)
        Me.btnExportarPDF.Size = New Size(150, 40)
        Me.btnExportarPDF.BackColor = Color.FromArgb(255, 77, 77)
        Me.btnExportarPDF.ForeColor = Color.White
        Me.btnExportarPDF.FlatStyle = FlatStyle.Flat

        ' Botón Exportar a Excel
        Me.btnExportarExcel.Text = "Exportar a Excel"
        Me.btnExportarExcel.Location = New Point(400, 200)
        Me.btnExportarExcel.Size = New Size(150, 40)
        Me.btnExportarExcel.BackColor = Color.FromArgb(51, 153, 255)
        Me.btnExportarExcel.ForeColor = Color.White
        Me.btnExportarExcel.FlatStyle = FlatStyle.Flat

        ' DataGridView para mostrar los reportes
        Me.dgvReporte.Location = New Point(50, 260)
        Me.dgvReporte.Size = New Size(800, 250)
        Me.dgvReporte.BackgroundColor = Color.White
        Me.dgvReporte.GridColor = Color.LightGray
        Me.dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76)
        Me.dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvReporte.EnableHeadersVisualStyles = False

        ' Agregar los controles al formulario
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmbTipoReporte)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.dgvReporte)
    End Sub
End Class
