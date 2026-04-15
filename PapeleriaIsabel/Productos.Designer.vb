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
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEliminar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(347, 80)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.Size = New Size(512, 408)
        dgvProductos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 9F)
        Label1.Location = New Point(369, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 19)
        Label1.TabIndex = 1
        Label1.Text = "Buscar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 9F)
        Label2.Location = New Point(21, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 19)
        Label2.TabIndex = 2
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 9F)
        Label3.Location = New Point(16, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 19)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("MS Reference Sans Serif", 9F)
        Label4.Location = New Point(21, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 19)
        Label4.TabIndex = 4
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 9F)
        Label5.Location = New Point(17, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 19)
        Label5.TabIndex = 5
        Label5.Text = "Proveedor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 9F)
        Label6.Location = New Point(16, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 19)
        Label6.TabIndex = 6
        Label6.Text = "Descripcion"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(109, 100)
        txtID.Name = "txtID"
        txtID.Size = New Size(204, 27)
        txtID.TabIndex = 7
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(438, 46)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(381, 27)
        txtBuscar.TabIndex = 8
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(109, 165)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(204, 27)
        txtNombre.TabIndex = 9
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(109, 311)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(204, 27)
        txtPrecio.TabIndex = 10
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(109, 378)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(204, 27)
        txtDescripcion.TabIndex = 11
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(109, 246)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(204, 28)
        cmbProveedor.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(23, 435)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.Location = New Point(21, 12)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(66, 65)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 14
        btnAgregar.TabStop = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = My.Resources.Resources.editar
        btnEditar.Location = New Point(127, 12)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(66, 65)
        btnEditar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEditar.TabIndex = 15
        btnEditar.TabStop = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Image = My.Resources.Resources.borrar
        btnEliminar.Location = New Point(237, 12)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(66, 65)
        btnEliminar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminar.TabIndex = 16
        btnEliminar.TabStop = False
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(890, 522)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Productos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRODUCTOS"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEliminar, ComponentModel.ISupportInitialize).EndInit()
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
End Class
