<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(49, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(571, 470)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(80, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 38)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 38)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PowderBlue
        Button2.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(73, 420)
        Button2.Name = "Button2"
        Button2.Size = New Size(526, 66)
        Button2.TabIndex = 6
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("MS Reference Sans Serif", 18F)
        TextBox2.Location = New Point(3, 3)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(382, 57)
        TextBox2.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(137, 329)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(388, 63)
        Panel2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("MS Reference Sans Serif", 18F)
        TextBox1.Location = New Point(3, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(382, 57)
        TextBox1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(137, 203)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(388, 63)
        Panel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(262, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 42)
        Label3.TabIndex = 7
        Label3.Text = "LOGIN"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(669, 542)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label

End Class
