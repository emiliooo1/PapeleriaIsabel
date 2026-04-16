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
        Button1 = New Button()
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
        btnEliminar.Location = New Point(329, 66)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(93, 95)
        btnEliminar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminar.TabIndex = 33
        btnEliminar.TabStop = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = My.Resources.Resources.editar
        btnEditar.Location = New Point(181, 66)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(93, 95)
        btnEditar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEditar.TabIndex = 32
        btnEditar.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.Location = New Point(49, 66)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(93, 95)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 31
        btnAgregar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(49, 887)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtTelefono.Location = New Point(223, 548)
        txtTelefono.Multiline = True
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(216, 45)
        txtTelefono.TabIndex = 28
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtCorreo.Location = New Point(224, 481)
        txtCorreo.Multiline = True
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(215, 45)
        txtCorreo.TabIndex = 27
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtNombre.Location = New Point(224, 416)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(215, 45)
        txtNombre.TabIndex = 26
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(737, 167)
        txtBuscar.Multiline = True
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(691, 45)
        txtBuscar.TabIndex = 25
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(223, 357)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(216, 45)
        txtID.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label6.Location = New Point(49, 558)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 35)
        Label6.TabIndex = 23
        Label6.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label4.Location = New Point(49, 491)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 35)
        Label4.TabIndex = 21
        Label4.Text = "Correo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label3.Location = New Point(49, 426)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 35)
        Label3.TabIndex = 20
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label2.Location = New Point(49, 360)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 35)
        Label2.TabIndex = 19
        Label2.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(609, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 35)
        Label1.TabIndex = 18
        Label1.Text = "Buscar"
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedores.Location = New Point(609, 218)
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.RowHeadersWidth = 51
        dgvProveedores.Size = New Size(1087, 559)
        dgvProveedores.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 34
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PROVEEDORES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1747, 1043)
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
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "PROVEEDORES"
        StartPosition = FormStartPosition.Manual
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
    Friend WithEvents Button1 As Button
End Class
