Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Public Class frmScreen
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFindProduct As Boolean
    Dim IsFindDept As Boolean
    Private Sub AddEdit()
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdClear.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        grdScreen.Enabled = False
    End Sub
    Private Sub SaveCancel()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdClear.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        grdScreen.Enabled = True
        txtC_ID.Enabled = True
    End Sub
    Private Sub ClearAllData()
        txtC_ID.Text = ""
        txtName.Text = ""
        txtSize.Text = ""
        cboPrefix.Text = ""
        txtBase.Text = ""
        txtPrice.Text = ""
        txtLow.Text = ""
        txtStock.Text = ""
        txtC_ID.Focus()
    End Sub

    Private Function CheckDataAdd() As Boolean
        Check = False
        If txtC_ID.Text = "" Or txtName.Text = "" Or txtSize.Text = "" Or cboPrefix.Text = "" Or txtBase.Text = "" Or txtPrice.Text = "" Or txtLow.Text = "" Or txtStock.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ   ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckDataEdit() As Boolean
        Check = False
        If txtC_ID.Text = "" Or txtName.Text = "" Or txtSize.Text = "" Or cboPrefix.Text = "" Or txtBase.Text = "" Or txtPrice.Text = "" Or txtLow.Text = "" Or txtStock.Text = "" Then
            MessageBox.Show("กรุณาเลือกรายการเพื่อทำการแก้ไขหรือลบ   ", "ยังไม่เลือกรายการ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckfrmEdit() As Boolean
        frmEdit.Show()
    End Function
    Private Sub FormatGrd()
        With grdScreen
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "ชื่อ"
                .Columns(2).HeaderText = "โรงงาน/ผู้ผลิต"
                .Columns(3).HeaderText = "สี"
                .Columns(4).HeaderText = "ไซต์/ขนาด"
                .Columns(5).HeaderText = "หน่วย"
                .Columns(6).HeaderText = "ราคาทุน"
                .Columns(7).HeaderText = "ราคาขายส่ง"
                .Columns(8).HeaderText = "ราคาขายปลีก"
                .Columns(9).HeaderText = "ราคาขายส่งพิเศษ"
                .Columns(10).HeaderText = "จำนวน"

                .Columns(0).Width = 60
                .Columns(1).Width = 75
                .Columns(2).Width = 70
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 80
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
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFindProduct = True Then
            ds.Tables("Product2").Clear()
        End If
        da.Fill(ds, "Product2")
        If ds.Tables("Product2").Rows.Count <> 0 Then
            grdScreen.DataSource = ds.Tables("Product2")
            FormatGrd()
            IsFindProduct = True
        End If
    End Sub
    Private Sub frmScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()

        SaveCancel()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddEdit()
        ClearAllData()
        txtC_ID.Text = "SC"
        Action = "ADD"
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If MessageBox.Show("โปรดล็อกอินเพื่อทำการแก้ไข", "แก้ไข", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            AddEdit()
            txtC_ID.Enabled = False
            txtName.Focus()
            Action = "EDIT"
            frmEdit.Show()
        Else
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        SaveCancel()
        ClearAllData()
    End Sub
    Private Sub grdScreen_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdScreen.CellMouseUp
        If e.RowIndex = -1 Then Exit Sub
        With grdScreen
            txtC_ID.Text = .Rows.Item(e.RowIndex).Cells(0).Value.ToString()
            txtName.Text = .Rows.Item(e.RowIndex).Cells(1).Value.ToString()
            txtSize.Text = .Rows.Item(e.RowIndex).Cells(4).Value.ToString()
            cboPrefix.Text = .Rows.Item(e.RowIndex).Cells(5).Value.ToString()
            txtBase.Text = .Rows.Item(e.RowIndex).Cells(6).Value.ToString()
            txtPrice.Text = .Rows.Item(e.RowIndex).Cells(7).Value.ToString()
            txtLow.Text = .Rows.Item(e.RowIndex).Cells(8).Value.ToString()
            txtStock.Text = .Rows.Item(e.RowIndex).Cells(10).Value.ToString()
            

        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckDataAdd() = True Then
            Select Case Action
                Case "ADD"
                    strSQL = "INSERT INTO Product2 (P_ID,Type,Size,unit,Base,Price,Low,Stock) VALUES ('" & txtC_ID.Text & "','" & txtName.Text & "','" & txtSize.Text & "','" & cboPrefix.Text & "','" & txtBase.Text & "','" & txtPrice.Text & "','" & txtLow.Text & "','" & txtStock.Text & "')"
                    MessageBox.Show("บันทึกลงฐานข้อมูลเรียบร้อยแล้ว", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case "EDIT"

                    strSQL = "UPDATE Product2 SET Type = '" & txtName.Text & "', Size = '" & txtSize.Text & "',unit = '" & cboPrefix.Text & "',Base = '" & txtBase.Text & "',Price = '" & txtPrice.Text & "',Low = '" & txtLow.Text & "' , Stock = '" & txtStock.Text & "' WHERE(P_ID = '" & txtC_ID.Text & "') "

            End Select

            Dim comSave As New SqlCommand
            With comSave
                .CommandType = CommandType.Text
                .CommandText = strSQL
                .Connection = Conn.GetConnect()
                .ExecuteNonQuery()
            End With


            SaveCancel()
            ClearAllData()
            ShowData()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        If (MessageBox.Show("คุณต้องการลบข้อมูล : " & txtName.Text & " ใช่หรือไม่ ? ", "โปรดยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)) = Windows.Forms.DialogResult.OK Then
            Dim comDelete As New SqlCommand
            strSQL = "DELETE Product2 WHERE(P_ID = '" & txtC_ID.Text & "')"
            With comDelete
                .CommandType = CommandType.Text
                .CommandText = strSQL
                .Connection = Conn.GetConnect()
                .ExecuteNonQuery()
            End With
            ClearAllData()
            ShowData()
        End If
    End Sub
End Class