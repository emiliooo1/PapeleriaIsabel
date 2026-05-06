<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autorizacion
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(194, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 42)
        Label3.TabIndex = 14
        Label3.Text = "ADMINISTRADOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(84, 269)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 38)
        Label2.TabIndex = 12
        Label2.Text = "Contraseña:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 38)
        Label1.TabIndex = 11
        Label1.Text = "Usuario:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(53, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(571, 533)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("MS Reference Sans Serif", 18F)
        txtUsuario.Location = New Point(145, 186)
        txtUsuario.Multiline = True
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(382, 57)
        txtUsuario.TabIndex = 9
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Font = New Font("MS Reference Sans Serif", 18F)
        txtContrasena.Location = New Point(145, 328)
        txtContrasena.Multiline = True
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(382, 57)
        txtContrasena.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PowderBlue
        Button2.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(72, 414)
        Button2.Name = "Button2"
        Button2.Size = New Size(526, 66)
        Button2.TabIndex = 13
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(72, 486)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Autorizacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(669, 573)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtUsuario)
        Controls.Add(txtContrasena)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Autorizacion"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Autorizacion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
