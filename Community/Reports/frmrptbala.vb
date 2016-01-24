Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmrptbala

    Private Sub frmrptbala_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As New ADODB
        Dim cmd As New SqlDataAdapter("select * from product2 order by 1 ASC", con.GetConnect())
        Dim ds As New DataSet
        cmd.Fill(ds)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "Reports\rptbala.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsbala", ds.Tables(0)))
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.RefreshReport()

    End Sub
End Class