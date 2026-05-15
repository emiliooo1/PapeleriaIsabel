Imports Microsoft.Office.Interop
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

        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.WindowState = FormWindowState.Maximized

        dgvReportes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        dgvReportes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        Dim app As New Excel.Application
        Dim libro As Excel.Workbook = app.Workbooks.Add
        Dim hoja As Excel.Worksheet = CType(libro.Sheets(1), Excel.Worksheet)

        Try

            Dim totalVendido As Decimal = 0


            ' TITULO

            hoja.Range("A1", Chr(64 + dgvReportes.Columns.Count) & "1").Merge()
            hoja.Cells(1, 1) = "PAPELERIA ISABEL"

            With hoja.Range("A1", Chr(64 + dgvReportes.Columns.Count) & "1")
                .Font.Size = 26
                .Font.Bold = True
                .RowHeight = 40
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(52, 152, 219)
                .Font.Color = RGB(255, 255, 255)
            End With


            ' SUBTITULO
            hoja.Range("A2", Chr(64 + dgvReportes.Columns.Count) & "2").Merge()
            hoja.Cells(2, 1) = "REPORTE DE VENTAS"

            With hoja.Range("A2", Chr(64 + dgvReportes.Columns.Count) & "2")
                .Font.Size = 16
                .Font.Bold = True
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Interior.Color = RGB(184, 204, 228)
            End With


            ' ENCABEZADOS

            For i As Integer = 0 To dgvReportes.Columns.Count - 1
                hoja.Cells(4, i + 1) = dgvReportes.Columns(i).HeaderText
            Next

            With hoja.Range("A4", Chr(64 + dgvReportes.Columns.Count) & "4")
                .Font.Bold = True
                .Font.Size = 13
                .RowHeight = 25
                .Interior.Color = RGB(0, 102, 204)
                .Font.Color = RGB(255, 255, 255)
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            ' DATOS
            Dim filaExcel As Integer = 5

            For i As Integer = 0 To dgvReportes.Rows.Count - 1

                If Not dgvReportes.Rows(i).IsNewRow Then

                    For j As Integer = 0 To dgvReportes.Columns.Count - 1

                        Dim valor = dgvReportes.Rows(i).Cells(j).Value

                        If valor IsNot Nothing Then
                            hoja.Cells(filaExcel, j + 1) = "'" & valor.ToString()
                        Else
                            hoja.Cells(filaExcel, j + 1) = ""
                        End If

                    Next

                    'SUMAR TOTAL
                    Try
                        totalVendido += Convert.ToDecimal(dgvReportes.Rows(i).Cells("Total").Value)
                    Catch
                    End Try

                    filaExcel += 1

                End If
            Next

            ' TOTAL VENDIDO
            hoja.Range("A" & filaExcel, "B" & filaExcel).Merge()
            hoja.Cells(filaExcel, 1) = "TOTAL VENDIDO:"

            With hoja.Range("A" & filaExcel, "B" & filaExcel)
                .Font.Bold = True
                .Font.Size = 16
                .Interior.Color = RGB(255, 230, 153)
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            hoja.Cells(filaExcel, 3) = "$" & totalVendido.ToString("N2")

            With hoja.Cells(filaExcel, 3)
                .Font.Bold = True
                .Font.Size = 16
                .Interior.Color = RGB(198, 239, 206)
            End With


            ' DISEÑO
            hoja.Columns.AutoFit()

            Dim ultimaColumna As String = Chr(64 + dgvReportes.Columns.Count)

            Dim rango As Excel.Range =
                hoja.Range("A4", ultimaColumna & filaExcel)

            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous

            'Filas alternadas
            Dim filaColor As Integer = 5

            While filaColor < filaExcel

                hoja.Range("A" & filaColor, ultimaColumna & filaColor).Interior.Color = RGB(221, 235, 247)

                filaColor += 2

            End While

            'Centrar contenido
            hoja.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            'Tamaño general
            hoja.Cells.Font.Size = 12
            hoja.Columns("B:B").ColumnWidth = 25

            ' MOSTRAR EXCEL

            app.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error al exportar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

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

            lblTotal.Text = "Total: $" & total

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