Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Public Class frmType1
    Dim strConn As String
    Dim Conn As New ADODB
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFindProduct As Boolean
    Dim IsFindDept As Boolean

    Private Sub ShowDept()
        strSQL = "SELECT T_ID,NameT FROM Type1"
        da = New SqlDataAdapter(strSQL, Conn.GetConnect())
        If IsFindDept = True Then
            ds.Tables("Type1").Clear()
        End If
        da.Fill(ds, "Type1")
        If ds.Tables("Type1").Rows.Count <> 0 Then
            cboGr_ID.DisplayMember = "NameT"
            cboGr_ID.ValueMember = "NameT"
            cboGr_ID.DataSource = ds.Tables("Type1")
            IsFindDept = True
        End If
    End Sub

    Private Sub frmType1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If cboGr_ID.Text = "เสื้อ" Then
            frmShirt.Show()
        Else : cboGr_ID.Text = "อุปกรณ์สกรีน"
            frmScreen.Show()
        End If

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class