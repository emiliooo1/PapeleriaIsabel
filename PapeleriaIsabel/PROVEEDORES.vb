Imports MySql.Data.MySqlClient

Public Class PROVEEDORES
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")


    Sub cargarProveedores()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM proveedores", conexion)

        da.Fill(dt)
        dgvProveedores.DataSource = dt

    End Sub


    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProveedores()

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvProveedores.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvProveedores.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtID.Text = "" Or txtNombre.Text = "" Then
            MessageBox.Show("Completa los campos")
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim cmd As New MySqlCommand("
            INSERT INTO proveedores(idProv, nombre, correo, telefono)
            VALUES(@id,@n,@c,@t)", conexion)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@n", txtNombre.Text)
            cmd.Parameters.AddWithValue("@c", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@t", txtTelefono.Text)

            cmd.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Proveedor agregado")
            cargarProveedores()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try

    End Sub


    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick

        If dgvProveedores.CurrentRow Is Nothing Then Exit Sub

        txtID.Text = dgvProveedores.CurrentRow.Cells("idProv").Value.ToString()
        txtNombre.Text = dgvProveedores.CurrentRow.Cells("nombre").Value.ToString()
        txtCorreo.Text = dgvProveedores.CurrentRow.Cells("correo").Value.ToString()
        txtTelefono.Text = dgvProveedores.CurrentRow.Cells("telefono").Value.ToString()

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtID.Text = "" Then Exit Sub

        Try
            conexion.Open()

            Dim cmd As New MySqlCommand("
            UPDATE proveedores 
            SET nombre=@n, correo=@c, telefono=@t
            WHERE idProv=@id", conexion)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@n", txtNombre.Text)
            cmd.Parameters.AddWithValue("@c", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@t", txtTelefono.Text)

            cmd.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Proveedor actualizado")
            cargarProveedores()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtID.Text = "" Then Exit Sub

        If MessageBox.Show("¿Eliminar proveedor?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Try
                conexion.Open()

                Dim cmd As New MySqlCommand("DELETE FROM proveedores WHERE idProv=@id", conexion)
                cmd.Parameters.AddWithValue("@id", txtID.Text)

                cmd.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show("Proveedor eliminado")
                cargarProveedores()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                conexion.Close()
            End Try

        End If

    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT * FROM proveedores
        WHERE nombre LIKE @busqueda", conexion)

        da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" & txtBuscar.Text & "%")

        da.Fill(dt)
        dgvProveedores.DataSource = dt

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Menu.Show()

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