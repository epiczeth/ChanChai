Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Public Class frmBalance
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim IsFind As Boolean
    Private Sub FormatGrd()
        With grdProduct
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "สินค้า"
                .Columns(2).HeaderText = "โรงงาน/ผู้ผลิต"
                .Columns(3).HeaderText = "สี"
                .Columns(4).HeaderText = "ไซต์/ขนาด"
                .Columns(5).HeaderText = "หน่วย"
                .Columns(6).HeaderText = "ราคาทุน"
                .Columns(7).HeaderText = "ราคาขายส่ง"
                .Columns(8).HeaderText = "ราคาขายปลีก"
                .Columns(9).HeaderText = "ราคาส่งพิเศษ"
                .Columns(10).HeaderText = "จำนวน"

                .Columns(0).Width = 60
                .Columns(1).Width = 100
                .Columns(2).Width = 80
                .Columns(3).Width = 80
                .Columns(4).Width = 60
                .Columns(5).Width = 70
                .Columns(6).Width = 80
                .Columns(7).Width = 80
                .Columns(8).Width = 80
                .Columns(9).Width = 80
                .Columns(10).Width = 80


            End If
        End With
    End Sub
    Private Sub ShowData()
        strSQL = "SELECT * FROM Product2"
        da = New SqlDataAdapter(strSQL, Conn.getConnect())
        If IsFind = True Then
            ds.Tables("Product2").Clear()
        End If
        da.Fill(ds, "Product2")
        If ds.Tables("Product2").Rows.Count <> 0 Then
            grdProduct.DataSource = ds.Tables("Product2")
            FormatGrd()
            IsFind = True
        End If
    End Sub

    Private Sub frmBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ShowData()
    End Sub

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click
        If grdProduct.Rows.Count <= 0 Then
            Return
        End If
        frmrptbala.ShowDialog(Me)
    End Sub
End Class