<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobro
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
        lblTotal = New Label()
        lblCambio = New Label()
        lblRecibido = New Label()
        Button1 = New Button()
        btnCobrar = New Button()
        txtRecibido = New TextBox()
        SuspendLayout()
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.White
        lblTotal.Font = New Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(205, 96)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(256, 42)
        lblTotal.TabIndex = 14
        lblTotal.Text = "TOTAL: $0.00"
        ' 
        ' lblCambio
        ' 
        lblCambio.AutoSize = True
        lblCambio.BackColor = Color.White
        lblCambio.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCambio.Location = New Point(205, 344)
        lblCambio.Name = "lblCambio"
        lblCambio.Size = New Size(240, 38)
        lblCambio.TabIndex = 10
        lblCambio.Text = "COBRO: $0.00"
        ' 
        ' lblRecibido
        ' 
        lblRecibido.AutoSize = True
        lblRecibido.BackColor = Color.White
        lblRecibido.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecibido.Location = New Point(73, 192)
        lblRecibido.Name = "lblRecibido"
        lblRecibido.Size = New Size(186, 38)
        lblRecibido.TabIndex = 9
        lblRecibido.Text = "RECIBIDO:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Enabled = False
        Button1.Location = New Point(49, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(571, 470)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnCobrar
        ' 
        btnCobrar.BackColor = Color.PowderBlue
        btnCobrar.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCobrar.Location = New Point(63, 414)
        btnCobrar.Name = "btnCobrar"
        btnCobrar.Size = New Size(542, 77)
        btnCobrar.TabIndex = 15
        btnCobrar.Text = "COBRAR"
        btnCobrar.UseVisualStyleBackColor = False
        ' 
        ' txtRecibido
        ' 
        txtRecibido.Font = New Font("MS Reference Sans Serif", 18F)
        txtRecibido.Location = New Point(144, 243)
        txtRecibido.Multiline = True
        txtRecibido.Name = "txtRecibido"
        txtRecibido.Size = New Size(382, 57)
        txtRecibido.TabIndex = 16
        ' 
        ' Cobro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(669, 542)
        Controls.Add(txtRecibido)
        Controls.Add(btnCobrar)
        Controls.Add(lblTotal)
        Controls.Add(lblCambio)
        Controls.Add(lblRecibido)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Cobro"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cobro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTotal As Label
    Private lblCambio As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRecibido As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCobrar As Button
    Private WithEvents txtRecibido As TextBox
End Class
