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
        Button1 = New Button()
        CType(dgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEliminarProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetalle
        ' 
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle.Location = New Point(49, 179)
        dgvDetalle.Name = "dgvDetalle"
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
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.PaleTurquoise
        btnAgregar.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(583, 72)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(197, 76)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("MS Reference Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(282, 859)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(44, 46)
        lblTotal.TabIndex = 4
        lblTotal.Text = "$"
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.BackColor = Color.PaleTurquoise
        btnFinalizar.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinalizar.Location = New Point(819, 857)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(212, 71)
        btnFinalizar.TabIndex = 5
        btnFinalizar.Text = "FINALIZAR"
        btnFinalizar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
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
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F)
        Label3.Location = New Point(59, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 35)
        Label3.TabIndex = 8
        Label3.Text = "Cantidad:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(49, 887)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.Image = My.Resources.Resources.borrar
        btnEliminarProducto.Location = New Point(1106, 51)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(102, 102)
        btnEliminarProducto.SizeMode = PictureBoxSizeMode.StretchImage
        btnEliminarProducto.TabIndex = 17
        btnEliminarProducto.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 18
        Button1.UseVisualStyleBackColor = True
        ' 
        ' VENTAS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1747, 1043)
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
    Friend WithEvents Button1 As Button
End Class
