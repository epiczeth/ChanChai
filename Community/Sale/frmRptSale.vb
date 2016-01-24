Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Public Class frmRptSale
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim dtDate As Date
    Dim dblSubTotal As Double
    Dim IsFind As Boolean
    '----------------------ตัวแปรสำหรับพิมพ์ใบเสร็จ----------------------
    Dim UseFont As New Font("MS Sans Serif", 12)
    Dim prDoc As New PrintDocument()
    Dim prDlg As New PrintDialog()

    Private Sub FormatGrd()
        With grdOrder
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "วันที่"
                .Columns(2).HeaderText = "รวม"
                .Columns(3).HeaderText = "ลูกค้า"

                .Columns(0).Width = 80
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
            End If
        End With
    End Sub

    Private Sub ShowData()
        strSQL = "SELECT Sale.S_ID, Sale.Date, Sale.Net, Member1.Name FROM Sale CROSS JOIN Member1 WHERE(Date = @Date)"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.SelectCommand.Parameters.Add("@Date", SqlDbType.Date).Value = monDate.Value
        If IsFind = True Then
            ds.Tables("Sale").Clear()
        End If
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            grdOrder.DataSource = ds.Tables("Sale")
            FormatGrd()
            IsFind = True
        End If
        SubTotal()
    End Sub

    Private Sub SubTotal()
        Dim Num, i As Integer
        dblSubTotal = 0
        strSQL = "SELECT Sale.S_ID, Sale.Date, Sale.Net, Member1.Name FROM Sale CROSS JOIN Member1 WHERE(Date = @Date)"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.SelectCommand.Parameters.Add("@Date", SqlDbType.Date).Value = monDate.Value
        da.Fill(ds, "SubTotal")
        If ds.Tables("SubTotal").Rows.Count <> 0 Then
            Num = ds.Tables("SubTotal").Rows.Count - 1
            For i = 0 To Num
                dblSubTotal = dblSubTotal + CDbl(ds.Tables("SubTotal").Rows(i).Item(0).ToString)
            Next
            ds.Tables("SubTotal").Clear()
        End If
        lblSubTotal.Text = Format(dblSubTotal, "#,##0.00")
    End Sub

    Private Sub StringToPrint_Print(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim NumRow, i, Lines As Integer
        i = 0
        NumRow = grdOrder.Rows.Count - 1
        Lines = 310
        AnyString(e.Graphics, "ร้านจันฉาย ไซน์แอนด์ซิลค์โคราช", 343, 100)
        AnyString(e.Graphics, "สรุปรายได้ประจำวัน", 340, 140)
        AnyString(e.Graphics, "ประจำวันที่ : " & CStr(monDate.Value.Date), 100, 200)
        AnyString(e.Graphics, "------------------------------------------------------------------------------------------------------------------", 100, 220)
        AnyString(e.Graphics, "    รหัส                        วันที่                              รวม                              รหัสลูกค้า", 100, 250)
        AnyString(e.Graphics, "------------------------------------------------------------------------------------------------------------------", 100, 280)
        For i = 0 To NumRow
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(0).Value.ToString(), 120, Lines)
            AnyString(e.Graphics, CStr(monDate.Value.Date), 220, Lines)
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(2).Value.ToString(), 400, Lines)
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(3).Value.ToString(), 600, Lines)
            Lines = Lines + 30
        Next
        AnyString(e.Graphics, "------------------------------------------------------------------------------------------------------------------", 100, Lines)
        AnyString(e.Graphics, "รวมทั้งสิ้น : " & Format(dblSubTotal, "#,##0.00") & ".-", 600, Lines + 30)
        AnyString(e.Graphics, "------------------------------------------------------------------------------------------------------------------", 100, Lines + 60)
        AnyString(e.Graphics, "Print : " & Date.Today, 350, Lines + 90)
    End Sub

    Private Sub AnyString(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)

        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub frmRptSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
        SubTotal()
        AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.StringToPrint_Print)
        prDoc.DocumentName = "สรุปยอดขาย"
        prDlg.Document = prDoc
    End Sub

    Private Sub monDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles monDate.ValueChanged
        ShowData()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If grdOrder.Rows.Count <= 0 Then
            Return
        End If
        frmrptsalep.Ssum = Format(dblSubTotal, "#,##0.00")
        frmrptsalep.Dtdate = CStr(monDate.Value.Date)
        frmrptsalep.Strcmd = monDate.Value.Date
        frmrptsalep.ShowDialog()
        'prDoc.Print()
    End Sub
End Class