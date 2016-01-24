Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCir
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim IsFindCirculation, IsFindMember, IsFindM_ID, IsFindNet As Boolean
    Private Sub FormatGrd()
        With grdCir
            If .RowCount <> 0 Then
                .Columns(0).HeaderText = "ปี"
                .Columns(1).HeaderText = "รหัส"
                .Columns(2).HeaderText = "ชื่อ"
                .Columns(3).HeaderText = "รวม"

                .Columns(0).Width = 80
                .Columns(1).Width = 80
                .Columns(2).Width = 100
                .Columns(3).Width = 100
            End If
        End With
    End Sub
    Private Sub ShowData()
        strSQL = "SELECT Circulation.Years,Circulation.M_ID,Member1.Name,Circulation.Sum FROM Member1 INNER JOIN Circulation ON Member1.M_ID = Circulation.M_ID"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFindCirculation = True Then
            ds.Tables("Circulation").Clear()
        End If
        da.Fill(ds, "Circulation")
        If ds.Tables("Circulation").Rows.Count <> 0 Then
            grdCir.DataSource = ds.Tables("Circulation")
            FormatGrd()
            IsFindCirculation = True
        End If
    End Sub
    Private Sub UpdateData()
        Dim i, j As Integer
        Dim dblNet As Double
        Dim comSave As New SqlCommand
        strSQL = "SELECT M_ID FROM Member1 "
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFindMember = True Then
            ds.Tables("Member1").Clear()
        End If
        da.Fill(ds, "Member1")
        If ds.Tables("Member1").Rows.Count <> 0 Then
            For i = 0 To ds.Tables("Member1").Rows.Count - 1
                dblNet = 0
                strSQL = "SELECT M_ID FROM Circulation WHERE(M_ID = " & CInt(ds.Tables("Member1").Rows(i).Item("M_ID").ToString) & ")"
                da = New SqlDataAdapter(strSQL, Conn.GetConnect())
                If IsFindM_ID = True Then
                    ds.Tables("M_ID").Clear()
                End If
                da.Fill(ds, "M_ID")
                If ds.Tables("M_ID").Rows.Count <> 0 Then ' ข้อมูลแล้ว
                    strSQL = "SELECT Net FROM Sale WHERE(M_ID = " & CInt(ds.Tables("Member1").Rows(i).Item("M_ID").ToString) & ")"
                    da = New SqlDataAdapter(strSQL, Conn.GetConnect())
                    If IsFindNet = True Then
                        ds.Tables("Net").Clear()
                    End If
                    da.Fill(ds, "Net")
                    If ds.Tables("Net").Rows.Count <> 0 Then
                        For j = 0 To ds.Tables("Net").Rows.Count - 1
                            dblNet += CDbl(ds.Tables("Net").Rows(j).Item("Net").ToString)
                        Next
                        IsFindNet = True
                    End If
                    strSQL = "UPDATE Circulation SET Sum = " & dblNet & " WHERE(M_ID = " & CInt(ds.Tables("Member1").Rows(i).Item("M_ID").ToString) & ")"
                    With comSave
                        .CommandType = CommandType.Text
                        .CommandText = strSQL
                        .Connection = Conn.GetConnect()
                        .ExecuteNonQuery()
                    End With
                    IsFindM_ID = True
                Else 'ยังไม่มีขัอมูล
                    strSQL = "SELECT Net FROM Sale WHERE(M_ID = " & CInt(ds.Tables("Member1").Rows(i).Item("M_ID").ToString) & ")"
                    da = New SqlDataAdapter(strSQL, Conn.GetConnect())
                    If IsFindNet = True Then
                        ds.Tables("Net").Clear()
                    End If
                    da.Fill(ds, "Net")
                    If ds.Tables("Net").Rows.Count <> 0 Then
                        For j = 0 To ds.Tables("Net").Rows.Count - 1
                            dblNet += CDbl(ds.Tables("Net").Rows(j).Item("Net").ToString)
                        Next
                        IsFindNet = True
                    End If
                    strSQL = "INSERT INTO Circulation(Years,M_ID,Sum) VALUES('" & CStr(Date.Today.Year.ToString) & "'," & CInt(ds.Tables("Member1").Rows(i).Item("M_ID").ToString) & "," & dblNet & ")"
                    With comSave
                        .CommandType = CommandType.Text
                        .CommandText = strSQL
                        .Connection = Conn.GetConnect()
                        .ExecuteNonQuery()
                    End With
                End If
            Next
            IsFindMember = True
        End If
    End Sub

    Private Sub frmCir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        UpdateData()
        ShowData()
    End Sub
End Class