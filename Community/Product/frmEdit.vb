Public Class frmEdit
    Private Sub ClearAllData()
        TextBox1.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "Chanchai" Then
            Me.Hide()

        Else
            MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "ระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ClearAllData()
    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class