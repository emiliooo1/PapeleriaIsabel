Imports MySql.Data.MySqlClient
Public Class Autorizacion

    Public autorizado As Boolean = False

    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        autorizado = False
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtUsuario.Text = "" Or txtContrasena.Text = "" Then
            MessageBox.Show("Ingrese usuario y contraseña")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("
        SELECT COUNT(*) 
        FROM usuarios 
        WHERE usuario=@user 
        AND contrasena=@pass 
        AND tipo='Administrador'", conexion)

        cmd.Parameters.AddWithValue("@user", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@pass", txtContrasena.Text)

        conexion.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conexion.Close()

        If count > 0 Then

            autorizado = True
            Me.Close()

        Else
            MessageBox.Show("Credenciales incorrectas")
            txtUsuario.Clear()
            txtContrasena.Clear()

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button2
    End Sub
End Class