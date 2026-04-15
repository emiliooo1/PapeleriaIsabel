Imports MySql.Data.MySqlClient

Public Class VENTAS
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")
    Dim total As Decimal = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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

        dgvDetalle.Columns.Clear()
        dgvDetalle.Columns.Add("idProd", "ID")
        dgvDetalle.Columns.Add("producto", "Producto")
        dgvDetalle.Columns.Add("precio", "Precio")
        dgvDetalle.Columns.Add("cantidad", "Cantidad")
        dgvDetalle.Columns.Add("subtotal", "Subtotal")

        dgvDetalle.AllowUserToAddRows = False 'QUITA FILA VACÍA

        lblTotal.Text = "Total: $0"
        numCantidad.Value = 1

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

        'VER SI YA EXISTE EN CARRITO
        For Each filaGrid As DataGridViewRow In dgvDetalle.Rows

            If filaGrid.Cells(0).Value = idProd Then

                Dim cantidadActual As Integer = filaGrid.Cells(3).Value
                Dim nuevaCantidad As Integer = cantidadActual + cantidad

                ' VALIDAR STOCK REAL
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

        ' VALIDAR SI ES NUEVO
        If cantidad > stockActual Then
            MessageBox.Show("No hay suficiente stock")
            Exit Sub
        End If

        ' AGREGAR NUEVO
        Dim subtotal As Decimal = precio * cantidad
        dgvDetalle.Rows.Add(idProd, cmbProducto.Text, precio, cantidad, subtotal)

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


    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click

        If dgvDetalle.CurrentRow Is Nothing Then
            MessageBox.Show("Selecciona un producto")
            Exit Sub
        End If

        dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow)

        calcularTotal()

    End Sub


    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If dgvDetalle.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta")
            Exit Sub
        End If

        Try
            conexion.Open()

            ' Insertar venta
            Dim cmdVenta As New MySqlCommand("INSERT INTO ventas(total, idUsuario) VALUES(@total,@user)", conexion)
            cmdVenta.Parameters.AddWithValue("@total", total)
            cmdVenta.Parameters.AddWithValue("@user", 1)

            cmdVenta.ExecuteNonQuery()

            Dim idVenta As Integer = cmdVenta.LastInsertedId

            ' Insertar detalle
            For Each fila As DataGridViewRow In dgvDetalle.Rows

                Dim cmdDetalle As New MySqlCommand("
                INSERT INTO detalle_ventas(idVenta,idProd,precioUnitario,cantidad,subtotal)
                VALUES(@v,@p,@pre,@cant,@sub)", conexion)

                cmdDetalle.Parameters.AddWithValue("@v", idVenta)
                cmdDetalle.Parameters.AddWithValue("@p", fila.Cells(0).Value)
                cmdDetalle.Parameters.AddWithValue("@pre", fila.Cells(2).Value)
                cmdDetalle.Parameters.AddWithValue("@cant", fila.Cells(3).Value)
                cmdDetalle.Parameters.AddWithValue("@sub", fila.Cells(4).Value)

                cmdDetalle.ExecuteNonQuery()

                ' Actualizar inventario
                Dim cmdInv As New MySqlCommand("
                UPDATE inventario 
                SET stock = stock - @cant 
                WHERE idProd=@id", conexion)

                cmdInv.Parameters.AddWithValue("@cant", fila.Cells(3).Value)
                cmdInv.Parameters.AddWithValue("@id", fila.Cells(0).Value)

                cmdInv.ExecuteNonQuery()

            Next

            conexion.Close()

            MessageBox.Show("Venta realizada")

            ' Limpiar
            dgvDetalle.Rows.Clear()
            total = 0
            lblTotal.Text = "Total: $0"
            numCantidad.Value = 1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try

    End Sub
End Class