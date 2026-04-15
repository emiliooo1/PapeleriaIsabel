<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VENTAS))
        dgvDetalle = New DataGridView()
        cmbProducto = New ComboBox()
        numCantidad = New NumericUpDown()
        btnAgregar = New Button()
        lblTotal = New Label()
        btnFinalizar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        btnEliminarProducto = New PictureBox()
        CType(dgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEliminarProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetalle
        ' 
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle.Location = New Point(32, 143)
        dgvDetalle.Name = "dgvDetalle"
        dgvDetalle.RowHeadersWidth = 51
        dgvDetalle.Size = New Size(717, 226)
        dgvDetalle.TabIndex = 0
        ' 
        ' cmbProducto
        ' 
        cmbProducto.FormattingEnabled = True
        cmbProducto.Location = New Point(156, 34)
        cmbProducto.Name = "cmbProducto"
        cmbProducto.Size = New Size(182, 28)
        cmbProducto.TabIndex = 1
        ' 
        ' numCantidad
        ' 
        numCantidad.Location = New Point(156, 92)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(182, 27)
        numCantidad.TabIndex = 2
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.PaleTurquoise
        btnAgregar.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnAgregar.Location = New Point(465, 63)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(116, 41)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(220, 396)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(33, 35)
        lblTotal.TabIndex = 4
        lblTotal.Text = "$"
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.BackColor = Color.PaleTurquoise
        btnFinalizar.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnFinalizar.Location = New Point(490, 390)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(116, 41)
        btnFinalizar.TabIndex = 5
        btnFinalizar.Text = "FINALIZAR"
        btnFinalizar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label2.Location = New Point(55, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 22)
        Label2.TabIndex = 7
        Label2.Text = "Producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label3.Location = New Point(55, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 22)
        Label3.TabIndex = 8
        Label3.Text = "Cantidad:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(12, 377)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.Image = My.Resources.Resources.borrar
        btnEliminarProducto.Location = New Point(637, 39)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(66, 65)
        btnEliminarProducto.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminarProducto.TabIndex = 17
        btnEliminarProducto.TabStop = False
        ' 
        ' VENTAS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminarProducto)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnFinalizar)
        Controls.Add(lblTotal)
        Controls.Add(btnAgregar)
        Controls.Add(numCantidad)
        Controls.Add(cmbProducto)
        Controls.Add(dgvDetalle)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "VENTAS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VENTAS"
        CType(dgvDetalle, ComponentModel.ISupportInitialize).EndInit()
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEliminarProducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminarProducto As PictureBox
End Class
