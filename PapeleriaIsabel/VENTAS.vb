Imports MySql.Data.MySqlClient

Public Class VENTAS

    Public tipoUsuario As String

    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")
    Dim total As Decimal = 0

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If tipoUsuario = "Vendedor" Then
            MessageBox.Show("No tienes permiso para regresar al menú")
            Exit Sub
        End If

        Me.Hide()
        Menu.Show()
    End Sub


    Sub cargarProductos()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT idProd, nombre, precio FROM productos", conexion)

        da.Fill(dt)

        cmbProducto.DataSource = dt
        cmbProducto.DisplayMember = "nombre"
        cmbProducto.ValueMember = "idProd"

    End Sub


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarProductos()

        'BLOQUEAR REGRESO SI ES VENDEDOR
        If tipoUsuario = "Vendedor" Then
            PictureBox1.Visible = False
        End If

        dgvDetalle.Columns.Clear()
        dgvDetalle.Columns.Add("idProd", "ID")
        dgvDetalle.Columns.Add("producto", "Producto")
        dgvDetalle.Columns.Add("precio", "Precio")
        dgvDetalle.Columns.Add("cantidad", "Cantidad")
        dgvDetalle.Columns.Add("subtotal", "Subtotal")

        dgvDetalle.AllowUserToAddRows = False

        lblTotal.Text = "Total: $0"
        numCantidad.Value = 1

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvDetalle.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14)
        dgvDetalle.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold)
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged

        If cmbProducto.SelectedIndex = -1 Then Exit Sub

        Dim fila As DataRowView = cmbProducto.SelectedItem
        lblTotal.Text = "$" & fila("precio")

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If numCantidad.Value <= 0 Then
            MessageBox.Show("Cantidad inválida")
            Exit Sub
        End If

        Dim cantidad As Integer = numCantidad.Value
        Dim precio As Decimal
        Dim idProd As Integer = cmbProducto.SelectedValue

        Dim fila As DataRowView = cmbProducto.SelectedItem
        precio = fila("precio")

        'OBTENER STOCK
        Dim cmdStock As New MySqlCommand("SELECT stock FROM inventario WHERE idProd=@id", conexion)
        cmdStock.Parameters.AddWithValue("@id", idProd)

        conexion.Open()
        Dim stockActual As Integer = Convert.ToInt32(cmdStock.ExecuteScalar())
        conexion.Close()

        'SI YA EXISTE EN EL GRID
        For Each filaGrid As DataGridViewRow In dgvDetalle.Rows

            If filaGrid.Cells(0).Value = idProd Then

                Dim nuevaCantidad As Integer = filaGrid.Cells(3).Value + cantidad

                If nuevaCantidad > stockActual Then
                    MessageBox.Show("No hay suficiente stock")
                    Exit Sub
                End If

                filaGrid.Cells(3).Value = nuevaCantidad
                filaGrid.Cells(4).Value = precio * nuevaCantidad

                calcularTotal()
                numCantidad.Value = 1
                Exit Sub
            End If

        Next

        'VALIDAR NUEVO
        If cantidad > stockActual Then
            MessageBox.Show("No hay suficiente stock")
            Exit Sub
        End If

        dgvDetalle.Rows.Add(idProd, cmbProducto.Text, precio, cantidad, precio * cantidad)

        calcularTotal()
        numCantidad.Value = 1

    End Sub


    Sub calcularTotal()

        total = 0

        For Each fila As DataGridViewRow In dgvDetalle.Rows
            total += Convert.ToDecimal(fila.Cells(4).Value)
        Next

        lblTotal.Text = "Total: $" & total

    End Sub

    'VALIDAR ADMIN
    Function validarAdmin(usuario As String, password As String) As Boolean

        Dim cmd As New MySqlCommand("
    SELECT COUNT(*) 
    FROM usuarios 
    WHERE usuario=@user 
    AND contrasena=@pass 
    AND tipo='Administrador'", conexion)

        cmd.Parameters.AddWithValue("@user", usuario)
        cmd.Parameters.AddWithValue("@pass", password)

        conexion.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conexion.Close()

        Return count > 0

    End Function

    'ELIMINAR CON AUTORIZACIÓN
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        'SI ES VENDEDOR
        If tipoUsuario = "Vendedor" Then

            Dim userAdmin As String = InputBox("Usuario administrador:")
            If userAdmin = "" Then Exit Sub

            Dim passAdmin As String = InputBox("Contraseña administrador:")
            If passAdmin = "" Then Exit Sub

            'VALIDACIÓN
            If validarAdmin(userAdmin, passAdmin) = False Then
                MessageBox.Show("Acceso denegado")
                Exit Sub
            End If

        End If

        If dgvDetalle.Rows.Count = 0 Then
            total = 0
            lblTotal.Text = "Total: $0"
        End If

        dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow)
        calcularTotal()

    End Sub

    'FINALIZAR VENTA
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If dgvDetalle.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta")
            Exit Sub
        End If

        Dim recibidoStr As String = InputBox("Total: $" & total & vbCrLf & "Ingrese dinero:")

        If recibidoStr = "" Then Exit Sub

        Dim recibido As Decimal

        If Not Decimal.TryParse(recibidoStr, recibido) Then
            MessageBox.Show("Cantidad inválida")
            Exit Sub
        End If

        If recibido < total Then
            MessageBox.Show("Dinero insuficiente")
            Exit Sub
        End If

        Dim cambio As Decimal = recibido - total
        MessageBox.Show("Cambio: $" & cambio)

        guardarVenta()

    End Sub


    Sub guardarVenta()

        Try
            conexion.Open()

            Dim cmdVenta As New MySqlCommand("INSERT INTO ventas(total, idUsuario) VALUES(@t,1)", conexion)
            cmdVenta.Parameters.AddWithValue("@t", total)
            cmdVenta.ExecuteNonQuery()

            Dim idVenta As Integer = cmdVenta.LastInsertedId

            For Each fila As DataGridViewRow In dgvDetalle.Rows

                If fila.IsNewRow Then Continue For

                Dim cmdDetalle As New MySqlCommand("
                INSERT INTO detalle_ventas(idVenta,idProd,precioUnitario,cantidad,subtotal)
                VALUES(@v,@p,@pre,@cant,@sub)", conexion)

                cmdDetalle.Parameters.AddWithValue("@v", idVenta)
                cmdDetalle.Parameters.AddWithValue("@p", fila.Cells(0).Value)
                cmdDetalle.Parameters.AddWithValue("@pre", fila.Cells(2).Value)
                cmdDetalle.Parameters.AddWithValue("@cant", fila.Cells(3).Value)
                cmdDetalle.Parameters.AddWithValue("@sub", fila.Cells(4).Value)

                cmdDetalle.ExecuteNonQuery()

                Dim cmdInv As New MySqlCommand("
                UPDATE inventario 
                SET stock = stock - @cant 
                WHERE idProd=@id", conexion)

                cmdInv.Parameters.AddWithValue("@cant", fila.Cells(3).Value)
                cmdInv.Parameters.AddWithValue("@id", fila.Cells(0).Value)

                cmdInv.ExecuteNonQuery()

            Next

            conexion.Close()

            MessageBox.Show("Venta realizada correctamente")

            dgvDetalle.Rows.Clear()
            total = 0
            lblTotal.Text = "Total: $0"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
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