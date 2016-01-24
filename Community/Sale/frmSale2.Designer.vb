<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSale2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmname = New System.Windows.Forms.ComboBox()
        Me.cbpname = New System.Windows.Forms.ComboBox()
        Me.cbpid = New System.Windows.Forms.ComboBox()
        Me.cbMid = New System.Windows.Forms.ComboBox()
        Me.lblStock = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblS_ID = New System.Windows.Forms.Label()
        Me.cmdAddList = New System.Windows.Forms.Button()
        Me.grdOrder = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gpoMoney = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecieve = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gpoMoney.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmname)
        Me.GroupBox1.Controls.Add(Me.cbpname)
        Me.GroupBox1.Controls.Add(Me.cbpid)
        Me.GroupBox1.Controls.Add(Me.cbMid)
        Me.GroupBox1.Controls.Add(Me.lblStock)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblS_ID)
        Me.GroupBox1.Controls.Add(Me.cmdAddList)
        Me.GroupBox1.Controls.Add(Me.grdOrder)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 453)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'cbmname
        '
        Me.cbmname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmname.FormattingEnabled = True
        Me.cbmname.Location = New System.Drawing.Point(232, 115)
        Me.cbmname.Name = "cbmname"
        Me.cbmname.Size = New System.Drawing.Size(185, 24)
        Me.cbmname.TabIndex = 59
        '
        'cbpname
        '
        Me.cbpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpname.FormattingEnabled = True
        Me.cbpname.Location = New System.Drawing.Point(106, 186)
        Me.cbpname.Name = "cbpname"
        Me.cbpname.Size = New System.Drawing.Size(136, 24)
        Me.cbpname.TabIndex = 58
        '
        'cbpid
        '
        Me.cbpid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpid.FormattingEnabled = True
        Me.cbpid.Location = New System.Drawing.Point(35, 186)
        Me.cbpid.Name = "cbpid"
        Me.cbpid.Size = New System.Drawing.Size(65, 24)
        Me.cbpid.TabIndex = 57
        '
        'cbMid
        '
        Me.cbMid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMid.FormattingEnabled = True
        Me.cbMid.Location = New System.Drawing.Point(106, 115)
        Me.cbMid.Name = "cbMid"
        Me.cbMid.Size = New System.Drawing.Size(84, 24)
        Me.cbMid.TabIndex = 56
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(349, 184)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(48, 26)
        Me.lblStock.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(344, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 29)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "คงเหลือ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 29)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "ชื่อลูกค้า :"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.lblTotal.Location = New System.Drawing.Point(467, 186)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(78, 26)
        Me.lblTotal.TabIndex = 32
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.lblPrice.Location = New System.Drawing.Point(274, 184)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(55, 26)
        Me.lblPrice.TabIndex = 31
        '
        'lblS_ID
        '
        Me.lblS_ID.BackColor = System.Drawing.Color.White
        Me.lblS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblS_ID.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.lblS_ID.Location = New System.Drawing.Point(359, 27)
        Me.lblS_ID.Name = "lblS_ID"
        Me.lblS_ID.Size = New System.Drawing.Size(178, 27)
        Me.lblS_ID.TabIndex = 28
        Me.lblS_ID.Text = "0"
        '
        'cmdAddList
        '
        Me.cmdAddList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAddList.Location = New System.Drawing.Point(461, 215)
        Me.cmdAddList.Name = "cmdAddList"
        Me.cmdAddList.Size = New System.Drawing.Size(76, 26)
        Me.cmdAddList.TabIndex = 7
        Me.cmdAddList.Text = "เพิ่มรายการ"
        Me.cmdAddList.UseVisualStyleBackColor = False
        '
        'grdOrder
        '
        Me.grdOrder.AllowUserToAddRows = False
        Me.grdOrder.AllowUserToDeleteRows = False
        Me.grdOrder.AllowUserToResizeColumns = False
        Me.grdOrder.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdOrder.BackgroundColor = System.Drawing.Color.White
        Me.grdOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdOrder.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdOrder.Location = New System.Drawing.Point(16, 247)
        Me.grdOrder.Name = "grdOrder"
        Me.grdOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrder.Size = New System.Drawing.Size(521, 199)
        Me.grdOrder.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "รหัสสินค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ราคา"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวน"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "รวม"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "ลูกค้า"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "วันที่ขายสินค้า :"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(359, 58)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(178, 26)
        Me.dtpDate.TabIndex = 19
        Me.dtpDate.Value = New Date(2015, 7, 20, 10, 48, 13, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(489, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "รวม"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ราคาปลีก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "เลขที่การขาย :"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(409, 185)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(48, 26)
        Me.txtQty.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "จำนวน"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(138, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 29)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "ชื่อสินค้า"
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Black
        Me.lblNet.Location = New System.Drawing.Point(573, 85)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(210, 114)
        Me.lblNet.TabIndex = 38
        Me.lblNet.Text = "0.00"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.gpoMoney)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(573, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 312)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'gpoMoney
        '
        Me.gpoMoney.BackColor = System.Drawing.Color.White
        Me.gpoMoney.Controls.Add(Me.Label1)
        Me.gpoMoney.Controls.Add(Me.txtRecieve)
        Me.gpoMoney.Controls.Add(Me.lblChange)
        Me.gpoMoney.Controls.Add(Me.lblSum)
        Me.gpoMoney.Controls.Add(Me.Label3)
        Me.gpoMoney.Controls.Add(Me.Label7)
        Me.gpoMoney.Controls.Add(Me.Label11)
        Me.gpoMoney.Location = New System.Drawing.Point(216, 305)
        Me.gpoMoney.Name = "gpoMoney"
        Me.gpoMoney.Size = New System.Drawing.Size(775, 447)
        Me.gpoMoney.TabIndex = 45
        Me.gpoMoney.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(224, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 133)
        Me.Label1.TabIndex = 13
        '
        'txtRecieve
        '
        Me.txtRecieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRecieve.Location = New System.Drawing.Point(319, 200)
        Me.txtRecieve.MaxLength = 6
        Me.txtRecieve.Name = "txtRecieve"
        Me.txtRecieve.Size = New System.Drawing.Size(393, 80)
        Me.txtRecieve.TabIndex = 11
        Me.txtRecieve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblChange.Location = New System.Drawing.Point(319, 294)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(393, 80)
        Me.lblChange.TabIndex = 10
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSum
        '
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.Color.Blue
        Me.lblSum.Location = New System.Drawing.Point(319, 109)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(393, 83)
        Me.lblSum.TabIndex = 9
        Me.lblSum.Text = "0.00"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("FreesiaUPC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 115)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "เงินทอน :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FreesiaUPC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(94, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 115)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "รับมา :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("FreesiaUPC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(42, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(296, 115)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "รวมเงิน :"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancel.Location = New System.Drawing.Point(78, 229)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(65, 57)
        Me.cmdCancel.TabIndex = 14
        Me.cmdCancel.Text = "ยกเลิก"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSave.Image = Global.Community.My.Resources.Resources._87
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(78, 166)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(65, 57)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "ชำระเงิน"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdAdd.Image = Global.Community.My.Resources.Resources._new
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdd.Location = New System.Drawing.Point(78, 53)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(65, 57)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Text = "ขายสินค้า"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(-6, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 84)
        Me.Panel1.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 39)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ขายสินค้า"
        '
        'frmSale2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 538)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSale2"
        Me.Text = "frmSale2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gpoMoney.ResumeLayout(False)
        Me.gpoMoney.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblS_ID As System.Windows.Forms.Label
    Friend WithEvents cmdAddList As System.Windows.Forms.Button
    Friend WithEvents grdOrder As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents gpoMoney As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecieve As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbMid As System.Windows.Forms.ComboBox
    Friend WithEvents cbmname As System.Windows.Forms.ComboBox
    Friend WithEvents cbpname As System.Windows.Forms.ComboBox
    Friend WithEvents cbpid As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
