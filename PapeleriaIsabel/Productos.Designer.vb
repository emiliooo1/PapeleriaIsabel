<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        dgvProductos = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtID = New TextBox()
        txtBuscar = New TextBox()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        txtDescripcion = New TextBox()
        cmbProveedor = New ComboBox()
        PictureBox1 = New PictureBox()
        btnAgregar = New PictureBox()
        btnEditar = New PictureBox()
        btnEliminar = New PictureBox()
        Button1 = New Button()
        Label7 = New Label()
        btnLimpiar = New PictureBox()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLimpiar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.BackgroundColor = Color.WhiteSmoke
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(609, 218)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.ReadOnly = True
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.Size = New Size(1087, 559)
        dgvProductos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(609, 170)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 35)
        Label1.TabIndex = 1
        Label1.Text = "Buscar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label2.Location = New Point(54, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 35)
        Label2.TabIndex = 2
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label3.Location = New Point(49, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 35)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label4.Location = New Point(54, 524)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 35)
        Label4.TabIndex = 4
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label5.Location = New Point(50, 455)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 35)
        Label5.TabIndex = 5
        Label5.Text = "Proveedor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label6.Location = New Point(49, 591)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 35)
        Label6.TabIndex = 6
        Label6.Text = "Descripcion"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtID.Location = New Point(254, 301)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(219, 43)
        txtID.TabIndex = 7
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(743, 163)
        txtBuscar.Multiline = True
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(787, 42)
        txtBuscar.TabIndex = 8
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(254, 368)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(219, 45)
        txtNombre.TabIndex = 9
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtPrecio.Location = New Point(254, 521)
        txtPrecio.Multiline = True
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(219, 43)
        txtPrecio.TabIndex = 10
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtDescripcion.Location = New Point(254, 581)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(219, 45)
        txtDescripcion.TabIndex = 11
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(254, 450)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(219, 42)
        cmbProveedor.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.regresar
        PictureBox1.Location = New Point(49, 874)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.White
        btnAgregar.Image = My.Resources.Resources.botonagregarfondo
        btnAgregar.Location = New Point(50, 68)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(112, 121)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 14
        btnAgregar.TabStop = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.White
        btnEditar.Image = My.Resources.Resources.editar__1_
        btnEditar.Location = New Point(189, 68)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 121)
        btnEditar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEditar.TabIndex = 15
        btnEditar.TabStop = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.White
        btnEliminar.Image = My.Resources.Resources.eliminarfondo
        btnEliminar.Location = New Point(329, 68)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(113, 121)
        btnEliminar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminar.TabIndex = 16
        btnEliminar.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 19
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Microsoft YaHei", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(1), CByte(61), CByte(90))
        Label7.Location = New Point(1367, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(329, 62)
        Label7.TabIndex = 36
        Label7.Text = "PRODUCTOS"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.White
        btnLimpiar.Image = My.Resources.Resources.borrar__1_
        btnLimpiar.Location = New Point(475, 68)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(113, 121)
        btnLimpiar.SizeMode = PictureBoxSizeMode.StretchImage
        btnLimpiar.TabIndex = 37
        btnLimpiar.TabStop = False
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(btnLimpiar)
        Controls.Add(Label7)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Controls.Add(PictureBox1)
        Controls.Add(cmbProveedor)
        Controls.Add(txtDescripcion)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Controls.Add(txtBuscar)
        Controls.Add(txtID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvProductos)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "Productos"
        StartPosition = FormStartPosition.Manual
        Text = "PRODUCTOS"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLimpiar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents btnEditar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLimpiar As PictureBox
End Class
