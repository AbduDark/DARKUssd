Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MTUssd.My

Namespace MTUssd
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class frmAddVCNums
		Inherits Form

		' Token: 0x060000B4 RID: 180 RVA: 0x000025A7 File Offset: 0x000007A7
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmAddVCNums_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x060000B7 RID: 183 RVA: 0x000025C7 File Offset: 0x000007C7
		' (set) Token: 0x060000B8 RID: 184 RVA: 0x0000D668 File Offset: 0x0000B868
		Friend Overridable Property btnAddFF As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAddFF
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddFF_Click
				Dim btnAddFF As Button = Me._btnAddFF
				If btnAddFF IsNot Nothing Then
					RemoveHandler btnAddFF.Click, value2
				End If
				Me._btnAddFF = value
				btnAddFF = Me._btnAddFF
				If btnAddFF IsNot Nothing Then
					AddHandler btnAddFF.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x060000B9 RID: 185 RVA: 0x000025D1 File Offset: 0x000007D1
		' (set) Token: 0x060000BA RID: 186 RVA: 0x000025DB File Offset: 0x000007DB
		Friend Overridable Property lblSavePath As Label

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x060000BB RID: 187 RVA: 0x000025E4 File Offset: 0x000007E4
		' (set) Token: 0x060000BC RID: 188 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		Friend Overridable Property btnSaveAS As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSaveAS
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSaveAS_Click
				Dim btnSaveAS As Button = Me._btnSaveAS
				If btnSaveAS IsNot Nothing Then
					RemoveHandler btnSaveAS.Click, value2
				End If
				Me._btnSaveAS = value
				btnSaveAS = Me._btnSaveAS
				If btnSaveAS IsNot Nothing Then
					AddHandler btnSaveAS.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x060000BD RID: 189 RVA: 0x000025EE File Offset: 0x000007EE
		' (set) Token: 0x060000BE RID: 190 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		Friend Overridable Property btnExport2 As Button
			<CompilerGenerated()>
			Get
				Return Me._btnExport2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnExport2_Click
				Dim btnExport As Button = Me._btnExport2
				If btnExport IsNot Nothing Then
					RemoveHandler btnExport.Click, value2
				End If
				Me._btnExport2 = value
				btnExport = Me._btnExport2
				If btnExport IsNot Nothing Then
					AddHandler btnExport.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000BF RID: 191 RVA: 0x000025F8 File Offset: 0x000007F8
		' (set) Token: 0x060000C0 RID: 192 RVA: 0x0000D734 File Offset: 0x0000B934
		Friend Overridable Property cmbPaste As Button
			<CompilerGenerated()>
			Get
				Return Me._cmbPaste
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmbPaste_Click
				Dim cmbPaste As Button = Me._cmbPaste
				If cmbPaste IsNot Nothing Then
					RemoveHandler cmbPaste.Click, value2
				End If
				Me._cmbPaste = value
				cmbPaste = Me._cmbPaste
				If cmbPaste IsNot Nothing Then
					AddHandler cmbPaste.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x060000C1 RID: 193 RVA: 0x00002602 File Offset: 0x00000802
		' (set) Token: 0x060000C2 RID: 194 RVA: 0x0000260C File Offset: 0x0000080C
		Friend Overridable Property lblCountPre As Label

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x060000C3 RID: 195 RVA: 0x00002615 File Offset: 0x00000815
		' (set) Token: 0x060000C4 RID: 196 RVA: 0x0000D778 File Offset: 0x0000B978
		Friend Overridable Property btnClear As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClear
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnClear_Click
				Dim btnClear As Button = Me._btnClear
				If btnClear IsNot Nothing Then
					RemoveHandler btnClear.Click, value2
				End If
				Me._btnClear = value
				btnClear = Me._btnClear
				If btnClear IsNot Nothing Then
					AddHandler btnClear.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x0000261F File Offset: 0x0000081F
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		Friend Overridable Property btnDelOnePre As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelOnePre
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDelOnePre_Click
				Dim btnDelOnePre As Button = Me._btnDelOnePre
				If btnDelOnePre IsNot Nothing Then
					RemoveHandler btnDelOnePre.Click, value2
				End If
				Me._btnDelOnePre = value
				btnDelOnePre = Me._btnDelOnePre
				If btnDelOnePre IsNot Nothing Then
					AddHandler btnDelOnePre.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00002629 File Offset: 0x00000829
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x0000D800 File Offset: 0x0000BA00
		Friend Overridable Property txtCardNew As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtCardNew
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.txtCardNew_KeyPress
				Dim value3 As EventHandler = AddressOf Me.txtCardNew_TextChanged
				Dim txtCardNew As TextBox = Me._txtCardNew
				If txtCardNew IsNot Nothing Then
					RemoveHandler txtCardNew.KeyPress, value2
					RemoveHandler txtCardNew.TextChanged, value3
				End If
				Me._txtCardNew = value
				txtCardNew = Me._txtCardNew
				If txtCardNew IsNot Nothing Then
					AddHandler txtCardNew.KeyPress, value2
					AddHandler txtCardNew.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000C9 RID: 201 RVA: 0x00002633 File Offset: 0x00000833
		' (set) Token: 0x060000CA RID: 202 RVA: 0x0000263D File Offset: 0x0000083D
		Friend Overridable Property cmbColom As ComboBox

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000CB RID: 203 RVA: 0x00002646 File Offset: 0x00000846
		' (set) Token: 0x060000CC RID: 204 RVA: 0x0000D860 File Offset: 0x0000BA60
		Friend Overridable Property btnDel As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDel_Click
				Dim btnDel As Button = Me._btnDel
				If btnDel IsNot Nothing Then
					RemoveHandler btnDel.Click, value2
				End If
				Me._btnDel = value
				btnDel = Me._btnDel
				If btnDel IsNot Nothing Then
					AddHandler btnDel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000CD RID: 205 RVA: 0x00002650 File Offset: 0x00000850
		' (set) Token: 0x060000CE RID: 206 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		Friend Overridable Property lstB1 As ListBox
			<CompilerGenerated()>
			Get
				Return Me._lstB1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstB1_SelectedIndexChanged
				Dim lstB As ListBox = Me._lstB1
				If lstB IsNot Nothing Then
					RemoveHandler lstB.SelectedIndexChanged, value2
				End If
				Me._lstB1 = value
				lstB = Me._lstB1
				If lstB IsNot Nothing Then
					AddHandler lstB.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000CF RID: 207 RVA: 0x0000265A File Offset: 0x0000085A
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		Friend Overridable Property lstB2 As ListBox
			<CompilerGenerated()>
			Get
				Return Me._lstB2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstB2_SelectedIndexChanged
				Dim lstB As ListBox = Me._lstB2
				If lstB IsNot Nothing Then
					RemoveHandler lstB.SelectedIndexChanged, value2
				End If
				Me._lstB2 = value
				lstB = Me._lstB2
				If lstB IsNot Nothing Then
					AddHandler lstB.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x00002664 File Offset: 0x00000864
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x0000266E File Offset: 0x0000086E
		Friend Overridable Property lblC As Label

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000D3 RID: 211 RVA: 0x00002677 File Offset: 0x00000877
		' (set) Token: 0x060000D4 RID: 212 RVA: 0x00002681 File Offset: 0x00000881
		Friend Overridable Property Label18 As Label

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000D5 RID: 213 RVA: 0x0000268A File Offset: 0x0000088A
		' (set) Token: 0x060000D6 RID: 214 RVA: 0x00002694 File Offset: 0x00000894
		Friend Overridable Property SFD As SaveFileDialog

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000D7 RID: 215 RVA: 0x0000269D File Offset: 0x0000089D
		' (set) Token: 0x060000D8 RID: 216 RVA: 0x000026A7 File Offset: 0x000008A7
		Friend Overridable Property Label3 As Label

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x000026B0 File Offset: 0x000008B0
		' (set) Token: 0x060000DA RID: 218 RVA: 0x000026BA File Offset: 0x000008BA
		Friend Overridable Property lstNumbers As ListBox

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000DB RID: 219 RVA: 0x000026C3 File Offset: 0x000008C3
		' (set) Token: 0x060000DC RID: 220 RVA: 0x000026CD File Offset: 0x000008CD
		Friend Overridable Property PB1 As ProgressBar

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000DD RID: 221 RVA: 0x000026D6 File Offset: 0x000008D6
		' (set) Token: 0x060000DE RID: 222 RVA: 0x0000D92C File Offset: 0x0000BB2C
		Friend Overridable Property btnExport As Button
			<CompilerGenerated()>
			Get
				Return Me._btnExport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnExport_Click
				Dim btnExport As Button = Me._btnExport
				If btnExport IsNot Nothing Then
					RemoveHandler btnExport.Click, value2
				End If
				Me._btnExport = value
				btnExport = Me._btnExport
				If btnExport IsNot Nothing Then
					AddHandler btnExport.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000DF RID: 223 RVA: 0x000026E0 File Offset: 0x000008E0
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x0000D970 File Offset: 0x0000BB70
		Friend Overridable Property btnOpen As Button
			<CompilerGenerated()>
			Get
				Return Me._btnOpen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOpen_Click
				Dim btnOpen As Button = Me._btnOpen
				If btnOpen IsNot Nothing Then
					RemoveHandler btnOpen.Click, value2
				End If
				Me._btnOpen = value
				btnOpen = Me._btnOpen
				If btnOpen IsNot Nothing Then
					AddHandler btnOpen.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x000026EA File Offset: 0x000008EA
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		Friend Overridable Property btnDelOne As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelOne
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDelOne_Click
				Dim btnDelOne As Button = Me._btnDelOne
				If btnDelOne IsNot Nothing Then
					RemoveHandler btnDelOne.Click, value2
				End If
				Me._btnDelOne = value
				btnDelOne = Me._btnDelOne
				If btnDelOne IsNot Nothing Then
					AddHandler btnDelOne.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x000026F4 File Offset: 0x000008F4
		' (set) Token: 0x060000E4 RID: 228 RVA: 0x000026FE File Offset: 0x000008FE
		Friend Overridable Property lblTelNum As Label

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000E5 RID: 229 RVA: 0x00002707 File Offset: 0x00000907
		' (set) Token: 0x060000E6 RID: 230 RVA: 0x00002711 File Offset: 0x00000911
		Friend Overridable Property lblCount As Label

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000E7 RID: 231 RVA: 0x0000271A File Offset: 0x0000091A
		' (set) Token: 0x060000E8 RID: 232 RVA: 0x00002724 File Offset: 0x00000924
		Friend Overridable Property Label4 As Label

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000E9 RID: 233 RVA: 0x0000272D File Offset: 0x0000092D
		' (set) Token: 0x060000EA RID: 234 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		Friend Overridable Property dataViewGrid As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dataViewGrid
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellEventHandler = AddressOf Me.dataViewGrid_CellContentClick
				Dim dataViewGrid As DataGridView = Me._dataViewGrid
				If dataViewGrid IsNot Nothing Then
					RemoveHandler dataViewGrid.CellContentClick, value2
				End If
				Me._dataViewGrid = value
				dataViewGrid = Me._dataViewGrid
				If dataViewGrid IsNot Nothing Then
					AddHandler dataViewGrid.CellContentClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000EB RID: 235 RVA: 0x00002737 File Offset: 0x00000937
		' (set) Token: 0x060000EC RID: 236 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		Friend Overridable Property btnDelNums As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelNums
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDelNums_Click
				Dim btnDelNums As Button = Me._btnDelNums
				If btnDelNums IsNot Nothing Then
					RemoveHandler btnDelNums.Click, value2
				End If
				Me._btnDelNums = value
				btnDelNums = Me._btnDelNums
				If btnDelNums IsNot Nothing Then
					AddHandler btnDelNums.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000ED RID: 237 RVA: 0x00002741 File Offset: 0x00000941
		' (set) Token: 0x060000EE RID: 238 RVA: 0x0000DA80 File Offset: 0x0000BC80
		Friend Overridable Property btnNewnums As Button
			<CompilerGenerated()>
			Get
				Return Me._btnNewnums
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnNewnums_Click
				Dim btnNewnums As Button = Me._btnNewnums
				If btnNewnums IsNot Nothing Then
					RemoveHandler btnNewnums.Click, value2
				End If
				Me._btnNewnums = value
				btnNewnums = Me._btnNewnums
				If btnNewnums IsNot Nothing Then
					AddHandler btnNewnums.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000EF RID: 239 RVA: 0x0000274B File Offset: 0x0000094B
		' (set) Token: 0x060000F0 RID: 240 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		Friend Overridable Property txtDail As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtDail
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.txtDail_KeyPress
				Dim value3 As EventHandler = AddressOf Me.txtDail_TextChanged
				Dim txtDail As TextBox = Me._txtDail
				If txtDail IsNot Nothing Then
					RemoveHandler txtDail.KeyPress, value2
					RemoveHandler txtDail.TextChanged, value3
				End If
				Me._txtDail = value
				txtDail = Me._txtDail
				If txtDail IsNot Nothing Then
					AddHandler txtDail.KeyPress, value2
					AddHandler txtDail.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x00002755 File Offset: 0x00000955
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x0000275F File Offset: 0x0000095F
		Friend Overridable Property Label10 As Label

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x00002768 File Offset: 0x00000968
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x0000DB24 File Offset: 0x0000BD24
		Friend Overridable Property txtEnumSH As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtEnumSH
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.txtEnumSH_KeyPress
				Dim value3 As EventHandler = AddressOf Me.txtEnumSH_TextChanged
				Dim txtEnumSH As TextBox = Me._txtEnumSH
				If txtEnumSH IsNot Nothing Then
					RemoveHandler txtEnumSH.KeyPress, value2
					RemoveHandler txtEnumSH.TextChanged, value3
				End If
				Me._txtEnumSH = value
				txtEnumSH = Me._txtEnumSH
				If txtEnumSH IsNot Nothing Then
					AddHandler txtEnumSH.KeyPress, value2
					AddHandler txtEnumSH.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x00002772 File Offset: 0x00000972
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x0000277C File Offset: 0x0000097C
		Friend Overridable Property ODfile As OpenFileDialog

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x00002785 File Offset: 0x00000985
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x0000DB84 File Offset: 0x0000BD84
		Friend Overridable Property btnADDAuto As Button
			<CompilerGenerated()>
			Get
				Return Me._btnADDAuto
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnADDAuto_Click
				Dim btnADDAuto As Button = Me._btnADDAuto
				If btnADDAuto IsNot Nothing Then
					RemoveHandler btnADDAuto.Click, value2
				End If
				Me._btnADDAuto = value
				btnADDAuto = Me._btnADDAuto
				If btnADDAuto IsNot Nothing Then
					AddHandler btnADDAuto.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x0000278F File Offset: 0x0000098F
		' (set) Token: 0x060000FA RID: 250 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		Friend Overridable Property btnSaveFromOut As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSaveFromOut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSaveFromOut_Click
				Dim btnSaveFromOut As Button = Me._btnSaveFromOut
				If btnSaveFromOut IsNot Nothing Then
					RemoveHandler btnSaveFromOut.Click, value2
				End If
				Me._btnSaveFromOut = value
				btnSaveFromOut = Me._btnSaveFromOut
				If btnSaveFromOut IsNot Nothing Then
					AddHandler btnSaveFromOut.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000FB RID: 251 RVA: 0x00002799 File Offset: 0x00000999
		' (set) Token: 0x060000FC RID: 252 RVA: 0x0000DC0C File Offset: 0x0000BE0C
		Friend Overridable Property btnTransfer As Button
			<CompilerGenerated()>
			Get
				Return Me._btnTransfer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnTransfer_Click
				Dim btnTransfer As Button = Me._btnTransfer
				If btnTransfer IsNot Nothing Then
					RemoveHandler btnTransfer.Click, value2
				End If
				Me._btnTransfer = value
				btnTransfer = Me._btnTransfer
				If btnTransfer IsNot Nothing Then
					AddHandler btnTransfer.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000FD RID: 253 RVA: 0x000027A3 File Offset: 0x000009A3
		' (set) Token: 0x060000FE RID: 254 RVA: 0x000027AD File Offset: 0x000009AD
		Friend Overridable Property txtGroupQty As TextBox

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000FF RID: 255 RVA: 0x000027B6 File Offset: 0x000009B6
		' (set) Token: 0x06000100 RID: 256 RVA: 0x000027C0 File Offset: 0x000009C0
		Friend Overridable Property Label1 As Label

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x06000101 RID: 257 RVA: 0x000027C9 File Offset: 0x000009C9
		' (set) Token: 0x06000102 RID: 258 RVA: 0x0000DC50 File Offset: 0x0000BE50
		Friend Overridable Property btnAddFromWebServer As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAddFromWebServer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddFromWebServer_Click
				Dim btnAddFromWebServer As Button = Me._btnAddFromWebServer
				If btnAddFromWebServer IsNot Nothing Then
					RemoveHandler btnAddFromWebServer.Click, value2
				End If
				Me._btnAddFromWebServer = value
				btnAddFromWebServer = Me._btnAddFromWebServer
				If btnAddFromWebServer IsNot Nothing Then
					AddHandler btnAddFromWebServer.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000103 RID: 259 RVA: 0x0000DC94 File Offset: 0x0000BE94
		Private Sub Reset()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.objData = New CData(Application.StartupPath + "\maindb.ngm")
				IL_27:
				GoTo IL_8A
				IL_29:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_43:
				GoTo IL_7F
				IL_45:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_5D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_45
			End Try
			IL_7F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000104 RID: 260 RVA: 0x0000DD44 File Offset: 0x0000BF44
		Private Function GetNextenums() As Integer
			Dim num As Integer
			Dim result As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT distinct enums FROM vcnums order by enums")
				IL_23:
				num2 = 3
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				IL_39:
				num2 = 4
				Dim flag As Boolean = num3 >= 0
				If Not flag Then
					IL_88:
					num2 = 7
					result = 1
					GoTo IL_8F
				End If
				IL_49:
				num2 = 5
				result = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(num3)("enums"))) + 1.0))
				IL_8F:
				GoTo IL_10A
				IL_84:
				IL_8E:
				GoTo IL_8F
				IL_91:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_C3:
				GoTo IL_FF
				IL_C5:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_DD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_C5
			End Try
			IL_FF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_10A:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000105 RID: 261 RVA: 0x0000DE78 File Offset: 0x0000C078
		Private Sub AddTelNum(cardIDx As String)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim text As String = "Insert Into vcnums "
				IL_13:
				num2 = 3
				text += "(enums,evalue,mobnum)"
				IL_21:
				num2 = 4
				text += "Values ("
				IL_2F:
				num2 = 5
				text = text + " " + Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)) + " , "
				IL_57:
				num2 = 6
				text += " 0 , "
				IL_65:
				num2 = 7
				text = text + "'" + cardIDx + "') "
				IL_79:
				num2 = 8
				Me.objData.DatabaseCommand(text)
				IL_88:
				GoTo IL_103
				IL_8A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_BC:
				GoTo IL_F8
				IL_BE:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_D6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_BE
			End Try
			IL_F8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_103:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000106 RID: 262 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		Private Sub Addtelnumber()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.txtDail.BackColor = Color.White
				IL_1E:
				num2 = 3
				Dim flag As Boolean = Conversion.Val(Me.txtEnumSH.Text) <= 0.0
				If Not flag Then
					GoTo IL_6B
				End If
				IL_42:
				num2 = 4
				Interaction.MsgBox("اكمل الخانات اللازمة من فضلك", MsgBoxStyle.Critical, Nothing)
				IL_52:
				num2 = 5
				Me.txtDail.BackColor = Color.PaleVioletRed
				IL_65:
				GoTo IL_175
				IL_6B:
				IL_6C:
				num2 = 8
				Dim flag2 As Boolean = Me.txtDail.Text.Trim().Length <= 0 And Me.btnADDAuto.Enabled
				If Not flag2 Then
					GoTo IL_C6
				End If
				IL_9B:
				num2 = 9
				Interaction.MsgBox("الرقم غير سليم", MsgBoxStyle.Critical, Nothing)
				IL_AC:
				num2 = 10
				Me.txtDail.BackColor = Color.PaleVioletRed
				IL_C0:
				GoTo IL_175
				IL_C6:
				IL_C7:
				num2 = 13
				Dim enabled As Boolean = Me.btnADDAuto.Enabled
				If Not enabled Then
					GoTo IL_113
				End If
				IL_DB:
				num2 = 14
				Dim flag3 As Boolean = Me.chktelNumFound(Me.txtDail.Text.Trim())
				If Not flag3 Then
					GoTo IL_111
				End If
				IL_FA:
				num2 = 15
				Me.txtDail.BackColor = Color.PaleVioletRed
				IL_10E:
				GoTo IL_175
				IL_111:
				IL_112:
				IL_113:
				IL_114:
				num2 = 19
				Me.AddTelNum(Me.txtDail.Text.Trim())
				IL_12E:
				num2 = 20
				Dim enabled2 As Boolean = Me.btnADDAuto.Enabled
				If Not enabled2 Then
					GoTo IL_161
				End If
				IL_142:
				num2 = 21
				Me.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_161:
				num2 = 22
				Me.txtDail.BackColor = Color.PaleGreen
				IL_175:
				GoTo IL_22B
				IL_6A:
				GoTo IL_6B
				IL_C5:
				GoTo IL_C6
				IL_110:
				GoTo IL_111
				IL_17A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1E4:
				GoTo IL_220
				IL_1E6:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_1FE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1E6
			End Try
			IL_220:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_22B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000107 RID: 263 RVA: 0x0000E204 File Offset: 0x0000C404
		Private Function chktelNumFound(eetel As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM vcnums where  mobnum = '" + eetel + "'")
				IL_2E:
				num2 = 3
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_91
				End If
				IL_49:
				num2 = 4
				Dim flag2 As Boolean = Not Me.AutoFlag
				If Not flag2 Then
					GoTo IL_8A
				End If
				IL_5A:
				num2 = 5
				Interaction.MsgBox(Operators.ConcatenateObject("الرقم موجود من قبل بالحركة رقم " & vbCrLf, Me.objDataTabletemp.Rows(0)("enums")), MsgBoxStyle.Critical, Nothing)
				IL_8A:
				num2 = 6
				result = True
				GoTo IL_98
				IL_91:
				IL_92:
				num2 = 8
				result = False
				IL_98:
				GoTo IL_113
				IL_90:
				GoTo IL_91
				IL_9A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_CC:
				GoTo IL_108
				IL_CE:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_E6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CE
			End Try
			IL_108:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_113:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000108 RID: 264 RVA: 0x0000E340 File Offset: 0x0000C540
		Private Sub GetAllSmsfromDB(eeDB As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim dataTable As DataTable = New DataTable("temp")
				IL_19:
				num2 = 3
				dataTable.Columns.Add("الرقم")
				IL_2D:
				num2 = 4
				dataTable.Columns.Add("اخر امر تشغيل")
				IL_41:
				num2 = 5
				IL_46:
				num2 = 6
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid")
				IL_73:
				num2 = 7
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_13A
				End If
				IL_91:
				num2 = 8
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_AE:
					num2 = 9
					Dim dataRow As DataRow = dataTable.NewRow()
					IL_BA:
					num2 = 10
					dataRow(0) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("mobnum"))
					IL_E6:
					num2 = 11
					dataRow(1) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("evalue"))
					IL_112:
					num2 = 12
					dataTable.Rows.Add(dataRow)
					IL_124:
					num2 = 13
					dataRow = Nothing
					IL_12A:
					num2 = 14
				Next
				IL_139:
				IL_13A:
				IL_13B:
				num2 = 16
				Me.lblCount.Text = Conversions.ToString(Me.objDataTabletemp.Rows.Count)
				IL_15F:
				num2 = 17
				Me.dataViewGrid.DataSource = dataTable
				IL_170:
				num2 = 18
				Me.dataViewGrid.Columns(0).Width = 160
				IL_18F:
				num2 = 19
				Me.dataViewGrid.Columns(1).Width = 160
				IL_1AE:
				GoTo IL_258
				IL_1B3:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_211:
				GoTo IL_24D
				IL_213:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_22B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_213
			End Try
			IL_24D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_258:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000109 RID: 265 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		Private Sub GetAllSmsfromWWDB(eeDB As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				IL_10:
				num2 = 3
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid")
				IL_3D:
				num2 = 4
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_A7
				End If
				IL_58:
				num2 = 5
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_72:
					num2 = 6
					Me.AddBoxToLstPreXC(Conversions.ToString(Me.objDataTabletemp.Rows(i)("mobnum")))
					IL_9B:
					num2 = 7
				Next
				IL_A6:
				IL_A7:
				IL_A8:
				GoTo IL_123
				IL_AA:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_DC:
				GoTo IL_118
				IL_DE:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_F6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_DE
			End Try
			IL_118:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_123:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010A RID: 266 RVA: 0x0000E718 File Offset: 0x0000C918
		Private Sub GetAllSmsfromDBExc(eeDB As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				IL_10:
				num2 = 3
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid")
				IL_3D:
				num2 = 4
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_A7
				End If
				IL_58:
				num2 = 5
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_72:
					num2 = 6
					Me.AddBoxToLstPreXC(Conversions.ToString(Me.objDataTabletemp.Rows(i)("mobnum")))
					IL_9B:
					num2 = 7
				Next
				IL_A6:
				IL_A7:
				IL_A8:
				num2 = 9
				Me.lblCount.Text = Conversions.ToString(Me.objDataTabletemp.Rows.Count)
				IL_CC:
				GoTo IL_14B
				IL_CE:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_104:
				GoTo IL_140
				IL_106:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_11E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_106
			End Try
			IL_140:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_14B:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010B RID: 267 RVA: 0x0000E898 File Offset: 0x0000CA98
		Private Sub txtDail_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
				If Not flag Then
					GoTo IL_7C
				End If
				IL_20:
				num2 = 3
				Dim flag2 As Boolean = Me.txtDail.Text.Trim().Length > 0
				If Not flag2 Then
					GoTo IL_7A
				End If
				IL_40:
				num2 = 4
				Me.Addtelnumber()
				IL_49:
				num2 = 5
				Dim flag3 As Boolean = Me.txtDail.BackColor = Color.PaleGreen
				If Not flag3 Then
					GoTo IL_79
				End If
				IL_66:
				num2 = 6
				Me.txtDail.Text = ""
				IL_79:
				IL_7A:
				IL_7B:
				IL_7C:
				IL_7D:
				GoTo IL_F8
				IL_7F:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_B1:
				GoTo IL_ED
				IL_B3:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_CB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B3
			End Try
			IL_ED:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F8:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010C RID: 268 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		Private Sub frmAddVCNums_Load(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.Reset()
				IL_14:
				num2 = 3
				Me.btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e)
				IL_24:
				num2 = 4
				Me.AutoFlag = False
				IL_2D:
				num2 = 5
				Me.cmbColom.SelectedIndex = 0
				IL_3C:
				GoTo IL_AB
				IL_3E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_64:
				GoTo IL_A0
				IL_66:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_7E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_66
			End Try
			IL_A0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010D RID: 269 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		Private Sub btnNewnums_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.txtEnumSH.Text = Conversions.ToString(Me.GetNextenums())
				IL_24:
				num2 = 3
				Me.GetAllSmsfromDB(Me.txtEnumSH.Text)
				IL_38:
				GoTo IL_9F
				IL_3A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_58:
				GoTo IL_94
				IL_5A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_72:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5A
			End Try
			IL_94:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x0000EB54 File Offset: 0x0000CD54
		Private Sub btnDelNums_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = CInt(Interaction.MsgBox("هل  تريد حذف رقم حركة ادخال رقم" + Me.txtEnumSH.Text + vbCrLf & " وعددهم " + Me.lblCount.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_3B:
				num2 = 3
				Dim flag As Boolean = num3 = 7
				If Not flag Then
					GoTo IL_49
				End If
				IL_47:
				GoTo IL_76
				IL_49:
				num2 = 5
				Me.objData.DatabaseCommand("Delete From vcnums WHERE enums = " + Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_76:
				GoTo IL_E5
				IL_78:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_9E:
				GoTo IL_DA
				IL_A0:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_B8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A0
			End Try
			IL_DA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E5:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x0000EC60 File Offset: 0x0000CE60
		Private Sub txtEnumSH_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
				If Not flag Then
					GoTo IL_5A
				End If
				IL_20:
				num2 = 3
				Dim flag2 As Boolean = Conversion.Val(Me.txtEnumSH.Text) > 0.0
				If Not flag2 Then
					GoTo IL_58
				End If
				IL_43:
				num2 = 4
				Me.GetAllSmsfromDB(Me.txtEnumSH.Text)
				IL_57:
				IL_58:
				IL_59:
				IL_5A:
				IL_5B:
				num2 = 7
				Dim flag3 As Boolean = Strings.Asc(e.KeyChar) <> 8
				If Not flag3 Then
					GoTo IL_A6
				End If
				IL_74:
				num2 = 8
				Dim flag4 As Boolean = Strings.Asc(e.KeyChar) < 48 Or Strings.Asc(e.KeyChar) > 57
				If Not flag4 Then
					GoTo IL_A6
				End If
				IL_9B:
				num2 = 9
				e.KeyChar = vbNullChar
				IL_A6:
				GoTo IL_125
				IL_A8:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_DE:
				GoTo IL_11A
				IL_E0:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_F8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E0
			End Try
			IL_11A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_125:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		Private Sub dataViewGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.lblTelNum.Text = Conversions.ToString(Me.dataViewGrid(0, e.RowIndex).Value)
				IL_35:
				GoTo IL_98
				IL_37:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_51:
				GoTo IL_8D
				IL_53:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_6B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_53
			End Try
			IL_8D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_98:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000111 RID: 273 RVA: 0x0000EE6C File Offset: 0x0000D06C
		Private Sub btnDelOne_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = CInt(Interaction.MsgBox("هل  تريد حذف الرقم" + Me.lblTelNum.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_2B:
				num2 = 3
				Dim flag As Boolean = num3 = 7
				If Not flag Then
					GoTo IL_39
				End If
				IL_37:
				GoTo IL_A8
				IL_39:
				num2 = 5
				Me.objData.DatabaseCommand("Delete From vcnums WHERE mobnum = '" + Me.lblTelNum.Text + "'")
				IL_61:
				num2 = 6
				Interaction.MsgBox("تم حذف الرقم" + Me.lblTelNum.Text, MsgBoxStyle.Information, Nothing)
				IL_81:
				num2 = 7
				Me.GetAllSmsfromDB(Me.txtEnumSH.Text)
				IL_95:
				num2 = 8
				Me.lblTelNum.Text = ""
				IL_A8:
				GoTo IL_123
				IL_AA:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_DC:
				GoTo IL_118
				IL_DE:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_F6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_DE
			End Try
			IL_118:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_123:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000112 RID: 274 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		Private Sub btnADDAuto_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0F:
				num2 = 3
				Dim num4 As Integer = CInt(Interaction.MsgBox("هل تريد اضافة الارقام المحددة  الى النظام", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_20:
				num2 = 4
				Dim flag As Boolean = num4 = 7
				If Not flag Then
					GoTo IL_32
				End If
				IL_2D:
				GoTo IL_126
				IL_32:
				num2 = 6
				Me.AutoFlag = True
				IL_3B:
				num2 = 7
				Me.btnADDAuto.Enabled = False
				IL_4A:
				While True
					IL_BA:
					num2 = 9
					Dim flag2 As Boolean = num3 >= Me.lstNumbers.Items.Count
					If flag2 Then
						Exit For
					End If
					IL_4C:
					num2 = 10
					Me.txtDail.Text = Conversions.ToString(Me.lstNumbers.Items(num3))
					IL_71:
					num2 = 11
					Me.Addtelnumber()
					IL_7B:
					num2 = 12
					num3 += 1
					IL_82:
					num2 = 13
					Me.lblCount.Text = Conversions.ToString(Conversion.Val(Me.lblCount.Text) + 1.0)
					IL_B0:
					num2 = 14
					Application.DoEvents()
					IL_B9:
				End While
				IL_DC:
				num2 = 16
				Me.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_FB:
				num2 = 17
				Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information, Nothing)
				IL_10C:
				num2 = 18
				Me.AutoFlag = False
				IL_116:
				num2 = 19
				Me.btnADDAuto.Enabled = True
				IL_126:
				GoTo IL_1D0
				IL_12B:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_189:
				GoTo IL_1C5
				IL_18B:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_1A3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_18B
			End Try
			IL_1C5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1D0:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000113 RID: 275 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		Private Sub btnDelOnePre_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Me.lstNumbers.SelectedItems.Count > 0
				If Not flag Then
					GoTo IL_66
				End If
				IL_24:
				num2 = 3
				Me.lstNumbers.Items.RemoveAt(Me.lstNumbers.SelectedIndex)
				IL_42:
				num2 = 4
				Me.lblCountPre.Text = Conversions.ToString(Me.lstNumbers.Items.Count)
				IL_65:
				IL_66:
				IL_67:
				GoTo IL_D6
				IL_69:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_8F:
				GoTo IL_CB
				IL_91:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_A9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_91
			End Try
			IL_CB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_D6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000114 RID: 276 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.lstNumbers.Items.Clear()
				IL_1E:
				num2 = 3
				Me.lblCountPre.Text = "0"
				IL_31:
				GoTo IL_98
				IL_33:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_51:
				GoTo IL_8D
				IL_53:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_6B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_53
			End Try
			IL_8D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_98:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000115 RID: 277 RVA: 0x0000F378 File Offset: 0x0000D578
		Private Sub txtCardNew_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
				If Not flag Then
					GoTo IL_BC
				End If
				IL_23:
				num2 = 3
				Dim flag2 As Boolean = Me.txtCardNew.Text.Trim().Length > 0
				If Not flag2 Then
					GoTo IL_BA
				End If
				IL_43:
				num2 = 4
				Me.txtCardNew.BackColor = Color.White
				IL_56:
				num2 = 5
				Dim flag3 As Boolean = Me.chktelNumFound(Me.txtCardNew.Text.Trim())
				If Not flag3 Then
					GoTo IL_8A
				End If
				IL_74:
				num2 = 6
				Me.txtCardNew.BackColor = Color.PaleVioletRed
				IL_87:
				GoTo IL_BD
				IL_8A:
				IL_8B:
				num2 = 9
				Me.AddBoxToLstPre(Me.txtCardNew.Text.Trim())
				IL_A5:
				num2 = 10
				Me.txtCardNew.Text = ""
				IL_B9:
				IL_BA:
				IL_BB:
				IL_BC:
				IL_BD:
				GoTo IL_14B
				IL_89:
				GoTo IL_8A
				IL_C2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_104:
				GoTo IL_140
				IL_106:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_11E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_106
			End Try
			IL_140:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_14B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000116 RID: 278 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		Private Sub AddBoxToLstPre(EER As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0F:
				num2 = 3
				Dim flag As Boolean = EER.Length > 0
				If Not flag Then
					IL_37:
					GoTo IL_71
				End If
				IL_20:
				num2 = 4
				Dim flag2 As Boolean = Me.chktelNumFound(EER)
				If Not flag2 Then
					GoTo IL_32
				End If
				IL_2F:
				GoTo IL_71
				IL_32:
				IL_33:
				IL_3A:
				num2 = 10
				num3 = Me.lstNumbers.FindString(EER)
				IL_4A:
				num2 = 11
				Dim flag3 As Boolean = num3 >= 0
				If Not flag3 Then
					GoTo IL_5C
				End If
				IL_5A:
				GoTo IL_71
				IL_5C:
				num2 = 13
				Me.lstNumbers.Items.Add(EER)
				IL_71:
				IL_72:
				num2 = 14
				Me.lblCountPre.Text = Conversions.ToString(Me.lstNumbers.Items.Count)
				IL_96:
				num2 = 15
				Application.DoEvents()
				IL_9F:
				GoTo IL_139
				IL_31:
				IL_39:
				GoTo IL_3A
				IL_A4:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_F2:
				GoTo IL_12E
				IL_F4:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_10C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F4
			End Try
			IL_12E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_139:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000117 RID: 279 RVA: 0x0000F664 File Offset: 0x0000D864
		Private Sub AddBoxToLstPreXC(EER As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0F:
				num2 = 3
				num3 = Me.lstNumbers.FindString(EER)
				IL_1E:
				num2 = 4
				Dim flag As Boolean = num3 >= 0
				If Not flag Then
					GoTo IL_2F
				End If
				IL_2D:
				GoTo IL_43
				IL_2F:
				num2 = 6
				Me.lstNumbers.Items.Add(EER)
				IL_43:
				IL_44:
				num2 = 7
				Me.lblCountPre.Text = Conversions.ToString(Me.lstNumbers.Items.Count)
				IL_67:
				num2 = 8
				Application.DoEvents()
				IL_6F:
				GoTo IL_EA
				IL_71:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_A3:
				GoTo IL_DF
				IL_A5:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_BD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A5
			End Try
			IL_DF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_EA:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000118 RID: 280 RVA: 0x000027D3 File Offset: 0x000009D3
		Private Sub btnOpen_Click(sender As Object, e As EventArgs)
			Me.OpenFileLoc()
		End Sub

		' Token: 0x06000119 RID: 281 RVA: 0x0000F774 File Offset: 0x0000D974
		Private Sub btnDel_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Me.lstB1.SelectedIndex >= 0
				If Not flag Then
					GoTo IL_AB
				End If
				IL_25:
				num2 = 3
				Me.lblC.Text = Conversions.ToString(Conversion.Val(Me.lblC.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.lstB2.Items(Me.lstB2.SelectedIndex))))
				IL_6E:
				num2 = 4
				Me.lstB1.Items.RemoveAt(Me.lstB1.SelectedIndex)
				IL_8C:
				num2 = 5
				Me.lstB2.Items.RemoveAt(Me.lstB2.SelectedIndex)
				IL_AA:
				IL_AB:
				IL_AC:
				GoTo IL_11F
				IL_AE:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_D8:
				GoTo IL_114
				IL_DA:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_F2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_DA
			End Try
			IL_114:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_11F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600011A RID: 282 RVA: 0x0000F8BC File Offset: 0x0000DABC
		Private Sub lstB2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstB2.SelectedIndex >= 0
			If flag Then
				Me.lstB1.SelectedIndex = Me.lstB2.SelectedIndex
			End If
		End Sub

		' Token: 0x0600011B RID: 283 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		Private Sub lstB1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstB1.SelectedIndex >= 0
			If flag Then
				Me.lstB2.SelectedIndex = Me.lstB1.SelectedIndex
			End If
		End Sub

		' Token: 0x0600011C RID: 284 RVA: 0x0000F934 File Offset: 0x0000DB34
		Private Sub OpenFileLoc()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.ODfile.Title = "Open File"
				IL_1E:
				num2 = 3
				Me.ODfile.Filter = "Excel - (*.xls;*.xlsx)|*.xls;*.xlsx"
				IL_31:
				num2 = 4
				Me.ODfile.FilterIndex = 1
				IL_40:
				num2 = 5
				Me.ODfile.Multiselect = False
				IL_4F:
				num2 = 6
				Dim flag As Boolean = Me.ODfile.ShowDialog() = DialogResult.OK
				If Not flag Then
					GoTo IL_BE
				End If
				IL_63:
				num2 = 7
				Dim flag2 As Boolean = Strings.Len(Me.ODfile.FileName) > 2
				If Not flag2 Then
					GoTo IL_BC
				End If
				IL_7E:
				num2 = 8
				Me.FileNamePath = Me.ODfile.FileName
				IL_91:
				num2 = 9
				Me.btnOpen.Enabled = False
				IL_A1:
				num2 = 10
				Me.OpenExcelFileToprocess()
				IL_AB:
				num2 = 11
				Me.btnOpen.Enabled = True
				IL_BB:
				IL_BC:
				IL_BD:
				IL_BE:
				IL_BF:
				GoTo IL_151
				IL_C4:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_10A:
				GoTo IL_146
				IL_10C:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_124:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10C
			End Try
			IL_146:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_151:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600011D RID: 285 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		Private Sub DoExcelImport()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num7 As Integer
			Dim obj3 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Integer = 0
				Me.Cursor = Cursors.WaitCursor
				Me.PB1.Minimum = 0
				Me.PB1.Value = 0
				Me.PB1.Maximum = CInt(Math.Round(Conversion.Val(Me.lblC.Text)))
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""))
				Dim instance As Object = NewLateBinding.LateGet(objectValue, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
				Dim type As Type = Nothing
				Dim memberName As String = "Open"
				Dim array As Object() = New Object(0) {}
				Dim num3 As Integer = 0
				Dim ptr As String = Me.FileNamePath
				array(num3) = Me.FileNamePath
				Dim array2 As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array3 As Boolean() = New Boolean() { True }
				Dim array4 As Boolean() = array3
				Dim obj As Object = NewLateBinding.LateGet(instance, type, memberName, array, argumentNames, typeArguments, array3)
				If array4(0) Then
					ptr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
				End If
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj)
				NewLateBinding.LateSet(objectValue, Nothing, "DisplayAlerts", New Object() { False }, Nothing, Nothing)
				Dim objectValue3 As Object
				Dim num6 As Long
				Dim flag3 As Boolean
				Do
					Dim instance2 As Object = objectValue2
					Dim type2 As Type = Nothing
					Dim memberName2 As String = "Worksheets"
					Dim array5 As Object() = New Object(0) {}
					Dim num4 As Integer = 0
					Dim items As ListBox.ObjectCollection = Me.lstB1.Items
					Dim objectCollection As ListBox.ObjectCollection = items
					Dim num5 As Integer = num2
					Dim index As Integer = num5
					array5(num4) = items(num5)
					array2 = array5
					Dim argumentNames2 As String() = Nothing
					Dim typeArguments2 As Type() = Nothing
					Dim array6 As Boolean() = New Boolean() { True }
					array4 = array6
					Dim obj2 As Object = NewLateBinding.LateGet(instance2, type2, memberName2, array5, argumentNames2, typeArguments2, array6)
					If array4(0) Then
						objectCollection(index) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))
					End If
					objectValue3 = RuntimeHelpers.GetObjectValue(obj2)
					num6 = 1L
					While True
						Dim flag As Boolean = Operators.ConditionalCompareObjectGreater(num6, Me.lstB2.Items(num2), False)
						If flag Then
							Exit For
						End If
						Dim flag2 As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Range", New Object() { Me.cmbColom.Text + num6.ToString() }, Nothing, Nothing, Nothing), Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing)))
						If flag2 Then
							Dim eer As String = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Range", New Object() { Me.cmbColom.Text + num6.ToString() }, Nothing, Nothing, Nothing), Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Trim()
							Me.AddBoxToLstPre(eer)
						End If
						Dim pb As ProgressBar = Me.PB1
						Dim progressBar As ProgressBar = pb
						pb.Value = progressBar.Value + 1
						Application.DoEvents()
						num6 += 1L
					End While
					num2 += 1
					flag3 = (num2 < Me.lstB2.Items.Count And Information.Err().Number = 0)
				Loop While flag3
				NewLateBinding.LateCall(objectValue2, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue))
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2))
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3))
				Me.Cursor = Cursors.[Default]
				Dim flag4 As Boolean = num6 > 3L
				If flag4 Then
					Interaction.MsgBox("تم استيراد جميع الارقام بنجاح", MsgBoxStyle.Information, Nothing)
				End If
				IL_38E:
				GoTo IL_3D1
				IL_373:
				Me.Cursor = Cursors.[Default]
				Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical, Nothing)
				GoTo IL_38E
				IL_390:
				num7 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3A4:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_390
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3D1:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600011E RID: 286 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		Private Sub OpenExcelFileToprocess()
			Dim num As Integer
			Dim num6 As Integer
			Dim obj3 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Long = 1L
				Dim num3 As Double = 1.0
				Dim num4 As Double = 0.0
				Dim flag As Boolean = Operators.CompareString(Me.FileNamePath.Trim(), "", False) = 0
				If Not flag Then
					Me.Cursor = Cursors.WaitCursor
					Dim obj As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""))
					Dim instance As Object = NewLateBinding.LateGet(obj, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
					Dim type As Type = Nothing
					Dim memberName As String = "Open"
					Dim array As Object() = New Object(0) {}
					Dim num5 As Integer = 0
					Dim ptr As String = Me.FileNamePath
					array(num5) = Me.FileNamePath
					Dim array2 As Object() = array
					Dim argumentNames As String() = Nothing
					Dim typeArguments As Type() = Nothing
					Dim array3 As Boolean() = New Boolean() { True }
					Dim array4 As Boolean() = array3
					Dim obj2 As Object = NewLateBinding.LateGet(instance, type, memberName, array, argumentNames, typeArguments, array3)
					If array4(0) Then
						ptr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
					End If
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj2)
					NewLateBinding.LateSet(obj, Nothing, "DisplayAlerts", New Object() { False }, Nothing, Nothing)
					num2 = 1L
					Me.lblC.Text = "0"
					Me.lstB1.Items.Clear()
					Me.lstB2.Items.Clear()
					num4 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "Worksheets", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing))
					Dim objectValue2 As Object
					While True
						Dim instance2 As Object = objectValue
						Dim type2 As Type = Nothing
						Dim memberName2 As String = "Worksheets"
						Dim array5 As Object() = New Object() { num3 }
						array2 = array5
						Dim argumentNames2 As String() = Nothing
						Dim typeArguments2 As Type() = Nothing
						Dim array6 As Boolean() = New Boolean() { True }
						array4 = array6
						obj2 = NewLateBinding.LateGet(instance2, type2, memberName2, array5, argumentNames2, typeArguments2, array6)
						If array4(0) Then
							num3 = CDbl(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Double)))
						End If
						objectValue2 = RuntimeHelpers.GetObjectValue(obj2)
						While True
							Dim flag2 As Boolean = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, Nothing, "Range", New Object() { Me.cmbColom.Text + num2.ToString() }, Nothing, Nothing, Nothing), Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Trim().Length < 4
							If flag2 Then
								Exit For
							End If
							num2 += 1L
						End While
						IL_242:
						num2 -= 1L
						Dim flag3 As Boolean = num2 > 1L
						If flag3 Then
							Me.lstB1.Items.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)))
							Me.lstB2.Items.Add(num2)
						End If
						num3 += 1.0
						Me.lblC.Text = Conversions.ToString(Conversion.Val(Me.lblC.Text) + CDbl(num2))
						Dim flag4 As Boolean = Conversion.Val(Me.lblC.Text) < 0.0
						If flag4 Then
							Me.lblC.Text = "0"
						End If
						Dim flag5 As Boolean = num3 <= num4 And Information.Err().Number = 0
						If Not flag5 Then
							Exit For
						End If
						num2 = 1L
					End While
					NewLateBinding.LateCall(objectValue, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Me.releaseObject(RuntimeHelpers.GetObjectValue(obj))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2))
					obj = Nothing
					Me.Cursor = Cursors.[Default]
				End If
				GoTo IL_3B8
				IL_377:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_38B:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_377
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3B8:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600011F RID: 287 RVA: 0x0000B3A4 File Offset: 0x000095A4
		Private Sub releaseObject(obj As Object)
			Try
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj))
				obj = Nothing
			Catch ex As Exception
				obj = Nothing
			Finally
				Dim flag As Boolean = obj IsNot Nothing
				If flag Then
					Dim generation As Integer = GC.GetGeneration(RuntimeHelpers.GetObjectValue(obj))
					GC.Collect(generation)
				Else
					GC.Collect()
					GC.WaitForPendingFinalizers()
				End If
			End Try
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x000102A8 File Offset: 0x0000E4A8
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Conversion.Val(Me.lblC.Text) > 0.0
				If Not flag Then
					IL_57:
					num2 = 7
					Interaction.MsgBox("لا يوجد ارقام للتنفيذ", MsgBoxStyle.Critical, Nothing)
					IL_67:
					GoTo IL_68
				End If
				IL_2C:
				num2 = 3
				Me.btnExport.Enabled = False
				IL_3B:
				num2 = 4
				Me.DoExcelImport()
				IL_44:
				num2 = 5
				Me.btnExport.Enabled = True
				IL_53:
				IL_68:
				GoTo IL_E3
				IL_6A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_9C:
				GoTo IL_D8
				IL_9E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_B6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9E
			End Try
			IL_D8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000121 RID: 289 RVA: 0x000103B4 File Offset: 0x0000E5B4
		Private Sub cmbPaste_Click(sender As Object, e As EventArgs)
			Dim text As String = Clipboard.GetText()
			Dim flag As Boolean = text.Trim().Length > 0
			If flag Then
				Me.txtDail.Text = text.Trim()
				Clipboard.Clear()
			End If
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x000103F4 File Offset: 0x0000E5F4
		Private Function OpensaveAs(tempFilename As String) As String
			Dim num As Integer
			Dim result As String
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.SFD.Title = "Save File AS"
				IL_1E:
				num2 = 3
				Me.SFD.Filter = "Excel - (*.xls)|*.xls"
				IL_31:
				num2 = 4
				Me.SFD.FilterIndex = 1
				IL_40:
				num2 = 5
				Me.SFD.FileName = tempFilename
				IL_4F:
				num2 = 6
				Dim flag As Boolean = Me.SFD.ShowDialog() = DialogResult.OK
				If Not flag Then
					GoTo IL_95
				End If
				IL_65:
				num2 = 7
				Dim flag2 As Boolean = Strings.Len(Me.SFD.FileName) > 2
				If Not flag2 Then
					GoTo IL_93
				End If
				IL_80:
				num2 = 8
				result = Me.SFD.FileName
				GoTo IL_A1
				IL_93:
				IL_94:
				IL_95:
				IL_96:
				num2 = 12
				result = ""
				IL_A1:
				GoTo IL_12F
				IL_90:
				GoTo IL_A1
				IL_92:
				GoTo IL_93
				IL_A6:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E8:
				GoTo IL_124
				IL_EA:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_102:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_EA
			End Try
			IL_124:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_12F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000123 RID: 291 RVA: 0x00010558 File Offset: 0x0000E758
		Private Sub btnSaveAS_Click(sender As Object, e As EventArgs)
			Dim text As String = "X_" + DateAndTime.Today.Month.ToString() + "_" + DateAndTime.Today.Day.ToString()
			Dim flag As Boolean = Strings.Len(text) > 2
			If flag Then
				Dim text2 As String = Me.OpensaveAs(text)
				Dim flag2 As Boolean = Operators.CompareString(text2, "", False) = 0
				If Not flag2 Then
					Me.lblSavePath.Text = text2.Trim(New Char() { "s"c }).Trim(New Char() { "l"c }).Trim(New Char() { "x"c }).Trim(New Char() { "."c })
				End If
			End If
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x0001062C File Offset: 0x0000E82C
		Private Sub btnExport2_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Double = 1.0
				Dim flag As Boolean = Me.lblSavePath.Text.Length <= 1
				If Not flag Then
					Me.Cursor = Cursors.WaitCursor
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION", ""))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Open", New Object() { Application.StartupPath + "\reports\xyz2.xls" }, Nothing, Nothing, Nothing))
					NewLateBinding.LateSet(objectValue, Nothing, "DisplayAlerts", New Object() { False }, Nothing, Nothing)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, Nothing, "Worksheets", New Object() { "Sheet1" }, Nothing, Nothing, Nothing))
					Dim num3 As Double = 0.0
					While True
						' The following expression was wrapped in a checked-statement
						Dim flag2 As Boolean = num3 > CDbl((Me.lstNumbers.Items.Count - 1))
						If flag2 Then
							Exit For
						End If
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, Nothing, "Range", New Object() { "A" + num2.ToString() }, Nothing, Nothing, Nothing), Nothing, "Value", New Object() { Me.lstNumbers.Items(CInt(Math.Round(num3))) }, Nothing, Nothing, False, True)
						num2 += 1.0
						num3 += 1.0
					End While
					Dim flag3 As Boolean = num2 > 1.0
					If flag3 Then
						NewLateBinding.LateCall(objectValue2, Nothing, "SaveAs", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Me.lblSavePath.Text + "_", Me.lstNumbers.Items(0)), ".xls") }, Nothing, Nothing, Nothing, True)
					Else
						Interaction.MsgBox("لا توجد اى ارقام ", MsgBoxStyle.Critical, Nothing)
					End If
					NewLateBinding.LateCall(objectValue2, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3))
					Me.Cursor = Cursors.[Default]
					Dim flag4 As Boolean = num2 > 3.0
					If flag4 Then
						Interaction.MsgBox("تم تصدير جميع الارقام بنجاح", MsgBoxStyle.Information, Nothing)
					End If
				End If
				IL_2A5:
				GoTo IL_2E8
				IL_28A:
				Me.Cursor = Cursors.[Default]
				Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical, Nothing)
				GoTo IL_2A5
				IL_2A7:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2BB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2A7
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2E8:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000125 RID: 293 RVA: 0x00010948 File Offset: 0x0000EB48
		Private Sub btnAddFF_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Conversion.Val(Me.txtEnumSH.Text) > 0.0
			If flag Then
				Me.GetAllSmsfromDBExc(Me.txtEnumSH.Text)
			End If
		End Sub

		' Token: 0x06000126 RID: 294 RVA: 0x0001098C File Offset: 0x0000EB8C
		Private Sub btnSaveFromOut_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Me.btnSaveFromOut.Enabled = False
				IL_1A:
				num2 = 3
				Dim flag As Boolean = MyProject.Forms.frmUssd.lblNum1.Text.Trim().Length > 0
				If Not flag Then
					GoTo IL_72
				End If
				IL_41:
				num2 = 4
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum1.Text.Trim()
				IL_68:
				num2 = 5
				Me.Addtelnumber()
				IL_71:
				IL_72:
				IL_73:
				num2 = 7
				Dim flag2 As Boolean = MyProject.Forms.frmUssd.lblNum2.Text.Trim().Length > 0
				If Not flag2 Then
					GoTo IL_CE
				End If
				IL_9C:
				num2 = 8
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum2.Text.Trim()
				IL_C3:
				num2 = 9
				Me.Addtelnumber()
				IL_CD:
				IL_CE:
				IL_CF:
				num2 = 11
				Dim flag3 As Boolean = MyProject.Forms.frmUssd.lblNum3.Text.Trim().Length > 0
				If Not flag3 Then
					GoTo IL_12C
				End If
				IL_F9:
				num2 = 12
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum3.Text.Trim()
				IL_121:
				num2 = 13
				Me.Addtelnumber()
				IL_12B:
				IL_12C:
				IL_12D:
				num2 = 15
				Dim flag4 As Boolean = MyProject.Forms.frmUssd.lblNum4.Text.Trim().Length > 0
				If Not flag4 Then
					GoTo IL_18A
				End If
				IL_157:
				num2 = 16
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum4.Text.Trim()
				IL_17F:
				num2 = 17
				Me.Addtelnumber()
				IL_189:
				IL_18A:
				IL_18B:
				num2 = 19
				Dim flag5 As Boolean = MyProject.Forms.frmUssd.lblNum5.Text.Trim().Length > 0
				If Not flag5 Then
					GoTo IL_1E8
				End If
				IL_1B5:
				num2 = 20
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum5.Text.Trim()
				IL_1DD:
				num2 = 21
				Me.Addtelnumber()
				IL_1E7:
				IL_1E8:
				IL_1E9:
				num2 = 23
				Dim flag6 As Boolean = MyProject.Forms.frmUssd.lblNum6.Text.Trim().Length > 0
				If Not flag6 Then
					GoTo IL_246
				End If
				IL_213:
				num2 = 24
				Me.txtDail.Text = MyProject.Forms.frmUssd.lblNum6.Text.Trim()
				IL_23B:
				num2 = 25
				Me.Addtelnumber()
				IL_245:
				IL_246:
				IL_247:
				num2 = 27
				Me.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_266:
				num2 = 28
				Application.DoEvents()
				IL_26F:
				num2 = 29
				Me.btnSaveFromOut.Enabled = True
				IL_27F:
				GoTo IL_351
				IL_284:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_30A:
				GoTo IL_346
				IL_30C:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_324:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_30C
			End Try
			IL_346:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_351:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000127 RID: 295 RVA: 0x0000257C File Offset: 0x0000077C
		Private Sub txtEnumSH_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000128 RID: 296 RVA: 0x00010D10 File Offset: 0x0000EF10
		Private Sub btnTransfer_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Conversion.Val(Me.txtEnumSH.Text) > 0.0
			If flag Then
				Me.GetAllSmsfromWWDB(Me.txtEnumSH.Text)
			End If
		End Sub

		' Token: 0x06000129 RID: 297 RVA: 0x0000257C File Offset: 0x0000077C
		Private Sub txtCardNew_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600012A RID: 298 RVA: 0x0000257C File Offset: 0x0000077C
		Private Sub txtDail_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600012B RID: 299 RVA: 0x00010D54 File Offset: 0x0000EF54
		Private Sub btnAddFromWebServer_Click(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0F:
				num2 = 3
				Dim num4 As Integer = CInt(Interaction.MsgBox("are you sure", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_20:
				num2 = 4
				Dim flag As Boolean = num4 = 7
				If Not flag Then
					GoTo IL_32
				End If
				IL_2D:
				GoTo IL_183
				IL_32:
				num2 = 6
				Me.AutoFlag = True
				IL_3B:
				num2 = 7
				Dim num5 As Integer = 0
				IL_40:
				num2 = 8
				Me.btnAddFromWebServer.Enabled = False
				IL_4F:
				While True
					IL_10E:
					num2 = 10
					Dim flag2 As Boolean = num3 >= MyProject.Forms.frmUssd.lstWebQry.Items.Count
					If flag2 Then
						Exit For
					End If
					IL_54:
					num2 = 11
					Me.txtDail.Text = Conversions.ToString(MyProject.Forms.frmUssd.lstWebQry.Items(num3))
					IL_82:
					num2 = 12
					Me.Addtelnumber()
					IL_8C:
					num2 = 13
					num3 += 1
					IL_93:
					num2 = 14
					num5 += 1
					IL_9C:
					num2 = 15
					Dim flag3 As Boolean = CDbl(num5) >= Conversion.Val(Me.txtGroupQty.Text)
					If flag3 Then
						IL_BD:
						num2 = 16
						num5 = 0
						IL_C3:
						num2 = 17
						Me.btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e)
						IL_D4:
					End If
					IL_D6:
					num2 = 19
					Me.lblCount.Text = Conversions.ToString(Conversion.Val(Me.lblCount.Text) + 1.0)
					IL_104:
					num2 = 20
					Application.DoEvents()
					IL_10D:
				End While
				IL_139:
				num2 = 22
				Me.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_158:
				num2 = 23
				Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information, Nothing)
				IL_169:
				num2 = 24
				Me.AutoFlag = False
				IL_173:
				num2 = 25
				Me.btnAddFromWebServer.Enabled = True
				IL_183:
				GoTo IL_245
				IL_188:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_1FE:
				GoTo IL_23A
				IL_200:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_218:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_200
			End Try
			IL_23A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_245:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0400006D RID: 109
		Private objData As CData

		' Token: 0x0400006E RID: 110
		Private objDataTabletemp As DataTable

		' Token: 0x0400006F RID: 111
		Private AutoFlag As Boolean

		' Token: 0x04000070 RID: 112
		Private CurrIndex As Integer

		' Token: 0x04000071 RID: 113
		Private CLICODE As String

		' Token: 0x04000072 RID: 114
		Private FileNamePath As String
	End Class
End Namespace
