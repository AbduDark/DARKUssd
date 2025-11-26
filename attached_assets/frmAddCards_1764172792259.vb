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

Namespace MTUssd
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class frmAddCards
		Inherits Form

		' Token: 0x06000039 RID: 57 RVA: 0x0000230D File Offset: 0x0000050D
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmAddCards_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600003C RID: 60 RVA: 0x0000232D File Offset: 0x0000052D
		' (set) Token: 0x0600003D RID: 61 RVA: 0x000085A4 File Offset: 0x000067A4
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

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600003E RID: 62 RVA: 0x00002337 File Offset: 0x00000537
		' (set) Token: 0x0600003F RID: 63 RVA: 0x000085E8 File Offset: 0x000067E8
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

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000040 RID: 64 RVA: 0x00002341 File Offset: 0x00000541
		' (set) Token: 0x06000041 RID: 65 RVA: 0x0000234B File Offset: 0x0000054B
		Friend Overridable Property lblTelNum As Label

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000042 RID: 66 RVA: 0x00002354 File Offset: 0x00000554
		' (set) Token: 0x06000043 RID: 67 RVA: 0x0000235E File Offset: 0x0000055E
		Friend Overridable Property lblCount As Label

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x06000044 RID: 68 RVA: 0x00002367 File Offset: 0x00000567
		' (set) Token: 0x06000045 RID: 69 RVA: 0x00002371 File Offset: 0x00000571
		Friend Overridable Property Label4 As Label

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x06000046 RID: 70 RVA: 0x0000237A File Offset: 0x0000057A
		' (set) Token: 0x06000047 RID: 71 RVA: 0x0000862C File Offset: 0x0000682C
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

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000048 RID: 72 RVA: 0x00002384 File Offset: 0x00000584
		' (set) Token: 0x06000049 RID: 73 RVA: 0x00008670 File Offset: 0x00006870
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

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600004A RID: 74 RVA: 0x0000238E File Offset: 0x0000058E
		' (set) Token: 0x0600004B RID: 75 RVA: 0x000086B4 File Offset: 0x000068B4
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

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x0600004C RID: 76 RVA: 0x00002398 File Offset: 0x00000598
		' (set) Token: 0x0600004D RID: 77 RVA: 0x000086F8 File Offset: 0x000068F8
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

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x0600004E RID: 78 RVA: 0x000023A2 File Offset: 0x000005A2
		' (set) Token: 0x0600004F RID: 79 RVA: 0x000023AC File Offset: 0x000005AC
		Friend Overridable Property Label10 As Label

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000050 RID: 80 RVA: 0x000023B5 File Offset: 0x000005B5
		' (set) Token: 0x06000051 RID: 81 RVA: 0x00008758 File Offset: 0x00006958
		Friend Overridable Property txtEnumSH As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtEnumSH
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.txtEnumSH_KeyPress
				Dim txtEnumSH As TextBox = Me._txtEnumSH
				If txtEnumSH IsNot Nothing Then
					RemoveHandler txtEnumSH.KeyPress, value2
				End If
				Me._txtEnumSH = value
				txtEnumSH = Me._txtEnumSH
				If txtEnumSH IsNot Nothing Then
					AddHandler txtEnumSH.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000052 RID: 82 RVA: 0x000023BF File Offset: 0x000005BF
		' (set) Token: 0x06000053 RID: 83 RVA: 0x000023C9 File Offset: 0x000005C9
		Friend Overridable Property Label1 As Label

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000054 RID: 84 RVA: 0x000023D2 File Offset: 0x000005D2
		' (set) Token: 0x06000055 RID: 85 RVA: 0x000023DC File Offset: 0x000005DC
		Friend Overridable Property txtCardValue As TextBox

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000056 RID: 86 RVA: 0x000023E5 File Offset: 0x000005E5
		' (set) Token: 0x06000057 RID: 87 RVA: 0x000023EF File Offset: 0x000005EF
		Friend Overridable Property PB1 As ProgressBar

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000058 RID: 88 RVA: 0x000023F8 File Offset: 0x000005F8
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00002402 File Offset: 0x00000602
		Friend Overridable Property cmbColom As ComboBox

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x0600005A RID: 90 RVA: 0x0000240B File Offset: 0x0000060B
		' (set) Token: 0x0600005B RID: 91 RVA: 0x0000879C File Offset: 0x0000699C
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

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600005C RID: 92 RVA: 0x00002415 File Offset: 0x00000615
		' (set) Token: 0x0600005D RID: 93 RVA: 0x000087E0 File Offset: 0x000069E0
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

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600005E RID: 94 RVA: 0x0000241F File Offset: 0x0000061F
		' (set) Token: 0x0600005F RID: 95 RVA: 0x00008824 File Offset: 0x00006A24
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

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000060 RID: 96 RVA: 0x00002429 File Offset: 0x00000629
		' (set) Token: 0x06000061 RID: 97 RVA: 0x00002433 File Offset: 0x00000633
		Friend Overridable Property lblC As Label

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000062 RID: 98 RVA: 0x0000243C File Offset: 0x0000063C
		' (set) Token: 0x06000063 RID: 99 RVA: 0x00002446 File Offset: 0x00000646
		Friend Overridable Property Label18 As Label

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000064 RID: 100 RVA: 0x0000244F File Offset: 0x0000064F
		' (set) Token: 0x06000065 RID: 101 RVA: 0x00008868 File Offset: 0x00006A68
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

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000066 RID: 102 RVA: 0x00002459 File Offset: 0x00000659
		' (set) Token: 0x06000067 RID: 103 RVA: 0x000088AC File Offset: 0x00006AAC
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

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000068 RID: 104 RVA: 0x00002463 File Offset: 0x00000663
		' (set) Token: 0x06000069 RID: 105 RVA: 0x0000246D File Offset: 0x0000066D
		Friend Overridable Property ODfile As OpenFileDialog

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00002476 File Offset: 0x00000676
		' (set) Token: 0x0600006B RID: 107 RVA: 0x000088F0 File Offset: 0x00006AF0
		Friend Overridable Property txtCardNew As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtCardNew
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.txtCardNew_KeyPress
				Dim txtCardNew As TextBox = Me._txtCardNew
				If txtCardNew IsNot Nothing Then
					RemoveHandler txtCardNew.KeyPress, value2
				End If
				Me._txtCardNew = value
				txtCardNew = Me._txtCardNew
				If txtCardNew IsNot Nothing Then
					AddHandler txtCardNew.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00002480 File Offset: 0x00000680
		' (set) Token: 0x0600006D RID: 109 RVA: 0x0000248A File Offset: 0x0000068A
		Friend Overridable Property Label3 As Label

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00002493 File Offset: 0x00000693
		' (set) Token: 0x0600006F RID: 111 RVA: 0x0000249D File Offset: 0x0000069D
		Friend Overridable Property lstNumbers As ListBox

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000070 RID: 112 RVA: 0x000024A6 File Offset: 0x000006A6
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00008934 File Offset: 0x00006B34
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

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000072 RID: 114 RVA: 0x000024B0 File Offset: 0x000006B0
		' (set) Token: 0x06000073 RID: 115 RVA: 0x00008978 File Offset: 0x00006B78
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

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000074 RID: 116 RVA: 0x000024BA File Offset: 0x000006BA
		' (set) Token: 0x06000075 RID: 117 RVA: 0x000024C4 File Offset: 0x000006C4
		Friend Overridable Property lblCountPre As Label

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000024CD File Offset: 0x000006CD
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000089BC File Offset: 0x00006BBC
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

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000078 RID: 120 RVA: 0x000024D7 File Offset: 0x000006D7
		' (set) Token: 0x06000079 RID: 121 RVA: 0x000024E1 File Offset: 0x000006E1
		Friend Overridable Property txtTemp As TextBox

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600007A RID: 122 RVA: 0x000024EA File Offset: 0x000006EA
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00008A00 File Offset: 0x00006C00
		Friend Overridable Property btnAddIQ As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAddIQ
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddIQ_Click
				Dim btnAddIQ As Button = Me._btnAddIQ
				If btnAddIQ IsNot Nothing Then
					RemoveHandler btnAddIQ.Click, value2
				End If
				Me._btnAddIQ = value
				btnAddIQ = Me._btnAddIQ
				If btnAddIQ IsNot Nothing Then
					AddHandler btnAddIQ.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600007C RID: 124 RVA: 0x000024F4 File Offset: 0x000006F4
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00008A44 File Offset: 0x00006C44
		Friend Overridable Property btnPast2 As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPast2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnPast2_Click
				Dim btnPast As Button = Me._btnPast2
				If btnPast IsNot Nothing Then
					RemoveHandler btnPast.Click, value2
				End If
				Me._btnPast2 = value
				btnPast = Me._btnPast2
				If btnPast IsNot Nothing Then
					AddHandler btnPast.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600007E RID: 126 RVA: 0x000024FE File Offset: 0x000006FE
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00008A88 File Offset: 0x00006C88
		Friend Overridable Property btnCleattemp As Button
			<CompilerGenerated()>
			Get
				Return Me._btnCleattemp
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCleattemp_Click
				Dim btnCleattemp As Button = Me._btnCleattemp
				If btnCleattemp IsNot Nothing Then
					RemoveHandler btnCleattemp.Click, value2
				End If
				Me._btnCleattemp = value
				btnCleattemp = Me._btnCleattemp
				If btnCleattemp IsNot Nothing Then
					AddHandler btnCleattemp.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00002508 File Offset: 0x00000708
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00002512 File Offset: 0x00000712
		Friend Overridable Property SFD As SaveFileDialog

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000082 RID: 130 RVA: 0x0000251B File Offset: 0x0000071B
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00008ACC File Offset: 0x00006CCC
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

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000084 RID: 132 RVA: 0x00002525 File Offset: 0x00000725
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00008B10 File Offset: 0x00006D10
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

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0000252F File Offset: 0x0000072F
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00002539 File Offset: 0x00000739
		Friend Overridable Property lblSavePath As Label

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000088 RID: 136 RVA: 0x00002542 File Offset: 0x00000742
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00008B54 File Offset: 0x00006D54
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

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008A RID: 138 RVA: 0x0000254C File Offset: 0x0000074C
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002556 File Offset: 0x00000756
		Friend Overridable Property RBVoda As RadioButton

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x0600008C RID: 140 RVA: 0x0000255F File Offset: 0x0000075F
		' (set) Token: 0x0600008D RID: 141 RVA: 0x00002569 File Offset: 0x00000769
		Friend Overridable Property RBEts As RadioButton

		' Token: 0x0600008E RID: 142 RVA: 0x00008B98 File Offset: 0x00006D98
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

		' Token: 0x0600008F RID: 143 RVA: 0x00008C48 File Offset: 0x00006E48
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
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT distinct enums FROM cardscharge order by enums")
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

		' Token: 0x06000090 RID: 144 RVA: 0x00008D7C File Offset: 0x00006F7C
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
				Dim text As String = "Insert Into cardscharge "
				IL_13:
				num2 = 3
				text += "(enums,edate,estatus,evalue,eets,cardid)"
				IL_21:
				num2 = 4
				text += "Values ("
				IL_2F:
				num2 = 5
				text = text + " " + Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)) + " , "
				IL_57:
				num2 = 6
				text = text + "#" + Conversions.ToString(DateTime.Today) + "#, "
				IL_74:
				num2 = 7
				text += " 0 , "
				IL_82:
				num2 = 8
				text = text + " " + Conversions.ToString(Conversion.Val(Me.txtCardValue.Text)) + " , "
				IL_AA:
				num2 = 9
				Dim checked As Boolean = Me.RBEts.Checked
				If Not checked Then
					IL_D1:
					num2 = 12
					text += " 1 , "
					IL_E0:
					GoTo IL_E1
				End If
				IL_BE:
				num2 = 10
				text += " 0 , "
				IL_CD:
				IL_E1:
				num2 = 14
				text = text + "'" + cardIDx + "') "
				IL_F6:
				num2 = 15
				Me.objData.DatabaseCommand(text)
				IL_106:
				GoTo IL_1A0
				IL_10B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_159:
				GoTo IL_195
				IL_15B:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_173:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_15B
			End Try
			IL_195:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1A0:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x00008F50 File Offset: 0x00007150
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
				GoTo IL_176
				IL_6B:
				IL_6C:
				num2 = 8
				Dim flag2 As Boolean = Me.txtDail.Text.Trim().Length <> 15 And Me.btnADDAuto.Enabled
				If Not flag2 Then
					GoTo IL_C7
				End If
				IL_9C:
				num2 = 9
				Interaction.MsgBox("الرقم غير سليم", MsgBoxStyle.Critical, Nothing)
				IL_AD:
				num2 = 10
				Me.txtDail.BackColor = Color.PaleVioletRed
				IL_C1:
				GoTo IL_176
				IL_C7:
				IL_C8:
				num2 = 13
				Dim enabled As Boolean = Me.btnADDAuto.Enabled
				If Not enabled Then
					GoTo IL_114
				End If
				IL_DC:
				num2 = 14
				Dim flag3 As Boolean = Me.chktelNumFound(Me.txtDail.Text.Trim())
				If Not flag3 Then
					GoTo IL_112
				End If
				IL_FB:
				num2 = 15
				Me.txtDail.BackColor = Color.PaleVioletRed
				IL_10F:
				GoTo IL_176
				IL_112:
				IL_113:
				IL_114:
				IL_115:
				num2 = 19
				Me.AddTelNum(Me.txtDail.Text.Trim())
				IL_12F:
				num2 = 20
				Dim enabled2 As Boolean = Me.btnADDAuto.Enabled
				If Not enabled2 Then
					GoTo IL_162
				End If
				IL_143:
				num2 = 21
				Me.GetAllSmsfromDB(Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_162:
				num2 = 22
				Me.txtDail.BackColor = Color.PaleGreen
				IL_176:
				GoTo IL_22C
				IL_6A:
				GoTo IL_6B
				IL_C6:
				GoTo IL_C7
				IL_111:
				GoTo IL_112
				IL_17B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1E5:
				GoTo IL_221
				IL_1E7:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_1FF:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1E7
			End Try
			IL_221:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_22C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x000091B0 File Offset: 0x000073B0
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
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM cardscharge where  cardid = '" + eetel + "'")
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

		' Token: 0x06000093 RID: 147 RVA: 0x000092EC File Offset: 0x000074EC
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
				dataTable.Columns.Add("الكارت")
				IL_2D:
				num2 = 4
				dataTable.Columns.Add("الفئة")
				IL_41:
				num2 = 5
				dataTable.Columns.Add("الحالة")
				IL_55:
				num2 = 6
				IL_5A:
				num2 = 7
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM cardscharge where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid")
				IL_87:
				num2 = 8
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_17B
				End If
				IL_A5:
				num2 = 9
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_C3:
					num2 = 10
					Dim dataRow As DataRow = dataTable.NewRow()
					IL_CF:
					num2 = 11
					dataRow(0) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("cardid"))
					IL_FB:
					num2 = 12
					dataRow(1) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("evalue"))
					IL_127:
					num2 = 13
					dataRow(2) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("estatus"))
					IL_153:
					num2 = 14
					dataTable.Rows.Add(dataRow)
					IL_165:
					num2 = 15
					dataRow = Nothing
					IL_16B:
					num2 = 16
				Next
				IL_17A:
				IL_17B:
				IL_17C:
				num2 = 18
				Me.lblCount.Text = Conversions.ToString(Me.objDataTabletemp.Rows.Count)
				IL_1A0:
				num2 = 19
				Me.dataViewGrid.DataSource = dataTable
				IL_1B1:
				num2 = 20
				Me.dataViewGrid.Columns(0).Width = 160
				IL_1D0:
				num2 = 21
				Me.dataViewGrid.Columns(1).Width = 80
				IL_1EC:
				num2 = 22
				Me.dataViewGrid.Columns(2).Width = 80
				IL_208:
				GoTo IL_2BE
				IL_20D:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_277:
				GoTo IL_2B3
				IL_279:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_291:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_279
			End Try
			IL_2B3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2BE:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x000095DC File Offset: 0x000077DC
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
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM cardscharge where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid")
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
					Me.AddBoxToLstPreXC(Conversions.ToString(Me.objDataTabletemp.Rows(i)("cardid")))
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

		' Token: 0x06000095 RID: 149 RVA: 0x0000975C File Offset: 0x0000795C
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
					GoTo IL_97
				End If
				IL_20:
				num2 = 3
				Dim flag2 As Boolean = Me.txtDail.Text.Trim().Length = 15 Or Me.txtDail.Text.Trim().Length = 16
				If Not flag2 Then
					GoTo IL_95
				End If
				IL_5B:
				num2 = 4
				Me.Addtelnumber()
				IL_64:
				num2 = 5
				Dim flag3 As Boolean = Me.txtDail.BackColor = Color.PaleGreen
				If Not flag3 Then
					GoTo IL_94
				End If
				IL_81:
				num2 = 6
				Me.txtDail.Text = ""
				IL_94:
				IL_95:
				IL_96:
				IL_97:
				IL_98:
				num2 = 9
				Dim flag4 As Boolean = Strings.Asc(e.KeyChar) <> 8
				If Not flag4 Then
					GoTo IL_E5
				End If
				IL_B2:
				num2 = 10
				Dim flag5 As Boolean = Strings.Asc(e.KeyChar) < 48 Or Strings.Asc(e.KeyChar) > 57
				If Not flag5 Then
					GoTo IL_E5
				End If
				IL_DA:
				num2 = 11
				e.KeyChar = vbNullChar
				IL_E5:
				GoTo IL_16F
				IL_EA:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_128:
				GoTo IL_164
				IL_12A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_142:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_12A
			End Try
			IL_164:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_16F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x00009900 File Offset: 0x00007B00
		Private Sub frmAddCards_Load(sender As Object, e As EventArgs)
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

		' Token: 0x06000097 RID: 151 RVA: 0x000099D4 File Offset: 0x00007BD4
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

		' Token: 0x06000098 RID: 152 RVA: 0x00009A9C File Offset: 0x00007C9C
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
					GoTo IL_4C
				End If
				IL_47:
				GoTo IL_120
				IL_4C:
				num2 = 5
				num3 = CInt(Interaction.MsgBox("هل  انت متاكد انك تريد حذف رقم حركة ادخال رقم" + Me.txtEnumSH.Text + vbCrLf & " وعددهم " + Me.lblCount.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_7C:
				num2 = 6
				Dim flag2 As Boolean = num3 = 7
				If Not flag2 Then
					GoTo IL_8D
				End If
				IL_88:
				GoTo IL_120
				IL_8D:
				num2 = 8
				num3 = CInt(Interaction.MsgBox("كل الكروت الموجودة على رقم الحركة سوف يتم حذفها " & vbCrLf & " ولا يمكن استرجاعها باى شكل من الاشكال هل تريد الاستمرار ", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
				IL_9D:
				num2 = 9
				Dim flag3 As Boolean = num3 = 7
				If Not flag3 Then
					GoTo IL_AC
				End If
				IL_AA:
				GoTo IL_120
				IL_AC:
				num2 = 11
				Me.objData.DatabaseCommand("Delete From cardscharge WHERE enums = " + Conversions.ToString(Conversion.Val(Me.txtEnumSH.Text)))
				IL_DA:
				num2 = 12
				Interaction.MsgBox("تم حذف رقم حركة ادخال رقم" + Me.txtEnumSH.Text + vbCrLf & " وعددهم " + Me.lblCount.Text, MsgBoxStyle.Information, Nothing)
				IL_10B:
				num2 = 13
				Me.GetAllSmsfromDB(Me.txtEnumSH.Text)
				IL_120:
				GoTo IL_1B2
				IL_125:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_16B:
				GoTo IL_1A7
				IL_16D:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_185:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_16D
			End Try
			IL_1A7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1B2:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x00009C80 File Offset: 0x00007E80
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

		' Token: 0x0600009A RID: 154 RVA: 0x00009DCC File Offset: 0x00007FCC
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

		' Token: 0x0600009B RID: 155 RVA: 0x00009E8C File Offset: 0x0000808C
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
				Dim num3 As Integer = CInt(Interaction.MsgBox("هل  تريد حذف الكارت" + Me.lblTelNum.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
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
				Me.objData.DatabaseCommand("Delete From cardscharge WHERE cardid = '" + Me.lblTelNum.Text + "'")
				IL_61:
				num2 = 6
				Interaction.MsgBox("تم حذف الكارت" + Me.lblTelNum.Text, MsgBoxStyle.Information, Nothing)
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

		' Token: 0x0600009C RID: 156 RVA: 0x00009FD8 File Offset: 0x000081D8
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
				Dim num4 As Integer = CInt(Interaction.MsgBox("هل تريد اضافة الكروت المحددة  الى النظام", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing))
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
				Interaction.MsgBox("تم اضافة الكروت بنجاح", MsgBoxStyle.Information, Nothing)
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

		' Token: 0x0600009D RID: 157 RVA: 0x0000A1DC File Offset: 0x000083DC
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

		' Token: 0x0600009E RID: 158 RVA: 0x0000A2D8 File Offset: 0x000084D8
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

		' Token: 0x0600009F RID: 159 RVA: 0x0000A398 File Offset: 0x00008598
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
					GoTo IL_DA
				End If
				IL_23:
				num2 = 3
				Dim flag2 As Boolean = Me.txtCardNew.Text.Trim().Length = 15 Or Me.txtCardNew.Text.Trim().Length = 16
				If Not flag2 Then
					GoTo IL_D8
				End If
				IL_5E:
				num2 = 4
				Me.txtCardNew.BackColor = Color.White
				IL_71:
				num2 = 5
				Dim flag3 As Boolean = Me.chktelNumFound(Me.txtCardNew.Text.Trim())
				If Not flag3 Then
					GoTo IL_A8
				End If
				IL_8F:
				num2 = 6
				Me.txtCardNew.BackColor = Color.PaleVioletRed
				IL_A2:
				GoTo IL_128
				IL_A8:
				IL_A9:
				num2 = 9
				Me.AddBoxToLstPre(Me.txtCardNew.Text.Trim())
				IL_C3:
				num2 = 10
				Me.txtCardNew.Text = ""
				IL_D7:
				IL_D8:
				IL_D9:
				IL_DA:
				IL_DB:
				num2 = 13
				Dim flag4 As Boolean = Strings.Asc(e.KeyChar) <> 8
				If Not flag4 Then
					GoTo IL_128
				End If
				IL_F5:
				num2 = 14
				Dim flag5 As Boolean = Strings.Asc(e.KeyChar) < 48 Or Strings.Asc(e.KeyChar) > 57
				If Not flag5 Then
					GoTo IL_128
				End If
				IL_11D:
				num2 = 15
				e.KeyChar = vbNullChar
				IL_128:
				GoTo IL_1C2
				IL_A7:
				GoTo IL_A8
				IL_12D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_17B:
				GoTo IL_1B7
				IL_17D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_195:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_17D
			End Try
			IL_1B7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1C2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x0000A58C File Offset: 0x0000878C
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
				Dim flag As Boolean = EER.Length = 15 Or EER.Length = 16
				If Not flag Then
					IL_43:
					GoTo IL_7D
				End If
				IL_2C:
				num2 = 4
				Dim flag2 As Boolean = Me.chktelNumFound(EER)
				If Not flag2 Then
					GoTo IL_3E
				End If
				IL_3B:
				GoTo IL_7D
				IL_3E:
				IL_3F:
				IL_46:
				num2 = 10
				num3 = Me.lstNumbers.FindString(EER)
				IL_56:
				num2 = 11
				Dim flag3 As Boolean = num3 >= 0
				If Not flag3 Then
					GoTo IL_68
				End If
				IL_66:
				GoTo IL_7D
				IL_68:
				num2 = 13
				Me.lstNumbers.Items.Add(EER)
				IL_7D:
				IL_7E:
				num2 = 14
				Me.lblCountPre.Text = Conversions.ToString(Me.lstNumbers.Items.Count)
				IL_A2:
				num2 = 15
				Application.DoEvents()
				IL_AB:
				GoTo IL_145
				IL_3D:
				IL_45:
				GoTo IL_46
				IL_B0:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_FE:
				GoTo IL_13A
				IL_100:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_118:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_100
			End Try
			IL_13A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_145:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x0000A704 File Offset: 0x00008904
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

		' Token: 0x060000A2 RID: 162 RVA: 0x00002572 File Offset: 0x00000772
		Private Sub btnOpen_Click(sender As Object, e As EventArgs)
			Me.OpenFileLoc()
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x0000A814 File Offset: 0x00008A14
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

		' Token: 0x060000A4 RID: 164 RVA: 0x0000A95C File Offset: 0x00008B5C
		Private Sub lstB2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstB2.SelectedIndex >= 0
			If flag Then
				Me.lstB1.SelectedIndex = Me.lstB2.SelectedIndex
			End If
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x0000A998 File Offset: 0x00008B98
		Private Sub lstB1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstB1.SelectedIndex >= 0
			If flag Then
				Me.lstB2.SelectedIndex = Me.lstB1.SelectedIndex
			End If
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x0000A9D4 File Offset: 0x00008BD4
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

		' Token: 0x060000A7 RID: 167 RVA: 0x0000AB58 File Offset: 0x00008D58
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
				Dim flag5 As Boolean
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
							Dim text As String = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Range", New Object() { Me.cmbColom.Text + num6.ToString() }, Nothing, Nothing, Nothing), Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Trim()
							Dim flag3 As Boolean = text.Length = 14
							If flag3 Then
								text = "0" + text
							Else
								Dim flag4 As Boolean = text.Length = 17
								If flag4 Then
									text = text.Trim(New Char() { "P"c }).Trim(New Char() { ":"c })
								End If
							End If
							Me.AddBoxToLstPre(text)
						End If
						Dim pb As ProgressBar = Me.PB1
						Dim progressBar As ProgressBar = pb
						pb.Value = progressBar.Value + 1
						Application.DoEvents()
						num6 += 1L
					End While
					num2 += 1
					flag5 = (num2 < Me.lstB2.Items.Count And Information.Err().Number = 0)
				Loop While flag5
				NewLateBinding.LateCall(objectValue2, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue))
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2))
				Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3))
				Me.Cursor = Cursors.[Default]
				Dim flag6 As Boolean = num6 > 3L
				If flag6 Then
					Interaction.MsgBox("تم استيراد جميع الكروت بنجاح", MsgBoxStyle.Information, Nothing)
				End If
				IL_3E9:
				GoTo IL_42C
				IL_3CE:
				Me.Cursor = Cursors.[Default]
				Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical, Nothing)
				GoTo IL_3E9
				IL_3EB:
				num7 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3FF:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_3EB
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_42C:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x0000AFB8 File Offset: 0x000091B8
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
							Dim flag2 As Boolean = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, Nothing, "Range", New Object() { Me.cmbColom.Text + num2.ToString() }, Nothing, Nothing, Nothing), Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Trim().Length < 9
							If flag2 Then
								Exit For
							End If
							num2 += 1L
						End While
						IL_243:
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
				GoTo IL_3B9
				IL_378:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_38C:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_378
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3B9:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000A9 RID: 169 RVA: 0x0000B3A4 File Offset: 0x000095A4
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

		' Token: 0x060000AA RID: 170 RVA: 0x0000B424 File Offset: 0x00009624
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
					Interaction.MsgBox("لا يوجد كروت للتنفيذ", MsgBoxStyle.Critical, Nothing)
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

		' Token: 0x060000AB RID: 171 RVA: 0x0000B530 File Offset: 0x00009730
		Private Sub cmbPaste_Click(sender As Object, e As EventArgs)
			Dim text As String = Clipboard.GetText()
			Dim flag As Boolean = text.Trim().Length = 15 Or text.Trim().Length = 16
			If flag Then
				Me.txtDail.Text = text.Trim()
				Clipboard.Clear()
			End If
		End Sub

		' Token: 0x060000AC RID: 172 RVA: 0x0000257C File Offset: 0x0000077C
		Private Sub txtDail_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000AD RID: 173 RVA: 0x0000B584 File Offset: 0x00009784
		Private Sub btnAddIQ_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.txtTemp.Text
			Dim flag4 As Boolean
			Do
				Dim flag As Boolean = text.Contains("الرقم السرى")
				If Not flag Then
					Exit Do
				End If
				Dim num As Integer = text.IndexOf("الرقم السرى")
				Dim text2 As String = text.Substring(num + 12, 22).Trim(New Char() { vbCr }).Trim().Replace("-", "")
				Dim flag2 As Boolean = text2.Length = 15 Or text2.Length = 16
				If flag2 Then
					Me.txtCardNew.Text = text2
					Me.txtCardNew.BackColor = Color.White
					Dim flag3 As Boolean = Me.chktelNumFound(Me.txtCardNew.Text.Trim())
					If flag3 Then
						Me.txtCardNew.BackColor = Color.PaleVioletRed
					Else
						Me.AddBoxToLstPre(Me.txtCardNew.Text.Trim())
					End If
					Me.txtCardNew.Text = ""
				End If
				text = text.Substring(num + 35, text.Length - (num + 35))
				flag4 = (text.Length > 10)
			Loop While flag4
		End Sub

		' Token: 0x060000AE RID: 174 RVA: 0x0000257F File Offset: 0x0000077F
		Private Sub btnPast2_Click(sender As Object, e As EventArgs)
			Me.txtTemp.Text = Clipboard.GetText()
		End Sub

		' Token: 0x060000AF RID: 175 RVA: 0x00002593 File Offset: 0x00000793
		Private Sub btnCleattemp_Click(sender As Object, e As EventArgs)
			Me.txtTemp.Text = ""
		End Sub

		' Token: 0x060000B0 RID: 176 RVA: 0x0000B6B4 File Offset: 0x000098B4
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

		' Token: 0x060000B1 RID: 177 RVA: 0x0000B818 File Offset: 0x00009A18
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

		' Token: 0x060000B2 RID: 178 RVA: 0x0000B8EC File Offset: 0x00009AEC
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
						Interaction.MsgBox("لا توجد اى كروت ", MsgBoxStyle.Critical, Nothing)
					End If
					NewLateBinding.LateCall(objectValue2, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue2))
					Me.releaseObject(RuntimeHelpers.GetObjectValue(objectValue3))
					Me.Cursor = Cursors.[Default]
					Dim flag4 As Boolean = num2 > 3.0
					If flag4 Then
						Interaction.MsgBox("تم تصدير جميع الكروت بنجاح", MsgBoxStyle.Information, Nothing)
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

		' Token: 0x060000B3 RID: 179 RVA: 0x0000BC08 File Offset: 0x00009E08
		Private Sub btnAddFF_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Conversion.Val(Me.txtEnumSH.Text) > 0.0
			If flag Then
				Me.GetAllSmsfromDBExc(Me.txtEnumSH.Text)
			End If
		End Sub

		' Token: 0x04000040 RID: 64
		Private objData As CData

		' Token: 0x04000041 RID: 65
		Private objDataTabletemp As DataTable

		' Token: 0x04000042 RID: 66
		Private AutoFlag As Boolean

		' Token: 0x04000043 RID: 67
		Private CurrIndex As Integer

		' Token: 0x04000044 RID: 68
		Private CLICODE As String

		' Token: 0x04000045 RID: 69
		Private FileNamePath As String
	End Class
End Namespace
