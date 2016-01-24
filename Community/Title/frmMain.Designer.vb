<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.sb1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sb2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sb3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ts11 = New System.Windows.Forms.ToolStripButton()
        Me.ts41 = New System.Windows.Forms.ToolStripButton()
        Me.tsBalance = New System.Windows.Forms.ToolStripButton()
        Me.ts51 = New System.Windows.Forms.ToolStripButton()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu51 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu52 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu71 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu72 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbMain.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sb1, Me.sb2, Me.sb3})
        Me.sbMain.Location = New System.Drawing.Point(0, 486)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(961, 22)
        Me.sbMain.TabIndex = 13
        Me.sbMain.Text = "StatusStrip1"
        '
        'sb1
        '
        Me.sb1.AutoSize = False
        Me.sb1.Image = CType(resources.GetObject("sb1.Image"), System.Drawing.Image)
        Me.sb1.Name = "sb1"
        Me.sb1.Size = New System.Drawing.Size(160, 17)
        Me.sb1.Text = "ร้านจันฉาย ไซน์แอนด์ซิลค์โคราช"
        '
        'sb2
        '
        Me.sb2.AutoSize = False
        Me.sb2.Name = "sb2"
        Me.sb2.Size = New System.Drawing.Size(200, 17)
        '
        'sb3
        '
        Me.sb3.AutoSize = False
        Me.sb3.Name = "sb3"
        Me.sb3.Size = New System.Drawing.Size(250, 17)
        '
        'tsMain
        '
        Me.tsMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ts11, Me.ts41, Me.tsBalance, Me.ts51})
        Me.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsMain.Location = New System.Drawing.Point(0, 24)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(961, 39)
        Me.tsMain.TabIndex = 12
        Me.tsMain.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Community.My.Resources.Resources.จัดการ
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(98, 36)
        Me.ToolStripButton1.Text = "ข้อมูลสินค้า"
        '
        'ts11
        '
        Me.ts11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ts11.Image = CType(resources.GetObject("ts11.Image"), System.Drawing.Image)
        Me.ts11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ts11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts11.Name = "ts11"
        Me.ts11.Size = New System.Drawing.Size(98, 36)
        Me.ts11.Text = "ข้อมูลลูกค้า"
        '
        'ts41
        '
        Me.ts41.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ts41.Image = CType(resources.GetObject("ts41.Image"), System.Drawing.Image)
        Me.ts41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ts41.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts41.Name = "ts41"
        Me.ts41.Size = New System.Drawing.Size(90, 36)
        Me.ts41.Text = "ขายสินค้า"
        '
        'tsBalance
        '
        Me.tsBalance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsBalance.Image = CType(resources.GetObject("tsBalance.Image"), System.Drawing.Image)
        Me.tsBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsBalance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBalance.Name = "tsBalance"
        Me.tsBalance.Size = New System.Drawing.Size(109, 36)
        Me.tsBalance.Text = "สินค้าคงเหลือ"
        '
        'ts51
        '
        Me.ts51.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ts51.Image = CType(resources.GetObject("ts51.Image"), System.Drawing.Image)
        Me.ts51.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ts51.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts51.Name = "ts51"
        Me.ts51.Size = New System.Drawing.Size(138, 36)
        Me.ts51.Text = "สรุปรายได้ประจำวัน"
        '
        'mnuMain
        '
        Me.mnuMain.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu1, Me.mnu5, Me.mnu7})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(961, 24)
        Me.mnuMain.Stretch = False
        Me.mnuMain.TabIndex = 11
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnu1
        '
        Me.mnu1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu13, Me.ToolStripSeparator1, Me.mnu11})
        Me.mnu1.Name = "mnu1"
        Me.mnu1.Size = New System.Drawing.Size(116, 20)
        Me.mnu1.Text = "1. จัดการข้อมูลหลัก"
        '
        'mnu13
        '
        Me.mnu13.Image = CType(resources.GetObject("mnu13.Image"), System.Drawing.Image)
        Me.mnu13.Name = "mnu13"
        Me.mnu13.Size = New System.Drawing.Size(191, 30)
        Me.mnu13.Text = "1.1 จัดการข้อมูลสินค้า"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'mnu11
        '
        Me.mnu11.Image = CType(resources.GetObject("mnu11.Image"), System.Drawing.Image)
        Me.mnu11.Name = "mnu11"
        Me.mnu11.Size = New System.Drawing.Size(191, 30)
        Me.mnu11.Text = "1.2 จัดการข้อมูลลูกค้า"
        '
        'mnu5
        '
        Me.mnu5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu51, Me.ToolStripSeparator2, Me.mnu52})
        Me.mnu5.Name = "mnu5"
        Me.mnu5.Size = New System.Drawing.Size(81, 20)
        Me.mnu5.Text = "2. ขายสินค้า"
        '
        'mnu51
        '
        Me.mnu51.Image = CType(resources.GetObject("mnu51.Image"), System.Drawing.Image)
        Me.mnu51.Name = "mnu51"
        Me.mnu51.Size = New System.Drawing.Size(170, 30)
        Me.mnu51.Text = "2.1 ขายสินค้า"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'mnu52
        '
        Me.mnu52.Image = CType(resources.GetObject("mnu52.Image"), System.Drawing.Image)
        Me.mnu52.Name = "mnu52"
        Me.mnu52.Size = New System.Drawing.Size(170, 30)
        Me.mnu52.Text = "2.2 สินค้าคงเหลือ"
        '
        'mnu7
        '
        Me.mnu7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu71, Me.mnu72})
        Me.mnu7.Name = "mnu7"
        Me.mnu7.Size = New System.Drawing.Size(105, 20)
        Me.mnu7.Text = "3. รายงานสรุปผล"
        '
        'mnu71
        '
        Me.mnu71.Image = CType(resources.GetObject("mnu71.Image"), System.Drawing.Image)
        Me.mnu71.Name = "mnu71"
        Me.mnu71.Size = New System.Drawing.Size(215, 30)
        Me.mnu71.Text = "3.1 สรุปรายได้ประจำวัน"
        '
        'mnu72
        '
        Me.mnu72.Image = CType(resources.GetObject("mnu72.Image"), System.Drawing.Image)
        Me.mnu72.Name = "mnu72"
        Me.mnu72.Size = New System.Drawing.Size(215, 30)
        Me.mnu72.Text = "3.2  สรุปรายได้ประจำเดือน"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 508)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "ร้านจันฉาย ไซน์แอนด์ซิลค์โคราช"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents sb1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sb2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sb3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ts11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts41 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts51 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu51 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu52 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu71 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu72 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBalance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
