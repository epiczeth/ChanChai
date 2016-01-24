Public Class frmMain

   

    Private Sub mnu11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu11.Click
        Dim f As New frmMember()
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub mnu52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu52.Click
        Dim f As New frmBalance()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnu51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu51.Click
        Dim f As New frmSale()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnu71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu71.Click
        Dim f As New frmRptSale()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnu72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu72.Click
        Dim f As New frmRptInEx()
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub ts21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmShirt()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ts11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts11.Click
        Dim f As New frmMember()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ts41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts41.Click
        Dim f As New frmSale1()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ts51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts51.Click
        Dim f As New frmRptSale()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmType()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub tsBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBalance.Click
        Dim f As New frmBalance()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub สรปยอดของสมาชกToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmCir()
        f.MdiParent = Me
        f.Show()
    End Sub

   
    

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim f As New frmType1()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnu13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu13.Click
        Dim f As New frmType1()
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
