using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MTUssd
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class frmSrvNums : Form
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00002889 File Offset: 0x00000A89
		public frmSrvNums()
		{
			base.Load += this.frmSrvNums_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000028A9 File Offset: 0x00000AA9
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000028B3 File Offset: 0x00000AB3
		internal virtual OpenFileDialog ODfile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000028BC File Offset: 0x00000ABC
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00012CB4 File Offset: 0x00010EB4
		internal virtual Button btnDelOne
		{
			[CompilerGenerated]
			get
			{
				return this._btnDelOne;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDelOne_Click);
				Button btnDelOne = this._btnDelOne;
				if (btnDelOne != null)
				{
					btnDelOne.Click -= value2;
				}
				this._btnDelOne = value;
				btnDelOne = this._btnDelOne;
				if (btnDelOne != null)
				{
					btnDelOne.Click += value2;
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000028C6 File Offset: 0x00000AC6
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00012CF8 File Offset: 0x00010EF8
		internal virtual DataGridView dataViewGrid
		{
			[CompilerGenerated]
			get
			{
				return this._dataViewGrid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dataViewGrid_CellContentClick);
				DataGridView dataViewGrid = this._dataViewGrid;
				if (dataViewGrid != null)
				{
					dataViewGrid.CellContentClick -= value2;
				}
				this._dataViewGrid = value;
				dataViewGrid = this._dataViewGrid;
				if (dataViewGrid != null)
				{
					dataViewGrid.CellContentClick += value2;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000028D0 File Offset: 0x00000AD0
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000028DA File Offset: 0x00000ADA
		internal virtual TextBox txtDail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000028E3 File Offset: 0x00000AE3
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000028ED File Offset: 0x00000AED
		internal virtual SaveFileDialog SFD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000028F6 File Offset: 0x00000AF6
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002900 File Offset: 0x00000B00
		internal virtual Label lblTelNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002909 File Offset: 0x00000B09
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002913 File Offset: 0x00000B13
		internal virtual TextBox txtSrvName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000291C File Offset: 0x00000B1C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002926 File Offset: 0x00000B26
		internal virtual TextBox txtEnote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000292F File Offset: 0x00000B2F
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002939 File Offset: 0x00000B39
		internal virtual TextBox txtMsg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002942 File Offset: 0x00000B42
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000294C File Offset: 0x00000B4C
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002955 File Offset: 0x00000B55
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000295F File Offset: 0x00000B5F
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002968 File Offset: 0x00000B68
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002972 File Offset: 0x00000B72
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000297B File Offset: 0x00000B7B
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002985 File Offset: 0x00000B85
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000298E File Offset: 0x00000B8E
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00012D3C File Offset: 0x00010F3C
		internal virtual Button btnAdd
		{
			[CompilerGenerated]
			get
			{
				return this._btnAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAdd_Click);
				Button btnAdd = this._btnAdd;
				if (btnAdd != null)
				{
					btnAdd.Click -= value2;
				}
				this._btnAdd = value;
				btnAdd = this._btnAdd;
				if (btnAdd != null)
				{
					btnAdd.Click += value2;
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00012D80 File Offset: 0x00010F80
		private void Reset()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.objData = new CData(Application.StartupPath + "\\maindb.ngm");
				IL_27:
				goto IL_8A;
				IL_29:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_43:
				goto IL_7F;
				IL_45:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_5D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_45;
			}
			IL_7F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012E30 File Offset: 0x00011030
		private void AddTelNum()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				string text = "Insert Into svrnums ";
				IL_13:
				num2 = 3;
				text += "(mobnum,edscrp,enote,srvmsg)";
				IL_21:
				num2 = 4;
				text += "Values (";
				IL_2F:
				num2 = 5;
				text = text + "'" + this.txtDail.Text + "' , ";
				IL_4D:
				num2 = 6;
				text = text + "'" + this.txtSrvName.Text + "' , ";
				IL_6B:
				num2 = 7;
				text = text + "'" + this.txtEnote.Text + "' , ";
				IL_89:
				num2 = 8;
				text = text + "'" + this.txtMsg.Text + "') ";
				IL_A7:
				num2 = 9;
				this.objData.DatabaseCommand(text);
				IL_B7:
				num2 = 10;
				this.txtDail.Text = "";
				IL_CB:
				num2 = 11;
				this.txtSrvName.Text = "";
				IL_DF:
				num2 = 12;
				this.txtEnote.Text = "";
				IL_F3:
				num2 = 13;
				this.txtMsg.Text = "";
				IL_107:
				goto IL_199;
				IL_10C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_152:
				goto IL_18E;
				IL_154:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_16C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_154;
			}
			IL_18E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_199:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00012FFC File Offset: 0x000111FC
		private void GetAllSmsfromDB()
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				DataTable dataTable = new DataTable("temp");
				IL_19:
				num2 = 3;
				dataTable.Columns.Add("الرقم");
				IL_2D:
				num2 = 4;
				dataTable.Columns.Add("اسم الخدمة");
				IL_41:
				num2 = 5;
				dataTable.Columns.Add("نص الرسالة");
				IL_55:
				num2 = 6;
				dataTable.Columns.Add("ملاحظة");
				IL_69:
				num2 = 7;
				IL_6E:
				num2 = 8;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT * FROM svrnums  order by mobnum");
				IL_86:
				num2 = 9;
				bool flag = this.objDataTabletemp.Rows.Count > 0;
				if (!flag)
				{
					goto IL_1A7;
				}
				IL_A5:
				num2 = 10;
				checked
				{
					int num3 = this.objDataTabletemp.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_C3:
						num2 = 11;
						DataRow dataRow = dataTable.NewRow();
						IL_CF:
						num2 = 12;
						dataRow[0] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["mobnum"]);
						IL_FB:
						num2 = 13;
						dataRow[1] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["edscrp"]);
						IL_127:
						num2 = 14;
						dataRow[2] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["srvmsg"]);
						IL_153:
						num2 = 15;
						dataRow[3] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["enote"]);
						IL_17F:
						num2 = 16;
						dataTable.Rows.Add(dataRow);
						IL_191:
						num2 = 17;
						dataRow = null;
						IL_197:
						num2 = 18;
					}
					IL_1A6:
					IL_1A7:
					IL_1A8:
					num2 = 20;
					this.dataViewGrid.DataSource = dataTable;
					IL_1B9:
					num2 = 21;
					this.dataViewGrid.Columns[0].Width = 120;
					IL_1D5:
					num2 = 22;
					this.dataViewGrid.Columns[1].Width = 200;
					IL_1F4:
					num2 = 23;
					this.dataViewGrid.Columns[2].Width = 250;
					IL_213:
					num2 = 24;
					this.dataViewGrid.Columns[3].Width = 250;
					IL_232:
					goto IL_2F0;
					IL_237:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_2A9:
				goto IL_2E5;
				IL_2AB:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_2C3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2AB;
			}
			IL_2E5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2F0:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00013320 File Offset: 0x00011520
		private void frmSrvNums_Load(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.Reset();
				IL_14:
				num2 = 3;
				this.GetAllSmsfromDB();
				IL_1D:
				goto IL_84;
				IL_1F:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3D:
				goto IL_79;
				IL_3F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_57:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3F;
			}
			IL_79:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_84:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000133CC File Offset: 0x000115CC
		private void dataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.lblTelNum.Text = Conversions.ToString(this.dataViewGrid[0, e.RowIndex].Value);
				IL_35:
				goto IL_98;
				IL_37:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_51:
				goto IL_8D;
				IL_53:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_6B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_53;
			}
			IL_8D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_98:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001348C File Offset: 0x0001168C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.txtDail.Text.Trim().Length > 0;
			if (flag)
			{
				this.AddTelNum();
				this.GetAllSmsfromDB();
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000134C8 File Offset: 0x000116C8
		private void btnDelOne_Click(object sender, EventArgs e)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				int num3 = (int)Interaction.MsgBox("هل  تريد حذف الرقم" + this.lblTelNum.Text, MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
				IL_2B:
				num2 = 3;
				bool flag = num3 == 7;
				if (!flag)
				{
					goto IL_39;
				}
				IL_37:
				goto IL_9D;
				IL_39:
				num2 = 5;
				this.objData.DatabaseCommand("Delete From svrnums WHERE mobnum = '" + this.lblTelNum.Text + "'");
				IL_61:
				num2 = 6;
				Interaction.MsgBox("تم حذف الرقم" + this.lblTelNum.Text, MsgBoxStyle.Information, null);
				IL_81:
				num2 = 7;
				this.GetAllSmsfromDB();
				IL_8A:
				num2 = 8;
				this.lblTelNum.Text = "";
				IL_9D:
				goto IL_118;
				IL_9F:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_D1:
				goto IL_10D;
				IL_D3:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_EB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D3;
			}
			IL_10D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_118:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0400008C RID: 140
		private CData objData;

		// Token: 0x0400008D RID: 141
		private DataTable objDataTabletemp;

		// Token: 0x0400008E RID: 142
		private bool AutoFlag;

		// Token: 0x0400008F RID: 143
		private int CurrIndex;

		// Token: 0x04000090 RID: 144
		private string CLICODE;

		// Token: 0x04000091 RID: 145
		private string FileNamePath;
	}
}
