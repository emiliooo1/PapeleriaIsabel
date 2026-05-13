<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVENTARIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INVENTARIO))
        cmbProducto = New ComboBox()
        numCantidad = New NumericUpDown()
        dgvInventario = New DataGridView()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtBuscar = New TextBox()
        Button1 = New Button()
        btnStock = New PictureBox()
        btnAgregarStock = New PictureBox()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInventario, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnStock, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregarStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProducto
        ' 
        cmbProducto.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbProducto.FormattingEnabled = True
        cmbProducto.Location = New Point(251, 53)
        cmbProducto.Name = "cmbProducto"
        cmbProducto.Size = New Size(212, 42)
        cmbProducto.TabIndex = 0
        ' 
        ' numCantidad
        ' 
        numCantidad.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numCantidad.Location = New Point(251, 120)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(212, 40)
        numCantidad.TabIndex = 1
        ' 
        ' dgvInventario
        ' 
        dgvInventario.BackgroundColor = Color.White
        dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventario.Location = New Point(49, 235)
        dgvInventario.Name = "dgvInventario"
        dgvInventario.RowHeadersWidth = 51
        dgvInventario.Size = New Size(1625, 615)
        dgvInventario.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = My.Resources.Resources.regresar
        PictureBox2.Location = New Point(49, 881)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(96, 101)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label1.Location = New Point(85, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 35)
        Label1.TabIndex = 5
        Label1.Text = "Producto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label2.Location = New Point(85, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 35)
        Label2.TabIndex = 7
        Label2.Text = "Cantidad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(113, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 35)
        Label3.TabIndex = 8
        Label3.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(251, 173)
        txtBuscar.Multiline = True
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(997, 47)
        txtBuscar.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(21, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnStock
        ' 
        btnStock.Image = My.Resources.Resources.eliminarfondo
        btnStock.Location = New Point(655, 45)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(120, 122)
        btnStock.SizeMode = PictureBoxSizeMode.StretchImage
        btnStock.TabIndex = 41
        btnStock.TabStop = False
        ' 
        ' btnAgregarStock
        ' 
        btnAgregarStock.Image = My.Resources.Resources.botonagregarfondo
        btnAgregarStock.Location = New Point(505, 45)
        btnAgregarStock.Name = "btnAgregarStock"
        btnAgregarStock.Size = New Size(120, 122)
        btnAgregarStock.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregarStock.TabIndex = 42
        btnAgregarStock.TabStop = False
        ' 
        ' INVENTARIO
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(btnAgregarStock)
        Controls.Add(btnStock)
        Controls.Add(txtBuscar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(dgvInventario)
        Controls.Add(numCantidad)
        Controls.Add(cmbProducto)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "INVENTARIO"
        StartPosition = FormStartPosition.Manual
        Text = "INVENTARIO"
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInventario, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnStock, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregarStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnStock As PictureBox
    Friend WithEvents btnAgregarStock As PictureBox
End Class
