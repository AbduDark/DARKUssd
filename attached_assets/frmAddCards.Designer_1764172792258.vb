Namespace MTUssd
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmAddCards
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600003A RID: 58 RVA: 0x00006914 File Offset: 0x00004B14
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x00006964 File Offset: 0x00004B64
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnADDAuto = New Global.System.Windows.Forms.Button()
			Me.btnDelOne = New Global.System.Windows.Forms.Button()
			Me.lblTelNum = New Global.System.Windows.Forms.Label()
			Me.lblCount = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.dataViewGrid = New Global.System.Windows.Forms.DataGridView()
			Me.btnDelNums = New Global.System.Windows.Forms.Button()
			Me.btnNewnums = New Global.System.Windows.Forms.Button()
			Me.txtDail = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtEnumSH = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtCardValue = New Global.System.Windows.Forms.TextBox()
			Me.PB1 = New Global.System.Windows.Forms.ProgressBar()
			Me.cmbColom = New Global.System.Windows.Forms.ComboBox()
			Me.btnDel = New Global.System.Windows.Forms.Button()
			Me.lstB1 = New Global.System.Windows.Forms.ListBox()
			Me.lstB2 = New Global.System.Windows.Forms.ListBox()
			Me.lblC = New Global.System.Windows.Forms.Label()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.btnOpen = New Global.System.Windows.Forms.Button()
			Me.ODfile = New Global.System.Windows.Forms.OpenFileDialog()
			Me.txtCardNew = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.lstNumbers = New Global.System.Windows.Forms.ListBox()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnDelOnePre = New Global.System.Windows.Forms.Button()
			Me.lblCountPre = New Global.System.Windows.Forms.Label()
			Me.cmbPaste = New Global.System.Windows.Forms.Button()
			Me.txtTemp = New Global.System.Windows.Forms.TextBox()
			Me.btnAddIQ = New Global.System.Windows.Forms.Button()
			Me.btnPast2 = New Global.System.Windows.Forms.Button()
			Me.btnCleattemp = New Global.System.Windows.Forms.Button()
			Me.SFD = New Global.System.Windows.Forms.SaveFileDialog()
			Me.btnSaveAS = New Global.System.Windows.Forms.Button()
			Me.btnExport2 = New Global.System.Windows.Forms.Button()
			Me.lblSavePath = New Global.System.Windows.Forms.Label()
			Me.btnAddFF = New Global.System.Windows.Forms.Button()
			Me.RBVoda = New Global.System.Windows.Forms.RadioButton()
			Me.RBEts = New Global.System.Windows.Forms.RadioButton()
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnADDAuto.Location = New Global.System.Drawing.Point(12, 152)
			Me.btnADDAuto.Name = "btnADDAuto"
			Me.btnADDAuto.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnADDAuto.Size = New Global.System.Drawing.Size(166, 38)
			Me.btnADDAuto.TabIndex = 371
			Me.btnADDAuto.Text = "التسجيل أليا من الارقام المحددة"
			Me.btnADDAuto.UseVisualStyleBackColor = True
			Me.btnDelOne.Location = New Global.System.Drawing.Point(226, 160)
			Me.btnDelOne.Name = "btnDelOne"
			Me.btnDelOne.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnDelOne.Size = New Global.System.Drawing.Size(77, 30)
			Me.btnDelOne.TabIndex = 370
			Me.btnDelOne.Text = "حذف رقم"
			Me.btnDelOne.UseVisualStyleBackColor = True
			Me.lblTelNum.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblTelNum.ForeColor = Global.System.Drawing.Color.White
			Me.lblTelNum.Location = New Global.System.Drawing.Point(108, 130)
			Me.lblTelNum.Name = "lblTelNum"
			Me.lblTelNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblTelNum.Size = New Global.System.Drawing.Size(195, 19)
			Me.lblTelNum.TabIndex = 369
			Me.lblTelNum.Text = "#"
			Me.lblTelNum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCount.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCount.ForeColor = Global.System.Drawing.Color.White
			Me.lblCount.Location = New Global.System.Drawing.Point(12, 116)
			Me.lblCount.Name = "lblCount"
			Me.lblCount.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCount.Size = New Global.System.Drawing.Size(58, 19)
			Me.lblCount.TabIndex = 367
			Me.lblCount.Text = "#"
			Me.lblCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.White
			Me.Label4.Location = New Global.System.Drawing.Point(25, 94)
			Me.Label4.Name = "Label4"
			Me.Label4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label4.Size = New Global.System.Drawing.Size(45, 19)
			Me.Label4.TabIndex = 366
			Me.Label4.Text = "العدد"
			Me.dataViewGrid.AllowUserToAddRows = False
			Me.dataViewGrid.AllowUserToDeleteRows = False
			Me.dataViewGrid.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dataViewGrid.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGrid.DefaultCellStyle = dataGridViewCellStyle2
			Me.dataViewGrid.Location = New Global.System.Drawing.Point(12, 196)
			Me.dataViewGrid.Name = "dataViewGrid"
			Me.dataViewGrid.[ReadOnly] = True
			Me.dataViewGrid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.dataViewGrid.Size = New Global.System.Drawing.Size(291, 328)
			Me.dataViewGrid.TabIndex = 365
			Me.btnDelNums.Location = New Global.System.Drawing.Point(3, 12)
			Me.btnDelNums.Name = "btnDelNums"
			Me.btnDelNums.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnDelNums.Size = New Global.System.Drawing.Size(51, 30)
			Me.btnDelNums.TabIndex = 364
			Me.btnDelNums.Text = "حذف"
			Me.btnDelNums.UseVisualStyleBackColor = True
			Me.btnNewnums.Location = New Global.System.Drawing.Point(60, 12)
			Me.btnNewnums.Name = "btnNewnums"
			Me.btnNewnums.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnNewnums.Size = New Global.System.Drawing.Size(85, 30)
			Me.btnNewnums.TabIndex = 362
			Me.btnNewnums.Text = "رقم حركة جديد"
			Me.btnNewnums.UseVisualStyleBackColor = True
			Me.txtDail.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDail.Location = New Global.System.Drawing.Point(3, 48)
			Me.txtDail.MaxLength = 16
			Me.txtDail.Name = "txtDail"
			Me.txtDail.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDail.Size = New Global.System.Drawing.Size(300, 36)
			Me.txtDail.TabIndex = 361
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ForeColor = Global.System.Drawing.Color.White
			Me.Label10.Location = New Global.System.Drawing.Point(232, 19)
			Me.Label10.Name = "Label10"
			Me.Label10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label10.Size = New Global.System.Drawing.Size(71, 17)
			Me.Label10.TabIndex = 356
			Me.Label10.Text = "رقم حركة"
			Me.txtEnumSH.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.txtEnumSH.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnumSH.Location = New Global.System.Drawing.Point(149, 11)
			Me.txtEnumSH.Name = "txtEnumSH"
			Me.txtEnumSH.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnumSH.Size = New Global.System.Drawing.Size(76, 33)
			Me.txtEnumSH.TabIndex = 355
			Me.txtEnumSH.Text = "0"
			Me.txtEnumSH.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(157, 94)
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label1.Size = New Global.System.Drawing.Size(75, 17)
			Me.Label1.TabIndex = 374
			Me.Label1.Text = "فئة الكارت"
			Me.txtCardValue.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 192)
			Me.txtCardValue.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCardValue.Location = New Global.System.Drawing.Point(76, 86)
			Me.txtCardValue.Name = "txtCardValue"
			Me.txtCardValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCardValue.Size = New Global.System.Drawing.Size(75, 33)
			Me.txtCardValue.TabIndex = 373
			Me.txtCardValue.Text = "5"
			Me.txtCardValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.PB1.Location = New Global.System.Drawing.Point(317, 482)
			Me.PB1.Name = "PB1"
			Me.PB1.Size = New Global.System.Drawing.Size(103, 18)
			Me.PB1.Style = Global.System.Windows.Forms.ProgressBarStyle.Continuous
			Me.PB1.TabIndex = 383
			Me.cmbColom.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbColom.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.cmbColom.FormattingEnabled = True
			Me.cmbColom.Items.AddRange(New Object() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" })
			Me.cmbColom.Location = New Global.System.Drawing.Point(478, 6)
			Me.cmbColom.Name = "cmbColom"
			Me.cmbColom.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.cmbColom.Size = New Global.System.Drawing.Size(90, 27)
			Me.cmbColom.Sorted = True
			Me.cmbColom.TabIndex = 382
			Me.btnDel.ForeColor = Global.System.Drawing.Color.Black
			Me.btnDel.Location = New Global.System.Drawing.Point(548, 39)
			Me.btnDel.Name = "btnDel"
			Me.btnDel.Size = New Global.System.Drawing.Size(20, 27)
			Me.btnDel.TabIndex = 381
			Me.btnDel.Text = "D"
			Me.btnDel.UseVisualStyleBackColor = True
			Me.lstB1.FormattingEnabled = True
			Me.lstB1.Location = New Global.System.Drawing.Point(314, 8)
			Me.lstB1.Name = "lstB1"
			Me.lstB1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstB1.Size = New Global.System.Drawing.Size(77, 56)
			Me.lstB1.TabIndex = 380
			Me.lstB2.FormattingEnabled = True
			Me.lstB2.Location = New Global.System.Drawing.Point(395, 9)
			Me.lstB2.Name = "lstB2"
			Me.lstB2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstB2.Size = New Global.System.Drawing.Size(77, 56)
			Me.lstB2.TabIndex = 379
			Me.lblC.AutoSize = True
			Me.lblC.Location = New Global.System.Drawing.Point(378, 106)
			Me.lblC.Name = "lblC"
			Me.lblC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblC.Size = New Global.System.Drawing.Size(13, 13)
			Me.lblC.TabIndex = 378
			Me.lblC.Text = "0"
			Me.Label18.AutoSize = True
			Me.Label18.Location = New Global.System.Drawing.Point(332, 85)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(94, 13)
			Me.Label18.TabIndex = 377
			Me.Label18.Text = "عدد الخطوط بالملف"
			Me.btnExport.Location = New Global.System.Drawing.Point(454, 100)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(114, 29)
			Me.btnExport.TabIndex = 376
			Me.btnExport.Text = "استيراد"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.btnOpen.Location = New Global.System.Drawing.Point(454, 72)
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Global.System.Drawing.Size(114, 29)
			Me.btnOpen.TabIndex = 375
			Me.btnOpen.Text = "فتح الملف"
			Me.btnOpen.UseVisualStyleBackColor = True
			Me.ODfile.FileName = "OFD"
			Me.txtCardNew.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCardNew.Location = New Global.System.Drawing.Point(314, 135)
			Me.txtCardNew.MaxLength = 16
			Me.txtCardNew.Name = "txtCardNew"
			Me.txtCardNew.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCardNew.Size = New Global.System.Drawing.Size(254, 36)
			Me.txtCardNew.TabIndex = 386
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(433, 174)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(135, 16)
			Me.Label3.TabIndex = 385
			Me.Label3.Text = "الكروت المراد تخزينها"
			Me.lstNumbers.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNumbers.FormattingEnabled = True
			Me.lstNumbers.ItemHeight = 23
			Me.lstNumbers.Location = New Global.System.Drawing.Point(314, 196)
			Me.lstNumbers.Name = "lstNumbers"
			Me.lstNumbers.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNumbers.Size = New Global.System.Drawing.Size(254, 280)
			Me.lstNumbers.TabIndex = 384
			Me.btnClear.Location = New Global.System.Drawing.Point(497, 481)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnClear.TabIndex = 388
			Me.btnClear.Text = "مسح الكل"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnDelOnePre.Location = New Global.System.Drawing.Point(426, 481)
			Me.btnDelOnePre.Name = "btnDelOnePre"
			Me.btnDelOnePre.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnDelOnePre.TabIndex = 387
			Me.btnDelOnePre.Text = "حذف محدد"
			Me.btnDelOnePre.UseVisualStyleBackColor = True
			Me.lblCountPre.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCountPre.ForeColor = Global.System.Drawing.Color.White
			Me.lblCountPre.Location = New Global.System.Drawing.Point(322, 174)
			Me.lblCountPre.Name = "lblCountPre"
			Me.lblCountPre.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCountPre.Size = New Global.System.Drawing.Size(93, 19)
			Me.lblCountPre.TabIndex = 389
			Me.lblCountPre.Text = "#"
			Me.lblCountPre.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.cmbPaste.Location = New Global.System.Drawing.Point(241, 87)
			Me.cmbPaste.Name = "cmbPaste"
			Me.cmbPaste.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.cmbPaste.Size = New Global.System.Drawing.Size(62, 30)
			Me.cmbPaste.TabIndex = 390
			Me.cmbPaste.Text = "Paste"
			Me.cmbPaste.UseVisualStyleBackColor = True
			Me.txtTemp.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTemp.Location = New Global.System.Drawing.Point(574, 48)
			Me.txtTemp.MaxLength = 600000
			Me.txtTemp.Multiline = True
			Me.txtTemp.Name = "txtTemp"
			Me.txtTemp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTemp.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtTemp.Size = New Global.System.Drawing.Size(213, 452)
			Me.txtTemp.TabIndex = 391
			Me.btnAddIQ.Location = New Global.System.Drawing.Point(574, 4)
			Me.btnAddIQ.Name = "btnAddIQ"
			Me.btnAddIQ.Size = New Global.System.Drawing.Size(91, 40)
			Me.btnAddIQ.TabIndex = 392
			Me.btnAddIQ.Text = "هات الكروت"
			Me.btnAddIQ.UseVisualStyleBackColor = True
			Me.btnPast2.Location = New Global.System.Drawing.Point(671, 4)
			Me.btnPast2.Name = "btnPast2"
			Me.btnPast2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnPast2.Size = New Global.System.Drawing.Size(65, 40)
			Me.btnPast2.TabIndex = 393
			Me.btnPast2.Text = "لصق"
			Me.btnPast2.UseVisualStyleBackColor = True
			Me.btnCleattemp.Location = New Global.System.Drawing.Point(742, 4)
			Me.btnCleattemp.Name = "btnCleattemp"
			Me.btnCleattemp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnCleattemp.Size = New Global.System.Drawing.Size(47, 40)
			Me.btnCleattemp.TabIndex = 394
			Me.btnCleattemp.Text = "مسح"
			Me.btnCleattemp.UseVisualStyleBackColor = True
			Me.SFD.DefaultExt = "*.jpg"
			Me.btnSaveAS.Location = New Global.System.Drawing.Point(370, 508)
			Me.btnSaveAS.Name = "btnSaveAS"
			Me.btnSaveAS.Size = New Global.System.Drawing.Size(45, 44)
			Me.btnSaveAS.TabIndex = 876
			Me.btnSaveAS.Text = "مكان الحفظ"
			Me.btnSaveAS.UseVisualStyleBackColor = True
			Me.btnExport2.Location = New Global.System.Drawing.Point(322, 508)
			Me.btnExport2.Name = "btnExport2"
			Me.btnExport2.Size = New Global.System.Drawing.Size(48, 44)
			Me.btnExport2.TabIndex = 875
			Me.btnExport2.Text = "تصدير"
			Me.btnExport2.UseVisualStyleBackColor = True
			Me.lblSavePath.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.lblSavePath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblSavePath.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSavePath.ForeColor = Global.System.Drawing.Color.Black
			Me.lblSavePath.Location = New Global.System.Drawing.Point(426, 508)
			Me.lblSavePath.Name = "lblSavePath"
			Me.lblSavePath.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblSavePath.Size = New Global.System.Drawing.Size(142, 38)
			Me.lblSavePath.TabIndex = 877
			Me.lblSavePath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnAddFF.Location = New Global.System.Drawing.Point(160, 522)
			Me.btnAddFF.Name = "btnAddFF"
			Me.btnAddFF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnAddFF.Size = New Global.System.Drawing.Size(143, 30)
			Me.btnAddFF.TabIndex = 878
			Me.btnAddFF.Text = "اضافة الارقام الى التصدير"
			Me.btnAddFF.UseVisualStyleBackColor = True
			Me.RBVoda.AutoSize = True
			Me.RBVoda.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.RBVoda.ForeColor = Global.System.Drawing.Color.Red
			Me.RBVoda.Location = New Global.System.Drawing.Point(627, 517)
			Me.RBVoda.Name = "RBVoda"
			Me.RBVoda.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RBVoda.Size = New Global.System.Drawing.Size(77, 23)
			Me.RBVoda.TabIndex = 945
			Me.RBVoda.Text = "فودافون"
			Me.RBVoda.UseVisualStyleBackColor = True
			Me.RBEts.AutoSize = True
			Me.RBEts.Checked = True
			Me.RBEts.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.RBEts.ForeColor = Global.System.Drawing.Color.Lime
			Me.RBEts.Location = New Global.System.Drawing.Point(710, 517)
			Me.RBEts.Name = "RBEts"
			Me.RBEts.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RBEts.Size = New Global.System.Drawing.Size(75, 23)
			Me.RBEts.TabIndex = 944
			Me.RBEts.TabStop = True
			Me.RBEts.Text = "اتصالات"
			Me.RBEts.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			MyBase.ClientSize = New Global.System.Drawing.Size(797, 554)
			MyBase.Controls.Add(Me.RBVoda)
			MyBase.Controls.Add(Me.RBEts)
			MyBase.Controls.Add(Me.btnAddFF)
			MyBase.Controls.Add(Me.lblSavePath)
			MyBase.Controls.Add(Me.btnSaveAS)
			MyBase.Controls.Add(Me.btnExport2)
			MyBase.Controls.Add(Me.btnCleattemp)
			MyBase.Controls.Add(Me.btnPast2)
			MyBase.Controls.Add(Me.btnAddIQ)
			MyBase.Controls.Add(Me.txtTemp)
			MyBase.Controls.Add(Me.cmbPaste)
			MyBase.Controls.Add(Me.lblCountPre)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.btnDelOnePre)
			MyBase.Controls.Add(Me.txtCardNew)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.lstNumbers)
			MyBase.Controls.Add(Me.PB1)
			MyBase.Controls.Add(Me.cmbColom)
			MyBase.Controls.Add(Me.btnDel)
			MyBase.Controls.Add(Me.lstB1)
			MyBase.Controls.Add(Me.lstB2)
			MyBase.Controls.Add(Me.lblC)
			MyBase.Controls.Add(Me.Label18)
			MyBase.Controls.Add(Me.btnExport)
			MyBase.Controls.Add(Me.btnOpen)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtCardValue)
			MyBase.Controls.Add(Me.btnADDAuto)
			MyBase.Controls.Add(Me.btnDelOne)
			MyBase.Controls.Add(Me.lblTelNum)
			MyBase.Controls.Add(Me.lblCount)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.dataViewGrid)
			MyBase.Controls.Add(Me.btnDelNums)
			MyBase.Controls.Add(Me.btnNewnums)
			MyBase.Controls.Add(Me.txtDail)
			MyBase.Controls.Add(Me.Label10)
			MyBase.Controls.Add(Me.txtEnumSH)
			MyBase.MaximizeBox = False
			MyBase.Name = "frmAddCards"
			Me.Text = "اضافة ارقام كروت للشحن"
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000016 RID: 22
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
