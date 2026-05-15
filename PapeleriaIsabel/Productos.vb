Imports MySql.Data.MySqlClient
Public Class Productos
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")


    Sub cargarProductos()
        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT p.idProd, p.nombre, pr.nombre AS proveedor, p.precio, p.descripcion
        FROM productos p
        INNER JOIN proveedores pr ON p.idProv = pr.idProv
        WHERE p.activo = 1", conexion)

        da.Fill(dt)
        dgvProductos.DataSource = dt
    End Sub


    Sub cargarProveedores()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT idProv, nombre FROM proveedores WHERE activo=1", conexion)

        da.Fill(dt)

        cmbProveedor.DataSource = dt
        cmbProveedor.DisplayMember = "nombre"
        cmbProveedor.ValueMember = "idProv"
    End Sub


    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        cargarProveedores()

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvProductos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvProductos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtID.Text = "" Or txtNombre.Text = "" Then
            MessageBox.Show("Completa los campos")
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim cmd As New MySqlCommand("
            INSERT INTO productos(idProd, nombre, descripcion, precio, idProv)
            VALUES(@id,@n,@d,@p,@prov)", conexion)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@n", txtNombre.Text)
            cmd.Parameters.AddWithValue("@d", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@p", txtPrecio.Text)
            cmd.Parameters.AddWithValue("@prov", cmbProveedor.SelectedValue)

            cmd.ExecuteNonQuery()

            Dim cmdInv As New MySqlCommand("INSERT INTO inventario(idProd, stock) VALUES(@id, 0)", conexion)
            cmdInv.Parameters.AddWithValue("@id", txtID.Text)
            cmdInv.ExecuteNonQuery()

            conexion.Close()

            MessageBox.Show("Producto agregado")

            cargarProductos()

            txtID.Clear()
            txtNombre.Clear()
            txtDescripcion.Clear()
            txtPrecio.Clear()

            cmbProveedor.SelectedIndex = 0

            txtID.Focus()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try

    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick

        If dgvProductos.CurrentRow Is Nothing Then Exit Sub

        txtID.Text = dgvProductos.CurrentRow.Cells("idProd").Value.ToString()
        txtNombre.Text = dgvProductos.CurrentRow.Cells("nombre").Value.ToString()
        txtDescripcion.Text = dgvProductos.CurrentRow.Cells("descripcion").Value.ToString()
        txtPrecio.Text = dgvProductos.CurrentRow.Cells("precio").Value.ToString()
        cmbProveedor.Text = dgvProductos.CurrentRow.Cells("proveedor").Value.ToString()

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If txtID.Text = "" Then Exit Sub

        Try
            conexion.Open()

            Dim cmd As New MySqlCommand("
            UPDATE productos 
            SET nombre=@n, descripcion=@d, precio=@p, idProv=@prov
            WHERE idProd=@id", conexion)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@n", txtNombre.Text)
            cmd.Parameters.AddWithValue("@d", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@p", txtPrecio.Text)
            cmd.Parameters.AddWithValue("@prov", cmbProveedor.SelectedValue)

            cmd.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Producto actualizado")
            cargarProductos()

            txtID.Clear()
            txtNombre.Clear()
            txtDescripcion.Clear()
            txtPrecio.Clear()
            cmbProveedor.SelectedIndex = 0

            txtID.Focus()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtID.Text = "" Then Exit Sub

        If MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Try
                conexion.Open

                Dim cmd As New MySqlCommand("UPDATE productos SET activo=0 WHERE idProd=@id", conexion)
                cmd.Parameters.AddWithValue("@id", txtID.Text)

                cmd.ExecuteNonQuery
                conexion.Close

                MessageBox.Show("Producto eliminado")
                cargarProductos

                txtID.Clear
                txtNombre.Clear
                txtDescripcion.Clear
                txtPrecio.Clear

                cmbProveedor.SelectedIndex = 0

                txtID.Focus

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                conexion.Close
            End Try

        End If
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT p.idProd, p.nombre, pr.nombre AS proveedor, p.precio, p.descripcion
        FROM productos p
        INNER JOIN proveedores pr ON p.idProv = pr.idProv
        WHERE p.nombre LIKE @busqueda", conexion)

        da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" & txtBuscar.Text & "%")

        da.Fill(dt)
        dgvProductos.DataSource = dt

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtID.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        cmbProveedor.SelectedIndex = 0
        txtID.Focus()
    End Sub
End Class