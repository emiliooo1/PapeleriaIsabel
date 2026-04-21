Imports MySql.Data.MySqlClient
Public Class Login
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cmd As New MySqlCommand("
    SELECT idUsuario, tipo 
    FROM usuarios 
    WHERE usuario=@user AND contrasena=@pass", conexion)

        cmd.Parameters.AddWithValue("@user", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@pass", txtContrasena.Text)

        conexion.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then

            Dim idUsuario As Integer = dr("idUsuario")
            Dim tipo As String = dr("tipo").ToString()

            dr.Close()

            'ACTUALIZAR LOGIN
            Dim cmdUpdate As New MySqlCommand("
        UPDATE usuarios 
        SET ultimo_login = NOW() 
        WHERE idUsuario=@id", conexion)

            cmdUpdate.Parameters.AddWithValue("@id", idUsuario)
            cmdUpdate.ExecuteNonQuery()

            conexion.Close()

            'CONTROL DE ACCESO
            If tipo = "Administrador" Then

                Menu.Show()

            ElseIf tipo = "Vendedor" Then

                VENTAS.tipoUsuario = tipo
                VENTAS.Show()

            End If

            Me.Hide()

        Else
            conexion.Close()
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If

    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then

            If MessageBox.Show("¿Salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
            Else
                Application.Exit()
            End If

        End If

    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button2
    End Sub
End Class
