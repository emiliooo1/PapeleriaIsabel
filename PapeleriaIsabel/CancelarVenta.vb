Imports MySql.Data.MySqlClient

Public Class CancelarVenta
    Dim conexion As New MySqlConnection("server=localhost;user=root;password=1234567890;database=papeleria")


    Private Sub txtIdVenta_TextChanged(sender As Object, e As EventArgs) Handles txtIdVenta.TextChanged

        If txtIdVenta.Text = "" Or Not IsNumeric(txtIdVenta.Text) Then
            dgvDetalle.DataSource = Nothing
            lblTotal.Text = "Total: $0"
            Exit Sub
        End If

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter("
        SELECT 
        v.idVenta,
        v.fecha,
        u.usuario,
        d.idProd,
        p.nombre,
        d.cantidad,
        d.precioUnitario,
        d.subtotal
        FROM detalle_ventas d
        JOIN productos p ON d.idProd = p.idProd
        JOIN ventas v ON d.idVenta = v.idVenta
        JOIN usuarios u ON v.idUsuario = u.idUsuario
        WHERE d.idVenta = @id", conexion)

        da.SelectCommand.Parameters.AddWithValue("@id", txtIdVenta.Text)

        da.Fill(dt)

        dgvDetalle.DataSource = dt


        If dgvDetalle.Columns.Contains("fecha") Then
            dgvDetalle.Columns("fecha").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If


        Dim total As Decimal = 0
        For Each fila As DataRow In dt.Rows
            total += fila("subtotal")
        Next

        lblTotal.Text = "Total: $" & total

    End Sub


    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click

        If txtIdVenta.Text = "" Then
            MessageBox.Show("Ingresa el ID de la venta")
            Exit Sub
        End If


        If MessageBox.Show("¿Cancelar esta venta?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            conexion.Open()

            ' VERIFICAR ESTADO
            Dim cmdEstado As New MySqlCommand("SELECT estado FROM ventas WHERE idVenta=@id", conexion)
            cmdEstado.Parameters.AddWithValue("@id", txtIdVenta.Text)

            Dim estado As Object = cmdEstado.ExecuteScalar()

            If estado Is Nothing Then
                MessageBox.Show("Venta no existe")
                conexion.Close()
                Exit Sub
            End If

            If estado.ToString() = "Cancelada" Then
                MessageBox.Show("La venta ya está cancelada")
                conexion.Close()
                Exit Sub
            End If

            'OBTENER PRODUCTOS
            Dim cmdDetalle As New MySqlCommand("
            SELECT idProd, cantidad 
            FROM detalle_ventas 
            WHERE idVenta=@id", conexion)

            cmdDetalle.Parameters.AddWithValue("@id", txtIdVenta.Text)

            Dim dr As MySqlDataReader = cmdDetalle.ExecuteReader()

            Dim lista As New List(Of Tuple(Of Integer, Integer))

            While dr.Read()
                lista.Add(New Tuple(Of Integer, Integer)(dr("idProd"), dr("cantidad")))
            End While

            dr.Close()

            'DEVOLVER STOCK
            For Each item In lista

                Dim cmdInv As New MySqlCommand("
                UPDATE inventario 
                SET stock = stock + @cant 
                WHERE idProd=@id", conexion)

                cmdInv.Parameters.AddWithValue("@cant", item.Item2)
                cmdInv.Parameters.AddWithValue("@id", item.Item1)

                cmdInv.ExecuteNonQuery()

            Next

            'CANCELAR VENTA
            Dim cmdCancel As New MySqlCommand("
            UPDATE ventas 
            SET estado='Cancelada' 
            WHERE idVenta=@id", conexion)

            cmdCancel.Parameters.AddWithValue("@id", txtIdVenta.Text)
            cmdCancel.ExecuteNonQuery()

            conexion.Close()

            MessageBox.Show("Venta cancelada correctamente")


            txtIdVenta.Clear()
            dgvDetalle.DataSource = Nothing
            lblTotal.Text = "Total: $0"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conexion.Close()
        End Try

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Menu.Show()

    End Sub

    Private Sub CancelarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvDetalle.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvDetalle.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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