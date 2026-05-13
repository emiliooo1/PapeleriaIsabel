<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        MenuStrip1 = New MenuStrip()
        PRODUCTOSToolStripMenuItem = New ToolStripMenuItem()
        PROOVEDORESToolStripMenuItem = New ToolStripMenuItem()
        VENTASToolStripMenuItem = New ToolStripMenuItem()
        INVENTARIOToolStripMenuItem = New ToolStripMenuItem()
        REPORTESToolStripMenuItem = New ToolStripMenuItem()
        CANCELARVENTAToolStripMenuItem = New ToolStripMenuItem()
        USUARIOSToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        Label5 = New Label()
        PictureBox7 = New PictureBox()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        PictureBox5 = New PictureBox()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(1), CByte(61), CByte(90))
        MenuStrip1.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PRODUCTOSToolStripMenuItem, PROOVEDORESToolStripMenuItem, VENTASToolStripMenuItem, INVENTARIOToolStripMenuItem, REPORTESToolStripMenuItem, CANCELARVENTAToolStripMenuItem, USUARIOSToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(1747, 45)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PRODUCTOSToolStripMenuItem
        ' 
        PRODUCTOSToolStripMenuItem.Font = New Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PRODUCTOSToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        PRODUCTOSToolStripMenuItem.Size = New Size(182, 39)
        PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        ' 
        ' PROOVEDORESToolStripMenuItem
        ' 
        PROOVEDORESToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        PROOVEDORESToolStripMenuItem.Name = "PROOVEDORESToolStripMenuItem"
        PROOVEDORESToolStripMenuItem.Size = New Size(253, 39)
        PROOVEDORESToolStripMenuItem.Text = "PROVEEDORES"
        ' 
        ' VENTASToolStripMenuItem
        ' 
        VENTASToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        VENTASToolStripMenuItem.Size = New Size(148, 39)
        VENTASToolStripMenuItem.Text = "VENTAS"
        ' 
        ' INVENTARIOToolStripMenuItem
        ' 
        INVENTARIOToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        INVENTARIOToolStripMenuItem.Size = New Size(221, 39)
        INVENTARIOToolStripMenuItem.Text = "INVENTARIO"
        ' 
        ' REPORTESToolStripMenuItem
        ' 
        REPORTESToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        REPORTESToolStripMenuItem.Size = New Size(186, 39)
        REPORTESToolStripMenuItem.Text = "REPORTES"
        ' 
        ' CANCELARVENTAToolStripMenuItem
        ' 
        CANCELARVENTAToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        CANCELARVENTAToolStripMenuItem.Name = "CANCELARVENTAToolStripMenuItem"
        CANCELARVENTAToolStripMenuItem.Size = New Size(299, 39)
        CANCELARVENTAToolStripMenuItem.Text = "CANCELAR VENTA"
        ' 
        ' USUARIOSToolStripMenuItem
        ' 
        USUARIOSToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        USUARIOSToolStripMenuItem.Size = New Size(190, 39)
        USUARIOSToolStripMenuItem.Text = "USUARIOS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(21, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(1705, 924)
        Button1.TabIndex = 36
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label5.Location = New Point(1357, 869)
        Label5.Name = "Label5"
        Label5.Size = New Size(197, 45)
        Label5.TabIndex = 16
        Label5.Text = "REPORTES"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = My.Resources.Resources.reportes
        PictureBox7.Location = New Point(1302, 544)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(295, 322)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label3.Location = New Point(1378, 425)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 45)
        Label3.TabIndex = 14
        Label3.Text = "VENTAS"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.WhiteSmoke
        PictureBox3.Image = My.Resources.Resources.ventas
        PictureBox3.Location = New Point(1302, 100)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(295, 322)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label6.Location = New Point(207, 869)
        Label6.Name = "Label6"
        Label6.Size = New Size(338, 45)
        Label6.TabIndex = 23
        Label6.Text = "CANCELAR VENTA"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.WhiteSmoke
        PictureBox5.Image = My.Resources.Resources.cancelarV
        PictureBox5.Location = New Point(207, 544)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(295, 322)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 22
        PictureBox5.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label4.Location = New Point(784, 869)
        Label4.Name = "Label4"
        Label4.Size = New Size(242, 45)
        Label4.TabIndex = 15
        Label4.Text = "INVENTARIO"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.WhiteSmoke
        PictureBox4.Image = My.Resources.Resources.inventario
        PictureBox4.Location = New Point(741, 544)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(295, 322)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label2.Location = New Point(773, 425)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 45)
        Label2.TabIndex = 20
        Label2.Text = "PROVEEDORES"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold)
        Label1.Location = New Point(240, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 45)
        Label1.TabIndex = 21
        Label1.Text = "PRODUCTOS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Image = My.Resources.Resources.productos
        PictureBox1.Location = New Point(207, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(295, 322)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = My.Resources.Resources.proveedores
        PictureBox2.Location = New Point(741, 100)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(295, 322)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(1747, 1043)
        Controls.Add(Label6)
        Controls.Add(PictureBox5)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(MenuStrip1)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimizeBox = False
        Name = "Menu"
        StartPosition = FormStartPosition.Manual
        Text = "MENU"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROOVEDORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CANCELARVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
