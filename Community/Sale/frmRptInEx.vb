Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Public Class frmRptInEx
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim dtDate As Date
    Dim dblSale, dblOrder, dblBebefit As Double
    Dim IsFindSale, IsFindOrder As Boolean
    '----------------------ตัวแปรสำหรับพิมพ์ใบเสร็จ----------------------
    Dim UseFont As New Font("MS Sans Serif", 10)
    Dim prDoc As New PrintDocument()
    Dim prDlg As New PrintDialog()

    Private Sub FormatGrdSale()
        With grdSale
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "วันที่"
                .Columns(2).HeaderText = "รวม"
                .Columns(3).HeaderText = "ลูกค้า"

                .Columns(0).Width = 40
                .Columns(1).Width = 80
                .Columns(2).Width = 60
                .Columns(3).Width = 60
            End If
        End With
    End Sub
    
    Private Sub ShowData()
        strSQL = "SELECT Sale.S_ID, Sale.Date, Sale.Net, Member1.Name FROM Sale CROSS JOIN Member1 WHERE(Date BETWEEN @StartDate AND @EndDate)"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.SelectCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStart.Value
        da.SelectCommand.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEnd.Value
        If IsFindSale = True Then
            ds.Tables("Sale").Clear()
        End If
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            grdSale.DataSource = ds.Tables("Sale")
            FormatGrdSale()
            IsFindSale = True
        End If
        SubTotal()
    End Sub

    Private Sub SubTotal()
        Dim Num, i As Integer
        dblSale = 0
        dblOrder = 0
        dblBebefit = 0
        strSQL = "SELECT Net FROM Sale WHERE(Date BETWEEN @StartDate AND @EndDate)"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.SelectCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStart.Value
        da.SelectCommand.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEnd.Value
        da.Fill(ds, "Total")
        If ds.Tables("Total").Rows.Count <> 0 Then
            Num = ds.Tables("Total").Rows.Count - 1
            For i = 0 To Num
                dblSale = dblSale + CDbl(ds.Tables("Total").Rows(i).Item(0).ToString)
            Next
            ds.Tables("Total").Clear()
        End If


        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.SelectCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStart.Value
        da.SelectCommand.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEnd.Value
        da.Fill(ds, "SubTotal")
        If ds.Tables("SubTotal").Rows.Count <> 0 Then
            Num = ds.Tables("SubTotal").Rows.Count - 1
            For i = 0 To Num
                dblOrder = dblOrder + CDbl(ds.Tables("SubTotal").Rows(i).Item(0).ToString)
            Next
            ds.Tables("SubTotal").Clear()
        End If

        dblBebefit = dblSale - dblOrder
        lblSale.Text = Format(dblSale, "#,##0.00")
        End Sub

    Private Sub StringToPrint_Print(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        AnyString(e.Graphics, "ร้านจันฉาย ไซน์แอนด์ซิลค์โคราช", 343, 40)
        AnyString(e.Graphics, "เลขที่ 23-25 ถ.บุรินทร์ ต.ในเมือง อ.เมือง จ.นครราชสีมา 30000", 250, 60)
        AnyString(e.Graphics, "สรุปรายได้ประจำเดือน", 343, 90)
        AnyString(e.Graphics, "ตั้งแต่วันที่ : " & dtpStart.Value.Date, 100, 120)
        AnyString(e.Graphics, "ถึงวันที่   : " & dtpEnd.Value.Date, 100, 140)
        AnyString(e.Graphics, "------------------------------------------------------------------------------------------------------------------", 100, 180)
        AnyString(e.Graphics, "สรุปรายได้ : ", 100, 200)
        AnyString(e.Graphics, lblSale.Text, 210, 200)
        AnyString(e.Graphics, "Print : " & Date.Today, 350, 200)
    End Sub

    Private Sub AnyString(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub frmRptInEx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
        SubTotal()
        AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.StringToPrint_Print)
        prDoc.DocumentName = "สรุปรายได้ประจำเดือน"
        prDlg.Document = prDoc
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        ShowData()
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        ShowData()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim ps As New PageSetupDialog
        '  ps.Document = prDoc
        '  If ps.ShowDialog() = DialogResult.OK Then
        'prDoc.DefaultPageSettings = ps.PageSettings
        '  End If
        ' prDoc.Print()
        If grdSale.Rows.Count <= 0 Then
            Return
        End If
        frmInEx.strparam(0) = dtpStart.Value.Date.ToString()
        frmInEx.strparam(1) = dtpEnd.Value.Date.ToString()
        frmInEx.strparam(2) = lblSale.Text
        frmInEx.ShowDialog()
    End Sub
End Class