Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmInEx
    Public strparam(2) As String
    Private Sub frmInEx_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_data()
    End Sub
    Private Sub load_data()
        Dim sql As String
        sql = "SELECT Sale.S_ID, Sale.Date, Sale.Net, Member1.Name FROM Sale CROSS JOIN Member1 WHERE(Sale.Date BETWEEN @StartDate AND @EndDate)"
        Dim conn As New ADODB
        Dim cmd As New SqlDataAdapter(sql, conn.GetConnect())
        cmd.SelectCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = strparam(0)
        cmd.SelectCommand.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = strparam(1)
        Dim ds As New DataSet
        cmd.Fill(ds)
        Dim dss As New ReportDataSource("dsSale", ds.Tables(0))
        Dim param(2) As ReportParameter
        param(0) = New ReportParameter("dfrom", strparam(0))
        param(1) = New ReportParameter("dto", strparam(1))
        param(2) = New ReportParameter("sump", strparam(2))

        ReportViewer1.LocalReport.ReportPath = "Reports\rptInEx.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(dss)
        ReportViewer1.LocalReport.SetParameters(param)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.RefreshReport()
    End Sub
End Class