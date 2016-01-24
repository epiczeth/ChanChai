Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class frmSale2
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim LastRecord As Long
    Dim dblSubTotal, dblRecieve, dblChange As Double
    Dim IsFindProduct, IsFindMember, IsFindSale, IsFindSaleDetail As Boolean
    '----------------------ตัวแปรสำหรับพิมพ์ใบเสร็จ----------------------
    Dim lngO_ID As Long = 0
    Dim UseFont As New Font("MS Sans Serif", 10)
    Dim prDoc As New PrintDocument()
    Dim prDlg As New PrintDialog()
    Private Sub AddEdit()
        cmdAdd.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        cbMid.Enabled = True
        cbmname.Enabled = True
        cbpid.Enabled = True
        cbpname.Enabled = True
        cmdAddList.Enabled = True
    End Sub
    Private Sub SaveCancel()
        cmdAdd.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        cbMid.Enabled = False
        cbmname.Enabled = False
        cbpid.Enabled = False
        cbpname.Enabled = False
        cmdAddList.Enabled = False
    End Sub
    Private Sub ClearAllData()
        lblS_ID.Text = ""
        lblPrice.Text = ""
        lblStock.Text = ""
        txtQty.Text = ""

        lblTotal.Text = ""
        grdOrder.Rows.Clear()
        lblNet.Text = "0.00"
        grdOrder.DataSource = Nothing
    End Sub
    Private Function CheckList() As Boolean
        Check = False
        strSQL = "SELECT * FROM Sale_Detail WHERE(S_ID = " & CInt(lblS_ID.Text) & " AND P_ID  = '" & cbpid.SelectedValue.ToString() & "')"
        da = New SqlDataAdapter(strSQL, Conn.getConnect())
        da.Fill(ds, "List")
        If ds.Tables("List").Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub bindingdata()
        Dim adapter As New SqlDataAdapter("SELECT * FROM MEMBER1 order by 1 ASC", Conn.GetConnect())
        Dim ds0, ds1 As New DataSet
        adapter.Fill(ds0)
        adapter = New SqlDataAdapter("SELECT * FROM product2 order by 1 ASC", Conn.GetConnect())
        adapter.Fill(ds1)
        cbMid.DataSource = ds0.Tables(0)
        cbMid.ValueMember = "M_ID"
        cbMid.DisplayMember = "M_ID"
        cbmname.DataSource = ds0.Tables(0)
        cbmname.ValueMember = "M_ID"
        cbmname.DisplayMember = "Name"

        cbpid.DataSource = ds1.Tables(0)
        cbpid.ValueMember = "P_ID"
        cbpid.DisplayMember = "P_ID"
        cbpname.DataSource = ds1.Tables(0)
        cbpname.ValueMember = "P_ID"
        cbpname.DisplayMember = "Type"
    End Sub

    Private Function CheckDataAdd() As Boolean
        Check = False
        If lblPrice.Text = "" Or txtQty.Text = "" Or lblTotal.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ   ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckDataSave() As Boolean
        Check = False
        If grdOrder.Rows.Count < 1 Then
            MessageBox.Show("กรุณาเลือกสินค้า   ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub FormatGrd()
        With grdOrder
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "รหัส"
                .Columns(1).HeaderText = "รายการ"
                .Columns(2).HeaderText = "ราคาปลีก"
                .Columns(3).HeaderText = "จำนวน"
                .Columns(4).HeaderText = "รวม"

                .Columns(0).Width = 60
                .Columns(1).Width = 180
                .Columns(2).Width = 60
                .Columns(3).Width = 50
                .Columns(4).Width = 80

            End If
        End With
    End Sub
    Private Sub ShowMember()
        'If txtM_ID.Text = "" Then
        '    txtP_ID.Focus()
        '    Exit Sub
        'End If
        strSQL = "SELECT * FROM Member1 WHERE(M_ID = '" & cbMid.SelectedValue.ToString & "')"
        da = New SqlDataAdapter(strSQL, Conn.getConnect())
        If IsFindMember = True Then
            ds.Tables("Member1").Clear()
        End If
        da.Fill(ds, "Member1")
        If ds.Tables("Member1").Rows.Count <> 0 Then

            'lblMName.Text = CStr(ds.Tables("Member1").Rows(0).Item("Name"))
            'lblMName.Text &= "   "
            'lblMName.Text &= CStr(ds.Tables("Member1").Rows(0).Item("Address"))
            'lblMName.Text &= "   "
            'lblMName.Text &= CStr(ds.Tables("Member1").Rows(0).Item("Phone"))
            'txtP_ID.Focus()
            IsFindMember = True
        Else
            MessageBox.Show("ไม่มีชื่อนี้  ", "ลูกค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Private Sub ShowProduct()
        'strSQL = "SELECT * FROM Product2 WHERE(P_ID  = '" & cbpid.SelectedValue.ToString() & "')"
        'da = New SqlDataAdapter(strSQL, Conn.getConnect())
        'If IsFindProduct = True Then
        '    ds.Tables("Product2").Clear()
        'End If
        'da.Fill(ds, "Product2")
        'If ds.Tables("Product2").Rows.Count <> 0 Then
        '    lblName.Text = CStr(ds.Tables("Product2").Rows(0).Item("Type"))
        '    lblPrice.Text = CStr(ds.Tables("Product2").Rows(0).Item("Low"))
        '    lblStock.Text = CStr(ds.Tables("Product2").Rows(0).Item("Stock"))
        '    txtQty.Text = "1"
        '    txtQty.Focus()
        '    IsFindProduct = True
        'Else
        '    MessageBox.Show("ไม่มีชื่อสินค้านี้  ", "สินค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End If
    End Sub
    Private Sub ShowSale_Detail1()
        strSQL = "SELECT Sale_Detail.P_ID, Product2.Name, Sale_Detail.Price,Sale_Detail.Qty,Sale_Detail.Total FROM Product2 INNER JOIN Sale_Detail ON Product2.P_ID = Sale_Detail.P_ID WHERE(S_ID = " & CInt(lblS_ID.Text) & ")"
        da = New SqlDataAdapter(strSQL, Conn.getConnect())
        If IsFindSaleDetail = True Then
            ds.Tables("Sale_Detail").Clear()
        End If
        da.Fill(ds, "Sale_Detail")
        If ds.Tables("Sale_Detail").Rows.Count <> 0 Then
            grdOrder.DataSource = ds.Tables("Sale_Detail")
            FormatGrd()
            IsFindSaleDetail = True
        End If
    End Sub


    Private Sub frmSale2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindingdata()
        gpoMoney.Visible = False

        SaveCancel()

        AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.StringToPrint_Print)
        prDoc.DocumentName = "ใบเสร็จรับเงิน"
        prDlg.Document = prDoc
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        initval = 0
        AddEdit()
        ClearAllData()
        GetOID()
        dtpDate.Value = Date.Today

        strSQL = "SELECT * FROM Sale"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFindSale = True Then
            ds.Tables("Sale").Clear()
        End If
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            LastRecord = CLng(ds.Tables("Sale").Rows(ds.Tables("Sale").Rows.Count - 1).Item("S_ID"))
            IsFindSale = True
        Else
            LastRecord = 0
        End If
        LastRecord += 1
        lblS_ID.Text = CStr(LastRecord)
        initval = CInt(LastRecord)
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            On Error GoTo errDup
            Dim comSave As New SqlCommand
            If CheckDataAdd() = True Then
                If CheckList() = True Then
                    strSQL = "UPDATE Sale_Detail SET Qty = (Qty + " & CInt(txtQty.Text) & "),Total = (Total + " & CLng(lblTotal.Text) & " ) WHERE(S_ID = " & CInt(lblS_ID.Text) & " AND P_ID '" & cbpid.SelectedValue.ToString() & "')"
                    With comSave
                        .CommandType = CommandType.Text
                        .CommandText = strSQL
                        .Connection = Conn.getConnect()
                        .ExecuteNonQuery()
                    End With
                Else
                    strSQL = "INSERT INTO Sale_Detail (S_ID,P_ID,Price,Qty,Total) VALUES(@S_ID,@P_ID,@Price,@Qty,@Total)"
                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@S_ID", SqlDbType.Int).Value = lblS_ID.Text
                        .Parameters.Add("@P_ID", SqlDbType.Text).Value = cbpid.SelectedValue.ToString()
                        .Parameters.Add("@Price", SqlDbType.Float).Value = lblPrice.Text

                        .Parameters.Add("@Qty", SqlDbType.Int).Value = txtQty.Text

                        .Parameters.Add("@Total", SqlDbType.Int).Value = lblTotal.Text

                        .CommandType = CommandType.Text
                        .CommandText = strSQL
                        .Connection = Conn.getConnect()
                        .ExecuteNonQuery()
                    End With
                End If

                lblPrice.Text = ""

                txtQty.Text = ""
                lblStock.Text = ""
                lblTotal.Text = ""

                ShowSale_Detail1()
                SubTotal()

            End If
            Exit Sub
errDup:
            MessageBox.Show("เกิดข้อผิดพลาด กรุณาตรวจสอบข้อมูลอีกครั้ง   " & Environment.NewLine & "1. อาจเกิดจากการระบุรหัสซ้ำ" & Environment.NewLine & "2. หรืออาจจะระบุชนิดข้อมูลผิดพลาด" & Environment.NewLine & "กรุณาตรวจสอบข้อมูลอีกครั้ง  ก่อนทำการบันทึก", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        On Error Resume Next
        Dim dblPrice As Double
        Dim intQty As Integer
        Dim dblTotal As Double


        dblPrice = 0
        intQty = 0
        dblTotal = 0
        dblPrice = CLng(lblPrice.Text)
        intQty = CInt(txtQty.Text)
        dblTotal = dblPrice * intQty
        lblTotal.Text = CStr(dblTotal)
    End Sub
    Private addcount As Integer = 0
    Private Sub cmdAddList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddList.Click
        '        On Error GoTo errDup
        '        Dim comSave As New SqlCommand
        '        If CheckDataAdd() = True Then
        '            If CheckList() = True Then
        '                strSQL = "UPDATE Sale_Detail SET Qty = (Qty + " & CInt(txtQty.Text) & "),Total = (Total + " & CLng(lblTotal.Text) & " ) WHERE(S_ID = " & CInt(lblS_ID.Text) & " AND P_ID '" & cbpid.SelectedValue.ToString() & "')"
        '                With comSave
        '                    .CommandType = CommandType.Text
        '                    .CommandText = strSQL
        '                    .Connection = Conn.getConnect()
        '                    .ExecuteNonQuery()
        '                End With
        '            Else
        '                strSQL = "INSERT INTO Sale_Detail (S_ID,P_ID,Price,Qty,Total) VALUES (@S_ID,@P_ID,@Price,@Qty,@Total)"
        '                With comSave
        '                    .Parameters.Clear()
        '                    .Parameters.Add("@S_ID", SqlDbType.Int).Value = lblS_ID.Text
        '                    .Parameters.Add("@P_ID", SqlDbType.Text).Value = cbpid.SelectedValue.ToString()
        '                    .Parameters.Add("@Price", SqlDbType.Float).Value = lblPrice.Text
        '                    .Parameters.Add("@Qty", SqlDbType.Int).Value = txtQty.Text
        '                    .Parameters.Add("@Total", SqlDbType.Int).Value = lblTotal.Text
        '                    .CommandType = CommandType.Text
        '                    .CommandText = strSQL
        '                    .Connection = Conn.getConnect()
        '                    .ExecuteNonQuery()
        '                End With
        '            End If


        '            lblPrice.Text = ""
        '            txtQty.Text = ""
        '            lblTotal.Text = ""
        '            ShowSale_Detail1()
        '            SubTotal()

        '        End If
        '        Exit Sub
        'errDup:
        '        MessageBox.Show("เกิดข้อผิดพลาด กรุณาตรวจสอบข้อมูลอีกครั้ง   " & Environment.NewLine & "1. อาจเกิดจากการระบุรหัสซ้ำ" & Environment.NewLine & "2. หรืออาจจะระบุชนิดข้อมูลผิดพลาด" & Environment.NewLine & "กรุณาตรวจสอบข้อมูลอีกครั้ง  ก่อนทำการบันทึก", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        If txtQty.Text.Length = 0 Or txtQty.Text = "0" Then
            Exit Sub
        End If
        If lblStock.Text.Length = 0 Or lblStock.Text = "0" Then
            Exit Sub
        End If
        Dim cmds As New SqlCommand("UPDATE Product2 SET Stock=@stc WHERE P_ID=@pid", Conn.GetConnect())
        cmds.Parameters.Add("@stc", SqlDbType.Int).Value = (CInt(lblStock.Text) - CInt(txtQty.Text))
        cmds.Parameters.Add("@pid", SqlDbType.NVarChar).Value = cbpid.SelectedValue.ToString()
        lblStock.Text = (CInt(lblStock.Text) - CInt(txtQty.Text)).ToString()
        cmds.ExecuteNonQuery()
        grdOrder.Rows.Add(CInt(lblS_ID.Text) + addcount, cbpid.SelectedValue.ToString(), lblPrice.Text, txtQty.Text, lblTotal.Text, cbMid.SelectedValue.ToString())
        initval += 1
        lblS_ID.Text = initval.ToString
        Dim sum As Integer = 0
        For i As Integer = 0 To grdOrder.Rows.Count - 1
            sum += CInt(grdOrder.Rows(i).Cells(4).Value)
        Next

        lblNet.Text = Format(sum, "#,##0.00")
        lblTotal.Text = ""
        txtQty.Text = ""
    End Sub
    Private initval As Integer = 0
    Private Sub SubTotal()
        Dim Num, i As Integer
        dblSubTotal = 0
        strSQL = "SELECT Total FROM Sale_Detail WHERE(S_ID = " & CInt(lblS_ID.Text) & " )"
        da = New SqlDataAdapter(strSQL, Conn.getConnect())
        da.Fill(ds, "SubTotal")
        If ds.Tables("SubTotal").Rows.Count <> 0 Then
            Num = ds.Tables("SubTotal").Rows.Count - 1
            For i = 0 To Num
                dblSubTotal = dblSubTotal + CDbl(ds.Tables("SubTotal").Rows(i).Item(0).ToString)
            Next
            lblNet.Text = Format(dblSubTotal, "#,###.00")
            ds.Tables("SubTotal").Clear()
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'On Error GoTo errDup
        'Dim comSave As New SqlCommand
        'Dim comUpdate As New SqlCommand
        'Dim numRows, i As Integer
        'numRows = grdOrder.Rows.Count - 1
        'If CheckDataSave() = True Then
        '    strSQL = "INSERT INTO Sale (S_ID,Date,Net,M_ID) VALUES(@S_ID,@Date,@Net,@M_ID)"
        '    With comSave
        '        .Parameters.Clear()
        '        .Parameters.Add("@S_ID", SqlDbType.Int).Value = lblS_ID.Text
        '        .Parameters.Add("@Date", SqlDbType.DateTime).Value = dtpDate.Value
        '        .Parameters.Add("@Net", SqlDbType.Float).Value = lblNet.Text
        '        If cbMid.SelectedValue.ToString() = "" Then
        '            .Parameters.Add("@M_ID", SqlDbType.Int).Value = 0
        '        Else
        '            .Parameters.Add("@M_ID", SqlDbType.Int).Value = cbMid.Text
        '        End If
        '        .CommandType = CommandType.Text
        '        .CommandText = strSQL
        '        .Connection = Conn.getConnect()
        '        .ExecuteNonQuery()
        '    End With

        '    For i = 0 To numRows
        '        strSQL = "UPDATE Product2 SET Stock = Stock - @Stock WHERE(P_ID = @P_ID)"
        '        With comUpdate
        '            .Parameters.Clear()
        '            .Parameters.Add("@Stock", SqlDbType.Int).Value = grdOrder.Rows(i).Cells(3).Value
        '            .Parameters.Add("@P_ID", SqlDbType.VarChar).Value = grdOrder.Rows(i).Cells(0).Value.ToString()
        '            .CommandType = CommandType.Text
        '            .CommandText = strSQL
        '            .Connection = Conn.GetConnect()
        '            .ExecuteNonQuery()
        '        End With

        '    Next

        'MessageBox.Show("บันทึกลงฐานข้อมูลเรียบร้อยแล้ว   ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'gpoMoney.Visible = True
        'lblSum.Text = Format(dblSubTotal, "#,##0.00")
        'lngO_ID = CLng(lblS_ID.Text)
        'txtRecieve.Text = ""
        'txtRecieve.Focus()
        'End If
        '        Exit Sub
        'errDup:
        '        MessageBox.Show("เกิดข้อผิดพลาด กรุณาตรวจสอบข้อมูลอีกครั้ง   " & Environment.NewLine & "1. อาจเกิดจากการระบุรหัสซ้ำ" & Environment.NewLine & "2. หรืออาจจะระบุชนิดข้อมูลผิดพลาด" & Environment.NewLine & "กรุณาตรวจสอบข้อมูลอีกครั้ง  ก่อนทำการบันทึก", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        If grdOrder.Rows.Count <= 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To grdOrder.Rows.Count - 1
            Dim cmd As New SqlCommand("INSERT INTO Sale (S_ID,Date,Net,M_ID) VALUES(@S_ID,@Date,@Net,@M_ID)", Conn.GetConnect())
            With cmd
                .Parameters.Add("@S_ID", SqlDbType.Int).Value = CInt(grdOrder.Rows(i).Cells(0).Value)
                .Parameters.Add("@Date", SqlDbType.DateTime).Value = CDate(dtpDate.Value)
                .Parameters.Add("@Net", SqlDbType.Float).Value = CLng(grdOrder.Rows(i).Cells(3).Value)
                .Parameters.Add("@M_ID", SqlDbType.Int).Value = CInt(cbMid.SelectedValue)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        For i As Integer = 0 To grdOrder.Rows.Count - 1
            Dim cmd As New SqlCommand("INSERT INTO Sale_Detail (S_ID,P_ID,Price,Qty,Total) VALUES (@S_ID,@P_ID,@Price,@Qty,@Total)", Conn.GetConnect())
            With cmd
                .Parameters.Clear()
                .Parameters.Add("@S_ID", SqlDbType.Int).Value = CInt(grdOrder.Rows(i).Cells(0).Value)
                .Parameters.Add("@P_ID", SqlDbType.Text).Value = CStr(grdOrder.Rows(i).Cells(1).Value)
                .Parameters.Add("@Price", SqlDbType.Float).Value = CLng(grdOrder.Rows(i).Cells(2).Value)
                .Parameters.Add("@Qty", SqlDbType.Int).Value = CInt(grdOrder.Rows(i).Cells(3).Value)
                .Parameters.Add("@Total", SqlDbType.Int).Value = CInt(grdOrder.Rows(i).Cells(4).Value)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        Dim cmds As New SqlCommand("INSERT INTO Orders (O_ID) VALUES (@oid)", Conn.GetConnect())
        With cmds
            .Parameters.Clear()
            .Parameters.Add("@oid", SqlDbType.Int).Value = CInt(oid)
        End With
        cmds.ExecuteNonQuery()
        cmds.Dispose()
        MessageBox.Show("บันทึกการขายแล้ว")
        billing1.list = "2"
        billing1.dfrom = grdOrder.Rows(0).Cells(0).Value.ToString()
        billing1.dto = (CInt(lblS_ID.Text) - 1).ToString()
        billing1.pcus = cbmname.SelectedValue.ToString()
        billing1.oid = CStr(oid)
        billing1.ssum = CInt(lblNet.Text)
        billing1.ddate = dtpDate.Value
        billing1.ShowDialog()

        SaveCancel()
        ClearAllData()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Dim comDelete As New SqlCommand
        strSQL = "DELETE Sale_Detail WHERE(S_ID = " & lblS_ID.Text & ")"
        With comDelete
            .CommandType = CommandType.Text
            .CommandText = strSQL
            .Connection = Conn.getConnect()
            .ExecuteNonQuery()
        End With
        SaveCancel()
        ClearAllData()
    End Sub
    Private Sub StringToPrint_Print(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim NumRow, i, Lines As Integer
        i = 0
        NumRow = grdOrder.Rows.Count - 1
        Lines = 260
        AnyString(e.Graphics, "ร้านจันฉาย ไซน์แอนด์ซิลค์โคราช", 300, 60)
        AnyString(e.Graphics, "เลขที่ 23-25 ถ.บุรินทร์ ต.ในเมือง อ.เมือง จ.นครราชสีมา 30000", 200, 80)
        AnyString(e.Graphics, "ใบเสร็จรับเงิน", 350, 120)
        AnyString(e.Graphics, "เลขที่เอกสาร : " & CStr(lngO_ID), 200, 140)
        AnyString(e.Graphics, "วันที่ออกใบเสร็จ : " & Date.Today, 200, 160)
        If cbMid.Text = "" Then
            AnyString(e.Graphics, "ลูกค้า : ลูกค้าทั่วไป", 200, 180)
        Else
            AnyString(e.Graphics, "ลูกค้า : " & cbmname.SelectedValue.ToString(), 200, 180)
        End If

        AnyString(e.Graphics, "-----------------------------------------------------------", 250, 200)
        AnyString(e.Graphics, "รายการ                                ราคา    จำนวน     รวม", 250, 220)
        AnyString(e.Graphics, "-----------------------------------------------------------", 250, 240)
        For i = 0 To NumRow
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(1).Value.ToString(), 260, Lines)
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(2).Value.ToString(), 405, Lines)
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(3).Value.ToString(), 460, Lines)
            AnyString(e.Graphics, grdOrder.Rows.Item(i).Cells(4).Value.ToString(), 505, Lines)
            Lines = Lines + 20
        Next
        AnyString(e.Graphics, "-----------------------------------------------------------", 250, Lines)
        AnyString(e.Graphics, "รวมทั้งสิ้น : " & Format(dblSubTotal, "#,##0.00") & ".-", 450, Lines + 20)
        AnyString(e.Graphics, "-----------------------------------------------------------", 250, Lines + 40)
        AnyString(e.Graphics, "รับเงินมา  : " & Format(dblRecieve, "#,##0.00") & ".-", 450, Lines + 60)
        AnyString(e.Graphics, "เงินทอน   : " & Format(dblChange, "#,##0.00") & ".-", 450, Lines + 80)
        AnyString(e.Graphics, "ขอบคุณ(Thank You)", 500, Lines + 120)
    End Sub
    Private Sub AnyString(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub txtRecieve_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecieve.KeyPress
        If e.KeyChar = Chr(13) Then
            If dblRecieve < dblSubTotal Then
                MessageBox.Show("เงินรับมาน้อยกว่ายอดรวม  กรุณาตรวจสอบ        ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            gpoMoney.Visible = False
            prDoc.Print()
            SaveCancel()
            ClearAllData()
        End If
    End Sub

    Private Sub txtRecieve_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecieve.TextChanged
        On Error Resume Next
        dblRecieve = CDbl(txtRecieve.Text)
        dblChange = dblRecieve - dblSubTotal
        lblChange.Text = Format(dblChange, "#,##0.00")
    End Sub

    Private Sub txtM_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ShowMember()
        End If
    End Sub

    Private Sub txtP_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ShowProduct()
        End If
    End Sub


    Private Sub cbpid_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbpid.SelectedValueChanged
        load_cb()
    End Sub
    Private Sub load_cb()
        If cbpid.SelectedValue.ToString() <> "" Then

            Dim cmd As New SqlCommand("SELECT * FROM Product2 WHERE (P_ID=@pid)", Conn.GetConnect())
            cmd.Parameters.Add("@pid", SqlDbType.NVarChar).Value = cbpid.SelectedValue.ToString()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                lblPrice.Text = reader.Item("Price").ToString()
                lblStock.Text = reader.Item("Stock").ToString()
            End While
            reader.Dispose()
        End If
    End Sub

    Private Sub cbpname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbpname.SelectedIndexChanged
        load_cb()
    End Sub


    Dim oid As Integer
    Private Sub GetOID()
        Dim last As Integer = 0
        Dim cm As New SqlCommand("select top 1 O_ID from orders order by O_ID desc", Conn.GetConnect())
        Dim reader As SqlDataReader
        reader = cm.ExecuteReader()
        While reader.Read()
            last = CInt(reader.Item("O_ID")) + 1
        End While
        oid = last
    End Sub
End Class