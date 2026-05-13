<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelarVenta
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
        txtIdVenta = New TextBox()
        Label3 = New Label()
        dgvDetalle = New DataGridView()
        PictureBox2 = New PictureBox()
        btnCancelarVenta = New PictureBox()
        lblTotal = New Label()
        CType(dgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCancelarVenta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 35
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtIdVenta
        ' 
        txtIdVenta.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdVenta.Location = New Point(220, 133)
        txtIdVenta.Multiline = True
        txtIdVenta.Name = "txtIdVenta"
        txtIdVenta.Size = New Size(997, 47)
        txtIdVenta.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(85, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 35)
        Label3.TabIndex = 36
        Label3.Text = "Buscar:"
        ' 
        ' dgvDetalle
        ' 
        dgvDetalle.BackgroundColor = Color.White
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle.Location = New Point(61, 214)
        dgvDetalle.Name = "dgvDetalle"
        dgvDetalle.ReadOnly = True
        dgvDetalle.RowHeadersWidth = 51
        dgvDetalle.Size = New Size(1625, 615)
        dgvDetalle.TabIndex = 38
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = My.Resources.Resources.regresar
        PictureBox2.Location = New Point(49, 879)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(98, 103)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' btnCancelarVenta
        ' 
        btnCancelarVenta.Image = My.Resources.Resources.eliminarfondo
        btnCancelarVenta.Location = New Point(1246, 50)
        btnCancelarVenta.Name = "btnCancelarVenta"
        btnCancelarVenta.Size = New Size(140, 148)
        btnCancelarVenta.SizeMode = PictureBoxSizeMode.StretchImage
        btnCancelarVenta.TabIndex = 40
        btnCancelarVenta.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.White
        lblTotal.Font = New Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(684, 879)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(321, 74)
        lblTotal.TabIndex = 41
        lblTotal.Text = "TOTAL: $"
        ' 
        ' CancelarVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(lblTotal)
        Controls.Add(btnCancelarVenta)
        Controls.Add(PictureBox2)
        Controls.Add(dgvDetalle)
        Controls.Add(txtIdVenta)
        Controls.Add(Label3)
        Controls.Add(Button1)
        MinimizeBox = False
        Name = "CancelarVenta"
        ShowIcon = False
        StartPosition = FormStartPosition.Manual
        Text = "CancelarVenta"
        CType(dgvDetalle, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCancelarVenta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelarVenta As PictureBox
    Friend WithEvents lblTotal As Label
End Class
