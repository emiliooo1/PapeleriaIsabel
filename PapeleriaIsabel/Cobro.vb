Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Cobro
    Public total As Decimal
    Public dgv As DataGridView
    Public vendedor As String
    Public idVenta As Integer

    Private Sub FrmCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = "TOTAL: $" & total.ToString("0.00")
        lblCambio.Text = "CAMBIO: $0.00"
        txtRecibido.Focus()
    End Sub

    Private Sub txtRecibido_TextChanged(sender As Object, e As EventArgs) Handles txtRecibido.TextChanged

        Dim recibido As Decimal

        If Decimal.TryParse(txtRecibido.Text, recibido) Then
            lblCambio.Text = "CAMBIO: $" & (recibido - total).ToString("0.00")
        Else
            lblCambio.Text = "CAMBIO: $0.00"
        End If

    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click

        Dim recibido As Decimal

        If Not Decimal.TryParse(txtRecibido.Text, recibido) Then
            MessageBox.Show("Cantidad inválida")
            Exit Sub
        End If

        If recibido < total Then
            MessageBox.Show("Dinero insuficiente")
            Exit Sub
        End If

        generarTicket(recibido)

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub


    Sub generarTicket(recibido As Decimal)
        Dim subtotalSinIVA As Decimal = total / 1.08D
        Dim iva As Decimal = total - subtotalSinIVA

        Try
            Dim ruta As String = "ticket.pdf"

            ' 🔥 TAMAÑO TICKET REAL
            Dim doc As New iTextSharp.text.Document(New iTextSharp.text.Rectangle(164, 350))
            PdfWriter.GetInstance(doc, New FileStream(ruta, FileMode.Create))

            doc.Open()

            Dim normal As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.COURIER, 7)
            Dim negrita As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD, 8)

            ' ENCABEZADO
            Dim centro As New Paragraph("PAPELERIA ISABEL", negrita)
            centro.Alignment = Element.ALIGN_CENTER
            doc.Add(centro)

            doc.Add(New Paragraph("-----------------------"))

            ' INFO
            doc.Add(New Paragraph("Venta: " & idVenta, normal))
            doc.Add(New Paragraph("Fecha: " & Now.ToString("dd/MM/yy HH:mm"), normal))

            doc.Add(New Paragraph("-----------------------"))

            doc.Add(New Paragraph("CANT PROD P.U IMP", negrita))
            doc.Add(New Paragraph("-----------------------"))

            For Each fila As DataGridViewRow In dgv.Rows

                If fila.IsNewRow Then Continue For

                Dim cant As String = fila.Cells("cantidad").Value.ToString().PadRight(3)

                Dim prod As String = fila.Cells("producto").Value.ToString()
                If prod.Length > 7 Then prod = prod.Substring(0, 7)
                prod = prod.PadRight(7)

                Dim precio As String = Convert.ToDecimal(fila.Cells("precio").Value).ToString("0.00").PadLeft(5)
                Dim subtotal As String = Convert.ToDecimal(fila.Cells("subtotal").Value).ToString("0.00").PadLeft(6)

                Dim linea As String = cant & prod & precio & subtotal

                doc.Add(New Paragraph(linea, normal))

            Next

            doc.Add(New Paragraph("-----------------------"))

            doc.Add(New Paragraph("SUBTOTAL: $" & subtotalSinIVA.ToString("0.00"), normal))

            doc.Add(New Paragraph("IVA INCLUIDO 8%: $" & iva.ToString("0.00"), normal))

            doc.Add(New Paragraph("TOTAL: $" & total.ToString("0.00"), negrita))

            doc.Add(New Paragraph("-----------------------"))
            doc.Add(New Paragraph("EFECTIVO: $" & recibido.ToString("0.00"), normal))
            doc.Add(New Paragraph("CAMBIO: $" & (recibido - total).ToString("0.00"), normal))

            doc.Add(New Paragraph("-----------------------"))


            doc.Add(New Paragraph("GRACIAS POR SU COMPRA", normal) With {.Alignment = Element.ALIGN_CENTER})

            doc.Close()

            Dim psi As New ProcessStartInfo()
            psi.FileName = ruta
            psi.UseShellExecute = True
            Process.Start(psi)

        Catch ex As Exception
            MessageBox.Show("Error ticket: " & ex.Message)
        End Try

    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnCobrar
    End Sub
End Class