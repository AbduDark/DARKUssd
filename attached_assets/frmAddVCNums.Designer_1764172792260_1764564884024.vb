Namespace MTUssd
	' Token: 0x0200000E RID: 14
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmAddVCNums
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000B5 RID: 181 RVA: 0x0000BC4C File Offset: 0x00009E4C
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

		' Token: 0x060000B6 RID: 182 RVA: 0x0000BC9C File Offset: 0x00009E9C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnAddFF = New Global.System.Windows.Forms.Button()
			Me.lblSavePath = New Global.System.Windows.Forms.Label()
			Me.btnSaveAS = New Global.System.Windows.Forms.Button()
			Me.btnExport2 = New Global.System.Windows.Forms.Button()
			Me.cmbPaste = New Global.System.Windows.Forms.Button()
			Me.lblCountPre = New Global.System.Windows.Forms.Label()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnDelOnePre = New Global.System.Windows.Forms.Button()
			Me.txtCardNew = New Global.System.Windows.Forms.TextBox()
			Me.cmbColom = New Global.System.Windows.Forms.ComboBox()
			Me.btnDel = New Global.System.Windows.Forms.Button()
			Me.lstB1 = New Global.System.Windows.Forms.ListBox()
			Me.lstB2 = New Global.System.Windows.Forms.ListBox()
			Me.lblC = New Global.System.Windows.Forms.Label()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.SFD = New Global.System.Windows.Forms.SaveFileDialog()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.lstNumbers = New Global.System.Windows.Forms.ListBox()
			Me.PB1 = New Global.System.Windows.Forms.ProgressBar()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.btnOpen = New Global.System.Windows.Forms.Button()
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
			Me.ODfile = New Global.System.Windows.Forms.OpenFileDialog()
			Me.btnADDAuto = New Global.System.Windows.Forms.Button()
			Me.btnSaveFromOut = New Global.System.Windows.Forms.Button()
			Me.btnTransfer = New Global.System.Windows.Forms.Button()
			Me.txtGroupQty = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnAddFromWebServer = New Global.System.Windows.Forms.Button()
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnAddFF.Location = New Global.System.Drawing.Point(171, 529)
			Me.btnAddFF.Name = "btnAddFF"
			Me.btnAddFF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnAddFF.Size = New Global.System.Drawing.Size(143, 30)
			Me.btnAddFF.TabIndex = 982
			Me.btnAddFF.Text = "اضافة الارقام الى التصدير"
			Me.btnAddFF.UseVisualStyleBackColor = True
			Me.lblSavePath.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.lblSavePath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblSavePath.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSavePath.ForeColor = Global.System.Drawing.Color.Black
			Me.lblSavePath.Location = New Global.System.Drawing.Point(700, 515)
			Me.lblSavePath.Name = "lblSavePath"
			Me.lblSavePath.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblSavePath.Size = New Global.System.Drawing.Size(142, 38)
			Me.lblSavePath.TabIndex = 981
			Me.lblSavePath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnSaveAS.Location = New Global.System.Drawing.Point(588, 518)
			Me.btnSaveAS.Name = "btnSaveAS"
			Me.btnSaveAS.Size = New Global.System.Drawing.Size(79, 30)
			Me.btnSaveAS.TabIndex = 980
			Me.btnSaveAS.Text = "مكان الحفظ"
			Me.btnSaveAS.UseVisualStyleBackColor = True
			Me.btnExport2.Location = New Global.System.Drawing.Point(588, 549)
			Me.btnExport2.Name = "btnExport2"
			Me.btnExport2.Size = New Global.System.Drawing.Size(77, 30)
			Me.btnExport2.TabIndex = 979
			Me.btnExport2.Text = "تصدير"
			Me.btnExport2.UseVisualStyleBackColor = True
			Me.cmbPaste.Location = New Global.System.Drawing.Point(252, 86)
			Me.cmbPaste.Name = "cmbPaste"
			Me.cmbPaste.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.cmbPaste.Size = New Global.System.Drawing.Size(62, 30)
			Me.cmbPaste.TabIndex = 974
			Me.cmbPaste.Text = "Paste"
			Me.cmbPaste.UseVisualStyleBackColor = True
			Me.lblCountPre.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCountPre.ForeColor = Global.System.Drawing.Color.White
			Me.lblCountPre.Location = New Global.System.Drawing.Point(596, 181)
			Me.lblCountPre.Name = "lblCountPre"
			Me.lblCountPre.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCountPre.Size = New Global.System.Drawing.Size(93, 19)
			Me.lblCountPre.TabIndex = 973
			Me.lblCountPre.Text = "#"
			Me.lblCountPre.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnClear.Location = New Global.System.Drawing.Point(771, 488)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnClear.TabIndex = 972
			Me.btnClear.Text = "مسح الكل"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnDelOnePre.Location = New Global.System.Drawing.Point(700, 488)
			Me.btnDelOnePre.Name = "btnDelOnePre"
			Me.btnDelOnePre.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnDelOnePre.TabIndex = 971
			Me.btnDelOnePre.Text = "حذف محدد"
			Me.btnDelOnePre.UseVisualStyleBackColor = True
			Me.txtCardNew.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCardNew.Location = New Global.System.Drawing.Point(588, 142)
			Me.txtCardNew.MaxLength = 11
			Me.txtCardNew.Name = "txtCardNew"
			Me.txtCardNew.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCardNew.Size = New Global.System.Drawing.Size(254, 36)
			Me.txtCardNew.TabIndex = 970
			Me.cmbColom.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbColom.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.cmbColom.FormattingEnabled = True
			Me.cmbColom.Items.AddRange(New Object() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" })
			Me.cmbColom.Location = New Global.System.Drawing.Point(752, 13)
			Me.cmbColom.Name = "cmbColom"
			Me.cmbColom.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.cmbColom.Size = New Global.System.Drawing.Size(90, 27)
			Me.cmbColom.Sorted = True
			Me.cmbColom.TabIndex = 966
			Me.btnDel.ForeColor = Global.System.Drawing.Color.Black
			Me.btnDel.Location = New Global.System.Drawing.Point(822, 46)
			Me.btnDel.Name = "btnDel"
			Me.btnDel.Size = New Global.System.Drawing.Size(20, 27)
			Me.btnDel.TabIndex = 965
			Me.btnDel.Text = "D"
			Me.btnDel.UseVisualStyleBackColor = True
			Me.lstB1.FormattingEnabled = True
			Me.lstB1.Location = New Global.System.Drawing.Point(588, 15)
			Me.lstB1.Name = "lstB1"
			Me.lstB1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstB1.Size = New Global.System.Drawing.Size(77, 56)
			Me.lstB1.TabIndex = 964
			Me.lstB2.FormattingEnabled = True
			Me.lstB2.Location = New Global.System.Drawing.Point(669, 16)
			Me.lstB2.Name = "lstB2"
			Me.lstB2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstB2.Size = New Global.System.Drawing.Size(77, 56)
			Me.lstB2.TabIndex = 963
			Me.lblC.AutoSize = True
			Me.lblC.Location = New Global.System.Drawing.Point(652, 113)
			Me.lblC.Name = "lblC"
			Me.lblC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblC.Size = New Global.System.Drawing.Size(13, 13)
			Me.lblC.TabIndex = 962
			Me.lblC.Text = "0"
			Me.Label18.AutoSize = True
			Me.Label18.Location = New Global.System.Drawing.Point(606, 92)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(94, 13)
			Me.Label18.TabIndex = 961
			Me.Label18.Text = "عدد الخطوط بالملف"
			Me.SFD.DefaultExt = "*.jpg"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(707, 181)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(139, 16)
			Me.Label3.TabIndex = 969
			Me.Label3.Text = "الخطوط المراد تخزينها"
			Me.lstNumbers.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNumbers.FormattingEnabled = True
			Me.lstNumbers.ItemHeight = 23
			Me.lstNumbers.Location = New Global.System.Drawing.Point(588, 203)
			Me.lstNumbers.Name = "lstNumbers"
			Me.lstNumbers.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNumbers.Size = New Global.System.Drawing.Size(254, 280)
			Me.lstNumbers.TabIndex = 968
			Me.PB1.Location = New Global.System.Drawing.Point(591, 489)
			Me.PB1.Name = "PB1"
			Me.PB1.Size = New Global.System.Drawing.Size(103, 18)
			Me.PB1.Style = Global.System.Windows.Forms.ProgressBarStyle.Continuous
			Me.PB1.TabIndex = 967
			Me.btnExport.Location = New Global.System.Drawing.Point(728, 107)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(114, 29)
			Me.btnExport.TabIndex = 960
			Me.btnExport.Text = "استيراد"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.btnOpen.Location = New Global.System.Drawing.Point(728, 79)
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Global.System.Drawing.Size(114, 29)
			Me.btnOpen.TabIndex = 959
			Me.btnOpen.Text = "فتح الملف"
			Me.btnOpen.UseVisualStyleBackColor = True
			Me.btnDelOne.Location = New Global.System.Drawing.Point(237, 159)
			Me.btnDelOne.Name = "btnDelOne"
			Me.btnDelOne.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnDelOne.Size = New Global.System.Drawing.Size(77, 30)
			Me.btnDelOne.TabIndex = 955
			Me.btnDelOne.Text = "حذف رقم"
			Me.btnDelOne.UseVisualStyleBackColor = True
			Me.lblTelNum.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblTelNum.ForeColor = Global.System.Drawing.Color.White
			Me.lblTelNum.Location = New Global.System.Drawing.Point(119, 129)
			Me.lblTelNum.Name = "lblTelNum"
			Me.lblTelNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblTelNum.Size = New Global.System.Drawing.Size(195, 19)
			Me.lblTelNum.TabIndex = 954
			Me.lblTelNum.Text = "#"
			Me.lblTelNum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCount.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCount.ForeColor = Global.System.Drawing.Color.White
			Me.lblCount.Location = New Global.System.Drawing.Point(23, 115)
			Me.lblCount.Name = "lblCount"
			Me.lblCount.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCount.Size = New Global.System.Drawing.Size(58, 19)
			Me.lblCount.TabIndex = 953
			Me.lblCount.Text = "#"
			Me.lblCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.White
			Me.Label4.Location = New Global.System.Drawing.Point(36, 93)
			Me.Label4.Name = "Label4"
			Me.Label4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label4.Size = New Global.System.Drawing.Size(45, 19)
			Me.Label4.TabIndex = 952
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
			Me.dataViewGrid.Location = New Global.System.Drawing.Point(23, 195)
			Me.dataViewGrid.Name = "dataViewGrid"
			Me.dataViewGrid.[ReadOnly] = True
			Me.dataViewGrid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.dataViewGrid.Size = New Global.System.Drawing.Size(291, 328)
			Me.dataViewGrid.TabIndex = 951
			Me.btnDelNums.Location = New Global.System.Drawing.Point(14, 11)
			Me.btnDelNums.Name = "btnDelNums"
			Me.btnDelNums.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnDelNums.Size = New Global.System.Drawing.Size(51, 30)
			Me.btnDelNums.TabIndex = 950
			Me.btnDelNums.Text = "حذف"
			Me.btnDelNums.UseVisualStyleBackColor = True
			Me.btnNewnums.Location = New Global.System.Drawing.Point(71, 11)
			Me.btnNewnums.Name = "btnNewnums"
			Me.btnNewnums.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnNewnums.Size = New Global.System.Drawing.Size(85, 30)
			Me.btnNewnums.TabIndex = 949
			Me.btnNewnums.Text = "رقم حركة جديد"
			Me.btnNewnums.UseVisualStyleBackColor = True
			Me.txtDail.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDail.Location = New Global.System.Drawing.Point(14, 47)
			Me.txtDail.MaxLength = 11
			Me.txtDail.Name = "txtDail"
			Me.txtDail.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDail.Size = New Global.System.Drawing.Size(300, 36)
			Me.txtDail.TabIndex = 948
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ForeColor = Global.System.Drawing.Color.White
			Me.Label10.Location = New Global.System.Drawing.Point(243, 18)
			Me.Label10.Name = "Label10"
			Me.Label10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label10.Size = New Global.System.Drawing.Size(71, 17)
			Me.Label10.TabIndex = 947
			Me.Label10.Text = "رقم حركة"
			Me.txtEnumSH.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.txtEnumSH.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnumSH.Location = New Global.System.Drawing.Point(160, 10)
			Me.txtEnumSH.Name = "txtEnumSH"
			Me.txtEnumSH.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnumSH.Size = New Global.System.Drawing.Size(76, 33)
			Me.txtEnumSH.TabIndex = 946
			Me.txtEnumSH.Text = "0"
			Me.txtEnumSH.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ODfile.FileName = "OFD"
			Me.btnADDAuto.Location = New Global.System.Drawing.Point(23, 151)
			Me.btnADDAuto.Name = "btnADDAuto"
			Me.btnADDAuto.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnADDAuto.Size = New Global.System.Drawing.Size(166, 38)
			Me.btnADDAuto.TabIndex = 956
			Me.btnADDAuto.Text = "التسجيل أليا من الارقام المحددة"
			Me.btnADDAuto.UseVisualStyleBackColor = True
			Me.btnSaveFromOut.Location = New Global.System.Drawing.Point(23, 529)
			Me.btnSaveFromOut.Name = "btnSaveFromOut"
			Me.btnSaveFromOut.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnSaveFromOut.Size = New Global.System.Drawing.Size(129, 29)
			Me.btnSaveFromOut.TabIndex = 983
			Me.btnSaveFromOut.Text = "التسجيل من الرئيسية"
			Me.btnSaveFromOut.UseVisualStyleBackColor = True
			Me.btnTransfer.Location = New Global.System.Drawing.Point(178, 87)
			Me.btnTransfer.Name = "btnTransfer"
			Me.btnTransfer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnTransfer.Size = New Global.System.Drawing.Size(68, 28)
			Me.btnTransfer.TabIndex = 984
			Me.btnTransfer.Text = ">>"
			Me.btnTransfer.UseVisualStyleBackColor = True
			Me.txtGroupQty.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.txtGroupQty.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGroupQty.Location = New Global.System.Drawing.Point(429, 11)
			Me.txtGroupQty.Name = "txtGroupQty"
			Me.txtGroupQty.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGroupQty.Size = New Global.System.Drawing.Size(76, 33)
			Me.txtGroupQty.TabIndex = 985
			Me.txtGroupQty.Text = "300"
			Me.txtGroupQty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(351, 22)
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label1.Size = New Global.System.Drawing.Size(62, 17)
			Me.Label1.TabIndex = 986
			Me.Label1.Text = "Grp Qty"
			Me.btnAddFromWebServer.Location = New Global.System.Drawing.Point(343, 50)
			Me.btnAddFromWebServer.Name = "btnAddFromWebServer"
			Me.btnAddFromWebServer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnAddFromWebServer.Size = New Global.System.Drawing.Size(206, 38)
			Me.btnAddFromWebServer.TabIndex = 987
			Me.btnAddFromWebServer.Text = "Add From Web Server"
			Me.btnAddFromWebServer.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Olive
			MyBase.ClientSize = New Global.System.Drawing.Size(853, 580)
			MyBase.Controls.Add(Me.btnAddFromWebServer)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtGroupQty)
			MyBase.Controls.Add(Me.btnTransfer)
			MyBase.Controls.Add(Me.btnSaveFromOut)
			MyBase.Controls.Add(Me.btnAddFF)
			MyBase.Controls.Add(Me.lblSavePath)
			MyBase.Controls.Add(Me.btnSaveAS)
			MyBase.Controls.Add(Me.btnExport2)
			MyBase.Controls.Add(Me.cmbPaste)
			MyBase.Controls.Add(Me.lblCountPre)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.btnDelOnePre)
			MyBase.Controls.Add(Me.txtCardNew)
			MyBase.Controls.Add(Me.cmbColom)
			MyBase.Controls.Add(Me.btnDel)
			MyBase.Controls.Add(Me.lstB1)
			MyBase.Controls.Add(Me.lstB2)
			MyBase.Controls.Add(Me.lblC)
			MyBase.Controls.Add(Me.Label18)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.lstNumbers)
			MyBase.Controls.Add(Me.PB1)
			MyBase.Controls.Add(Me.btnExport)
			MyBase.Controls.Add(Me.btnOpen)
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
			MyBase.Controls.Add(Me.btnADDAuto)
			MyBase.Name = "frmAddVCNums"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "اضافة خطوط "
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000046 RID: 70
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
