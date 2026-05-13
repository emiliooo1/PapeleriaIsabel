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
        dgvReportes = New DataGridView()
        PictureBox1 = New PictureBox()
        lblTotal = New Label()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        btnBuscar = New PictureBox()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnBuscar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpInicio
        ' 
        dtpInicio.Font = New Font("MS Reference Sans Serif", 19.8000011F)
        dtpInicio.Format = DateTimePickerFormat.Short
        dtpInicio.Location = New Point(615, 123)
        dtpInicio.Name = "dtpInicio"
        dtpInicio.Size = New Size(228, 48)
        dtpInicio.TabIndex = 0
        ' 
        ' dtpFin
        ' 
        dtpFin.CalendarFont = New Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFin.Font = New Font("MS Reference Sans Serif", 19.8000011F)
        dtpFin.Format = DateTimePickerFormat.Short
        dtpFin.Location = New Point(957, 123)
        dtpFin.Name = "dtpFin"
        dtpFin.Size = New Size(229, 48)
        dtpFin.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold)
        Label1.Location = New Point(456, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 42)
        Label1.TabIndex = 2
        Label1.Text = "Fecha:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold)
        Label2.Location = New Point(871, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 42)
        Label2.TabIndex = 3
        Label2.Text = "al"
        ' 
        ' dgvReportes
        ' 
        dgvReportes.BackgroundColor = Color.White
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Location = New Point(58, 224)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.RowHeadersWidth = 51
        dgvReportes.Size = New Size(1625, 615)
        dgvReportes.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.regresar
        PictureBox1.Location = New Point(49, 875)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.White
        lblTotal.Font = New Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(680, 887)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(321, 74)
        lblTotal.TabIndex = 7
        lblTotal.Text = "TOTAL: $"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(21, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 976)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1595, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(120, 131)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.Location = New Point(1213, 69)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(119, 122)
        btnBuscar.SizeMode = PictureBoxSizeMode.StretchImage
        btnBuscar.TabIndex = 15
        btnBuscar.TabStop = False
        ' 
        ' REPORTES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(btnBuscar)
        Controls.Add(PictureBox2)
        Controls.Add(lblTotal)
        Controls.Add(PictureBox1)
        Controls.Add(dgvReportes)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpFin)
        Controls.Add(dtpInicio)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "REPORTES"
        StartPosition = FormStartPosition.Manual
        Text = "REPORTES"
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnBuscar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBuscar As PictureBox
End Class
