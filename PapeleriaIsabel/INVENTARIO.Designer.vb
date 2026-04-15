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
        btnAgregarStock = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtBuscar = New TextBox()
        btnQuitarStock = New Button()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInventario, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProducto
        ' 
        cmbProducto.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbProducto.FormattingEnabled = True
        cmbProducto.Location = New Point(150, 25)
        cmbProducto.Name = "cmbProducto"
        cmbProducto.Size = New Size(157, 30)
        cmbProducto.TabIndex = 0
        ' 
        ' numCantidad
        ' 
        numCantidad.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numCantidad.Location = New Point(150, 80)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(157, 28)
        numCantidad.TabIndex = 1
        ' 
        ' dgvInventario
        ' 
        dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventario.Location = New Point(30, 161)
        dgvInventario.Name = "dgvInventario"
        dgvInventario.RowHeadersWidth = 51
        dgvInventario.Size = New Size(741, 221)
        dgvInventario.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download__1_
        PictureBox2.Location = New Point(30, 388)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label1.Location = New Point(32, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 22)
        Label1.TabIndex = 5
        Label1.Text = "Producto:"
        ' 
        ' btnAgregarStock
        ' 
        btnAgregarStock.BackColor = Color.PaleTurquoise
        btnAgregarStock.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregarStock.Location = New Point(360, 46)
        btnAgregarStock.Name = "btnAgregarStock"
        btnAgregarStock.Size = New Size(143, 46)
        btnAgregarStock.TabIndex = 6
        btnAgregarStock.Text = "AGREGAR"
        btnAgregarStock.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label2.Location = New Point(32, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 22)
        Label2.TabIndex = 7
        Label2.Text = "Cantidad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label3.Location = New Point(32, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 22)
        Label3.TabIndex = 8
        Label3.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(123, 130)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(578, 28)
        txtBuscar.TabIndex = 9
        ' 
        ' btnQuitarStock
        ' 
        btnQuitarStock.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnQuitarStock.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnQuitarStock.Location = New Point(540, 46)
        btnQuitarStock.Name = "btnQuitarStock"
        btnQuitarStock.Size = New Size(143, 46)
        btnQuitarStock.TabIndex = 10
        btnQuitarStock.Text = "ELIMINAR"
        btnQuitarStock.UseVisualStyleBackColor = False
        ' 
        ' INVENTARIO
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btnQuitarStock)
        Controls.Add(txtBuscar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnAgregarStock)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(dgvInventario)
        Controls.Add(numCantidad)
        Controls.Add(cmbProducto)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "INVENTARIO"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INVENTARIO"
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInventario, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarStock As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnQuitarStock As Button
End Class
