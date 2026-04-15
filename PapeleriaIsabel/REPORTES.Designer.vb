<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORTES))
        dtpInicio = New DateTimePicker()
        dtpFin = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        btnBuscar = New Button()
        dgvReportes = New DataGridView()
        PictureBox1 = New PictureBox()
        lblTotal = New Label()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpInicio
        ' 
        dtpInicio.Font = New Font("MS Reference Sans Serif", 10.2F)
        dtpInicio.Format = DateTimePickerFormat.Short
        dtpInicio.Location = New Point(173, 53)
        dtpInicio.Name = "dtpInicio"
        dtpInicio.Size = New Size(228, 28)
        dtpInicio.TabIndex = 0
        ' 
        ' dtpFin
        ' 
        dtpFin.Font = New Font("MS Reference Sans Serif", 10.2F)
        dtpFin.Format = DateTimePickerFormat.Short
        dtpFin.Location = New Point(448, 53)
        dtpFin.Name = "dtpFin"
        dtpFin.Size = New Size(217, 28)
        dtpFin.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label1.Location = New Point(85, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 22)
        Label1.TabIndex = 2
        Label1.Text = "Fecha:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 10.2F)
        Label2.Location = New Point(407, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 22)
        Label2.TabIndex = 3
        Label2.Text = "al"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.PaleTurquoise
        btnBuscar.Font = New Font("MS Reference Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(343, 104)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(118, 51)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvReportes
        ' 
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Location = New Point(25, 161)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.RowHeadersWidth = 51
        dgvReportes.Size = New Size(756, 219)
        dgvReportes.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(25, 386)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(285, 395)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(147, 35)
        lblTotal.TabIndex = 7
        lblTotal.Text = "TOTAL: $"
        ' 
        ' REPORTES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(PictureBox1)
        Controls.Add(dgvReportes)
        Controls.Add(btnBuscar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpFin)
        Controls.Add(dtpInicio)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "REPORTES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REPORTES"
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotal As Label
End Class
