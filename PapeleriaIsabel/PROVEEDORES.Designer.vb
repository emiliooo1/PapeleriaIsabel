<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROVEEDORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PROVEEDORES))
        btnEliminar = New PictureBox()
        btnEditar = New PictureBox()
        btnAgregar = New PictureBox()
        PictureBox1 = New PictureBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        txtNombre = New TextBox()
        txtBuscar = New TextBox()
        txtID = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvProveedores = New DataGridView()
        CType(btnEliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Image = My.Resources.Resources.borrar
        btnEliminar.Location = New Point(235, 25)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(66, 65)
        btnEliminar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminar.TabIndex = 33
        btnEliminar.TabStop = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = My.Resources.Resources.editar
        btnEditar.Location = New Point(125, 25)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(66, 65)
        btnEditar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEditar.TabIndex = 32
        btnEditar.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.Location = New Point(19, 25)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(66, 65)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 31
        btnAgregar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(21, 448)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(107, 310)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(204, 27)
        txtTelefono.TabIndex = 28
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(107, 243)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(204, 27)
        txtCorreo.TabIndex = 27
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(107, 178)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(204, 27)
        txtNombre.TabIndex = 26
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(436, 59)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(381, 27)
        txtBuscar.TabIndex = 25
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(107, 113)
        txtID.Name = "txtID"
        txtID.Size = New Size(204, 27)
        txtID.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 9F)
        Label6.Location = New Point(14, 318)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 19)
        Label6.TabIndex = 23
        Label6.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("MS Reference Sans Serif", 9F)
        Label4.Location = New Point(14, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 19)
        Label4.TabIndex = 21
        Label4.Text = "Correo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 9F)
        Label3.Location = New Point(14, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 19)
        Label3.TabIndex = 20
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 9F)
        Label2.Location = New Point(19, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 19)
        Label2.TabIndex = 19
        Label2.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 9F)
        Label1.Location = New Point(367, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 19)
        Label1.TabIndex = 18
        Label1.Text = "Buscar"
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedores.Location = New Point(345, 93)
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.RowHeadersWidth = 51
        dgvProveedores.Size = New Size(512, 408)
        dgvProveedores.TabIndex = 17
        ' 
        ' PROVEEDORES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(945, 547)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Controls.Add(PictureBox1)
        Controls.Add(txtTelefono)
        Controls.Add(txtCorreo)
        Controls.Add(txtNombre)
        Controls.Add(txtBuscar)
        Controls.Add(txtID)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvProveedores)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PROVEEDORES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PROVEEDORES"
        CType(btnEliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnEditar As PictureBox
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProveedores As DataGridView
End Class
