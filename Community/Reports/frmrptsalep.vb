Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmrptsalep
    Public Strcmd As DateTime
    Public Dtdate, Ssum As String
    Private Sub frmrptsalep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim conn As New ADODB
        Dim adapter As New SqlDataAdapter("SELECT Sale.S_ID, Sale.Date, Sale.Net, Member1.Name FROM Sale CROSS JOIN Member1 WHERE (Date = @sdate)", conn.GetConnect())
        adapter.SelectCommand.Parameters.Add("@sdate", SqlDbType.DateTime).Value = Strcmd
        Dim ds As New DataSet
        adapter.Fill(ds)
        Dim param(1) As ReportParameter
        param(0) = New ReportParameter("dtdate", dtdate)
        param(1) = New ReportParameter("ssum", ssum)
        Dim dss As New ReportDataSource("dsSale1", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "Reports\rptSalep.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(dss)
        ReportViewer1.LocalReport.SetParameters(param)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.RefreshReport()
    End Sub
End Class