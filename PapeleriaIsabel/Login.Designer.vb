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
        txtUsuario = New TextBox()
        Label3 = New Label()
        txtContrasena = New TextBox()
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
        Label1.Font = New Font("Microsoft YaHei", 18F)
        Label1.Location = New Point(80, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 39)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft YaHei", 18F)
        Label2.Location = New Point(80, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 39)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(61), CByte(90))
        Button2.Font = New Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(73, 420)
        Button2.Name = "Button2"
        Button2.Size = New Size(526, 66)
        Button2.TabIndex = 6
        Button2.Text = "LOGIN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(143, 201)
        txtUsuario.Multiline = True
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(382, 57)
        txtUsuario.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(249, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 52)
        Label3.TabIndex = 7
        Label3.Text = "LOGIN"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Font = New Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContrasena.Location = New Point(143, 333)
        txtContrasena.Multiline = True
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(382, 57)
        txtContrasena.TabIndex = 1
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(239))
        ClientSize = New Size(669, 542)
        Controls.Add(txtContrasena)
        Controls.Add(txtUsuario)
        Controls.Add(Label3)
        Controls.Add(Button2)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContrasena As TextBox

End Class
