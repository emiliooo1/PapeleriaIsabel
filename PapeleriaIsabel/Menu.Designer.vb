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
        Button1 = New Button()
        PictureBox7 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        PRODUCTOSToolStripMenuItem = New ToolStripMenuItem()
        PROOVEDORESToolStripMenuItem = New ToolStripMenuItem()
        VENTASToolStripMenuItem = New ToolStripMenuItem()
        INVENTARIOToolStripMenuItem = New ToolStripMenuItem()
        REPORTESToolStripMenuItem = New ToolStripMenuItem()
        CANCELARVENTAToolStripMenuItem = New ToolStripMenuItem()
        USUARIOSToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(41, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(1686, 938)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = My.Resources.Resources.Screenshot_2026_03_21_143151_removebg_preview
        PictureBox7.Location = New Point(1302, 555)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(301, 311)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.WhiteSmoke
        PictureBox4.Image = My.Resources.Resources._57385c35_2863_4074_8e21_14815323dc88_removebg_preview
        PictureBox4.Location = New Point(716, 555)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(301, 311)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.WhiteSmoke
        PictureBox3.Image = My.Resources.Resources._840f21a1_504b_4a0e_af6c_785ea1baedf3_removebg_preview
        PictureBox3.Location = New Point(1302, 111)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(301, 311)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ButtonFace
        MenuStrip1.Font = New Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PRODUCTOSToolStripMenuItem, PROOVEDORESToolStripMenuItem, VENTASToolStripMenuItem, INVENTARIOToolStripMenuItem, REPORTESToolStripMenuItem, CANCELARVENTAToolStripMenuItem, USUARIOSToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(1747, 36)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PRODUCTOSToolStripMenuItem
        ' 
        PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        PRODUCTOSToolStripMenuItem.Size = New Size(154, 30)
        PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        ' 
        ' PROOVEDORESToolStripMenuItem
        ' 
        PROOVEDORESToolStripMenuItem.Name = "PROOVEDORESToolStripMenuItem"
        PROOVEDORESToolStripMenuItem.Size = New Size(180, 30)
        PROOVEDORESToolStripMenuItem.Text = "PROVEEDORES"
        ' 
        ' VENTASToolStripMenuItem
        ' 
        VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        VENTASToolStripMenuItem.Size = New Size(108, 30)
        VENTASToolStripMenuItem.Text = "VENTAS"
        ' 
        ' INVENTARIOToolStripMenuItem
        ' 
        INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        INVENTARIOToolStripMenuItem.Size = New Size(155, 30)
        INVENTARIOToolStripMenuItem.Text = "INVENTARIO"
        ' 
        ' REPORTESToolStripMenuItem
        ' 
        REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        REPORTESToolStripMenuItem.Size = New Size(134, 30)
        REPORTESToolStripMenuItem.Text = "REPORTES"
        ' 
        ' CANCELARVENTAToolStripMenuItem
        ' 
        CANCELARVENTAToolStripMenuItem.Name = "CANCELARVENTAToolStripMenuItem"
        CANCELARVENTAToolStripMenuItem.Size = New Size(210, 30)
        CANCELARVENTAToolStripMenuItem.Text = "CANCELAR VENTA"
        ' 
        ' USUARIOSToolStripMenuItem
        ' 
        USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        USUARIOSToolStripMenuItem.Size = New Size(136, 30)
        USUARIOSToolStripMenuItem.Text = "USUARIOS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label3.Location = New Point(1406, 425)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 29)
        Label3.TabIndex = 14
        Label3.Text = "VENTAS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label4.Location = New Point(781, 869)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 29)
        Label4.TabIndex = 15
        Label4.Text = "INVENTARIO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label5.Location = New Point(1386, 869)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 29)
        Label5.TabIndex = 16
        Label5.Text = "REPORTES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label2.Location = New Point(768, 425)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 29)
        Label2.TabIndex = 20
        Label2.Text = "PROVEEDORES"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = My.Resources.Resources.b77b9b46_356d_46c2_82a8_939d497abf52_removebg_preview
        PictureBox2.Location = New Point(716, 111)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(301, 311)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Image = My.Resources.Resources._0bca20a1_0cf6_4d93_bb90_5de8019c6549_removebg_preview
        PictureBox1.Location = New Point(185, 111)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 311)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label1.Location = New Point(261, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 29)
        Label1.TabIndex = 21
        Label1.Text = "PRODUCTOS"
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1747, 1043)
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
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimizeBox = False
        Name = "Menu"
        StartPosition = FormStartPosition.Manual
        Text = "MENU"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROOVEDORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CANCELARVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem

End Class
