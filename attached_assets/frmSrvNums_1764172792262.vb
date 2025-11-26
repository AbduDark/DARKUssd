Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace MTUssd
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class frmSrvNums
		Inherits Form

		' Token: 0x0600014B RID: 331 RVA: 0x00002889 File Offset: 0x00000A89
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSrvNums_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x0600014E RID: 334 RVA: 0x000028A9 File Offset: 0x00000AA9
		' (set) Token: 0x0600014F RID: 335 RVA: 0x000028B3 File Offset: 0x00000AB3
		Friend Overridable Property ODfile As OpenFileDialog

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x06000150 RID: 336 RVA: 0x000028BC File Offset: 0x00000ABC
		' (set) Token: 0x06000151 RID: 337 RVA: 0x00012CB4 File Offset: 0x00010EB4
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

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x06000152 RID: 338 RVA: 0x000028C6 File Offset: 0x00000AC6
		' (set) Token: 0x06000153 RID: 339 RVA: 0x00012CF8 File Offset: 0x00010EF8
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x06000154 RID: 340 RVA: 0x000028D0 File Offset: 0x00000AD0
		' (set) Token: 0x06000155 RID: 341 RVA: 0x000028DA File Offset: 0x00000ADA
		Friend Overridable Property txtDail As TextBox

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x06000156 RID: 342 RVA: 0x000028E3 File Offset: 0x00000AE3
		' (set) Token: 0x06000157 RID: 343 RVA: 0x000028ED File Offset: 0x00000AED
		Friend Overridable Property SFD As SaveFileDialog

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x06000158 RID: 344 RVA: 0x000028F6 File Offset: 0x00000AF6
		' (set) Token: 0x06000159 RID: 345 RVA: 0x00002900 File Offset: 0x00000B00
		Friend Overridable Property lblTelNum As Label

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x0600015A RID: 346 RVA: 0x00002909 File Offset: 0x00000B09
		' (set) Token: 0x0600015B RID: 347 RVA: 0x00002913 File Offset: 0x00000B13
		Friend Overridable Property txtSrvName As TextBox

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x0600015C RID: 348 RVA: 0x0000291C File Offset: 0x00000B1C
		' (set) Token: 0x0600015D RID: 349 RVA: 0x00002926 File Offset: 0x00000B26
		Friend Overridable Property txtEnote As TextBox

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x0600015E RID: 350 RVA: 0x0000292F File Offset: 0x00000B2F
		' (set) Token: 0x0600015F RID: 351 RVA: 0x00002939 File Offset: 0x00000B39
		Friend Overridable Property txtMsg As TextBox

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x06000160 RID: 352 RVA: 0x00002942 File Offset: 0x00000B42
		' (set) Token: 0x06000161 RID: 353 RVA: 0x0000294C File Offset: 0x00000B4C
		Friend Overridable Property Label1 As Label

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x06000162 RID: 354 RVA: 0x00002955 File Offset: 0x00000B55
		' (set) Token: 0x06000163 RID: 355 RVA: 0x0000295F File Offset: 0x00000B5F
		Friend Overridable Property Label2 As Label

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x06000164 RID: 356 RVA: 0x00002968 File Offset: 0x00000B68
		' (set) Token: 0x06000165 RID: 357 RVA: 0x00002972 File Offset: 0x00000B72
		Friend Overridable Property Label3 As Label

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000166 RID: 358 RVA: 0x0000297B File Offset: 0x00000B7B
		' (set) Token: 0x06000167 RID: 359 RVA: 0x00002985 File Offset: 0x00000B85
		Friend Overridable Property Label5 As Label

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000168 RID: 360 RVA: 0x0000298E File Offset: 0x00000B8E
		' (set) Token: 0x06000169 RID: 361 RVA: 0x00012D3C File Offset: 0x00010F3C
		Friend Overridable Property btnAdd As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAdd_Click
				Dim btnAdd As Button = Me._btnAdd
				If btnAdd IsNot Nothing Then
					RemoveHandler btnAdd.Click, value2
				End If
				Me._btnAdd = value
				btnAdd = Me._btnAdd
				If btnAdd IsNot Nothing Then
					AddHandler btnAdd.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600016A RID: 362 RVA: 0x00012D80 File Offset: 0x00010F80
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

		' Token: 0x0600016B RID: 363 RVA: 0x00012E30 File Offset: 0x00011030
		Private Sub AddTelNum()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_02:
				ProjectData.ClearProjectError()
				num = -2
				IL_0B:
				Dim num2 As Integer = 2
				Dim text As String = "Insert Into svrnums "
				IL_13:
				num2 = 3
				text += "(mobnum,edscrp,enote,srvmsg)"
				IL_21:
				num2 = 4
				text += "Values ("
				IL_2F:
				num2 = 5
				text = text + "'" + Me.txtDail.Text + "' , "
				IL_4D:
				num2 = 6
				text = text + "'" + Me.txtSrvName.Text + "' , "
				IL_6B:
				num2 = 7
				text = text + "'" + Me.txtEnote.Text + "' , "
				IL_89:
				num2 = 8
				text = text + "'" + Me.txtMsg.Text + "') "
				IL_A7:
				num2 = 9
				Me.objData.DatabaseCommand(text)
				IL_B7:
				num2 = 10
				Me.txtDail.Text = ""
				IL_CB:
				num2 = 11
				Me.txtSrvName.Text = ""
				IL_DF:
				num2 = 12
				Me.txtEnote.Text = ""
				IL_F3:
				num2 = 13
				Me.txtMsg.Text = ""
				IL_107:
				GoTo IL_199
				IL_10C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_152:
				GoTo IL_18E
				IL_154:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_16C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_154
			End Try
			IL_18E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_199:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600016C RID: 364 RVA: 0x00012FFC File Offset: 0x000111FC
		Private Sub GetAllSmsfromDB()
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
				dataTable.Columns.Add("اسم الخدمة")
				IL_41:
				num2 = 5
				dataTable.Columns.Add("نص الرسالة")
				IL_55:
				num2 = 6
				dataTable.Columns.Add("ملاحظة")
				IL_69:
				num2 = 7
				IL_6E:
				num2 = 8
				Me.objDataTabletemp = Me.objData.QueryDatabase("SELECT * FROM svrnums  order by mobnum")
				IL_86:
				num2 = 9
				Dim flag As Boolean = Me.objDataTabletemp.Rows.Count > 0
				If Not flag Then
					GoTo IL_1A7
				End If
				IL_A5:
				num2 = 10
				Dim num3 As Integer = Me.objDataTabletemp.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_C3:
					num2 = 11
					Dim dataRow As DataRow = dataTable.NewRow()
					IL_CF:
					num2 = 12
					dataRow(0) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("mobnum"))
					IL_FB:
					num2 = 13
					dataRow(1) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("edscrp"))
					IL_127:
					num2 = 14
					dataRow(2) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("srvmsg"))
					IL_153:
					num2 = 15
					dataRow(3) = RuntimeHelpers.GetObjectValue(Me.objDataTabletemp.Rows(i)("enote"))
					IL_17F:
					num2 = 16
					dataTable.Rows.Add(dataRow)
					IL_191:
					num2 = 17
					dataRow = Nothing
					IL_197:
					num2 = 18
				Next
				IL_1A6:
				IL_1A7:
				IL_1A8:
				num2 = 20
				Me.dataViewGrid.DataSource = dataTable
				IL_1B9:
				num2 = 21
				Me.dataViewGrid.Columns(0).Width = 120
				IL_1D5:
				num2 = 22
				Me.dataViewGrid.Columns(1).Width = 200
				IL_1F4:
				num2 = 23
				Me.dataViewGrid.Columns(2).Width = 250
				IL_213:
				num2 = 24
				Me.dataViewGrid.Columns(3).Width = 250
				IL_232:
				GoTo IL_2F0
				IL_237:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_2A9:
				GoTo IL_2E5
				IL_2AB:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_2C3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2AB
			End Try
			IL_2E5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2F0:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600016D RID: 365 RVA: 0x00013320 File Offset: 0x00011520
		Private Sub frmSrvNums_Load(sender As Object, e As EventArgs)
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
				Me.GetAllSmsfromDB()
				IL_1D:
				GoTo IL_84
				IL_1F:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_3D:
				GoTo IL_79
				IL_3F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_57:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3F
			End Try
			IL_79:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_84:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600016E RID: 366 RVA: 0x000133CC File Offset: 0x000115CC
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

		' Token: 0x0600016F RID: 367 RVA: 0x0001348C File Offset: 0x0001168C
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.txtDail.Text.Trim().Length > 0
			If flag Then
				Me.AddTelNum()
				Me.GetAllSmsfromDB()
			End If
		End Sub

		' Token: 0x06000170 RID: 368 RVA: 0x000134C8 File Offset: 0x000116C8
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
				GoTo IL_9D
				IL_39:
				num2 = 5
				Me.objData.DatabaseCommand("Delete From svrnums WHERE mobnum = '" + Me.lblTelNum.Text + "'")
				IL_61:
				num2 = 6
				Interaction.MsgBox("تم حذف الرقم" + Me.lblTelNum.Text, MsgBoxStyle.Information, Nothing)
				IL_81:
				num2 = 7
				Me.GetAllSmsfromDB()
				IL_8A:
				num2 = 8
				Me.lblTelNum.Text = ""
				IL_9D:
				GoTo IL_118
				IL_9F:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_D1:
				GoTo IL_10D
				IL_D3:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num > -2), num, 1))
				IL_EB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_D3
			End Try
			IL_10D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_118:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0400008C RID: 140
		Private objData As CData

		' Token: 0x0400008D RID: 141
		Private objDataTabletemp As DataTable

		' Token: 0x0400008E RID: 142
		Private AutoFlag As Boolean

		' Token: 0x0400008F RID: 143
		Private CurrIndex As Integer

		' Token: 0x04000090 RID: 144
		Private CLICODE As String

		' Token: 0x04000091 RID: 145
		Private FileNamePath As String
	End Class
End Namespace
