Imports MySql.Data.MySqlClient

Public Class INVENTARIO
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")



    Sub cargarInventario()

        Try
            Dim dt As New DataTable

            Dim da As New MySqlDataAdapter("
            SELECT i.idInv, p.idProd, p.nombre, i.stock
            FROM inventario i
            INNER JOIN productos p ON i.idProd = p.idProd", conexion)

            da.Fill(dt)
            dgvInventario.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub cargarProductos()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT idProd, nombre FROM productos", conexion)

        da.Fill(dt)

        cmbProducto.DataSource = dt
        cmbProducto.DisplayMember = "nombre"
        cmbProducto.ValueMember = "idProd"

    End Sub


    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarInventario()
        cargarProductos()

        numCantidad.Value = 1

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvInventario.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvInventario.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick

        If dgvInventario.CurrentRow Is Nothing Then Exit Sub

        cmbProducto.SelectedValue = dgvInventario.CurrentRow.Cells("idProd").Value

    End Sub


    Private Sub btnAgregarStock_Click(sender As Object, e As EventArgs) Handles btnAgregarStock.Click

        If numCantidad.Value <= 0 Then
            MessageBox.Show("Cantidad inválida")
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim cmd As New MySqlCommand("
            UPDATE inventario 
            SET stock = stock + @cant 
            WHERE idProd=@id", conexion)

            cmd.Parameters.AddWithValue("@cant", numCantidad.Value)
            cmd.Parameters.AddWithValue("@id", cmbProducto.SelectedValue)

            Dim filas As Integer = cmd.ExecuteNonQuery()

            conexion.Close()

            If filas = 0 Then
                MessageBox.Show("No existe en inventario")
            Else
                MessageBox.Show("Stock agregado")
            End If

            cargarInventario()
            numCantidad.Value = 1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexion.Close()
        End Try

    End Sub


    Private Sub btnQuitarStock_Click(sender As Object, e As EventArgs) Handles btnQuitarStock.Click

        If numCantidad.Value <= 0 Then
            MessageBox.Show("Cantidad inválida")
            Exit Sub
        End If

        Try
            conexion.Open()


            Dim cmdCheck As New MySqlCommand("SELECT stock FROM inventario WHERE idProd=@id", conexion)
            cmdCheck.Parameters.AddWithValue("@id", cmbProducto.SelectedValue)

            Dim stockActual As Object = cmdCheck.ExecuteScalar()

            If IsDBNull(stockActual) Then
                MessageBox.Show("No existe en inventario")
                conexion.Close()
                Exit Sub
            End If

            If numCantidad.Value > stockActual Then
                MessageBox.Show("No hay suficiente stock")
                conexion.Close()
                Exit Sub
            End If

            ' Quitar stock
            Dim cmd As New MySqlCommand("
            UPDATE inventario 
            SET stock = stock - @cant 
            WHERE idProd=@id", conexion)

            cmd.Parameters.AddWithValue("@cant", numCantidad.Value)
            cmd.Parameters.AddWithValue("@id", cmbProducto.SelectedValue)

            cmd.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Stock actualizado")

            cargarInventario()
            numCantidad.Value = 1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexion.Close()
        End Try

    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT i.idInv, p.idProd, p.nombre, i.stock
        FROM inventario i
        INNER JOIN productos p ON i.idProd = p.idProd
        WHERE p.nombre LIKE @busqueda", conexion)

        da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" & txtBuscar.Text & "%")

        da.Fill(dt)
        dgvInventario.DataSource = dt

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Menu.Show()

    End Sub


End Class