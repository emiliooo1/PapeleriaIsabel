Imports MySql.Data.MySqlClient

Public Class REPORTES
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Menu.Show()

    End Sub
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpInicio.Value = DateTime.Now.AddDays(-7)
        dtpFin.Value = DateTime.Now

        dgvReportes.AllowUserToAddRows = False

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            Dim dt As New DataTable

            Dim query As String = "
            SELECT v.idVenta, v.fecha, v.total
            FROM ventas v
            WHERE DATE(v.fecha) BETWEEN @inicio AND @fin
            ORDER BY v.fecha DESC"

            Dim da As New MySqlDataAdapter(query, conexion)

            da.SelectCommand.Parameters.AddWithValue("@inicio", dtpInicio.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand.Parameters.AddWithValue("@fin", dtpFin.Value.ToString("yyyy-MM-dd"))

            da.Fill(dt)

            dgvReportes.DataSource = dt

            'CALCULAR TOTAL
            Dim total As Decimal = 0

            For Each fila As DataRow In dt.Rows
                total += fila("total")
            Next

            lblTotal.Text = "Total vendido: $" & total

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub


End Class