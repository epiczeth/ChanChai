Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMember
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim LastRecord As Long
    Dim IsFind As Boolean
    Private Sub AddEdit()
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdClear.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        grdCustomer.Enabled = False
    End Sub
    Private Sub SaveCancel()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdClear.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        grdCustomer.Enabled = True
    End Sub
    Private Sub ClearAllData()
        txtM_ID.Text = ""

        txtName.Text = ""
        txtSurname.Text = ""
        txtP.Text = ""
        txtMail.Text = ""

    End Sub
    Private Function CheckDataAdd() As Boolean
        Check = False
        If txtM_ID.Text = "" Or txtName.Text = "" Or txtSurname.Text = "" Or txtP.Text = "" Or txtMail.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ   ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckDataEdit() As Boolean
        Check = False
        If txtM_ID.Text = "" Or txtName.Text = "" Or txtSurname.Text = "" Or txtP.Text = "" Or txtMail.Text = "" Then
            MessageBox.Show("กรุณาเลือกรายการเพื่อทำการแก้ไขหรือลบ   ", "ยังไม่เลือกรายการ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub FormatGrd()
        With grdCustomer
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "ชื่อ"
                .Columns(2).HeaderText = "ที่อยู่"
                .Columns(3).HeaderText = "เบอร์โทรศัพท์"
                .Columns(4).HeaderText = "E-Mail"

                .Columns(0).Width = 60
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 80
                .Columns(4).Width = 250

            End If
        End With
    End Sub
    Private Sub ShowData()
        strSQL = "SELECT * FROM Member1"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFind = True Then
            ds.Tables("Member1").Clear()
        End If
        da.Fill(ds, "Member1")
        If ds.Tables("Member1").Rows.Count <> 0 Then
            grdCustomer.DataSource = ds.Tables("Member1")
            FormatGrd()
            IsFind = True
        End If
    End Sub
    
    Private Sub frmMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
        SaveCancel()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddEdit()
        ClearAllData()
        Action = "ADD"
        strSQL = "SELECT M_ID FROM Member1"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        da.Fill(ds, "LastID")
        If ds.Tables("LastID").Rows.Count <> 0 Then
            LastRecord = CLng(ds.Tables("LastID").Rows(ds.Tables("LastID").Rows.Count - 1).Item("M_ID"))
            ds.Tables("LastID").Clear()
        Else
            LastRecord = 0
        End If
        LastRecord += 1
        txtM_ID.Text = CStr(LastRecord)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckDataEdit() = True Then
            AddEdit()

            Action = "EDIT"
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        SaveCancel()
        ClearAllData()
    End Sub
    Private Sub grdCustomer_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdCustomer.CellMouseUp
        If e.RowIndex = -1 Then Exit Sub
        With grdCustomer
            txtM_ID.Text = .Rows.Item(e.RowIndex).Cells(0).Value.ToString()
            txtName.Text = .Rows.Item(e.RowIndex).Cells(1).Value.ToString()
            txtSurname.Text = .Rows.Item(e.RowIndex).Cells(2).Value.ToString()
            txtP.Text = .Rows.Item(e.RowIndex).Cells(3).Value.ToString()
            txtMail.Text = .Rows.Item(e.RowIndex).Cells(4).Value.ToString()

        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
         If CheckDataAdd() = True Then
            Select Case Action
                Case "ADD"
                    strSQL = "INSERT INTO Member1 (M_ID,Name,Address,Phone,Mail) VALUES('" & txtM_ID.Text & "','" & txtName.Text & "','" & txtSurname.Text & "','" & txtP.Text & "','" & txtMail.Text & "')"
                Case "EDIT"
                    strSQL = "UPDATE Member1 SET Name = '" & txtName.Text & "',Address = '" & txtSurname.Text & "',Phone = '" & txtP.Text & "',Mail = '" & txtMail.Text & "'  WHERE(M_ID = '" & txtM_ID.Text & "') "
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
                strSQL = "DELETE Member1 WHERE(M_ID = " & CInt(txtM_ID.Text) & ")"
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