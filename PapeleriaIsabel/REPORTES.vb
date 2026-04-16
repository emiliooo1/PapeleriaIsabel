Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class REPORTES
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Menu.Show()

    End Sub
    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234567890;database=papeleria")


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpInicio.Value = DateTime.Now.AddDays(-7)
        dtpFin.Value = DateTime.Now

        dgvReportes.AllowUserToAddRows = False

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvReportes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            Dim dt As New DataTable

            Dim query As String = "
            SELECT v.idVenta, v.fecha, v.total
            FROM ventas v
            WHERE DATE(v.fecha) BETWEEN @inicio AND @fin 
            AND v.estado='Activa'
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim app As New Excel.Application
        Dim libro As Excel.Workbook = app.Workbooks.Add
        Dim hoja As Excel.Worksheet = libro.Sheets(1)

        ' 🔥 ENCABEZADOS
        For i As Integer = 0 To dgvReportes.Columns.Count - 1
            hoja.Cells(1, i + 1) = dgvReportes.Columns(i).HeaderText
        Next

        ' 🔥 DATOS
        For i As Integer = 0 To dgvReportes.Rows.Count - 1
            For j As Integer = 0 To dgvReportes.Columns.Count - 1
                hoja.Cells(i + 2, j + 1) = dgvReportes.Rows(i).Cells(j).Value
            Next
        Next

        ' 🔥 MOSTRAR EXCEL
        app.Visible = True
    End Sub
End Class