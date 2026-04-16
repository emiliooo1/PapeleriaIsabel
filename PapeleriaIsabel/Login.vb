Imports MySql.Data.MySqlClient
Public Class Login
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conexion.Open()

            Dim consulta As String = "SELECT * FROM usuarios WHERE usuario=@user AND contrasena=@pass"
            Dim cmd As New MySqlCommand(consulta, conexion)

            cmd.Parameters.AddWithValue("@user", TextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.HasRows Then

                Dim menu As New Menu
                Me.Hide()


                menu.Show()


            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
                TextBox1.Clear()
                TextBox2.Clear()


            End If

            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

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

End Class
