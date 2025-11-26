Namespace MTUssd
	' Token: 0x02000011 RID: 17
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSrvNums
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600014C RID: 332 RVA: 0x000121D8 File Offset: 0x000103D8
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

		' Token: 0x0600014D RID: 333 RVA: 0x00012228 File Offset: 0x00010428
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.ODfile = New Global.System.Windows.Forms.OpenFileDialog()
			Me.btnDelOne = New Global.System.Windows.Forms.Button()
			Me.dataViewGrid = New Global.System.Windows.Forms.DataGridView()
			Me.txtDail = New Global.System.Windows.Forms.TextBox()
			Me.SFD = New Global.System.Windows.Forms.SaveFileDialog()
			Me.lblTelNum = New Global.System.Windows.Forms.Label()
			Me.txtSrvName = New Global.System.Windows.Forms.TextBox()
			Me.txtEnote = New Global.System.Windows.Forms.TextBox()
			Me.txtMsg = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.btnAdd = New Global.System.Windows.Forms.Button()
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.ODfile.FileName = "OFD"
			Me.btnDelOne.Location = New Global.System.Drawing.Point(707, 7)
			Me.btnDelOne.Name = "btnDelOne"
			Me.btnDelOne.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnDelOne.Size = New Global.System.Drawing.Size(77, 30)
			Me.btnDelOne.TabIndex = 992
			Me.btnDelOne.Text = "حذف رقم"
			Me.btnDelOne.UseVisualStyleBackColor = True
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
			Me.dataViewGrid.Location = New Global.System.Drawing.Point(2, 91)
			Me.dataViewGrid.Name = "dataViewGrid"
			Me.dataViewGrid.[ReadOnly] = True
			Me.dataViewGrid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.dataViewGrid.Size = New Global.System.Drawing.Size(786, 317)
			Me.dataViewGrid.TabIndex = 988
			Me.txtDail.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDail.Location = New Global.System.Drawing.Point(387, 7)
			Me.txtDail.MaxLength = 11
			Me.txtDail.Name = "txtDail"
			Me.txtDail.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDail.Size = New Global.System.Drawing.Size(174, 36)
			Me.txtDail.TabIndex = 985
			Me.txtDail.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.SFD.DefaultExt = "*.jpg"
			Me.lblTelNum.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblTelNum.ForeColor = Global.System.Drawing.Color.White
			Me.lblTelNum.Location = New Global.System.Drawing.Point(655, 45)
			Me.lblTelNum.Name = "lblTelNum"
			Me.lblTelNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblTelNum.Size = New Global.System.Drawing.Size(129, 19)
			Me.lblTelNum.TabIndex = 991
			Me.lblTelNum.Text = "#"
			Me.lblTelNum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSrvName.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSrvName.Location = New Global.System.Drawing.Point(2, 7)
			Me.txtSrvName.MaxLength = 100
			Me.txtSrvName.Name = "txtSrvName"
			Me.txtSrvName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSrvName.Size = New Global.System.Drawing.Size(280, 36)
			Me.txtSrvName.TabIndex = 993
			Me.txtSrvName.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.txtEnote.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtEnote.Location = New Global.System.Drawing.Point(2, 45)
			Me.txtEnote.MaxLength = 100
			Me.txtEnote.Name = "txtEnote"
			Me.txtEnote.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnote.Size = New Global.System.Drawing.Size(280, 36)
			Me.txtEnote.TabIndex = 994
			Me.txtEnote.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.txtMsg.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMsg.Location = New Global.System.Drawing.Point(387, 49)
			Me.txtMsg.MaxLength = 100
			Me.txtMsg.Name = "txtMsg"
			Me.txtMsg.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMsg.Size = New Global.System.Drawing.Size(174, 36)
			Me.txtMsg.TabIndex = 995
			Me.txtMsg.Text = "ألغاء"
			Me.txtMsg.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(282, 18)
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label1.Size = New Global.System.Drawing.Size(99, 19)
			Me.Label1.TabIndex = 996
			Me.Label1.Text = "اسم الخدمة"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.White
			Me.Label2.Location = New Global.System.Drawing.Point(288, 59)
			Me.Label2.Name = "Label2"
			Me.Label2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label2.Size = New Global.System.Drawing.Size(68, 19)
			Me.Label2.TabIndex = 997
			Me.Label2.Text = "ملاحظة"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.White
			Me.Label3.Location = New Global.System.Drawing.Point(564, 56)
			Me.Label3.Name = "Label3"
			Me.Label3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label3.Size = New Global.System.Drawing.Size(65, 19)
			Me.Label3.TabIndex = 998
			Me.Label3.Text = "الرسالة"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.White
			Me.Label5.Location = New Global.System.Drawing.Point(567, 17)
			Me.Label5.Name = "Label5"
			Me.Label5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label5.Size = New Global.System.Drawing.Size(47, 19)
			Me.Label5.TabIndex = 999
			Me.Label5.Text = "الرقم"
			Me.btnAdd.Location = New Global.System.Drawing.Point(624, 7)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.btnAdd.Size = New Global.System.Drawing.Size(77, 30)
			Me.btnAdd.TabIndex = 1000
			Me.btnAdd.Text = "اضافة"
			Me.btnAdd.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Teal
			MyBase.ClientSize = New Global.System.Drawing.Size(796, 413)
			MyBase.Controls.Add(Me.btnAdd)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtMsg)
			MyBase.Controls.Add(Me.txtEnote)
			MyBase.Controls.Add(Me.txtSrvName)
			MyBase.Controls.Add(Me.btnDelOne)
			MyBase.Controls.Add(Me.lblTelNum)
			MyBase.Controls.Add(Me.dataViewGrid)
			MyBase.Controls.Add(Me.txtDail)
			MyBase.MaximizeBox = False
			MyBase.Name = "frmSrvNums"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "اضافة ارقام الخدمات"
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400007D RID: 125
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
