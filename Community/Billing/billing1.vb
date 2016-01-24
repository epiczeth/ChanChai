Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class billing1
    Public dfrom, dto As String
    Public ddate As Date
    Public oid, pcus As String
    Public ssum As Integer
    Public list As String


    Private Sub load_data()


        Dim sql As String
        sql = "SELECT    Sale_Detail.S_ID,    Product2.Type, Sale_Detail.Price, Sale_Detail.Qty, Sale_Detail.Total FROM Sale_Detail INNER JOIN Product2 ON Sale_Detail.P_ID = Product2.P_ID WHERE (Sale_Detail.S_ID BETWEEN @df AND @dt)"
        Dim conn As New ADODB
        Console.WriteLine(dfrom + "|" + dto)
        Dim cmd As New SqlDataAdapter(sql, conn.GetConnect())
        cmd.SelectCommand.Parameters.Add("@df", SqlDbType.Int).Value = CInt(dfrom)
        cmd.SelectCommand.Parameters.Add("@dt", SqlDbType.Int).Value = CInt(dto)
        Dim ds As New DataSet
        cmd.Fill(ds)
        Dim dss As New ReportDataSource("Billing", ds.Tables(0))
        Dim param(3) As ReportParameter
        param(0) = New ReportParameter("poid", oid)
        param(1) = New ReportParameter("pcus", pcus)
        param(2) = New ReportParameter("ssum", ssum)
        param(3) = New ReportParameter("ddate", ddate)

        ReportViewer1.LocalReport.ReportPath = "Billing\rptbilling" + list + ".rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(dss)
            ReportViewer1.LocalReport.SetParameters(param)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
            ReportViewer1.RefreshReport()
    End Sub

    Private Sub billing1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_data()
    End Sub
End Class