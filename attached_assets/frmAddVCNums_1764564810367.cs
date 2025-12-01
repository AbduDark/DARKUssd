using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MTUssd.My;

namespace MTUssd
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class frmAddVCNums : Form
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000025A7 File Offset: 0x000007A7
		public frmAddVCNums()
		{
			base.Load += this.frmAddVCNums_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000025C7 File Offset: 0x000007C7
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000D668 File Offset: 0x0000B868
		internal virtual Button btnAddFF
		{
			[CompilerGenerated]
			get
			{
				return this._btnAddFF;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddFF_Click);
				Button btnAddFF = this._btnAddFF;
				if (btnAddFF != null)
				{
					btnAddFF.Click -= value2;
				}
				this._btnAddFF = value;
				btnAddFF = this._btnAddFF;
				if (btnAddFF != null)
				{
					btnAddFF.Click += value2;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000025D1 File Offset: 0x000007D1
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000025DB File Offset: 0x000007DB
		internal virtual Label lblSavePath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000025E4 File Offset: 0x000007E4
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		internal virtual Button btnSaveAS
		{
			[CompilerGenerated]
			get
			{
				return this._btnSaveAS;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSaveAS_Click);
				Button btnSaveAS = this._btnSaveAS;
				if (btnSaveAS != null)
				{
					btnSaveAS.Click -= value2;
				}
				this._btnSaveAS = value;
				btnSaveAS = this._btnSaveAS;
				if (btnSaveAS != null)
				{
					btnSaveAS.Click += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000025EE File Offset: 0x000007EE
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		internal virtual Button btnExport2
		{
			[CompilerGenerated]
			get
			{
				return this._btnExport2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnExport2_Click);
				Button btnExport = this._btnExport2;
				if (btnExport != null)
				{
					btnExport.Click -= value2;
				}
				this._btnExport2 = value;
				btnExport = this._btnExport2;
				if (btnExport != null)
				{
					btnExport.Click += value2;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000D734 File Offset: 0x0000B934
		internal virtual Button cmbPaste
		{
			[CompilerGenerated]
			get
			{
				return this._cmbPaste;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbPaste_Click);
				Button cmbPaste = this._cmbPaste;
				if (cmbPaste != null)
				{
					cmbPaste.Click -= value2;
				}
				this._cmbPaste = value;
				cmbPaste = this._cmbPaste;
				if (cmbPaste != null)
				{
					cmbPaste.Click += value2;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002602 File Offset: 0x00000802
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000260C File Offset: 0x0000080C
		internal virtual Label lblCountPre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002615 File Offset: 0x00000815
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000D778 File Offset: 0x0000B978
		internal virtual Button btnClear
		{
			[CompilerGenerated]
			get
			{
				return this._btnClear;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnClear_Click);
				Button btnClear = this._btnClear;
				if (btnClear != null)
				{
					btnClear.Click -= value2;
				}
				this._btnClear = value;
				btnClear = this._btnClear;
				if (btnClear != null)
				{
					btnClear.Click += value2;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000261F File Offset: 0x0000081F
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		internal virtual Button btnDelOnePre
		{
			[CompilerGenerated]
			get
			{
				return this._btnDelOnePre;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDelOnePre_Click);
				Button btnDelOnePre = this._btnDelOnePre;
				if (btnDelOnePre != null)
				{
					btnDelOnePre.Click -= value2;
				}
				this._btnDelOnePre = value;
				btnDelOnePre = this._btnDelOnePre;
				if (btnDelOnePre != null)
				{
					btnDelOnePre.Click += value2;
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002629 File Offset: 0x00000829
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000D800 File Offset: 0x0000BA00
		internal virtual TextBox txtCardNew
		{
			[CompilerGenerated]
			get
			{
				return this._txtCardNew;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtCardNew_KeyPress);
				EventHandler value3 = new EventHandler(this.txtCardNew_TextChanged);
				TextBox txtCardNew = this._txtCardNew;
				if (txtCardNew != null)
				{
					txtCardNew.KeyPress -= value2;
					txtCardNew.TextChanged -= value3;
				}
				this._txtCardNew = value;
				txtCardNew = this._txtCardNew;
				if (txtCardNew != null)
				{
					txtCardNew.KeyPress += value2;
					txtCardNew.TextChanged += value3;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002633 File Offset: 0x00000833
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000263D File Offset: 0x0000083D
		internal virtual ComboBox cmbColom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002646 File Offset: 0x00000846
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000D860 File Offset: 0x0000BA60
		internal virtual Button btnDel
		{
			[CompilerGenerated]
			get
			{
				return this._btnDel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDel_Click);
				Button btnDel = this._btnDel;
				if (btnDel != null)
				{
					btnDel.Click -= value2;
				}
				this._btnDel = value;
				btnDel = this._btnDel;
				if (btnDel != null)
				{
					btnDel.Click += value2;
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002650 File Offset: 0x00000850
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		internal virtual ListBox lstB1
		{
			[CompilerGenerated]
			get
			{
				return this._lstB1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lstB1_SelectedIndexChanged);
				ListBox lstB = this._lstB1;
				if (lstB != null)
				{
					lstB.SelectedIndexChanged -= value2;
				}
				this._lstB1 = value;
				lstB = this._lstB1;
				if (lstB != null)
				{
					lstB.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000265A File Offset: 0x0000085A
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		internal virtual ListBox lstB2
		{
			[CompilerGenerated]
			get
			{
				return this._lstB2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lstB2_SelectedIndexChanged);
				ListBox lstB = this._lstB2;
				if (lstB != null)
				{
					lstB.SelectedIndexChanged -= value2;
				}
				this._lstB2 = value;
				lstB = this._lstB2;
				if (lstB != null)
				{
					lstB.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002664 File Offset: 0x00000864
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000266E File Offset: 0x0000086E
		internal virtual Label lblC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002677 File Offset: 0x00000877
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002681 File Offset: 0x00000881
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000268A File Offset: 0x0000088A
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002694 File Offset: 0x00000894
		internal virtual SaveFileDialog SFD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000269D File Offset: 0x0000089D
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000026A7 File Offset: 0x000008A7
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000026B0 File Offset: 0x000008B0
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000026BA File Offset: 0x000008BA
		internal virtual ListBox lstNumbers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000026C3 File Offset: 0x000008C3
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000026CD File Offset: 0x000008CD
		internal virtual ProgressBar PB1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000026D6 File Offset: 0x000008D6
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000D92C File Offset: 0x0000BB2C
		internal virtual Button btnExport
		{
			[CompilerGenerated]
			get
			{
				return this._btnExport;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnExport_Click);
				Button btnExport = this._btnExport;
				if (btnExport != null)
				{
					btnExport.Click -= value2;
				}
				this._btnExport = value;
				btnExport = this._btnExport;
				if (btnExport != null)
				{
					btnExport.Click += value2;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000026E0 File Offset: 0x000008E0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000D970 File Offset: 0x0000BB70
		internal virtual Button btnOpen
		{
			[CompilerGenerated]
			get
			{
				return this._btnOpen;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOpen_Click);
				Button btnOpen = this._btnOpen;
				if (btnOpen != null)
				{
					btnOpen.Click -= value2;
				}
				this._btnOpen = value;
				btnOpen = this._btnOpen;
				if (btnOpen != null)
				{
					btnOpen.Click += value2;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000026EA File Offset: 0x000008EA
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000026F4 File Offset: 0x000008F4
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000026FE File Offset: 0x000008FE
		internal virtual Label lblTelNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002707 File Offset: 0x00000907
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002711 File Offset: 0x00000911
		internal virtual Label lblCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000271A File Offset: 0x0000091A
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002724 File Offset: 0x00000924
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000272D File Offset: 0x0000092D
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002737 File Offset: 0x00000937
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		internal virtual Button btnDelNums
		{
			[CompilerGenerated]
			get
			{
				return this._btnDelNums;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDelNums_Click);
				Button btnDelNums = this._btnDelNums;
				if (btnDelNums != null)
				{
					btnDelNums.Click -= value2;
				}
				this._btnDelNums = value;
				btnDelNums = this._btnDelNums;
				if (btnDelNums != null)
				{
					btnDelNums.Click += value2;
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002741 File Offset: 0x00000941
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000DA80 File Offset: 0x0000BC80
		internal virtual Button btnNewnums
		{
			[CompilerGenerated]
			get
			{
				return this._btnNewnums;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnNewnums_Click);
				Button btnNewnums = this._btnNewnums;
				if (btnNewnums != null)
				{
					btnNewnums.Click -= value2;
				}
				this._btnNewnums = value;
				btnNewnums = this._btnNewnums;
				if (btnNewnums != null)
				{
					btnNewnums.Click += value2;
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000274B File Offset: 0x0000094B
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		internal virtual TextBox txtDail
		{
			[CompilerGenerated]
			get
			{
				return this._txtDail;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtDail_KeyPress);
				EventHandler value3 = new EventHandler(this.txtDail_TextChanged);
				TextBox txtDail = this._txtDail;
				if (txtDail != null)
				{
					txtDail.KeyPress -= value2;
					txtDail.TextChanged -= value3;
				}
				this._txtDail = value;
				txtDail = this._txtDail;
				if (txtDail != null)
				{
					txtDail.KeyPress += value2;
					txtDail.TextChanged += value3;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002755 File Offset: 0x00000955
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000275F File Offset: 0x0000095F
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002768 File Offset: 0x00000968
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000DB24 File Offset: 0x0000BD24
		internal virtual TextBox txtEnumSH
		{
			[CompilerGenerated]
			get
			{
				return this._txtEnumSH;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.txtEnumSH_KeyPress);
				EventHandler value3 = new EventHandler(this.txtEnumSH_TextChanged);
				TextBox txtEnumSH = this._txtEnumSH;
				if (txtEnumSH != null)
				{
					txtEnumSH.KeyPress -= value2;
					txtEnumSH.TextChanged -= value3;
				}
				this._txtEnumSH = value;
				txtEnumSH = this._txtEnumSH;
				if (txtEnumSH != null)
				{
					txtEnumSH.KeyPress += value2;
					txtEnumSH.TextChanged += value3;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002772 File Offset: 0x00000972
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000277C File Offset: 0x0000097C
		internal virtual OpenFileDialog ODfile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002785 File Offset: 0x00000985
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000DB84 File Offset: 0x0000BD84
		internal virtual Button btnADDAuto
		{
			[CompilerGenerated]
			get
			{
				return this._btnADDAuto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnADDAuto_Click);
				Button btnADDAuto = this._btnADDAuto;
				if (btnADDAuto != null)
				{
					btnADDAuto.Click -= value2;
				}
				this._btnADDAuto = value;
				btnADDAuto = this._btnADDAuto;
				if (btnADDAuto != null)
				{
					btnADDAuto.Click += value2;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000278F File Offset: 0x0000098F
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		internal virtual Button btnSaveFromOut
		{
			[CompilerGenerated]
			get
			{
				return this._btnSaveFromOut;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSaveFromOut_Click);
				Button btnSaveFromOut = this._btnSaveFromOut;
				if (btnSaveFromOut != null)
				{
					btnSaveFromOut.Click -= value2;
				}
				this._btnSaveFromOut = value;
				btnSaveFromOut = this._btnSaveFromOut;
				if (btnSaveFromOut != null)
				{
					btnSaveFromOut.Click += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002799 File Offset: 0x00000999
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000DC0C File Offset: 0x0000BE0C
		internal virtual Button btnTransfer
		{
			[CompilerGenerated]
			get
			{
				return this._btnTransfer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTransfer_Click);
				Button btnTransfer = this._btnTransfer;
				if (btnTransfer != null)
				{
					btnTransfer.Click -= value2;
				}
				this._btnTransfer = value;
				btnTransfer = this._btnTransfer;
				if (btnTransfer != null)
				{
					btnTransfer.Click += value2;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000027A3 File Offset: 0x000009A3
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000027AD File Offset: 0x000009AD
		internal virtual TextBox txtGroupQty { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000027B6 File Offset: 0x000009B6
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000027C0 File Offset: 0x000009C0
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000027C9 File Offset: 0x000009C9
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000DC50 File Offset: 0x0000BE50
		internal virtual Button btnAddFromWebServer
		{
			[CompilerGenerated]
			get
			{
				return this._btnAddFromWebServer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddFromWebServer_Click);
				Button btnAddFromWebServer = this._btnAddFromWebServer;
				if (btnAddFromWebServer != null)
				{
					btnAddFromWebServer.Click -= value2;
				}
				this._btnAddFromWebServer = value;
				btnAddFromWebServer = this._btnAddFromWebServer;
				if (btnAddFromWebServer != null)
				{
					btnAddFromWebServer.Click += value2;
				}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000DC94 File Offset: 0x0000BE94
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

		// Token: 0x06000104 RID: 260 RVA: 0x0000DD44 File Offset: 0x0000BF44
		private int GetNextenums()
		{
			int num;
			int result;
			int num5;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT distinct enums FROM vcnums order by enums");
				IL_23:
				num2 = 3;
				checked
				{
					int num3 = this.objDataTabletemp.Rows.Count - 1;
					IL_39:
					num2 = 4;
					bool flag = num3 >= 0;
					if (!flag)
					{
						IL_88:
						num2 = 7;
						result = 1;
						goto IL_8F;
					}
					IL_49:
					num2 = 5;
					result = (int)Math.Round(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[num3]["enums"])) + 1.0));
					IL_8F:
					goto IL_10A;
					IL_84:
					IL_8E:
					goto IL_8F;
					IL_91:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_C3:
				goto IL_FF;
				IL_C5:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_DD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_C5;
			}
			IL_FF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_10A:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000DE78 File Offset: 0x0000C078
		private void AddTelNum(string cardIDx)
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
				string text = "Insert Into vcnums ";
				IL_13:
				num2 = 3;
				text += "(enums,evalue,mobnum)";
				IL_21:
				num2 = 4;
				text += "Values (";
				IL_2F:
				num2 = 5;
				text = text + " " + Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)) + " , ";
				IL_57:
				num2 = 6;
				text += " 0 , ";
				IL_65:
				num2 = 7;
				text = text + "'" + cardIDx + "') ";
				IL_79:
				num2 = 8;
				this.objData.DatabaseCommand(text);
				IL_88:
				goto IL_103;
				IL_8A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_BC:
				goto IL_F8;
				IL_BE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_D6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_BE;
			}
			IL_F8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_103:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		private void Addtelnumber()
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
				this.txtDail.BackColor = Color.White;
				IL_1E:
				num2 = 3;
				bool flag = Conversion.Val(this.txtEnumSH.Text) <= 0.0;
				if (!flag)
				{
					goto IL_6B;
				}
				IL_42:
				num2 = 4;
				Interaction.MsgBox("اكمل الخانات اللازمة من فضلك", MsgBoxStyle.Critical, null);
				IL_52:
				num2 = 5;
				this.txtDail.BackColor = Color.PaleVioletRed;
				IL_65:
				goto IL_175;
				IL_6B:
				IL_6C:
				num2 = 8;
				bool flag2 = this.txtDail.Text.Trim().Length <= 0 & this.btnADDAuto.Enabled;
				if (!flag2)
				{
					goto IL_C6;
				}
				IL_9B:
				num2 = 9;
				Interaction.MsgBox("الرقم غير سليم", MsgBoxStyle.Critical, null);
				IL_AC:
				num2 = 10;
				this.txtDail.BackColor = Color.PaleVioletRed;
				IL_C0:
				goto IL_175;
				IL_C6:
				IL_C7:
				num2 = 13;
				bool enabled = this.btnADDAuto.Enabled;
				if (!enabled)
				{
					goto IL_113;
				}
				IL_DB:
				num2 = 14;
				bool flag3 = this.chktelNumFound(this.txtDail.Text.Trim());
				if (!flag3)
				{
					goto IL_111;
				}
				IL_FA:
				num2 = 15;
				this.txtDail.BackColor = Color.PaleVioletRed;
				IL_10E:
				goto IL_175;
				IL_111:
				IL_112:
				IL_113:
				IL_114:
				num2 = 19;
				this.AddTelNum(this.txtDail.Text.Trim());
				IL_12E:
				num2 = 20;
				bool enabled2 = this.btnADDAuto.Enabled;
				if (!enabled2)
				{
					goto IL_161;
				}
				IL_142:
				num2 = 21;
				this.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)));
				IL_161:
				num2 = 22;
				this.txtDail.BackColor = Color.PaleGreen;
				IL_175:
				goto IL_22B;
				IL_6A:
				goto IL_6B;
				IL_C5:
				goto IL_C6;
				IL_110:
				goto IL_111;
				IL_17A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1E4:
				goto IL_220;
				IL_1E6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_1FE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1E6;
			}
			IL_220:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_22B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000E204 File Offset: 0x0000C404
		private bool chktelNumFound(string eetel)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT * FROM vcnums where  mobnum = '" + eetel + "'");
				IL_2E:
				num2 = 3;
				bool flag = this.objDataTabletemp.Rows.Count > 0;
				if (!flag)
				{
					goto IL_91;
				}
				IL_49:
				num2 = 4;
				bool flag2 = !this.AutoFlag;
				if (!flag2)
				{
					goto IL_8A;
				}
				IL_5A:
				num2 = 5;
				Interaction.MsgBox(Operators.ConcatenateObject("الرقم موجود من قبل بالحركة رقم \r\n", this.objDataTabletemp.Rows[0]["enums"]), MsgBoxStyle.Critical, null);
				IL_8A:
				num2 = 6;
				result = true;
				goto IL_98;
				IL_91:
				IL_92:
				num2 = 8;
				result = false;
				IL_98:
				goto IL_113;
				IL_90:
				goto IL_91;
				IL_9A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_CC:
				goto IL_108;
				IL_CE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_E6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_CE;
			}
			IL_108:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_113:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000E340 File Offset: 0x0000C540
		private void GetAllSmsfromDB(string eeDB)
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
				dataTable.Columns.Add("اخر امر تشغيل");
				IL_41:
				num2 = 5;
				IL_46:
				num2 = 6;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
				IL_73:
				num2 = 7;
				bool flag = this.objDataTabletemp.Rows.Count > 0;
				if (!flag)
				{
					goto IL_13A;
				}
				IL_91:
				num2 = 8;
				checked
				{
					int num3 = this.objDataTabletemp.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_AE:
						num2 = 9;
						DataRow dataRow = dataTable.NewRow();
						IL_BA:
						num2 = 10;
						dataRow[0] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["mobnum"]);
						IL_E6:
						num2 = 11;
						dataRow[1] = RuntimeHelpers.GetObjectValue(this.objDataTabletemp.Rows[i]["evalue"]);
						IL_112:
						num2 = 12;
						dataTable.Rows.Add(dataRow);
						IL_124:
						num2 = 13;
						dataRow = null;
						IL_12A:
						num2 = 14;
					}
					IL_139:
					IL_13A:
					IL_13B:
					num2 = 16;
					this.lblCount.Text = Conversions.ToString(this.objDataTabletemp.Rows.Count);
					IL_15F:
					num2 = 17;
					this.dataViewGrid.DataSource = dataTable;
					IL_170:
					num2 = 18;
					this.dataViewGrid.Columns[0].Width = 160;
					IL_18F:
					num2 = 19;
					this.dataViewGrid.Columns[1].Width = 160;
					IL_1AE:
					goto IL_258;
					IL_1B3:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_211:
				goto IL_24D;
				IL_213:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_22B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_213;
			}
			IL_24D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_258:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		private void GetAllSmsfromWWDB(string eeDB)
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
				IL_10:
				num2 = 3;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
				IL_3D:
				num2 = 4;
				bool flag = this.objDataTabletemp.Rows.Count > 0;
				if (!flag)
				{
					goto IL_A7;
				}
				IL_58:
				num2 = 5;
				checked
				{
					int num3 = this.objDataTabletemp.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_72:
						num2 = 6;
						this.AddBoxToLstPreXC(Conversions.ToString(this.objDataTabletemp.Rows[i]["mobnum"]));
						IL_9B:
						num2 = 7;
					}
					IL_A6:
					IL_A7:
					IL_A8:
					goto IL_123;
					IL_AA:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_DC:
				goto IL_118;
				IL_DE:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_F6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_DE;
			}
			IL_118:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_123:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000E718 File Offset: 0x0000C918
		private void GetAllSmsfromDBExc(string eeDB)
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
				IL_10:
				num2 = 3;
				this.objDataTabletemp = this.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
				IL_3D:
				num2 = 4;
				bool flag = this.objDataTabletemp.Rows.Count > 0;
				if (!flag)
				{
					goto IL_A7;
				}
				IL_58:
				num2 = 5;
				checked
				{
					int num3 = this.objDataTabletemp.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_72:
						num2 = 6;
						this.AddBoxToLstPreXC(Conversions.ToString(this.objDataTabletemp.Rows[i]["mobnum"]));
						IL_9B:
						num2 = 7;
					}
					IL_A6:
					IL_A7:
					IL_A8:
					num2 = 9;
					this.lblCount.Text = Conversions.ToString(this.objDataTabletemp.Rows.Count);
					IL_CC:
					goto IL_14B;
					IL_CE:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_104:
				goto IL_140;
				IL_106:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_11E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_106;
			}
			IL_140:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_14B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000E898 File Offset: 0x0000CA98
		private void txtDail_KeyPress(object sender, KeyPressEventArgs e)
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
				bool flag = Strings.Asc(e.KeyChar) == 13;
				if (!flag)
				{
					goto IL_7C;
				}
				IL_20:
				num2 = 3;
				bool flag2 = this.txtDail.Text.Trim().Length > 0;
				if (!flag2)
				{
					goto IL_7A;
				}
				IL_40:
				num2 = 4;
				this.Addtelnumber();
				IL_49:
				num2 = 5;
				bool flag3 = this.txtDail.BackColor == Color.PaleGreen;
				if (!flag3)
				{
					goto IL_79;
				}
				IL_66:
				num2 = 6;
				this.txtDail.Text = "";
				IL_79:
				IL_7A:
				IL_7B:
				IL_7C:
				IL_7D:
				goto IL_F8;
				IL_7F:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_B1:
				goto IL_ED;
				IL_B3:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_CB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B3;
			}
			IL_ED:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F8:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		private void frmAddVCNums_Load(object sender, EventArgs e)
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
				this.btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e);
				IL_24:
				num2 = 4;
				this.AutoFlag = false;
				IL_2D:
				num2 = 5;
				this.cmbColom.SelectedIndex = 0;
				IL_3C:
				goto IL_AB;
				IL_3E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_64:
				goto IL_A0;
				IL_66:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_7E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_66;
			}
			IL_A0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_AB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		private void btnNewnums_Click(object sender, EventArgs e)
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
				this.txtEnumSH.Text = Conversions.ToString(this.GetNextenums());
				IL_24:
				num2 = 3;
				this.GetAllSmsfromDB(this.txtEnumSH.Text);
				IL_38:
				goto IL_9F;
				IL_3A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_58:
				goto IL_94;
				IL_5A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_72:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5A;
			}
			IL_94:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000EB54 File Offset: 0x0000CD54
		private void btnDelNums_Click(object sender, EventArgs e)
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
				int num3 = (int)Interaction.MsgBox("هل  تريد حذف رقم حركة ادخال رقم" + this.txtEnumSH.Text + "\r\n وعددهم " + this.lblCount.Text, MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
				IL_3B:
				num2 = 3;
				bool flag = num3 == 7;
				if (!flag)
				{
					goto IL_49;
				}
				IL_47:
				goto IL_76;
				IL_49:
				num2 = 5;
				this.objData.DatabaseCommand("Delete From vcnums WHERE enums = " + Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)));
				IL_76:
				goto IL_E5;
				IL_78:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_9E:
				goto IL_DA;
				IL_A0:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_B8:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A0;
			}
			IL_DA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E5:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000EC60 File Offset: 0x0000CE60
		private void txtEnumSH_KeyPress(object sender, KeyPressEventArgs e)
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
				bool flag = Strings.Asc(e.KeyChar) == 13;
				if (!flag)
				{
					goto IL_5A;
				}
				IL_20:
				num2 = 3;
				bool flag2 = Conversion.Val(this.txtEnumSH.Text) > 0.0;
				if (!flag2)
				{
					goto IL_58;
				}
				IL_43:
				num2 = 4;
				this.GetAllSmsfromDB(this.txtEnumSH.Text);
				IL_57:
				IL_58:
				IL_59:
				IL_5A:
				IL_5B:
				num2 = 7;
				bool flag3 = Strings.Asc(e.KeyChar) != 8;
				if (!flag3)
				{
					goto IL_A6;
				}
				IL_74:
				num2 = 8;
				bool flag4 = Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57;
				if (!flag4)
				{
					goto IL_A6;
				}
				IL_9B:
				num2 = 9;
				e.KeyChar = '\0';
				IL_A6:
				goto IL_125;
				IL_A8:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_DE:
				goto IL_11A;
				IL_E0:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_F8:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_E0;
			}
			IL_11A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_125:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000EDAC File Offset: 0x0000CFAC
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

		// Token: 0x06000111 RID: 273 RVA: 0x0000EE6C File Offset: 0x0000D06C
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
				goto IL_A8;
				IL_39:
				num2 = 5;
				this.objData.DatabaseCommand("Delete From vcnums WHERE mobnum = '" + this.lblTelNum.Text + "'");
				IL_61:
				num2 = 6;
				Interaction.MsgBox("تم حذف الرقم" + this.lblTelNum.Text, MsgBoxStyle.Information, null);
				IL_81:
				num2 = 7;
				this.GetAllSmsfromDB(this.txtEnumSH.Text);
				IL_95:
				num2 = 8;
				this.lblTelNum.Text = "";
				IL_A8:
				goto IL_123;
				IL_AA:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_DC:
				goto IL_118;
				IL_DE:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_F6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_DE;
			}
			IL_118:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_123:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		private void btnADDAuto_Click(object sender, EventArgs e)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				int num3 = 0;
				IL_0F:
				num2 = 3;
				int num4 = (int)Interaction.MsgBox("هل تريد اضافة الارقام المحددة  الى النظام", MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
				IL_20:
				num2 = 4;
				bool flag = num4 == 7;
				if (!flag)
				{
					goto IL_32;
				}
				IL_2D:
				goto IL_126;
				IL_32:
				num2 = 6;
				this.AutoFlag = true;
				IL_3B:
				num2 = 7;
				this.btnADDAuto.Enabled = false;
				IL_4A:
				for (;;)
				{
					IL_BA:
					num2 = 9;
					bool flag2 = num3 >= this.lstNumbers.Items.Count;
					if (flag2)
					{
						break;
					}
					IL_4C:
					num2 = 10;
					this.txtDail.Text = Conversions.ToString(this.lstNumbers.Items[num3]);
					IL_71:
					num2 = 11;
					this.Addtelnumber();
					IL_7B:
					num2 = 12;
					checked
					{
						num3++;
						IL_82:
						num2 = 13;
					}
					this.lblCount.Text = Conversions.ToString(Conversion.Val(this.lblCount.Text) + 1.0);
					IL_B0:
					num2 = 14;
					Application.DoEvents();
					IL_B9:;
				}
				IL_DC:
				num2 = 16;
				this.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)));
				IL_FB:
				num2 = 17;
				Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information, null);
				IL_10C:
				num2 = 18;
				this.AutoFlag = false;
				IL_116:
				num2 = 19;
				this.btnADDAuto.Enabled = true;
				IL_126:
				goto IL_1D0;
				IL_12B:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_189:
				goto IL_1C5;
				IL_18B:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_1A3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_18B;
			}
			IL_1C5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1D0:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		private void btnDelOnePre_Click(object sender, EventArgs e)
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
				bool flag = this.lstNumbers.SelectedItems.Count > 0;
				if (!flag)
				{
					goto IL_66;
				}
				IL_24:
				num2 = 3;
				this.lstNumbers.Items.RemoveAt(this.lstNumbers.SelectedIndex);
				IL_42:
				num2 = 4;
				this.lblCountPre.Text = Conversions.ToString(this.lstNumbers.Items.Count);
				IL_65:
				IL_66:
				IL_67:
				goto IL_D6;
				IL_69:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_8F:
				goto IL_CB;
				IL_91:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_A9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_91;
			}
			IL_CB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_D6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private void btnClear_Click(object sender, EventArgs e)
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
				this.lstNumbers.Items.Clear();
				IL_1E:
				num2 = 3;
				this.lblCountPre.Text = "0";
				IL_31:
				goto IL_98;
				IL_33:
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

		// Token: 0x06000115 RID: 277 RVA: 0x0000F378 File Offset: 0x0000D578
		private void txtCardNew_KeyPress(object sender, KeyPressEventArgs e)
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
				bool flag = Strings.Asc(e.KeyChar) == 13;
				if (!flag)
				{
					goto IL_BC;
				}
				IL_23:
				num2 = 3;
				bool flag2 = this.txtCardNew.Text.Trim().Length > 0;
				if (!flag2)
				{
					goto IL_BA;
				}
				IL_43:
				num2 = 4;
				this.txtCardNew.BackColor = Color.White;
				IL_56:
				num2 = 5;
				bool flag3 = this.chktelNumFound(this.txtCardNew.Text.Trim());
				if (!flag3)
				{
					goto IL_8A;
				}
				IL_74:
				num2 = 6;
				this.txtCardNew.BackColor = Color.PaleVioletRed;
				IL_87:
				goto IL_BD;
				IL_8A:
				IL_8B:
				num2 = 9;
				this.AddBoxToLstPre(this.txtCardNew.Text.Trim());
				IL_A5:
				num2 = 10;
				this.txtCardNew.Text = "";
				IL_B9:
				IL_BA:
				IL_BB:
				IL_BC:
				IL_BD:
				goto IL_14B;
				IL_89:
				goto IL_8A;
				IL_C2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_104:
				goto IL_140;
				IL_106:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_11E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_106;
			}
			IL_140:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_14B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		private void AddBoxToLstPre(string EER)
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
				int num3 = 0;
				IL_0F:
				num2 = 3;
				bool flag = EER.Length > 0;
				if (!flag)
				{
					IL_37:
					goto IL_71;
				}
				IL_20:
				num2 = 4;
				bool flag2 = this.chktelNumFound(EER);
				if (!flag2)
				{
					goto IL_32;
				}
				IL_2F:
				goto IL_71;
				IL_32:
				IL_33:
				IL_3A:
				num2 = 10;
				num3 = this.lstNumbers.FindString(EER);
				IL_4A:
				num2 = 11;
				bool flag3 = num3 >= 0;
				if (!flag3)
				{
					goto IL_5C;
				}
				IL_5A:
				goto IL_71;
				IL_5C:
				num2 = 13;
				this.lstNumbers.Items.Add(EER);
				IL_71:
				IL_72:
				num2 = 14;
				this.lblCountPre.Text = Conversions.ToString(this.lstNumbers.Items.Count);
				IL_96:
				num2 = 15;
				Application.DoEvents();
				IL_9F:
				goto IL_139;
				IL_31:
				IL_39:
				goto IL_3A;
				IL_A4:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_F2:
				goto IL_12E;
				IL_F4:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_10C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_F4;
			}
			IL_12E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_139:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000F664 File Offset: 0x0000D864
		private void AddBoxToLstPreXC(string EER)
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
				int num3 = 0;
				IL_0F:
				num2 = 3;
				num3 = this.lstNumbers.FindString(EER);
				IL_1E:
				num2 = 4;
				bool flag = num3 >= 0;
				if (!flag)
				{
					goto IL_2F;
				}
				IL_2D:
				goto IL_43;
				IL_2F:
				num2 = 6;
				this.lstNumbers.Items.Add(EER);
				IL_43:
				IL_44:
				num2 = 7;
				this.lblCountPre.Text = Conversions.ToString(this.lstNumbers.Items.Count);
				IL_67:
				num2 = 8;
				Application.DoEvents();
				IL_6F:
				goto IL_EA;
				IL_71:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_A3:
				goto IL_DF;
				IL_A5:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_BD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A5;
			}
			IL_DF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_EA:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000027D3 File Offset: 0x000009D3
		private void btnOpen_Click(object sender, EventArgs e)
		{
			this.OpenFileLoc();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000F774 File Offset: 0x0000D974
		private void btnDel_Click(object sender, EventArgs e)
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
				bool flag = this.lstB1.SelectedIndex >= 0;
				if (!flag)
				{
					goto IL_AB;
				}
				IL_25:
				num2 = 3;
				this.lblC.Text = Conversions.ToString(Conversion.Val(this.lblC.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.lstB2.Items[this.lstB2.SelectedIndex])));
				IL_6E:
				num2 = 4;
				this.lstB1.Items.RemoveAt(this.lstB1.SelectedIndex);
				IL_8C:
				num2 = 5;
				this.lstB2.Items.RemoveAt(this.lstB2.SelectedIndex);
				IL_AA:
				IL_AB:
				IL_AC:
				goto IL_11F;
				IL_AE:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_D8:
				goto IL_114;
				IL_DA:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_F2:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_DA;
			}
			IL_114:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_11F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000F8BC File Offset: 0x0000DABC
		private void lstB2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.lstB2.SelectedIndex >= 0;
			if (flag)
			{
				this.lstB1.SelectedIndex = this.lstB2.SelectedIndex;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		private void lstB1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.lstB1.SelectedIndex >= 0;
			if (flag)
			{
				this.lstB2.SelectedIndex = this.lstB1.SelectedIndex;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000F934 File Offset: 0x0000DB34
		private void OpenFileLoc()
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
				this.ODfile.Title = "Open File";
				IL_1E:
				num2 = 3;
				this.ODfile.Filter = "Excel - (*.xls;*.xlsx)|*.xls;*.xlsx";
				IL_31:
				num2 = 4;
				this.ODfile.FilterIndex = 1;
				IL_40:
				num2 = 5;
				this.ODfile.Multiselect = false;
				IL_4F:
				num2 = 6;
				bool flag = this.ODfile.ShowDialog() == DialogResult.OK;
				if (!flag)
				{
					goto IL_BE;
				}
				IL_63:
				num2 = 7;
				bool flag2 = Strings.Len(this.ODfile.FileName) > 2;
				if (!flag2)
				{
					goto IL_BC;
				}
				IL_7E:
				num2 = 8;
				this.FileNamePath = this.ODfile.FileName;
				IL_91:
				num2 = 9;
				this.btnOpen.Enabled = false;
				IL_A1:
				num2 = 10;
				this.OpenExcelFileToprocess();
				IL_AB:
				num2 = 11;
				this.btnOpen.Enabled = true;
				IL_BB:
				IL_BC:
				IL_BD:
				IL_BE:
				IL_BF:
				goto IL_151;
				IL_C4:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_10A:
				goto IL_146;
				IL_10C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_124:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10C;
			}
			IL_146:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_151:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		private void DoExcelImport()
		{
			checked
			{
				int num;
				int num5;
				object obj3;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int num2 = 0;
					this.Cursor = Cursors.WaitCursor;
					this.PB1.Minimum = 0;
					this.PB1.Value = 0;
					this.PB1.Maximum = (int)Math.Round(Conversion.Val(this.lblC.Text));
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""));
					object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
					Type type = null;
					string memberName = "Open";
					object[] array = new object[1];
					int num3 = 0;
					ref string ptr = ref this.FileNamePath;
					array[num3] = this.FileNamePath;
					object[] array2 = array;
					bool[] array3;
					object obj = NewLateBinding.LateGet(instance, type, memberName, array, null, null, array3 = new bool[]
					{
						true
					});
					if (array3[0])
					{
						ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
					NewLateBinding.LateSet(objectValue, null, "DisplayAlerts", new object[]
					{
						false
					}, null, null);
					object objectValue3;
					long num4;
					bool flag3;
					do
					{
						ListBox.ObjectCollection items;
						int index;
						object obj2 = NewLateBinding.LateGet(objectValue2, null, "Worksheets", array2 = new object[]
						{
							(items = this.lstB1.Items)[index = num2]
						}, null, null, array3 = new bool[]
						{
							true
						});
						if (array3[0])
						{
							items[index] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
						}
						objectValue3 = RuntimeHelpers.GetObjectValue(obj2);
						num4 = 1L;
						for (;;)
						{
							bool flag = Operators.ConditionalCompareObjectGreater(num4, this.lstB2.Items[num2], false);
							if (flag)
							{
								break;
							}
							bool flag2 = !Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Range", new object[]
							{
								this.cmbColom.Text + num4.ToString()
							}, null, null, null), null, "value", new object[0], null, null, null)));
							if (flag2)
							{
								string eer = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Range", new object[]
								{
									this.cmbColom.Text + num4.ToString()
								}, null, null, null), null, "value", new object[0], null, null, null).ToString().Trim();
								this.AddBoxToLstPre(eer);
							}
							ProgressBar pb;
							(pb = this.PB1).Value = pb.Value + 1;
							Application.DoEvents();
							num4 += 1L;
						}
						num2++;
						flag3 = (num2 < this.lstB2.Items.Count & Information.Err().Number == 0);
					}
					while (flag3);
					NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, true);
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3));
					this.Cursor = Cursors.Default;
					bool flag4 = num4 > 3L;
					if (flag4)
					{
						Interaction.MsgBox("تم استيراد جميع الارقام بنجاح", MsgBoxStyle.Information, null);
					}
					IL_38E:
					goto IL_3D1;
					IL_373:
					this.Cursor = Cursors.Default;
					Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical, null);
					goto IL_38E;
					IL_390:
					num5 = -1;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_3A4:;
				}
				catch when (endfilter(obj3 is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj4;
					goto IL_390;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_3D1:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		private void OpenExcelFileToprocess()
		{
			int num;
			int num6;
			object obj3;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				long num2 = 1L;
				double num3 = 1.0;
				double num4 = 0.0;
				bool flag = Operators.CompareString(this.FileNamePath.Trim(), "", false) == 0;
				if (!flag)
				{
					this.Cursor = Cursors.WaitCursor;
					object obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""));
					object instance = NewLateBinding.LateGet(obj, null, "Workbooks", new object[0], null, null, null);
					Type type = null;
					string memberName = "Open";
					object[] array = new object[1];
					int num5 = 0;
					ref string ptr = ref this.FileNamePath;
					array[num5] = this.FileNamePath;
					object[] array2 = array;
					bool[] array3;
					object obj2 = NewLateBinding.LateGet(instance, type, memberName, array, null, null, array3 = new bool[]
					{
						true
					});
					if (array3[0])
					{
						ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					NewLateBinding.LateSet(obj, null, "DisplayAlerts", new object[]
					{
						false
					}, null, null);
					num2 = 1L;
					this.lblC.Text = "0";
					this.lstB1.Items.Clear();
					this.lstB2.Items.Clear();
					num4 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Worksheets", new object[0], null, null, null), null, "count", new object[0], null, null, null));
					object objectValue2;
					for (;;)
					{
						obj2 = NewLateBinding.LateGet(objectValue, null, "Worksheets", array2 = new object[]
						{
							num3
						}, null, null, array3 = new bool[]
						{
							true
						});
						if (array3[0])
						{
							num3 = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(double));
						}
						objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
						checked
						{
							for (;;)
							{
								bool flag2 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Range", new object[]
								{
									this.cmbColom.Text + num2.ToString()
								}, null, null, null), null, "value", new object[0], null, null, null).ToString().Trim().Length < 4;
								if (flag2)
								{
									break;
								}
								num2 += 1L;
							}
							IL_242:
							num2 -= 1L;
							bool flag3 = num2 > 1L;
							if (flag3)
							{
								this.lstB1.Items.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "name", new object[0], null, null, null)));
								this.lstB2.Items.Add(num2);
							}
						}
						num3 += 1.0;
						this.lblC.Text = Conversions.ToString(Conversion.Val(this.lblC.Text) + (double)num2);
						bool flag4 = Conversion.Val(this.lblC.Text) < 0.0;
						if (flag4)
						{
							this.lblC.Text = "0";
						}
						bool flag5 = num3 <= num4 & Information.Err().Number == 0;
						if (!flag5)
						{
							break;
						}
						num2 = 1L;
					}
					NewLateBinding.LateCall(objectValue, null, "Close", new object[0], null, null, null, true);
					this.releaseObject(RuntimeHelpers.GetObjectValue(obj));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
					obj = null;
					this.Cursor = Cursors.Default;
				}
				goto IL_3B8;
				IL_377:
				num6 = -1;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_38B:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_377;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3B8:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000B3A4 File Offset: 0x000095A4
		private void releaseObject(object obj)
		{
			try
			{
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
			}
			finally
			{
				bool flag = obj != null;
				if (flag)
				{
					int generation = GC.GetGeneration(RuntimeHelpers.GetObjectValue(obj));
					GC.Collect(generation);
				}
				else
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
				}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000102A8 File Offset: 0x0000E4A8
		private void btnExport_Click(object sender, EventArgs e)
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
				bool flag = Conversion.Val(this.lblC.Text) > 0.0;
				if (!flag)
				{
					IL_57:
					num2 = 7;
					Interaction.MsgBox("لا يوجد ارقام للتنفيذ", MsgBoxStyle.Critical, null);
					IL_67:
					goto IL_68;
				}
				IL_2C:
				num2 = 3;
				this.btnExport.Enabled = false;
				IL_3B:
				num2 = 4;
				this.DoExcelImport();
				IL_44:
				num2 = 5;
				this.btnExport.Enabled = true;
				IL_53:
				IL_68:
				goto IL_E3;
				IL_6A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_9C:
				goto IL_D8;
				IL_9E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_B6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_9E;
			}
			IL_D8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000103B4 File Offset: 0x0000E5B4
		private void cmbPaste_Click(object sender, EventArgs e)
		{
			string text = Clipboard.GetText();
			bool flag = text.Trim().Length > 0;
			if (flag)
			{
				this.txtDail.Text = text.Trim();
				Clipboard.Clear();
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000103F4 File Offset: 0x0000E5F4
		private string OpensaveAs(string tempFilename)
		{
			int num;
			string result;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.SFD.Title = "Save File AS";
				IL_1E:
				num2 = 3;
				this.SFD.Filter = "Excel - (*.xls)|*.xls";
				IL_31:
				num2 = 4;
				this.SFD.FilterIndex = 1;
				IL_40:
				num2 = 5;
				this.SFD.FileName = tempFilename;
				IL_4F:
				num2 = 6;
				bool flag = this.SFD.ShowDialog() == DialogResult.OK;
				if (!flag)
				{
					goto IL_95;
				}
				IL_65:
				num2 = 7;
				bool flag2 = Strings.Len(this.SFD.FileName) > 2;
				if (!flag2)
				{
					goto IL_93;
				}
				IL_80:
				num2 = 8;
				result = this.SFD.FileName;
				goto IL_A1;
				IL_93:
				IL_94:
				IL_95:
				IL_96:
				num2 = 12;
				result = "";
				IL_A1:
				goto IL_12F;
				IL_90:
				goto IL_A1;
				IL_92:
				goto IL_93;
				IL_A6:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_E8:
				goto IL_124;
				IL_EA:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_102:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_EA;
			}
			IL_124:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_12F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010558 File Offset: 0x0000E758
		private void btnSaveAS_Click(object sender, EventArgs e)
		{
			string text = "X_" + DateAndTime.Today.Month.ToString() + "_" + DateAndTime.Today.Day.ToString();
			bool flag = Strings.Len(text) > 2;
			if (flag)
			{
				string text2 = this.OpensaveAs(text);
				bool flag2 = Operators.CompareString(text2, "", false) == 0;
				if (!flag2)
				{
					this.lblSavePath.Text = text2.Trim(new char[]
					{
						's'
					}).Trim(new char[]
					{
						'l'
					}).Trim(new char[]
					{
						'x'
					}).Trim(new char[]
					{
						'.'
					});
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001062C File Offset: 0x0000E82C
		private void btnExport2_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				double num2 = 1.0;
				bool flag = this.lblSavePath.Text.Length <= 1;
				if (!flag)
				{
					this.Cursor = Cursors.WaitCursor;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null), null, "Open", new object[]
					{
						Application.StartupPath + "\\reports\\xyz2.xls"
					}, null, null, null));
					NewLateBinding.LateSet(objectValue, null, "DisplayAlerts", new object[]
					{
						false
					}, null, null);
					object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[]
					{
						"Sheet1"
					}, null, null, null));
					double num3 = 0.0;
					for (;;)
					{
						checked
						{
							bool flag2 = num3 > (double)(this.lstNumbers.Items.Count - 1);
							if (flag2)
							{
								break;
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Range", new object[]
							{
								"A" + num2.ToString()
							}, null, null, null), null, "Value", new object[]
							{
								this.lstNumbers.Items[(int)Math.Round(num3)]
							}, null, null, false, true);
						}
						num2 += 1.0;
						num3 += 1.0;
					}
					bool flag3 = num2 > 1.0;
					if (flag3)
					{
						NewLateBinding.LateCall(objectValue2, null, "SaveAs", new object[]
						{
							Operators.ConcatenateObject(Operators.ConcatenateObject(this.lblSavePath.Text + "_", this.lstNumbers.Items[0]), ".xls")
						}, null, null, null, true);
					}
					else
					{
						Interaction.MsgBox("لا توجد اى ارقام ", MsgBoxStyle.Critical, null);
					}
					NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, true);
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
					this.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3));
					this.Cursor = Cursors.Default;
					bool flag4 = num2 > 3.0;
					if (flag4)
					{
						Interaction.MsgBox("تم تصدير جميع الارقام بنجاح", MsgBoxStyle.Information, null);
					}
				}
				IL_2A5:
				goto IL_2E8;
				IL_28A:
				this.Cursor = Cursors.Default;
				Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical, null);
				goto IL_2A5;
				IL_2A7:
				num4 = -1;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2BB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2A7;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E8:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00010948 File Offset: 0x0000EB48
		private void btnAddFF_Click(object sender, EventArgs e)
		{
			bool flag = Conversion.Val(this.txtEnumSH.Text) > 0.0;
			if (flag)
			{
				this.GetAllSmsfromDBExc(this.txtEnumSH.Text);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001098C File Offset: 0x0000EB8C
		private void btnSaveFromOut_Click(object sender, EventArgs e)
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
				this.btnSaveFromOut.Enabled = false;
				IL_1A:
				num2 = 3;
				bool flag = MyProject.Forms.frmUssd.lblNum1.Text.Trim().Length > 0;
				if (!flag)
				{
					goto IL_72;
				}
				IL_41:
				num2 = 4;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum1.Text.Trim();
				IL_68:
				num2 = 5;
				this.Addtelnumber();
				IL_71:
				IL_72:
				IL_73:
				num2 = 7;
				bool flag2 = MyProject.Forms.frmUssd.lblNum2.Text.Trim().Length > 0;
				if (!flag2)
				{
					goto IL_CE;
				}
				IL_9C:
				num2 = 8;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum2.Text.Trim();
				IL_C3:
				num2 = 9;
				this.Addtelnumber();
				IL_CD:
				IL_CE:
				IL_CF:
				num2 = 11;
				bool flag3 = MyProject.Forms.frmUssd.lblNum3.Text.Trim().Length > 0;
				if (!flag3)
				{
					goto IL_12C;
				}
				IL_F9:
				num2 = 12;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum3.Text.Trim();
				IL_121:
				num2 = 13;
				this.Addtelnumber();
				IL_12B:
				IL_12C:
				IL_12D:
				num2 = 15;
				bool flag4 = MyProject.Forms.frmUssd.lblNum4.Text.Trim().Length > 0;
				if (!flag4)
				{
					goto IL_18A;
				}
				IL_157:
				num2 = 16;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum4.Text.Trim();
				IL_17F:
				num2 = 17;
				this.Addtelnumber();
				IL_189:
				IL_18A:
				IL_18B:
				num2 = 19;
				bool flag5 = MyProject.Forms.frmUssd.lblNum5.Text.Trim().Length > 0;
				if (!flag5)
				{
					goto IL_1E8;
				}
				IL_1B5:
				num2 = 20;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum5.Text.Trim();
				IL_1DD:
				num2 = 21;
				this.Addtelnumber();
				IL_1E7:
				IL_1E8:
				IL_1E9:
				num2 = 23;
				bool flag6 = MyProject.Forms.frmUssd.lblNum6.Text.Trim().Length > 0;
				if (!flag6)
				{
					goto IL_246;
				}
				IL_213:
				num2 = 24;
				this.txtDail.Text = MyProject.Forms.frmUssd.lblNum6.Text.Trim();
				IL_23B:
				num2 = 25;
				this.Addtelnumber();
				IL_245:
				IL_246:
				IL_247:
				num2 = 27;
				this.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)));
				IL_266:
				num2 = 28;
				Application.DoEvents();
				IL_26F:
				num2 = 29;
				this.btnSaveFromOut.Enabled = true;
				IL_27F:
				goto IL_351;
				IL_284:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_30A:
				goto IL_346;
				IL_30C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_324:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_30C;
			}
			IL_346:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_351:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000257C File Offset: 0x0000077C
		private void txtEnumSH_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00010D10 File Offset: 0x0000EF10
		private void btnTransfer_Click(object sender, EventArgs e)
		{
			bool flag = Conversion.Val(this.txtEnumSH.Text) > 0.0;
			if (flag)
			{
				this.GetAllSmsfromWWDB(this.txtEnumSH.Text);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000257C File Offset: 0x0000077C
		private void txtCardNew_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000257C File Offset: 0x0000077C
		private void txtDail_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00010D54 File Offset: 0x0000EF54
		private void btnAddFromWebServer_Click(object sender, EventArgs e)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				int num3 = 0;
				IL_0F:
				num2 = 3;
				int num4 = (int)Interaction.MsgBox("are you sure", MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
				IL_20:
				num2 = 4;
				bool flag = num4 == 7;
				if (!flag)
				{
					goto IL_32;
				}
				IL_2D:
				goto IL_183;
				IL_32:
				num2 = 6;
				this.AutoFlag = true;
				IL_3B:
				num2 = 7;
				int num5 = 0;
				IL_40:
				num2 = 8;
				this.btnAddFromWebServer.Enabled = false;
				IL_4F:
				for (;;)
				{
					IL_10E:
					num2 = 10;
					bool flag2 = num3 >= MyProject.Forms.frmUssd.lstWebQry.Items.Count;
					if (flag2)
					{
						break;
					}
					IL_54:
					num2 = 11;
					this.txtDail.Text = Conversions.ToString(MyProject.Forms.frmUssd.lstWebQry.Items[num3]);
					IL_82:
					num2 = 12;
					this.Addtelnumber();
					IL_8C:
					num2 = 13;
					checked
					{
						num3++;
						IL_93:
						num2 = 14;
						num5++;
						IL_9C:
						num2 = 15;
						bool flag3 = (double)num5 >= Conversion.Val(this.txtGroupQty.Text);
						if (flag3)
						{
							IL_BD:
							num2 = 16;
							num5 = 0;
							IL_C3:
							num2 = 17;
							this.btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e);
							IL_D4:;
						}
						IL_D6:
						num2 = 19;
					}
					this.lblCount.Text = Conversions.ToString(Conversion.Val(this.lblCount.Text) + 1.0);
					IL_104:
					num2 = 20;
					Application.DoEvents();
					IL_10D:;
				}
				IL_139:
				num2 = 22;
				this.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(this.txtEnumSH.Text)));
				IL_158:
				num2 = 23;
				Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information, null);
				IL_169:
				num2 = 24;
				this.AutoFlag = false;
				IL_173:
				num2 = 25;
				this.btnAddFromWebServer.Enabled = true;
				IL_183:
				goto IL_245;
				IL_188:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_1FE:
				goto IL_23A;
				IL_200:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_218:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_200;
			}
			IL_23A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_245:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0400006D RID: 109
		private CData objData;

		// Token: 0x0400006E RID: 110
		private DataTable objDataTabletemp;

		// Token: 0x0400006F RID: 111
		private bool AutoFlag;

		// Token: 0x04000070 RID: 112
		private int CurrIndex;

		// Token: 0x04000071 RID: 113
		private string CLICODE;

		// Token: 0x04000072 RID: 114
		private string FileNamePath;
	}
}
