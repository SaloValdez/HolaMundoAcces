Public Class frmReporte
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim obj As New ClsEmpleado
        Dim rds As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dtsdatos As New DataTable

        Try
            rds.Name = "DataSet1"
            dtsdatos = obj.listar_empleado.Tables(0)
            If dtsdatos.Rows.Count > 0 Then
                rds.Value = dtsdatos
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(rds)
                ReportViewer1.LocalReport.ReportPath = "C:\Users\SaloNet\Documents\Visual Studio 2013\Projects\HolaMundoAcces\HolaMundoAcces\InformeDocente.rdlc"
                '"D:\UNIT\PROGRAMACION DISTRIBUIDA\SisReportes\PjReportes\rptReporteDocente.rdlc  "
            Else
                MessageBox.Show("no se encontraron datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim frm As New frmPrueba()
        frm.Show()
    End Sub
End Class