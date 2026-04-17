<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Button1 = New Button()
        btnEliminar = New PictureBox()
        btnEditar = New PictureBox()
        btnAgregar = New PictureBox()
        cmbTipo = New ComboBox()
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgvUsuarios = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(btnEliminar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 20
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Image = My.Resources.Resources.borrar
        btnEliminar.Location = New Point(361, 64)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(93, 95)
        btnEliminar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminar.TabIndex = 23
        btnEliminar.TabStop = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = My.Resources.Resources.editar
        btnEditar.Location = New Point(202, 64)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(93, 95)
        btnEditar.SizeMode = PictureBoxSizeMode.StretchImage
        btnEditar.TabIndex = 22
        btnEditar.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.Location = New Point(60, 64)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(93, 95)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 21
        btnAgregar.TabStop = False
        ' 
        ' cmbTipo
        ' 
        cmbTipo.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTipo.FormattingEnabled = True
        cmbTipo.Location = New Point(264, 462)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(219, 42)
        cmbTipo.TabIndex = 31
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(264, 321)
        txtUsuario.Multiline = True
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(219, 45)
        txtUsuario.TabIndex = 29
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Font = New Font("MS Reference Sans Serif", 16.2F)
        txtContrasena.Location = New Point(264, 390)
        txtContrasena.Multiline = True
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(219, 43)
        txtContrasena.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label5.Location = New Point(60, 467)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 35)
        Label5.TabIndex = 27
        Label5.Text = "Tipo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label3.Location = New Point(59, 390)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 35)
        Label3.TabIndex = 25
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label2.Location = New Point(64, 321)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 35)
        Label2.TabIndex = 24
        Label2.Text = "Usuario"
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.BackgroundColor = Color.WhiteSmoke
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(600, 229)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.RowHeadersWidth = 51
        dgvUsuarios.Size = New Size(1087, 559)
        dgvUsuarios.TabIndex = 32
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(64, 892)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1747, 1043)
        Controls.Add(PictureBox1)
        Controls.Add(dgvUsuarios)
        Controls.Add(cmbTipo)
        Controls.Add(txtUsuario)
        Controls.Add(txtContrasena)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Controls.Add(Button1)
        MinimizeBox = False
        Name = "Usuarios"
        ShowIcon = False
        StartPosition = FormStartPosition.Manual
        Text = "Usuarios"
        CType(btnEliminar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEditar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnEditar As PictureBox
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
