Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient

Public Class frmType
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFind As Boolean

    Private Sub AddEdit()
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdClear.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        grdType.Enabled = False
    End Sub

    Private Sub SaveCancel()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdClear.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        grdType.Enabled = True
        txtType_ID.Enabled = True
    End Sub

    Private Sub ClearAllData()
        txtType_ID.Text = ""
        txtName.Text = ""
        txtType_ID.Focus()
    End Sub

    Private Function CheckDataAdd() As Boolean
        Check = False
        If txtType_ID.Text = "" Or txtName.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ   ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CheckDataEdit() As Boolean
        Check = False
        If txtType_ID.Text = "" Or txtName.Text = "" Then
            MessageBox.Show("กรุณาเลือกรายการเพื่อทำการแก้ไขหรือลบ   ", "ยังไม่เลือกรายการ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub FormatGrd()
        With grdType
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัสประเภท"
                .Columns(1).HeaderText = "ประเภท"
                .Columns(0).Width = 100
                .Columns(1).Width = 180
            End If
        End With
    End Sub

    Private Sub ShowData()
        strSQL = "SELECT * FROM Type1"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFind = True Then
            ds.Tables("Type1").Clear()
        End If
        da.Fill(ds, "Type1")
        If ds.Tables("Type1").Rows.Count <> 0 Then
            grdType.DataSource = ds.Tables("Type1")
            FormatGrd()
            IsFind = True
        End If
    End Sub

    Private Sub frmType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
        SaveCancel()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddEdit()
        ClearAllData()
        Action = "ADD"
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckDataEdit() = True Then
            AddEdit()
            txtType_ID.Enabled = False
            txtName.Focus()
            txtName.SelectAll()
            Action = "EDIT"
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        SaveCancel()
        ClearAllData()
    End Sub

    Private Sub grdType_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdType.CellMouseUp
        If e.RowIndex = -1 Then Exit Sub
        With grdType
            txtType_ID.Text = .Rows.Item(e.RowIndex).Cells(0).Value.ToString()
            txtName.Text = .Rows.Item(e.RowIndex).Cells(1).Value.ToString()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckDataAdd() = True Then
            Select Case Action
                Case "ADD"
                    strSQL = "INSERT INTO Type1(T_ID,NameT) VALUES('" & txtType_ID.Text & "','" & txtName.Text & "')"
                Case "EDIT"
                    strSQL = "UPDATE Type1 SET NameT = '" & txtName.Text & "' WHERE(T_ID = '" & txtType_ID.Text & "') "
            End Select
            Dim comSave As New SqlCommand
            With comSave
                .CommandType = CommandType.Text
                .CommandText = strSQL
                .Connection = Conn.GetConnect()
                .ExecuteNonQuery()
            End With
            MessageBox.Show("บันทึกลงฐานข้อมูลเรียบร้อยแล้ว", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaveCancel()
            ClearAllData()
            ShowData()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        If CheckDataEdit() = True Then
            If (MessageBox.Show("คุณต้องการลบข้อมูล : " & txtName.Text & " ใช่หรือไม่ ?   ", "โปรดยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)) = Windows.Forms.DialogResult.OK Then
                Dim comDelete As New SqlCommand
                strSQL = "DELETE Type1 WHERE(T_ID = '" & txtType_ID.Text & "')"
                With comDelete
                    .CommandType = CommandType.Text
                    .CommandText = strSQL
                    .Connection = Conn.GetConnect()
                    .ExecuteNonQuery()
                End With
                ClearAllData()
                ShowData()
            End If
        End If
    End Sub
End Class