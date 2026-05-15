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
        lblTotal = New Label()
        btnFinalizar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        btnEliminarProducto = New PictureBox()
        Button1 = New Button()
        btnAgregar = New PictureBox()
        Label5 = New Label()
        CType(dgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEliminarProducto, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetalle
        ' 
        dgvDetalle.BackgroundColor = Color.White
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle.Location = New Point(49, 179)
        dgvDetalle.Name = "dgvDetalle"
        dgvDetalle.ReadOnly = True
        dgvDetalle.RowHeadersWidth = 51
        dgvDetalle.Size = New Size(1625, 615)
        dgvDetalle.TabIndex = 0
        ' 
        ' cmbProducto
        ' 
        cmbProducto.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbProducto.FormattingEnabled = True
        cmbProducto.Location = New Point(233, 48)
        cmbProducto.Name = "cmbProducto"
        cmbProducto.Size = New Size(182, 42)
        cmbProducto.TabIndex = 1
        ' 
        ' numCantidad
        ' 
        numCantidad.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numCantidad.Location = New Point(233, 113)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(182, 40)
        numCantidad.TabIndex = 2
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.White
        lblTotal.Font = New Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(686, 855)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(71, 74)
        lblTotal.TabIndex = 4
        lblTotal.Text = "$"
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.BackColor = Color.FromArgb(CByte(1), CByte(61), CByte(90))
        btnFinalizar.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFinalizar.ForeColor = Color.White
        btnFinalizar.Location = New Point(1435, 855)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(239, 87)
        btnFinalizar.TabIndex = 5
        btnFinalizar.Text = "FINALIZAR"
        btnFinalizar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label2.Location = New Point(59, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 35)
        Label2.TabIndex = 7
        Label2.Text = "Producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label3.Location = New Point(59, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 35)
        Label3.TabIndex = 8
        Label3.Text = "Cantidad:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.regresar
        PictureBox1.Location = New Point(49, 882)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(98, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.BackColor = Color.White
        btnEliminarProducto.Image = My.Resources.Resources.eliminarfondo
        btnEliminarProducto.Location = New Point(657, 48)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(125, 127)
        btnEliminarProducto.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminarProducto.TabIndex = 17
        btnEliminarProducto.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 18
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.White
        btnAgregar.Image = My.Resources.Resources.botonagregarfondo
        btnAgregar.Location = New Point(512, 48)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(125, 127)
        btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        btnAgregar.TabIndex = 19
        btnAgregar.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Microsoft YaHei", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(1), CByte(61), CByte(90))
        Label5.Location = New Point(1454, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 62)
        Label5.TabIndex = 44
        Label5.Text = "VENTAS"
        ' 
        ' VENTAS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(Label5)
        Controls.Add(btnAgregar)
        Controls.Add(btnEliminarProducto)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnFinalizar)
        Controls.Add(lblTotal)
        Controls.Add(numCantidad)
        Controls.Add(cmbProducto)
        Controls.Add(dgvDetalle)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "VENTAS"
        StartPosition = FormStartPosition.Manual
        Text = "VENTAS"
        CType(dgvDetalle, ComponentModel.ISupportInitialize).EndInit()
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEliminarProducto, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAgregar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminarProducto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents Label5 As Label
End Class
