Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim conexion As New MySqlConnection("server=localhost;user=root;password=1234567890;database=papeleria")
    Dim idSeleccionado As Integer = 0

    'CARGAR USUARIOS
    Sub cargarUsuarios()

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT idUsuario, usuario, contrasena,tipo, IFNULL(DATE_FORMAT(ultimo_login, '%d/%m/%Y %H:%i'), 'Nunca') AS ultimo_login
        FROM usuarios
        WHERE activo=1", conexion)

        da.Fill(dt)

        dgvUsuarios.DataSource = dt

        'OPCIONAL: CAMBIAR NOMBRE DE COLUMNA
        If dgvUsuarios.Columns.Contains("ultimo_login") Then
            dgvUsuarios.Columns("ultimo_login").HeaderText = "Último acceso"
        End If

    End Sub

    'INICIO
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarUsuarios()

        cmbTipo.Items.Clear()
        cmbTipo.Items.Add("Administrador")
        cmbTipo.Items.Add("Vendedor")

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvUsuarios.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    'AGREGAR
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtUsuario.Text = "" Or txtContrasena.Text = "" Or cmbTipo.Text = "" Then
            MessageBox.Show("Completa todos los campos")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("
        INSERT INTO usuarios(usuario, contrasena, tipo) 
        VALUES(@user,@pass,@tipo)", conexion)

        cmd.Parameters.AddWithValue("@user", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@pass", txtContrasena.Text)
        cmd.Parameters.AddWithValue("@tipo", cmbTipo.Text)

        conexion.Open
        cmd.ExecuteNonQuery
        conexion.Close

        MessageBox.Show("Usuario agregado")

        cargarUsuarios
        limpiar

    End Sub

    'EDITAR
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If idSeleccionado = 0 Then
            MessageBox.Show("Selecciona un usuario")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("
        UPDATE usuarios 
        SET usuario=@user, contrasena=@pass, tipo=@tipo
        WHERE idUsuario=@id", conexion)

        cmd.Parameters.AddWithValue("@user", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@pass", txtContrasena.Text)
        cmd.Parameters.AddWithValue("@tipo", cmbTipo.Text)
        cmd.Parameters.AddWithValue("@id", idSeleccionado)

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Usuario actualizado")

        cargarUsuarios()
        limpiar()

    End Sub

    'ELIMINAR
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If idSeleccionado = 0 Then
            MessageBox.Show("Selecciona un usuario")
            Exit Sub
        End If

        If MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Dim cmd As New MySqlCommand("UPDATE usuarios SET activo =0 WHERE idusuario=?", conexion)
        cmd.Parameters.AddWithValue("@id", idSeleccionado)

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Usuario eliminado")

        cargarUsuarios()
        limpiar()

    End Sub

    'SELECCIONAR
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)

        idSeleccionado = fila.Cells("idUsuario").Value
        txtUsuario.Text = fila.Cells("usuario").Value.ToString()
        txtContrasena.Text = fila.Cells("contrasena").Value.ToString()
        cmbTipo.Text = fila.Cells("tipo").Value.ToString()

    End Sub

    'LIMPIAR
    Sub limpiar()

        txtUsuario.Clear()
        txtContrasena.Clear()
        cmbTipo.SelectedIndex = -1
        idSeleccionado = 0

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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtUsuario.Clear()
        txtContrasena.Clear()
        cmbTipo.SelectedIndex = 0
    End Sub
End Class