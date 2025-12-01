Namespace MTUssd
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmUssd
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000172 RID: 370 RVA: 0x00013698 File Offset: 0x00011898
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

		' Token: 0x06000173 RID: 371 RVA: 0x000136E8 File Offset: 0x000118E8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle8 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle9 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.MTUssd.frmUssd))
			Me.btnRefreshMissed = New Global.System.Windows.Forms.Button()
			Me.txtUssdc3 = New Global.System.Windows.Forms.TextBox()
			Me.txtUssdc2 = New Global.System.Windows.Forms.TextBox()
			Me.txt205 = New Global.System.Windows.Forms.TextBox()
			Me.TimerSecAuto = New Global.System.Windows.Forms.Timer(Me.components)
			Me.txtUssd = New Global.System.Windows.Forms.TextBox()
			Me.lblPort6 = New Global.System.Windows.Forms.Label()
			Me.lblPort5 = New Global.System.Windows.Forms.Label()
			Me.lblPort4 = New Global.System.Windows.Forms.Label()
			Me.lblPort3 = New Global.System.Windows.Forms.Label()
			Me.lblPort2 = New Global.System.Windows.Forms.Label()
			Me.lblPort1 = New Global.System.Windows.Forms.Label()
			Me.btnResetMissed = New Global.System.Windows.Forms.Button()
			Me.btnGetSims = New Global.System.Windows.Forms.Button()
			Me.lblProgress = New Global.System.Windows.Forms.Label()
			Me.btnRefresh = New Global.System.Windows.Forms.Button()
			Me.btnRunUssd = New Global.System.Windows.Forms.Button()
			Me.txtRet01 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet02 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet03 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet06 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet05 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet04 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd2 = New Global.System.Windows.Forms.Button()
			Me.btnRunUssd3 = New Global.System.Windows.Forms.Button()
			Me.btnRunUssd4 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc4 = New Global.System.Windows.Forms.TextBox()
			Me.txtUssdc5 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd5 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc6 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd6 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc7 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd7 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc8 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd8 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc9 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd9 = New Global.System.Windows.Forms.Button()
			Me.txtUssdc10 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssd10 = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnRR = New Global.System.Windows.Forms.Button()
			Me.btnUssdReset = New Global.System.Windows.Forms.Button()
			Me.btnClearSMS = New Global.System.Windows.Forms.Button()
			Me.btnReadSms = New Global.System.Windows.Forms.Button()
			Me.lblNum6 = New Global.System.Windows.Forms.Label()
			Me.lblNum5 = New Global.System.Windows.Forms.Label()
			Me.lblNum4 = New Global.System.Windows.Forms.Label()
			Me.lblNum3 = New Global.System.Windows.Forms.Label()
			Me.lblNum2 = New Global.System.Windows.Forms.Label()
			Me.lblNum1 = New Global.System.Windows.Forms.Label()
			Me.ckBox = New Global.System.Windows.Forms.CheckBox()
			Me.btnRefreshEmpty = New Global.System.Windows.Forms.Button()
			Me.btnNumbers = New Global.System.Windows.Forms.Button()
			Me.ckME = New Global.System.Windows.Forms.CheckBox()
			Me.btnGetOut = New Global.System.Windows.Forms.Button()
			Me.btnSaveOut = New Global.System.Windows.Forms.Button()
			Me.btnNumbers2 = New Global.System.Windows.Forms.Button()
			Me.btnNumbers3 = New Global.System.Windows.Forms.Button()
			Me.txtLoopS = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopF = New Global.System.Windows.Forms.TextBox()
			Me.btnRunUssdGG = New Global.System.Windows.Forms.Button()
			Me.btnReplyBy = New Global.System.Windows.Forms.Button()
			Me.txtReplyBy = New Global.System.Windows.Forms.TextBox()
			Me.txtReplyBy2 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy2 = New Global.System.Windows.Forms.Button()
			Me.btnFawrySms = New Global.System.Windows.Forms.Button()
			Me.lblBal6 = New Global.System.Windows.Forms.Label()
			Me.lblBal5 = New Global.System.Windows.Forms.Label()
			Me.lblBal4 = New Global.System.Windows.Forms.Label()
			Me.lblBal3 = New Global.System.Windows.Forms.Label()
			Me.lblBal2 = New Global.System.Windows.Forms.Label()
			Me.lblBal1 = New Global.System.Windows.Forms.Label()
			Me.txtInfo = New Global.System.Windows.Forms.TextBox()
			Me.txtEproc = New Global.System.Windows.Forms.TextBox()
			Me.txtReplyBy3 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy3 = New Global.System.Windows.Forms.Button()
			Me.lblCard4 = New Global.System.Windows.Forms.Label()
			Me.lblCard5 = New Global.System.Windows.Forms.Label()
			Me.lblCard6 = New Global.System.Windows.Forms.Label()
			Me.lblCard3 = New Global.System.Windows.Forms.Label()
			Me.lblCard2 = New Global.System.Windows.Forms.Label()
			Me.lblCard1 = New Global.System.Windows.Forms.Label()
			Me.btnApplyCards = New Global.System.Windows.Forms.Button()
			Me.ckCards = New Global.System.Windows.Forms.CheckBox()
			Me.btnAddCards = New Global.System.Windows.Forms.Button()
			Me.lblCardsQty = New Global.System.Windows.Forms.Label()
			Me.cmbEvalue = New Global.System.Windows.Forms.ComboBox()
			Me.chkCh1 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh2 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh3 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh4 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh5 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh6 = New Global.System.Windows.Forms.CheckBox()
			Me.txtChSS = New Global.System.Windows.Forms.TextBox()
			Me.btnApplyCards2 = New Global.System.Windows.Forms.Button()
			Me.btnDeSA = New Global.System.Windows.Forms.Button()
			Me.btnSA = New Global.System.Windows.Forms.Button()
			Me.chkIgnorSms = New Global.System.Windows.Forms.CheckBox()
			Me.RBEts = New Global.System.Windows.Forms.RadioButton()
			Me.RBVoda = New Global.System.Windows.Forms.RadioButton()
			Me.chkSlowRead = New Global.System.Windows.Forms.CheckBox()
			Me.txtReplyBy4 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy4 = New Global.System.Windows.Forms.Button()
			Me.txtReplyBy5 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy5 = New Global.System.Windows.Forms.Button()
			Me.txtReplyBy0 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy0 = New Global.System.Windows.Forms.Button()
			Me.MainTC = New Global.System.Windows.Forms.TabControl()
			Me.VodaCashPAnel = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnTransToNm = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnTransFromNm = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnTransGiftAutoSpValAll0 = New Global.System.Windows.Forms.CheckBox()
			Me.btnRun02NmDwl = New Global.System.Windows.Forms.Button()
			Me.ckbtnTransGiftAuto = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnTransGiftAutoSpValAll = New Global.System.Windows.Forms.CheckBox()
			Me.btnTransFromNm = New Global.System.Windows.Forms.Button()
			Me.btnTransToNm = New Global.System.Windows.Forms.Button()
			Me.ckbtnRun02Nm = New Global.System.Windows.Forms.CheckBox()
			Me.btnTransGiftAutoSpValAll = New Global.System.Windows.Forms.Button()
			Me.chkAutoTransferCash = New Global.System.Windows.Forms.CheckBox()
			Me.lbl100 = New Global.System.Windows.Forms.Label()
			Me.lbl35 = New Global.System.Windows.Forms.Label()
			Me.lbl50 = New Global.System.Windows.Forms.Label()
			Me.chkAutoTransferNrm = New Global.System.Windows.Forms.CheckBox()
			Me.chAutoGooo2 = New Global.System.Windows.Forms.CheckBox()
			Me.lbl45 = New Global.System.Windows.Forms.Label()
			Me.lbl40 = New Global.System.Windows.Forms.Label()
			Me.chAutoGooo = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnTransGiftAutoSpVal = New Global.System.Windows.Forms.CheckBox()
			Me.btnAutoVC_SeresWtop = New Global.System.Windows.Forms.Button()
			Me.ckTransP = New Global.System.Windows.Forms.CheckBox()
			Me.txtTransP = New Global.System.Windows.Forms.TextBox()
			Me.lbl30 = New Global.System.Windows.Forms.Label()
			Me.lbl25 = New Global.System.Windows.Forms.Label()
			Me.lbl20 = New Global.System.Windows.Forms.Label()
			Me.lbl15 = New Global.System.Windows.Forms.Label()
			Me.lbl10 = New Global.System.Windows.Forms.Label()
			Me.lbl05 = New Global.System.Windows.Forms.Label()
			Me.chkTransGift = New Global.System.Windows.Forms.CheckBox()
			Me.chkGetgift = New Global.System.Windows.Forms.CheckBox()
			Me.btnExchangeNN = New Global.System.Windows.Forms.Button()
			Me.chbeep = New Global.System.Windows.Forms.CheckBox()
			Me.chkInDB = New Global.System.Windows.Forms.CheckBox()
			Me.btnAutoVC_Hez = New Global.System.Windows.Forms.Button()
			Me.chkRefref = New Global.System.Windows.Forms.CheckBox()
			Me.cknull = New Global.System.Windows.Forms.CheckBox()
			Me.btnAutoVC_Seres = New Global.System.Windows.Forms.Button()
			Me.txtVCForceMony = New Global.System.Windows.Forms.TextBox()
			Me.btnTransToNextMain = New Global.System.Windows.Forms.Button()
			Me.btnTransGiftAutoSpVal = New Global.System.Windows.Forms.Button()
			Me.Label37 = New Global.System.Windows.Forms.Label()
			Me.Label24 = New Global.System.Windows.Forms.Label()
			Me.btnAutoVCnorm = New Global.System.Windows.Forms.Button()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.txtTransNum2 = New Global.System.Windows.Forms.TextBox()
			Me.btnTransGiftAuto = New Global.System.Windows.Forms.Button()
			Me.txtCashNextMaster = New Global.System.Windows.Forms.TextBox()
			Me.btnRun02Nm = New Global.System.Windows.Forms.Button()
			Me.lblMain = New Global.System.Windows.Forms.Label()
			Me.Label21 = New Global.System.Windows.Forms.Label()
			Me.txtMonyMn = New Global.System.Windows.Forms.TextBox()
			Me.btnGetBal2 = New Global.System.Windows.Forms.Button()
			Me.btnTransAllMn = New Global.System.Windows.Forms.Button()
			Me.btnTransGiftAutoNorm = New Global.System.Windows.Forms.Button()
			Me.tabvc2 = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnCashKing = New Global.System.Windows.Forms.CheckBox()
			Me.btnCashKing = New Global.System.Windows.Forms.Button()
			Me.btn365_9093 = New Global.System.Windows.Forms.Button()
			Me.ck365_902 = New Global.System.Windows.Forms.CheckBox()
			Me.ck365_T2 = New Global.System.Windows.Forms.CheckBox()
			Me.ck365_toup = New Global.System.Windows.Forms.CheckBox()
			Me.ck365_90 = New Global.System.Windows.Forms.CheckBox()
			Me.ck365_T = New Global.System.Windows.Forms.CheckBox()
			Me.ck365_901 = New Global.System.Windows.Forms.CheckBox()
			Me.btn365_90 = New Global.System.Windows.Forms.Button()
			Me.btn365_901 = New Global.System.Windows.Forms.Button()
			Me.ckbtnVodaAuto3652 = New Global.System.Windows.Forms.CheckBox()
			Me.btnVodaAuto3652 = New Global.System.Windows.Forms.Button()
			Me.ckbtnVodaCashFreeTransfer = New Global.System.Windows.Forms.CheckBox()
			Me.btnVodaCashFreeTransfer = New Global.System.Windows.Forms.Button()
			Me.ckbtnVodaAuto365 = New Global.System.Windows.Forms.CheckBox()
			Me.btnVodaAuto365 = New Global.System.Windows.Forms.Button()
			Me.btnVCtransFrom3Up = New Global.System.Windows.Forms.Button()
			Me.btnVCtransFrom3Dn = New Global.System.Windows.Forms.Button()
			Me.ckTrans = New Global.System.Windows.Forms.CheckBox()
			Me.chkimpsms = New Global.System.Windows.Forms.CheckBox()
			Me.txtCHS = New Global.System.Windows.Forms.TextBox()
			Me.tab365_2 = New Global.System.Windows.Forms.TabPage()
			Me.btnDelTarfehy = New Global.System.Windows.Forms.Button()
			Me.chkNewWallet = New Global.System.Windows.Forms.CheckBox()
			Me.btnGetVodaBal365 = New Global.System.Windows.Forms.Button()
			Me.txtLoopSSD365_2 = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSD365_2 = New Global.System.Windows.Forms.TextBox()
			Me.chkApply365Trans = New Global.System.Windows.Forms.CheckBox()
			Me.txtTransNum2365_n = New Global.System.Windows.Forms.TextBox()
			Me.Label63 = New Global.System.Windows.Forms.Label()
			Me.btnTransGiftAutoNorm365 = New Global.System.Windows.Forms.Button()
			Me.txtVCForceMony365_n = New Global.System.Windows.Forms.TextBox()
			Me.chkTransferAllNormalVoda365 = New Global.System.Windows.Forms.CheckBox()
			Me.chkApply365Bakat = New Global.System.Windows.Forms.CheckBox()
			Me.btnApply365Bakat = New Global.System.Windows.Forms.Button()
			Me.btnChkNewSims = New Global.System.Windows.Forms.Button()
			Me.TabPage4 = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnChangePassNew = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnChangePass = New Global.System.Windows.Forms.CheckBox()
			Me.btnChangePassNew = New Global.System.Windows.Forms.Button()
			Me.BDatedel = New Global.System.Windows.Forms.DateTimePicker()
			Me.btnDlGifts = New Global.System.Windows.Forms.Button()
			Me.Label51 = New Global.System.Windows.Forms.Label()
			Me.btnChangePass = New Global.System.Windows.Forms.Button()
			Me.Label50 = New Global.System.Windows.Forms.Label()
			Me.txtOldPass = New Global.System.Windows.Forms.TextBox()
			Me.Label49 = New Global.System.Windows.Forms.Label()
			Me.txtNewPass = New Global.System.Windows.Forms.TextBox()
			Me.chkPay = New Global.System.Windows.Forms.CheckBox()
			Me.btnGetBalNM = New Global.System.Windows.Forms.Button()
			Me.btnCopyAll = New Global.System.Windows.Forms.Button()
			Me.txtSpNum6 = New Global.System.Windows.Forms.TextBox()
			Me.txtSpNum5 = New Global.System.Windows.Forms.TextBox()
			Me.txtSpNum4 = New Global.System.Windows.Forms.TextBox()
			Me.txtSpNum3 = New Global.System.Windows.Forms.TextBox()
			Me.txtSpNum2 = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtSpNum1 = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtwait = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtPass = New Global.System.Windows.Forms.TextBox()
			Me.btnAddItems = New Global.System.Windows.Forms.Button()
			Me.tabOcash = New Global.System.Windows.Forms.TabPage()
			Me.txtOCtopupDelayCash = New Global.System.Windows.Forms.TextBox()
			Me.txtOCTransferAll = New Global.System.Windows.Forms.TextBox()
			Me.txtOCchargeNumOne = New Global.System.Windows.Forms.TextBox()
			Me.ckbtnOCTopupOne = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCTopupOne = New Global.System.Windows.Forms.Button()
			Me.txtOCtopupDelay = New Global.System.Windows.Forms.TextBox()
			Me.ckOCBalWithBack = New Global.System.Windows.Forms.CheckBox()
			Me.Label105 = New Global.System.Windows.Forms.Label()
			Me.txtOCTransferSub = New Global.System.Windows.Forms.TextBox()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCTransferSame = New Global.System.Windows.Forms.Button()
			Me.txtOCValueSame = New Global.System.Windows.Forms.TextBox()
			Me.Label95 = New Global.System.Windows.Forms.Label()
			Me.lblOCvTotal = New Global.System.Windows.Forms.Label()
			Me.lblOCvsub = New Global.System.Windows.Forms.Label()
			Me.lblOCvPlus = New Global.System.Windows.Forms.Label()
			Me.lblOCv100 = New Global.System.Windows.Forms.Label()
			Me.lblOCv90 = New Global.System.Windows.Forms.Label()
			Me.lblOCv85 = New Global.System.Windows.Forms.Label()
			Me.lblOCv75 = New Global.System.Windows.Forms.Label()
			Me.lblOCv65 = New Global.System.Windows.Forms.Label()
			Me.lblOCv50 = New Global.System.Windows.Forms.Label()
			Me.lblOCv45 = New Global.System.Windows.Forms.Label()
			Me.lblOCv35 = New Global.System.Windows.Forms.Label()
			Me.lblOCv25 = New Global.System.Windows.Forms.Label()
			Me.ckbtnOCTransferAll = New Global.System.Windows.Forms.CheckBox()
			Me.txtLoopSSDOC = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSDOC = New Global.System.Windows.Forms.TextBox()
			Me.Label82 = New Global.System.Windows.Forms.Label()
			Me.lblOCv20 = New Global.System.Windows.Forms.Label()
			Me.btnOCTransferAll = New Global.System.Windows.Forms.Button()
			Me.lblOCv15 = New Global.System.Windows.Forms.Label()
			Me.lblOCv10 = New Global.System.Windows.Forms.Label()
			Me.lblOCv5 = New Global.System.Windows.Forms.Label()
			Me.ckbtnOCTopup = New Global.System.Windows.Forms.CheckBox()
			Me.txtOCchargeNum6 = New Global.System.Windows.Forms.TextBox()
			Me.txtOCchargeNum5 = New Global.System.Windows.Forms.TextBox()
			Me.txtOCchargeNum4 = New Global.System.Windows.Forms.TextBox()
			Me.txtOCchargeNum3 = New Global.System.Windows.Forms.TextBox()
			Me.txtOCchargeNum2 = New Global.System.Windows.Forms.TextBox()
			Me.txtOCTopValue = New Global.System.Windows.Forms.TextBox()
			Me.btnOCTopup = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCGetBal = New Global.System.Windows.Forms.CheckBox()
			Me.Label74 = New Global.System.Windows.Forms.Label()
			Me.txtOCchargeNum1 = New Global.System.Windows.Forms.TextBox()
			Me.btnOCGetBal = New Global.System.Windows.Forms.Button()
			Me.tabOCCon = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnOCSeriesGetBalAfter = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnOCSeriesGetBalBEfore = New Global.System.Windows.Forms.CheckBox()
			Me.lblOCMain = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopSSDOCPaySr = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSDOCPAYSr = New Global.System.Windows.Forms.TextBox()
			Me.ckbtnOCFromMasterToAll = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCFromMasterToAll = New Global.System.Windows.Forms.Button()
			Me.btnOCGetBalPAy = New Global.System.Windows.Forms.Button()
			Me.txtOCValueMT5 = New Global.System.Windows.Forms.TextBox()
			Me.Label100 = New Global.System.Windows.Forms.Label()
			Me.txtOCValueMT4 = New Global.System.Windows.Forms.TextBox()
			Me.Label99 = New Global.System.Windows.Forms.Label()
			Me.txtOCValueMT3 = New Global.System.Windows.Forms.TextBox()
			Me.Label98 = New Global.System.Windows.Forms.Label()
			Me.txtOCValueMT2 = New Global.System.Windows.Forms.TextBox()
			Me.Label97 = New Global.System.Windows.Forms.Label()
			Me.txtOCValueMT1 = New Global.System.Windows.Forms.TextBox()
			Me.Label96 = New Global.System.Windows.Forms.Label()
			Me.ckbtnOCSeriesMT = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCSeriesMT = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCSeries = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCSeries = New Global.System.Windows.Forms.Button()
			Me.txtOCValue = New Global.System.Windows.Forms.TextBox()
			Me.Label76 = New Global.System.Windows.Forms.Label()
			Me.Label94 = New Global.System.Windows.Forms.Label()
			Me.txtOCNextMain = New Global.System.Windows.Forms.TextBox()
			Me.Label73 = New Global.System.Windows.Forms.Label()
			Me.Label93 = New Global.System.Windows.Forms.Label()
			Me.Label72 = New Global.System.Windows.Forms.Label()
			Me.btnOCExchange = New Global.System.Windows.Forms.Button()
			Me.txtOCAdd = New Global.System.Windows.Forms.TextBox()
			Me.txtOCSub = New Global.System.Windows.Forms.TextBox()
			Me.ckOCSub = New Global.System.Windows.Forms.CheckBox()
			Me.ckOCSubAuto = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCfromMtoN = New Global.System.Windows.Forms.Button()
			Me.tabOCMaster = New Global.System.Windows.Forms.TabPage()
			Me.ckVerifyNumber = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnOCMAuto = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCMAuto = New Global.System.Windows.Forms.Button()
			Me.txtOCtopupDelayM2 = New Global.System.Windows.Forms.TextBox()
			Me.lblOCMMain = New Global.System.Windows.Forms.TextBox()
			Me.btnAddNumbersToOC = New Global.System.Windows.Forms.Button()
			Me.txtOCtopupDelayM = New Global.System.Windows.Forms.TextBox()
			Me.btnOCTopUpMulti = New Global.System.Windows.Forms.Button()
			Me.txtTopUpOrangeValue = New Global.System.Windows.Forms.TextBox()
			Me.txtOCInput = New Global.System.Windows.Forms.TextBox()
			Me.btnOCMSerieAcceptInput = New Global.System.Windows.Forms.Button()
			Me.btnOCMSeriesInput = New Global.System.Windows.Forms.Button()
			Me.btnTayerCharge = New Global.System.Windows.Forms.Button()
			Me.lblOCDone = New Global.System.Windows.Forms.Label()
			Me.btnClearOC = New Global.System.Windows.Forms.Button()
			Me.btnDelOnePre = New Global.System.Windows.Forms.Button()
			Me.lblCountPre = New Global.System.Windows.Forms.Label()
			Me.txtOCNumber = New Global.System.Windows.Forms.TextBox()
			Me.lstOCNumbers = New Global.System.Windows.Forms.ListBox()
			Me.ckbtnOCMSerieAccept = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCMSerieAccept = New Global.System.Windows.Forms.Button()
			Me.Label101 = New Global.System.Windows.Forms.Label()
			Me.txtOCMCount = New Global.System.Windows.Forms.TextBox()
			Me.btnOCGetBal2 = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCMSeries = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCMSeries = New Global.System.Windows.Forms.Button()
			Me.Label85 = New Global.System.Windows.Forms.Label()
			Me.Label87 = New Global.System.Windows.Forms.Label()
			Me.txtOCMValue = New Global.System.Windows.Forms.TextBox()
			Me.btnOCMGetBal = New Global.System.Windows.Forms.Button()
			Me.tabOCGifts = New Global.System.Windows.Forms.TabPage()
			Me.txtDoOfferWithdraw2 = New Global.System.Windows.Forms.TextBox()
			Me.Label108 = New Global.System.Windows.Forms.Label()
			Me.txtDoOfferWithdraw1 = New Global.System.Windows.Forms.TextBox()
			Me.Label107 = New Global.System.Windows.Forms.Label()
			Me.ckbtnDoOfferWithdraw = New Global.System.Windows.Forms.CheckBox()
			Me.btnDoOfferWithdraw = New Global.System.Windows.Forms.Button()
			Me.txtDelayToGet58 = New Global.System.Windows.Forms.TextBox()
			Me.ckbtnOCFreeTransfer = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCFreeTransfer = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCGetBalPAy2 = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnGetNormalBal = New Global.System.Windows.Forms.CheckBox()
			Me.btnGetNormalBal = New Global.System.Windows.Forms.Button()
			Me.ckbtnTranstop = New Global.System.Windows.Forms.CheckBox()
			Me.btnTranstop = New Global.System.Windows.Forms.Button()
			Me.ckbtnTrans1000 = New Global.System.Windows.Forms.CheckBox()
			Me.btnTrans1000 = New Global.System.Windows.Forms.Button()
			Me.ckbtnTrans100 = New Global.System.Windows.Forms.CheckBox()
			Me.btnTrans100 = New Global.System.Windows.Forms.Button()
			Me.btnOCGetBalPAy2 = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCApply58 = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnOCGiftsCheckConf = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCGiftsCheckConf = New Global.System.Windows.Forms.Button()
			Me.txtLoopSSOCG = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSOCG = New Global.System.Windows.Forms.TextBox()
			Me.btnOCApply58 = New Global.System.Windows.Forms.Button()
			Me.ckbtnOCGiftsCheck = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCGiftsCheck = New Global.System.Windows.Forms.Button()
			Me.tabOCSetup = New Global.System.Windows.Forms.TabPage()
			Me.Label84 = New Global.System.Windows.Forms.Label()
			Me.txtEtsCashPass = New Global.System.Windows.Forms.TextBox()
			Me.Label92 = New Global.System.Windows.Forms.Label()
			Me.txtOCOldPass = New Global.System.Windows.Forms.TextBox()
			Me.Label88 = New Global.System.Windows.Forms.Label()
			Me.txtOTyrPass = New Global.System.Windows.Forms.TextBox()
			Me.Label83 = New Global.System.Windows.Forms.Label()
			Me.txtOCPassMaster = New Global.System.Windows.Forms.TextBox()
			Me.ckOCEditPass = New Global.System.Windows.Forms.CheckBox()
			Me.btnOCEditPass = New Global.System.Windows.Forms.Button()
			Me.Label78 = New Global.System.Windows.Forms.Label()
			Me.txtOCNewPass = New Global.System.Windows.Forms.TextBox()
			Me.Label77 = New Global.System.Windows.Forms.Label()
			Me.txtOCPass = New Global.System.Windows.Forms.TextBox()
			Me.tabOrngInv = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnOtransRun = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnGetOrngBal = New Global.System.Windows.Forms.CheckBox()
			Me.dataViewGrid = New Global.System.Windows.Forms.DataGridView()
			Me.btnOrngAccQry = New Global.System.Windows.Forms.Button()
			Me.btnGetOrngBal = New Global.System.Windows.Forms.Button()
			Me.btnGetOrngBalAcc = New Global.System.Windows.Forms.Button()
			Me.btnSaveAS3 = New Global.System.Windows.Forms.Button()
			Me.btnExport3 = New Global.System.Windows.Forms.Button()
			Me.btnOtransRun = New Global.System.Windows.Forms.Button()
			Me.Label30 = New Global.System.Windows.Forms.Label()
			Me.txtOTotalTransQ = New Global.System.Windows.Forms.TextBox()
			Me.Label25 = New Global.System.Windows.Forms.Label()
			Me.txtOtotalTrans = New Global.System.Windows.Forms.TextBox()
			Me.txtOtransRem = New Global.System.Windows.Forms.TextBox()
			Me.txtOtransMP = New Global.System.Windows.Forms.TextBox()
			Me.txtOtransACC = New Global.System.Windows.Forms.TextBox()
			Me.txtOtransTN = New Global.System.Windows.Forms.TextBox()
			Me.Label29 = New Global.System.Windows.Forms.Label()
			Me.Label28 = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.Label26 = New Global.System.Windows.Forms.Label()
			Me.lblSavePath3 = New Global.System.Windows.Forms.Label()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnMacro = New Global.System.Windows.Forms.CheckBox()
			Me.btnMacro = New Global.System.Windows.Forms.Button()
			Me.txtMacro16 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro15 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro9 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro14 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro13 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro10 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro11 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro12 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro8 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro7 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro1 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro6 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro5 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro2 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro3 = New Global.System.Windows.Forms.TextBox()
			Me.txtMacro4 = New Global.System.Windows.Forms.TextBox()
			Me.txtReplyBy7 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy7 = New Global.System.Windows.Forms.Button()
			Me.txtReplyBy6 = New Global.System.Windows.Forms.TextBox()
			Me.btnReplyBy6 = New Global.System.Windows.Forms.Button()
			Me.TabPage7 = New Global.System.Windows.Forms.TabPage()
			Me.btnFromMainToAll = New Global.System.Windows.Forms.Button()
			Me.ckbtnECRun777111 = New Global.System.Windows.Forms.CheckBox()
			Me.btnECConvertTocash = New Global.System.Windows.Forms.Button()
			Me.btnECRun777111 = New Global.System.Windows.Forms.Button()
			Me.TempCheck = New Global.System.Windows.Forms.CheckBox()
			Me.ckbtnAutoES_Seres = New Global.System.Windows.Forms.CheckBox()
			Me.btnAutoES_Seres = New Global.System.Windows.Forms.Button()
			Me.Label104 = New Global.System.Windows.Forms.Label()
			Me.Label106 = New Global.System.Windows.Forms.Label()
			Me.txtESAdd = New Global.System.Windows.Forms.TextBox()
			Me.txtESSub = New Global.System.Windows.Forms.TextBox()
			Me.btnAutoVCnormECOne = New Global.System.Windows.Forms.Button()
			Me.ckbtnGetBal2EC = New Global.System.Windows.Forms.CheckBox()
			Me.lblMainEC = New Global.System.Windows.Forms.Label()
			Me.Label42 = New Global.System.Windows.Forms.Label()
			Me.Label39 = New Global.System.Windows.Forms.Label()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.btnAutoVCnormEC = New Global.System.Windows.Forms.Button()
			Me.txtCashNextMasterEC = New Global.System.Windows.Forms.TextBox()
			Me.txtMonyMnEC = New Global.System.Windows.Forms.TextBox()
			Me.btnGetBal2EC = New Global.System.Windows.Forms.Button()
			Me.Label38 = New Global.System.Windows.Forms.Label()
			Me.txtPassEC = New Global.System.Windows.Forms.TextBox()
			Me.tabPrint = New Global.System.Windows.Forms.TabPage()
			Me.txtPrintOut2 = New Global.System.Windows.Forms.TextBox()
			Me.txtPrintOut1 = New Global.System.Windows.Forms.TextBox()
			Me.btnPrintOUT = New Global.System.Windows.Forms.Button()
			Me.ck2x1 = New Global.System.Windows.Forms.CheckBox()
			Me.txtPrintStr = New Global.System.Windows.Forms.TextBox()
			Me.btnPrintstr = New Global.System.Windows.Forms.Button()
			Me.txtPrintPd = New Global.System.Windows.Forms.TextBox()
			Me.btnPrintRest = New Global.System.Windows.Forms.Button()
			Me.ckPrint = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.txtInfoT = New Global.System.Windows.Forms.TextBox()
			Me.txtInfoY = New Global.System.Windows.Forms.TextBox()
			Me.txtInfoX = New Global.System.Windows.Forms.TextBox()
			Me.Label66 = New Global.System.Windows.Forms.Label()
			Me.Label68 = New Global.System.Windows.Forms.Label()
			Me.btnPrinter = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.txtBar_tn = New Global.System.Windows.Forms.TextBox()
			Me.Label58 = New Global.System.Windows.Forms.Label()
			Me.txtBar_tk = New Global.System.Windows.Forms.TextBox()
			Me.Label59 = New Global.System.Windows.Forms.Label()
			Me.txtBar_H = New Global.System.Windows.Forms.TextBox()
			Me.txtBar_y = New Global.System.Windows.Forms.TextBox()
			Me.txtBar_x = New Global.System.Windows.Forms.TextBox()
			Me.Label60 = New Global.System.Windows.Forms.Label()
			Me.Label61 = New Global.System.Windows.Forms.Label()
			Me.Label62 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtW = New Global.System.Windows.Forms.TextBox()
			Me.txtH = New Global.System.Windows.Forms.TextBox()
			Me.txtHn = New Global.System.Windows.Forms.TextBox()
			Me.Label55 = New Global.System.Windows.Forms.Label()
			Me.Label56 = New Global.System.Windows.Forms.Label()
			Me.Label57 = New Global.System.Windows.Forms.Label()
			Me.cmbPrinter = New Global.System.Windows.Forms.TextBox()
			Me.TabPage3 = New Global.System.Windows.Forms.TabPage()
			Me.gboxSms = New Global.System.Windows.Forms.GroupBox()
			Me.txtGboxSub = New Global.System.Windows.Forms.TextBox()
			Me.btngboxSmsAdd = New Global.System.Windows.Forms.Button()
			Me.txtGboxQty = New Global.System.Windows.Forms.TextBox()
			Me.txtGboxMain = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsT_SR = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsT_MR = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsT_HR = New Global.System.Windows.Forms.TextBox()
			Me.Label109 = New Global.System.Windows.Forms.Label()
			Me.txtSmsT_S = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsT_M = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsT_H = New Global.System.Windows.Forms.TextBox()
			Me.ckbtnSendSmsToNumber = New Global.System.Windows.Forms.CheckBox()
			Me.txtSMStothisnumber = New Global.System.Windows.Forms.TextBox()
			Me.txtSmsWait = New Global.System.Windows.Forms.TextBox()
			Me.btnSendSmsToNumber = New Global.System.Windows.Forms.Button()
			Me.Label23 = New Global.System.Windows.Forms.Label()
			Me.txtLoopSsms = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFsms = New Global.System.Windows.Forms.TextBox()
			Me.btnAddNumbersToOCsms = New Global.System.Windows.Forms.Button()
			Me.lblCountPresms = New Global.System.Windows.Forms.Label()
			Me.btnClearOCsms = New Global.System.Windows.Forms.Button()
			Me.lblOCDonesms = New Global.System.Windows.Forms.Label()
			Me.txtOCNumbersms = New Global.System.Windows.Forms.TextBox()
			Me.lstOCNumberssms = New Global.System.Windows.Forms.ListBox()
			Me.TabPage5 = New Global.System.Windows.Forms.TabPage()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtGftLmt = New Global.System.Windows.Forms.TextBox()
			Me.txtTotalTransVal = New Global.System.Windows.Forms.TextBox()
			Me.btnTransAllMony = New Global.System.Windows.Forms.Button()
			Me.btnVodaTrans = New Global.System.Windows.Forms.Button()
			Me.btnRunAuto = New Global.System.Windows.Forms.Button()
			Me.txtLoopSVC = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFVC = New Global.System.Windows.Forms.TextBox()
			Me.btnExnums = New Global.System.Windows.Forms.Button()
			Me.lstNumbers = New Global.System.Windows.Forms.ListBox()
			Me.txtEnumsVC = New Global.System.Windows.Forms.TextBox()
			Me.btnTransInv = New Global.System.Windows.Forms.Button()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtTransNum = New Global.System.Windows.Forms.TextBox()
			Me.btnTransVal = New Global.System.Windows.Forms.Button()
			Me.btnRunAll = New Global.System.Windows.Forms.Button()
			Me.btnGetBal = New Global.System.Windows.Forms.Button()
			Me.btnRun02 = New Global.System.Windows.Forms.Button()
			Me.bt = New Global.System.Windows.Forms.Button()
			Me.btnNextItems = New Global.System.Windows.Forms.Button()
			Me.btnWorkID = New Global.System.Windows.Forms.Button()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtTransMoney = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtQtyDone = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtMoney = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtWorkID = New Global.System.Windows.Forms.TextBox()
			Me.TabPage14 = New Global.System.Windows.Forms.TabPage()
			Me.txtTotalTransValP = New Global.System.Windows.Forms.TextBox()
			Me.btnTransValP = New Global.System.Windows.Forms.Button()
			Me.Label48 = New Global.System.Windows.Forms.Label()
			Me.txtTransMoneyP = New Global.System.Windows.Forms.TextBox()
			Me.txtReplyPower = New Global.System.Windows.Forms.TextBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.txtUssdP2 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunPowe2 = New Global.System.Windows.Forms.Button()
			Me.txtTempxxp = New Global.System.Windows.Forms.TextBox()
			Me.Label47 = New Global.System.Windows.Forms.Label()
			Me.txtTransNumP = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopSVCP = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFVCP = New Global.System.Windows.Forms.TextBox()
			Me.Label45 = New Global.System.Windows.Forms.Label()
			Me.txtQtyDoneP = New Global.System.Windows.Forms.TextBox()
			Me.txtUssdP1 = New Global.System.Windows.Forms.TextBox()
			Me.btnRunPower = New Global.System.Windows.Forms.Button()
			Me.btnAutoSendPower = New Global.System.Windows.Forms.Button()
			Me.lstNumbersP = New Global.System.Windows.Forms.ListBox()
			Me.txtEnumsVCP = New Global.System.Windows.Forms.TextBox()
			Me.btnNextItemsP = New Global.System.Windows.Forms.Button()
			Me.TabPage12 = New Global.System.Windows.Forms.TabPage()
			Me.txtLoopSSD = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSD = New Global.System.Windows.Forms.TextBox()
			Me.btnGetVodaBal = New Global.System.Windows.Forms.Button()
			Me.btnChkOK = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmCancel = New Global.System.Windows.Forms.Button()
			Me.btnViewSa3edList = New Global.System.Windows.Forms.Button()
			Me.Label36 = New Global.System.Windows.Forms.Label()
			Me.Label35 = New Global.System.Windows.Forms.Label()
			Me.txtSa3edhmV = New Global.System.Windows.Forms.TextBox()
			Me.btnSA3edhmTrans = New Global.System.Windows.Forms.Button()
			Me.txtSA3edhmReq = New Global.System.Windows.Forms.TextBox()
			Me.btnSA3edhmR5 = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmR4 = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmR3 = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmR2 = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmR1 = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmRDell = New Global.System.Windows.Forms.Button()
			Me.btnSA3edhmRAdd = New Global.System.Windows.Forms.Button()
			Me.txtSA3edhmNum = New Global.System.Windows.Forms.TextBox()
			Me.btnSA3edhmReg = New Global.System.Windows.Forms.Button()
			Me.TabPage13 = New Global.System.Windows.Forms.TabPage()
			Me.txtArrayOut = New Global.System.Windows.Forms.TextBox()
			Me.lblCorrectNumber = New Global.System.Windows.Forms.Label()
			Me.Label41 = New Global.System.Windows.Forms.Label()
			Me.Label43 = New Global.System.Windows.Forms.Label()
			Me.btnAutoVCnormCon = New Global.System.Windows.Forms.Button()
			Me.Label44 = New Global.System.Windows.Forms.Label()
			Me.txtTransNum2Con = New Global.System.Windows.Forms.TextBox()
			Me.txtCashNextMasterCon = New Global.System.Windows.Forms.TextBox()
			Me.lblMainCon = New Global.System.Windows.Forms.Label()
			Me.Label46 = New Global.System.Windows.Forms.Label()
			Me.txtMonyMnCon = New Global.System.Windows.Forms.TextBox()
			Me.btnGetBal2Con = New Global.System.Windows.Forms.Button()
			Me.TabPage6 = New Global.System.Windows.Forms.TabPage()
			Me.txtNextPortNum = New Global.System.Windows.Forms.TextBox()
			Me.txtRemTimeVC = New Global.System.Windows.Forms.TextBox()
			Me.btnVCChargeToSelf = New Global.System.Windows.Forms.Button()
			Me.txtLoopSvc2 = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFvc2 = New Global.System.Windows.Forms.TextBox()
			Me.btnVC6 = New Global.System.Windows.Forms.Button()
			Me.txtMoneyMS6Dly = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS5Dly = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS4Dly = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS3Dly = New Global.System.Windows.Forms.TextBox()
			Me.Label31 = New Global.System.Windows.Forms.Label()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtMoneyMS6 = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS5 = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS4 = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS3 = New Global.System.Windows.Forms.TextBox()
			Me.txtMoneyMS2 = New Global.System.Windows.Forms.TextBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.txtMS02 = New Global.System.Windows.Forms.TextBox()
			Me.btnTransToA = New Global.System.Windows.Forms.Button()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.btnArrangIT = New Global.System.Windows.Forms.Button()
			Me.txtPassMs = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtMS01 = New Global.System.Windows.Forms.TextBox()
			Me.btnGetBalMS = New Global.System.Windows.Forms.Button()
			Me.btnTransTo = New Global.System.Windows.Forms.Button()
			Me.btnTransFromMS = New Global.System.Windows.Forms.Button()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.tabTayer = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnTayerPullAllBalsMony = New Global.System.Windows.Forms.CheckBox()
			Me.btnTayerPullAllBalsMony = New Global.System.Windows.Forms.Button()
			Me.btnTayerKikOut = New Global.System.Windows.Forms.Button()
			Me.Label90 = New Global.System.Windows.Forms.Label()
			Me.btnAddCodeToTayer = New Global.System.Windows.Forms.Button()
			Me.txtCodeTayer = New Global.System.Windows.Forms.TextBox()
			Me.ckbtnTayerPullAllBals = New Global.System.Windows.Forms.CheckBox()
			Me.btnTayerPullAllBals = New Global.System.Windows.Forms.Button()
			Me.ckbtnTayerSeries = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.txtTayerF = New Global.System.Windows.Forms.TextBox()
			Me.txtTayerS = New Global.System.Windows.Forms.TextBox()
			Me.ckTayerGetBal = New Global.System.Windows.Forms.CheckBox()
			Me.btnTayerfromMtoN = New Global.System.Windows.Forms.Button()
			Me.Label80 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.btnAutoVC_ChargeTayer = New Global.System.Windows.Forms.Button()
			Me.Label70 = New Global.System.Windows.Forms.Label()
			Me.txtTayerPass = New Global.System.Windows.Forms.TextBox()
			Me.ckTayerSub = New Global.System.Windows.Forms.CheckBox()
			Me.txtTayerSub = New Global.System.Windows.Forms.TextBox()
			Me.btnTayerEX = New Global.System.Windows.Forms.Button()
			Me.btnTayerSeries = New Global.System.Windows.Forms.Button()
			Me.Label75 = New Global.System.Windows.Forms.Label()
			Me.Label79 = New Global.System.Windows.Forms.Label()
			Me.txtTayerNextMain = New Global.System.Windows.Forms.TextBox()
			Me.lblTayerMain = New Global.System.Windows.Forms.Label()
			Me.Label81 = New Global.System.Windows.Forms.Label()
			Me.txtTayerValue = New Global.System.Windows.Forms.TextBox()
			Me.btnTayerGetBal = New Global.System.Windows.Forms.Button()
			Me.tabEzoo = New Global.System.Windows.Forms.TabPage()
			Me.ckbtnTal2aGetBal = New Global.System.Windows.Forms.CheckBox()
			Me.ckTal2a = New Global.System.Windows.Forms.CheckBox()
			Me.btnTal2aTransferFromOrange = New Global.System.Windows.Forms.Button()
			Me.Label102 = New Global.System.Windows.Forms.Label()
			Me.txtTl2aOrangeValue = New Global.System.Windows.Forms.TextBox()
			Me.btnTal2aTransferVoda = New Global.System.Windows.Forms.Button()
			Me.btnTal2aGetBal = New Global.System.Windows.Forms.Button()
			Me.Label86 = New Global.System.Windows.Forms.Label()
			Me.txtTl2aToVodaNumber = New Global.System.Windows.Forms.TextBox()
			Me.txtTl2aVodaValue = New Global.System.Windows.Forms.TextBox()
			Me.tab365 = New Global.System.Windows.Forms.TabPage()
			Me.chkTransGiftAutoSpVal365 = New Global.System.Windows.Forms.CheckBox()
			Me.txtLoopSSD365_f = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSD365_f = New Global.System.Windows.Forms.TextBox()
			Me.txtGetgft365_2 = New Global.System.Windows.Forms.TextBox()
			Me.chkAuto365EXE_f = New Global.System.Windows.Forms.CheckBox()
			Me.txtGetgft365_f = New Global.System.Windows.Forms.TextBox()
			Me.btnApply36590_f = New Global.System.Windows.Forms.Button()
			Me.txtLoopSSD365Gft = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSD365Gft = New Global.System.Windows.Forms.TextBox()
			Me.chkNoCharge50 = New Global.System.Windows.Forms.CheckBox()
			Me.chkAuto365Trans = New Global.System.Windows.Forms.CheckBox()
			Me.chk250int = New Global.System.Windows.Forms.CheckBox()
			Me.chkApply365 = New Global.System.Windows.Forms.CheckBox()
			Me.chkAuto365EXE = New Global.System.Windows.Forms.CheckBox()
			Me.chkFast365 = New Global.System.Windows.Forms.CheckBox()
			Me.btnAuto365 = New Global.System.Windows.Forms.Button()
			Me.txtGetgft365 = New Global.System.Windows.Forms.TextBox()
			Me.txtVCForceMony365 = New Global.System.Windows.Forms.TextBox()
			Me.btnTransGiftAutoSpVal365 = New Global.System.Windows.Forms.Button()
			Me.Label54 = New Global.System.Windows.Forms.Label()
			Me.txtTransNum2365Gft = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopSSD365 = New Global.System.Windows.Forms.TextBox()
			Me.txtLoopFSD365 = New Global.System.Windows.Forms.TextBox()
			Me.btnApply36590 = New Global.System.Windows.Forms.Button()
			Me.chkChargeOnSame365 = New Global.System.Windows.Forms.CheckBox()
			Me.Label52 = New Global.System.Windows.Forms.Label()
			Me.Label53 = New Global.System.Windows.Forms.Label()
			Me.txtTransNum2365 = New Global.System.Windows.Forms.TextBox()
			Me.txtMonyMn365 = New Global.System.Windows.Forms.TextBox()
			Me.btnApply365 = New Global.System.Windows.Forms.Button()
			Me.tabpoints = New Global.System.Windows.Forms.TabPage()
			Me.txtRet07 = New Global.System.Windows.Forms.TextBox()
			Me.txtRet08 = New Global.System.Windows.Forms.TextBox()
			Me.chkCh8 = New Global.System.Windows.Forms.CheckBox()
			Me.chkCh7 = New Global.System.Windows.Forms.CheckBox()
			Me.txtPointsF = New Global.System.Windows.Forms.TextBox()
			Me.txtPointsS = New Global.System.Windows.Forms.TextBox()
			Me.btnAutoVC_ChargePoints = New Global.System.Windows.Forms.Button()
			Me.Label69 = New Global.System.Windows.Forms.Label()
			Me.lblMainPoints = New Global.System.Windows.Forms.Label()
			Me.Label71 = New Global.System.Windows.Forms.Label()
			Me.txtPointsValue = New Global.System.Windows.Forms.TextBox()
			Me.lblNum8 = New Global.System.Windows.Forms.TextBox()
			Me.lblNum7 = New Global.System.Windows.Forms.TextBox()
			Me.tabON = New Global.System.Windows.Forms.TabPage()
			Me.btnONtopup = New Global.System.Windows.Forms.Button()
			Me.btnONGift = New Global.System.Windows.Forms.Button()
			Me.btnGetBal2ON = New Global.System.Windows.Forms.Button()
			Me.btnAutoGet = New Global.System.Windows.Forms.Button()
			Me.btnPic = New Global.System.Windows.Forms.Button()
			Me.lblONnumQ = New Global.System.Windows.Forms.Label()
			Me.lblONvQ = New Global.System.Windows.Forms.Label()
			Me.lblONmcQ = New Global.System.Windows.Forms.Label()
			Me.txtQryOrder = New Global.System.Windows.Forms.TextBox()
			Me.lblONnum6 = New Global.System.Windows.Forms.Label()
			Me.txtONorder6 = New Global.System.Windows.Forms.TextBox()
			Me.lblONv6 = New Global.System.Windows.Forms.Label()
			Me.lblONmc6 = New Global.System.Windows.Forms.Label()
			Me.lblONnum5 = New Global.System.Windows.Forms.Label()
			Me.txtONorder5 = New Global.System.Windows.Forms.TextBox()
			Me.lblONv5 = New Global.System.Windows.Forms.Label()
			Me.lblONmc5 = New Global.System.Windows.Forms.Label()
			Me.lblONnum4 = New Global.System.Windows.Forms.Label()
			Me.txtONorder4 = New Global.System.Windows.Forms.TextBox()
			Me.lblONv4 = New Global.System.Windows.Forms.Label()
			Me.lblONmc4 = New Global.System.Windows.Forms.Label()
			Me.lblONnum3 = New Global.System.Windows.Forms.Label()
			Me.txtONorder3 = New Global.System.Windows.Forms.TextBox()
			Me.lblONv3 = New Global.System.Windows.Forms.Label()
			Me.lblONmc3 = New Global.System.Windows.Forms.Label()
			Me.lblONnum2 = New Global.System.Windows.Forms.Label()
			Me.txtONorder2 = New Global.System.Windows.Forms.TextBox()
			Me.lblONv2 = New Global.System.Windows.Forms.Label()
			Me.lblONmc2 = New Global.System.Windows.Forms.Label()
			Me.lblONnum1 = New Global.System.Windows.Forms.Label()
			Me.txtONorder1 = New Global.System.Windows.Forms.TextBox()
			Me.lblONed = New Global.System.Windows.Forms.Label()
			Me.lblONv1 = New Global.System.Windows.Forms.Label()
			Me.lblONmc1 = New Global.System.Windows.Forms.Label()
			Me.ckOnOut = New Global.System.Windows.Forms.CheckBox()
			Me.btnOnOut = New Global.System.Windows.Forms.Button()
			Me.Label64 = New Global.System.Windows.Forms.Label()
			Me.txtOnValue = New Global.System.Windows.Forms.TextBox()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.TabPage8 = New Global.System.Windows.Forms.TabPage()
			Me.lstNames = New Global.System.Windows.Forms.ListBox()
			Me.lstNum = New Global.System.Windows.Forms.ListBox()
			Me.btnRefreshMsg = New Global.System.Windows.Forms.Button()
			Me.txtEnote = New Global.System.Windows.Forms.TextBox()
			Me.txtSvrName = New Global.System.Windows.Forms.TextBox()
			Me.txtSrvMsg = New Global.System.Windows.Forms.TextBox()
			Me.txtMobnum = New Global.System.Windows.Forms.TextBox()
			Me.btnSendSms = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TabPage9 = New Global.System.Windows.Forms.TabPage()
			Me.btnPast = New Global.System.Windows.Forms.Button()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.dataViewGridQryChrg = New Global.System.Windows.Forms.DataGridView()
			Me.dataViewGridQryBal = New Global.System.Windows.Forms.DataGridView()
			Me.txtNumQry = New Global.System.Windows.Forms.TextBox()
			Me.TabPage10 = New Global.System.Windows.Forms.TabPage()
			Me.lblSavePath = New Global.System.Windows.Forms.Label()
			Me.btnSaveAS = New Global.System.Windows.Forms.Button()
			Me.btnExport2 = New Global.System.Windows.Forms.Button()
			Me.btnQryQry = New Global.System.Windows.Forms.Button()
			Me.lblQryTotal = New Global.System.Windows.Forms.Label()
			Me.lstQryBal = New Global.System.Windows.Forms.ListBox()
			Me.lstQryNumbers = New Global.System.Windows.Forms.ListBox()
			Me.txtEnumsVCQry = New Global.System.Windows.Forms.TextBox()
			Me.btnGetQry = New Global.System.Windows.Forms.Button()
			Me.chkAutoMain = New Global.System.Windows.Forms.CheckBox()
			Me.ckUseNextMain = New Global.System.Windows.Forms.CheckBox()
			Me.chkUse365inprcss = New Global.System.Windows.Forms.CheckBox()
			Me.chkUse365inprcss10 = New Global.System.Windows.Forms.CheckBox()
			Me.chkSqn = New Global.System.Windows.Forms.CheckBox()
			Me.chkTransferAllNormalVoda = New Global.System.Windows.Forms.CheckBox()
			Me.ckUse910 = New Global.System.Windows.Forms.CheckBox()
			Me.chkChargeOnSame = New Global.System.Windows.Forms.CheckBox()
			Me.btnCancelTrans = New Global.System.Windows.Forms.Button()
			Me.btn3G = New Global.System.Windows.Forms.Button()
			Me.chkStop = New Global.System.Windows.Forms.CheckBox()
			Me.lblGifts01 = New Global.System.Windows.Forms.Label()
			Me.lblGifts02 = New Global.System.Windows.Forms.Label()
			Me.lblGifts03 = New Global.System.Windows.Forms.Label()
			Me.lblGifts04 = New Global.System.Windows.Forms.Label()
			Me.lblGifts05 = New Global.System.Windows.Forms.Label()
			Me.lblGifts06 = New Global.System.Windows.Forms.Label()
			Me.SFD = New Global.System.Windows.Forms.SaveFileDialog()
			Me.chkAutoDell = New Global.System.Windows.Forms.CheckBox()
			Me.ODfile = New Global.System.Windows.Forms.OpenFileDialog()
			Me.lblGiftV1 = New Global.System.Windows.Forms.Label()
			Me.lblGiftV2 = New Global.System.Windows.Forms.Label()
			Me.lblGiftV3 = New Global.System.Windows.Forms.Label()
			Me.lblGiftV4 = New Global.System.Windows.Forms.Label()
			Me.lblGiftV5 = New Global.System.Windows.Forms.Label()
			Me.lblGiftV6 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal6 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal5 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal4 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal3 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal2 = New Global.System.Windows.Forms.Label()
			Me.lblGifttotal1 = New Global.System.Windows.Forms.Label()
			Me.btnRefreshComs = New Global.System.Windows.Forms.Button()
			Me.btnGetSimsGifts = New Global.System.Windows.Forms.Button()
			Me.btnGetInfo = New Global.System.Windows.Forms.Button()
			Me.chkAutoRes = New Global.System.Windows.Forms.CheckBox()
			Me.chkDelSms = New Global.System.Windows.Forms.CheckBox()
			Me.chkReadsms = New Global.System.Windows.Forms.CheckBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage11 = New Global.System.Windows.Forms.TabPage()
			Me.btnInvertSelection = New Global.System.Windows.Forms.Button()
			Me.btnSADwn = New Global.System.Windows.Forms.Button()
			Me.btnUp = New Global.System.Windows.Forms.Button()
			Me.BtnOO = New Global.System.Windows.Forms.Button()
			Me.btnVV = New Global.System.Windows.Forms.Button()
			Me.TabPage15 = New Global.System.Windows.Forms.TabPage()
			Me.txtWebSign = New Global.System.Windows.Forms.TextBox()
			Me.btnCC = New Global.System.Windows.Forms.Button()
			Me.TabPage16 = New Global.System.Windows.Forms.TabPage()
			Me.btn2G = New Global.System.Windows.Forms.Button()
			Me.TabPage17 = New Global.System.Windows.Forms.TabPage()
			Me.ckSetThisNumberToValedPeriod = New Global.System.Windows.Forms.CheckBox()
			Me.chkSafeMode = New Global.System.Windows.Forms.CheckBox()
			Me.tabServer = New Global.System.Windows.Forms.TabPage()
			Me.Label103 = New Global.System.Windows.Forms.Label()
			Me.txtNumberToAddinRobot = New Global.System.Windows.Forms.TextBox()
			Me.lbladdedtoQry = New Global.System.Windows.Forms.Label()
			Me.btnSaveASqry = New Global.System.Windows.Forms.Button()
			Me.btnExport2qry = New Global.System.Windows.Forms.Button()
			Me.btnwebQry = New Global.System.Windows.Forms.Button()
			Me.lblQryCount = New Global.System.Windows.Forms.Label()
			Me.Label91 = New Global.System.Windows.Forms.Label()
			Me.txtWebQryMonth = New Global.System.Windows.Forms.TextBox()
			Me.Label34 = New Global.System.Windows.Forms.Label()
			Me.txtWebQryDay = New Global.System.Windows.Forms.TextBox()
			Me.lstWebQry = New Global.System.Windows.Forms.ListBox()
			Me.Label33 = New Global.System.Windows.Forms.Label()
			Me.Label32 = New Global.System.Windows.Forms.Label()
			Me.txtWebQryOperator = New Global.System.Windows.Forms.TextBox()
			Me.txtWebQrySign = New Global.System.Windows.Forms.TextBox()
			Me.txtDelayInSC = New Global.System.Windows.Forms.TextBox()
			Me.cktxtDelayInSC = New Global.System.Windows.Forms.CheckBox()
			Me.lblChargeDone1 = New Global.System.Windows.Forms.Label()
			Me.lblChargeDone2 = New Global.System.Windows.Forms.Label()
			Me.lblChargeDone3 = New Global.System.Windows.Forms.Label()
			Me.lblChargeDone4 = New Global.System.Windows.Forms.Label()
			Me.lblChargeDone5 = New Global.System.Windows.Forms.Label()
			Me.lblChargeDone6 = New Global.System.Windows.Forms.Label()
			Me.gboxLock = New Global.System.Windows.Forms.GroupBox()
			Me.btnLockNo = New Global.System.Windows.Forms.Button()
			Me.btnLockOK = New Global.System.Windows.Forms.Button()
			Me.Label67 = New Global.System.Windows.Forms.Label()
			Me.Label65 = New Global.System.Windows.Forms.Label()
			Me.lblLastCheck = New Global.System.Windows.Forms.Label()
			Me.txtInfoSize = New Global.System.Windows.Forms.TextBox()
			Me.Label89 = New Global.System.Windows.Forms.Label()
			Me.txtInfoSizeH = New Global.System.Windows.Forms.TextBox()
			Me.Label110 = New Global.System.Windows.Forms.Label()
			Me.MainTC.SuspendLayout()
			Me.VodaCashPAnel.SuspendLayout()
			Me.tabvc2.SuspendLayout()
			Me.tab365_2.SuspendLayout()
			Me.TabPage4.SuspendLayout()
			Me.tabOcash.SuspendLayout()
			Me.tabOCCon.SuspendLayout()
			Me.tabOCMaster.SuspendLayout()
			Me.tabOCGifts.SuspendLayout()
			Me.tabOCSetup.SuspendLayout()
			Me.tabOrngInv.SuspendLayout()
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabPage1.SuspendLayout()
			Me.TabPage7.SuspendLayout()
			Me.tabPrint.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.TabPage3.SuspendLayout()
			Me.gboxSms.SuspendLayout()
			Me.TabPage5.SuspendLayout()
			Me.TabPage14.SuspendLayout()
			Me.TabPage12.SuspendLayout()
			Me.TabPage13.SuspendLayout()
			Me.TabPage6.SuspendLayout()
			Me.tabTayer.SuspendLayout()
			Me.tabEzoo.SuspendLayout()
			Me.tab365.SuspendLayout()
			Me.tabpoints.SuspendLayout()
			Me.tabON.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.TabPage8.SuspendLayout()
			Me.TabPage9.SuspendLayout()
			CType(Me.dataViewGridQryChrg, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataViewGridQryBal, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabPage10.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.TabPage11.SuspendLayout()
			Me.TabPage15.SuspendLayout()
			Me.TabPage16.SuspendLayout()
			Me.TabPage17.SuspendLayout()
			Me.tabServer.SuspendLayout()
			Me.gboxLock.SuspendLayout()
			MyBase.SuspendLayout()
			Me.btnRefreshMissed.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.btnRefreshMissed.Font = New Global.System.Drawing.Font("Tahoma", 7.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRefreshMissed.Location = New Global.System.Drawing.Point(82, 5)
			Me.btnRefreshMissed.Name = "btnRefreshMissed"
			Me.btnRefreshMissed.Size = New Global.System.Drawing.Size(87, 42)
			Me.btnRefreshMissed.TabIndex = 765
			Me.btnRefreshMissed.Text = "Get Missed"
			Me.btnRefreshMissed.UseVisualStyleBackColor = False
			Me.txtUssdc3.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc3.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc3.Location = New Global.System.Drawing.Point(6, 38)
			Me.txtUssdc3.Name = "txtUssdc3"
			Me.txtUssdc3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc3.Size = New Global.System.Drawing.Size(135, 27)
			Me.txtUssdc3.TabIndex = 736
			Me.txtUssdc2.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc2.Location = New Global.System.Drawing.Point(214, 38)
			Me.txtUssdc2.Name = "txtUssdc2"
			Me.txtUssdc2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc2.Size = New Global.System.Drawing.Size(108, 27)
			Me.txtUssdc2.TabIndex = 734
			Me.txt205.BackColor = Global.System.Drawing.Color.FromArgb(64, 64, 64)
			Me.txt205.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txt205.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txt205.ForeColor = Global.System.Drawing.Color.White
			Me.txt205.Location = New Global.System.Drawing.Point(163, 265)
			Me.txt205.Name = "txt205"
			Me.txt205.PasswordChar = "*"c
			Me.txt205.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txt205.Size = New Global.System.Drawing.Size(37, 17)
			Me.txt205.TabIndex = 726
			Me.txt205.TabStop = False
			Me.txt205.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.TimerSecAuto.Interval = 3000
			Me.txtUssd.BackColor = Global.System.Drawing.Color.White
			Me.txtUssd.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssd.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssd.Location = New Global.System.Drawing.Point(6, 9)
			Me.txtUssd.Name = "txtUssd"
			Me.txtUssd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssd.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssd.TabIndex = 598
			Me.lblPort6.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort6.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort6.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort6.Location = New Global.System.Drawing.Point(221, 350)
			Me.lblPort6.Name = "lblPort6"
			Me.lblPort6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort6.Size = New Global.System.Drawing.Size(66, 27)
			Me.lblPort6.TabIndex = 624
			Me.lblPort6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblPort5.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort5.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort5.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort5.Location = New Global.System.Drawing.Point(691, 350)
			Me.lblPort5.Name = "lblPort5"
			Me.lblPort5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort5.Size = New Global.System.Drawing.Size(66, 27)
			Me.lblPort5.TabIndex = 622
			Me.lblPort5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblPort4.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort4.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort4.Location = New Global.System.Drawing.Point(1229, 351)
			Me.lblPort4.Name = "lblPort4"
			Me.lblPort4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort4.Size = New Global.System.Drawing.Size(65, 27)
			Me.lblPort4.TabIndex = 615
			Me.lblPort4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblPort3.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort3.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort3.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort3.Location = New Global.System.Drawing.Point(80, 135)
			Me.lblPort3.Name = "lblPort3"
			Me.lblPort3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort3.Size = New Global.System.Drawing.Size(66, 27)
			Me.lblPort3.TabIndex = 613
			Me.lblPort3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblPort2.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort2.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort2.Location = New Global.System.Drawing.Point(630, 135)
			Me.lblPort2.Name = "lblPort2"
			Me.lblPort2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort2.Size = New Global.System.Drawing.Size(59, 27)
			Me.lblPort2.TabIndex = 611
			Me.lblPort2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblPort1.BackColor = Global.System.Drawing.Color.Black
			Me.lblPort1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblPort1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblPort1.ForeColor = Global.System.Drawing.Color.White
			Me.lblPort1.Location = New Global.System.Drawing.Point(974, 138)
			Me.lblPort1.Name = "lblPort1"
			Me.lblPort1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblPort1.Size = New Global.System.Drawing.Size(58, 27)
			Me.lblPort1.TabIndex = 608
			Me.lblPort1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnResetMissed.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.btnResetMissed.Font = New Global.System.Drawing.Font("Tahoma", 7.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnResetMissed.ForeColor = Global.System.Drawing.Color.Red
			Me.btnResetMissed.Location = New Global.System.Drawing.Point(6, 5)
			Me.btnResetMissed.Name = "btnResetMissed"
			Me.btnResetMissed.Size = New Global.System.Drawing.Size(75, 42)
			Me.btnResetMissed.TabIndex = 593
			Me.btnResetMissed.Text = "RST Missed"
			Me.btnResetMissed.UseVisualStyleBackColor = False
			Me.btnGetSims.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.btnGetSims.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnGetSims.ForeColor = Global.System.Drawing.Color.Red
			Me.btnGetSims.Location = New Global.System.Drawing.Point(82, 47)
			Me.btnGetSims.Name = "btnGetSims"
			Me.btnGetSims.Size = New Global.System.Drawing.Size(87, 42)
			Me.btnGetSims.TabIndex = 591
			Me.btnGetSims.Text = "RST All"
			Me.btnGetSims.UseVisualStyleBackColor = False
			Me.lblProgress.BackColor = Global.System.Drawing.Color.White
			Me.lblProgress.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblProgress.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblProgress.ForeColor = Global.System.Drawing.Color.Black
			Me.lblProgress.Location = New Global.System.Drawing.Point(152, 4)
			Me.lblProgress.Name = "lblProgress"
			Me.lblProgress.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblProgress.Size = New Global.System.Drawing.Size(824, 35)
			Me.lblProgress.TabIndex = 616
			Me.lblProgress.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnRefresh.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.btnRefresh.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRefresh.ForeColor = Global.System.Drawing.Color.Green
			Me.btnRefresh.Location = New Global.System.Drawing.Point(951, 396)
			Me.btnRefresh.Name = "btnRefresh"
			Me.btnRefresh.Size = New Global.System.Drawing.Size(138, 117)
			Me.btnRefresh.TabIndex = 590
			Me.btnRefresh.Text = "Run"
			Me.btnRefresh.UseVisualStyleBackColor = False
			Me.btnRunUssd.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd.Location = New Global.System.Drawing.Point(328, 8)
			Me.btnRunUssd.Name = "btnRunUssd"
			Me.btnRunUssd.Size = New Global.System.Drawing.Size(62, 27)
			Me.btnRunUssd.TabIndex = 596
			Me.btnRunUssd.Text = "تنفيذ"
			Me.btnRunUssd.UseVisualStyleBackColor = False
			Me.txtRet01.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet01.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet01.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet01.Location = New Global.System.Drawing.Point(895, 101)
			Me.txtRet01.Multiline = True
			Me.txtRet01.Name = "txtRet01"
			Me.txtRet01.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet01.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet01.Size = New Global.System.Drawing.Size(445, 113)
			Me.txtRet01.TabIndex = 769
			Me.txtRet02.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet02.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet02.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet02.Location = New Global.System.Drawing.Point(450, 101)
			Me.txtRet02.Multiline = True
			Me.txtRet02.Name = "txtRet02"
			Me.txtRet02.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet02.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet02.Size = New Global.System.Drawing.Size(443, 113)
			Me.txtRet02.TabIndex = 770
			Me.txtRet03.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet03.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet03.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet03.Location = New Global.System.Drawing.Point(3, 101)
			Me.txtRet03.Multiline = True
			Me.txtRet03.Name = "txtRet03"
			Me.txtRet03.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet03.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet03.Size = New Global.System.Drawing.Size(446, 113)
			Me.txtRet03.TabIndex = 771
			Me.txtRet06.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet06.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet06.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet06.Location = New Global.System.Drawing.Point(3, 277)
			Me.txtRet06.Multiline = True
			Me.txtRet06.Name = "txtRet06"
			Me.txtRet06.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet06.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet06.Size = New Global.System.Drawing.Size(446, 113)
			Me.txtRet06.TabIndex = 774
			Me.txtRet05.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet05.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet05.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet05.Location = New Global.System.Drawing.Point(450, 277)
			Me.txtRet05.Multiline = True
			Me.txtRet05.Name = "txtRet05"
			Me.txtRet05.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet05.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet05.Size = New Global.System.Drawing.Size(443, 113)
			Me.txtRet05.TabIndex = 773
			Me.txtRet04.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet04.Font = New Global.System.Drawing.Font("Arial", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet04.ForeColor = Global.System.Drawing.Color.White
			Me.txtRet04.Location = New Global.System.Drawing.Point(895, 277)
			Me.txtRet04.Multiline = True
			Me.txtRet04.Name = "txtRet04"
			Me.txtRet04.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet04.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet04.Size = New Global.System.Drawing.Size(445, 113)
			Me.txtRet04.TabIndex = 772
			Me.btnRunUssd2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd2.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd2.Location = New Global.System.Drawing.Point(328, 39)
			Me.btnRunUssd2.Name = "btnRunUssd2"
			Me.btnRunUssd2.Size = New Global.System.Drawing.Size(62, 27)
			Me.btnRunUssd2.TabIndex = 775
			Me.btnRunUssd2.Text = "تنفيذ"
			Me.btnRunUssd2.UseVisualStyleBackColor = False
			Me.btnRunUssd3.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd3.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd3.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd3.Location = New Global.System.Drawing.Point(147, 38)
			Me.btnRunUssd3.Name = "btnRunUssd3"
			Me.btnRunUssd3.Size = New Global.System.Drawing.Size(62, 27)
			Me.btnRunUssd3.TabIndex = 776
			Me.btnRunUssd3.Text = "تنفيذ"
			Me.btnRunUssd3.UseVisualStyleBackColor = False
			Me.btnRunUssd4.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd4.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd4.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd4.Location = New Global.System.Drawing.Point(328, 77)
			Me.btnRunUssd4.Name = "btnRunUssd4"
			Me.btnRunUssd4.Size = New Global.System.Drawing.Size(62, 27)
			Me.btnRunUssd4.TabIndex = 777
			Me.btnRunUssd4.Text = "تنفيذ"
			Me.btnRunUssd4.UseVisualStyleBackColor = False
			Me.txtUssdc4.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc4.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc4.Location = New Global.System.Drawing.Point(6, 77)
			Me.txtUssdc4.Name = "txtUssdc4"
			Me.txtUssdc4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc4.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc4.TabIndex = 778
			Me.txtUssdc5.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc5.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc5.Location = New Global.System.Drawing.Point(6, 157)
			Me.txtUssdc5.Name = "txtUssdc5"
			Me.txtUssdc5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc5.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc5.TabIndex = 780
			Me.btnRunUssd5.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd5.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd5.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd5.Location = New Global.System.Drawing.Point(328, 159)
			Me.btnRunUssd5.Name = "btnRunUssd5"
			Me.btnRunUssd5.Size = New Global.System.Drawing.Size(63, 27)
			Me.btnRunUssd5.TabIndex = 779
			Me.btnRunUssd5.Text = "تنفيذ"
			Me.btnRunUssd5.UseVisualStyleBackColor = False
			Me.txtUssdc6.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc6.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc6.Location = New Global.System.Drawing.Point(6, 185)
			Me.txtUssdc6.Name = "txtUssdc6"
			Me.txtUssdc6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc6.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc6.TabIndex = 782
			Me.btnRunUssd6.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd6.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd6.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd6.Location = New Global.System.Drawing.Point(328, 186)
			Me.btnRunUssd6.Name = "btnRunUssd6"
			Me.btnRunUssd6.Size = New Global.System.Drawing.Size(63, 27)
			Me.btnRunUssd6.TabIndex = 781
			Me.btnRunUssd6.Text = "تنفيذ"
			Me.btnRunUssd6.UseVisualStyleBackColor = False
			Me.txtUssdc7.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc7.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc7.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc7.Location = New Global.System.Drawing.Point(6, 212)
			Me.txtUssdc7.Name = "txtUssdc7"
			Me.txtUssdc7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc7.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc7.TabIndex = 784
			Me.btnRunUssd7.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd7.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd7.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd7.Location = New Global.System.Drawing.Point(328, 213)
			Me.btnRunUssd7.Name = "btnRunUssd7"
			Me.btnRunUssd7.Size = New Global.System.Drawing.Size(63, 27)
			Me.btnRunUssd7.TabIndex = 783
			Me.btnRunUssd7.Text = "تنفيذ"
			Me.btnRunUssd7.UseVisualStyleBackColor = False
			Me.txtUssdc8.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc8.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc8.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc8.Location = New Global.System.Drawing.Point(6, 239)
			Me.txtUssdc8.Name = "txtUssdc8"
			Me.txtUssdc8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc8.Size = New Global.System.Drawing.Size(128, 27)
			Me.txtUssdc8.TabIndex = 786
			Me.btnRunUssd8.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd8.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd8.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd8.Location = New Global.System.Drawing.Point(138, 241)
			Me.btnRunUssd8.Name = "btnRunUssd8"
			Me.btnRunUssd8.Size = New Global.System.Drawing.Size(63, 27)
			Me.btnRunUssd8.TabIndex = 785
			Me.btnRunUssd8.Text = "تنفيذ"
			Me.btnRunUssd8.UseVisualStyleBackColor = False
			Me.txtUssdc9.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc9.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc9.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc9.Location = New Global.System.Drawing.Point(6, 104)
			Me.txtUssdc9.Name = "txtUssdc9"
			Me.txtUssdc9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc9.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc9.TabIndex = 788
			Me.btnRunUssd9.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd9.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd9.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd9.Location = New Global.System.Drawing.Point(328, 104)
			Me.btnRunUssd9.Name = "btnRunUssd9"
			Me.btnRunUssd9.Size = New Global.System.Drawing.Size(62, 27)
			Me.btnRunUssd9.TabIndex = 787
			Me.btnRunUssd9.Text = "تنفيذ"
			Me.btnRunUssd9.UseVisualStyleBackColor = False
			Me.txtUssdc10.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdc10.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdc10.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdc10.Location = New Global.System.Drawing.Point(6, 131)
			Me.txtUssdc10.Name = "txtUssdc10"
			Me.txtUssdc10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdc10.Size = New Global.System.Drawing.Size(316, 27)
			Me.txtUssdc10.TabIndex = 790
			Me.btnRunUssd10.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssd10.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssd10.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssd10.Location = New Global.System.Drawing.Point(328, 131)
			Me.btnRunUssd10.Name = "btnRunUssd10"
			Me.btnRunUssd10.Size = New Global.System.Drawing.Size(63, 27)
			Me.btnRunUssd10.TabIndex = 789
			Me.btnRunUssd10.Text = "تنفيذ"
			Me.btnRunUssd10.UseVisualStyleBackColor = False
			Me.btnClear.BackColor = Global.System.Drawing.Color.FromArgb(255, 224, 192)
			Me.btnClear.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(6, 4)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(140, 35)
			Me.btnClear.TabIndex = 791
			Me.btnClear.Text = "Clear"
			Me.btnClear.UseVisualStyleBackColor = False
			Me.btnRR.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRR.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRR.Location = New Global.System.Drawing.Point(9, 179)
			Me.btnRR.Name = "btnRR"
			Me.btnRR.Size = New Global.System.Drawing.Size(160, 30)
			Me.btnRR.TabIndex = 792
			Me.btnRR.Text = "قراءة الرد"
			Me.btnRR.UseVisualStyleBackColor = False
			Me.btnUssdReset.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnUssdReset.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnUssdReset.Location = New Global.System.Drawing.Point(3, 6)
			Me.btnUssdReset.Name = "btnUssdReset"
			Me.btnUssdReset.Size = New Global.System.Drawing.Size(202, 65)
			Me.btnUssdReset.TabIndex = 793
			Me.btnUssdReset.Text = "Refresh USSD"
			Me.btnUssdReset.UseVisualStyleBackColor = False
			Me.btnClearSMS.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnClearSMS.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearSMS.Location = New Global.System.Drawing.Point(6, 108)
			Me.btnClearSMS.Name = "btnClearSMS"
			Me.btnClearSMS.Size = New Global.System.Drawing.Size(144, 27)
			Me.btnClearSMS.TabIndex = 809
			Me.btnClearSMS.Text = "مسح الرسائل"
			Me.btnClearSMS.UseVisualStyleBackColor = False
			Me.btnReadSms.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.btnReadSms.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnReadSms.Location = New Global.System.Drawing.Point(6, 77)
			Me.btnReadSms.Name = "btnReadSms"
			Me.btnReadSms.Size = New Global.System.Drawing.Size(144, 27)
			Me.btnReadSms.TabIndex = 808
			Me.btnReadSms.Text = "قراءة الرسائل"
			Me.btnReadSms.UseVisualStyleBackColor = False
			Me.lblNum6.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum6.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblNum6.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum6.Location = New Global.System.Drawing.Point(222, 217)
			Me.lblNum6.Name = "lblNum6"
			Me.lblNum6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum6.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum6.TabIndex = 815
			Me.lblNum6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNum5.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum5.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblNum5.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum5.Location = New Global.System.Drawing.Point(663, 218)
			Me.lblNum5.Name = "lblNum5"
			Me.lblNum5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum5.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum5.TabIndex = 814
			Me.lblNum5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNum4.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum4.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblNum4.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum4.Location = New Global.System.Drawing.Point(1113, 218)
			Me.lblNum4.Name = "lblNum4"
			Me.lblNum4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum4.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum4.TabIndex = 813
			Me.lblNum4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNum3.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum3.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblNum3.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum3.Location = New Global.System.Drawing.Point(222, 43)
			Me.lblNum3.Name = "lblNum3"
			Me.lblNum3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum3.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum3.TabIndex = 812
			Me.lblNum3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNum2.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum2.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold)
			Me.lblNum2.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum2.Location = New Global.System.Drawing.Point(663, 44)
			Me.lblNum2.Name = "lblNum2"
			Me.lblNum2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum2.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum2.TabIndex = 811
			Me.lblNum2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNum1.BackColor = Global.System.Drawing.Color.Black
			Me.lblNum1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblNum1.Font = New Global.System.Drawing.Font("Tahoma", 21.75F, Global.System.Drawing.FontStyle.Bold)
			Me.lblNum1.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.lblNum1.Location = New Global.System.Drawing.Point(1113, 42)
			Me.lblNum1.Name = "lblNum1"
			Me.lblNum1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum1.Size = New Global.System.Drawing.Size(227, 52)
			Me.lblNum1.TabIndex = 810
			Me.lblNum1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.ckBox.AutoSize = True
			Me.ckBox.Checked = True
			Me.ckBox.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.ckBox.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckBox.ForeColor = Global.System.Drawing.Color.Cyan
			Me.ckBox.Location = New Global.System.Drawing.Point(110, 213)
			Me.ckBox.Name = "ckBox"
			Me.ckBox.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckBox.Size = New Global.System.Drawing.Size(112, 17)
			Me.ckBox.TabIndex = 816
			Me.ckBox.Text = "تطبيق على الكل"
			Me.ckBox.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckBox.UseVisualStyleBackColor = True
			Me.btnRefreshEmpty.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRefreshEmpty.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRefreshEmpty.Location = New Global.System.Drawing.Point(9, 210)
			Me.btnRefreshEmpty.Name = "btnRefreshEmpty"
			Me.btnRefreshEmpty.Size = New Global.System.Drawing.Size(160, 32)
			Me.btnRefreshEmpty.TabIndex = 817
			Me.btnRefreshEmpty.Text = "Refresh"
			Me.btnRefreshEmpty.UseVisualStyleBackColor = False
			Me.btnNumbers.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnNumbers.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnNumbers.Location = New Global.System.Drawing.Point(106, 87)
			Me.btnNumbers.Name = "btnNumbers"
			Me.btnNumbers.Size = New Global.System.Drawing.Size(63, 40)
			Me.btnNumbers.TabIndex = 818
			Me.btnNumbers.Text = "MISSED Nums1"
			Me.btnNumbers.UseVisualStyleBackColor = False
			Me.ckME.AutoSize = True
			Me.ckME.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckME.ForeColor = Global.System.Drawing.Color.Cyan
			Me.ckME.Location = New Global.System.Drawing.Point(128, 60)
			Me.ckME.Name = "ckME"
			Me.ckME.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckME.Size = New Global.System.Drawing.Size(94, 17)
			Me.ckME.TabIndex = 819
			Me.ckME.Text = "رسائل الجهاز"
			Me.ckME.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckME.UseVisualStyleBackColor = True
			Me.btnGetOut.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetOut.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetOut.Location = New Global.System.Drawing.Point(6, 170)
			Me.btnGetOut.Name = "btnGetOut"
			Me.btnGetOut.Size = New Global.System.Drawing.Size(199, 42)
			Me.btnGetOut.TabIndex = 840
			Me.btnGetOut.Text = "Get "
			Me.btnGetOut.UseVisualStyleBackColor = False
			Me.btnSaveOut.BackColor = Global.System.Drawing.Color.Silver
			Me.btnSaveOut.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSaveOut.Location = New Global.System.Drawing.Point(1170, 4)
			Me.btnSaveOut.Name = "btnSaveOut"
			Me.btnSaveOut.Size = New Global.System.Drawing.Size(170, 35)
			Me.btnSaveOut.TabIndex = 839
			Me.btnSaveOut.Text = "Save"
			Me.btnSaveOut.UseVisualStyleBackColor = False
			Me.btnNumbers2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnNumbers2.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnNumbers2.Location = New Global.System.Drawing.Point(6, 87)
			Me.btnNumbers2.Name = "btnNumbers2"
			Me.btnNumbers2.Size = New Global.System.Drawing.Size(99, 40)
			Me.btnNumbers2.TabIndex = 851
			Me.btnNumbers2.Text = "MISSED Nums2"
			Me.btnNumbers2.UseVisualStyleBackColor = False
			Me.btnNumbers3.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnNumbers3.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnNumbers3.Location = New Global.System.Drawing.Point(6, 127)
			Me.btnNumbers3.Name = "btnNumbers3"
			Me.btnNumbers3.Size = New Global.System.Drawing.Size(99, 35)
			Me.btnNumbers3.TabIndex = 868
			Me.btnNumbers3.Text = "MISSED Nums3"
			Me.btnNumbers3.UseVisualStyleBackColor = False
			Me.txtLoopS.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopS.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopS.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopS.Location = New Global.System.Drawing.Point(6, 34)
			Me.txtLoopS.Name = "txtLoopS"
			Me.txtLoopS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopS.Size = New Global.System.Drawing.Size(37, 24)
			Me.txtLoopS.TabIndex = 870
			Me.txtLoopS.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopF.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopF.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopF.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopF.Location = New Global.System.Drawing.Point(6, 8)
			Me.txtLoopF.Name = "txtLoopF"
			Me.txtLoopF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopF.Size = New Global.System.Drawing.Size(37, 24)
			Me.txtLoopF.TabIndex = 869
			Me.txtLoopF.Text = "1"
			Me.txtLoopF.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnRunUssdGG.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunUssdGG.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRunUssdGG.ForeColor = Global.System.Drawing.Color.Black
			Me.btnRunUssdGG.Location = New Global.System.Drawing.Point(203, 242)
			Me.btnRunUssdGG.Name = "btnRunUssdGG"
			Me.btnRunUssdGG.Size = New Global.System.Drawing.Size(119, 27)
			Me.btnRunUssdGG.TabIndex = 871
			Me.btnRunUssdGG.Text = "تنفيذ مخصص"
			Me.btnRunUssdGG.UseVisualStyleBackColor = False
			Me.btnReplyBy.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy.Location = New Global.System.Drawing.Point(445, 42)
			Me.btnReplyBy.Name = "btnReplyBy"
			Me.btnReplyBy.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy.TabIndex = 872
			Me.btnReplyBy.Text = "Reply"
			Me.btnReplyBy.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy.UseVisualStyleBackColor = False
			Me.txtReplyBy.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy.Location = New Global.System.Drawing.Point(455, 49)
			Me.txtReplyBy.MaxLength = 1
			Me.txtReplyBy.Name = "txtReplyBy"
			Me.txtReplyBy.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy.Size = New Global.System.Drawing.Size(37, 17)
			Me.txtReplyBy.TabIndex = 873
			Me.txtReplyBy.TabStop = False
			Me.txtReplyBy.Text = "1"
			Me.txtReplyBy.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtReplyBy2.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy2.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy2.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy2.Location = New Global.System.Drawing.Point(455, 82)
			Me.txtReplyBy2.MaxLength = 1
			Me.txtReplyBy2.Name = "txtReplyBy2"
			Me.txtReplyBy2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy2.Size = New Global.System.Drawing.Size(37, 17)
			Me.txtReplyBy2.TabIndex = 878
			Me.txtReplyBy2.TabStop = False
			Me.txtReplyBy2.Text = "2"
			Me.txtReplyBy2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy2.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy2.Location = New Global.System.Drawing.Point(445, 75)
			Me.btnReplyBy2.Name = "btnReplyBy2"
			Me.btnReplyBy2.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy2.TabIndex = 877
			Me.btnReplyBy2.Text = "Reply"
			Me.btnReplyBy2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy2.UseVisualStyleBackColor = False
			Me.btnFawrySms.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnFawrySms.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnFawrySms.ForeColor = Global.System.Drawing.Color.Black
			Me.btnFawrySms.Location = New Global.System.Drawing.Point(9, 242)
			Me.btnFawrySms.Name = "btnFawrySms"
			Me.btnFawrySms.Size = New Global.System.Drawing.Size(160, 38)
			Me.btnFawrySms.TabIndex = 879
			Me.btnFawrySms.Text = "تصدير الرسائل"
			Me.btnFawrySms.UseVisualStyleBackColor = False
			Me.lblBal6.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal6.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal6.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal6.Location = New Global.System.Drawing.Point(42, 216)
			Me.lblBal6.Name = "lblBal6"
			Me.lblBal6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal6.Size = New Global.System.Drawing.Size(107, 27)
			Me.lblBal6.TabIndex = 888
			Me.lblBal6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblBal5.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal5.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal5.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal5.Location = New Global.System.Drawing.Point(481, 216)
			Me.lblBal5.Name = "lblBal5"
			Me.lblBal5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal5.Size = New Global.System.Drawing.Size(107, 27)
			Me.lblBal5.TabIndex = 887
			Me.lblBal5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblBal4.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal4.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal4.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal4.Location = New Global.System.Drawing.Point(923, 216)
			Me.lblBal4.Name = "lblBal4"
			Me.lblBal4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal4.Size = New Global.System.Drawing.Size(117, 27)
			Me.lblBal4.TabIndex = 886
			Me.lblBal4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblBal3.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal3.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal3.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal3.Location = New Global.System.Drawing.Point(42, 42)
			Me.lblBal3.Name = "lblBal3"
			Me.lblBal3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal3.Size = New Global.System.Drawing.Size(107, 27)
			Me.lblBal3.TabIndex = 885
			Me.lblBal3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblBal2.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal2.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal2.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal2.Location = New Global.System.Drawing.Point(481, 42)
			Me.lblBal2.Name = "lblBal2"
			Me.lblBal2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal2.Size = New Global.System.Drawing.Size(107, 27)
			Me.lblBal2.TabIndex = 884
			Me.lblBal2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblBal1.BackColor = Global.System.Drawing.Color.Black
			Me.lblBal1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblBal1.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblBal1.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblBal1.Location = New Global.System.Drawing.Point(923, 42)
			Me.lblBal1.Name = "lblBal1"
			Me.lblBal1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblBal1.Size = New Global.System.Drawing.Size(117, 27)
			Me.lblBal1.TabIndex = 883
			Me.lblBal1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtInfo.BackColor = Global.System.Drawing.Color.Black
			Me.txtInfo.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtInfo.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtInfo.Location = New Global.System.Drawing.Point(6, 194)
			Me.txtInfo.Multiline = True
			Me.txtInfo.Name = "txtInfo"
			Me.txtInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtInfo.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtInfo.Size = New Global.System.Drawing.Size(216, 96)
			Me.txtInfo.TabIndex = 890
			Me.txtEproc.BackColor = Global.System.Drawing.Color.Black
			Me.txtEproc.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtEproc.ForeColor = Global.System.Drawing.Color.Yellow
			Me.txtEproc.Location = New Global.System.Drawing.Point(0, 765)
			Me.txtEproc.Name = "txtEproc"
			Me.txtEproc.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEproc.Size = New Global.System.Drawing.Size(150, 24)
			Me.txtEproc.TabIndex = 891
			Me.txtEproc.Visible = False
			Me.txtReplyBy3.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy3.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy3.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy3.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy3.Location = New Global.System.Drawing.Point(455, 116)
			Me.txtReplyBy3.MaxLength = 1
			Me.txtReplyBy3.Name = "txtReplyBy3"
			Me.txtReplyBy3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy3.Size = New Global.System.Drawing.Size(37, 17)
			Me.txtReplyBy3.TabIndex = 893
			Me.txtReplyBy3.TabStop = False
			Me.txtReplyBy3.Text = "3"
			Me.txtReplyBy3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy3.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy3.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy3.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy3.Location = New Global.System.Drawing.Point(445, 108)
			Me.btnReplyBy3.Name = "btnReplyBy3"
			Me.btnReplyBy3.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy3.TabIndex = 892
			Me.btnReplyBy3.Text = "Reply"
			Me.btnReplyBy3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy3.UseVisualStyleBackColor = False
			Me.lblCard4.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard4.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard4.Location = New Global.System.Drawing.Point(731, 573)
			Me.lblCard4.Name = "lblCard4"
			Me.lblCard4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard4.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard4.TabIndex = 895
			Me.lblCard4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard4.Visible = False
			Me.lblCard5.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard5.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard5.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard5.Location = New Global.System.Drawing.Point(731, 514)
			Me.lblCard5.Name = "lblCard5"
			Me.lblCard5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard5.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard5.TabIndex = 896
			Me.lblCard5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard5.Visible = False
			Me.lblCard6.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard6.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard6.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard6.Location = New Global.System.Drawing.Point(731, 661)
			Me.lblCard6.Name = "lblCard6"
			Me.lblCard6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard6.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard6.TabIndex = 897
			Me.lblCard6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard6.Visible = False
			Me.lblCard3.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard3.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard3.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard3.Location = New Global.System.Drawing.Point(731, 631)
			Me.lblCard3.Name = "lblCard3"
			Me.lblCard3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard3.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard3.TabIndex = 900
			Me.lblCard3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard3.Visible = False
			Me.lblCard2.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard2.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard2.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard2.Location = New Global.System.Drawing.Point(731, 541)
			Me.lblCard2.Name = "lblCard2"
			Me.lblCard2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard2.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard2.TabIndex = 899
			Me.lblCard2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard2.Visible = False
			Me.lblCard1.BackColor = Global.System.Drawing.Color.Silver
			Me.lblCard1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCard1.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCard1.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCard1.Location = New Global.System.Drawing.Point(731, 601)
			Me.lblCard1.Name = "lblCard1"
			Me.lblCard1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCard1.Size = New Global.System.Drawing.Size(140, 27)
			Me.lblCard1.TabIndex = 898
			Me.lblCard1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblCard1.Visible = False
			Me.btnApplyCards.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.btnApplyCards.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApplyCards.Location = New Global.System.Drawing.Point(419, 14)
			Me.btnApplyCards.Name = "btnApplyCards"
			Me.btnApplyCards.Size = New Global.System.Drawing.Size(186, 44)
			Me.btnApplyCards.TabIndex = 901
			Me.btnApplyCards.Text = "شحن كروت جديدة"
			Me.btnApplyCards.UseVisualStyleBackColor = False
			Me.ckCards.AutoSize = True
			Me.ckCards.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckCards.Location = New Global.System.Drawing.Point(56, 83)
			Me.ckCards.Name = "ckCards"
			Me.ckCards.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckCards.Size = New Global.System.Drawing.Size(113, 17)
			Me.ckCards.TabIndex = 902
			Me.ckCards.Text = "امان شحن كروت"
			Me.ckCards.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckCards.UseVisualStyleBackColor = True
			Me.btnAddCards.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.btnAddCards.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAddCards.ForeColor = Global.System.Drawing.Color.Black
			Me.btnAddCards.Location = New Global.System.Drawing.Point(24, 14)
			Me.btnAddCards.Name = "btnAddCards"
			Me.btnAddCards.Size = New Global.System.Drawing.Size(151, 40)
			Me.btnAddCards.TabIndex = 903
			Me.btnAddCards.Text = "اضافة كروت شحن"
			Me.btnAddCards.UseVisualStyleBackColor = False
			Me.lblCardsQty.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.lblCardsQty.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCardsQty.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCardsQty.ForeColor = Global.System.Drawing.Color.White
			Me.lblCardsQty.Location = New Global.System.Drawing.Point(99, 53)
			Me.lblCardsQty.Name = "lblCardsQty"
			Me.lblCardsQty.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCardsQty.Size = New Global.System.Drawing.Size(50, 27)
			Me.lblCardsQty.TabIndex = 904
			Me.lblCardsQty.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.cmbEvalue.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbEvalue.FormattingEnabled = True
			Me.cmbEvalue.Location = New Global.System.Drawing.Point(24, 57)
			Me.cmbEvalue.Name = "cmbEvalue"
			Me.cmbEvalue.Size = New Global.System.Drawing.Size(69, 21)
			Me.cmbEvalue.TabIndex = 905
			Me.chkCh1.AutoSize = True
			Me.chkCh1.Checked = True
			Me.chkCh1.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh1.Location = New Global.System.Drawing.Point(902, 64)
			Me.chkCh1.Name = "chkCh1"
			Me.chkCh1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh1.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh1.TabIndex = 906
			Me.chkCh1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh1.UseVisualStyleBackColor = True
			Me.chkCh2.AutoSize = True
			Me.chkCh2.Checked = True
			Me.chkCh2.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh2.Location = New Global.System.Drawing.Point(457, 63)
			Me.chkCh2.Name = "chkCh2"
			Me.chkCh2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh2.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh2.TabIndex = 907
			Me.chkCh2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh2.UseVisualStyleBackColor = True
			Me.chkCh3.AutoSize = True
			Me.chkCh3.Checked = True
			Me.chkCh3.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh3.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkCh3.Location = New Global.System.Drawing.Point(12, 63)
			Me.chkCh3.Name = "chkCh3"
			Me.chkCh3.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh3.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh3.TabIndex = 908
			Me.chkCh3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh3.UseVisualStyleBackColor = True
			Me.chkCh4.AutoSize = True
			Me.chkCh4.Checked = True
			Me.chkCh4.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh4.Location = New Global.System.Drawing.Point(902, 240)
			Me.chkCh4.Name = "chkCh4"
			Me.chkCh4.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh4.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh4.TabIndex = 909
			Me.chkCh4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh4.UseVisualStyleBackColor = True
			Me.chkCh5.AutoSize = True
			Me.chkCh5.Checked = True
			Me.chkCh5.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh5.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh5.Location = New Global.System.Drawing.Point(457, 240)
			Me.chkCh5.Name = "chkCh5"
			Me.chkCh5.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh5.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh5.TabIndex = 910
			Me.chkCh5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh5.UseVisualStyleBackColor = True
			Me.chkCh6.AutoSize = True
			Me.chkCh6.Checked = True
			Me.chkCh6.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh6.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh6.Location = New Global.System.Drawing.Point(12, 240)
			Me.chkCh6.Name = "chkCh6"
			Me.chkCh6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh6.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh6.TabIndex = 911
			Me.chkCh6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh6.UseVisualStyleBackColor = True
			Me.txtChSS.BackColor = Global.System.Drawing.Color.White
			Me.txtChSS.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtChSS.ForeColor = Global.System.Drawing.Color.Black
			Me.txtChSS.Location = New Global.System.Drawing.Point(150, 53)
			Me.txtChSS.Name = "txtChSS"
			Me.txtChSS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtChSS.Size = New Global.System.Drawing.Size(22, 27)
			Me.txtChSS.TabIndex = 912
			Me.txtChSS.Text = "0"
			Me.btnApplyCards2.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.btnApplyCards2.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApplyCards2.Location = New Global.System.Drawing.Point(420, 60)
			Me.btnApplyCards2.Name = "btnApplyCards2"
			Me.btnApplyCards2.Size = New Global.System.Drawing.Size(186, 39)
			Me.btnApplyCards2.TabIndex = 913
			Me.btnApplyCards2.Text = "شحن الكروت الحالية"
			Me.btnApplyCards2.UseVisualStyleBackColor = False
			Me.btnDeSA.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.btnDeSA.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDeSA.Location = New Global.System.Drawing.Point(6, 101)
			Me.btnDeSA.Name = "btnDeSA"
			Me.btnDeSA.Size = New Global.System.Drawing.Size(139, 46)
			Me.btnDeSA.TabIndex = 932
			Me.btnDeSA.Text = "DeSel"
			Me.btnDeSA.UseVisualStyleBackColor = False
			Me.btnSA.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnSA.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSA.Location = New Global.System.Drawing.Point(6, 60)
			Me.btnSA.Name = "btnSA"
			Me.btnSA.Size = New Global.System.Drawing.Size(216, 44)
			Me.btnSA.TabIndex = 931
			Me.btnSA.Text = "Select All"
			Me.btnSA.UseVisualStyleBackColor = False
			Me.chkIgnorSms.AutoSize = True
			Me.chkIgnorSms.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.chkIgnorSms.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkIgnorSms.Location = New Global.System.Drawing.Point(68, 27)
			Me.chkIgnorSms.Name = "chkIgnorSms"
			Me.chkIgnorSms.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkIgnorSms.Size = New Global.System.Drawing.Size(154, 16)
			Me.chkIgnorSms.TabIndex = 941
			Me.chkIgnorSms.Text = "تجاهل الرسائل غير المرغوبة"
			Me.chkIgnorSms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkIgnorSms.UseVisualStyleBackColor = True
			Me.RBEts.AutoSize = True
			Me.RBEts.Checked = True
			Me.RBEts.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.RBEts.ForeColor = Global.System.Drawing.Color.Lime
			Me.RBEts.Location = New Global.System.Drawing.Point(276, 31)
			Me.RBEts.Name = "RBEts"
			Me.RBEts.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RBEts.Size = New Global.System.Drawing.Size(119, 23)
			Me.RBEts.TabIndex = 942
			Me.RBEts.TabStop = True
			Me.RBEts.Text = "شحن اتصالات"
			Me.RBEts.UseVisualStyleBackColor = True
			Me.RBVoda.AutoSize = True
			Me.RBVoda.Font = New Global.System.Drawing.Font("Tahoma", 12F)
			Me.RBVoda.ForeColor = Global.System.Drawing.Color.Red
			Me.RBVoda.Location = New Global.System.Drawing.Point(274, 60)
			Me.RBVoda.Name = "RBVoda"
			Me.RBVoda.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RBVoda.Size = New Global.System.Drawing.Size(121, 23)
			Me.RBVoda.TabIndex = 943
			Me.RBVoda.Text = "شحن فودافون"
			Me.RBVoda.UseVisualStyleBackColor = True
			Me.chkSlowRead.AutoSize = True
			Me.chkSlowRead.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkSlowRead.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkSlowRead.Location = New Global.System.Drawing.Point(92, 43)
			Me.chkSlowRead.Name = "chkSlowRead"
			Me.chkSlowRead.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkSlowRead.Size = New Global.System.Drawing.Size(130, 17)
			Me.chkSlowRead.TabIndex = 944
			Me.chkSlowRead.Text = "قراءة بطيئة للرسائل"
			Me.chkSlowRead.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkSlowRead.UseVisualStyleBackColor = True
			Me.txtReplyBy4.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy4.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy4.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy4.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy4.Location = New Global.System.Drawing.Point(456, 149)
			Me.txtReplyBy4.MaxLength = 1
			Me.txtReplyBy4.Name = "txtReplyBy4"
			Me.txtReplyBy4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy4.Size = New Global.System.Drawing.Size(36, 17)
			Me.txtReplyBy4.TabIndex = 946
			Me.txtReplyBy4.TabStop = False
			Me.txtReplyBy4.Text = "4"
			Me.txtReplyBy4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy4.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy4.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy4.Location = New Global.System.Drawing.Point(445, 141)
			Me.btnReplyBy4.Name = "btnReplyBy4"
			Me.btnReplyBy4.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy4.TabIndex = 945
			Me.btnReplyBy4.Text = "Reply"
			Me.btnReplyBy4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy4.UseVisualStyleBackColor = False
			Me.txtReplyBy5.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy5.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy5.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy5.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy5.Location = New Global.System.Drawing.Point(456, 182)
			Me.txtReplyBy5.MaxLength = 1
			Me.txtReplyBy5.Name = "txtReplyBy5"
			Me.txtReplyBy5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy5.Size = New Global.System.Drawing.Size(36, 17)
			Me.txtReplyBy5.TabIndex = 948
			Me.txtReplyBy5.TabStop = False
			Me.txtReplyBy5.Text = "5"
			Me.txtReplyBy5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy5.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy5.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy5.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy5.Location = New Global.System.Drawing.Point(445, 174)
			Me.btnReplyBy5.Name = "btnReplyBy5"
			Me.btnReplyBy5.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy5.TabIndex = 947
			Me.btnReplyBy5.Text = "Reply"
			Me.btnReplyBy5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy5.UseVisualStyleBackColor = False
			Me.txtReplyBy0.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy0.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy0.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy0.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyBy0.Location = New Global.System.Drawing.Point(455, 21)
			Me.txtReplyBy0.MaxLength = 1
			Me.txtReplyBy0.Name = "txtReplyBy0"
			Me.txtReplyBy0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy0.Size = New Global.System.Drawing.Size(37, 17)
			Me.txtReplyBy0.TabIndex = 950
			Me.txtReplyBy0.TabStop = False
			Me.txtReplyBy0.Text = "0"
			Me.txtReplyBy0.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy0.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy0.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy0.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy0.Location = New Global.System.Drawing.Point(445, 9)
			Me.btnReplyBy0.Name = "btnReplyBy0"
			Me.btnReplyBy0.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy0.TabIndex = 949
			Me.btnReplyBy0.Text = "Reply"
			Me.btnReplyBy0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy0.UseVisualStyleBackColor = False
			Me.MainTC.Controls.Add(Me.VodaCashPAnel)
			Me.MainTC.Controls.Add(Me.tabvc2)
			Me.MainTC.Controls.Add(Me.tab365_2)
			Me.MainTC.Controls.Add(Me.TabPage4)
			Me.MainTC.Controls.Add(Me.tabOcash)
			Me.MainTC.Controls.Add(Me.tabOCCon)
			Me.MainTC.Controls.Add(Me.tabOCMaster)
			Me.MainTC.Controls.Add(Me.tabOCGifts)
			Me.MainTC.Controls.Add(Me.tabOCSetup)
			Me.MainTC.Controls.Add(Me.tabOrngInv)
			Me.MainTC.Controls.Add(Me.TabPage1)
			Me.MainTC.Controls.Add(Me.TabPage7)
			Me.MainTC.Controls.Add(Me.tabPrint)
			Me.MainTC.Controls.Add(Me.TabPage3)
			Me.MainTC.Controls.Add(Me.TabPage5)
			Me.MainTC.Controls.Add(Me.TabPage14)
			Me.MainTC.Controls.Add(Me.TabPage12)
			Me.MainTC.Controls.Add(Me.TabPage13)
			Me.MainTC.Controls.Add(Me.TabPage6)
			Me.MainTC.Controls.Add(Me.tabTayer)
			Me.MainTC.Controls.Add(Me.tabEzoo)
			Me.MainTC.Controls.Add(Me.tab365)
			Me.MainTC.Controls.Add(Me.tabpoints)
			Me.MainTC.Controls.Add(Me.tabON)
			Me.MainTC.Controls.Add(Me.TabPage2)
			Me.MainTC.Controls.Add(Me.TabPage8)
			Me.MainTC.Controls.Add(Me.TabPage9)
			Me.MainTC.Controls.Add(Me.TabPage10)
			Me.MainTC.Location = New Global.System.Drawing.Point(6, 393)
			Me.MainTC.Name = "MainTC"
			Me.MainTC.SelectedIndex = 0
			Me.MainTC.Size = New Global.System.Drawing.Size(942, 321)
			Me.MainTC.TabIndex = 951
			Me.VodaCashPAnel.BackColor = Global.System.Drawing.Color.Red
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransToNm)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransFromNm)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransGiftAutoSpValAll0)
			Me.VodaCashPAnel.Controls.Add(Me.btnRun02NmDwl)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransGiftAuto)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransGiftAutoSpValAll)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransFromNm)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransToNm)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnRun02Nm)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransGiftAutoSpValAll)
			Me.VodaCashPAnel.Controls.Add(Me.chkAutoTransferCash)
			Me.VodaCashPAnel.Controls.Add(Me.lbl100)
			Me.VodaCashPAnel.Controls.Add(Me.lbl35)
			Me.VodaCashPAnel.Controls.Add(Me.lbl50)
			Me.VodaCashPAnel.Controls.Add(Me.chkAutoTransferNrm)
			Me.VodaCashPAnel.Controls.Add(Me.chAutoGooo2)
			Me.VodaCashPAnel.Controls.Add(Me.lbl45)
			Me.VodaCashPAnel.Controls.Add(Me.lbl40)
			Me.VodaCashPAnel.Controls.Add(Me.chAutoGooo)
			Me.VodaCashPAnel.Controls.Add(Me.ckbtnTransGiftAutoSpVal)
			Me.VodaCashPAnel.Controls.Add(Me.btnAutoVC_SeresWtop)
			Me.VodaCashPAnel.Controls.Add(Me.ckTransP)
			Me.VodaCashPAnel.Controls.Add(Me.txtTransP)
			Me.VodaCashPAnel.Controls.Add(Me.lbl30)
			Me.VodaCashPAnel.Controls.Add(Me.lbl25)
			Me.VodaCashPAnel.Controls.Add(Me.lbl20)
			Me.VodaCashPAnel.Controls.Add(Me.lbl15)
			Me.VodaCashPAnel.Controls.Add(Me.lbl10)
			Me.VodaCashPAnel.Controls.Add(Me.lbl05)
			Me.VodaCashPAnel.Controls.Add(Me.chkTransGift)
			Me.VodaCashPAnel.Controls.Add(Me.chkGetgift)
			Me.VodaCashPAnel.Controls.Add(Me.btnExchangeNN)
			Me.VodaCashPAnel.Controls.Add(Me.chbeep)
			Me.VodaCashPAnel.Controls.Add(Me.chkInDB)
			Me.VodaCashPAnel.Controls.Add(Me.btnAutoVC_Hez)
			Me.VodaCashPAnel.Controls.Add(Me.chkRefref)
			Me.VodaCashPAnel.Controls.Add(Me.cknull)
			Me.VodaCashPAnel.Controls.Add(Me.btnAutoVC_Seres)
			Me.VodaCashPAnel.Controls.Add(Me.txtVCForceMony)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransToNextMain)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransGiftAutoSpVal)
			Me.VodaCashPAnel.Controls.Add(Me.Label37)
			Me.VodaCashPAnel.Controls.Add(Me.Label24)
			Me.VodaCashPAnel.Controls.Add(Me.btnAutoVCnorm)
			Me.VodaCashPAnel.Controls.Add(Me.Label14)
			Me.VodaCashPAnel.Controls.Add(Me.txtTransNum2)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransGiftAuto)
			Me.VodaCashPAnel.Controls.Add(Me.txtCashNextMaster)
			Me.VodaCashPAnel.Controls.Add(Me.btnRun02Nm)
			Me.VodaCashPAnel.Controls.Add(Me.lblMain)
			Me.VodaCashPAnel.Controls.Add(Me.Label21)
			Me.VodaCashPAnel.Controls.Add(Me.txtMonyMn)
			Me.VodaCashPAnel.Controls.Add(Me.btnGetBal2)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransAllMn)
			Me.VodaCashPAnel.Controls.Add(Me.btnTransGiftAutoNorm)
			Me.VodaCashPAnel.ForeColor = Global.System.Drawing.Color.Black
			Me.VodaCashPAnel.Location = New Global.System.Drawing.Point(4, 22)
			Me.VodaCashPAnel.Name = "VodaCashPAnel"
			Me.VodaCashPAnel.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.VodaCashPAnel.Size = New Global.System.Drawing.Size(934, 295)
			Me.VodaCashPAnel.TabIndex = 6
			Me.VodaCashPAnel.Text = "VfC Series"
			Me.ckbtnTransToNm.AutoSize = True
			Me.ckbtnTransToNm.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTransToNm.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransToNm.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransToNm.Location = New Global.System.Drawing.Point(884, 209)
			Me.ckbtnTransToNm.Name = "ckbtnTransToNm"
			Me.ckbtnTransToNm.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransToNm.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnTransToNm.TabIndex = 1076
			Me.ckbtnTransToNm.Text = "Au"
			Me.ckbtnTransToNm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransToNm.UseVisualStyleBackColor = False
			Me.ckbtnTransFromNm.AutoSize = True
			Me.ckbtnTransFromNm.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTransFromNm.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransFromNm.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransFromNm.Location = New Global.System.Drawing.Point(887, 250)
			Me.ckbtnTransFromNm.Name = "ckbtnTransFromNm"
			Me.ckbtnTransFromNm.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransFromNm.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnTransFromNm.TabIndex = 1075
			Me.ckbtnTransFromNm.Text = "Au"
			Me.ckbtnTransFromNm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransFromNm.UseVisualStyleBackColor = False
			Me.ckbtnTransGiftAutoSpValAll0.AutoSize = True
			Me.ckbtnTransGiftAutoSpValAll0.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.ckbtnTransGiftAutoSpValAll0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransGiftAutoSpValAll0.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransGiftAutoSpValAll0.Location = New Global.System.Drawing.Point(7, 268)
			Me.ckbtnTransGiftAutoSpValAll0.Name = "ckbtnTransGiftAutoSpValAll0"
			Me.ckbtnTransGiftAutoSpValAll0.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransGiftAutoSpValAll0.Size = New Global.System.Drawing.Size(46, 21)
			Me.ckbtnTransGiftAutoSpValAll0.TabIndex = 1074
			Me.ckbtnTransGiftAutoSpValAll0.Text = "Au"
			Me.ckbtnTransGiftAutoSpValAll0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransGiftAutoSpValAll0.UseVisualStyleBackColor = False
			Me.btnRun02NmDwl.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRun02NmDwl.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRun02NmDwl.Location = New Global.System.Drawing.Point(234, 73)
			Me.btnRun02NmDwl.Name = "btnRun02NmDwl"
			Me.btnRun02NmDwl.Size = New Global.System.Drawing.Size(190, 39)
			Me.btnRun02NmDwl.TabIndex = 1073
			Me.btnRun02NmDwl.Text = "الهدايا"
			Me.btnRun02NmDwl.UseVisualStyleBackColor = False
			Me.ckbtnTransGiftAuto.AutoSize = True
			Me.ckbtnTransGiftAuto.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTransGiftAuto.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransGiftAuto.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransGiftAuto.Location = New Global.System.Drawing.Point(381, 179)
			Me.ckbtnTransGiftAuto.Name = "ckbtnTransGiftAuto"
			Me.ckbtnTransGiftAuto.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransGiftAuto.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnTransGiftAuto.TabIndex = 1050
			Me.ckbtnTransGiftAuto.Text = "Au"
			Me.ckbtnTransGiftAuto.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransGiftAuto.UseVisualStyleBackColor = False
			Me.ckbtnTransGiftAutoSpValAll.AutoSize = True
			Me.ckbtnTransGiftAutoSpValAll.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTransGiftAutoSpValAll.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransGiftAutoSpValAll.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransGiftAutoSpValAll.Location = New Global.System.Drawing.Point(179, 245)
			Me.ckbtnTransGiftAutoSpValAll.Name = "ckbtnTransGiftAutoSpValAll"
			Me.ckbtnTransGiftAutoSpValAll.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransGiftAutoSpValAll.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnTransGiftAutoSpValAll.TabIndex = 1072
			Me.ckbtnTransGiftAutoSpValAll.Text = "Au"
			Me.ckbtnTransGiftAutoSpValAll.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransGiftAutoSpValAll.UseVisualStyleBackColor = False
			Me.btnTransFromNm.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransFromNm.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransFromNm.Location = New Global.System.Drawing.Point(722, 250)
			Me.btnTransFromNm.Name = "btnTransFromNm"
			Me.btnTransFromNm.Size = New Global.System.Drawing.Size(204, 39)
			Me.btnTransFromNm.TabIndex = 983
			Me.btnTransFromNm.Text = "تحويل من الكل الى"
			Me.btnTransFromNm.UseVisualStyleBackColor = False
			Me.btnTransToNm.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransToNm.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransToNm.Location = New Global.System.Drawing.Point(722, 205)
			Me.btnTransToNm.Name = "btnTransToNm"
			Me.btnTransToNm.Size = New Global.System.Drawing.Size(203, 39)
			Me.btnTransToNm.TabIndex = 982
			Me.btnTransToNm.Text = "تحويل من الاساسى"
			Me.btnTransToNm.UseVisualStyleBackColor = False
			Me.ckbtnRun02Nm.AutoSize = True
			Me.ckbtnRun02Nm.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnRun02Nm.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnRun02Nm.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnRun02Nm.Location = New Global.System.Drawing.Point(381, 120)
			Me.ckbtnRun02Nm.Name = "ckbtnRun02Nm"
			Me.ckbtnRun02Nm.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnRun02Nm.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnRun02Nm.TabIndex = 1049
			Me.ckbtnRun02Nm.Text = "Au"
			Me.ckbtnRun02Nm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnRun02Nm.UseVisualStyleBackColor = False
			Me.btnTransGiftAutoSpValAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAutoSpValAll.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAutoSpValAll.Location = New Global.System.Drawing.Point(7, 236)
			Me.btnTransGiftAutoSpValAll.Name = "btnTransGiftAutoSpValAll"
			Me.btnTransGiftAutoSpValAll.Size = New Global.System.Drawing.Size(215, 53)
			Me.btnTransGiftAutoSpValAll.TabIndex = 1071
			Me.btnTransGiftAutoSpValAll.Text = "TopUp All Cash Back"
			Me.btnTransGiftAutoSpValAll.UseVisualStyleBackColor = False
			Me.chkAutoTransferCash.AutoSize = True
			Me.chkAutoTransferCash.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkAutoTransferCash.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAutoTransferCash.ForeColor = Global.System.Drawing.Color.Black
			Me.chkAutoTransferCash.Location = New Global.System.Drawing.Point(884, 16)
			Me.chkAutoTransferCash.Name = "chkAutoTransferCash"
			Me.chkAutoTransferCash.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAutoTransferCash.Size = New Global.System.Drawing.Size(41, 17)
			Me.chkAutoTransferCash.TabIndex = 1050
			Me.chkAutoTransferCash.Text = "Au"
			Me.chkAutoTransferCash.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAutoTransferCash.UseVisualStyleBackColor = False
			Me.lbl100.BackColor = Global.System.Drawing.Color.White
			Me.lbl100.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl100.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl100.Location = New Global.System.Drawing.Point(8, 193)
			Me.lbl100.Name = "lbl100"
			Me.lbl100.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl100.Size = New Global.System.Drawing.Size(104, 37)
			Me.lbl100.TabIndex = 1070
			Me.lbl100.Text = "100"
			Me.lbl100.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl35.BackColor = Global.System.Drawing.Color.White
			Me.lbl35.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl35.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl35.Location = New Global.System.Drawing.Point(118, 151)
			Me.lbl35.Name = "lbl35"
			Me.lbl35.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl35.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl35.TabIndex = 1069
			Me.lbl35.Text = "35"
			Me.lbl35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl50.BackColor = Global.System.Drawing.Color.White
			Me.lbl50.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl50.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl50.Location = New Global.System.Drawing.Point(118, 193)
			Me.lbl50.Name = "lbl50"
			Me.lbl50.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl50.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl50.TabIndex = 1068
			Me.lbl50.Text = "50"
			Me.lbl50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chkAutoTransferNrm.AutoSize = True
			Me.chkAutoTransferNrm.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkAutoTransferNrm.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAutoTransferNrm.ForeColor = Global.System.Drawing.Color.Black
			Me.chkAutoTransferNrm.Location = New Global.System.Drawing.Point(885, 72)
			Me.chkAutoTransferNrm.Name = "chkAutoTransferNrm"
			Me.chkAutoTransferNrm.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAutoTransferNrm.Size = New Global.System.Drawing.Size(41, 17)
			Me.chkAutoTransferNrm.TabIndex = 1051
			Me.chkAutoTransferNrm.Text = "Au"
			Me.chkAutoTransferNrm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAutoTransferNrm.UseVisualStyleBackColor = False
			Me.chAutoGooo2.AutoSize = True
			Me.chAutoGooo2.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chAutoGooo2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chAutoGooo2.ForeColor = Global.System.Drawing.Color.Black
			Me.chAutoGooo2.Location = New Global.System.Drawing.Point(619, 245)
			Me.chAutoGooo2.Name = "chAutoGooo2"
			Me.chAutoGooo2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chAutoGooo2.Size = New Global.System.Drawing.Size(42, 17)
			Me.chAutoGooo2.TabIndex = 1009
			Me.chAutoGooo2.Text = "AU"
			Me.chAutoGooo2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chAutoGooo2.UseVisualStyleBackColor = False
			Me.lbl45.BackColor = Global.System.Drawing.Color.White
			Me.lbl45.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl45.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl45.Location = New Global.System.Drawing.Point(175, 193)
			Me.lbl45.Name = "lbl45"
			Me.lbl45.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl45.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl45.TabIndex = 1067
			Me.lbl45.Text = "45"
			Me.lbl45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl40.BackColor = Global.System.Drawing.Color.White
			Me.lbl40.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl40.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl40.Location = New Global.System.Drawing.Point(175, 151)
			Me.lbl40.Name = "lbl40"
			Me.lbl40.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl40.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl40.TabIndex = 1066
			Me.lbl40.Text = "40"
			Me.lbl40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chAutoGooo.AutoSize = True
			Me.chAutoGooo.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chAutoGooo.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chAutoGooo.ForeColor = Global.System.Drawing.Color.Black
			Me.chAutoGooo.Location = New Global.System.Drawing.Point(378, 15)
			Me.chAutoGooo.Name = "chAutoGooo"
			Me.chAutoGooo.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chAutoGooo.Size = New Global.System.Drawing.Size(42, 17)
			Me.chAutoGooo.TabIndex = 1008
			Me.chAutoGooo.Text = "AU"
			Me.chAutoGooo.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chAutoGooo.UseVisualStyleBackColor = False
			Me.ckbtnTransGiftAutoSpVal.AutoSize = True
			Me.ckbtnTransGiftAutoSpVal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTransGiftAutoSpVal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTransGiftAutoSpVal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTransGiftAutoSpVal.Location = New Global.System.Drawing.Point(183, 56)
			Me.ckbtnTransGiftAutoSpVal.Name = "ckbtnTransGiftAutoSpVal"
			Me.ckbtnTransGiftAutoSpVal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTransGiftAutoSpVal.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckbtnTransGiftAutoSpVal.TabIndex = 1064
			Me.ckbtnTransGiftAutoSpVal.Text = "Au"
			Me.ckbtnTransGiftAutoSpVal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTransGiftAutoSpVal.UseVisualStyleBackColor = False
			Me.btnAutoVC_SeresWtop.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVC_SeresWtop.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVC_SeresWtop.Location = New Global.System.Drawing.Point(722, 153)
			Me.btnAutoVC_SeresWtop.Name = "btnAutoVC_SeresWtop"
			Me.btnAutoVC_SeresWtop.Size = New Global.System.Drawing.Size(204, 47)
			Me.btnAutoVC_SeresWtop.TabIndex = 1063
			Me.btnAutoVC_SeresWtop.Text = "شحن متتالى"
			Me.btnAutoVC_SeresWtop.UseVisualStyleBackColor = False
			Me.ckTransP.AutoSize = True
			Me.ckTransP.BackColor = Global.System.Drawing.Color.Red
			Me.ckTransP.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckTransP.Location = New Global.System.Drawing.Point(537, 213)
			Me.ckTransP.Name = "ckTransP"
			Me.ckTransP.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckTransP.Size = New Global.System.Drawing.Size(78, 17)
			Me.ckTransP.TabIndex = 1062
			Me.ckTransP.Text = "خصم مبلغ"
			Me.ckTransP.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckTransP.UseVisualStyleBackColor = False
			Me.txtTransP.BackColor = Global.System.Drawing.Color.White
			Me.txtTransP.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransP.Location = New Global.System.Drawing.Point(436, 209)
			Me.txtTransP.MaxLength = 100
			Me.txtTransP.Name = "txtTransP"
			Me.txtTransP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransP.Size = New Global.System.Drawing.Size(95, 24)
			Me.txtTransP.TabIndex = 1061
			Me.txtTransP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lbl30.BackColor = Global.System.Drawing.Color.White
			Me.lbl30.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl30.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl30.Location = New Global.System.Drawing.Point(63, 151)
			Me.lbl30.Name = "lbl30"
			Me.lbl30.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl30.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl30.TabIndex = 1059
			Me.lbl30.Text = "30"
			Me.lbl30.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl25.BackColor = Global.System.Drawing.Color.White
			Me.lbl25.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl25.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl25.Location = New Global.System.Drawing.Point(8, 151)
			Me.lbl25.Name = "lbl25"
			Me.lbl25.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl25.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl25.TabIndex = 1058
			Me.lbl25.Text = "25"
			Me.lbl25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl20.BackColor = Global.System.Drawing.Color.White
			Me.lbl20.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl20.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl20.Location = New Global.System.Drawing.Point(8, 109)
			Me.lbl20.Name = "lbl20"
			Me.lbl20.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl20.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl20.TabIndex = 1057
			Me.lbl20.Text = "20"
			Me.lbl20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl15.BackColor = Global.System.Drawing.Color.White
			Me.lbl15.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl15.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl15.Location = New Global.System.Drawing.Point(63, 109)
			Me.lbl15.Name = "lbl15"
			Me.lbl15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl15.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl15.TabIndex = 1056
			Me.lbl15.Text = "15"
			Me.lbl15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl10.BackColor = Global.System.Drawing.Color.White
			Me.lbl10.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl10.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl10.Location = New Global.System.Drawing.Point(118, 109)
			Me.lbl10.Name = "lbl10"
			Me.lbl10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl10.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl10.TabIndex = 1055
			Me.lbl10.Text = "10"
			Me.lbl10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl05.BackColor = Global.System.Drawing.Color.White
			Me.lbl05.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl05.ForeColor = Global.System.Drawing.Color.Black
			Me.lbl05.Location = New Global.System.Drawing.Point(175, 109)
			Me.lbl05.Name = "lbl05"
			Me.lbl05.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbl05.Size = New Global.System.Drawing.Size(49, 37)
			Me.lbl05.TabIndex = 1054
			Me.lbl05.Text = "5"
			Me.lbl05.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chkTransGift.AutoSize = True
			Me.chkTransGift.BackColor = Global.System.Drawing.Color.Red
			Me.chkTransGift.Checked = True
			Me.chkTransGift.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkTransGift.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkTransGift.ForeColor = Global.System.Drawing.Color.Black
			Me.chkTransGift.Location = New Global.System.Drawing.Point(235, 196)
			Me.chkTransGift.Name = "chkTransGift"
			Me.chkTransGift.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkTransGift.Size = New Global.System.Drawing.Size(50, 24)
			Me.chkTransGift.TabIndex = 1053
			Me.chkTransGift.Text = "Au"
			Me.chkTransGift.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkTransGift.UseVisualStyleBackColor = False
			Me.chkGetgift.AutoSize = True
			Me.chkGetgift.BackColor = Global.System.Drawing.Color.Red
			Me.chkGetgift.Checked = True
			Me.chkGetgift.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkGetgift.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkGetgift.ForeColor = Global.System.Drawing.Color.Black
			Me.chkGetgift.Location = New Global.System.Drawing.Point(235, 138)
			Me.chkGetgift.Name = "chkGetgift"
			Me.chkGetgift.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkGetgift.Size = New Global.System.Drawing.Size(50, 23)
			Me.chkGetgift.TabIndex = 1052
			Me.chkGetgift.Text = "Au"
			Me.chkGetgift.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkGetgift.UseVisualStyleBackColor = False
			Me.btnExchangeNN.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnExchangeNN.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.btnExchangeNN.Location = New Global.System.Drawing.Point(505, 95)
			Me.btnExchangeNN.Name = "btnExchangeNN"
			Me.btnExchangeNN.Size = New Global.System.Drawing.Size(42, 23)
			Me.btnExchangeNN.TabIndex = 1049
			Me.btnExchangeNN.Text = "||"
			Me.btnExchangeNN.UseVisualStyleBackColor = False
			Me.chbeep.AutoSize = True
			Me.chbeep.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chbeep.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chbeep.Location = New Global.System.Drawing.Point(599, 11)
			Me.chbeep.Name = "chbeep"
			Me.chbeep.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chbeep.Size = New Global.System.Drawing.Size(49, 17)
			Me.chbeep.TabIndex = 1019
			Me.chbeep.Text = "تنبيه"
			Me.chbeep.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chbeep.UseVisualStyleBackColor = True
			Me.chkInDB.AutoSize = True
			Me.chkInDB.Checked = True
			Me.chkInDB.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkInDB.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkInDB.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkInDB.Location = New Global.System.Drawing.Point(460, 99)
			Me.chkInDB.Name = "chkInDB"
			Me.chkInDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkInDB.Size = New Global.System.Drawing.Size(39, 17)
			Me.chkInDB.TabIndex = 1018
			Me.chkInDB.Text = "ck"
			Me.chkInDB.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkInDB.UseVisualStyleBackColor = True
			Me.btnAutoVC_Hez.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVC_Hez.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVC_Hez.Location = New Global.System.Drawing.Point(6, 10)
			Me.btnAutoVC_Hez.Name = "btnAutoVC_Hez"
			Me.btnAutoVC_Hez.Size = New Global.System.Drawing.Size(104, 38)
			Me.btnAutoVC_Hez.TabIndex = 1014
			Me.btnAutoVC_Hez.Text = "متردد"
			Me.btnAutoVC_Hez.UseVisualStyleBackColor = False
			Me.chkRefref.AutoSize = True
			Me.chkRefref.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkRefref.Location = New Global.System.Drawing.Point(0, 281)
			Me.chkRefref.Name = "chkRefref"
			Me.chkRefref.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkRefref.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkRefref.TabIndex = 1013
			Me.chkRefref.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkRefref.UseVisualStyleBackColor = True
			Me.cknull.AutoSize = True
			Me.cknull.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.cknull.Location = New Global.System.Drawing.Point(1, 281)
			Me.cknull.Name = "cknull"
			Me.cknull.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.cknull.Size = New Global.System.Drawing.Size(15, 14)
			Me.cknull.TabIndex = 1010
			Me.cknull.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cknull.UseVisualStyleBackColor = True
			Me.cknull.Visible = False
			Me.btnAutoVC_Seres.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVC_Seres.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVC_Seres.Location = New Global.System.Drawing.Point(235, 12)
			Me.btnAutoVC_Seres.Name = "btnAutoVC_Seres"
			Me.btnAutoVC_Seres.Size = New Global.System.Drawing.Size(187, 55)
			Me.btnAutoVC_Seres.TabIndex = 1008
			Me.btnAutoVC_Seres.Text = "متتالى"
			Me.btnAutoVC_Seres.UseVisualStyleBackColor = False
			Me.txtVCForceMony.BackColor = Global.System.Drawing.Color.White
			Me.txtVCForceMony.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtVCForceMony.ForeColor = Global.System.Drawing.Color.Black
			Me.txtVCForceMony.Location = New Global.System.Drawing.Point(6, 61)
			Me.txtVCForceMony.Name = "txtVCForceMony"
			Me.txtVCForceMony.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtVCForceMony.Size = New Global.System.Drawing.Size(63, 36)
			Me.txtVCForceMony.TabIndex = 1007
			Me.txtVCForceMony.Text = "0"
			Me.txtVCForceMony.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransToNextMain.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransToNextMain.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransToNextMain.Location = New Global.System.Drawing.Point(459, 161)
			Me.btnTransToNextMain.Name = "btnTransToNextMain"
			Me.btnTransToNextMain.Size = New Global.System.Drawing.Size(207, 39)
			Me.btnTransToNextMain.TabIndex = 1006
			Me.btnTransToNextMain.Text = "من الاساسى للاساسى التالى"
			Me.btnTransToNextMain.UseVisualStyleBackColor = False
			Me.btnTransGiftAutoSpVal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAutoSpVal.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAutoSpVal.Location = New Global.System.Drawing.Point(75, 51)
			Me.btnTransGiftAutoSpVal.Name = "btnTransGiftAutoSpVal"
			Me.btnTransGiftAutoSpVal.Size = New Global.System.Drawing.Size(154, 55)
			Me.btnTransGiftAutoSpVal.TabIndex = 1005
			Me.btnTransGiftAutoSpVal.Text = "TopUp"
			Me.btnTransGiftAutoSpVal.UseVisualStyleBackColor = False
			Me.Label37.AutoSize = True
			Me.Label37.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label37.ForeColor = Global.System.Drawing.Color.Black
			Me.Label37.Location = New Global.System.Drawing.Point(565, 100)
			Me.Label37.Name = "Label37"
			Me.Label37.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label37.Size = New Global.System.Drawing.Size(94, 13)
			Me.Label37.TabIndex = 1001
			Me.Label37.Text = "الاساسى التالى"
			Me.Label24.AutoSize = True
			Me.Label24.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label24.ForeColor = Global.System.Drawing.Color.Black
			Me.Label24.Location = New Global.System.Drawing.Point(548, 16)
			Me.Label24.Name = "Label24"
			Me.Label24.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label24.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label24.TabIndex = 1000
			Me.Label24.Text = "المبلغ"
			Me.btnAutoVCnorm.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVCnorm.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVCnorm.Location = New Global.System.Drawing.Point(111, 11)
			Me.btnAutoVCnorm.Name = "btnAutoVCnorm"
			Me.btnAutoVCnorm.Size = New Global.System.Drawing.Size(118, 38)
			Me.btnAutoVCnorm.TabIndex = 998
			Me.btnAutoVCnorm.Text = "جماعى"
			Me.btnAutoVCnorm.UseVisualStyleBackColor = False
			Me.Label14.AutoSize = True
			Me.Label14.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.Label14.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label14.ForeColor = Global.System.Drawing.Color.Black
			Me.Label14.Location = New Global.System.Drawing.Point(235, 230)
			Me.Label14.Name = "Label14"
			Me.Label14.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label14.Size = New Global.System.Drawing.Size(191, 17)
			Me.Label14.TabIndex = 997
			Me.Label14.Text = "الخط مستقبل الرصيد العادى"
			Me.txtTransNum2.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.txtTransNum2.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNum2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum2.Location = New Global.System.Drawing.Point(235, 250)
			Me.txtTransNum2.MaxLength = 11
			Me.txtTransNum2.Name = "txtTransNum2"
			Me.txtTransNum2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum2.Size = New Global.System.Drawing.Size(190, 36)
			Me.txtTransNum2.TabIndex = 996
			Me.txtTransNum2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransGiftAuto.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAuto.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAuto.Location = New Global.System.Drawing.Point(291, 176)
			Me.btnTransGiftAuto.Name = "btnTransGiftAuto"
			Me.btnTransGiftAuto.Size = New Global.System.Drawing.Size(133, 51)
			Me.btnTransGiftAuto.TabIndex = 995
			Me.btnTransGiftAuto.Text = "شحن الهدية"
			Me.btnTransGiftAuto.UseVisualStyleBackColor = False
			Me.txtCashNextMaster.BackColor = Global.System.Drawing.Color.White
			Me.txtCashNextMaster.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCashNextMaster.ForeColor = Global.System.Drawing.Color.Black
			Me.txtCashNextMaster.Location = New Global.System.Drawing.Point(459, 122)
			Me.txtCashNextMaster.MaxLength = 11
			Me.txtCashNextMaster.Name = "txtCashNextMaster"
			Me.txtCashNextMaster.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCashNextMaster.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtCashNextMaster.TabIndex = 994
			Me.txtCashNextMaster.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnRun02Nm.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRun02Nm.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnRun02Nm.Location = New Global.System.Drawing.Point(291, 117)
			Me.btnRun02Nm.Name = "btnRun02Nm"
			Me.btnRun02Nm.Size = New Global.System.Drawing.Size(133, 56)
			Me.btnRun02Nm.TabIndex = 984
			Me.btnRun02Nm.Text = "استقبالا الهدايا"
			Me.btnRun02Nm.UseVisualStyleBackColor = False
			Me.lblMain.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.lblMain.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblMain.ForeColor = Global.System.Drawing.Color.Black
			Me.lblMain.Location = New Global.System.Drawing.Point(459, 56)
			Me.lblMain.Name = "lblMain"
			Me.lblMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblMain.Size = New Global.System.Drawing.Size(202, 38)
			Me.lblMain.TabIndex = 981
			Me.lblMain.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label21.AutoSize = True
			Me.Label21.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label21.ForeColor = Global.System.Drawing.Color.Black
			Me.Label21.Location = New Global.System.Drawing.Point(590, 33)
			Me.Label21.Name = "Label21"
			Me.Label21.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label21.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label21.TabIndex = 975
			Me.Label21.Text = "الاساسى"
			Me.txtMonyMn.BackColor = Global.System.Drawing.Color.White
			Me.txtMonyMn.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMonyMn.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMonyMn.Location = New Global.System.Drawing.Point(459, 15)
			Me.txtMonyMn.Name = "txtMonyMn"
			Me.txtMonyMn.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMonyMn.Size = New Global.System.Drawing.Size(84, 36)
			Me.txtMonyMn.TabIndex = 974
			Me.txtMonyMn.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetBal2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBal2.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnGetBal2.Location = New Global.System.Drawing.Point(434, 236)
			Me.btnGetBal2.Name = "btnGetBal2"
			Me.btnGetBal2.Size = New Global.System.Drawing.Size(232, 53)
			Me.btnGetBal2.TabIndex = 902
			Me.btnGetBal2.Text = "استعلام عن رصيدالكاش"
			Me.btnGetBal2.UseVisualStyleBackColor = False
			Me.btnTransAllMn.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransAllMn.Font = New Global.System.Drawing.Font("Tahoma", 7.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransAllMn.Location = New Global.System.Drawing.Point(722, 13)
			Me.btnTransAllMn.Name = "btnTransAllMn"
			Me.btnTransAllMn.Size = New Global.System.Drawing.Size(204, 50)
			Me.btnTransAllMn.TabIndex = 979
			Me.btnTransAllMn.Text = "تحويل كامل مبلغ الكاش"
			Me.btnTransAllMn.UseVisualStyleBackColor = False
			Me.btnTransGiftAutoNorm.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAutoNorm.Font = New Global.System.Drawing.Font("Tahoma", 7.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAutoNorm.Location = New Global.System.Drawing.Point(723, 65)
			Me.btnTransGiftAutoNorm.Name = "btnTransGiftAutoNorm"
			Me.btnTransGiftAutoNorm.Size = New Global.System.Drawing.Size(203, 51)
			Me.btnTransGiftAutoNorm.TabIndex = 1012
			Me.btnTransGiftAutoNorm.Text = "تحويل كامل الرصيد العادى"
			Me.btnTransGiftAutoNorm.UseVisualStyleBackColor = False
			Me.tabvc2.BackColor = Global.System.Drawing.Color.Red
			Me.tabvc2.Controls.Add(Me.ckbtnCashKing)
			Me.tabvc2.Controls.Add(Me.btnCashKing)
			Me.tabvc2.Controls.Add(Me.btn365_9093)
			Me.tabvc2.Controls.Add(Me.ck365_902)
			Me.tabvc2.Controls.Add(Me.ck365_T2)
			Me.tabvc2.Controls.Add(Me.ck365_toup)
			Me.tabvc2.Controls.Add(Me.ck365_90)
			Me.tabvc2.Controls.Add(Me.ck365_T)
			Me.tabvc2.Controls.Add(Me.ck365_901)
			Me.tabvc2.Controls.Add(Me.btn365_90)
			Me.tabvc2.Controls.Add(Me.btn365_901)
			Me.tabvc2.Controls.Add(Me.ckbtnVodaAuto3652)
			Me.tabvc2.Controls.Add(Me.btnVodaAuto3652)
			Me.tabvc2.Controls.Add(Me.ckbtnVodaCashFreeTransfer)
			Me.tabvc2.Controls.Add(Me.btnVodaCashFreeTransfer)
			Me.tabvc2.Controls.Add(Me.ckbtnVodaAuto365)
			Me.tabvc2.Controls.Add(Me.btnVodaAuto365)
			Me.tabvc2.Controls.Add(Me.btnVCtransFrom3Up)
			Me.tabvc2.Controls.Add(Me.btnVCtransFrom3Dn)
			Me.tabvc2.Controls.Add(Me.ckTrans)
			Me.tabvc2.Controls.Add(Me.chkimpsms)
			Me.tabvc2.Controls.Add(Me.txtCHS)
			Me.tabvc2.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabvc2.Name = "tabvc2"
			Me.tabvc2.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabvc2.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabvc2.TabIndex = 25
			Me.tabvc2.Text = "VfC Series2"
			Me.ckbtnCashKing.AutoSize = True
			Me.ckbtnCashKing.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnCashKing.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnCashKing.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnCashKing.Location = New Global.System.Drawing.Point(211, 154)
			Me.ckbtnCashKing.Name = "ckbtnCashKing"
			Me.ckbtnCashKing.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnCashKing.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnCashKing.TabIndex = 1111
			Me.ckbtnCashKing.Text = "Auto"
			Me.ckbtnCashKing.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnCashKing.UseVisualStyleBackColor = False
			Me.btnCashKing.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnCashKing.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnCashKing.ForeColor = Global.System.Drawing.Color.Black
			Me.btnCashKing.Location = New Global.System.Drawing.Point(20, 152)
			Me.btnCashKing.Name = "btnCashKing"
			Me.btnCashKing.Size = New Global.System.Drawing.Size(244, 53)
			Me.btnCashKing.TabIndex = 1110
			Me.btnCashKing.Text = "ملوك الكاش"
			Me.btnCashKing.UseVisualStyleBackColor = False
			Me.btn365_9093.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btn365_9093.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btn365_9093.ForeColor = Global.System.Drawing.Color.Black
			Me.btn365_9093.Location = New Global.System.Drawing.Point(306, 187)
			Me.btn365_9093.Name = "btn365_9093"
			Me.btn365_9093.Size = New Global.System.Drawing.Size(244, 45)
			Me.btn365_9093.TabIndex = 1109
			Me.btn365_9093.Text = "*365*90-93#"
			Me.btn365_9093.UseVisualStyleBackColor = False
			Me.ck365_902.AutoSize = True
			Me.ck365_902.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_902.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_902.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_902.Location = New Global.System.Drawing.Point(680, 239)
			Me.ck365_902.Name = "ck365_902"
			Me.ck365_902.Size = New Global.System.Drawing.Size(103, 17)
			Me.ck365_902.TabIndex = 1108
			Me.ck365_902.Text = "*365*90-93#"
			Me.ck365_902.UseVisualStyleBackColor = False
			Me.ck365_T2.AutoSize = True
			Me.ck365_T2.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_T2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_T2.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_T2.Location = New Global.System.Drawing.Point(680, 217)
			Me.ck365_T2.Name = "ck365_T2"
			Me.ck365_T2.Size = New Global.System.Drawing.Size(74, 17)
			Me.ck365_T2.TabIndex = 1107
			Me.ck365_T2.Text = "Transfer"
			Me.ck365_T2.UseVisualStyleBackColor = False
			Me.ck365_toup.AutoSize = True
			Me.ck365_toup.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_toup.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_toup.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_toup.Location = New Global.System.Drawing.Point(680, 262)
			Me.ck365_toup.Name = "ck365_toup"
			Me.ck365_toup.Size = New Global.System.Drawing.Size(76, 17)
			Me.ck365_toup.TabIndex = 1106
			Me.ck365_toup.Text = "TopUpAll"
			Me.ck365_toup.UseVisualStyleBackColor = False
			Me.ck365_90.AutoSize = True
			Me.ck365_90.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_90.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_90.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_90.Location = New Global.System.Drawing.Point(680, 197)
			Me.ck365_90.Name = "ck365_90"
			Me.ck365_90.Size = New Global.System.Drawing.Size(84, 17)
			Me.ck365_90.TabIndex = 1105
			Me.ck365_90.Text = "*365*90#"
			Me.ck365_90.UseVisualStyleBackColor = False
			Me.ck365_T.AutoSize = True
			Me.ck365_T.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_T.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_T.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_T.Location = New Global.System.Drawing.Point(680, 174)
			Me.ck365_T.Name = "ck365_T"
			Me.ck365_T.Size = New Global.System.Drawing.Size(74, 17)
			Me.ck365_T.TabIndex = 1104
			Me.ck365_T.Text = "Transfer"
			Me.ck365_T.UseVisualStyleBackColor = False
			Me.ck365_901.AutoSize = True
			Me.ck365_901.BackColor = Global.System.Drawing.Color.Silver
			Me.ck365_901.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck365_901.ForeColor = Global.System.Drawing.Color.Black
			Me.ck365_901.Location = New Global.System.Drawing.Point(680, 149)
			Me.ck365_901.Name = "ck365_901"
			Me.ck365_901.Size = New Global.System.Drawing.Size(98, 17)
			Me.ck365_901.TabIndex = 1103
			Me.ck365_901.Text = "*365*90*1#"
			Me.ck365_901.UseVisualStyleBackColor = False
			Me.btn365_90.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btn365_90.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btn365_90.ForeColor = Global.System.Drawing.Color.Black
			Me.btn365_90.Location = New Global.System.Drawing.Point(306, 136)
			Me.btn365_90.Name = "btn365_90"
			Me.btn365_90.Size = New Global.System.Drawing.Size(244, 45)
			Me.btn365_90.TabIndex = 1102
			Me.btn365_90.Text = "*365*90#"
			Me.btn365_90.UseVisualStyleBackColor = False
			Me.btn365_901.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btn365_901.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btn365_901.ForeColor = Global.System.Drawing.Color.Black
			Me.btn365_901.Location = New Global.System.Drawing.Point(306, 85)
			Me.btn365_901.Name = "btn365_901"
			Me.btn365_901.Size = New Global.System.Drawing.Size(244, 45)
			Me.btn365_901.TabIndex = 1101
			Me.btn365_901.Text = "*365*90*1#"
			Me.btn365_901.UseVisualStyleBackColor = False
			Me.ckbtnVodaAuto3652.AutoSize = True
			Me.ckbtnVodaAuto3652.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnVodaAuto3652.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnVodaAuto3652.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnVodaAuto3652.Location = New Global.System.Drawing.Point(856, 88)
			Me.ckbtnVodaAuto3652.Name = "ckbtnVodaAuto3652"
			Me.ckbtnVodaAuto3652.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnVodaAuto3652.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnVodaAuto3652.TabIndex = 1100
			Me.ckbtnVodaAuto3652.Text = "Auto"
			Me.ckbtnVodaAuto3652.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnVodaAuto3652.UseVisualStyleBackColor = False
			Me.btnVodaAuto3652.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVodaAuto3652.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnVodaAuto3652.ForeColor = Global.System.Drawing.Color.Black
			Me.btnVodaAuto3652.Location = New Global.System.Drawing.Point(668, 85)
			Me.btnVodaAuto3652.Name = "btnVodaAuto3652"
			Me.btnVodaAuto3652.Size = New Global.System.Drawing.Size(244, 53)
			Me.btnVodaAuto3652.TabIndex = 1099
			Me.btnVodaAuto3652.Text = "تشغيل كامل 365"
			Me.btnVodaAuto3652.UseVisualStyleBackColor = False
			Me.ckbtnVodaCashFreeTransfer.AutoSize = True
			Me.ckbtnVodaCashFreeTransfer.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnVodaCashFreeTransfer.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnVodaCashFreeTransfer.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnVodaCashFreeTransfer.Location = New Global.System.Drawing.Point(497, 22)
			Me.ckbtnVodaCashFreeTransfer.Name = "ckbtnVodaCashFreeTransfer"
			Me.ckbtnVodaCashFreeTransfer.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnVodaCashFreeTransfer.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnVodaCashFreeTransfer.TabIndex = 1098
			Me.ckbtnVodaCashFreeTransfer.Text = "Auto"
			Me.ckbtnVodaCashFreeTransfer.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnVodaCashFreeTransfer.UseVisualStyleBackColor = False
			Me.btnVodaCashFreeTransfer.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVodaCashFreeTransfer.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnVodaCashFreeTransfer.ForeColor = Global.System.Drawing.Color.Black
			Me.btnVodaCashFreeTransfer.Location = New Global.System.Drawing.Point(306, 20)
			Me.btnVodaCashFreeTransfer.Name = "btnVodaCashFreeTransfer"
			Me.btnVodaCashFreeTransfer.Size = New Global.System.Drawing.Size(244, 53)
			Me.btnVodaCashFreeTransfer.TabIndex = 1097
			Me.btnVodaCashFreeTransfer.Text = "عرض الصيف للتحويل مجانى"
			Me.btnVodaCashFreeTransfer.UseVisualStyleBackColor = False
			Me.ckbtnVodaAuto365.AutoSize = True
			Me.ckbtnVodaAuto365.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnVodaAuto365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnVodaAuto365.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnVodaAuto365.Location = New Global.System.Drawing.Point(859, 17)
			Me.ckbtnVodaAuto365.Name = "ckbtnVodaAuto365"
			Me.ckbtnVodaAuto365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnVodaAuto365.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnVodaAuto365.TabIndex = 1095
			Me.ckbtnVodaAuto365.Text = "Auto"
			Me.ckbtnVodaAuto365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnVodaAuto365.UseVisualStyleBackColor = False
			Me.btnVodaAuto365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVodaAuto365.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnVodaAuto365.ForeColor = Global.System.Drawing.Color.Black
			Me.btnVodaAuto365.Location = New Global.System.Drawing.Point(671, 14)
			Me.btnVodaAuto365.Name = "btnVodaAuto365"
			Me.btnVodaAuto365.Size = New Global.System.Drawing.Size(244, 53)
			Me.btnVodaAuto365.TabIndex = 1094
			Me.btnVodaAuto365.Text = "تشغيل تلقائى كامل متعدد"
			Me.btnVodaAuto365.UseVisualStyleBackColor = False
			Me.btnVCtransFrom3Up.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVCtransFrom3Up.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnVCtransFrom3Up.Location = New Global.System.Drawing.Point(10, 15)
			Me.btnVCtransFrom3Up.Name = "btnVCtransFrom3Up"
			Me.btnVCtransFrom3Up.Size = New Global.System.Drawing.Size(223, 31)
			Me.btnVCtransFrom3Up.TabIndex = 987
			Me.btnVCtransFrom3Up.Text = "تحويل من الثلاثة العلوية الى السفلية"
			Me.btnVCtransFrom3Up.UseVisualStyleBackColor = False
			Me.btnVCtransFrom3Dn.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVCtransFrom3Dn.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnVCtransFrom3Dn.Location = New Global.System.Drawing.Point(10, 46)
			Me.btnVCtransFrom3Dn.Name = "btnVCtransFrom3Dn"
			Me.btnVCtransFrom3Dn.Size = New Global.System.Drawing.Size(223, 27)
			Me.btnVCtransFrom3Dn.TabIndex = 988
			Me.btnVCtransFrom3Dn.Text = "تحويل من الثلاثة السفلية الى العلوية"
			Me.btnVCtransFrom3Dn.UseVisualStyleBackColor = False
			Me.ckTrans.AutoSize = True
			Me.ckTrans.BackColor = Global.System.Drawing.Color.Red
			Me.ckTrans.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckTrans.Location = New Global.System.Drawing.Point(82, 94)
			Me.ckTrans.Name = "ckTrans"
			Me.ckTrans.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckTrans.Size = New Global.System.Drawing.Size(141, 17)
			Me.ckTrans.TabIndex = 1002
			Me.ckTrans.Text = "تحويل واستبال اجبارى"
			Me.ckTrans.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckTrans.UseVisualStyleBackColor = False
			Me.chkimpsms.AutoSize = True
			Me.chkimpsms.BackColor = Global.System.Drawing.Color.Red
			Me.chkimpsms.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkimpsms.Location = New Global.System.Drawing.Point(73, 117)
			Me.chkimpsms.Name = "chkimpsms"
			Me.chkimpsms.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkimpsms.Size = New Global.System.Drawing.Size(150, 17)
			Me.chkimpsms.TabIndex = 1004
			Me.chkimpsms.Text = "دمج الرسائل فى التنفيذ"
			Me.chkimpsms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkimpsms.UseVisualStyleBackColor = False
			Me.txtCHS.BackColor = Global.System.Drawing.Color.White
			Me.txtCHS.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCHS.ForeColor = Global.System.Drawing.Color.Black
			Me.txtCHS.Location = New Global.System.Drawing.Point(20, 110)
			Me.txtCHS.MaxLength = 1
			Me.txtCHS.Name = "txtCHS"
			Me.txtCHS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCHS.Size = New Global.System.Drawing.Size(35, 24)
			Me.txtCHS.TabIndex = 1003
			Me.txtCHS.Text = "1"
			Me.txtCHS.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.tab365_2.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.tab365_2.Controls.Add(Me.btnDelTarfehy)
			Me.tab365_2.Controls.Add(Me.chkNewWallet)
			Me.tab365_2.Controls.Add(Me.btnGetVodaBal365)
			Me.tab365_2.Controls.Add(Me.txtLoopSSD365_2)
			Me.tab365_2.Controls.Add(Me.txtLoopFSD365_2)
			Me.tab365_2.Controls.Add(Me.chkApply365Trans)
			Me.tab365_2.Controls.Add(Me.txtTransNum2365_n)
			Me.tab365_2.Controls.Add(Me.Label63)
			Me.tab365_2.Controls.Add(Me.btnTransGiftAutoNorm365)
			Me.tab365_2.Controls.Add(Me.txtVCForceMony365_n)
			Me.tab365_2.Controls.Add(Me.chkTransferAllNormalVoda365)
			Me.tab365_2.Controls.Add(Me.chkApply365Bakat)
			Me.tab365_2.Controls.Add(Me.btnApply365Bakat)
			Me.tab365_2.Controls.Add(Me.btnChkNewSims)
			Me.tab365_2.ForeColor = Global.System.Drawing.Color.Black
			Me.tab365_2.Location = New Global.System.Drawing.Point(4, 22)
			Me.tab365_2.Name = "tab365_2"
			Me.tab365_2.Size = New Global.System.Drawing.Size(934, 295)
			Me.tab365_2.TabIndex = 17
			Me.tab365_2.Text = "365_2"
			Me.btnDelTarfehy.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnDelTarfehy.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnDelTarfehy.Location = New Global.System.Drawing.Point(648, 137)
			Me.btnDelTarfehy.Name = "btnDelTarfehy"
			Me.btnDelTarfehy.Size = New Global.System.Drawing.Size(188, 41)
			Me.btnDelTarfehy.TabIndex = 1047
			Me.btnDelTarfehy.Text = "الغاء الخدمات الترفيهية"
			Me.btnDelTarfehy.UseVisualStyleBackColor = False
			Me.chkNewWallet.AutoSize = True
			Me.chkNewWallet.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkNewWallet.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkNewWallet.Location = New Global.System.Drawing.Point(229, 224)
			Me.chkNewWallet.Name = "chkNewWallet"
			Me.chkNewWallet.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkNewWallet.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkNewWallet.TabIndex = 1046
			Me.chkNewWallet.Text = "Auto"
			Me.chkNewWallet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkNewWallet.UseVisualStyleBackColor = False
			Me.btnGetVodaBal365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetVodaBal365.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetVodaBal365.Location = New Global.System.Drawing.Point(592, 201)
			Me.btnGetVodaBal365.Name = "btnGetVodaBal365"
			Me.btnGetVodaBal365.Size = New Global.System.Drawing.Size(249, 40)
			Me.btnGetVodaBal365.TabIndex = 1045
			Me.btnGetVodaBal365.Text = "استعلام عن الرصيد العادى للخط"
			Me.btnGetVodaBal365.UseVisualStyleBackColor = False
			Me.txtLoopSSD365_2.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSD365_2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSD365_2.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSD365_2.Location = New Global.System.Drawing.Point(213, 79)
			Me.txtLoopSSD365_2.Name = "txtLoopSSD365_2"
			Me.txtLoopSSD365_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSD365_2.Size = New Global.System.Drawing.Size(55, 24)
			Me.txtLoopSSD365_2.TabIndex = 1044
			Me.txtLoopSSD365_2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSD365_2.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSD365_2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSD365_2.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSD365_2.Location = New Global.System.Drawing.Point(214, 51)
			Me.txtLoopFSD365_2.Name = "txtLoopFSD365_2"
			Me.txtLoopFSD365_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSD365_2.Size = New Global.System.Drawing.Size(54, 24)
			Me.txtLoopFSD365_2.TabIndex = 1043
			Me.txtLoopFSD365_2.Text = "1"
			Me.txtLoopFSD365_2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.chkApply365Trans.AutoSize = True
			Me.chkApply365Trans.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkApply365Trans.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkApply365Trans.ForeColor = Global.System.Drawing.Color.Black
			Me.chkApply365Trans.Location = New Global.System.Drawing.Point(142, 40)
			Me.chkApply365Trans.Name = "chkApply365Trans"
			Me.chkApply365Trans.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkApply365Trans.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkApply365Trans.TabIndex = 1042
			Me.chkApply365Trans.Text = "Auto"
			Me.chkApply365Trans.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkApply365Trans.UseVisualStyleBackColor = False
			Me.txtTransNum2365_n.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNum2365_n.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNum2365_n.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum2365_n.Location = New Global.System.Drawing.Point(13, 163)
			Me.txtTransNum2365_n.MaxLength = 11
			Me.txtTransNum2365_n.Name = "txtTransNum2365_n"
			Me.txtTransNum2365_n.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum2365_n.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtTransNum2365_n.TabIndex = 1041
			Me.txtTransNum2365_n.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label63.AutoSize = True
			Me.Label63.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label63.ForeColor = Global.System.Drawing.Color.Black
			Me.Label63.Location = New Global.System.Drawing.Point(139, 115)
			Me.Label63.Name = "Label63"
			Me.Label63.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label63.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label63.TabIndex = 1040
			Me.Label63.Text = "المبلغ"
			Me.btnTransGiftAutoNorm365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAutoNorm365.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAutoNorm365.Location = New Global.System.Drawing.Point(14, 37)
			Me.btnTransGiftAutoNorm365.Name = "btnTransGiftAutoNorm365"
			Me.btnTransGiftAutoNorm365.Size = New Global.System.Drawing.Size(186, 66)
			Me.btnTransGiftAutoNorm365.TabIndex = 1039
			Me.btnTransGiftAutoNorm365.Text = "تحويل رصيد عادى"
			Me.btnTransGiftAutoNorm365.UseVisualStyleBackColor = False
			Me.txtVCForceMony365_n.BackColor = Global.System.Drawing.Color.White
			Me.txtVCForceMony365_n.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtVCForceMony365_n.ForeColor = Global.System.Drawing.Color.Black
			Me.txtVCForceMony365_n.Location = New Global.System.Drawing.Point(66, 109)
			Me.txtVCForceMony365_n.Name = "txtVCForceMony365_n"
			Me.txtVCForceMony365_n.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtVCForceMony365_n.Size = New Global.System.Drawing.Size(67, 27)
			Me.txtVCForceMony365_n.TabIndex = 1038
			Me.txtVCForceMony365_n.Text = "0"
			Me.txtVCForceMony365_n.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.chkTransferAllNormalVoda365.AutoSize = True
			Me.chkTransferAllNormalVoda365.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkTransferAllNormalVoda365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkTransferAllNormalVoda365.Location = New Global.System.Drawing.Point(38, 138)
			Me.chkTransferAllNormalVoda365.Name = "chkTransferAllNormalVoda365"
			Me.chkTransferAllNormalVoda365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkTransferAllNormalVoda365.Size = New Global.System.Drawing.Size(161, 17)
			Me.chkTransferAllNormalVoda365.TabIndex = 1037
			Me.chkTransferAllNormalVoda365.Text = "تحويل كامل الرصيد العادى"
			Me.chkTransferAllNormalVoda365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkTransferAllNormalVoda365.UseVisualStyleBackColor = False
			Me.chkApply365Bakat.AutoSize = True
			Me.chkApply365Bakat.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkApply365Bakat.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkApply365Bakat.ForeColor = Global.System.Drawing.Color.Black
			Me.chkApply365Bakat.Location = New Global.System.Drawing.Point(783, 36)
			Me.chkApply365Bakat.Name = "chkApply365Bakat"
			Me.chkApply365Bakat.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkApply365Bakat.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkApply365Bakat.TabIndex = 1036
			Me.chkApply365Bakat.Text = "Auto"
			Me.chkApply365Bakat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkApply365Bakat.UseVisualStyleBackColor = False
			Me.btnApply365Bakat.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnApply365Bakat.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnApply365Bakat.Location = New Global.System.Drawing.Point(653, 33)
			Me.btnApply365Bakat.Name = "btnApply365Bakat"
			Me.btnApply365Bakat.Size = New Global.System.Drawing.Size(188, 64)
			Me.btnApply365Bakat.TabIndex = 1035
			Me.btnApply365Bakat.Text = "الباقات"
			Me.btnApply365Bakat.UseVisualStyleBackColor = False
			Me.btnChkNewSims.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnChkNewSims.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnChkNewSims.Location = New Global.System.Drawing.Point(13, 222)
			Me.btnChkNewSims.Name = "btnChkNewSims"
			Me.btnChkNewSims.Size = New Global.System.Drawing.Size(269, 57)
			Me.btnChkNewSims.TabIndex = 1048
			Me.btnChkNewSims.Text = "استعلام تلقائى عن المحافظ الجديدة"
			Me.btnChkNewSims.UseVisualStyleBackColor = False
			Me.TabPage4.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage4.Controls.Add(Me.ckbtnChangePassNew)
			Me.TabPage4.Controls.Add(Me.ckbtnChangePass)
			Me.TabPage4.Controls.Add(Me.btnChangePassNew)
			Me.TabPage4.Controls.Add(Me.BDatedel)
			Me.TabPage4.Controls.Add(Me.btnDlGifts)
			Me.TabPage4.Controls.Add(Me.Label51)
			Me.TabPage4.Controls.Add(Me.btnChangePass)
			Me.TabPage4.Controls.Add(Me.Label50)
			Me.TabPage4.Controls.Add(Me.txtOldPass)
			Me.TabPage4.Controls.Add(Me.Label49)
			Me.TabPage4.Controls.Add(Me.txtNewPass)
			Me.TabPage4.Controls.Add(Me.chkPay)
			Me.TabPage4.Controls.Add(Me.btnGetBalNM)
			Me.TabPage4.Controls.Add(Me.btnCopyAll)
			Me.TabPage4.Controls.Add(Me.txtSpNum6)
			Me.TabPage4.Controls.Add(Me.txtSpNum5)
			Me.TabPage4.Controls.Add(Me.txtSpNum4)
			Me.TabPage4.Controls.Add(Me.txtSpNum3)
			Me.TabPage4.Controls.Add(Me.txtSpNum2)
			Me.TabPage4.Controls.Add(Me.Label11)
			Me.TabPage4.Controls.Add(Me.txtSpNum1)
			Me.TabPage4.Controls.Add(Me.Label2)
			Me.TabPage4.Controls.Add(Me.txtwait)
			Me.TabPage4.Controls.Add(Me.Label1)
			Me.TabPage4.Controls.Add(Me.txtPass)
			Me.TabPage4.Controls.Add(Me.btnAddItems)
			Me.TabPage4.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage4.Name = "TabPage4"
			Me.TabPage4.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage4.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage4.TabIndex = 3
			Me.TabPage4.Text = "VFsetting"
			Me.ckbtnChangePassNew.AutoSize = True
			Me.ckbtnChangePassNew.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnChangePassNew.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnChangePassNew.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnChangePassNew.Location = New Global.System.Drawing.Point(857, 232)
			Me.ckbtnChangePassNew.Name = "ckbtnChangePassNew"
			Me.ckbtnChangePassNew.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnChangePassNew.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnChangePassNew.TabIndex = 1044
			Me.ckbtnChangePassNew.Text = "Auto"
			Me.ckbtnChangePassNew.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnChangePassNew.UseVisualStyleBackColor = False
			Me.ckbtnChangePass.AutoSize = True
			Me.ckbtnChangePass.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnChangePass.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnChangePass.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnChangePass.Location = New Global.System.Drawing.Point(559, 119)
			Me.ckbtnChangePass.Name = "ckbtnChangePass"
			Me.ckbtnChangePass.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnChangePass.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnChangePass.TabIndex = 1043
			Me.ckbtnChangePass.Text = "Auto"
			Me.ckbtnChangePass.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnChangePass.UseVisualStyleBackColor = False
			Me.btnChangePassNew.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnChangePassNew.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnChangePassNew.Location = New Global.System.Drawing.Point(693, 232)
			Me.btnChangePassNew.Name = "btnChangePassNew"
			Me.btnChangePassNew.Size = New Global.System.Drawing.Size(217, 51)
			Me.btnChangePassNew.TabIndex = 987
			Me.btnChangePassNew.Text = "تسجيل اول مرة لكل الخطوط"
			Me.btnChangePassNew.UseVisualStyleBackColor = False
			Me.BDatedel.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.BDatedel.Location = New Global.System.Drawing.Point(52, 263)
			Me.BDatedel.Name = "BDatedel"
			Me.BDatedel.Size = New Global.System.Drawing.Size(88, 20)
			Me.BDatedel.TabIndex = 986
			Me.btnDlGifts.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnDlGifts.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDlGifts.Location = New Global.System.Drawing.Point(13, 229)
			Me.btnDlGifts.Name = "btnDlGifts"
			Me.btnDlGifts.Size = New Global.System.Drawing.Size(170, 32)
			Me.btnDlGifts.TabIndex = 985
			Me.btnDlGifts.Text = "حذف الهدايا قبل تاريخ"
			Me.btnDlGifts.UseVisualStyleBackColor = False
			Me.Label51.AutoSize = True
			Me.Label51.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label51.ForeColor = Global.System.Drawing.Color.Black
			Me.Label51.Location = New Global.System.Drawing.Point(394, 22)
			Me.Label51.Name = "Label51"
			Me.Label51.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label51.Size = New Global.System.Drawing.Size(199, 17)
			Me.Label51.TabIndex = 984
			Me.Label51.Text = "تعديل كلمة السر لكل الخطوط"
			Me.btnChangePass.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnChangePass.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnChangePass.Location = New Global.System.Drawing.Point(361, 110)
			Me.btnChangePass.Name = "btnChangePass"
			Me.btnChangePass.Size = New Global.System.Drawing.Size(192, 32)
			Me.btnChangePass.TabIndex = 983
			Me.btnChangePass.Text = "تعديل كلمة السر"
			Me.btnChangePass.UseVisualStyleBackColor = False
			Me.Label50.AutoSize = True
			Me.Label50.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label50.ForeColor = Global.System.Drawing.Color.Black
			Me.Label50.Location = New Global.System.Drawing.Point(476, 53)
			Me.Label50.Name = "Label50"
			Me.Label50.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label50.Size = New Global.System.Drawing.Size(127, 17)
			Me.Label50.TabIndex = 982
			Me.Label50.Text = "كلمة السر القديمة"
			Me.txtOldPass.BackColor = Global.System.Drawing.Color.White
			Me.txtOldPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOldPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOldPass.Location = New Global.System.Drawing.Point(361, 47)
			Me.txtOldPass.MaxLength = 6
			Me.txtOldPass.Name = "txtOldPass"
			Me.txtOldPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOldPass.Size = New Global.System.Drawing.Size(109, 27)
			Me.txtOldPass.TabIndex = 981
			Me.Label49.AutoSize = True
			Me.Label49.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label49.ForeColor = Global.System.Drawing.Color.Black
			Me.Label49.Location = New Global.System.Drawing.Point(476, 83)
			Me.Label49.Name = "Label49"
			Me.Label49.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label49.Size = New Global.System.Drawing.Size(128, 17)
			Me.Label49.TabIndex = 980
			Me.Label49.Text = "كلمة السر الجديدة"
			Me.txtNewPass.BackColor = Global.System.Drawing.Color.White
			Me.txtNewPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNewPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtNewPass.Location = New Global.System.Drawing.Point(361, 77)
			Me.txtNewPass.MaxLength = 6
			Me.txtNewPass.Name = "txtNewPass"
			Me.txtNewPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtNewPass.Size = New Global.System.Drawing.Size(109, 27)
			Me.txtNewPass.TabIndex = 979
			Me.chkPay.AutoSize = True
			Me.chkPay.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkPay.Location = New Global.System.Drawing.Point(662, 28)
			Me.chkPay.Name = "chkPay"
			Me.chkPay.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkPay.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkPay.TabIndex = 978
			Me.chkPay.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkPay.UseVisualStyleBackColor = True
			Me.btnGetBalNM.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBalNM.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetBalNM.Location = New Global.System.Drawing.Point(650, 12)
			Me.btnGetBalNM.Name = "btnGetBalNM"
			Me.btnGetBalNM.Size = New Global.System.Drawing.Size(278, 51)
			Me.btnGetBalNM.TabIndex = 977
			Me.btnGetBalNM.Text = "استعلام عن الرصيد العادى للخط"
			Me.btnGetBalNM.UseVisualStyleBackColor = False
			Me.btnCopyAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnCopyAll.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCopyAll.Location = New Global.System.Drawing.Point(162, 165)
			Me.btnCopyAll.Name = "btnCopyAll"
			Me.btnCopyAll.Size = New Global.System.Drawing.Size(87, 27)
			Me.btnCopyAll.TabIndex = 906
			Me.btnCopyAll.Text = "نسخ الكل"
			Me.btnCopyAll.UseVisualStyleBackColor = False
			Me.txtSpNum6.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum6.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum6.Location = New Global.System.Drawing.Point(6, 164)
			Me.txtSpNum6.MaxLength = 11
			Me.txtSpNum6.Name = "txtSpNum6"
			Me.txtSpNum6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum6.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum6.TabIndex = 905
			Me.txtSpNum5.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum5.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum5.Location = New Global.System.Drawing.Point(6, 137)
			Me.txtSpNum5.MaxLength = 11
			Me.txtSpNum5.Name = "txtSpNum5"
			Me.txtSpNum5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum5.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum5.TabIndex = 904
			Me.txtSpNum4.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum4.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum4.Location = New Global.System.Drawing.Point(6, 110)
			Me.txtSpNum4.MaxLength = 11
			Me.txtSpNum4.Name = "txtSpNum4"
			Me.txtSpNum4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum4.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum4.TabIndex = 903
			Me.txtSpNum3.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum3.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum3.Location = New Global.System.Drawing.Point(6, 83)
			Me.txtSpNum3.MaxLength = 11
			Me.txtSpNum3.Name = "txtSpNum3"
			Me.txtSpNum3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum3.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum3.TabIndex = 902
			Me.txtSpNum2.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum2.Location = New Global.System.Drawing.Point(6, 56)
			Me.txtSpNum2.MaxLength = 11
			Me.txtSpNum2.Name = "txtSpNum2"
			Me.txtSpNum2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum2.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum2.TabIndex = 901
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label11.ForeColor = Global.System.Drawing.Color.Black
			Me.Label11.Location = New Global.System.Drawing.Point(40, 8)
			Me.Label11.Name = "Label11"
			Me.Label11.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label11.Size = New Global.System.Drawing.Size(84, 17)
			Me.Label11.TabIndex = 900
			Me.Label11.Text = "ارقام سحب"
			Me.txtSpNum1.BackColor = Global.System.Drawing.Color.White
			Me.txtSpNum1.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpNum1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSpNum1.Location = New Global.System.Drawing.Point(6, 29)
			Me.txtSpNum1.MaxLength = 11
			Me.txtSpNum1.Name = "txtSpNum1"
			Me.txtSpNum1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSpNum1.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSpNum1.TabIndex = 899
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.Black
			Me.Label2.Location = New Global.System.Drawing.Point(159, 202)
			Me.Label2.Name = "Label2"
			Me.Label2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label2.Size = New Global.System.Drawing.Size(55, 17)
			Me.Label2.TabIndex = 884
			Me.Label2.Text = "الانتظار"
			Me.txtwait.BackColor = Global.System.Drawing.Color.White
			Me.txtwait.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtwait.ForeColor = Global.System.Drawing.Color.Black
			Me.txtwait.Location = New Global.System.Drawing.Point(47, 196)
			Me.txtwait.Name = "txtwait"
			Me.txtwait.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtwait.Size = New Global.System.Drawing.Size(109, 27)
			Me.txtwait.TabIndex = 883
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.Black
			Me.Label1.Location = New Global.System.Drawing.Point(544, 209)
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label1.Size = New Global.System.Drawing.Size(270, 17)
			Me.Label1.TabIndex = 882
			Me.Label1.Text = "كلمة السر لخطوط فودافون كاش العادية"
			Me.txtPass.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.txtPass.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtPass.Location = New Global.System.Drawing.Point(541, 238)
			Me.txtPass.MaxLength = 6
			Me.txtPass.Name = "txtPass"
			Me.txtPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPass.Size = New Global.System.Drawing.Size(146, 40)
			Me.txtPass.TabIndex = 881
			Me.txtPass.Text = "606060"
			Me.txtPass.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAddItems.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAddItems.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAddItems.ForeColor = Global.System.Drawing.Color.Black
			Me.btnAddItems.Location = New Global.System.Drawing.Point(162, 29)
			Me.btnAddItems.Name = "btnAddItems"
			Me.btnAddItems.Size = New Global.System.Drawing.Size(151, 65)
			Me.btnAddItems.TabIndex = 880
			Me.btnAddItems.Text = "اضافة خطوط لاستقبال الرصيد"
			Me.btnAddItems.UseVisualStyleBackColor = False
			Me.tabOcash.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOcash.Controls.Add(Me.txtOCtopupDelayCash)
			Me.tabOcash.Controls.Add(Me.txtOCTransferAll)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNumOne)
			Me.tabOcash.Controls.Add(Me.ckbtnOCTopupOne)
			Me.tabOcash.Controls.Add(Me.btnOCTopupOne)
			Me.tabOcash.Controls.Add(Me.txtOCtopupDelay)
			Me.tabOcash.Controls.Add(Me.ckOCBalWithBack)
			Me.tabOcash.Controls.Add(Me.Label105)
			Me.tabOcash.Controls.Add(Me.txtOCTransferSub)
			Me.tabOcash.Controls.Add(Me.CheckBox1)
			Me.tabOcash.Controls.Add(Me.btnOCTransferSame)
			Me.tabOcash.Controls.Add(Me.txtOCValueSame)
			Me.tabOcash.Controls.Add(Me.Label95)
			Me.tabOcash.Controls.Add(Me.lblOCvTotal)
			Me.tabOcash.Controls.Add(Me.lblOCvsub)
			Me.tabOcash.Controls.Add(Me.lblOCvPlus)
			Me.tabOcash.Controls.Add(Me.lblOCv100)
			Me.tabOcash.Controls.Add(Me.lblOCv90)
			Me.tabOcash.Controls.Add(Me.lblOCv85)
			Me.tabOcash.Controls.Add(Me.lblOCv75)
			Me.tabOcash.Controls.Add(Me.lblOCv65)
			Me.tabOcash.Controls.Add(Me.lblOCv50)
			Me.tabOcash.Controls.Add(Me.lblOCv45)
			Me.tabOcash.Controls.Add(Me.lblOCv35)
			Me.tabOcash.Controls.Add(Me.lblOCv25)
			Me.tabOcash.Controls.Add(Me.ckbtnOCTransferAll)
			Me.tabOcash.Controls.Add(Me.txtLoopSSDOC)
			Me.tabOcash.Controls.Add(Me.txtLoopFSDOC)
			Me.tabOcash.Controls.Add(Me.Label82)
			Me.tabOcash.Controls.Add(Me.lblOCv20)
			Me.tabOcash.Controls.Add(Me.btnOCTransferAll)
			Me.tabOcash.Controls.Add(Me.lblOCv15)
			Me.tabOcash.Controls.Add(Me.lblOCv10)
			Me.tabOcash.Controls.Add(Me.lblOCv5)
			Me.tabOcash.Controls.Add(Me.ckbtnOCTopup)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum6)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum5)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum4)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum3)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum2)
			Me.tabOcash.Controls.Add(Me.txtOCTopValue)
			Me.tabOcash.Controls.Add(Me.btnOCTopup)
			Me.tabOcash.Controls.Add(Me.ckbtnOCGetBal)
			Me.tabOcash.Controls.Add(Me.Label74)
			Me.tabOcash.Controls.Add(Me.txtOCchargeNum1)
			Me.tabOcash.Controls.Add(Me.btnOCGetBal)
			Me.tabOcash.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOcash.Name = "tabOcash"
			Me.tabOcash.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOcash.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOcash.TabIndex = 20
			Me.tabOcash.Text = "OC Topup Transfer"
			Me.txtOCtopupDelayCash.BackColor = Global.System.Drawing.Color.Blue
			Me.txtOCtopupDelayCash.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCtopupDelayCash.ForeColor = Global.System.Drawing.Color.White
			Me.txtOCtopupDelayCash.Location = New Global.System.Drawing.Point(843, 154)
			Me.txtOCtopupDelayCash.Name = "txtOCtopupDelayCash"
			Me.txtOCtopupDelayCash.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCtopupDelayCash.Size = New Global.System.Drawing.Size(64, 24)
			Me.txtOCtopupDelayCash.TabIndex = 1131
			Me.txtOCtopupDelayCash.Text = "1"
			Me.txtOCtopupDelayCash.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCTransferAll.BackColor = Global.System.Drawing.Color.White
			Me.txtOCTransferAll.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCTransferAll.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCTransferAll.Location = New Global.System.Drawing.Point(409, 253)
			Me.txtOCTransferAll.MaxLength = 11
			Me.txtOCTransferAll.Name = "txtOCTransferAll"
			Me.txtOCTransferAll.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCTransferAll.Size = New Global.System.Drawing.Size(222, 36)
			Me.txtOCTransferAll.TabIndex = 1129
			Me.txtOCTransferAll.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCchargeNumOne.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNumOne.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNumOne.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNumOne.Location = New Global.System.Drawing.Point(415, 88)
			Me.txtOCchargeNumOne.MaxLength = 11
			Me.txtOCchargeNumOne.Name = "txtOCchargeNumOne"
			Me.txtOCchargeNumOne.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNumOne.Size = New Global.System.Drawing.Size(222, 36)
			Me.txtOCchargeNumOne.TabIndex = 1128
			Me.txtOCchargeNumOne.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckbtnOCTopupOne.AutoSize = True
			Me.ckbtnOCTopupOne.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCTopupOne.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCTopupOne.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCTopupOne.Location = New Global.System.Drawing.Point(581, 16)
			Me.ckbtnOCTopupOne.Name = "ckbtnOCTopupOne"
			Me.ckbtnOCTopupOne.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCTopupOne.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCTopupOne.TabIndex = 1127
			Me.ckbtnOCTopupOne.Text = "Auto"
			Me.ckbtnOCTopupOne.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCTopupOne.UseVisualStyleBackColor = False
			Me.btnOCTopupOne.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCTopupOne.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCTopupOne.Location = New Global.System.Drawing.Point(499, 13)
			Me.btnOCTopupOne.Name = "btnOCTopupOne"
			Me.btnOCTopupOne.Size = New Global.System.Drawing.Size(138, 69)
			Me.btnOCTopupOne.TabIndex = 1126
			Me.btnOCTopupOne.Text = "TopUp to 1"
			Me.btnOCTopupOne.UseVisualStyleBackColor = False
			Me.txtOCtopupDelay.BackColor = Global.System.Drawing.Color.Blue
			Me.txtOCtopupDelay.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCtopupDelay.ForeColor = Global.System.Drawing.Color.White
			Me.txtOCtopupDelay.Location = New Global.System.Drawing.Point(429, 20)
			Me.txtOCtopupDelay.Name = "txtOCtopupDelay"
			Me.txtOCtopupDelay.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCtopupDelay.Size = New Global.System.Drawing.Size(64, 24)
			Me.txtOCtopupDelay.TabIndex = 1125
			Me.txtOCtopupDelay.Text = "1"
			Me.txtOCtopupDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckOCBalWithBack.AutoSize = True
			Me.ckOCBalWithBack.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ckOCBalWithBack.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.ckOCBalWithBack.Location = New Global.System.Drawing.Point(737, 118)
			Me.ckOCBalWithBack.Name = "ckOCBalWithBack"
			Me.ckOCBalWithBack.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckOCBalWithBack.Size = New Global.System.Drawing.Size(167, 21)
			Me.ckOCBalWithBack.TabIndex = 1124
			Me.ckOCBalWithBack.Text = "شحن الباك مع الرصيد"
			Me.ckOCBalWithBack.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckOCBalWithBack.UseVisualStyleBackColor = False
			Me.Label105.AutoSize = True
			Me.Label105.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label105.ForeColor = Global.System.Drawing.Color.Black
			Me.Label105.Location = New Global.System.Drawing.Point(707, 157)
			Me.Label105.Name = "Label105"
			Me.Label105.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label105.Size = New Global.System.Drawing.Size(119, 17)
			Me.Label105.TabIndex = 1123
			Me.Label105.Text = "باقى رصيد بالخط"
			Me.Label105.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtOCTransferSub.BackColor = Global.System.Drawing.Color.White
			Me.txtOCTransferSub.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCTransferSub.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCTransferSub.Location = New Global.System.Drawing.Point(643, 151)
			Me.txtOCTransferSub.Name = "txtOCTransferSub"
			Me.txtOCTransferSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCTransferSub.Size = New Global.System.Drawing.Size(58, 27)
			Me.txtOCTransferSub.TabIndex = 1122
			Me.txtOCTransferSub.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.CheckBox1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.CheckBox1.ForeColor = Global.System.Drawing.Color.Black
			Me.CheckBox1.Location = New Global.System.Drawing.Point(851, 53)
			Me.CheckBox1.Name = "CheckBox1"
			Me.CheckBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.CheckBox1.Size = New Global.System.Drawing.Size(53, 17)
			Me.CheckBox1.TabIndex = 1121
			Me.CheckBox1.Text = "Auto"
			Me.CheckBox1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.CheckBox1.UseVisualStyleBackColor = False
			Me.btnOCTransferSame.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCTransferSame.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCTransferSame.Location = New Global.System.Drawing.Point(643, 46)
			Me.btnOCTransferSame.Name = "btnOCTransferSame"
			Me.btnOCTransferSame.Size = New Global.System.Drawing.Size(267, 59)
			Me.btnOCTransferSame.TabIndex = 1120
			Me.btnOCTransferSame.Text = "تحويل مبلغ من الكل"
			Me.btnOCTransferSame.UseVisualStyleBackColor = False
			Me.txtOCValueSame.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueSame.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueSame.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueSame.Location = New Global.System.Drawing.Point(719, 8)
			Me.txtOCValueSame.Name = "txtOCValueSame"
			Me.txtOCValueSame.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueSame.Size = New Global.System.Drawing.Size(99, 36)
			Me.txtOCValueSame.TabIndex = 1118
			Me.txtOCValueSame.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label95.AutoSize = True
			Me.Label95.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label95.ForeColor = Global.System.Drawing.Color.Black
			Me.Label95.Location = New Global.System.Drawing.Point(825, 18)
			Me.Label95.Name = "Label95"
			Me.Label95.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label95.Size = New Global.System.Drawing.Size(88, 17)
			Me.Label95.TabIndex = 1119
			Me.Label95.Text = "مبلغ التحويل"
			Me.lblOCvTotal.BackColor = Global.System.Drawing.Color.White
			Me.lblOCvTotal.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCvTotal.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCvTotal.Location = New Global.System.Drawing.Point(224, 249)
			Me.lblOCvTotal.Name = "lblOCvTotal"
			Me.lblOCvTotal.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCvTotal.Size = New Global.System.Drawing.Size(179, 35)
			Me.lblOCvTotal.TabIndex = 1117
			Me.lblOCvTotal.Text = "Total Bal"
			Me.lblOCvTotal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCvsub.BackColor = Global.System.Drawing.Color.White
			Me.lblOCvsub.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCvsub.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCvsub.Location = New Global.System.Drawing.Point(293, 221)
			Me.lblOCvsub.Name = "lblOCvsub"
			Me.lblOCvsub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCvsub.Size = New Global.System.Drawing.Size(51, 24)
			Me.lblOCvsub.TabIndex = 1116
			Me.lblOCvsub.Text = "-5"
			Me.lblOCvsub.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCvPlus.BackColor = Global.System.Drawing.Color.White
			Me.lblOCvPlus.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCvPlus.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCvPlus.Location = New Global.System.Drawing.Point(351, 221)
			Me.lblOCvPlus.Name = "lblOCvPlus"
			Me.lblOCvPlus.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCvPlus.Size = New Global.System.Drawing.Size(51, 24)
			Me.lblOCvPlus.TabIndex = 1115
			Me.lblOCvPlus.Text = "+5"
			Me.lblOCvPlus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv100.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv100.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv100.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv100.Location = New Global.System.Drawing.Point(226, 221)
			Me.lblOCv100.Name = "lblOCv100"
			Me.lblOCv100.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv100.Size = New Global.System.Drawing.Size(61, 24)
			Me.lblOCv100.TabIndex = 1114
			Me.lblOCv100.Text = "100"
			Me.lblOCv100.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv90.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv90.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv90.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv90.Location = New Global.System.Drawing.Point(226, 190)
			Me.lblOCv90.Name = "lblOCv90"
			Me.lblOCv90.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv90.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv90.TabIndex = 1113
			Me.lblOCv90.Text = "90"
			Me.lblOCv90.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv85.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv85.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv85.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv85.Location = New Global.System.Drawing.Point(270, 190)
			Me.lblOCv85.Name = "lblOCv85"
			Me.lblOCv85.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv85.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv85.TabIndex = 1112
			Me.lblOCv85.Text = "85"
			Me.lblOCv85.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv75.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv75.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv75.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv75.Location = New Global.System.Drawing.Point(316, 190)
			Me.lblOCv75.Name = "lblOCv75"
			Me.lblOCv75.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv75.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv75.TabIndex = 1111
			Me.lblOCv75.Text = "75"
			Me.lblOCv75.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv65.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv65.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv65.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv65.Location = New Global.System.Drawing.Point(362, 190)
			Me.lblOCv65.Name = "lblOCv65"
			Me.lblOCv65.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv65.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv65.TabIndex = 1110
			Me.lblOCv65.Text = "65"
			Me.lblOCv65.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv50.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv50.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv50.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv50.Location = New Global.System.Drawing.Point(224, 159)
			Me.lblOCv50.Name = "lblOCv50"
			Me.lblOCv50.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv50.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv50.TabIndex = 1109
			Me.lblOCv50.Text = "50"
			Me.lblOCv50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv45.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv45.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv45.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv45.Location = New Global.System.Drawing.Point(270, 159)
			Me.lblOCv45.Name = "lblOCv45"
			Me.lblOCv45.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv45.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv45.TabIndex = 1108
			Me.lblOCv45.Text = "45"
			Me.lblOCv45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv35.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv35.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv35.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv35.Location = New Global.System.Drawing.Point(316, 159)
			Me.lblOCv35.Name = "lblOCv35"
			Me.lblOCv35.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv35.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv35.TabIndex = 1107
			Me.lblOCv35.Text = "35"
			Me.lblOCv35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv25.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv25.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv25.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv25.Location = New Global.System.Drawing.Point(362, 159)
			Me.lblOCv25.Name = "lblOCv25"
			Me.lblOCv25.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv25.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv25.TabIndex = 1106
			Me.lblOCv25.Text = "25"
			Me.lblOCv25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.ckbtnOCTransferAll.AutoSize = True
			Me.ckbtnOCTransferAll.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCTransferAll.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCTransferAll.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCTransferAll.Location = New Global.System.Drawing.Point(578, 194)
			Me.ckbtnOCTransferAll.Name = "ckbtnOCTransferAll"
			Me.ckbtnOCTransferAll.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCTransferAll.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCTransferAll.TabIndex = 1105
			Me.ckbtnOCTransferAll.Text = "Auto"
			Me.ckbtnOCTransferAll.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCTransferAll.UseVisualStyleBackColor = False
			Me.txtLoopSSDOC.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSDOC.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSDOC.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSDOC.Location = New Global.System.Drawing.Point(364, 48)
			Me.txtLoopSSDOC.Name = "txtLoopSSDOC"
			Me.txtLoopSSDOC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSDOC.Size = New Global.System.Drawing.Size(44, 24)
			Me.txtLoopSSDOC.TabIndex = 1098
			Me.txtLoopSSDOC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSDOC.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSDOC.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSDOC.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSDOC.Location = New Global.System.Drawing.Point(365, 20)
			Me.txtLoopFSDOC.Name = "txtLoopFSDOC"
			Me.txtLoopFSDOC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSDOC.Size = New Global.System.Drawing.Size(43, 24)
			Me.txtLoopFSDOC.TabIndex = 1097
			Me.txtLoopFSDOC.Text = "1"
			Me.txtLoopFSDOC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label82.AutoSize = True
			Me.Label82.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label82.ForeColor = Global.System.Drawing.Color.Black
			Me.Label82.Location = New Global.System.Drawing.Point(352, 92)
			Me.Label82.Name = "Label82"
			Me.Label82.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label82.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label82.TabIndex = 1087
			Me.Label82.Text = "المبلغ"
			Me.lblOCv20.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv20.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv20.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv20.Location = New Global.System.Drawing.Point(224, 127)
			Me.lblOCv20.Name = "lblOCv20"
			Me.lblOCv20.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv20.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv20.TabIndex = 1075
			Me.lblOCv20.Text = "20"
			Me.lblOCv20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnOCTransferAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCTransferAll.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCTransferAll.Location = New Global.System.Drawing.Point(410, 192)
			Me.btnOCTransferAll.Name = "btnOCTransferAll"
			Me.btnOCTransferAll.Size = New Global.System.Drawing.Size(221, 55)
			Me.btnOCTransferAll.TabIndex = 1104
			Me.btnOCTransferAll.Text = "تحويل كل الكاش على الرقم"
			Me.btnOCTransferAll.UseVisualStyleBackColor = False
			Me.lblOCv15.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv15.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv15.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv15.Location = New Global.System.Drawing.Point(270, 127)
			Me.lblOCv15.Name = "lblOCv15"
			Me.lblOCv15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv15.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv15.TabIndex = 1074
			Me.lblOCv15.Text = "15"
			Me.lblOCv15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv10.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv10.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv10.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv10.Location = New Global.System.Drawing.Point(316, 127)
			Me.lblOCv10.Name = "lblOCv10"
			Me.lblOCv10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv10.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv10.TabIndex = 1073
			Me.lblOCv10.Text = "10"
			Me.lblOCv10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblOCv5.BackColor = Global.System.Drawing.Color.White
			Me.lblOCv5.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCv5.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCv5.Location = New Global.System.Drawing.Point(362, 127)
			Me.lblOCv5.Name = "lblOCv5"
			Me.lblOCv5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCv5.Size = New Global.System.Drawing.Size(40, 24)
			Me.lblOCv5.TabIndex = 1072
			Me.lblOCv5.Text = "5"
			Me.lblOCv5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.ckbtnOCTopup.AutoSize = True
			Me.ckbtnOCTopup.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCTopup.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCTopup.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCTopup.Location = New Global.System.Drawing.Point(302, 13)
			Me.ckbtnOCTopup.Name = "ckbtnOCTopup"
			Me.ckbtnOCTopup.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCTopup.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCTopup.TabIndex = 1071
			Me.ckbtnOCTopup.Text = "Auto"
			Me.ckbtnOCTopup.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCTopup.UseVisualStyleBackColor = False
			Me.txtOCchargeNum6.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum6.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum6.Location = New Global.System.Drawing.Point(15, 210)
			Me.txtOCchargeNum6.MaxLength = 11
			Me.txtOCchargeNum6.Name = "txtOCchargeNum6"
			Me.txtOCchargeNum6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum6.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum6.TabIndex = 1067
			Me.txtOCchargeNum6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCchargeNum5.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum5.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum5.Location = New Global.System.Drawing.Point(15, 173)
			Me.txtOCchargeNum5.MaxLength = 11
			Me.txtOCchargeNum5.Name = "txtOCchargeNum5"
			Me.txtOCchargeNum5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum5.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum5.TabIndex = 1066
			Me.txtOCchargeNum5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCchargeNum4.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum4.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum4.Location = New Global.System.Drawing.Point(15, 137)
			Me.txtOCchargeNum4.MaxLength = 11
			Me.txtOCchargeNum4.Name = "txtOCchargeNum4"
			Me.txtOCchargeNum4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum4.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum4.TabIndex = 1065
			Me.txtOCchargeNum4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCchargeNum3.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum3.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum3.Location = New Global.System.Drawing.Point(15, 101)
			Me.txtOCchargeNum3.MaxLength = 11
			Me.txtOCchargeNum3.Name = "txtOCchargeNum3"
			Me.txtOCchargeNum3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum3.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum3.TabIndex = 1064
			Me.txtOCchargeNum3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCchargeNum2.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum2.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum2.Location = New Global.System.Drawing.Point(14, 65)
			Me.txtOCchargeNum2.MaxLength = 11
			Me.txtOCchargeNum2.Name = "txtOCchargeNum2"
			Me.txtOCchargeNum2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum2.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum2.TabIndex = 1063
			Me.txtOCchargeNum2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCTopValue.BackColor = Global.System.Drawing.Color.White
			Me.txtOCTopValue.Font = New Global.System.Drawing.Font("Tahoma", 20.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOCTopValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCTopValue.Location = New Global.System.Drawing.Point(222, 81)
			Me.txtOCTopValue.Name = "txtOCTopValue"
			Me.txtOCTopValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCTopValue.Size = New Global.System.Drawing.Size(122, 40)
			Me.txtOCTopValue.TabIndex = 1060
			Me.txtOCTopValue.Text = "0"
			Me.txtOCTopValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCTopup.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCTopup.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCTopup.Location = New Global.System.Drawing.Point(220, 10)
			Me.btnOCTopup.Name = "btnOCTopup"
			Me.btnOCTopup.Size = New Global.System.Drawing.Size(138, 69)
			Me.btnOCTopup.TabIndex = 1058
			Me.btnOCTopup.Text = "TopUp To 6"
			Me.btnOCTopup.UseVisualStyleBackColor = False
			Me.ckbtnOCGetBal.AutoSize = True
			Me.ckbtnOCGetBal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCGetBal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCGetBal.Location = New Global.System.Drawing.Point(859, 239)
			Me.ckbtnOCGetBal.Name = "ckbtnOCGetBal"
			Me.ckbtnOCGetBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCGetBal.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCGetBal.TabIndex = 1088
			Me.ckbtnOCGetBal.Text = "Auto"
			Me.ckbtnOCGetBal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCGetBal.UseVisualStyleBackColor = False
			Me.Label74.AutoSize = True
			Me.Label74.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.Label74.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label74.ForeColor = Global.System.Drawing.Color.Black
			Me.Label74.Location = New Global.System.Drawing.Point(11, 9)
			Me.Label74.Name = "Label74"
			Me.Label74.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label74.Size = New Global.System.Drawing.Size(191, 17)
			Me.Label74.TabIndex = 1055
			Me.Label74.Text = "الخط مستقبل الرصيد العادى"
			Me.txtOCchargeNum1.BackColor = Global.System.Drawing.Color.White
			Me.txtOCchargeNum1.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCchargeNum1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCchargeNum1.Location = New Global.System.Drawing.Point(14, 29)
			Me.txtOCchargeNum1.MaxLength = 11
			Me.txtOCchargeNum1.Name = "txtOCchargeNum1"
			Me.txtOCchargeNum1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCchargeNum1.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtOCchargeNum1.TabIndex = 1054
			Me.txtOCchargeNum1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCGetBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGetBal.Location = New Global.System.Drawing.Point(643, 237)
			Me.btnOCGetBal.Name = "btnOCGetBal"
			Me.btnOCGetBal.Size = New Global.System.Drawing.Size(269, 50)
			Me.btnOCGetBal.TabIndex = 1068
			Me.btnOCGetBal.Text = "استعلام عن رصيدالكاش"
			Me.btnOCGetBal.UseVisualStyleBackColor = False
			Me.tabOCCon.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOCCon.Controls.Add(Me.ckbtnOCSeriesGetBalAfter)
			Me.tabOCCon.Controls.Add(Me.ckbtnOCSeriesGetBalBEfore)
			Me.tabOCCon.Controls.Add(Me.lblOCMain)
			Me.tabOCCon.Controls.Add(Me.txtLoopSSDOCPaySr)
			Me.tabOCCon.Controls.Add(Me.txtLoopFSDOCPAYSr)
			Me.tabOCCon.Controls.Add(Me.ckbtnOCFromMasterToAll)
			Me.tabOCCon.Controls.Add(Me.btnOCFromMasterToAll)
			Me.tabOCCon.Controls.Add(Me.btnOCGetBalPAy)
			Me.tabOCCon.Controls.Add(Me.txtOCValueMT5)
			Me.tabOCCon.Controls.Add(Me.Label100)
			Me.tabOCCon.Controls.Add(Me.txtOCValueMT4)
			Me.tabOCCon.Controls.Add(Me.Label99)
			Me.tabOCCon.Controls.Add(Me.txtOCValueMT3)
			Me.tabOCCon.Controls.Add(Me.Label98)
			Me.tabOCCon.Controls.Add(Me.txtOCValueMT2)
			Me.tabOCCon.Controls.Add(Me.Label97)
			Me.tabOCCon.Controls.Add(Me.txtOCValueMT1)
			Me.tabOCCon.Controls.Add(Me.Label96)
			Me.tabOCCon.Controls.Add(Me.ckbtnOCSeriesMT)
			Me.tabOCCon.Controls.Add(Me.btnOCSeriesMT)
			Me.tabOCCon.Controls.Add(Me.ckbtnOCSeries)
			Me.tabOCCon.Controls.Add(Me.btnOCSeries)
			Me.tabOCCon.Controls.Add(Me.txtOCValue)
			Me.tabOCCon.Controls.Add(Me.Label76)
			Me.tabOCCon.Controls.Add(Me.Label94)
			Me.tabOCCon.Controls.Add(Me.txtOCNextMain)
			Me.tabOCCon.Controls.Add(Me.Label73)
			Me.tabOCCon.Controls.Add(Me.Label93)
			Me.tabOCCon.Controls.Add(Me.Label72)
			Me.tabOCCon.Controls.Add(Me.btnOCExchange)
			Me.tabOCCon.Controls.Add(Me.txtOCAdd)
			Me.tabOCCon.Controls.Add(Me.txtOCSub)
			Me.tabOCCon.Controls.Add(Me.ckOCSub)
			Me.tabOCCon.Controls.Add(Me.ckOCSubAuto)
			Me.tabOCCon.Controls.Add(Me.btnOCfromMtoN)
			Me.tabOCCon.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOCCon.Name = "tabOCCon"
			Me.tabOCCon.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOCCon.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOCCon.TabIndex = 27
			Me.tabOCCon.Text = "OC Series"
			Me.ckbtnOCSeriesGetBalAfter.AutoSize = True
			Me.ckbtnOCSeriesGetBalAfter.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ckbtnOCSeriesGetBalAfter.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCSeriesGetBalAfter.Location = New Global.System.Drawing.Point(274, 51)
			Me.ckbtnOCSeriesGetBalAfter.Name = "ckbtnOCSeriesGetBalAfter"
			Me.ckbtnOCSeriesGetBalAfter.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCSeriesGetBalAfter.Size = New Global.System.Drawing.Size(114, 17)
			Me.ckbtnOCSeriesGetBalAfter.TabIndex = 1120
			Me.ckbtnOCSeriesGetBalAfter.Text = "استعلام رصيد بعد"
			Me.ckbtnOCSeriesGetBalAfter.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCSeriesGetBalAfter.UseVisualStyleBackColor = False
			Me.ckbtnOCSeriesGetBalBEfore.AutoSize = True
			Me.ckbtnOCSeriesGetBalBEfore.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ckbtnOCSeriesGetBalBEfore.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCSeriesGetBalBEfore.Location = New Global.System.Drawing.Point(271, 24)
			Me.ckbtnOCSeriesGetBalBEfore.Name = "ckbtnOCSeriesGetBalBEfore"
			Me.ckbtnOCSeriesGetBalBEfore.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCSeriesGetBalBEfore.Size = New Global.System.Drawing.Size(117, 17)
			Me.ckbtnOCSeriesGetBalBEfore.TabIndex = 1119
			Me.ckbtnOCSeriesGetBalBEfore.Text = "استعلام رصيد قبل"
			Me.ckbtnOCSeriesGetBalBEfore.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCSeriesGetBalBEfore.UseVisualStyleBackColor = False
			Me.lblOCMain.BackColor = Global.System.Drawing.Color.White
			Me.lblOCMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCMain.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCMain.Location = New Global.System.Drawing.Point(640, 168)
			Me.lblOCMain.MaxLength = 11
			Me.lblOCMain.Name = "lblOCMain"
			Me.lblOCMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCMain.Size = New Global.System.Drawing.Size(202, 36)
			Me.lblOCMain.TabIndex = 1118
			Me.lblOCMain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopSSDOCPaySr.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSDOCPaySr.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSDOCPaySr.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSDOCPaySr.Location = New Global.System.Drawing.Point(498, 40)
			Me.txtLoopSSDOCPaySr.Name = "txtLoopSSDOCPaySr"
			Me.txtLoopSSDOCPaySr.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSDOCPaySr.Size = New Global.System.Drawing.Size(44, 24)
			Me.txtLoopSSDOCPaySr.TabIndex = 1117
			Me.txtLoopSSDOCPaySr.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSDOCPAYSr.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSDOCPAYSr.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSDOCPAYSr.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSDOCPAYSr.Location = New Global.System.Drawing.Point(499, 12)
			Me.txtLoopFSDOCPAYSr.Name = "txtLoopFSDOCPAYSr"
			Me.txtLoopFSDOCPAYSr.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSDOCPAYSr.Size = New Global.System.Drawing.Size(43, 24)
			Me.txtLoopFSDOCPAYSr.TabIndex = 1116
			Me.txtLoopFSDOCPAYSr.Text = "1"
			Me.txtLoopFSDOCPAYSr.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckbtnOCFromMasterToAll.AutoSize = True
			Me.ckbtnOCFromMasterToAll.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCFromMasterToAll.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCFromMasterToAll.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCFromMasterToAll.Location = New Global.System.Drawing.Point(354, 87)
			Me.ckbtnOCFromMasterToAll.Name = "ckbtnOCFromMasterToAll"
			Me.ckbtnOCFromMasterToAll.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCFromMasterToAll.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCFromMasterToAll.TabIndex = 1115
			Me.ckbtnOCFromMasterToAll.Text = "Auto"
			Me.ckbtnOCFromMasterToAll.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCFromMasterToAll.UseVisualStyleBackColor = False
			Me.btnOCFromMasterToAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCFromMasterToAll.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCFromMasterToAll.Location = New Global.System.Drawing.Point(234, 84)
			Me.btnOCFromMasterToAll.Name = "btnOCFromMasterToAll"
			Me.btnOCFromMasterToAll.Size = New Global.System.Drawing.Size(173, 79)
			Me.btnOCFromMasterToAll.TabIndex = 1114
			Me.btnOCFromMasterToAll.Text = "من الاساسى للكل"
			Me.btnOCFromMasterToAll.UseVisualStyleBackColor = False
			Me.btnOCGetBalPAy.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGetBalPAy.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGetBalPAy.Location = New Global.System.Drawing.Point(234, 172)
			Me.btnOCGetBalPAy.Name = "btnOCGetBalPAy"
			Me.btnOCGetBalPAy.Size = New Global.System.Drawing.Size(173, 72)
			Me.btnOCGetBalPAy.TabIndex = 1107
			Me.btnOCGetBalPAy.Text = "استعلام عن رصيدالكاش"
			Me.btnOCGetBalPAy.UseVisualStyleBackColor = False
			Me.txtOCValueMT5.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueMT5.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueMT5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueMT5.Location = New Global.System.Drawing.Point(14, 219)
			Me.txtOCValueMT5.Name = "txtOCValueMT5"
			Me.txtOCValueMT5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueMT5.Size = New Global.System.Drawing.Size(120, 36)
			Me.txtOCValueMT5.TabIndex = 1112
			Me.txtOCValueMT5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label100.AutoSize = True
			Me.Label100.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label100.ForeColor = Global.System.Drawing.Color.Black
			Me.Label100.Location = New Global.System.Drawing.Point(155, 227)
			Me.Label100.Name = "Label100"
			Me.Label100.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label100.Size = New Global.System.Drawing.Size(61, 17)
			Me.Label100.TabIndex = 1113
			Me.Label100.Text = "تحويل 5"
			Me.txtOCValueMT4.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueMT4.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueMT4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueMT4.Location = New Global.System.Drawing.Point(14, 179)
			Me.txtOCValueMT4.Name = "txtOCValueMT4"
			Me.txtOCValueMT4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueMT4.Size = New Global.System.Drawing.Size(120, 36)
			Me.txtOCValueMT4.TabIndex = 1110
			Me.txtOCValueMT4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label99.AutoSize = True
			Me.Label99.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label99.ForeColor = Global.System.Drawing.Color.Black
			Me.Label99.Location = New Global.System.Drawing.Point(155, 187)
			Me.Label99.Name = "Label99"
			Me.Label99.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label99.Size = New Global.System.Drawing.Size(61, 17)
			Me.Label99.TabIndex = 1111
			Me.Label99.Text = "تحويل 4"
			Me.txtOCValueMT3.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueMT3.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueMT3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueMT3.Location = New Global.System.Drawing.Point(14, 140)
			Me.txtOCValueMT3.Name = "txtOCValueMT3"
			Me.txtOCValueMT3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueMT3.Size = New Global.System.Drawing.Size(120, 36)
			Me.txtOCValueMT3.TabIndex = 1108
			Me.txtOCValueMT3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label98.AutoSize = True
			Me.Label98.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label98.ForeColor = Global.System.Drawing.Color.Black
			Me.Label98.Location = New Global.System.Drawing.Point(155, 148)
			Me.Label98.Name = "Label98"
			Me.Label98.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label98.Size = New Global.System.Drawing.Size(61, 17)
			Me.Label98.TabIndex = 1109
			Me.Label98.Text = "تحويل 3"
			Me.txtOCValueMT2.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueMT2.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueMT2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueMT2.Location = New Global.System.Drawing.Point(14, 101)
			Me.txtOCValueMT2.Name = "txtOCValueMT2"
			Me.txtOCValueMT2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueMT2.Size = New Global.System.Drawing.Size(120, 36)
			Me.txtOCValueMT2.TabIndex = 1106
			Me.txtOCValueMT2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label97.AutoSize = True
			Me.Label97.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label97.ForeColor = Global.System.Drawing.Color.Black
			Me.Label97.Location = New Global.System.Drawing.Point(155, 109)
			Me.Label97.Name = "Label97"
			Me.Label97.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label97.Size = New Global.System.Drawing.Size(61, 17)
			Me.Label97.TabIndex = 1107
			Me.Label97.Text = "تحويل 2"
			Me.txtOCValueMT1.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValueMT1.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValueMT1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValueMT1.Location = New Global.System.Drawing.Point(14, 62)
			Me.txtOCValueMT1.Name = "txtOCValueMT1"
			Me.txtOCValueMT1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValueMT1.Size = New Global.System.Drawing.Size(120, 36)
			Me.txtOCValueMT1.TabIndex = 1104
			Me.txtOCValueMT1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label96.AutoSize = True
			Me.Label96.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label96.ForeColor = Global.System.Drawing.Color.Black
			Me.Label96.Location = New Global.System.Drawing.Point(155, 70)
			Me.Label96.Name = "Label96"
			Me.Label96.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label96.Size = New Global.System.Drawing.Size(61, 17)
			Me.Label96.TabIndex = 1105
			Me.Label96.Text = "تحويل 1"
			Me.ckbtnOCSeriesMT.AutoSize = True
			Me.ckbtnOCSeriesMT.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCSeriesMT.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCSeriesMT.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCSeriesMT.Location = New Global.System.Drawing.Point(166, 14)
			Me.ckbtnOCSeriesMT.Name = "ckbtnOCSeriesMT"
			Me.ckbtnOCSeriesMT.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCSeriesMT.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCSeriesMT.TabIndex = 1103
			Me.ckbtnOCSeriesMT.Text = "Auto"
			Me.ckbtnOCSeriesMT.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCSeriesMT.UseVisualStyleBackColor = False
			Me.btnOCSeriesMT.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCSeriesMT.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCSeriesMT.Location = New Global.System.Drawing.Point(14, 8)
			Me.btnOCSeriesMT.Name = "btnOCSeriesMT"
			Me.btnOCSeriesMT.Size = New Global.System.Drawing.Size(205, 48)
			Me.btnOCSeriesMT.TabIndex = 1102
			Me.btnOCSeriesMT.Text = "متتالى"
			Me.btnOCSeriesMT.UseVisualStyleBackColor = False
			Me.ckbtnOCSeries.AutoSize = True
			Me.ckbtnOCSeries.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCSeries.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCSeries.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCSeries.Location = New Global.System.Drawing.Point(795, 17)
			Me.ckbtnOCSeries.Name = "ckbtnOCSeries"
			Me.ckbtnOCSeries.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCSeries.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCSeries.TabIndex = 1076
			Me.ckbtnOCSeries.Text = "Auto"
			Me.ckbtnOCSeries.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCSeries.UseVisualStyleBackColor = False
			Me.btnOCSeries.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCSeries.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCSeries.Location = New Global.System.Drawing.Point(548, 10)
			Me.btnOCSeries.Name = "btnOCSeries"
			Me.btnOCSeries.Size = New Global.System.Drawing.Size(303, 73)
			Me.btnOCSeries.TabIndex = 1061
			Me.btnOCSeries.Text = "متتالى"
			Me.btnOCSeries.UseVisualStyleBackColor = False
			Me.txtOCValue.BackColor = Global.System.Drawing.Color.White
			Me.txtOCValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCValue.Location = New Global.System.Drawing.Point(521, 113)
			Me.txtOCValue.Name = "txtOCValue"
			Me.txtOCValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCValue.Size = New Global.System.Drawing.Size(99, 36)
			Me.txtOCValue.TabIndex = 1050
			Me.txtOCValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label76.AutoSize = True
			Me.Label76.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label76.ForeColor = Global.System.Drawing.Color.Black
			Me.Label76.Location = New Global.System.Drawing.Point(770, 141)
			Me.Label76.Name = "Label76"
			Me.Label76.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label76.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label76.TabIndex = 1051
			Me.Label76.Text = "الاساسى"
			Me.Label94.AutoSize = True
			Me.Label94.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label94.ForeColor = Global.System.Drawing.Color.Black
			Me.Label94.Location = New Global.System.Drawing.Point(636, 136)
			Me.Label94.Name = "Label94"
			Me.Label94.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label94.Size = New Global.System.Drawing.Size(29, 25)
			Me.Label94.TabIndex = 1101
			Me.Label94.Text = "+"
			Me.txtOCNextMain.BackColor = Global.System.Drawing.Color.White
			Me.txtOCNextMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCNextMain.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCNextMain.Location = New Global.System.Drawing.Point(641, 235)
			Me.txtOCNextMain.MaxLength = 11
			Me.txtOCNextMain.Name = "txtOCNextMain"
			Me.txtOCNextMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCNextMain.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtOCNextMain.TabIndex = 1053
			Me.txtOCNextMain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label73.AutoSize = True
			Me.Label73.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label73.ForeColor = Global.System.Drawing.Color.Black
			Me.Label73.Location = New Global.System.Drawing.Point(532, 86)
			Me.Label73.Name = "Label73"
			Me.Label73.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label73.Size = New Global.System.Drawing.Size(88, 17)
			Me.Label73.TabIndex = 1056
			Me.Label73.Text = "مبلغ التحويل"
			Me.Label93.AutoSize = True
			Me.Label93.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label93.ForeColor = Global.System.Drawing.Color.Black
			Me.Label93.Location = New Global.System.Drawing.Point(639, 105)
			Me.Label93.Name = "Label93"
			Me.Label93.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label93.Size = New Global.System.Drawing.Size(21, 25)
			Me.Label93.TabIndex = 1100
			Me.Label93.Text = "-"
			Me.Label72.AutoSize = True
			Me.Label72.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label72.ForeColor = Global.System.Drawing.Color.Black
			Me.Label72.Location = New Global.System.Drawing.Point(748, 212)
			Me.Label72.Name = "Label72"
			Me.Label72.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label72.Size = New Global.System.Drawing.Size(94, 13)
			Me.Label72.TabIndex = 1057
			Me.Label72.Text = "الاساسى التالى"
			Me.btnOCExchange.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCExchange.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCExchange.Location = New Global.System.Drawing.Point(640, 207)
			Me.btnOCExchange.Name = "btnOCExchange"
			Me.btnOCExchange.Size = New Global.System.Drawing.Size(42, 23)
			Me.btnOCExchange.TabIndex = 1062
			Me.btnOCExchange.Text = "||"
			Me.btnOCExchange.UseVisualStyleBackColor = False
			Me.txtOCAdd.BackColor = Global.System.Drawing.Color.White
			Me.txtOCAdd.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCAdd.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCAdd.Location = New Global.System.Drawing.Point(670, 138)
			Me.txtOCAdd.MaxLength = 100
			Me.txtOCAdd.Name = "txtOCAdd"
			Me.txtOCAdd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCAdd.Size = New Global.System.Drawing.Size(69, 24)
			Me.txtOCAdd.TabIndex = 1099
			Me.txtOCAdd.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCSub.BackColor = Global.System.Drawing.Color.White
			Me.txtOCSub.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCSub.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCSub.Location = New Global.System.Drawing.Point(670, 107)
			Me.txtOCSub.MaxLength = 100
			Me.txtOCSub.Name = "txtOCSub"
			Me.txtOCSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCSub.Size = New Global.System.Drawing.Size(69, 24)
			Me.txtOCSub.TabIndex = 1069
			Me.txtOCSub.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckOCSub.AutoSize = True
			Me.ckOCSub.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ckOCSub.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckOCSub.Location = New Global.System.Drawing.Point(758, 104)
			Me.ckOCSub.Name = "ckOCSub"
			Me.ckOCSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckOCSub.Size = New Global.System.Drawing.Size(78, 17)
			Me.ckOCSub.TabIndex = 1070
			Me.ckOCSub.Text = "خصم مبلغ"
			Me.ckOCSub.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckOCSub.UseVisualStyleBackColor = False
			Me.ckOCSubAuto.AutoSize = True
			Me.ckOCSubAuto.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ckOCSubAuto.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckOCSubAuto.Location = New Global.System.Drawing.Point(745, 121)
			Me.ckOCSubAuto.Name = "ckOCSubAuto"
			Me.ckOCSubAuto.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckOCSubAuto.Size = New Global.System.Drawing.Size(91, 17)
			Me.ckOCSubAuto.TabIndex = 1077
			Me.ckOCSubAuto.Text = "تخفيض ذكى"
			Me.ckOCSubAuto.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckOCSubAuto.UseVisualStyleBackColor = False
			Me.btnOCfromMtoN.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCfromMtoN.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCfromMtoN.Location = New Global.System.Drawing.Point(499, 159)
			Me.btnOCfromMtoN.Name = "btnOCfromMtoN"
			Me.btnOCfromMtoN.Size = New Global.System.Drawing.Size(135, 116)
			Me.btnOCfromMtoN.TabIndex = 1059
			Me.btnOCfromMtoN.Text = "من الاساسى للاساسى التالى"
			Me.btnOCfromMtoN.UseVisualStyleBackColor = False
			Me.tabOCMaster.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOCMaster.Controls.Add(Me.ckVerifyNumber)
			Me.tabOCMaster.Controls.Add(Me.ckbtnOCMAuto)
			Me.tabOCMaster.Controls.Add(Me.btnOCMAuto)
			Me.tabOCMaster.Controls.Add(Me.txtOCtopupDelayM2)
			Me.tabOCMaster.Controls.Add(Me.lblOCMMain)
			Me.tabOCMaster.Controls.Add(Me.btnAddNumbersToOC)
			Me.tabOCMaster.Controls.Add(Me.txtOCtopupDelayM)
			Me.tabOCMaster.Controls.Add(Me.btnOCTopUpMulti)
			Me.tabOCMaster.Controls.Add(Me.txtTopUpOrangeValue)
			Me.tabOCMaster.Controls.Add(Me.txtOCInput)
			Me.tabOCMaster.Controls.Add(Me.btnOCMSerieAcceptInput)
			Me.tabOCMaster.Controls.Add(Me.btnOCMSeriesInput)
			Me.tabOCMaster.Controls.Add(Me.btnTayerCharge)
			Me.tabOCMaster.Controls.Add(Me.lblOCDone)
			Me.tabOCMaster.Controls.Add(Me.btnClearOC)
			Me.tabOCMaster.Controls.Add(Me.btnDelOnePre)
			Me.tabOCMaster.Controls.Add(Me.lblCountPre)
			Me.tabOCMaster.Controls.Add(Me.txtOCNumber)
			Me.tabOCMaster.Controls.Add(Me.lstOCNumbers)
			Me.tabOCMaster.Controls.Add(Me.ckbtnOCMSerieAccept)
			Me.tabOCMaster.Controls.Add(Me.btnOCMSerieAccept)
			Me.tabOCMaster.Controls.Add(Me.Label101)
			Me.tabOCMaster.Controls.Add(Me.txtOCMCount)
			Me.tabOCMaster.Controls.Add(Me.btnOCGetBal2)
			Me.tabOCMaster.Controls.Add(Me.ckbtnOCMSeries)
			Me.tabOCMaster.Controls.Add(Me.btnOCMSeries)
			Me.tabOCMaster.Controls.Add(Me.Label85)
			Me.tabOCMaster.Controls.Add(Me.Label87)
			Me.tabOCMaster.Controls.Add(Me.txtOCMValue)
			Me.tabOCMaster.Controls.Add(Me.btnOCMGetBal)
			Me.tabOCMaster.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOCMaster.Name = "tabOCMaster"
			Me.tabOCMaster.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOCMaster.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOCMaster.TabIndex = 21
			Me.tabOCMaster.Text = "OC Master Tayer"
			Me.ckVerifyNumber.AutoSize = True
			Me.ckVerifyNumber.Checked = True
			Me.ckVerifyNumber.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.ckVerifyNumber.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckVerifyNumber.Location = New Global.System.Drawing.Point(121, 40)
			Me.ckVerifyNumber.Name = "ckVerifyNumber"
			Me.ckVerifyNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckVerifyNumber.Size = New Global.System.Drawing.Size(59, 17)
			Me.ckVerifyNumber.TabIndex = 1135
			Me.ckVerifyNumber.Text = "Verify"
			Me.ckVerifyNumber.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckVerifyNumber.UseVisualStyleBackColor = True
			Me.ckbtnOCMAuto.AutoSize = True
			Me.ckbtnOCMAuto.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCMAuto.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCMAuto.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCMAuto.Location = New Global.System.Drawing.Point(565, 17)
			Me.ckbtnOCMAuto.Name = "ckbtnOCMAuto"
			Me.ckbtnOCMAuto.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCMAuto.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCMAuto.TabIndex = 1134
			Me.ckbtnOCMAuto.Text = "Auto"
			Me.ckbtnOCMAuto.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCMAuto.UseVisualStyleBackColor = False
			Me.btnOCMAuto.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMAuto.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMAuto.Location = New Global.System.Drawing.Point(430, 12)
			Me.btnOCMAuto.Name = "btnOCMAuto"
			Me.btnOCMAuto.Size = New Global.System.Drawing.Size(195, 71)
			Me.btnOCMAuto.TabIndex = 1133
			Me.btnOCMAuto.Text = "Auto Input"
			Me.btnOCMAuto.UseVisualStyleBackColor = False
			Me.txtOCtopupDelayM2.BackColor = Global.System.Drawing.Color.Blue
			Me.txtOCtopupDelayM2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCtopupDelayM2.ForeColor = Global.System.Drawing.Color.White
			Me.txtOCtopupDelayM2.Location = New Global.System.Drawing.Point(872, 126)
			Me.txtOCtopupDelayM2.Name = "txtOCtopupDelayM2"
			Me.txtOCtopupDelayM2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCtopupDelayM2.Size = New Global.System.Drawing.Size(50, 24)
			Me.txtOCtopupDelayM2.TabIndex = 1131
			Me.txtOCtopupDelayM2.Text = "1"
			Me.txtOCtopupDelayM2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblOCMMain.BackColor = Global.System.Drawing.Color.White
			Me.lblOCMMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOCMMain.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCMMain.Location = New Global.System.Drawing.Point(726, 180)
			Me.lblOCMMain.MaxLength = 11
			Me.lblOCMMain.Name = "lblOCMMain"
			Me.lblOCMMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCMMain.Size = New Global.System.Drawing.Size(196, 36)
			Me.lblOCMMain.TabIndex = 1130
			Me.lblOCMMain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAddNumbersToOC.Location = New Global.System.Drawing.Point(110, 10)
			Me.btnAddNumbersToOC.Name = "btnAddNumbersToOC"
			Me.btnAddNumbersToOC.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnAddNumbersToOC.TabIndex = 1129
			Me.btnAddNumbersToOC.Text = "Add"
			Me.btnAddNumbersToOC.UseVisualStyleBackColor = True
			Me.txtOCtopupDelayM.BackColor = Global.System.Drawing.Color.Blue
			Me.txtOCtopupDelayM.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCtopupDelayM.ForeColor = Global.System.Drawing.Color.White
			Me.txtOCtopupDelayM.Location = New Global.System.Drawing.Point(421, 226)
			Me.txtOCtopupDelayM.Name = "txtOCtopupDelayM"
			Me.txtOCtopupDelayM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCtopupDelayM.Size = New Global.System.Drawing.Size(50, 24)
			Me.txtOCtopupDelayM.TabIndex = 1128
			Me.txtOCtopupDelayM.Text = "1"
			Me.txtOCtopupDelayM.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCTopUpMulti.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCTopUpMulti.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCTopUpMulti.Location = New Global.System.Drawing.Point(421, 226)
			Me.btnOCTopUpMulti.Name = "btnOCTopUpMulti"
			Me.btnOCTopUpMulti.Size = New Global.System.Drawing.Size(177, 64)
			Me.btnOCTopUpMulti.TabIndex = 1127
			Me.btnOCTopUpMulti.Text = "TopUp Cash"
			Me.btnOCTopUpMulti.UseVisualStyleBackColor = False
			Me.txtTopUpOrangeValue.BackColor = Global.System.Drawing.Color.White
			Me.txtTopUpOrangeValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTopUpOrangeValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTopUpOrangeValue.Location = New Global.System.Drawing.Point(425, 182)
			Me.txtTopUpOrangeValue.Name = "txtTopUpOrangeValue"
			Me.txtTopUpOrangeValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTopUpOrangeValue.Size = New Global.System.Drawing.Size(113, 36)
			Me.txtTopUpOrangeValue.TabIndex = 1126
			Me.txtTopUpOrangeValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOCInput.BackColor = Global.System.Drawing.Color.White
			Me.txtOCInput.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCInput.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCInput.Location = New Global.System.Drawing.Point(3, 74)
			Me.txtOCInput.Name = "txtOCInput"
			Me.txtOCInput.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCInput.Size = New Global.System.Drawing.Size(102, 36)
			Me.txtOCInput.TabIndex = 1125
			Me.txtOCInput.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCMSerieAcceptInput.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMSerieAcceptInput.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMSerieAcceptInput.Location = New Global.System.Drawing.Point(2, 170)
			Me.btnOCMSerieAcceptInput.Name = "btnOCMSerieAcceptInput"
			Me.btnOCMSerieAcceptInput.Size = New Global.System.Drawing.Size(179, 49)
			Me.btnOCMSerieAcceptInput.TabIndex = 1124
			Me.btnOCMSerieAcceptInput.Text = "تأكيد السحب"
			Me.btnOCMSerieAcceptInput.UseVisualStyleBackColor = False
			Me.btnOCMSeriesInput.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMSeriesInput.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMSeriesInput.Location = New Global.System.Drawing.Point(2, 119)
			Me.btnOCMSeriesInput.Name = "btnOCMSeriesInput"
			Me.btnOCMSeriesInput.Size = New Global.System.Drawing.Size(178, 47)
			Me.btnOCMSeriesInput.TabIndex = 1123
			Me.btnOCMSeriesInput.Text = "سحب من الماستر"
			Me.btnOCMSeriesInput.UseVisualStyleBackColor = False
			Me.btnTayerCharge.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerCharge.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerCharge.Location = New Global.System.Drawing.Point(425, 121)
			Me.btnTayerCharge.Name = "btnTayerCharge"
			Me.btnTayerCharge.Size = New Global.System.Drawing.Size(113, 56)
			Me.btnTayerCharge.TabIndex = 1122
			Me.btnTayerCharge.Text = "TopUp Hawa"
			Me.btnTayerCharge.UseVisualStyleBackColor = False
			Me.lblOCDone.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblOCDone.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCDone.Location = New Global.System.Drawing.Point(6, 9)
			Me.lblOCDone.Name = "lblOCDone"
			Me.lblOCDone.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCDone.Size = New Global.System.Drawing.Size(77, 19)
			Me.lblOCDone.TabIndex = 1121
			Me.lblOCDone.Text = "#"
			Me.lblOCDone.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnClearOC.Location = New Global.System.Drawing.Point(110, 63)
			Me.btnClearOC.Name = "btnClearOC"
			Me.btnClearOC.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnClearOC.TabIndex = 1120
			Me.btnClearOC.Text = "مسح الكل"
			Me.btnClearOC.UseVisualStyleBackColor = True
			Me.btnDelOnePre.Location = New Global.System.Drawing.Point(110, 89)
			Me.btnDelOnePre.Name = "btnDelOnePre"
			Me.btnDelOnePre.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnDelOnePre.TabIndex = 1119
			Me.btnDelOnePre.Text = "حذف محدد"
			Me.btnDelOnePre.UseVisualStyleBackColor = True
			Me.lblCountPre.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCountPre.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCountPre.Location = New Global.System.Drawing.Point(6, 40)
			Me.lblCountPre.Name = "lblCountPre"
			Me.lblCountPre.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCountPre.Size = New Global.System.Drawing.Size(77, 19)
			Me.lblCountPre.TabIndex = 1118
			Me.lblCountPre.Text = "#"
			Me.lblCountPre.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtOCNumber.BackColor = Global.System.Drawing.Color.White
			Me.txtOCNumber.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCNumber.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCNumber.Location = New Global.System.Drawing.Point(188, 17)
			Me.txtOCNumber.Name = "txtOCNumber"
			Me.txtOCNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCNumber.Size = New Global.System.Drawing.Size(231, 36)
			Me.txtOCNumber.TabIndex = 1117
			Me.txtOCNumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lstOCNumbers.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstOCNumbers.FormattingEnabled = True
			Me.lstOCNumbers.ItemHeight = 23
			Me.lstOCNumbers.Location = New Global.System.Drawing.Point(188, 56)
			Me.lstOCNumbers.Name = "lstOCNumbers"
			Me.lstOCNumbers.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstOCNumbers.Size = New Global.System.Drawing.Size(231, 188)
			Me.lstOCNumbers.TabIndex = 1116
			Me.ckbtnOCMSerieAccept.AutoSize = True
			Me.ckbtnOCMSerieAccept.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCMSerieAccept.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCMSerieAccept.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCMSerieAccept.Location = New Global.System.Drawing.Point(730, 12)
			Me.ckbtnOCMSerieAccept.Name = "ckbtnOCMSerieAccept"
			Me.ckbtnOCMSerieAccept.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCMSerieAccept.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCMSerieAccept.TabIndex = 1115
			Me.ckbtnOCMSerieAccept.Text = "Auto"
			Me.ckbtnOCMSerieAccept.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCMSerieAccept.UseVisualStyleBackColor = False
			Me.btnOCMSerieAccept.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMSerieAccept.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMSerieAccept.Location = New Global.System.Drawing.Point(637, 7)
			Me.btnOCMSerieAccept.Name = "btnOCMSerieAccept"
			Me.btnOCMSerieAccept.Size = New Global.System.Drawing.Size(152, 71)
			Me.btnOCMSerieAccept.TabIndex = 1114
			Me.btnOCMSerieAccept.Text = "تأكيد الايداع"
			Me.btnOCMSerieAccept.UseVisualStyleBackColor = False
			Me.Label101.AutoSize = True
			Me.Label101.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label101.ForeColor = Global.System.Drawing.Color.Black
			Me.Label101.Location = New Global.System.Drawing.Point(793, 141)
			Me.Label101.Name = "Label101"
			Me.Label101.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label101.Size = New Global.System.Drawing.Size(41, 17)
			Me.Label101.TabIndex = 1113
			Me.Label101.Text = "العدد"
			Me.txtOCMCount.BackColor = Global.System.Drawing.Color.White
			Me.txtOCMCount.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCMCount.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCMCount.Location = New Global.System.Drawing.Point(726, 130)
			Me.txtOCMCount.Name = "txtOCMCount"
			Me.txtOCMCount.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCMCount.Size = New Global.System.Drawing.Size(54, 36)
			Me.txtOCMCount.TabIndex = 1112
			Me.txtOCMCount.Text = "1"
			Me.txtOCMCount.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCGetBal2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGetBal2.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGetBal2.Location = New Global.System.Drawing.Point(608, 222)
			Me.btnOCGetBal2.Name = "btnOCGetBal2"
			Me.btnOCGetBal2.Size = New Global.System.Drawing.Size(166, 66)
			Me.btnOCGetBal2.TabIndex = 1107
			Me.btnOCGetBal2.Text = "استعلام عن رصيدالكاش"
			Me.btnOCGetBal2.UseVisualStyleBackColor = False
			Me.ckbtnOCMSeries.AutoSize = True
			Me.ckbtnOCMSeries.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCMSeries.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCMSeries.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCMSeries.Location = New Global.System.Drawing.Point(872, 11)
			Me.ckbtnOCMSeries.Name = "ckbtnOCMSeries"
			Me.ckbtnOCMSeries.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCMSeries.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCMSeries.TabIndex = 1102
			Me.ckbtnOCMSeries.Text = "Auto"
			Me.ckbtnOCMSeries.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCMSeries.UseVisualStyleBackColor = False
			Me.btnOCMSeries.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMSeries.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMSeries.Location = New Global.System.Drawing.Point(795, 6)
			Me.btnOCMSeries.Name = "btnOCMSeries"
			Me.btnOCMSeries.Size = New Global.System.Drawing.Size(133, 72)
			Me.btnOCMSeries.TabIndex = 1101
			Me.btnOCMSeries.Text = "ايداع"
			Me.btnOCMSeries.UseVisualStyleBackColor = False
			Me.Label85.AutoSize = True
			Me.Label85.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label85.ForeColor = Global.System.Drawing.Color.Black
			Me.Label85.Location = New Global.System.Drawing.Point(833, 97)
			Me.Label85.Name = "Label85"
			Me.Label85.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label85.Size = New Global.System.Drawing.Size(88, 17)
			Me.Label85.TabIndex = 1100
			Me.Label85.Text = "مبلغ التحويل"
			Me.Label87.AutoSize = True
			Me.Label87.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label87.ForeColor = Global.System.Drawing.Color.Black
			Me.Label87.Location = New Global.System.Drawing.Point(866, 156)
			Me.Label87.Name = "Label87"
			Me.Label87.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label87.Size = New Global.System.Drawing.Size(58, 17)
			Me.Label87.TabIndex = 1098
			Me.Label87.Text = "الماستر"
			Me.txtOCMValue.BackColor = Global.System.Drawing.Color.White
			Me.txtOCMValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCMValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCMValue.Location = New Global.System.Drawing.Point(720, 89)
			Me.txtOCMValue.Name = "txtOCMValue"
			Me.txtOCMValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCMValue.Size = New Global.System.Drawing.Size(102, 36)
			Me.txtOCMValue.TabIndex = 1097
			Me.txtOCMValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCMGetBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCMGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCMGetBal.Location = New Global.System.Drawing.Point(780, 222)
			Me.btnOCMGetBal.Name = "btnOCMGetBal"
			Me.btnOCMGetBal.Size = New Global.System.Drawing.Size(148, 66)
			Me.btnOCMGetBal.TabIndex = 1095
			Me.btnOCMGetBal.Text = "استعلام عن رصيدالماستر"
			Me.btnOCMGetBal.UseVisualStyleBackColor = False
			Me.tabOCGifts.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOCGifts.Controls.Add(Me.txtDoOfferWithdraw2)
			Me.tabOCGifts.Controls.Add(Me.Label108)
			Me.tabOCGifts.Controls.Add(Me.txtDoOfferWithdraw1)
			Me.tabOCGifts.Controls.Add(Me.Label107)
			Me.tabOCGifts.Controls.Add(Me.ckbtnDoOfferWithdraw)
			Me.tabOCGifts.Controls.Add(Me.btnDoOfferWithdraw)
			Me.tabOCGifts.Controls.Add(Me.txtDelayToGet58)
			Me.tabOCGifts.Controls.Add(Me.ckbtnOCFreeTransfer)
			Me.tabOCGifts.Controls.Add(Me.btnOCFreeTransfer)
			Me.tabOCGifts.Controls.Add(Me.ckbtnOCGetBalPAy2)
			Me.tabOCGifts.Controls.Add(Me.ckbtnGetNormalBal)
			Me.tabOCGifts.Controls.Add(Me.btnGetNormalBal)
			Me.tabOCGifts.Controls.Add(Me.ckbtnTranstop)
			Me.tabOCGifts.Controls.Add(Me.btnTranstop)
			Me.tabOCGifts.Controls.Add(Me.ckbtnTrans1000)
			Me.tabOCGifts.Controls.Add(Me.btnTrans1000)
			Me.tabOCGifts.Controls.Add(Me.ckbtnTrans100)
			Me.tabOCGifts.Controls.Add(Me.btnTrans100)
			Me.tabOCGifts.Controls.Add(Me.btnOCGetBalPAy2)
			Me.tabOCGifts.Controls.Add(Me.ckbtnOCApply58)
			Me.tabOCGifts.Controls.Add(Me.ckbtnOCGiftsCheckConf)
			Me.tabOCGifts.Controls.Add(Me.btnOCGiftsCheckConf)
			Me.tabOCGifts.Controls.Add(Me.txtLoopSSOCG)
			Me.tabOCGifts.Controls.Add(Me.txtLoopFSOCG)
			Me.tabOCGifts.Controls.Add(Me.btnOCApply58)
			Me.tabOCGifts.Controls.Add(Me.ckbtnOCGiftsCheck)
			Me.tabOCGifts.Controls.Add(Me.btnOCGiftsCheck)
			Me.tabOCGifts.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOCGifts.Name = "tabOCGifts"
			Me.tabOCGifts.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOCGifts.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOCGifts.TabIndex = 26
			Me.tabOCGifts.Text = "OC Offers"
			Me.txtDoOfferWithdraw2.BackColor = Global.System.Drawing.Color.White
			Me.txtDoOfferWithdraw2.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDoOfferWithdraw2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtDoOfferWithdraw2.Location = New Global.System.Drawing.Point(325, 189)
			Me.txtDoOfferWithdraw2.MaxLength = 11
			Me.txtDoOfferWithdraw2.Name = "txtDoOfferWithdraw2"
			Me.txtDoOfferWithdraw2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDoOfferWithdraw2.Size = New Global.System.Drawing.Size(196, 36)
			Me.txtDoOfferWithdraw2.TabIndex = 1138
			Me.txtDoOfferWithdraw2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label108.AutoSize = True
			Me.Label108.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label108.ForeColor = Global.System.Drawing.Color.Black
			Me.Label108.Location = New Global.System.Drawing.Point(447, 167)
			Me.Label108.Name = "Label108"
			Me.Label108.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label108.Size = New Global.System.Drawing.Size(74, 17)
			Me.Label108.TabIndex = 1137
			Me.Label108.Text = "اسنقبال 1"
			Me.txtDoOfferWithdraw1.BackColor = Global.System.Drawing.Color.White
			Me.txtDoOfferWithdraw1.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDoOfferWithdraw1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtDoOfferWithdraw1.Location = New Global.System.Drawing.Point(325, 122)
			Me.txtDoOfferWithdraw1.MaxLength = 11
			Me.txtDoOfferWithdraw1.Name = "txtDoOfferWithdraw1"
			Me.txtDoOfferWithdraw1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDoOfferWithdraw1.Size = New Global.System.Drawing.Size(196, 36)
			Me.txtDoOfferWithdraw1.TabIndex = 1136
			Me.txtDoOfferWithdraw1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label107.AutoSize = True
			Me.Label107.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label107.ForeColor = Global.System.Drawing.Color.Black
			Me.Label107.Location = New Global.System.Drawing.Point(447, 100)
			Me.Label107.Name = "Label107"
			Me.Label107.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label107.Size = New Global.System.Drawing.Size(74, 17)
			Me.Label107.TabIndex = 1135
			Me.Label107.Text = "اسنقبال 1"
			Me.ckbtnDoOfferWithdraw.AutoSize = True
			Me.ckbtnDoOfferWithdraw.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnDoOfferWithdraw.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnDoOfferWithdraw.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnDoOfferWithdraw.Location = New Global.System.Drawing.Point(468, 231)
			Me.ckbtnDoOfferWithdraw.Name = "ckbtnDoOfferWithdraw"
			Me.ckbtnDoOfferWithdraw.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnDoOfferWithdraw.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnDoOfferWithdraw.TabIndex = 1134
			Me.ckbtnDoOfferWithdraw.Text = "Auto"
			Me.ckbtnDoOfferWithdraw.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnDoOfferWithdraw.UseVisualStyleBackColor = False
			Me.btnDoOfferWithdraw.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnDoOfferWithdraw.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnDoOfferWithdraw.ForeColor = Global.System.Drawing.Color.Black
			Me.btnDoOfferWithdraw.Location = New Global.System.Drawing.Point(325, 230)
			Me.btnDoOfferWithdraw.Name = "btnDoOfferWithdraw"
			Me.btnDoOfferWithdraw.Size = New Global.System.Drawing.Size(196, 58)
			Me.btnDoOfferWithdraw.TabIndex = 1133
			Me.btnDoOfferWithdraw.Text = "after withdraw"
			Me.btnDoOfferWithdraw.UseVisualStyleBackColor = False
			Me.txtDelayToGet58.BackColor = Global.System.Drawing.Color.Blue
			Me.txtDelayToGet58.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDelayToGet58.ForeColor = Global.System.Drawing.Color.White
			Me.txtDelayToGet58.Location = New Global.System.Drawing.Point(212, 189)
			Me.txtDelayToGet58.Name = "txtDelayToGet58"
			Me.txtDelayToGet58.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDelayToGet58.Size = New Global.System.Drawing.Size(64, 24)
			Me.txtDelayToGet58.TabIndex = 1132
			Me.txtDelayToGet58.Text = "60"
			Me.txtDelayToGet58.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckbtnOCFreeTransfer.AutoSize = True
			Me.ckbtnOCFreeTransfer.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCFreeTransfer.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCFreeTransfer.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCFreeTransfer.Location = New Global.System.Drawing.Point(594, 28)
			Me.ckbtnOCFreeTransfer.Name = "ckbtnOCFreeTransfer"
			Me.ckbtnOCFreeTransfer.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCFreeTransfer.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCFreeTransfer.TabIndex = 1120
			Me.ckbtnOCFreeTransfer.Text = "Auto"
			Me.ckbtnOCFreeTransfer.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCFreeTransfer.UseVisualStyleBackColor = False
			Me.btnOCFreeTransfer.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCFreeTransfer.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCFreeTransfer.ForeColor = Global.System.Drawing.Color.Black
			Me.btnOCFreeTransfer.Location = New Global.System.Drawing.Point(325, 14)
			Me.btnOCFreeTransfer.Name = "btnOCFreeTransfer"
			Me.btnOCFreeTransfer.Size = New Global.System.Drawing.Size(333, 67)
			Me.btnOCFreeTransfer.TabIndex = 1119
			Me.btnOCFreeTransfer.Text = "عرض الصيف للتحويل مجانى"
			Me.btnOCFreeTransfer.UseVisualStyleBackColor = False
			Me.ckbtnOCGetBalPAy2.AutoSize = True
			Me.ckbtnOCGetBalPAy2.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCGetBalPAy2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCGetBalPAy2.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCGetBalPAy2.Location = New Global.System.Drawing.Point(847, 222)
			Me.ckbtnOCGetBalPAy2.Name = "ckbtnOCGetBalPAy2"
			Me.ckbtnOCGetBalPAy2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCGetBalPAy2.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCGetBalPAy2.TabIndex = 1118
			Me.ckbtnOCGetBalPAy2.Text = "Auto"
			Me.ckbtnOCGetBalPAy2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCGetBalPAy2.UseVisualStyleBackColor = False
			Me.ckbtnGetNormalBal.AutoSize = True
			Me.ckbtnGetNormalBal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnGetNormalBal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnGetNormalBal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnGetNormalBal.Location = New Global.System.Drawing.Point(847, 148)
			Me.ckbtnGetNormalBal.Name = "ckbtnGetNormalBal"
			Me.ckbtnGetNormalBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnGetNormalBal.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnGetNormalBal.TabIndex = 1116
			Me.ckbtnGetNormalBal.Text = "Auto"
			Me.ckbtnGetNormalBal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnGetNormalBal.UseVisualStyleBackColor = False
			Me.btnGetNormalBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetNormalBal.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnGetNormalBal.ForeColor = Global.System.Drawing.Color.Black
			Me.btnGetNormalBal.Location = New Global.System.Drawing.Point(663, 145)
			Me.btnGetNormalBal.Name = "btnGetNormalBal"
			Me.btnGetNormalBal.Size = New Global.System.Drawing.Size(245, 67)
			Me.btnGetNormalBal.TabIndex = 1115
			Me.btnGetNormalBal.Text = "رصيد عادى"
			Me.btnGetNormalBal.UseVisualStyleBackColor = False
			Me.ckbtnTranstop.AutoSize = True
			Me.ckbtnTranstop.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTranstop.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTranstop.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTranstop.Location = New Global.System.Drawing.Point(148, 238)
			Me.ckbtnTranstop.Name = "ckbtnTranstop"
			Me.ckbtnTranstop.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTranstop.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTranstop.TabIndex = 1114
			Me.ckbtnTranstop.Text = "Auto"
			Me.ckbtnTranstop.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTranstop.UseVisualStyleBackColor = False
			Me.btnTranstop.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTranstop.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTranstop.ForeColor = Global.System.Drawing.Color.Black
			Me.btnTranstop.Location = New Global.System.Drawing.Point(17, 230)
			Me.btnTranstop.Name = "btnTranstop"
			Me.btnTranstop.Size = New Global.System.Drawing.Size(187, 53)
			Me.btnTranstop.TabIndex = 1113
			Me.btnTranstop.Text = "top up all"
			Me.btnTranstop.UseVisualStyleBackColor = False
			Me.ckbtnTrans1000.AutoSize = True
			Me.ckbtnTrans1000.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTrans1000.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTrans1000.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTrans1000.Location = New Global.System.Drawing.Point(148, 177)
			Me.ckbtnTrans1000.Name = "ckbtnTrans1000"
			Me.ckbtnTrans1000.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTrans1000.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTrans1000.TabIndex = 1112
			Me.ckbtnTrans1000.Text = "Auto"
			Me.ckbtnTrans1000.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTrans1000.UseVisualStyleBackColor = False
			Me.btnTrans1000.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTrans1000.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTrans1000.ForeColor = Global.System.Drawing.Color.Black
			Me.btnTrans1000.Location = New Global.System.Drawing.Point(17, 171)
			Me.btnTrans1000.Name = "btnTrans1000"
			Me.btnTrans1000.Size = New Global.System.Drawing.Size(187, 58)
			Me.btnTrans1000.TabIndex = 1111
			Me.btnTrans1000.Text = "Wait Then Get"
			Me.btnTrans1000.UseVisualStyleBackColor = False
			Me.ckbtnTrans100.AutoSize = True
			Me.ckbtnTrans100.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTrans100.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTrans100.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTrans100.Location = New Global.System.Drawing.Point(148, 105)
			Me.ckbtnTrans100.Name = "ckbtnTrans100"
			Me.ckbtnTrans100.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTrans100.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTrans100.TabIndex = 1110
			Me.ckbtnTrans100.Text = "Auto"
			Me.ckbtnTrans100.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTrans100.UseVisualStyleBackColor = False
			Me.btnTrans100.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTrans100.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTrans100.ForeColor = Global.System.Drawing.Color.Black
			Me.btnTrans100.Location = New Global.System.Drawing.Point(17, 100)
			Me.btnTrans100.Name = "btnTrans100"
			Me.btnTrans100.Size = New Global.System.Drawing.Size(187, 65)
			Me.btnTrans100.TabIndex = 1109
			Me.btnTrans100.Text = "trans 2S"
			Me.btnTrans100.UseVisualStyleBackColor = False
			Me.btnOCGetBalPAy2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGetBalPAy2.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGetBalPAy2.Location = New Global.System.Drawing.Point(663, 218)
			Me.btnOCGetBalPAy2.Name = "btnOCGetBalPAy2"
			Me.btnOCGetBalPAy2.Size = New Global.System.Drawing.Size(245, 65)
			Me.btnOCGetBalPAy2.TabIndex = 1108
			Me.btnOCGetBalPAy2.Text = "استعلام عن رصيدالكاش"
			Me.btnOCGetBalPAy2.UseVisualStyleBackColor = False
			Me.ckbtnOCApply58.AutoSize = True
			Me.ckbtnOCApply58.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCApply58.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCApply58.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCApply58.Location = New Global.System.Drawing.Point(148, 29)
			Me.ckbtnOCApply58.Name = "ckbtnOCApply58"
			Me.ckbtnOCApply58.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCApply58.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCApply58.TabIndex = 1103
			Me.ckbtnOCApply58.Text = "Auto"
			Me.ckbtnOCApply58.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCApply58.UseVisualStyleBackColor = False
			Me.ckbtnOCGiftsCheckConf.AutoSize = True
			Me.ckbtnOCGiftsCheckConf.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCGiftsCheckConf.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCGiftsCheckConf.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCGiftsCheckConf.Location = New Global.System.Drawing.Point(847, 91)
			Me.ckbtnOCGiftsCheckConf.Name = "ckbtnOCGiftsCheckConf"
			Me.ckbtnOCGiftsCheckConf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCGiftsCheckConf.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCGiftsCheckConf.TabIndex = 1102
			Me.ckbtnOCGiftsCheckConf.Text = "Auto"
			Me.ckbtnOCGiftsCheckConf.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCGiftsCheckConf.UseVisualStyleBackColor = False
			Me.btnOCGiftsCheckConf.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGiftsCheckConf.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGiftsCheckConf.ForeColor = Global.System.Drawing.Color.Black
			Me.btnOCGiftsCheckConf.Location = New Global.System.Drawing.Point(662, 86)
			Me.btnOCGiftsCheckConf.Name = "btnOCGiftsCheckConf"
			Me.btnOCGiftsCheckConf.Size = New Global.System.Drawing.Size(246, 53)
			Me.btnOCGiftsCheckConf.TabIndex = 1101
			Me.btnOCGiftsCheckConf.Text = "Confirm"
			Me.btnOCGiftsCheckConf.UseVisualStyleBackColor = False
			Me.txtLoopSSOCG.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSOCG.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSOCG.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSOCG.Location = New Global.System.Drawing.Point(206, 57)
			Me.txtLoopSSOCG.Name = "txtLoopSSOCG"
			Me.txtLoopSSOCG.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSOCG.Size = New Global.System.Drawing.Size(44, 24)
			Me.txtLoopSSOCG.TabIndex = 1100
			Me.txtLoopSSOCG.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSOCG.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSOCG.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSOCG.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSOCG.Location = New Global.System.Drawing.Point(207, 29)
			Me.txtLoopFSOCG.Name = "txtLoopFSOCG"
			Me.txtLoopFSOCG.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSOCG.Size = New Global.System.Drawing.Size(43, 24)
			Me.txtLoopFSOCG.TabIndex = 1099
			Me.txtLoopFSOCG.Text = "1"
			Me.txtLoopFSOCG.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnOCApply58.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCApply58.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCApply58.ForeColor = Global.System.Drawing.Color.Black
			Me.btnOCApply58.Location = New Global.System.Drawing.Point(17, 21)
			Me.btnOCApply58.Name = "btnOCApply58"
			Me.btnOCApply58.Size = New Global.System.Drawing.Size(187, 73)
			Me.btnOCApply58.TabIndex = 1094
			Me.btnOCApply58.Text = "#58#"
			Me.btnOCApply58.UseVisualStyleBackColor = False
			Me.ckbtnOCGiftsCheck.AutoSize = True
			Me.ckbtnOCGiftsCheck.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOCGiftsCheck.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOCGiftsCheck.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOCGiftsCheck.Location = New Global.System.Drawing.Point(845, 21)
			Me.ckbtnOCGiftsCheck.Name = "ckbtnOCGiftsCheck"
			Me.ckbtnOCGiftsCheck.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOCGiftsCheck.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOCGiftsCheck.TabIndex = 1093
			Me.ckbtnOCGiftsCheck.Text = "Auto"
			Me.ckbtnOCGiftsCheck.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOCGiftsCheck.UseVisualStyleBackColor = False
			Me.btnOCGiftsCheck.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCGiftsCheck.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOCGiftsCheck.ForeColor = Global.System.Drawing.Color.Black
			Me.btnOCGiftsCheck.Location = New Global.System.Drawing.Point(662, 14)
			Me.btnOCGiftsCheck.Name = "btnOCGiftsCheck"
			Me.btnOCGiftsCheck.Size = New Global.System.Drawing.Size(246, 66)
			Me.btnOCGiftsCheck.TabIndex = 597
			Me.btnOCGiftsCheck.Text = "Check"
			Me.btnOCGiftsCheck.UseVisualStyleBackColor = False
			Me.tabOCSetup.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOCSetup.Controls.Add(Me.Label84)
			Me.tabOCSetup.Controls.Add(Me.txtEtsCashPass)
			Me.tabOCSetup.Controls.Add(Me.Label92)
			Me.tabOCSetup.Controls.Add(Me.txtOCOldPass)
			Me.tabOCSetup.Controls.Add(Me.Label88)
			Me.tabOCSetup.Controls.Add(Me.txtOTyrPass)
			Me.tabOCSetup.Controls.Add(Me.Label83)
			Me.tabOCSetup.Controls.Add(Me.txtOCPassMaster)
			Me.tabOCSetup.Controls.Add(Me.ckOCEditPass)
			Me.tabOCSetup.Controls.Add(Me.btnOCEditPass)
			Me.tabOCSetup.Controls.Add(Me.Label78)
			Me.tabOCSetup.Controls.Add(Me.txtOCNewPass)
			Me.tabOCSetup.Controls.Add(Me.Label77)
			Me.tabOCSetup.Controls.Add(Me.txtOCPass)
			Me.tabOCSetup.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOCSetup.Name = "tabOCSetup"
			Me.tabOCSetup.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOCSetup.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOCSetup.TabIndex = 22
			Me.tabOCSetup.Text = "OC Setup"
			Me.Label84.AutoSize = True
			Me.Label84.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label84.ForeColor = Global.System.Drawing.Color.Black
			Me.Label84.Location = New Global.System.Drawing.Point(188, 184)
			Me.Label84.Name = "Label84"
			Me.Label84.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label84.Size = New Global.System.Drawing.Size(163, 17)
			Me.Label84.TabIndex = 1055
			Me.Label84.Text = "كلمة مرور اتصالات كاش"
			Me.txtEtsCashPass.BackColor = Global.System.Drawing.Color.White
			Me.txtEtsCashPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtEtsCashPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtEtsCashPass.Location = New Global.System.Drawing.Point(191, 216)
			Me.txtEtsCashPass.MaxLength = 11
			Me.txtEtsCashPass.Name = "txtEtsCashPass"
			Me.txtEtsCashPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEtsCashPass.Size = New Global.System.Drawing.Size(151, 27)
			Me.txtEtsCashPass.TabIndex = 1054
			Me.txtEtsCashPass.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label92.AutoSize = True
			Me.Label92.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label92.ForeColor = Global.System.Drawing.Color.Black
			Me.Label92.Location = New Global.System.Drawing.Point(783, 29)
			Me.Label92.Name = "Label92"
			Me.Label92.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label92.Size = New Global.System.Drawing.Size(127, 17)
			Me.Label92.TabIndex = 1053
			Me.Label92.Text = "كلمة السر القديمة"
			Me.txtOCOldPass.BackColor = Global.System.Drawing.Color.White
			Me.txtOCOldPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOCOldPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCOldPass.Location = New Global.System.Drawing.Point(668, 23)
			Me.txtOCOldPass.MaxLength = 6
			Me.txtOCOldPass.Name = "txtOCOldPass"
			Me.txtOCOldPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCOldPass.Size = New Global.System.Drawing.Size(109, 27)
			Me.txtOCOldPass.TabIndex = 1052
			Me.Label88.AutoSize = True
			Me.Label88.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label88.ForeColor = Global.System.Drawing.Color.Black
			Me.Label88.Location = New Global.System.Drawing.Point(36, 188)
			Me.Label88.Name = "Label88"
			Me.Label88.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label88.Size = New Global.System.Drawing.Size(104, 17)
			Me.Label88.TabIndex = 1051
			Me.Label88.Text = "كلمة مرور الهوا"
			Me.txtOTyrPass.BackColor = Global.System.Drawing.Color.White
			Me.txtOTyrPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOTyrPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOTyrPass.Location = New Global.System.Drawing.Point(24, 216)
			Me.txtOTyrPass.MaxLength = 11
			Me.txtOTyrPass.Name = "txtOTyrPass"
			Me.txtOTyrPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOTyrPass.Size = New Global.System.Drawing.Size(139, 27)
			Me.txtOTyrPass.TabIndex = 1050
			Me.txtOTyrPass.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label83.AutoSize = True
			Me.Label83.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label83.ForeColor = Global.System.Drawing.Color.Black
			Me.Label83.Location = New Global.System.Drawing.Point(36, 110)
			Me.Label83.Name = "Label83"
			Me.Label83.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label83.Size = New Global.System.Drawing.Size(115, 17)
			Me.Label83.TabIndex = 1049
			Me.Label83.Text = "كلمة مرور ماستر"
			Me.txtOCPassMaster.BackColor = Global.System.Drawing.Color.White
			Me.txtOCPassMaster.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCPassMaster.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCPassMaster.Location = New Global.System.Drawing.Point(24, 138)
			Me.txtOCPassMaster.MaxLength = 11
			Me.txtOCPassMaster.Name = "txtOCPassMaster"
			Me.txtOCPassMaster.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCPassMaster.Size = New Global.System.Drawing.Size(139, 27)
			Me.txtOCPassMaster.TabIndex = 1048
			Me.txtOCPassMaster.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckOCEditPass.AutoSize = True
			Me.ckOCEditPass.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckOCEditPass.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckOCEditPass.ForeColor = Global.System.Drawing.Color.Black
			Me.ckOCEditPass.Location = New Global.System.Drawing.Point(866, 98)
			Me.ckOCEditPass.Name = "ckOCEditPass"
			Me.ckOCEditPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckOCEditPass.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckOCEditPass.TabIndex = 1047
			Me.ckOCEditPass.Text = "Auto"
			Me.ckOCEditPass.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckOCEditPass.UseVisualStyleBackColor = False
			Me.btnOCEditPass.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOCEditPass.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOCEditPass.Location = New Global.System.Drawing.Point(668, 89)
			Me.btnOCEditPass.Name = "btnOCEditPass"
			Me.btnOCEditPass.Size = New Global.System.Drawing.Size(192, 32)
			Me.btnOCEditPass.TabIndex = 1046
			Me.btnOCEditPass.Text = "تعديل كلمة السر"
			Me.btnOCEditPass.UseVisualStyleBackColor = False
			Me.Label78.AutoSize = True
			Me.Label78.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label78.ForeColor = Global.System.Drawing.Color.Black
			Me.Label78.Location = New Global.System.Drawing.Point(783, 62)
			Me.Label78.Name = "Label78"
			Me.Label78.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label78.Size = New Global.System.Drawing.Size(128, 17)
			Me.Label78.TabIndex = 1045
			Me.Label78.Text = "كلمة السر الجديدة"
			Me.txtOCNewPass.BackColor = Global.System.Drawing.Color.White
			Me.txtOCNewPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOCNewPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCNewPass.Location = New Global.System.Drawing.Point(668, 56)
			Me.txtOCNewPass.MaxLength = 6
			Me.txtOCNewPass.Name = "txtOCNewPass"
			Me.txtOCNewPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCNewPass.Size = New Global.System.Drawing.Size(109, 27)
			Me.txtOCNewPass.TabIndex = 1044
			Me.Label77.AutoSize = True
			Me.Label77.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label77.ForeColor = Global.System.Drawing.Color.Black
			Me.Label77.Location = New Global.System.Drawing.Point(18, 24)
			Me.Label77.Name = "Label77"
			Me.Label77.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label77.Size = New Global.System.Drawing.Size(145, 17)
			Me.Label77.TabIndex = 917
			Me.Label77.Text = "كلمة مرور اورنج كاش"
			Me.txtOCPass.BackColor = Global.System.Drawing.Color.White
			Me.txtOCPass.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCPass.Location = New Global.System.Drawing.Point(21, 56)
			Me.txtOCPass.MaxLength = 11
			Me.txtOCPass.Name = "txtOCPass"
			Me.txtOCPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCPass.Size = New Global.System.Drawing.Size(139, 27)
			Me.txtOCPass.TabIndex = 916
			Me.txtOCPass.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.tabOrngInv.BackColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.tabOrngInv.Controls.Add(Me.ckbtnOtransRun)
			Me.tabOrngInv.Controls.Add(Me.ckbtnGetOrngBal)
			Me.tabOrngInv.Controls.Add(Me.dataViewGrid)
			Me.tabOrngInv.Controls.Add(Me.btnOrngAccQry)
			Me.tabOrngInv.Controls.Add(Me.btnGetOrngBal)
			Me.tabOrngInv.Controls.Add(Me.btnGetOrngBalAcc)
			Me.tabOrngInv.Controls.Add(Me.btnSaveAS3)
			Me.tabOrngInv.Controls.Add(Me.btnExport3)
			Me.tabOrngInv.Controls.Add(Me.btnOtransRun)
			Me.tabOrngInv.Controls.Add(Me.Label30)
			Me.tabOrngInv.Controls.Add(Me.txtOTotalTransQ)
			Me.tabOrngInv.Controls.Add(Me.Label25)
			Me.tabOrngInv.Controls.Add(Me.txtOtotalTrans)
			Me.tabOrngInv.Controls.Add(Me.txtOtransRem)
			Me.tabOrngInv.Controls.Add(Me.txtOtransMP)
			Me.tabOrngInv.Controls.Add(Me.txtOtransACC)
			Me.tabOrngInv.Controls.Add(Me.txtOtransTN)
			Me.tabOrngInv.Controls.Add(Me.Label29)
			Me.tabOrngInv.Controls.Add(Me.Label28)
			Me.tabOrngInv.Controls.Add(Me.Label27)
			Me.tabOrngInv.Controls.Add(Me.Label26)
			Me.tabOrngInv.Controls.Add(Me.lblSavePath3)
			Me.tabOrngInv.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabOrngInv.Name = "tabOrngInv"
			Me.tabOrngInv.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabOrngInv.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabOrngInv.TabIndex = 10
			Me.tabOrngInv.Text = "Orng Inv"
			Me.ckbtnOtransRun.AutoSize = True
			Me.ckbtnOtransRun.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnOtransRun.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnOtransRun.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnOtransRun.Location = New Global.System.Drawing.Point(847, 79)
			Me.ckbtnOtransRun.Name = "ckbtnOtransRun"
			Me.ckbtnOtransRun.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnOtransRun.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnOtransRun.TabIndex = 1095
			Me.ckbtnOtransRun.Text = "Auto"
			Me.ckbtnOtransRun.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnOtransRun.UseVisualStyleBackColor = False
			Me.ckbtnGetOrngBal.AutoSize = True
			Me.ckbtnGetOrngBal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnGetOrngBal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnGetOrngBal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnGetOrngBal.Location = New Global.System.Drawing.Point(545, 10)
			Me.ckbtnGetOrngBal.Name = "ckbtnGetOrngBal"
			Me.ckbtnGetOrngBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnGetOrngBal.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnGetOrngBal.TabIndex = 1094
			Me.ckbtnGetOrngBal.Text = "Auto"
			Me.ckbtnGetOrngBal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnGetOrngBal.UseVisualStyleBackColor = False
			Me.dataViewGrid.AllowUserToAddRows = False
			Me.dataViewGrid.AllowUserToDeleteRows = False
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.dataViewGrid.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.dataViewGrid.BackgroundColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dataViewGrid.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGrid.DefaultCellStyle = dataGridViewCellStyle3
			Me.dataViewGrid.Location = New Global.System.Drawing.Point(6, 134)
			Me.dataViewGrid.Name = "dataViewGrid"
			Me.dataViewGrid.[ReadOnly] = True
			Me.dataViewGrid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dataViewGrid.RowHeadersWidth = 51
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dataViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle5
			Me.dataViewGrid.Size = New Global.System.Drawing.Size(721, 155)
			Me.dataViewGrid.TabIndex = 1012
			Me.btnOrngAccQry.Location = New Global.System.Drawing.Point(6, 40)
			Me.btnOrngAccQry.Name = "btnOrngAccQry"
			Me.btnOrngAccQry.Size = New Global.System.Drawing.Size(195, 27)
			Me.btnOrngAccQry.TabIndex = 1010
			Me.btnOrngAccQry.Text = "استعلام عن العمليات الCOMة"
			Me.btnOrngAccQry.UseVisualStyleBackColor = True
			Me.btnGetOrngBal.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetOrngBal.Location = New Global.System.Drawing.Point(492, 6)
			Me.btnGetOrngBal.Name = "btnGetOrngBal"
			Me.btnGetOrngBal.Size = New Global.System.Drawing.Size(110, 114)
			Me.btnGetOrngBal.TabIndex = 1009
			Me.btnGetOrngBal.Text = "استعلام الرصيد العادى"
			Me.btnGetOrngBal.UseVisualStyleBackColor = True
			Me.btnGetOrngBalAcc.Location = New Global.System.Drawing.Point(446, 152)
			Me.btnGetOrngBalAcc.Name = "btnGetOrngBalAcc"
			Me.btnGetOrngBalAcc.Size = New Global.System.Drawing.Size(176, 27)
			Me.btnGetOrngBalAcc.TabIndex = 1008
			Me.btnGetOrngBalAcc.Text = "استعلام الرصيد برقم حساب"
			Me.btnGetOrngBalAcc.UseVisualStyleBackColor = True
			Me.btnSaveAS3.Location = New Global.System.Drawing.Point(474, 232)
			Me.btnSaveAS3.Name = "btnSaveAS3"
			Me.btnSaveAS3.Size = New Global.System.Drawing.Size(45, 38)
			Me.btnSaveAS3.TabIndex = 1002
			Me.btnSaveAS3.Text = "مكان الحفظ"
			Me.btnSaveAS3.UseVisualStyleBackColor = True
			Me.btnExport3.Location = New Global.System.Drawing.Point(474, 266)
			Me.btnExport3.Name = "btnExport3"
			Me.btnExport3.Size = New Global.System.Drawing.Size(45, 23)
			Me.btnExport3.TabIndex = 1001
			Me.btnExport3.Text = "تصدير"
			Me.btnExport3.UseVisualStyleBackColor = True
			Me.btnOtransRun.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOtransRun.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnOtransRun.ForeColor = Global.System.Drawing.Color.Black
			Me.btnOtransRun.Location = New Global.System.Drawing.Point(610, 70)
			Me.btnOtransRun.Name = "btnOtransRun"
			Me.btnOtransRun.Size = New Global.System.Drawing.Size(300, 54)
			Me.btnOtransRun.TabIndex = 1000
			Me.btnOtransRun.Text = "بدا التحويل"
			Me.btnOtransRun.UseVisualStyleBackColor = False
			Me.Label30.AutoSize = True
			Me.Label30.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label30.ForeColor = Global.System.Drawing.Color.Black
			Me.Label30.Location = New Global.System.Drawing.Point(126, 107)
			Me.Label30.Name = "Label30"
			Me.Label30.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label30.Size = New Global.System.Drawing.Size(138, 17)
			Me.Label30.TabIndex = 999
			Me.Label30.Text = "عدد عمليات التحويل"
			Me.txtOTotalTransQ.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 128)
			Me.txtOTotalTransQ.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOTotalTransQ.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOTotalTransQ.Location = New Global.System.Drawing.Point(6, 101)
			Me.txtOTotalTransQ.MaxLength = 11
			Me.txtOTotalTransQ.Name = "txtOTotalTransQ"
			Me.txtOTotalTransQ.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOTotalTransQ.Size = New Global.System.Drawing.Size(114, 27)
			Me.txtOTotalTransQ.TabIndex = 998
			Me.txtOTotalTransQ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label25.AutoSize = True
			Me.Label25.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label25.ForeColor = Global.System.Drawing.Color.Black
			Me.Label25.Location = New Global.System.Drawing.Point(126, 79)
			Me.Label25.Name = "Label25"
			Me.Label25.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label25.Size = New Global.System.Drawing.Size(150, 17)
			Me.Label25.TabIndex = 997
			Me.Label25.Text = "اجمالى المبلغ المحول"
			Me.txtOtotalTrans.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 128)
			Me.txtOtotalTrans.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtotalTrans.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOtotalTrans.Location = New Global.System.Drawing.Point(6, 73)
			Me.txtOtotalTrans.MaxLength = 11
			Me.txtOtotalTrans.Name = "txtOtotalTrans"
			Me.txtOtotalTrans.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOtotalTrans.Size = New Global.System.Drawing.Size(114, 27)
			Me.txtOtotalTrans.TabIndex = 996
			Me.txtOtotalTrans.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOtransRem.BackColor = Global.System.Drawing.Color.White
			Me.txtOtransRem.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtransRem.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOtransRem.Location = New Global.System.Drawing.Point(612, 34)
			Me.txtOtransRem.MaxLength = 11
			Me.txtOtransRem.Name = "txtOtransRem"
			Me.txtOtransRem.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOtransRem.Size = New Global.System.Drawing.Size(87, 27)
			Me.txtOtransRem.TabIndex = 993
			Me.txtOtransRem.Text = "0.15"
			Me.txtOtransRem.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOtransMP.BackColor = Global.System.Drawing.Color.White
			Me.txtOtransMP.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtransMP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOtransMP.Location = New Global.System.Drawing.Point(612, 7)
			Me.txtOtransMP.MaxLength = 11
			Me.txtOtransMP.Name = "txtOtransMP"
			Me.txtOtransMP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOtransMP.Size = New Global.System.Drawing.Size(87, 27)
			Me.txtOtransMP.TabIndex = 992
			Me.txtOtransMP.Text = "0"
			Me.txtOtransMP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOtransACC.BackColor = Global.System.Drawing.Color.White
			Me.txtOtransACC.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtransACC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOtransACC.Location = New Global.System.Drawing.Point(6, 12)
			Me.txtOtransACC.MaxLength = 11
			Me.txtOtransACC.Name = "txtOtransACC"
			Me.txtOtransACC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOtransACC.Size = New Global.System.Drawing.Size(195, 27)
			Me.txtOtransACC.TabIndex = 991
			Me.txtOtransACC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtOtransTN.BackColor = Global.System.Drawing.Color.White
			Me.txtOtransTN.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtransTN.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOtransTN.Location = New Global.System.Drawing.Point(474, 202)
			Me.txtOtransTN.MaxLength = 11
			Me.txtOtransTN.Name = "txtOtransTN"
			Me.txtOtransTN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOtransTN.Size = New Global.System.Drawing.Size(145, 27)
			Me.txtOtransTN.TabIndex = 990
			Me.txtOtransTN.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label29.AutoSize = True
			Me.Label29.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label29.ForeColor = Global.System.Drawing.Color.Black
			Me.Label29.Location = New Global.System.Drawing.Point(705, 13)
			Me.Label29.Name = "Label29"
			Me.Label29.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label29.Size = New Global.System.Drawing.Size(123, 17)
			Me.Label29.TabIndex = 989
			Me.Label29.Text = "المبلغ المراد دفعة"
			Me.Label28.AutoSize = True
			Me.Label28.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label28.ForeColor = Global.System.Drawing.Color.Black
			Me.Label28.Location = New Global.System.Drawing.Point(705, 38)
			Me.Label28.Name = "Label28"
			Me.Label28.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label28.Size = New Global.System.Drawing.Size(133, 17)
			Me.Label28.TabIndex = 987
			Me.Label28.Text = "المبلغ الباقى بالخط"
			Me.Label27.AutoSize = True
			Me.Label27.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label27.ForeColor = Global.System.Drawing.Color.Black
			Me.Label27.Location = New Global.System.Drawing.Point(204, 14)
			Me.Label27.Name = "Label27"
			Me.Label27.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label27.Size = New Global.System.Drawing.Size(62, 17)
			Me.Label27.TabIndex = 986
			Me.Label27.Text = "الحساب"
			Me.Label26.AutoSize = True
			Me.Label26.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label26.ForeColor = Global.System.Drawing.Color.Black
			Me.Label26.Location = New Global.System.Drawing.Point(531, 182)
			Me.Label26.Name = "Label26"
			Me.Label26.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label26.Size = New Global.System.Drawing.Size(81, 17)
			Me.Label26.TabIndex = 985
			Me.Label26.Text = "رقم العملية"
			Me.lblSavePath3.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 128)
			Me.lblSavePath3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblSavePath3.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSavePath3.ForeColor = Global.System.Drawing.Color.Black
			Me.lblSavePath3.Location = New Global.System.Drawing.Point(521, 232)
			Me.lblSavePath3.Name = "lblSavePath3"
			Me.lblSavePath3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblSavePath3.Size = New Global.System.Drawing.Size(98, 57)
			Me.lblSavePath3.TabIndex = 1003
			Me.lblSavePath3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.TabPage1.Controls.Add(Me.ckbtnMacro)
			Me.TabPage1.Controls.Add(Me.btnMacro)
			Me.TabPage1.Controls.Add(Me.txtMacro16)
			Me.TabPage1.Controls.Add(Me.txtMacro15)
			Me.TabPage1.Controls.Add(Me.txtMacro9)
			Me.TabPage1.Controls.Add(Me.txtMacro14)
			Me.TabPage1.Controls.Add(Me.txtMacro13)
			Me.TabPage1.Controls.Add(Me.txtMacro10)
			Me.TabPage1.Controls.Add(Me.txtMacro11)
			Me.TabPage1.Controls.Add(Me.txtMacro12)
			Me.TabPage1.Controls.Add(Me.txtMacro8)
			Me.TabPage1.Controls.Add(Me.txtMacro7)
			Me.TabPage1.Controls.Add(Me.txtMacro1)
			Me.TabPage1.Controls.Add(Me.txtMacro6)
			Me.TabPage1.Controls.Add(Me.txtMacro5)
			Me.TabPage1.Controls.Add(Me.txtMacro2)
			Me.TabPage1.Controls.Add(Me.txtMacro3)
			Me.TabPage1.Controls.Add(Me.txtMacro4)
			Me.TabPage1.Controls.Add(Me.txtReplyBy7)
			Me.TabPage1.Controls.Add(Me.btnReplyBy7)
			Me.TabPage1.Controls.Add(Me.txtReplyBy6)
			Me.TabPage1.Controls.Add(Me.btnReplyBy6)
			Me.TabPage1.Controls.Add(Me.txtUssdc10)
			Me.TabPage1.Controls.Add(Me.txtReplyBy0)
			Me.TabPage1.Controls.Add(Me.btnRunUssd5)
			Me.TabPage1.Controls.Add(Me.btnReplyBy0)
			Me.TabPage1.Controls.Add(Me.txtUssdc5)
			Me.TabPage1.Controls.Add(Me.txtReplyBy5)
			Me.TabPage1.Controls.Add(Me.btnRunUssd10)
			Me.TabPage1.Controls.Add(Me.btnReplyBy5)
			Me.TabPage1.Controls.Add(Me.txtUssdc7)
			Me.TabPage1.Controls.Add(Me.txtReplyBy4)
			Me.TabPage1.Controls.Add(Me.btnRunUssd6)
			Me.TabPage1.Controls.Add(Me.btnReplyBy4)
			Me.TabPage1.Controls.Add(Me.txtUssdc6)
			Me.TabPage1.Controls.Add(Me.btnRunUssd7)
			Me.TabPage1.Controls.Add(Me.btnRunUssd8)
			Me.TabPage1.Controls.Add(Me.txtUssdc8)
			Me.TabPage1.Controls.Add(Me.btnRunUssd)
			Me.TabPage1.Controls.Add(Me.btnRunUssd2)
			Me.TabPage1.Controls.Add(Me.btnRunUssd3)
			Me.TabPage1.Controls.Add(Me.btnRunUssd4)
			Me.TabPage1.Controls.Add(Me.btnRunUssd9)
			Me.TabPage1.Controls.Add(Me.txtUssd)
			Me.TabPage1.Controls.Add(Me.txtUssdc2)
			Me.TabPage1.Controls.Add(Me.txtUssdc3)
			Me.TabPage1.Controls.Add(Me.txtUssdc4)
			Me.TabPage1.Controls.Add(Me.txtUssdc9)
			Me.TabPage1.Controls.Add(Me.txtReplyBy)
			Me.TabPage1.Controls.Add(Me.txtReplyBy2)
			Me.TabPage1.Controls.Add(Me.txtReplyBy3)
			Me.TabPage1.Controls.Add(Me.btnReplyBy)
			Me.TabPage1.Controls.Add(Me.btnReplyBy2)
			Me.TabPage1.Controls.Add(Me.btnReplyBy3)
			Me.TabPage1.Controls.Add(Me.btnRunUssdGG)
			Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage1.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "Nrm Ussd"
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.ckbtnMacro.AutoSize = True
			Me.ckbtnMacro.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnMacro.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnMacro.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnMacro.Location = New Global.System.Drawing.Point(761, 217)
			Me.ckbtnMacro.Name = "ckbtnMacro"
			Me.ckbtnMacro.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnMacro.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnMacro.TabIndex = 1044
			Me.ckbtnMacro.Text = "Auto"
			Me.ckbtnMacro.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnMacro.UseVisualStyleBackColor = False
			Me.btnMacro.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnMacro.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnMacro.ForeColor = Global.System.Drawing.Color.Black
			Me.btnMacro.Location = New Global.System.Drawing.Point(646, 213)
			Me.btnMacro.Name = "btnMacro"
			Me.btnMacro.Size = New Global.System.Drawing.Size(168, 70)
			Me.btnMacro.TabIndex = 971
			Me.btnMacro.Text = "Macro"
			Me.btnMacro.UseVisualStyleBackColor = False
			Me.txtMacro16.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro16.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro16.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro16.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro16.Location = New Global.System.Drawing.Point(588, 242)
			Me.txtMacro16.MaxLength = 2
			Me.txtMacro16.Name = "txtMacro16"
			Me.txtMacro16.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro16.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro16.TabIndex = 970
			Me.txtMacro16.TabStop = False
			Me.txtMacro16.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro15.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro15.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro15.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro15.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro15.Location = New Global.System.Drawing.Point(587, 209)
			Me.txtMacro15.MaxLength = 2
			Me.txtMacro15.Name = "txtMacro15"
			Me.txtMacro15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro15.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro15.TabIndex = 969
			Me.txtMacro15.TabStop = False
			Me.txtMacro15.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro9.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro9.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro9.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMacro9.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro9.Location = New Global.System.Drawing.Point(587, 12)
			Me.txtMacro9.MaxLength = 1
			Me.txtMacro9.Name = "txtMacro9"
			Me.txtMacro9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro9.Size = New Global.System.Drawing.Size(37, 30)
			Me.txtMacro9.TabIndex = 968
			Me.txtMacro9.TabStop = False
			Me.txtMacro9.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro14.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro14.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro14.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro14.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro14.Location = New Global.System.Drawing.Point(587, 176)
			Me.txtMacro14.MaxLength = 1
			Me.txtMacro14.Name = "txtMacro14"
			Me.txtMacro14.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro14.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro14.TabIndex = 967
			Me.txtMacro14.TabStop = False
			Me.txtMacro14.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro13.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro13.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro13.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro13.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro13.Location = New Global.System.Drawing.Point(587, 144)
			Me.txtMacro13.MaxLength = 1
			Me.txtMacro13.Name = "txtMacro13"
			Me.txtMacro13.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro13.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro13.TabIndex = 966
			Me.txtMacro13.TabStop = False
			Me.txtMacro13.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro10.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro10.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro10.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMacro10.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro10.Location = New Global.System.Drawing.Point(587, 45)
			Me.txtMacro10.MaxLength = 1
			Me.txtMacro10.Name = "txtMacro10"
			Me.txtMacro10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro10.Size = New Global.System.Drawing.Size(37, 30)
			Me.txtMacro10.TabIndex = 963
			Me.txtMacro10.TabStop = False
			Me.txtMacro10.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro11.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro11.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro11.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro11.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro11.Location = New Global.System.Drawing.Point(587, 79)
			Me.txtMacro11.MaxLength = 1
			Me.txtMacro11.Name = "txtMacro11"
			Me.txtMacro11.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro11.Size = New Global.System.Drawing.Size(37, 27)
			Me.txtMacro11.TabIndex = 964
			Me.txtMacro11.TabStop = False
			Me.txtMacro11.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro12.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro12.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro12.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro12.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro12.Location = New Global.System.Drawing.Point(587, 111)
			Me.txtMacro12.MaxLength = 1
			Me.txtMacro12.Name = "txtMacro12"
			Me.txtMacro12.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro12.Size = New Global.System.Drawing.Size(37, 27)
			Me.txtMacro12.TabIndex = 965
			Me.txtMacro12.TabStop = False
			Me.txtMacro12.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro8.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro8.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro8.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro8.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro8.Location = New Global.System.Drawing.Point(396, 217)
			Me.txtMacro8.MaxLength = 2
			Me.txtMacro8.Name = "txtMacro8"
			Me.txtMacro8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro8.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro8.TabIndex = 962
			Me.txtMacro8.TabStop = False
			Me.txtMacro8.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro7.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro7.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro7.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro7.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro7.Location = New Global.System.Drawing.Point(396, 189)
			Me.txtMacro7.MaxLength = 2
			Me.txtMacro7.Name = "txtMacro7"
			Me.txtMacro7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro7.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro7.TabIndex = 961
			Me.txtMacro7.TabStop = False
			Me.txtMacro7.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro1.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro1.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMacro1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro1.Location = New Global.System.Drawing.Point(396, 8)
			Me.txtMacro1.MaxLength = 1
			Me.txtMacro1.Name = "txtMacro1"
			Me.txtMacro1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro1.Size = New Global.System.Drawing.Size(37, 30)
			Me.txtMacro1.TabIndex = 960
			Me.txtMacro1.TabStop = False
			Me.txtMacro1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro6.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro6.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro6.Location = New Global.System.Drawing.Point(396, 161)
			Me.txtMacro6.MaxLength = 1
			Me.txtMacro6.Name = "txtMacro6"
			Me.txtMacro6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro6.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro6.TabIndex = 959
			Me.txtMacro6.TabStop = False
			Me.txtMacro6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro5.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro5.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro5.Location = New Global.System.Drawing.Point(396, 132)
			Me.txtMacro5.MaxLength = 1
			Me.txtMacro5.Name = "txtMacro5"
			Me.txtMacro5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro5.Size = New Global.System.Drawing.Size(36, 27)
			Me.txtMacro5.TabIndex = 958
			Me.txtMacro5.TabStop = False
			Me.txtMacro5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro2.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro2.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMacro2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro2.Location = New Global.System.Drawing.Point(396, 40)
			Me.txtMacro2.MaxLength = 1
			Me.txtMacro2.Name = "txtMacro2"
			Me.txtMacro2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro2.Size = New Global.System.Drawing.Size(37, 30)
			Me.txtMacro2.TabIndex = 955
			Me.txtMacro2.TabStop = False
			Me.txtMacro2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro3.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro3.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro3.Location = New Global.System.Drawing.Point(396, 74)
			Me.txtMacro3.MaxLength = 1
			Me.txtMacro3.Name = "txtMacro3"
			Me.txtMacro3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro3.Size = New Global.System.Drawing.Size(37, 27)
			Me.txtMacro3.TabIndex = 956
			Me.txtMacro3.TabStop = False
			Me.txtMacro3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMacro4.BackColor = Global.System.Drawing.Color.White
			Me.txtMacro4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMacro4.Font = New Global.System.Drawing.Font("Tahoma", 12.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMacro4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMacro4.Location = New Global.System.Drawing.Point(396, 103)
			Me.txtMacro4.MaxLength = 1
			Me.txtMacro4.Name = "txtMacro4"
			Me.txtMacro4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMacro4.Size = New Global.System.Drawing.Size(37, 27)
			Me.txtMacro4.TabIndex = 957
			Me.txtMacro4.TabStop = False
			Me.txtMacro4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtReplyBy7.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy7.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy7.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy7.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.txtReplyBy7.Location = New Global.System.Drawing.Point(456, 246)
			Me.txtReplyBy7.MaxLength = 2
			Me.txtReplyBy7.Name = "txtReplyBy7"
			Me.txtReplyBy7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy7.Size = New Global.System.Drawing.Size(36, 17)
			Me.txtReplyBy7.TabIndex = 954
			Me.txtReplyBy7.TabStop = False
			Me.txtReplyBy7.Text = "7"
			Me.txtReplyBy7.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy7.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy7.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy7.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy7.Location = New Global.System.Drawing.Point(445, 240)
			Me.btnReplyBy7.Name = "btnReplyBy7"
			Me.btnReplyBy7.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy7.TabIndex = 953
			Me.btnReplyBy7.Text = "Reply"
			Me.btnReplyBy7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy7.UseVisualStyleBackColor = False
			Me.txtReplyBy6.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyBy6.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyBy6.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyBy6.ForeColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			Me.txtReplyBy6.Location = New Global.System.Drawing.Point(456, 215)
			Me.txtReplyBy6.MaxLength = 2
			Me.txtReplyBy6.Name = "txtReplyBy6"
			Me.txtReplyBy6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyBy6.Size = New Global.System.Drawing.Size(36, 17)
			Me.txtReplyBy6.TabIndex = 952
			Me.txtReplyBy6.TabStop = False
			Me.txtReplyBy6.Text = "6"
			Me.txtReplyBy6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnReplyBy6.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnReplyBy6.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btnReplyBy6.ForeColor = Global.System.Drawing.Color.Black
			Me.btnReplyBy6.Location = New Global.System.Drawing.Point(445, 207)
			Me.btnReplyBy6.Name = "btnReplyBy6"
			Me.btnReplyBy6.Size = New Global.System.Drawing.Size(112, 33)
			Me.btnReplyBy6.TabIndex = 951
			Me.btnReplyBy6.Text = "Reply"
			Me.btnReplyBy6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.btnReplyBy6.UseVisualStyleBackColor = False
			Me.TabPage7.BackColor = Global.System.Drawing.Color.PaleGreen
			Me.TabPage7.Controls.Add(Me.btnFromMainToAll)
			Me.TabPage7.Controls.Add(Me.ckbtnECRun777111)
			Me.TabPage7.Controls.Add(Me.btnECConvertTocash)
			Me.TabPage7.Controls.Add(Me.btnECRun777111)
			Me.TabPage7.Controls.Add(Me.TempCheck)
			Me.TabPage7.Controls.Add(Me.ckbtnAutoES_Seres)
			Me.TabPage7.Controls.Add(Me.btnAutoES_Seres)
			Me.TabPage7.Controls.Add(Me.Label104)
			Me.TabPage7.Controls.Add(Me.Label106)
			Me.TabPage7.Controls.Add(Me.txtESAdd)
			Me.TabPage7.Controls.Add(Me.txtESSub)
			Me.TabPage7.Controls.Add(Me.btnAutoVCnormECOne)
			Me.TabPage7.Controls.Add(Me.ckbtnGetBal2EC)
			Me.TabPage7.Controls.Add(Me.lblMainEC)
			Me.TabPage7.Controls.Add(Me.Label42)
			Me.TabPage7.Controls.Add(Me.Label39)
			Me.TabPage7.Controls.Add(Me.Label40)
			Me.TabPage7.Controls.Add(Me.btnAutoVCnormEC)
			Me.TabPage7.Controls.Add(Me.txtCashNextMasterEC)
			Me.TabPage7.Controls.Add(Me.txtMonyMnEC)
			Me.TabPage7.Controls.Add(Me.btnGetBal2EC)
			Me.TabPage7.Controls.Add(Me.Label38)
			Me.TabPage7.Controls.Add(Me.txtPassEC)
			Me.TabPage7.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage7.Name = "TabPage7"
			Me.TabPage7.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage7.TabIndex = 12
			Me.TabPage7.Text = "Ets"
			Me.btnFromMainToAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnFromMainToAll.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnFromMainToAll.Location = New Global.System.Drawing.Point(341, 120)
			Me.btnFromMainToAll.Name = "btnFromMainToAll"
			Me.btnFromMainToAll.Size = New Global.System.Drawing.Size(147, 80)
			Me.btnFromMainToAll.TabIndex = 1117
			Me.btnFromMainToAll.Text = "تحويل من الاساسى للكل"
			Me.btnFromMainToAll.UseVisualStyleBackColor = False
			Me.ckbtnECRun777111.AutoSize = True
			Me.ckbtnECRun777111.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.ckbtnECRun777111.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnECRun777111.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnECRun777111.Location = New Global.System.Drawing.Point(150, 23)
			Me.ckbtnECRun777111.Name = "ckbtnECRun777111"
			Me.ckbtnECRun777111.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnECRun777111.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnECRun777111.TabIndex = 1116
			Me.ckbtnECRun777111.Text = "Auto"
			Me.ckbtnECRun777111.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnECRun777111.UseVisualStyleBackColor = False
			Me.btnECConvertTocash.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnECConvertTocash.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnECConvertTocash.ForeColor = Global.System.Drawing.Color.Black
			Me.btnECConvertTocash.Location = New Global.System.Drawing.Point(22, 94)
			Me.btnECConvertTocash.Name = "btnECConvertTocash"
			Me.btnECConvertTocash.Size = New Global.System.Drawing.Size(181, 61)
			Me.btnECConvertTocash.TabIndex = 1115
			Me.btnECConvertTocash.Text = "CashBack to Cash"
			Me.btnECConvertTocash.UseVisualStyleBackColor = False
			Me.btnECRun777111.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnECRun777111.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnECRun777111.ForeColor = Global.System.Drawing.Color.Black
			Me.btnECRun777111.Location = New Global.System.Drawing.Point(22, 16)
			Me.btnECRun777111.Name = "btnECRun777111"
			Me.btnECRun777111.Size = New Global.System.Drawing.Size(181, 65)
			Me.btnECRun777111.TabIndex = 1114
			Me.btnECRun777111.Text = "*777*111#"
			Me.btnECRun777111.UseVisualStyleBackColor = False
			Me.TempCheck.AutoSize = True
			Me.TempCheck.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.TempCheck.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.TempCheck.ForeColor = Global.System.Drawing.Color.Black
			Me.TempCheck.Location = New Global.System.Drawing.Point(13, 273)
			Me.TempCheck.Name = "TempCheck"
			Me.TempCheck.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.TempCheck.Size = New Global.System.Drawing.Size(15, 14)
			Me.TempCheck.TabIndex = 1113
			Me.TempCheck.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.TempCheck.UseVisualStyleBackColor = False
			Me.TempCheck.Visible = False
			Me.ckbtnAutoES_Seres.AutoSize = True
			Me.ckbtnAutoES_Seres.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnAutoES_Seres.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnAutoES_Seres.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnAutoES_Seres.Location = New Global.System.Drawing.Point(856, 23)
			Me.ckbtnAutoES_Seres.Name = "ckbtnAutoES_Seres"
			Me.ckbtnAutoES_Seres.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnAutoES_Seres.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnAutoES_Seres.TabIndex = 1113
			Me.ckbtnAutoES_Seres.Text = "Auto"
			Me.ckbtnAutoES_Seres.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnAutoES_Seres.UseVisualStyleBackColor = False
			Me.btnAutoES_Seres.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoES_Seres.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoES_Seres.Location = New Global.System.Drawing.Point(671, 16)
			Me.btnAutoES_Seres.Name = "btnAutoES_Seres"
			Me.btnAutoES_Seres.Size = New Global.System.Drawing.Size(247, 73)
			Me.btnAutoES_Seres.TabIndex = 1112
			Me.btnAutoES_Seres.Text = "متتالى"
			Me.btnAutoES_Seres.UseVisualStyleBackColor = False
			Me.Label104.AutoSize = True
			Me.Label104.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label104.ForeColor = Global.System.Drawing.Color.Black
			Me.Label104.Location = New Global.System.Drawing.Point(552, 64)
			Me.Label104.Name = "Label104"
			Me.Label104.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label104.Size = New Global.System.Drawing.Size(29, 25)
			Me.Label104.TabIndex = 1111
			Me.Label104.Text = "+"
			Me.Label106.AutoSize = True
			Me.Label106.Font = New Global.System.Drawing.Font("Tahoma", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label106.ForeColor = Global.System.Drawing.Color.Black
			Me.Label106.Location = New Global.System.Drawing.Point(555, 33)
			Me.Label106.Name = "Label106"
			Me.Label106.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label106.Size = New Global.System.Drawing.Size(21, 25)
			Me.Label106.TabIndex = 1110
			Me.Label106.Text = "-"
			Me.txtESAdd.BackColor = Global.System.Drawing.Color.White
			Me.txtESAdd.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtESAdd.ForeColor = Global.System.Drawing.Color.Black
			Me.txtESAdd.Location = New Global.System.Drawing.Point(586, 66)
			Me.txtESAdd.MaxLength = 100
			Me.txtESAdd.Name = "txtESAdd"
			Me.txtESAdd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtESAdd.Size = New Global.System.Drawing.Size(69, 24)
			Me.txtESAdd.TabIndex = 1109
			Me.txtESAdd.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtESSub.BackColor = Global.System.Drawing.Color.White
			Me.txtESSub.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtESSub.ForeColor = Global.System.Drawing.Color.Black
			Me.txtESSub.Location = New Global.System.Drawing.Point(586, 35)
			Me.txtESSub.MaxLength = 100
			Me.txtESSub.Name = "txtESSub"
			Me.txtESSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtESSub.Size = New Global.System.Drawing.Size(69, 24)
			Me.txtESSub.TabIndex = 1108
			Me.txtESSub.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAutoVCnormECOne.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVCnormECOne.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAutoVCnormECOne.Location = New Global.System.Drawing.Point(341, 207)
			Me.btnAutoVCnormECOne.Name = "btnAutoVCnormECOne"
			Me.btnAutoVCnormECOne.Size = New Global.System.Drawing.Size(147, 80)
			Me.btnAutoVCnormECOne.TabIndex = 1107
			Me.btnAutoVCnormECOne.Text = "تحويل من الاساسى للتالى"
			Me.btnAutoVCnormECOne.UseVisualStyleBackColor = False
			Me.ckbtnGetBal2EC.AutoSize = True
			Me.ckbtnGetBal2EC.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnGetBal2EC.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnGetBal2EC.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnGetBal2EC.Location = New Global.System.Drawing.Point(865, 218)
			Me.ckbtnGetBal2EC.Name = "ckbtnGetBal2EC"
			Me.ckbtnGetBal2EC.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnGetBal2EC.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnGetBal2EC.TabIndex = 1106
			Me.ckbtnGetBal2EC.Text = "Auto"
			Me.ckbtnGetBal2EC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnGetBal2EC.UseVisualStyleBackColor = False
			Me.lblMainEC.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.lblMainEC.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblMainEC.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblMainEC.ForeColor = Global.System.Drawing.Color.Black
			Me.lblMainEC.Location = New Global.System.Drawing.Point(503, 178)
			Me.lblMainEC.Name = "lblMainEC"
			Me.lblMainEC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblMainEC.Size = New Global.System.Drawing.Size(202, 38)
			Me.lblMainEC.TabIndex = 1009
			Me.lblMainEC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label42.AutoSize = True
			Me.Label42.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label42.ForeColor = Global.System.Drawing.Color.Black
			Me.Label42.Location = New Global.System.Drawing.Point(571, 155)
			Me.Label42.Name = "Label42"
			Me.Label42.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label42.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label42.TabIndex = 1008
			Me.Label42.Text = "الاساسى"
			Me.Label39.AutoSize = True
			Me.Label39.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label39.ForeColor = Global.System.Drawing.Color.Black
			Me.Label39.Location = New Global.System.Drawing.Point(551, 224)
			Me.Label39.Name = "Label39"
			Me.Label39.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label39.Size = New Global.System.Drawing.Size(115, 17)
			Me.Label39.TabIndex = 1007
			Me.Label39.Text = "الاساسى التالى"
			Me.Label40.AutoSize = True
			Me.Label40.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label40.ForeColor = Global.System.Drawing.Color.Black
			Me.Label40.Location = New Global.System.Drawing.Point(443, 25)
			Me.Label40.Name = "Label40"
			Me.Label40.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label40.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label40.TabIndex = 1006
			Me.Label40.Text = "المبلغ"
			Me.btnAutoVCnormEC.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVCnormEC.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAutoVCnormEC.Location = New Global.System.Drawing.Point(201, 205)
			Me.btnAutoVCnormEC.Name = "btnAutoVCnormEC"
			Me.btnAutoVCnormEC.Size = New Global.System.Drawing.Size(133, 82)
			Me.btnAutoVCnormEC.TabIndex = 1005
			Me.btnAutoVCnormEC.Text = "تحويل من الكل للاساسى التالى"
			Me.btnAutoVCnormEC.UseVisualStyleBackColor = False
			Me.txtCashNextMasterEC.BackColor = Global.System.Drawing.Color.White
			Me.txtCashNextMasterEC.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCashNextMasterEC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtCashNextMasterEC.Location = New Global.System.Drawing.Point(503, 246)
			Me.txtCashNextMasterEC.MaxLength = 11
			Me.txtCashNextMasterEC.Name = "txtCashNextMasterEC"
			Me.txtCashNextMasterEC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCashNextMasterEC.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtCashNextMasterEC.TabIndex = 1004
			Me.txtCashNextMasterEC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMonyMnEC.BackColor = Global.System.Drawing.Color.White
			Me.txtMonyMnEC.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMonyMnEC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMonyMnEC.Location = New Global.System.Drawing.Point(393, 58)
			Me.txtMonyMnEC.Name = "txtMonyMnEC"
			Me.txtMonyMnEC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMonyMnEC.Size = New Global.System.Drawing.Size(133, 36)
			Me.txtMonyMnEC.TabIndex = 1003
			Me.txtMonyMnEC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetBal2EC.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBal2EC.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetBal2EC.Location = New Global.System.Drawing.Point(716, 212)
			Me.btnGetBal2EC.Name = "btnGetBal2EC"
			Me.btnGetBal2EC.Size = New Global.System.Drawing.Size(204, 77)
			Me.btnGetBal2EC.TabIndex = 1002
			Me.btnGetBal2EC.Text = "استعلام عن رصيد الكاش"
			Me.btnGetBal2EC.UseVisualStyleBackColor = False
			Me.Label38.AutoSize = True
			Me.Label38.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label38.ForeColor = Global.System.Drawing.Color.Black
			Me.Label38.Location = New Global.System.Drawing.Point(10, 228)
			Me.Label38.Name = "Label38"
			Me.Label38.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label38.Size = New Global.System.Drawing.Size(157, 17)
			Me.Label38.TabIndex = 884
			Me.Label38.Text = "كلمة سر اتصالات كاش"
			Me.txtPassEC.BackColor = Global.System.Drawing.Color.White
			Me.txtPassEC.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPassEC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtPassEC.Location = New Global.System.Drawing.Point(22, 255)
			Me.txtPassEC.MaxLength = 6
			Me.txtPassEC.Name = "txtPassEC"
			Me.txtPassEC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPassEC.Size = New Global.System.Drawing.Size(127, 27)
			Me.txtPassEC.TabIndex = 883
			Me.tabPrint.BackColor = Global.System.Drawing.Color.Teal
			Me.tabPrint.Controls.Add(Me.txtPrintOut2)
			Me.tabPrint.Controls.Add(Me.txtPrintOut1)
			Me.tabPrint.Controls.Add(Me.btnPrintOUT)
			Me.tabPrint.Controls.Add(Me.ck2x1)
			Me.tabPrint.Controls.Add(Me.txtPrintStr)
			Me.tabPrint.Controls.Add(Me.btnPrintstr)
			Me.tabPrint.Controls.Add(Me.txtPrintPd)
			Me.tabPrint.Controls.Add(Me.btnPrintRest)
			Me.tabPrint.Controls.Add(Me.ckPrint)
			Me.tabPrint.Controls.Add(Me.GroupBox2)
			Me.tabPrint.Controls.Add(Me.btnPrinter)
			Me.tabPrint.Controls.Add(Me.btnPrint)
			Me.tabPrint.Controls.Add(Me.GroupBox5)
			Me.tabPrint.Controls.Add(Me.GroupBox1)
			Me.tabPrint.Controls.Add(Me.cmbPrinter)
			Me.tabPrint.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabPrint.Name = "tabPrint"
			Me.tabPrint.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabPrint.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabPrint.TabIndex = 16
			Me.tabPrint.Text = "Print"
			Me.txtPrintOut2.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrintOut2.Location = New Global.System.Drawing.Point(286, 207)
			Me.txtPrintOut2.MaxLength = 100
			Me.txtPrintOut2.Name = "txtPrintOut2"
			Me.txtPrintOut2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPrintOut2.Size = New Global.System.Drawing.Size(176, 30)
			Me.txtPrintOut2.TabIndex = 1051
			Me.txtPrintOut2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtPrintOut1.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrintOut1.Location = New Global.System.Drawing.Point(286, 176)
			Me.txtPrintOut1.MaxLength = 100
			Me.txtPrintOut1.Name = "txtPrintOut1"
			Me.txtPrintOut1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPrintOut1.Size = New Global.System.Drawing.Size(176, 30)
			Me.txtPrintOut1.TabIndex = 1050
			Me.txtPrintOut1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnPrintOUT.Location = New Global.System.Drawing.Point(468, 176)
			Me.btnPrintOUT.Name = "btnPrintOUT"
			Me.btnPrintOUT.Size = New Global.System.Drawing.Size(76, 65)
			Me.btnPrintOUT.TabIndex = 1049
			Me.btnPrintOUT.Text = "طباعة خارج"
			Me.btnPrintOUT.UseVisualStyleBackColor = True
			Me.ck2x1.AutoSize = True
			Me.ck2x1.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ck2x1.Checked = True
			Me.ck2x1.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.ck2x1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ck2x1.ForeColor = Global.System.Drawing.Color.Black
			Me.ck2x1.Location = New Global.System.Drawing.Point(310, 28)
			Me.ck2x1.Name = "ck2x1"
			Me.ck2x1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ck2x1.Size = New Global.System.Drawing.Size(47, 17)
			Me.ck2x1.TabIndex = 1048
			Me.ck2x1.Text = "2x1"
			Me.ck2x1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ck2x1.UseVisualStyleBackColor = False
			Me.txtPrintStr.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrintStr.Location = New Global.System.Drawing.Point(641, 247)
			Me.txtPrintStr.Name = "txtPrintStr"
			Me.txtPrintStr.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPrintStr.Size = New Global.System.Drawing.Size(266, 30)
			Me.txtPrintStr.TabIndex = 1047
			Me.txtPrintStr.Text = "#"
			Me.txtPrintStr.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnPrintstr.Location = New Global.System.Drawing.Point(812, 202)
			Me.btnPrintstr.Name = "btnPrintstr"
			Me.btnPrintstr.Size = New Global.System.Drawing.Size(95, 43)
			Me.btnPrintstr.TabIndex = 1046
			Me.btnPrintstr.Text = "طباعة رقم"
			Me.btnPrintstr.UseVisualStyleBackColor = True
			Me.txtPrintPd.Font = New Global.System.Drawing.Font("Tahoma", 15F)
			Me.txtPrintPd.Location = New Global.System.Drawing.Point(703, 25)
			Me.txtPrintPd.Name = "txtPrintPd"
			Me.txtPrintPd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPrintPd.Size = New Global.System.Drawing.Size(79, 32)
			Me.txtPrintPd.TabIndex = 1045
			Me.txtPrintPd.Text = "3000"
			Me.txtPrintPd.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnPrintRest.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrintRest.Location = New Global.System.Drawing.Point(696, 20)
			Me.btnPrintRest.Name = "btnPrintRest"
			Me.btnPrintRest.Size = New Global.System.Drawing.Size(214, 93)
			Me.btnPrintRest.TabIndex = 1044
			Me.btnPrintRest.Text = "Restart"
			Me.btnPrintRest.UseVisualStyleBackColor = True
			Me.ckPrint.AutoSize = True
			Me.ckPrint.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckPrint.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckPrint.ForeColor = Global.System.Drawing.Color.Black
			Me.ckPrint.Location = New Global.System.Drawing.Point(846, 128)
			Me.ckPrint.Name = "ckPrint"
			Me.ckPrint.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckPrint.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckPrint.TabIndex = 1043
			Me.ckPrint.Text = "Auto"
			Me.ckPrint.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckPrint.UseVisualStyleBackColor = False
			Me.GroupBox2.Controls.Add(Me.txtInfoSizeH)
			Me.GroupBox2.Controls.Add(Me.Label110)
			Me.GroupBox2.Controls.Add(Me.txtInfoSize)
			Me.GroupBox2.Controls.Add(Me.Label89)
			Me.GroupBox2.Controls.Add(Me.txtInfoT)
			Me.GroupBox2.Controls.Add(Me.txtInfoY)
			Me.GroupBox2.Controls.Add(Me.txtInfoX)
			Me.GroupBox2.Controls.Add(Me.Label66)
			Me.GroupBox2.Controls.Add(Me.Label68)
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.White
			Me.GroupBox2.Location = New Global.System.Drawing.Point(277, 51)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(413, 94)
			Me.GroupBox2.TabIndex = 285
			Me.GroupBox2.TabStop = False
			Me.txtInfoT.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtInfoT.Location = New Global.System.Drawing.Point(216, 22)
			Me.txtInfoT.Name = "txtInfoT"
			Me.txtInfoT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtInfoT.Size = New Global.System.Drawing.Size(168, 30)
			Me.txtInfoT.TabIndex = 9
			Me.txtInfoT.Text = "#"
			Me.txtInfoT.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtInfoY.Location = New Global.System.Drawing.Point(130, 33)
			Me.txtInfoY.Name = "txtInfoY"
			Me.txtInfoY.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtInfoY.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtInfoY.TabIndex = 8
			Me.txtInfoY.Text = "7"
			Me.txtInfoY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtInfoX.Location = New Global.System.Drawing.Point(29, 32)
			Me.txtInfoX.Name = "txtInfoX"
			Me.txtInfoX.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtInfoX.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtInfoX.TabIndex = 7
			Me.txtInfoX.Text = "31"
			Me.txtInfoX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label66.AutoSize = True
			Me.Label66.ForeColor = Global.System.Drawing.Color.White
			Me.Label66.Location = New Global.System.Drawing.Point(6, 35)
			Me.Label66.Name = "Label66"
			Me.Label66.Size = New Global.System.Drawing.Size(14, 13)
			Me.Label66.TabIndex = 6
			Me.Label66.Text = "X"
			Me.Label68.AutoSize = True
			Me.Label68.ForeColor = Global.System.Drawing.Color.White
			Me.Label68.Location = New Global.System.Drawing.Point(111, 36)
			Me.Label68.Name = "Label68"
			Me.Label68.Size = New Global.System.Drawing.Size(14, 13)
			Me.Label68.TabIndex = 4
			Me.Label68.Text = "Y"
			Me.btnPrinter.Location = New Global.System.Drawing.Point(589, 20)
			Me.btnPrinter.Name = "btnPrinter"
			Me.btnPrinter.Size = New Global.System.Drawing.Size(90, 25)
			Me.btnPrinter.TabIndex = 284
			Me.btnPrinter.Text = "فتح الطابعة"
			Me.btnPrinter.UseVisualStyleBackColor = True
			Me.btnPrint.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrint.Location = New Global.System.Drawing.Point(696, 119)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New Global.System.Drawing.Size(214, 70)
			Me.btnPrint.TabIndex = 283
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.GroupBox5.Controls.Add(Me.txtBar_tn)
			Me.GroupBox5.Controls.Add(Me.Label58)
			Me.GroupBox5.Controls.Add(Me.txtBar_tk)
			Me.GroupBox5.Controls.Add(Me.Label59)
			Me.GroupBox5.Controls.Add(Me.txtBar_H)
			Me.GroupBox5.Controls.Add(Me.txtBar_y)
			Me.GroupBox5.Controls.Add(Me.txtBar_x)
			Me.GroupBox5.Controls.Add(Me.Label60)
			Me.GroupBox5.Controls.Add(Me.Label61)
			Me.GroupBox5.Controls.Add(Me.Label62)
			Me.GroupBox5.ForeColor = Global.System.Drawing.Color.White
			Me.GroupBox5.Location = New Global.System.Drawing.Point(17, 141)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.Size = New Global.System.Drawing.Size(231, 148)
			Me.GroupBox5.TabIndex = 282
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "مقاسات الباركود"
			Me.txtBar_tn.Location = New Global.System.Drawing.Point(130, 120)
			Me.txtBar_tn.Name = "txtBar_tn"
			Me.txtBar_tn.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtBar_tn.Size = New Global.System.Drawing.Size(41, 20)
			Me.txtBar_tn.TabIndex = 13
			Me.txtBar_tn.Text = "4"
			Me.txtBar_tn.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label58.AutoSize = True
			Me.Label58.ForeColor = Global.System.Drawing.Color.White
			Me.Label58.Location = New Global.System.Drawing.Point(6, 123)
			Me.Label58.Name = "Label58"
			Me.Label58.Size = New Global.System.Drawing.Size(82, 13)
			Me.Label58.TabIndex = 12
			Me.Label58.Text = "Wide Bar Width"
			Me.txtBar_tk.Location = New Global.System.Drawing.Point(130, 91)
			Me.txtBar_tk.Name = "txtBar_tk"
			Me.txtBar_tk.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtBar_tk.Size = New Global.System.Drawing.Size(41, 20)
			Me.txtBar_tk.TabIndex = 11
			Me.txtBar_tk.Text = "2"
			Me.txtBar_tk.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label59.AutoSize = True
			Me.Label59.ForeColor = Global.System.Drawing.Color.White
			Me.Label59.Location = New Global.System.Drawing.Point(6, 94)
			Me.Label59.Name = "Label59"
			Me.Label59.Size = New Global.System.Drawing.Size(91, 13)
			Me.Label59.TabIndex = 10
			Me.Label59.Text = "Narrow Bar Width"
			Me.txtBar_H.Location = New Global.System.Drawing.Point(102, 32)
			Me.txtBar_H.Name = "txtBar_H"
			Me.txtBar_H.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtBar_H.Size = New Global.System.Drawing.Size(69, 20)
			Me.txtBar_H.TabIndex = 9
			Me.txtBar_H.Text = "4"
			Me.txtBar_H.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtBar_y.Location = New Global.System.Drawing.Point(29, 61)
			Me.txtBar_y.Name = "txtBar_y"
			Me.txtBar_y.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtBar_y.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtBar_y.TabIndex = 8
			Me.txtBar_y.Text = "1"
			Me.txtBar_y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtBar_x.Location = New Global.System.Drawing.Point(29, 32)
			Me.txtBar_x.Name = "txtBar_x"
			Me.txtBar_x.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtBar_x.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtBar_x.TabIndex = 7
			Me.txtBar_x.Text = "2"
			Me.txtBar_x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label60.AutoSize = True
			Me.Label60.ForeColor = Global.System.Drawing.Color.White
			Me.Label60.Location = New Global.System.Drawing.Point(6, 35)
			Me.Label60.Name = "Label60"
			Me.Label60.Size = New Global.System.Drawing.Size(14, 13)
			Me.Label60.TabIndex = 6
			Me.Label60.Text = "X"
			Me.Label61.AutoSize = True
			Me.Label61.ForeColor = Global.System.Drawing.Color.White
			Me.Label61.Location = New Global.System.Drawing.Point(177, 35)
			Me.Label61.Name = "Label61"
			Me.Label61.Size = New Global.System.Drawing.Size(35, 13)
			Me.Label61.TabIndex = 5
			Me.Label61.Text = "ارتفاع"
			Me.Label62.AutoSize = True
			Me.Label62.ForeColor = Global.System.Drawing.Color.White
			Me.Label62.Location = New Global.System.Drawing.Point(6, 63)
			Me.Label62.Name = "Label62"
			Me.Label62.Size = New Global.System.Drawing.Size(14, 13)
			Me.Label62.TabIndex = 4
			Me.Label62.Text = "Y"
			Me.GroupBox1.Controls.Add(Me.txtW)
			Me.GroupBox1.Controls.Add(Me.txtH)
			Me.GroupBox1.Controls.Add(Me.txtHn)
			Me.GroupBox1.Controls.Add(Me.Label55)
			Me.GroupBox1.Controls.Add(Me.Label56)
			Me.GroupBox1.Controls.Add(Me.Label57)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.White
			Me.GroupBox1.Location = New Global.System.Drawing.Point(15, 21)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(231, 108)
			Me.GroupBox1.TabIndex = 281
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "مقاس الطابع بالملي"
			Me.txtW.Location = New Global.System.Drawing.Point(16, 50)
			Me.txtW.Name = "txtW"
			Me.txtW.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtW.Size = New Global.System.Drawing.Size(64, 20)
			Me.txtW.TabIndex = 9
			Me.txtW.Text = "40"
			Me.txtW.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtH.Location = New Global.System.Drawing.Point(16, 76)
			Me.txtH.Name = "txtH"
			Me.txtH.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtH.Size = New Global.System.Drawing.Size(64, 20)
			Me.txtH.TabIndex = 8
			Me.txtH.Text = "25"
			Me.txtH.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtHn.Location = New Global.System.Drawing.Point(16, 23)
			Me.txtHn.Name = "txtHn"
			Me.txtHn.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtHn.Size = New Global.System.Drawing.Size(64, 20)
			Me.txtHn.TabIndex = 7
			Me.txtHn.Text = "15"
			Me.txtHn.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label55.AutoSize = True
			Me.Label55.ForeColor = Global.System.Drawing.Color.White
			Me.Label55.Location = New Global.System.Drawing.Point(85, 26)
			Me.Label55.Name = "Label55"
			Me.Label55.Size = New Global.System.Drawing.Size(69, 13)
			Me.Label55.TabIndex = 6
			Me.Label55.Text = "حرارة الطباعة"
			Me.Label56.AutoSize = True
			Me.Label56.ForeColor = Global.System.Drawing.Color.White
			Me.Label56.Location = New Global.System.Drawing.Point(85, 53)
			Me.Label56.Name = "Label56"
			Me.Label56.Size = New Global.System.Drawing.Size(35, 13)
			Me.Label56.TabIndex = 5
			Me.Label56.Text = "العرض"
			Me.Label57.AutoSize = True
			Me.Label57.ForeColor = Global.System.Drawing.Color.White
			Me.Label57.Location = New Global.System.Drawing.Point(86, 79)
			Me.Label57.Name = "Label57"
			Me.Label57.Size = New Global.System.Drawing.Size(33, 13)
			Me.Label57.TabIndex = 4
			Me.Label57.Text = "الطول"
			Me.cmbPrinter.Location = New Global.System.Drawing.Point(363, 20)
			Me.cmbPrinter.Name = "cmbPrinter"
			Me.cmbPrinter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.cmbPrinter.Size = New Global.System.Drawing.Size(220, 20)
			Me.cmbPrinter.TabIndex = 280
			Me.cmbPrinter.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.TabPage3.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.TabPage3.Controls.Add(Me.gboxSms)
			Me.TabPage3.Controls.Add(Me.txtSmsT_SR)
			Me.TabPage3.Controls.Add(Me.txtSmsT_MR)
			Me.TabPage3.Controls.Add(Me.txtSmsT_HR)
			Me.TabPage3.Controls.Add(Me.Label109)
			Me.TabPage3.Controls.Add(Me.txtSmsT_S)
			Me.TabPage3.Controls.Add(Me.txtSmsT_M)
			Me.TabPage3.Controls.Add(Me.txtSmsT_H)
			Me.TabPage3.Controls.Add(Me.ckbtnSendSmsToNumber)
			Me.TabPage3.Controls.Add(Me.txtSMStothisnumber)
			Me.TabPage3.Controls.Add(Me.txtSmsWait)
			Me.TabPage3.Controls.Add(Me.btnSendSmsToNumber)
			Me.TabPage3.Controls.Add(Me.Label23)
			Me.TabPage3.Controls.Add(Me.txtLoopSsms)
			Me.TabPage3.Controls.Add(Me.txtLoopFsms)
			Me.TabPage3.Controls.Add(Me.btnAddNumbersToOCsms)
			Me.TabPage3.Controls.Add(Me.lblCountPresms)
			Me.TabPage3.Controls.Add(Me.btnClearOCsms)
			Me.TabPage3.Controls.Add(Me.lblOCDonesms)
			Me.TabPage3.Controls.Add(Me.txtOCNumbersms)
			Me.TabPage3.Controls.Add(Me.lstOCNumberssms)
			Me.TabPage3.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage3.Name = "TabPage3"
			Me.TabPage3.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage3.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage3.TabIndex = 2
			Me.TabPage3.Text = "SMS"
			Me.gboxSms.Controls.Add(Me.txtGboxSub)
			Me.gboxSms.Controls.Add(Me.btngboxSmsAdd)
			Me.gboxSms.Controls.Add(Me.txtGboxQty)
			Me.gboxSms.Controls.Add(Me.txtGboxMain)
			Me.gboxSms.Location = New Global.System.Drawing.Point(638, 128)
			Me.gboxSms.Name = "gboxSms"
			Me.gboxSms.Size = New Global.System.Drawing.Size(269, 161)
			Me.gboxSms.TabIndex = 1152
			Me.gboxSms.TabStop = False
			Me.txtGboxSub.BackColor = Global.System.Drawing.Color.White
			Me.txtGboxSub.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtGboxSub.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGboxSub.Location = New Global.System.Drawing.Point(8, 61)
			Me.txtGboxSub.MaxLength = 11
			Me.txtGboxSub.Name = "txtGboxSub"
			Me.txtGboxSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGboxSub.Size = New Global.System.Drawing.Size(82, 36)
			Me.txtGboxSub.TabIndex = 1146
			Me.txtGboxSub.Text = "1a"
			Me.txtGboxSub.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btngboxSmsAdd.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btngboxSmsAdd.Location = New Global.System.Drawing.Point(117, 100)
			Me.btngboxSmsAdd.Name = "btngboxSmsAdd"
			Me.btngboxSmsAdd.Size = New Global.System.Drawing.Size(87, 42)
			Me.btngboxSmsAdd.TabIndex = 1145
			Me.btngboxSmsAdd.Text = "Add"
			Me.btngboxSmsAdd.UseVisualStyleBackColor = True
			Me.txtGboxQty.BackColor = Global.System.Drawing.Color.White
			Me.txtGboxQty.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtGboxQty.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGboxQty.Location = New Global.System.Drawing.Point(8, 104)
			Me.txtGboxQty.MaxLength = 11
			Me.txtGboxQty.Name = "txtGboxQty"
			Me.txtGboxQty.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGboxQty.Size = New Global.System.Drawing.Size(82, 36)
			Me.txtGboxQty.TabIndex = 1144
			Me.txtGboxQty.Text = "100"
			Me.txtGboxQty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtGboxMain.BackColor = Global.System.Drawing.Color.White
			Me.txtGboxMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtGboxMain.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGboxMain.Location = New Global.System.Drawing.Point(8, 19)
			Me.txtGboxMain.MaxLength = 11
			Me.txtGboxMain.Name = "txtGboxMain"
			Me.txtGboxMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGboxMain.Size = New Global.System.Drawing.Size(196, 36)
			Me.txtGboxMain.TabIndex = 1143
			Me.txtGboxMain.Text = "5w4a6u"
			Me.txtGboxMain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsT_SR.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.txtSmsT_SR.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_SR.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_SR.Location = New Global.System.Drawing.Point(497, 236)
			Me.txtSmsT_SR.MaxLength = 2
			Me.txtSmsT_SR.Name = "txtSmsT_SR"
			Me.txtSmsT_SR.[ReadOnly] = True
			Me.txtSmsT_SR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_SR.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_SR.TabIndex = 1151
			Me.txtSmsT_SR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsT_MR.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.txtSmsT_MR.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_MR.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_MR.Location = New Global.System.Drawing.Point(445, 236)
			Me.txtSmsT_MR.MaxLength = 2
			Me.txtSmsT_MR.Name = "txtSmsT_MR"
			Me.txtSmsT_MR.[ReadOnly] = True
			Me.txtSmsT_MR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_MR.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_MR.TabIndex = 1150
			Me.txtSmsT_MR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsT_HR.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.txtSmsT_HR.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_HR.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_HR.Location = New Global.System.Drawing.Point(392, 236)
			Me.txtSmsT_HR.MaxLength = 2
			Me.txtSmsT_HR.Name = "txtSmsT_HR"
			Me.txtSmsT_HR.[ReadOnly] = True
			Me.txtSmsT_HR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_HR.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_HR.TabIndex = 1149
			Me.txtSmsT_HR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label109.AutoSize = True
			Me.Label109.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label109.ForeColor = Global.System.Drawing.Color.Black
			Me.Label109.Location = New Global.System.Drawing.Point(389, 172)
			Me.Label109.Name = "Label109"
			Me.Label109.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label109.Size = New Global.System.Drawing.Size(68, 17)
			Me.Label109.TabIndex = 1148
			Me.Label109.Text = "Set Time"
			Me.txtSmsT_S.BackColor = Global.System.Drawing.Color.White
			Me.txtSmsT_S.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_S.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_S.Location = New Global.System.Drawing.Point(497, 194)
			Me.txtSmsT_S.MaxLength = 2
			Me.txtSmsT_S.Name = "txtSmsT_S"
			Me.txtSmsT_S.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_S.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_S.TabIndex = 1147
			Me.txtSmsT_S.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsT_M.BackColor = Global.System.Drawing.Color.White
			Me.txtSmsT_M.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_M.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_M.Location = New Global.System.Drawing.Point(445, 194)
			Me.txtSmsT_M.MaxLength = 2
			Me.txtSmsT_M.Name = "txtSmsT_M"
			Me.txtSmsT_M.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_M.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_M.TabIndex = 1146
			Me.txtSmsT_M.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsT_H.BackColor = Global.System.Drawing.Color.White
			Me.txtSmsT_H.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsT_H.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSmsT_H.Location = New Global.System.Drawing.Point(392, 194)
			Me.txtSmsT_H.MaxLength = 2
			Me.txtSmsT_H.Name = "txtSmsT_H"
			Me.txtSmsT_H.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsT_H.Size = New Global.System.Drawing.Size(47, 36)
			Me.txtSmsT_H.TabIndex = 1145
			Me.txtSmsT_H.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckbtnSendSmsToNumber.AutoSize = True
			Me.ckbtnSendSmsToNumber.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnSendSmsToNumber.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnSendSmsToNumber.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnSendSmsToNumber.Location = New Global.System.Drawing.Point(758, 42)
			Me.ckbtnSendSmsToNumber.Name = "ckbtnSendSmsToNumber"
			Me.ckbtnSendSmsToNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnSendSmsToNumber.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnSendSmsToNumber.TabIndex = 1143
			Me.ckbtnSendSmsToNumber.Text = "Auto"
			Me.ckbtnSendSmsToNumber.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnSendSmsToNumber.UseVisualStyleBackColor = False
			Me.txtSMStothisnumber.BackColor = Global.System.Drawing.Color.White
			Me.txtSMStothisnumber.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSMStothisnumber.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSMStothisnumber.Location = New Global.System.Drawing.Point(392, 131)
			Me.txtSMStothisnumber.MaxLength = 11
			Me.txtSMStothisnumber.Name = "txtSMStothisnumber"
			Me.txtSMStothisnumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSMStothisnumber.Size = New Global.System.Drawing.Size(221, 36)
			Me.txtSMStothisnumber.TabIndex = 1142
			Me.txtSMStothisnumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtSmsWait.BackColor = Global.System.Drawing.Color.Blue
			Me.txtSmsWait.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSmsWait.ForeColor = Global.System.Drawing.Color.White
			Me.txtSmsWait.Location = New Global.System.Drawing.Point(405, 42)
			Me.txtSmsWait.Name = "txtSmsWait"
			Me.txtSmsWait.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSmsWait.Size = New Global.System.Drawing.Size(50, 24)
			Me.txtSmsWait.TabIndex = 1141
			Me.txtSmsWait.Text = "1"
			Me.txtSmsWait.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnSendSmsToNumber.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSendSmsToNumber.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSendSmsToNumber.Location = New Global.System.Drawing.Point(392, 34)
			Me.btnSendSmsToNumber.Name = "btnSendSmsToNumber"
			Me.btnSendSmsToNumber.Size = New Global.System.Drawing.Size(425, 64)
			Me.btnSendSmsToNumber.TabIndex = 1140
			Me.btnSendSmsToNumber.Text = "Send Sms"
			Me.btnSendSmsToNumber.UseVisualStyleBackColor = False
			Me.Label23.AutoSize = True
			Me.Label23.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label23.ForeColor = Global.System.Drawing.Color.Black
			Me.Label23.Location = New Global.System.Drawing.Point(389, 107)
			Me.Label23.Name = "Label23"
			Me.Label23.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label23.Size = New Global.System.Drawing.Size(103, 17)
			Me.Label23.TabIndex = 1139
			Me.Label23.Text = "Send Number"
			Me.txtLoopSsms.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSsms.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSsms.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSsms.Location = New Global.System.Drawing.Point(823, 66)
			Me.txtLoopSsms.Name = "txtLoopSsms"
			Me.txtLoopSsms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSsms.Size = New Global.System.Drawing.Size(44, 24)
			Me.txtLoopSsms.TabIndex = 1138
			Me.txtLoopSsms.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFsms.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFsms.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFsms.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFsms.Location = New Global.System.Drawing.Point(824, 38)
			Me.txtLoopFsms.Name = "txtLoopFsms"
			Me.txtLoopFsms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFsms.Size = New Global.System.Drawing.Size(43, 24)
			Me.txtLoopFsms.TabIndex = 1137
			Me.txtLoopFsms.Text = "1"
			Me.txtLoopFsms.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAddNumbersToOCsms.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAddNumbersToOCsms.Location = New Global.System.Drawing.Point(6, 17)
			Me.btnAddNumbersToOCsms.Name = "btnAddNumbersToOCsms"
			Me.btnAddNumbersToOCsms.Size = New Global.System.Drawing.Size(87, 42)
			Me.btnAddNumbersToOCsms.TabIndex = 1136
			Me.btnAddNumbersToOCsms.Text = "Add"
			Me.btnAddNumbersToOCsms.UseVisualStyleBackColor = True
			Me.lblCountPresms.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCountPresms.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCountPresms.Location = New Global.System.Drawing.Point(6, 183)
			Me.lblCountPresms.Name = "lblCountPresms"
			Me.lblCountPresms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCountPresms.Size = New Global.System.Drawing.Size(77, 19)
			Me.lblCountPresms.TabIndex = 1135
			Me.lblCountPresms.Text = "#"
			Me.lblCountPresms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnClearOCsms.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearOCsms.Location = New Global.System.Drawing.Point(5, 232)
			Me.btnClearOCsms.Name = "btnClearOCsms"
			Me.btnClearOCsms.Size = New Global.System.Drawing.Size(88, 44)
			Me.btnClearOCsms.TabIndex = 1134
			Me.btnClearOCsms.Text = "Clear"
			Me.btnClearOCsms.UseVisualStyleBackColor = True
			Me.lblOCDonesms.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblOCDonesms.ForeColor = Global.System.Drawing.Color.Black
			Me.lblOCDonesms.Location = New Global.System.Drawing.Point(6, 136)
			Me.lblOCDonesms.Name = "lblOCDonesms"
			Me.lblOCDonesms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblOCDonesms.Size = New Global.System.Drawing.Size(77, 19)
			Me.lblOCDonesms.TabIndex = 1132
			Me.lblOCDonesms.Text = "#"
			Me.lblOCDonesms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtOCNumbersms.BackColor = Global.System.Drawing.Color.White
			Me.txtOCNumbersms.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOCNumbersms.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOCNumbersms.Location = New Global.System.Drawing.Point(100, 16)
			Me.txtOCNumbersms.Name = "txtOCNumbersms"
			Me.txtOCNumbersms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOCNumbersms.Size = New Global.System.Drawing.Size(231, 36)
			Me.txtOCNumbersms.TabIndex = 1131
			Me.txtOCNumbersms.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lstOCNumberssms.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstOCNumberssms.FormattingEnabled = True
			Me.lstOCNumberssms.ItemHeight = 23
			Me.lstOCNumberssms.Location = New Global.System.Drawing.Point(100, 59)
			Me.lstOCNumberssms.Name = "lstOCNumberssms"
			Me.lstOCNumberssms.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstOCNumberssms.Size = New Global.System.Drawing.Size(231, 188)
			Me.lstOCNumberssms.TabIndex = 1130
			Me.TabPage5.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage5.Controls.Add(Me.Label12)
			Me.TabPage5.Controls.Add(Me.txtGftLmt)
			Me.TabPage5.Controls.Add(Me.txtTotalTransVal)
			Me.TabPage5.Controls.Add(Me.btnTransAllMony)
			Me.TabPage5.Controls.Add(Me.btnVodaTrans)
			Me.TabPage5.Controls.Add(Me.btnRunAuto)
			Me.TabPage5.Controls.Add(Me.txtLoopSVC)
			Me.TabPage5.Controls.Add(Me.txtLoopFVC)
			Me.TabPage5.Controls.Add(Me.btnExnums)
			Me.TabPage5.Controls.Add(Me.lstNumbers)
			Me.TabPage5.Controls.Add(Me.txtEnumsVC)
			Me.TabPage5.Controls.Add(Me.btnTransInv)
			Me.TabPage5.Controls.Add(Me.Label9)
			Me.TabPage5.Controls.Add(Me.txtTransNum)
			Me.TabPage5.Controls.Add(Me.btnTransVal)
			Me.TabPage5.Controls.Add(Me.btnRunAll)
			Me.TabPage5.Controls.Add(Me.btnGetBal)
			Me.TabPage5.Controls.Add(Me.btnRun02)
			Me.TabPage5.Controls.Add(Me.bt)
			Me.TabPage5.Controls.Add(Me.btnNextItems)
			Me.TabPage5.Controls.Add(Me.btnWorkID)
			Me.TabPage5.Controls.Add(Me.Label8)
			Me.TabPage5.Controls.Add(Me.txtTransMoney)
			Me.TabPage5.Controls.Add(Me.Label6)
			Me.TabPage5.Controls.Add(Me.txtQtyDone)
			Me.TabPage5.Controls.Add(Me.Label5)
			Me.TabPage5.Controls.Add(Me.txtMoney)
			Me.TabPage5.Controls.Add(Me.Label3)
			Me.TabPage5.Controls.Add(Me.txtWorkID)
			Me.TabPage5.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage5.Name = "TabPage5"
			Me.TabPage5.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage5.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage5.TabIndex = 4
			Me.TabPage5.Text = "VFOLd"
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label12.ForeColor = Global.System.Drawing.Color.Black
			Me.Label12.Location = New Global.System.Drawing.Point(182, 213)
			Me.Label12.Name = "Label12"
			Me.Label12.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label12.Size = New Global.System.Drawing.Size(118, 17)
			Me.Label12.TabIndex = 981
			Me.Label12.Text = "تحديد عدد الهدايا"
			Me.txtGftLmt.BackColor = Global.System.Drawing.Color.White
			Me.txtGftLmt.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGftLmt.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGftLmt.Location = New Global.System.Drawing.Point(206, 237)
			Me.txtGftLmt.Name = "txtGftLmt"
			Me.txtGftLmt.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGftLmt.Size = New Global.System.Drawing.Size(63, 27)
			Me.txtGftLmt.TabIndex = 980
			Me.txtGftLmt.Text = "1"
			Me.txtGftLmt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTotalTransVal.BackColor = Global.System.Drawing.Color.Black
			Me.txtTotalTransVal.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTotalTransVal.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtTotalTransVal.Location = New Global.System.Drawing.Point(173, 87)
			Me.txtTotalTransVal.Name = "txtTotalTransVal"
			Me.txtTotalTransVal.[ReadOnly] = True
			Me.txtTotalTransVal.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTotalTransVal.Size = New Global.System.Drawing.Size(81, 24)
			Me.txtTotalTransVal.TabIndex = 979
			Me.txtTotalTransVal.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransAllMony.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransAllMony.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransAllMony.Location = New Global.System.Drawing.Point(6, 235)
			Me.btnTransAllMony.Name = "btnTransAllMony"
			Me.btnTransAllMony.Size = New Global.System.Drawing.Size(161, 27)
			Me.btnTransAllMony.TabIndex = 978
			Me.btnTransAllMony.Text = "تحويل كامل المبلغ كاش"
			Me.btnTransAllMony.UseVisualStyleBackColor = False
			Me.btnVodaTrans.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVodaTrans.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnVodaTrans.Location = New Global.System.Drawing.Point(450, 121)
			Me.btnVodaTrans.Name = "btnVodaTrans"
			Me.btnVodaTrans.Size = New Global.System.Drawing.Size(180, 27)
			Me.btnVodaTrans.TabIndex = 977
			Me.btnVodaTrans.Text = "تحويل رصيد عادى"
			Me.btnVodaTrans.UseVisualStyleBackColor = False
			Me.btnRunAuto.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunAuto.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRunAuto.Location = New Global.System.Drawing.Point(363, 8)
			Me.btnRunAuto.Name = "btnRunAuto"
			Me.btnRunAuto.Size = New Global.System.Drawing.Size(81, 53)
			Me.btnRunAuto.TabIndex = 973
			Me.btnRunAuto.Text = "تشغيل تلقائى"
			Me.btnRunAuto.UseVisualStyleBackColor = False
			Me.txtLoopSVC.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSVC.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSVC.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSVC.Location = New Global.System.Drawing.Point(323, 144)
			Me.txtLoopSVC.Name = "txtLoopSVC"
			Me.txtLoopSVC.[ReadOnly] = True
			Me.txtLoopSVC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSVC.Size = New Global.System.Drawing.Size(55, 24)
			Me.txtLoopSVC.TabIndex = 972
			Me.txtLoopSVC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFVC.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFVC.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFVC.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFVC.Location = New Global.System.Drawing.Point(263, 144)
			Me.txtLoopFVC.Name = "txtLoopFVC"
			Me.txtLoopFVC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFVC.Size = New Global.System.Drawing.Size(54, 24)
			Me.txtLoopFVC.TabIndex = 971
			Me.txtLoopFVC.Text = "1"
			Me.txtLoopFVC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnExnums.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnExnums.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExnums.Location = New Global.System.Drawing.Point(6, 159)
			Me.btnExnums.Name = "btnExnums"
			Me.btnExnums.Size = New Global.System.Drawing.Size(162, 27)
			Me.btnExnums.TabIndex = 970
			Me.btnExnums.Text = "تبديل الخطوط"
			Me.btnExnums.UseVisualStyleBackColor = False
			Me.lstNumbers.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNumbers.FormattingEnabled = True
			Me.lstNumbers.ItemHeight = 23
			Me.lstNumbers.Location = New Global.System.Drawing.Point(5, 38)
			Me.lstNumbers.Name = "lstNumbers"
			Me.lstNumbers.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNumbers.Size = New Global.System.Drawing.Size(162, 73)
			Me.lstNumbers.TabIndex = 969
			Me.txtEnumsVC.BackColor = Global.System.Drawing.Color.White
			Me.txtEnumsVC.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnumsVC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtEnumsVC.Location = New Global.System.Drawing.Point(109, 5)
			Me.txtEnumsVC.Name = "txtEnumsVC"
			Me.txtEnumsVC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnumsVC.Size = New Global.System.Drawing.Size(58, 27)
			Me.txtEnumsVC.TabIndex = 907
			Me.txtEnumsVC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransInv.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransInv.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransInv.Location = New Global.System.Drawing.Point(450, 92)
			Me.btnTransInv.Name = "btnTransInv"
			Me.btnTransInv.Size = New Global.System.Drawing.Size(180, 27)
			Me.btnTransInv.TabIndex = 906
			Me.btnTransInv.Text = "تحويل الهدية فاتورة"
			Me.btnTransInv.UseVisualStyleBackColor = False
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label9.ForeColor = Global.System.Drawing.Color.Black
			Me.Label9.Location = New Global.System.Drawing.Point(213, 64)
			Me.Label9.Name = "Label9"
			Me.Label9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label9.Size = New Global.System.Drawing.Size(181, 17)
			Me.Label9.TabIndex = 905
			Me.Label9.Text = "رقم الخط المحول له الهدية"
			Me.txtTransNum.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNum.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTransNum.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum.Location = New Global.System.Drawing.Point(263, 83)
			Me.txtTransNum.MaxLength = 11
			Me.txtTransNum.Name = "txtTransNum"
			Me.txtTransNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum.Size = New Global.System.Drawing.Size(129, 27)
			Me.txtTransNum.TabIndex = 904
			Me.txtTransNum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransVal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransVal.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransVal.Location = New Global.System.Drawing.Point(450, 64)
			Me.btnTransVal.Name = "btnTransVal"
			Me.btnTransVal.Size = New Global.System.Drawing.Size(180, 27)
			Me.btnTransVal.TabIndex = 903
			Me.btnTransVal.Text = "تحويل الهدية رصيد"
			Me.btnTransVal.UseVisualStyleBackColor = False
			Me.btnRunAll.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunAll.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRunAll.Location = New Global.System.Drawing.Point(445, 159)
			Me.btnRunAll.Name = "btnRunAll"
			Me.btnRunAll.Size = New Global.System.Drawing.Size(62, 55)
			Me.btnRunAll.TabIndex = 902
			Me.btnRunAll.Text = "تشغيل ذكى"
			Me.btnRunAll.UseVisualStyleBackColor = False
			Me.btnGetBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBal.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetBal.Location = New Global.System.Drawing.Point(450, 8)
			Me.btnGetBal.Name = "btnGetBal"
			Me.btnGetBal.Size = New Global.System.Drawing.Size(180, 51)
			Me.btnGetBal.TabIndex = 901
			Me.btnGetBal.Text = "استعلام عن رصيد فودافون كاش"
			Me.btnGetBal.UseVisualStyleBackColor = False
			Me.btnRun02.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRun02.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRun02.Location = New Global.System.Drawing.Point(508, 186)
			Me.btnRun02.Name = "btnRun02"
			Me.btnRun02.Size = New Global.System.Drawing.Size(122, 27)
			Me.btnRun02.TabIndex = 900
			Me.btnRun02.Text = "استقبال الهدية"
			Me.btnRun02.UseVisualStyleBackColor = False
			Me.bt.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.bt.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.bt.Location = New Global.System.Drawing.Point(508, 159)
			Me.bt.Name = "bt"
			Me.bt.Size = New Global.System.Drawing.Size(122, 27)
			Me.bt.TabIndex = 899
			Me.bt.Text = "تحويل عادى"
			Me.bt.UseVisualStyleBackColor = False
			Me.btnNextItems.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnNextItems.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnNextItems.Location = New Global.System.Drawing.Point(6, 5)
			Me.btnNextItems.Name = "btnNextItems"
			Me.btnNextItems.Size = New Global.System.Drawing.Size(102, 27)
			Me.btnNextItems.TabIndex = 898
			Me.btnNextItems.Text = "هات الخطوط"
			Me.btnNextItems.UseVisualStyleBackColor = False
			Me.btnWorkID.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnWorkID.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnWorkID.Location = New Global.System.Drawing.Point(383, 232)
			Me.btnWorkID.Name = "btnWorkID"
			Me.btnWorkID.Size = New Global.System.Drawing.Size(69, 27)
			Me.btnWorkID.TabIndex = 897
			Me.btnWorkID.Text = "جديد"
			Me.btnWorkID.UseVisualStyleBackColor = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label8.ForeColor = Global.System.Drawing.Color.Black
			Me.Label8.Location = New Global.System.Drawing.Point(349, 117)
			Me.Label8.Name = "Label8"
			Me.Label8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label8.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label8.TabIndex = 896
			Me.Label8.Text = "المبلغ"
			Me.txtTransMoney.BackColor = Global.System.Drawing.Color.White
			Me.txtTransMoney.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTransMoney.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransMoney.Location = New Global.System.Drawing.Point(263, 114)
			Me.txtTransMoney.Name = "txtTransMoney"
			Me.txtTransMoney.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransMoney.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtTransMoney.TabIndex = 895
			Me.txtTransMoney.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label6.ForeColor = Global.System.Drawing.Color.Black
			Me.Label6.Location = New Global.System.Drawing.Point(182, 10)
			Me.Label6.Name = "Label6"
			Me.Label6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label6.Size = New Global.System.Drawing.Size(64, 17)
			Me.Label6.TabIndex = 892
			Me.Label6.Text = "مسلسل"
			Me.txtQtyDone.BackColor = Global.System.Drawing.Color.White
			Me.txtQtyDone.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtQtyDone.ForeColor = Global.System.Drawing.Color.Black
			Me.txtQtyDone.Location = New Global.System.Drawing.Point(173, 30)
			Me.txtQtyDone.Name = "txtQtyDone"
			Me.txtQtyDone.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtQtyDone.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtQtyDone.TabIndex = 891
			Me.txtQtyDone.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ForeColor = Global.System.Drawing.Color.Black
			Me.Label5.Location = New Global.System.Drawing.Point(297, 10)
			Me.Label5.Name = "Label5"
			Me.Label5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label5.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label5.TabIndex = 890
			Me.Label5.Text = "المبلغ"
			Me.txtMoney.BackColor = Global.System.Drawing.Color.White
			Me.txtMoney.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoney.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoney.Location = New Global.System.Drawing.Point(276, 30)
			Me.txtMoney.Name = "txtMoney"
			Me.txtMoney.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoney.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtMoney.TabIndex = 889
			Me.txtMoney.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ForeColor = Global.System.Drawing.Color.Black
			Me.Label3.Location = New Global.System.Drawing.Point(542, 240)
			Me.Label3.Name = "Label3"
			Me.Label3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label3.Size = New Global.System.Drawing.Size(90, 17)
			Me.Label3.TabIndex = 886
			Me.Label3.Text = "رقم التشغيل"
			Me.txtWorkID.BackColor = Global.System.Drawing.Color.White
			Me.txtWorkID.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtWorkID.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWorkID.Location = New Global.System.Drawing.Point(458, 232)
			Me.txtWorkID.Name = "txtWorkID"
			Me.txtWorkID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWorkID.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtWorkID.TabIndex = 885
			Me.txtWorkID.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.TabPage14.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage14.Controls.Add(Me.txtTotalTransValP)
			Me.TabPage14.Controls.Add(Me.btnTransValP)
			Me.TabPage14.Controls.Add(Me.Label48)
			Me.TabPage14.Controls.Add(Me.txtTransMoneyP)
			Me.TabPage14.Controls.Add(Me.txtReplyPower)
			Me.TabPage14.Controls.Add(Me.Button2)
			Me.TabPage14.Controls.Add(Me.txtUssdP2)
			Me.TabPage14.Controls.Add(Me.btnRunPowe2)
			Me.TabPage14.Controls.Add(Me.txtTempxxp)
			Me.TabPage14.Controls.Add(Me.Label47)
			Me.TabPage14.Controls.Add(Me.txtTransNumP)
			Me.TabPage14.Controls.Add(Me.txtLoopSVCP)
			Me.TabPage14.Controls.Add(Me.txtLoopFVCP)
			Me.TabPage14.Controls.Add(Me.Label45)
			Me.TabPage14.Controls.Add(Me.txtQtyDoneP)
			Me.TabPage14.Controls.Add(Me.txtUssdP1)
			Me.TabPage14.Controls.Add(Me.btnRunPower)
			Me.TabPage14.Controls.Add(Me.btnAutoSendPower)
			Me.TabPage14.Controls.Add(Me.lstNumbersP)
			Me.TabPage14.Controls.Add(Me.txtEnumsVCP)
			Me.TabPage14.Controls.Add(Me.btnNextItemsP)
			Me.TabPage14.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage14.Name = "TabPage14"
			Me.TabPage14.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage14.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage14.TabIndex = 14
			Me.TabPage14.Text = "VFPower"
			Me.txtTotalTransValP.BackColor = Global.System.Drawing.Color.Black
			Me.txtTotalTransValP.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTotalTransValP.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtTotalTransValP.Location = New Global.System.Drawing.Point(292, 172)
			Me.txtTotalTransValP.Name = "txtTotalTransValP"
			Me.txtTotalTransValP.[ReadOnly] = True
			Me.txtTotalTransValP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTotalTransValP.Size = New Global.System.Drawing.Size(81, 24)
			Me.txtTotalTransValP.TabIndex = 1010
			Me.txtTotalTransValP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransValP.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransValP.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransValP.Location = New Global.System.Drawing.Point(378, 170)
			Me.btnTransValP.Name = "btnTransValP"
			Me.btnTransValP.Size = New Global.System.Drawing.Size(187, 27)
			Me.btnTransValP.TabIndex = 1009
			Me.btnTransValP.Text = "تحويل الهدية رصيد"
			Me.btnTransValP.UseVisualStyleBackColor = False
			Me.Label48.AutoSize = True
			Me.Label48.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label48.ForeColor = Global.System.Drawing.Color.Black
			Me.Label48.Location = New Global.System.Drawing.Point(309, 206)
			Me.Label48.Name = "Label48"
			Me.Label48.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label48.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label48.TabIndex = 1008
			Me.Label48.Text = "المبلغ"
			Me.txtTransMoneyP.BackColor = Global.System.Drawing.Color.White
			Me.txtTransMoneyP.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTransMoneyP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransMoneyP.Location = New Global.System.Drawing.Point(291, 236)
			Me.txtTransMoneyP.Name = "txtTransMoneyP"
			Me.txtTransMoneyP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransMoneyP.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtTransMoneyP.TabIndex = 1007
			Me.txtTransMoneyP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtReplyPower.BackColor = Global.System.Drawing.Color.Black
			Me.txtReplyPower.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtReplyPower.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtReplyPower.ForeColor = Global.System.Drawing.Color.White
			Me.txtReplyPower.Location = New Global.System.Drawing.Point(353, 107)
			Me.txtReplyPower.MaxLength = 1
			Me.txtReplyPower.Name = "txtReplyPower"
			Me.txtReplyPower.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtReplyPower.Size = New Global.System.Drawing.Size(37, 17)
			Me.txtReplyPower.TabIndex = 1006
			Me.txtReplyPower.TabStop = False
			Me.txtReplyPower.Text = "0"
			Me.txtReplyPower.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Button2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.Button2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Button2.ForeColor = Global.System.Drawing.Color.Black
			Me.Button2.Location = New Global.System.Drawing.Point(337, 95)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Global.System.Drawing.Size(161, 39)
			Me.Button2.TabIndex = 1005
			Me.Button2.Text = "الReply By اختيار رقم "
			Me.Button2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Button2.UseVisualStyleBackColor = False
			Me.txtUssdP2.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdP2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdP2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdP2.Location = New Global.System.Drawing.Point(172, 14)
			Me.txtUssdP2.Name = "txtUssdP2"
			Me.txtUssdP2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdP2.Size = New Global.System.Drawing.Size(159, 27)
			Me.txtUssdP2.TabIndex = 1004
			Me.txtUssdP2.Text = "*1*15*0#"
			Me.btnRunPowe2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunPowe2.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRunPowe2.Location = New Global.System.Drawing.Point(171, 47)
			Me.btnRunPowe2.Name = "btnRunPowe2"
			Me.btnRunPowe2.Size = New Global.System.Drawing.Size(162, 42)
			Me.btnRunPowe2.TabIndex = 1003
			Me.btnRunPowe2.Text = "تنفيذ"
			Me.btnRunPowe2.UseVisualStyleBackColor = False
			Me.txtTempxxp.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtTempxxp.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTempxxp.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTempxxp.Location = New Global.System.Drawing.Point(4, 239)
			Me.txtTempxxp.Name = "txtTempxxp"
			Me.txtTempxxp.[ReadOnly] = True
			Me.txtTempxxp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTempxxp.Size = New Global.System.Drawing.Size(243, 27)
			Me.txtTempxxp.TabIndex = 1002
			Me.Label47.AutoSize = True
			Me.Label47.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label47.ForeColor = Global.System.Drawing.Color.Black
			Me.Label47.Location = New Global.System.Drawing.Point(415, 206)
			Me.Label47.Name = "Label47"
			Me.Label47.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label47.Size = New Global.System.Drawing.Size(117, 17)
			Me.Label47.TabIndex = 1001
			Me.Label47.Text = "المحول له الهدية"
			Me.txtTransNumP.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNumP.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNumP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNumP.Location = New Global.System.Drawing.Point(378, 231)
			Me.txtTransNumP.MaxLength = 11
			Me.txtTransNumP.Name = "txtTransNumP"
			Me.txtTransNumP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNumP.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtTransNumP.TabIndex = 1000
			Me.txtTransNumP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopSVCP.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSVCP.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSVCP.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSVCP.Location = New Global.System.Drawing.Point(565, 44)
			Me.txtLoopSVCP.Name = "txtLoopSVCP"
			Me.txtLoopSVCP.[ReadOnly] = True
			Me.txtLoopSVCP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSVCP.Size = New Global.System.Drawing.Size(55, 24)
			Me.txtLoopSVCP.TabIndex = 990
			Me.txtLoopSVCP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFVCP.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFVCP.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFVCP.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFVCP.Location = New Global.System.Drawing.Point(566, 17)
			Me.txtLoopFVCP.Name = "txtLoopFVCP"
			Me.txtLoopFVCP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFVCP.Size = New Global.System.Drawing.Size(54, 24)
			Me.txtLoopFVCP.TabIndex = 989
			Me.txtLoopFVCP.Text = "1"
			Me.txtLoopFVCP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label45.AutoSize = True
			Me.Label45.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label45.ForeColor = Global.System.Drawing.Color.Black
			Me.Label45.Location = New Global.System.Drawing.Point(100, 147)
			Me.Label45.Name = "Label45"
			Me.Label45.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label45.Size = New Global.System.Drawing.Size(64, 17)
			Me.Label45.TabIndex = 988
			Me.Label45.Text = "مسلسل"
			Me.txtQtyDoneP.BackColor = Global.System.Drawing.Color.White
			Me.txtQtyDoneP.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtQtyDoneP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtQtyDoneP.Location = New Global.System.Drawing.Point(6, 147)
			Me.txtQtyDoneP.Name = "txtQtyDoneP"
			Me.txtQtyDoneP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtQtyDoneP.Size = New Global.System.Drawing.Size(81, 27)
			Me.txtQtyDoneP.TabIndex = 987
			Me.txtQtyDoneP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtUssdP1.BackColor = Global.System.Drawing.Color.White
			Me.txtUssdP1.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUssdP1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtUssdP1.Location = New Global.System.Drawing.Point(337, 14)
			Me.txtUssdP1.Name = "txtUssdP1"
			Me.txtUssdP1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtUssdP1.Size = New Global.System.Drawing.Size(159, 27)
			Me.txtUssdP1.TabIndex = 986
			Me.txtUssdP1.Text = "*1*2#"
			Me.btnRunPower.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRunPower.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRunPower.Location = New Global.System.Drawing.Point(336, 47)
			Me.btnRunPower.Name = "btnRunPower"
			Me.btnRunPower.Size = New Global.System.Drawing.Size(162, 42)
			Me.btnRunPower.TabIndex = 985
			Me.btnRunPower.Text = "تنفيذ"
			Me.btnRunPower.UseVisualStyleBackColor = False
			Me.btnAutoSendPower.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoSendPower.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAutoSendPower.Location = New Global.System.Drawing.Point(3, 177)
			Me.btnAutoSendPower.Name = "btnAutoSendPower"
			Me.btnAutoSendPower.Size = New Global.System.Drawing.Size(244, 54)
			Me.btnAutoSendPower.TabIndex = 984
			Me.btnAutoSendPower.Text = "ارسال الى كل الخطوط المحددة"
			Me.btnAutoSendPower.UseVisualStyleBackColor = False
			Me.lstNumbersP.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNumbersP.FormattingEnabled = True
			Me.lstNumbersP.ItemHeight = 23
			Me.lstNumbersP.Location = New Global.System.Drawing.Point(6, 44)
			Me.lstNumbersP.Name = "lstNumbersP"
			Me.lstNumbersP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNumbersP.Size = New Global.System.Drawing.Size(162, 27)
			Me.lstNumbersP.TabIndex = 972
			Me.txtEnumsVCP.BackColor = Global.System.Drawing.Color.White
			Me.txtEnumsVCP.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnumsVCP.ForeColor = Global.System.Drawing.Color.Black
			Me.txtEnumsVCP.Location = New Global.System.Drawing.Point(106, 11)
			Me.txtEnumsVCP.Name = "txtEnumsVCP"
			Me.txtEnumsVCP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnumsVCP.Size = New Global.System.Drawing.Size(58, 27)
			Me.txtEnumsVCP.TabIndex = 971
			Me.txtEnumsVCP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnNextItemsP.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnNextItemsP.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnNextItemsP.Location = New Global.System.Drawing.Point(3, 11)
			Me.btnNextItemsP.Name = "btnNextItemsP"
			Me.btnNextItemsP.Size = New Global.System.Drawing.Size(102, 27)
			Me.btnNextItemsP.TabIndex = 970
			Me.btnNextItemsP.Text = "هات الخطوط"
			Me.btnNextItemsP.UseVisualStyleBackColor = False
			Me.TabPage12.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage12.Controls.Add(Me.txtLoopSSD)
			Me.TabPage12.Controls.Add(Me.txtLoopFSD)
			Me.TabPage12.Controls.Add(Me.btnGetVodaBal)
			Me.TabPage12.Controls.Add(Me.btnChkOK)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmCancel)
			Me.TabPage12.Controls.Add(Me.btnViewSa3edList)
			Me.TabPage12.Controls.Add(Me.Label36)
			Me.TabPage12.Controls.Add(Me.Label35)
			Me.TabPage12.Controls.Add(Me.txtSa3edhmV)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmTrans)
			Me.TabPage12.Controls.Add(Me.txtSA3edhmReq)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmR5)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmR4)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmR3)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmR2)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmR1)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmRDell)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmRAdd)
			Me.TabPage12.Controls.Add(Me.txtSA3edhmNum)
			Me.TabPage12.Controls.Add(Me.btnSA3edhmReg)
			Me.TabPage12.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage12.Name = "TabPage12"
			Me.TabPage12.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage12.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage12.TabIndex = 11
			Me.TabPage12.Text = "Helping"
			Me.txtLoopSSD.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSD.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSD.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSD.Location = New Global.System.Drawing.Point(417, 92)
			Me.txtLoopSSD.Name = "txtLoopSSD"
			Me.txtLoopSSD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSD.Size = New Global.System.Drawing.Size(55, 24)
			Me.txtLoopSSD.TabIndex = 993
			Me.txtLoopSSD.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSD.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSD.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSD.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSD.Location = New Global.System.Drawing.Point(418, 68)
			Me.txtLoopFSD.Name = "txtLoopFSD"
			Me.txtLoopFSD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSD.Size = New Global.System.Drawing.Size(54, 24)
			Me.txtLoopFSD.TabIndex = 992
			Me.txtLoopFSD.Text = "1"
			Me.txtLoopFSD.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetVodaBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetVodaBal.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetVodaBal.Location = New Global.System.Drawing.Point(698, 222)
			Me.btnGetVodaBal.Name = "btnGetVodaBal"
			Me.btnGetVodaBal.Size = New Global.System.Drawing.Size(210, 66)
			Me.btnGetVodaBal.TabIndex = 982
			Me.btnGetVodaBal.Text = "استعلام عن الرصيد العادى للخط"
			Me.btnGetVodaBal.UseVisualStyleBackColor = False
			Me.btnChkOK.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnChkOK.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnChkOK.ForeColor = Global.System.Drawing.Color.Black
			Me.btnChkOK.Location = New Global.System.Drawing.Point(804, 86)
			Me.btnChkOK.Name = "btnChkOK"
			Me.btnChkOK.Size = New Global.System.Drawing.Size(104, 66)
			Me.btnChkOK.TabIndex = 981
			Me.btnChkOK.Text = "مراجعة التطابق"
			Me.btnChkOK.UseVisualStyleBackColor = False
			Me.btnSA3edhmCancel.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmCancel.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmCancel.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmCancel.Location = New Global.System.Drawing.Point(14, 221)
			Me.btnSA3edhmCancel.Name = "btnSA3edhmCancel"
			Me.btnSA3edhmCancel.Size = New Global.System.Drawing.Size(94, 38)
			Me.btnSA3edhmCancel.TabIndex = 980
			Me.btnSA3edhmCancel.Text = "الغاء"
			Me.btnSA3edhmCancel.UseVisualStyleBackColor = False
			Me.btnViewSa3edList.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnViewSa3edList.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnViewSa3edList.ForeColor = Global.System.Drawing.Color.Black
			Me.btnViewSa3edList.Location = New Global.System.Drawing.Point(698, 14)
			Me.btnViewSa3edList.Name = "btnViewSa3edList"
			Me.btnViewSa3edList.Size = New Global.System.Drawing.Size(212, 66)
			Me.btnViewSa3edList.TabIndex = 979
			Me.btnViewSa3edList.Text = "عرض قائمة الارقام"
			Me.btnViewSa3edList.UseVisualStyleBackColor = False
			Me.Label36.AutoSize = True
			Me.Label36.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label36.ForeColor = Global.System.Drawing.Color.Black
			Me.Label36.Location = New Global.System.Drawing.Point(546, 137)
			Me.Label36.Name = "Label36"
			Me.Label36.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label36.Size = New Global.System.Drawing.Size(117, 19)
			Me.Label36.TabIndex = 978
			Me.Label36.Text = "مسلسل الرقم"
			Me.Label35.AutoSize = True
			Me.Label35.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.Label35.ForeColor = Global.System.Drawing.Color.Black
			Me.Label35.Location = New Global.System.Drawing.Point(577, 24)
			Me.Label35.Name = "Label35"
			Me.Label35.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label35.Size = New Global.System.Drawing.Size(66, 24)
			Me.Label35.TabIndex = 977
			Me.Label35.Text = "المبلغ"
			Me.txtSa3edhmV.BackColor = Global.System.Drawing.Color.White
			Me.txtSa3edhmV.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSa3edhmV.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSa3edhmV.Location = New Global.System.Drawing.Point(478, 18)
			Me.txtSa3edhmV.Name = "txtSa3edhmV"
			Me.txtSa3edhmV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSa3edhmV.Size = New Global.System.Drawing.Size(90, 36)
			Me.txtSa3edhmV.TabIndex = 976
			Me.txtSa3edhmV.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnSA3edhmTrans.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmTrans.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmTrans.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmTrans.Location = New Global.System.Drawing.Point(478, 59)
			Me.btnSA3edhmTrans.Name = "btnSA3edhmTrans"
			Me.btnSA3edhmTrans.Size = New Global.System.Drawing.Size(165, 57)
			Me.btnSA3edhmTrans.TabIndex = 911
			Me.btnSA3edhmTrans.Text = "تحويل"
			Me.btnSA3edhmTrans.UseVisualStyleBackColor = False
			Me.txtSA3edhmReq.BackColor = Global.System.Drawing.Color.White
			Me.txtSA3edhmReq.Font = New Global.System.Drawing.Font("Tahoma", 20F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSA3edhmReq.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSA3edhmReq.Location = New Global.System.Drawing.Point(478, 123)
			Me.txtSA3edhmReq.MaxLength = 11
			Me.txtSA3edhmReq.Name = "txtSA3edhmReq"
			Me.txtSA3edhmReq.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSA3edhmReq.Size = New Global.System.Drawing.Size(62, 40)
			Me.txtSA3edhmReq.TabIndex = 910
			Me.btnSA3edhmR5.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmR5.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmR5.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmR5.Location = New Global.System.Drawing.Point(116, 222)
			Me.btnSA3edhmR5.Name = "btnSA3edhmR5"
			Me.btnSA3edhmR5.Size = New Global.System.Drawing.Size(32, 38)
			Me.btnSA3edhmR5.TabIndex = 908
			Me.btnSA3edhmR5.Text = "5"
			Me.btnSA3edhmR5.UseVisualStyleBackColor = False
			Me.btnSA3edhmR4.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmR4.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmR4.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmR4.Location = New Global.System.Drawing.Point(152, 222)
			Me.btnSA3edhmR4.Name = "btnSA3edhmR4"
			Me.btnSA3edhmR4.Size = New Global.System.Drawing.Size(32, 38)
			Me.btnSA3edhmR4.TabIndex = 907
			Me.btnSA3edhmR4.Text = "4"
			Me.btnSA3edhmR4.UseVisualStyleBackColor = False
			Me.btnSA3edhmR3.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmR3.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmR3.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmR3.Location = New Global.System.Drawing.Point(188, 222)
			Me.btnSA3edhmR3.Name = "btnSA3edhmR3"
			Me.btnSA3edhmR3.Size = New Global.System.Drawing.Size(32, 38)
			Me.btnSA3edhmR3.TabIndex = 906
			Me.btnSA3edhmR3.Text = "3"
			Me.btnSA3edhmR3.UseVisualStyleBackColor = False
			Me.btnSA3edhmR2.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmR2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmR2.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmR2.Location = New Global.System.Drawing.Point(224, 222)
			Me.btnSA3edhmR2.Name = "btnSA3edhmR2"
			Me.btnSA3edhmR2.Size = New Global.System.Drawing.Size(32, 38)
			Me.btnSA3edhmR2.TabIndex = 905
			Me.btnSA3edhmR2.Text = "2"
			Me.btnSA3edhmR2.UseVisualStyleBackColor = False
			Me.btnSA3edhmR1.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmR1.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmR1.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmR1.Location = New Global.System.Drawing.Point(260, 222)
			Me.btnSA3edhmR1.Name = "btnSA3edhmR1"
			Me.btnSA3edhmR1.Size = New Global.System.Drawing.Size(32, 38)
			Me.btnSA3edhmR1.TabIndex = 904
			Me.btnSA3edhmR1.Text = "1"
			Me.btnSA3edhmR1.UseVisualStyleBackColor = False
			Me.btnSA3edhmRDell.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmRDell.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmRDell.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmRDell.Location = New Global.System.Drawing.Point(14, 179)
			Me.btnSA3edhmRDell.Name = "btnSA3edhmRDell"
			Me.btnSA3edhmRDell.Size = New Global.System.Drawing.Size(278, 38)
			Me.btnSA3edhmRDell.TabIndex = 903
			Me.btnSA3edhmRDell.Text = "حذف من قائمة ساعدهم"
			Me.btnSA3edhmRDell.UseVisualStyleBackColor = False
			Me.btnSA3edhmRAdd.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmRAdd.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmRAdd.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmRAdd.Location = New Global.System.Drawing.Point(6, 94)
			Me.btnSA3edhmRAdd.Name = "btnSA3edhmRAdd"
			Me.btnSA3edhmRAdd.Size = New Global.System.Drawing.Size(151, 38)
			Me.btnSA3edhmRAdd.TabIndex = 902
			Me.btnSA3edhmRAdd.Text = "اضافة الرقم"
			Me.btnSA3edhmRAdd.UseVisualStyleBackColor = False
			Me.txtSA3edhmNum.BackColor = Global.System.Drawing.Color.White
			Me.txtSA3edhmNum.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSA3edhmNum.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSA3edhmNum.Location = New Global.System.Drawing.Point(6, 61)
			Me.txtSA3edhmNum.MaxLength = 11
			Me.txtSA3edhmNum.Name = "txtSA3edhmNum"
			Me.txtSA3edhmNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSA3edhmNum.Size = New Global.System.Drawing.Size(150, 27)
			Me.txtSA3edhmNum.TabIndex = 901
			Me.btnSA3edhmReg.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSA3edhmReg.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSA3edhmReg.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSA3edhmReg.Location = New Global.System.Drawing.Point(6, 14)
			Me.btnSA3edhmReg.Name = "btnSA3edhmReg"
			Me.btnSA3edhmReg.Size = New Global.System.Drawing.Size(151, 38)
			Me.btnSA3edhmReg.TabIndex = 900
			Me.btnSA3edhmReg.Text = "اشتراك فى الخدمة"
			Me.btnSA3edhmReg.UseVisualStyleBackColor = False
			Me.TabPage13.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage13.Controls.Add(Me.txtArrayOut)
			Me.TabPage13.Controls.Add(Me.lblCorrectNumber)
			Me.TabPage13.Controls.Add(Me.Label41)
			Me.TabPage13.Controls.Add(Me.Label43)
			Me.TabPage13.Controls.Add(Me.btnAutoVCnormCon)
			Me.TabPage13.Controls.Add(Me.Label44)
			Me.TabPage13.Controls.Add(Me.txtTransNum2Con)
			Me.TabPage13.Controls.Add(Me.txtCashNextMasterCon)
			Me.TabPage13.Controls.Add(Me.lblMainCon)
			Me.TabPage13.Controls.Add(Me.Label46)
			Me.TabPage13.Controls.Add(Me.txtMonyMnCon)
			Me.TabPage13.Controls.Add(Me.btnGetBal2Con)
			Me.TabPage13.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage13.Name = "TabPage13"
			Me.TabPage13.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage13.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage13.TabIndex = 13
			Me.TabPage13.Text = "VFDec"
			Me.txtArrayOut.BackColor = Global.System.Drawing.Color.Black
			Me.txtArrayOut.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtArrayOut.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtArrayOut.Location = New Global.System.Drawing.Point(6, 89)
			Me.txtArrayOut.Multiline = True
			Me.txtArrayOut.Name = "txtArrayOut"
			Me.txtArrayOut.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtArrayOut.Size = New Global.System.Drawing.Size(277, 178)
			Me.txtArrayOut.TabIndex = 1014
			Me.lblCorrectNumber.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.lblCorrectNumber.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblCorrectNumber.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCorrectNumber.ForeColor = Global.System.Drawing.Color.Black
			Me.lblCorrectNumber.Location = New Global.System.Drawing.Point(291, 236)
			Me.lblCorrectNumber.Name = "lblCorrectNumber"
			Me.lblCorrectNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblCorrectNumber.Size = New Global.System.Drawing.Size(37, 31)
			Me.lblCorrectNumber.TabIndex = 1013
			Me.lblCorrectNumber.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label41.AutoSize = True
			Me.Label41.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label41.ForeColor = Global.System.Drawing.Color.Black
			Me.Label41.Location = New Global.System.Drawing.Point(752, 149)
			Me.Label41.Name = "Label41"
			Me.Label41.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label41.Size = New Global.System.Drawing.Size(115, 17)
			Me.Label41.TabIndex = 1011
			Me.Label41.Text = "الاساسى التالى"
			Me.Label43.AutoSize = True
			Me.Label43.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label43.ForeColor = Global.System.Drawing.Color.Black
			Me.Label43.Location = New Global.System.Drawing.Point(787, 23)
			Me.Label43.Name = "Label43"
			Me.Label43.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label43.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label43.TabIndex = 1010
			Me.Label43.Text = "المبلغ"
			Me.btnAutoVCnormCon.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVCnormCon.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAutoVCnormCon.Location = New Global.System.Drawing.Point(250, 15)
			Me.btnAutoVCnormCon.Name = "btnAutoVCnormCon"
			Me.btnAutoVCnormCon.Size = New Global.System.Drawing.Size(161, 54)
			Me.btnAutoVCnormCon.TabIndex = 1009
			Me.btnAutoVCnormCon.Text = "تشغيل ذكى مشروط"
			Me.btnAutoVCnormCon.UseVisualStyleBackColor = False
			Me.Label44.AutoSize = True
			Me.Label44.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label44.ForeColor = Global.System.Drawing.Color.Black
			Me.Label44.Location = New Global.System.Drawing.Point(43, 10)
			Me.Label44.Name = "Label44"
			Me.Label44.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label44.Size = New Global.System.Drawing.Size(117, 17)
			Me.Label44.TabIndex = 1008
			Me.Label44.Text = "المحول له الهدية"
			Me.txtTransNum2Con.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNum2Con.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNum2Con.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum2Con.Location = New Global.System.Drawing.Point(6, 32)
			Me.txtTransNum2Con.MaxLength = 11
			Me.txtTransNum2Con.Name = "txtTransNum2Con"
			Me.txtTransNum2Con.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum2Con.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtTransNum2Con.TabIndex = 1007
			Me.txtTransNum2Con.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtCashNextMasterCon.BackColor = Global.System.Drawing.Color.White
			Me.txtCashNextMasterCon.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCashNextMasterCon.ForeColor = Global.System.Drawing.Color.Black
			Me.txtCashNextMasterCon.Location = New Global.System.Drawing.Point(704, 170)
			Me.txtCashNextMasterCon.MaxLength = 11
			Me.txtCashNextMasterCon.Name = "txtCashNextMasterCon"
			Me.txtCashNextMasterCon.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCashNextMasterCon.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtCashNextMasterCon.TabIndex = 1006
			Me.txtCashNextMasterCon.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblMainCon.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.lblMainCon.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblMainCon.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblMainCon.ForeColor = Global.System.Drawing.Color.Black
			Me.lblMainCon.Location = New Global.System.Drawing.Point(704, 100)
			Me.lblMainCon.Name = "lblMainCon"
			Me.lblMainCon.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblMainCon.Size = New Global.System.Drawing.Size(202, 38)
			Me.lblMainCon.TabIndex = 1005
			Me.lblMainCon.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label46.AutoSize = True
			Me.Label46.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label46.ForeColor = Global.System.Drawing.Color.Black
			Me.Label46.Location = New Global.System.Drawing.Point(772, 81)
			Me.Label46.Name = "Label46"
			Me.Label46.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label46.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label46.TabIndex = 1004
			Me.Label46.Text = "الاساسى"
			Me.txtMonyMnCon.BackColor = Global.System.Drawing.Color.White
			Me.txtMonyMnCon.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMonyMnCon.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMonyMnCon.Location = New Global.System.Drawing.Point(758, 43)
			Me.txtMonyMnCon.Name = "txtMonyMnCon"
			Me.txtMonyMnCon.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMonyMnCon.Size = New Global.System.Drawing.Size(99, 36)
			Me.txtMonyMnCon.TabIndex = 1003
			Me.txtMonyMnCon.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetBal2Con.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBal2Con.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetBal2Con.Location = New Global.System.Drawing.Point(704, 215)
			Me.btnGetBal2Con.Name = "btnGetBal2Con"
			Me.btnGetBal2Con.Size = New Global.System.Drawing.Size(202, 37)
			Me.btnGetBal2Con.TabIndex = 1002
			Me.btnGetBal2Con.Text = "استعلام عن رصيدالكاش"
			Me.btnGetBal2Con.UseVisualStyleBackColor = False
			Me.TabPage6.BackColor = Global.System.Drawing.Color.Red
			Me.TabPage6.Controls.Add(Me.txtNextPortNum)
			Me.TabPage6.Controls.Add(Me.txtRemTimeVC)
			Me.TabPage6.Controls.Add(Me.btnVCChargeToSelf)
			Me.TabPage6.Controls.Add(Me.txtLoopSvc2)
			Me.TabPage6.Controls.Add(Me.txtLoopFvc2)
			Me.TabPage6.Controls.Add(Me.btnVC6)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS6Dly)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS5Dly)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS4Dly)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS3Dly)
			Me.TabPage6.Controls.Add(Me.Label31)
			Me.TabPage6.Controls.Add(Me.Label19)
			Me.TabPage6.Controls.Add(Me.Label18)
			Me.TabPage6.Controls.Add(Me.Label17)
			Me.TabPage6.Controls.Add(Me.Label16)
			Me.TabPage6.Controls.Add(Me.Label15)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS6)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS5)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS4)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS3)
			Me.TabPage6.Controls.Add(Me.txtMoneyMS2)
			Me.TabPage6.Controls.Add(Me.Label13)
			Me.TabPage6.Controls.Add(Me.txtMS02)
			Me.TabPage6.Controls.Add(Me.btnTransToA)
			Me.TabPage6.Controls.Add(Me.Label10)
			Me.TabPage6.Controls.Add(Me.btnArrangIT)
			Me.TabPage6.Controls.Add(Me.txtPassMs)
			Me.TabPage6.Controls.Add(Me.Label7)
			Me.TabPage6.Controls.Add(Me.txtMS01)
			Me.TabPage6.Controls.Add(Me.btnGetBalMS)
			Me.TabPage6.Controls.Add(Me.btnTransTo)
			Me.TabPage6.Controls.Add(Me.btnTransFromMS)
			Me.TabPage6.Controls.Add(Me.Label4)
			Me.TabPage6.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage6.Name = "TabPage6"
			Me.TabPage6.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage6.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage6.TabIndex = 5
			Me.TabPage6.Text = "VFMaster"
			Me.txtNextPortNum.BackColor = Global.System.Drawing.Color.Black
			Me.txtNextPortNum.Font = New Global.System.Drawing.Font("Tahoma", 20F, Global.System.Drawing.FontStyle.Bold)
			Me.txtNextPortNum.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtNextPortNum.Location = New Global.System.Drawing.Point(195, 175)
			Me.txtNextPortNum.Name = "txtNextPortNum"
			Me.txtNextPortNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtNextPortNum.Size = New Global.System.Drawing.Size(41, 40)
			Me.txtNextPortNum.TabIndex = 985
			Me.txtNextPortNum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRemTimeVC.BackColor = Global.System.Drawing.Color.Black
			Me.txtRemTimeVC.Font = New Global.System.Drawing.Font("Tahoma", 20F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRemTimeVC.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtRemTimeVC.Location = New Global.System.Drawing.Point(237, 175)
			Me.txtRemTimeVC.Name = "txtRemTimeVC"
			Me.txtRemTimeVC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtRemTimeVC.Size = New Global.System.Drawing.Size(142, 40)
			Me.txtRemTimeVC.TabIndex = 982
			Me.txtRemTimeVC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnVCChargeToSelf.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVCChargeToSelf.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnVCChargeToSelf.Location = New Global.System.Drawing.Point(167, 228)
			Me.btnVCChargeToSelf.Name = "btnVCChargeToSelf"
			Me.btnVCChargeToSelf.Size = New Global.System.Drawing.Size(314, 36)
			Me.btnVCChargeToSelf.TabIndex = 989
			Me.btnVCChargeToSelf.Text = "شحن كل خط بالمبلغ من نفسة من فودافون كاش"
			Me.btnVCChargeToSelf.UseVisualStyleBackColor = False
			Me.txtLoopSvc2.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSvc2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSvc2.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSvc2.Location = New Global.System.Drawing.Point(106, 238)
			Me.txtLoopSvc2.Name = "txtLoopSvc2"
			Me.txtLoopSvc2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSvc2.Size = New Global.System.Drawing.Size(55, 24)
			Me.txtLoopSvc2.TabIndex = 991
			Me.txtLoopSvc2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFvc2.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFvc2.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFvc2.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFvc2.Location = New Global.System.Drawing.Point(107, 214)
			Me.txtLoopFvc2.Name = "txtLoopFvc2"
			Me.txtLoopFvc2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFvc2.Size = New Global.System.Drawing.Size(54, 24)
			Me.txtLoopFvc2.TabIndex = 990
			Me.txtLoopFvc2.Text = "1"
			Me.txtLoopFvc2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnVC6.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnVC6.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnVC6.Location = New Global.System.Drawing.Point(14, 218)
			Me.btnVC6.Name = "btnVC6"
			Me.btnVC6.Size = New Global.System.Drawing.Size(86, 44)
			Me.btnVC6.TabIndex = 992
			Me.btnVC6.Text = "*6#"
			Me.btnVC6.UseVisualStyleBackColor = False
			Me.txtMoneyMS6Dly.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.txtMoneyMS6Dly.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS6Dly.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS6Dly.Location = New Global.System.Drawing.Point(385, 129)
			Me.txtMoneyMS6Dly.Name = "txtMoneyMS6Dly"
			Me.txtMoneyMS6Dly.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS6Dly.Size = New Global.System.Drawing.Size(53, 27)
			Me.txtMoneyMS6Dly.TabIndex = 972
			Me.txtMoneyMS6Dly.Text = "0"
			Me.txtMoneyMS6Dly.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS5Dly.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.txtMoneyMS5Dly.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS5Dly.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS5Dly.Location = New Global.System.Drawing.Point(385, 100)
			Me.txtMoneyMS5Dly.Name = "txtMoneyMS5Dly"
			Me.txtMoneyMS5Dly.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS5Dly.Size = New Global.System.Drawing.Size(53, 27)
			Me.txtMoneyMS5Dly.TabIndex = 971
			Me.txtMoneyMS5Dly.Text = "0"
			Me.txtMoneyMS5Dly.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS4Dly.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.txtMoneyMS4Dly.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS4Dly.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS4Dly.Location = New Global.System.Drawing.Point(385, 70)
			Me.txtMoneyMS4Dly.Name = "txtMoneyMS4Dly"
			Me.txtMoneyMS4Dly.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS4Dly.Size = New Global.System.Drawing.Size(53, 27)
			Me.txtMoneyMS4Dly.TabIndex = 970
			Me.txtMoneyMS4Dly.Text = "0"
			Me.txtMoneyMS4Dly.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS3Dly.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.txtMoneyMS3Dly.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS3Dly.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS3Dly.Location = New Global.System.Drawing.Point(385, 40)
			Me.txtMoneyMS3Dly.Name = "txtMoneyMS3Dly"
			Me.txtMoneyMS3Dly.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS3Dly.Size = New Global.System.Drawing.Size(53, 27)
			Me.txtMoneyMS3Dly.TabIndex = 969
			Me.txtMoneyMS3Dly.Text = "0"
			Me.txtMoneyMS3Dly.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label31.AutoSize = True
			Me.Label31.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label31.ForeColor = Global.System.Drawing.Color.White
			Me.Label31.Location = New Global.System.Drawing.Point(392, 8)
			Me.Label31.Name = "Label31"
			Me.Label31.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label31.Size = New Global.System.Drawing.Size(46, 17)
			Me.Label31.TabIndex = 967
			Me.Label31.Text = "دقيقة"
			Me.Label19.AutoSize = True
			Me.Label19.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label19.ForeColor = Global.System.Drawing.Color.White
			Me.Label19.Location = New Global.System.Drawing.Point(288, 147)
			Me.Label19.Name = "Label19"
			Me.Label19.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label19.Size = New Global.System.Drawing.Size(17, 17)
			Me.Label19.TabIndex = 966
			Me.Label19.Text = "6"
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label18.ForeColor = Global.System.Drawing.Color.White
			Me.Label18.Location = New Global.System.Drawing.Point(288, 118)
			Me.Label18.Name = "Label18"
			Me.Label18.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label18.Size = New Global.System.Drawing.Size(17, 17)
			Me.Label18.TabIndex = 965
			Me.Label18.Text = "5"
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label17.ForeColor = Global.System.Drawing.Color.White
			Me.Label17.Location = New Global.System.Drawing.Point(288, 91)
			Me.Label17.Name = "Label17"
			Me.Label17.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label17.Size = New Global.System.Drawing.Size(17, 17)
			Me.Label17.TabIndex = 964
			Me.Label17.Text = "4"
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label16.ForeColor = Global.System.Drawing.Color.White
			Me.Label16.Location = New Global.System.Drawing.Point(288, 62)
			Me.Label16.Name = "Label16"
			Me.Label16.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label16.Size = New Global.System.Drawing.Size(17, 17)
			Me.Label16.TabIndex = 963
			Me.Label16.Text = "3"
			Me.Label15.AutoSize = True
			Me.Label15.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label15.ForeColor = Global.System.Drawing.Color.White
			Me.Label15.Location = New Global.System.Drawing.Point(288, 34)
			Me.Label15.Name = "Label15"
			Me.Label15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label15.Size = New Global.System.Drawing.Size(17, 17)
			Me.Label15.TabIndex = 962
			Me.Label15.Text = "2"
			Me.txtMoneyMS6.BackColor = Global.System.Drawing.Color.White
			Me.txtMoneyMS6.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS6.Location = New Global.System.Drawing.Point(308, 142)
			Me.txtMoneyMS6.Name = "txtMoneyMS6"
			Me.txtMoneyMS6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS6.Size = New Global.System.Drawing.Size(75, 27)
			Me.txtMoneyMS6.TabIndex = 960
			Me.txtMoneyMS6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS5.BackColor = Global.System.Drawing.Color.White
			Me.txtMoneyMS5.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS5.Location = New Global.System.Drawing.Point(308, 113)
			Me.txtMoneyMS5.Name = "txtMoneyMS5"
			Me.txtMoneyMS5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS5.Size = New Global.System.Drawing.Size(75, 27)
			Me.txtMoneyMS5.TabIndex = 959
			Me.txtMoneyMS5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS4.BackColor = Global.System.Drawing.Color.White
			Me.txtMoneyMS4.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS4.Location = New Global.System.Drawing.Point(308, 86)
			Me.txtMoneyMS4.Name = "txtMoneyMS4"
			Me.txtMoneyMS4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS4.Size = New Global.System.Drawing.Size(75, 27)
			Me.txtMoneyMS4.TabIndex = 958
			Me.txtMoneyMS4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS3.BackColor = Global.System.Drawing.Color.White
			Me.txtMoneyMS3.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS3.Location = New Global.System.Drawing.Point(308, 57)
			Me.txtMoneyMS3.Name = "txtMoneyMS3"
			Me.txtMoneyMS3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS3.Size = New Global.System.Drawing.Size(75, 27)
			Me.txtMoneyMS3.TabIndex = 957
			Me.txtMoneyMS3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMoneyMS2.BackColor = Global.System.Drawing.Color.White
			Me.txtMoneyMS2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMoneyMS2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMoneyMS2.Location = New Global.System.Drawing.Point(308, 29)
			Me.txtMoneyMS2.Name = "txtMoneyMS2"
			Me.txtMoneyMS2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMoneyMS2.Size = New Global.System.Drawing.Size(75, 27)
			Me.txtMoneyMS2.TabIndex = 956
			Me.txtMoneyMS2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label13.ForeColor = Global.System.Drawing.Color.White
			Me.Label13.Location = New Global.System.Drawing.Point(150, 92)
			Me.Label13.Name = "Label13"
			Me.Label13.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label13.Size = New Global.System.Drawing.Size(94, 17)
			Me.Label13.TabIndex = 955
			Me.Label13.Text = "خط الماستر2"
			Me.txtMS02.BackColor = Global.System.Drawing.Color.White
			Me.txtMS02.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMS02.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMS02.Location = New Global.System.Drawing.Point(18, 86)
			Me.txtMS02.MaxLength = 11
			Me.txtMS02.Name = "txtMS02"
			Me.txtMS02.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMS02.Size = New Global.System.Drawing.Size(126, 27)
			Me.txtMS02.TabIndex = 954
			Me.txtMS02.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransToA.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransToA.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransToA.Location = New Global.System.Drawing.Point(720, 133)
			Me.btnTransToA.Name = "btnTransToA"
			Me.btnTransToA.Size = New Global.System.Drawing.Size(186, 65)
			Me.btnTransToA.TabIndex = 953
			Me.btnTransToA.Text = "سحب كل الرصيد من الخطوط كاش"
			Me.btnTransToA.UseVisualStyleBackColor = False
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ForeColor = Global.System.Drawing.Color.White
			Me.Label10.Location = New Global.System.Drawing.Point(97, 35)
			Me.Label10.Name = "Label10"
			Me.Label10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label10.Size = New Global.System.Drawing.Size(146, 17)
			Me.Label10.TabIndex = 900
			Me.Label10.Text = "كلمة سر خط الماستر"
			Me.btnArrangIT.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnArrangIT.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnArrangIT.Location = New Global.System.Drawing.Point(18, 116)
			Me.btnArrangIT.Name = "btnArrangIT"
			Me.btnArrangIT.Size = New Global.System.Drawing.Size(126, 27)
			Me.btnArrangIT.TabIndex = 952
			Me.btnArrangIT.Text = "ترتيب الخطوط"
			Me.btnArrangIT.UseVisualStyleBackColor = False
			Me.txtPassMs.BackColor = Global.System.Drawing.Color.White
			Me.txtPassMs.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPassMs.ForeColor = Global.System.Drawing.Color.Black
			Me.txtPassMs.Location = New Global.System.Drawing.Point(18, 30)
			Me.txtPassMs.MaxLength = 6
			Me.txtPassMs.Name = "txtPassMs"
			Me.txtPassMs.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPassMs.Size = New Global.System.Drawing.Size(77, 27)
			Me.txtPassMs.TabIndex = 899
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label7.ForeColor = Global.System.Drawing.Color.White
			Me.Label7.Location = New Global.System.Drawing.Point(150, 61)
			Me.Label7.Name = "Label7"
			Me.Label7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label7.Size = New Global.System.Drawing.Size(94, 17)
			Me.Label7.TabIndex = 950
			Me.Label7.Text = "خط الماستر1"
			Me.txtMS01.BackColor = Global.System.Drawing.Color.White
			Me.txtMS01.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMS01.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMS01.Location = New Global.System.Drawing.Point(18, 57)
			Me.txtMS01.MaxLength = 11
			Me.txtMS01.Name = "txtMS01"
			Me.txtMS01.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMS01.Size = New Global.System.Drawing.Size(126, 27)
			Me.txtMS01.TabIndex = 947
			Me.txtMS01.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetBalMS.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBalMS.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetBalMS.Location = New Global.System.Drawing.Point(14, 149)
			Me.btnGetBalMS.Name = "btnGetBalMS"
			Me.btnGetBalMS.Size = New Global.System.Drawing.Size(126, 49)
			Me.btnGetBalMS.TabIndex = 906
			Me.btnGetBalMS.Text = "استعلام عن الرصيد"
			Me.btnGetBalMS.UseVisualStyleBackColor = False
			Me.btnTransTo.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransTo.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransTo.Location = New Global.System.Drawing.Point(720, 70)
			Me.btnTransTo.Name = "btnTransTo"
			Me.btnTransTo.Size = New Global.System.Drawing.Size(186, 48)
			Me.btnTransTo.TabIndex = 905
			Me.btnTransTo.Text = "سحب رصيد من الخطوط"
			Me.btnTransTo.UseVisualStyleBackColor = False
			Me.btnTransFromMS.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransFromMS.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnTransFromMS.Location = New Global.System.Drawing.Point(720, 14)
			Me.btnTransFromMS.Name = "btnTransFromMS"
			Me.btnTransFromMS.Size = New Global.System.Drawing.Size(186, 51)
			Me.btnTransFromMS.TabIndex = 904
			Me.btnTransFromMS.Text = "تحويل من الماستر"
			Me.btnTransFromMS.UseVisualStyleBackColor = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label4.ForeColor = Global.System.Drawing.Color.White
			Me.Label4.Location = New Global.System.Drawing.Point(321, 8)
			Me.Label4.Name = "Label4"
			Me.Label4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label4.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label4.TabIndex = 903
			Me.Label4.Text = "المبلغ"
			Me.tabTayer.BackColor = Global.System.Drawing.Color.FromArgb(192, 0, 0)
			Me.tabTayer.Controls.Add(Me.ckbtnTayerPullAllBalsMony)
			Me.tabTayer.Controls.Add(Me.btnTayerPullAllBalsMony)
			Me.tabTayer.Controls.Add(Me.btnTayerKikOut)
			Me.tabTayer.Controls.Add(Me.Label90)
			Me.tabTayer.Controls.Add(Me.btnAddCodeToTayer)
			Me.tabTayer.Controls.Add(Me.txtCodeTayer)
			Me.tabTayer.Controls.Add(Me.ckbtnTayerPullAllBals)
			Me.tabTayer.Controls.Add(Me.btnTayerPullAllBals)
			Me.tabTayer.Controls.Add(Me.ckbtnTayerSeries)
			Me.tabTayer.Controls.Add(Me.CheckBox2)
			Me.tabTayer.Controls.Add(Me.txtTayerF)
			Me.tabTayer.Controls.Add(Me.txtTayerS)
			Me.tabTayer.Controls.Add(Me.ckTayerGetBal)
			Me.tabTayer.Controls.Add(Me.btnTayerfromMtoN)
			Me.tabTayer.Controls.Add(Me.Label80)
			Me.tabTayer.Controls.Add(Me.TextBox1)
			Me.tabTayer.Controls.Add(Me.btnAutoVC_ChargeTayer)
			Me.tabTayer.Controls.Add(Me.Label70)
			Me.tabTayer.Controls.Add(Me.txtTayerPass)
			Me.tabTayer.Controls.Add(Me.ckTayerSub)
			Me.tabTayer.Controls.Add(Me.txtTayerSub)
			Me.tabTayer.Controls.Add(Me.btnTayerEX)
			Me.tabTayer.Controls.Add(Me.btnTayerSeries)
			Me.tabTayer.Controls.Add(Me.Label75)
			Me.tabTayer.Controls.Add(Me.Label79)
			Me.tabTayer.Controls.Add(Me.txtTayerNextMain)
			Me.tabTayer.Controls.Add(Me.lblTayerMain)
			Me.tabTayer.Controls.Add(Me.Label81)
			Me.tabTayer.Controls.Add(Me.txtTayerValue)
			Me.tabTayer.Controls.Add(Me.btnTayerGetBal)
			Me.tabTayer.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabTayer.Name = "tabTayer"
			Me.tabTayer.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tabTayer.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabTayer.TabIndex = 23
			Me.tabTayer.Text = "Tayer"
			Me.ckbtnTayerPullAllBalsMony.AutoSize = True
			Me.ckbtnTayerPullAllBalsMony.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTayerPullAllBalsMony.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTayerPullAllBalsMony.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTayerPullAllBalsMony.Location = New Global.System.Drawing.Point(355, 17)
			Me.ckbtnTayerPullAllBalsMony.Name = "ckbtnTayerPullAllBalsMony"
			Me.ckbtnTayerPullAllBalsMony.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTayerPullAllBalsMony.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTayerPullAllBalsMony.TabIndex = 1101
			Me.ckbtnTayerPullAllBalsMony.Text = "Auto"
			Me.ckbtnTayerPullAllBalsMony.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTayerPullAllBalsMony.UseVisualStyleBackColor = False
			Me.btnTayerPullAllBalsMony.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerPullAllBalsMony.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerPullAllBalsMony.Location = New Global.System.Drawing.Point(211, 14)
			Me.btnTayerPullAllBalsMony.Name = "btnTayerPullAllBalsMony"
			Me.btnTayerPullAllBalsMony.Size = New Global.System.Drawing.Size(203, 87)
			Me.btnTayerPullAllBalsMony.TabIndex = 1100
			Me.btnTayerPullAllBalsMony.Text = "سحب من الكل الى النالى"
			Me.btnTayerPullAllBalsMony.UseVisualStyleBackColor = False
			Me.btnTayerKikOut.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerKikOut.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerKikOut.Location = New Global.System.Drawing.Point(726, 108)
			Me.btnTayerKikOut.Name = "btnTayerKikOut"
			Me.btnTayerKikOut.Size = New Global.System.Drawing.Size(189, 52)
			Me.btnTayerKikOut.TabIndex = 1099
			Me.btnTayerKikOut.Text = "Opt-Out"
			Me.btnTayerKikOut.UseVisualStyleBackColor = False
			Me.Label90.AutoSize = True
			Me.Label90.Font = New Global.System.Drawing.Font("Tahoma", 20F, Global.System.Drawing.FontStyle.Bold)
			Me.Label90.ForeColor = Global.System.Drawing.Color.Black
			Me.Label90.Location = New Global.System.Drawing.Point(718, 68)
			Me.Label90.Name = "Label90"
			Me.Label90.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label90.Size = New Global.System.Drawing.Size(33, 33)
			Me.Label90.TabIndex = 1098
			Me.Label90.Text = "A"
			Me.btnAddCodeToTayer.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAddCodeToTayer.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAddCodeToTayer.Location = New Global.System.Drawing.Point(726, 8)
			Me.btnAddCodeToTayer.Name = "btnAddCodeToTayer"
			Me.btnAddCodeToTayer.Size = New Global.System.Drawing.Size(189, 52)
			Me.btnAddCodeToTayer.TabIndex = 1097
			Me.btnAddCodeToTayer.Text = "Opt-in"
			Me.btnAddCodeToTayer.UseVisualStyleBackColor = False
			Me.txtCodeTayer.BackColor = Global.System.Drawing.Color.White
			Me.txtCodeTayer.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtCodeTayer.ForeColor = Global.System.Drawing.Color.Black
			Me.txtCodeTayer.Location = New Global.System.Drawing.Point(757, 66)
			Me.txtCodeTayer.MaxLength = 20
			Me.txtCodeTayer.Name = "txtCodeTayer"
			Me.txtCodeTayer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtCodeTayer.Size = New Global.System.Drawing.Size(158, 36)
			Me.txtCodeTayer.TabIndex = 1095
			Me.txtCodeTayer.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckbtnTayerPullAllBals.AutoSize = True
			Me.ckbtnTayerPullAllBals.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTayerPullAllBals.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTayerPullAllBals.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTayerPullAllBals.Location = New Global.System.Drawing.Point(858, 205)
			Me.ckbtnTayerPullAllBals.Name = "ckbtnTayerPullAllBals"
			Me.ckbtnTayerPullAllBals.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTayerPullAllBals.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTayerPullAllBals.TabIndex = 1094
			Me.ckbtnTayerPullAllBals.Text = "Auto"
			Me.ckbtnTayerPullAllBals.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTayerPullAllBals.UseVisualStyleBackColor = False
			Me.btnTayerPullAllBals.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerPullAllBals.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerPullAllBals.Location = New Global.System.Drawing.Point(714, 202)
			Me.btnTayerPullAllBals.Name = "btnTayerPullAllBals"
			Me.btnTayerPullAllBals.Size = New Global.System.Drawing.Size(203, 87)
			Me.btnTayerPullAllBals.TabIndex = 1093
			Me.btnTayerPullAllBals.Text = "سحب كل رصيد الطاير على الاساسى التالى"
			Me.btnTayerPullAllBals.UseVisualStyleBackColor = False
			Me.ckbtnTayerSeries.AutoSize = True
			Me.ckbtnTayerSeries.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTayerSeries.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTayerSeries.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTayerSeries.Location = New Global.System.Drawing.Point(564, 10)
			Me.ckbtnTayerSeries.Name = "ckbtnTayerSeries"
			Me.ckbtnTayerSeries.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTayerSeries.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckbtnTayerSeries.TabIndex = 1092
			Me.ckbtnTayerSeries.Text = "Auto"
			Me.ckbtnTayerSeries.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTayerSeries.UseVisualStyleBackColor = False
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.CheckBox2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.CheckBox2.ForeColor = Global.System.Drawing.Color.Black
			Me.CheckBox2.Location = New Global.System.Drawing.Point(127, 23)
			Me.CheckBox2.Name = "CheckBox2"
			Me.CheckBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.CheckBox2.Size = New Global.System.Drawing.Size(53, 17)
			Me.CheckBox2.TabIndex = 1091
			Me.CheckBox2.Text = "Auto"
			Me.CheckBox2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.CheckBox2.UseVisualStyleBackColor = False
			Me.txtTayerF.BackColor = Global.System.Drawing.Color.Black
			Me.txtTayerF.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerF.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtTayerF.Location = New Global.System.Drawing.Point(138, 87)
			Me.txtTayerF.Name = "txtTayerF"
			Me.txtTayerF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerF.Size = New Global.System.Drawing.Size(42, 28)
			Me.txtTayerF.TabIndex = 1089
			Me.txtTayerF.Text = "3"
			Me.txtTayerF.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTayerS.BackColor = Global.System.Drawing.Color.Black
			Me.txtTayerS.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerS.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtTayerS.Location = New Global.System.Drawing.Point(138, 116)
			Me.txtTayerS.Name = "txtTayerS"
			Me.txtTayerS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerS.Size = New Global.System.Drawing.Size(42, 28)
			Me.txtTayerS.TabIndex = 1090
			Me.txtTayerS.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckTayerGetBal.AutoSize = True
			Me.ckTayerGetBal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckTayerGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckTayerGetBal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckTayerGetBal.Location = New Global.System.Drawing.Point(127, 161)
			Me.ckTayerGetBal.Name = "ckTayerGetBal"
			Me.ckTayerGetBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckTayerGetBal.Size = New Global.System.Drawing.Size(53, 17)
			Me.ckTayerGetBal.TabIndex = 1088
			Me.ckTayerGetBal.Text = "Auto"
			Me.ckTayerGetBal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckTayerGetBal.UseVisualStyleBackColor = False
			Me.btnTayerfromMtoN.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerfromMtoN.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerfromMtoN.Location = New Global.System.Drawing.Point(417, 250)
			Me.btnTayerfromMtoN.Name = "btnTayerfromMtoN"
			Me.btnTayerfromMtoN.Size = New Global.System.Drawing.Size(202, 37)
			Me.btnTayerfromMtoN.TabIndex = 1087
			Me.btnTayerfromMtoN.Text = "من الاساسى للاساسى التالى"
			Me.btnTayerfromMtoN.UseVisualStyleBackColor = False
			Me.Label80.AutoSize = True
			Me.Label80.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label80.ForeColor = Global.System.Drawing.Color.Black
			Me.Label80.Location = New Global.System.Drawing.Point(35, 82)
			Me.Label80.Name = "Label80"
			Me.Label80.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label80.Size = New Global.System.Drawing.Size(87, 17)
			Me.Label80.TabIndex = 1086
			Me.Label80.Text = "مبلغ الشحن"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.White
			Me.TextBox1.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Location = New Global.System.Drawing.Point(17, 105)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.TextBox1.Size = New Global.System.Drawing.Size(115, 36)
			Me.TextBox1.TabIndex = 1085
			Me.TextBox1.Text = "10"
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAutoVC_ChargeTayer.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVC_ChargeTayer.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVC_ChargeTayer.Location = New Global.System.Drawing.Point(14, 19)
			Me.btnAutoVC_ChargeTayer.Name = "btnAutoVC_ChargeTayer"
			Me.btnAutoVC_ChargeTayer.Size = New Global.System.Drawing.Size(166, 57)
			Me.btnAutoVC_ChargeTayer.TabIndex = 1084
			Me.btnAutoVC_ChargeTayer.Text = "شحن من طاير"
			Me.btnAutoVC_ChargeTayer.UseVisualStyleBackColor = False
			Me.Label70.AutoSize = True
			Me.Label70.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label70.ForeColor = Global.System.Drawing.Color.Black
			Me.Label70.Location = New Global.System.Drawing.Point(35, 227)
			Me.Label70.Name = "Label70"
			Me.Label70.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label70.Size = New Global.System.Drawing.Size(113, 17)
			Me.Label70.TabIndex = 1083
			Me.Label70.Text = "كلمة مرور الطاير"
			Me.txtTayerPass.BackColor = Global.System.Drawing.Color.White
			Me.txtTayerPass.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerPass.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTayerPass.Location = New Global.System.Drawing.Point(38, 250)
			Me.txtTayerPass.MaxLength = 4
			Me.txtTayerPass.Name = "txtTayerPass"
			Me.txtTayerPass.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerPass.Size = New Global.System.Drawing.Size(104, 36)
			Me.txtTayerPass.TabIndex = 1082
			Me.txtTayerPass.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ckTayerSub.AutoSize = True
			Me.ckTayerSub.BackColor = Global.System.Drawing.Color.FromArgb(192, 0, 0)
			Me.ckTayerSub.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckTayerSub.Location = New Global.System.Drawing.Point(486, 112)
			Me.ckTayerSub.Name = "ckTayerSub"
			Me.ckTayerSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckTayerSub.Size = New Global.System.Drawing.Size(56, 17)
			Me.ckTayerSub.TabIndex = 1073
			Me.ckTayerSub.Text = "خصم "
			Me.ckTayerSub.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckTayerSub.UseVisualStyleBackColor = False
			Me.txtTayerSub.BackColor = Global.System.Drawing.Color.White
			Me.txtTayerSub.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerSub.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTayerSub.Location = New Global.System.Drawing.Point(418, 108)
			Me.txtTayerSub.MaxLength = 100
			Me.txtTayerSub.Name = "txtTayerSub"
			Me.txtTayerSub.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerSub.Size = New Global.System.Drawing.Size(68, 24)
			Me.txtTayerSub.TabIndex = 1072
			Me.txtTayerSub.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTayerEX.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerEX.Font = New Global.System.Drawing.Font("Tahoma", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerEX.Location = New Global.System.Drawing.Point(418, 179)
			Me.btnTayerEX.Name = "btnTayerEX"
			Me.btnTayerEX.Size = New Global.System.Drawing.Size(42, 23)
			Me.btnTayerEX.TabIndex = 1071
			Me.btnTayerEX.Text = "||"
			Me.btnTayerEX.UseVisualStyleBackColor = False
			Me.btnTayerSeries.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerSeries.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerSeries.Location = New Global.System.Drawing.Point(417, 6)
			Me.btnTayerSeries.Name = "btnTayerSeries"
			Me.btnTayerSeries.Size = New Global.System.Drawing.Size(203, 59)
			Me.btnTayerSeries.TabIndex = 1070
			Me.btnTayerSeries.Text = "متتالى"
			Me.btnTayerSeries.UseVisualStyleBackColor = False
			Me.Label75.AutoSize = True
			Me.Label75.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label75.ForeColor = Global.System.Drawing.Color.Black
			Me.Label75.Location = New Global.System.Drawing.Point(518, 183)
			Me.Label75.Name = "Label75"
			Me.Label75.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label75.Size = New Global.System.Drawing.Size(94, 13)
			Me.Label75.TabIndex = 1069
			Me.Label75.Text = "الاساسى التالى"
			Me.Label79.AutoSize = True
			Me.Label79.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label79.ForeColor = Global.System.Drawing.Color.Black
			Me.Label79.Location = New Global.System.Drawing.Point(537, 78)
			Me.Label79.Name = "Label79"
			Me.Label79.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label79.Size = New Global.System.Drawing.Size(88, 17)
			Me.Label79.TabIndex = 1068
			Me.Label79.Text = "مبلغ التحويل"
			Me.txtTayerNextMain.BackColor = Global.System.Drawing.Color.White
			Me.txtTayerNextMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerNextMain.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTayerNextMain.Location = New Global.System.Drawing.Point(417, 208)
			Me.txtTayerNextMain.MaxLength = 11
			Me.txtTayerNextMain.Name = "txtTayerNextMain"
			Me.txtTayerNextMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerNextMain.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtTayerNextMain.TabIndex = 1067
			Me.txtTayerNextMain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblTayerMain.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.lblTayerMain.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTayerMain.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblTayerMain.ForeColor = Global.System.Drawing.Color.Black
			Me.lblTayerMain.Location = New Global.System.Drawing.Point(418, 138)
			Me.lblTayerMain.Name = "lblTayerMain"
			Me.lblTayerMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblTayerMain.Size = New Global.System.Drawing.Size(202, 38)
			Me.lblTayerMain.TabIndex = 1066
			Me.lblTayerMain.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label81.AutoSize = True
			Me.Label81.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label81.ForeColor = Global.System.Drawing.Color.Black
			Me.Label81.Location = New Global.System.Drawing.Point(547, 116)
			Me.Label81.Name = "Label81"
			Me.Label81.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label81.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label81.TabIndex = 1065
			Me.Label81.Text = "الاساسى"
			Me.txtTayerValue.BackColor = Global.System.Drawing.Color.White
			Me.txtTayerValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTayerValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTayerValue.Location = New Global.System.Drawing.Point(417, 68)
			Me.txtTayerValue.Name = "txtTayerValue"
			Me.txtTayerValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTayerValue.Size = New Global.System.Drawing.Size(114, 36)
			Me.txtTayerValue.TabIndex = 1064
			Me.txtTayerValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTayerGetBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTayerGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTayerGetBal.Location = New Global.System.Drawing.Point(14, 160)
			Me.btnTayerGetBal.Name = "btnTayerGetBal"
			Me.btnTayerGetBal.Size = New Global.System.Drawing.Size(167, 61)
			Me.btnTayerGetBal.TabIndex = 1063
			Me.btnTayerGetBal.Text = "استعلام عن رصيدالطاير"
			Me.btnTayerGetBal.UseVisualStyleBackColor = False
			Me.tabEzoo.BackColor = Global.System.Drawing.Color.Purple
			Me.tabEzoo.Controls.Add(Me.ckbtnTal2aGetBal)
			Me.tabEzoo.Controls.Add(Me.ckTal2a)
			Me.tabEzoo.Controls.Add(Me.btnTal2aTransferFromOrange)
			Me.tabEzoo.Controls.Add(Me.Label102)
			Me.tabEzoo.Controls.Add(Me.txtTl2aOrangeValue)
			Me.tabEzoo.Controls.Add(Me.btnTal2aTransferVoda)
			Me.tabEzoo.Controls.Add(Me.btnTal2aGetBal)
			Me.tabEzoo.Controls.Add(Me.Label86)
			Me.tabEzoo.Controls.Add(Me.txtTl2aToVodaNumber)
			Me.tabEzoo.Controls.Add(Me.txtTl2aVodaValue)
			Me.tabEzoo.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabEzoo.Name = "tabEzoo"
			Me.tabEzoo.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabEzoo.TabIndex = 28
			Me.tabEzoo.Text = "EZOO Tal2a"
			Me.ckbtnTal2aGetBal.AutoSize = True
			Me.ckbtnTal2aGetBal.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckbtnTal2aGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckbtnTal2aGetBal.ForeColor = Global.System.Drawing.Color.Black
			Me.ckbtnTal2aGetBal.Location = New Global.System.Drawing.Point(842, 222)
			Me.ckbtnTal2aGetBal.Name = "ckbtnTal2aGetBal"
			Me.ckbtnTal2aGetBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckbtnTal2aGetBal.Size = New Global.System.Drawing.Size(42, 17)
			Me.ckbtnTal2aGetBal.TabIndex = 1116
			Me.ckbtnTal2aGetBal.Text = "AU"
			Me.ckbtnTal2aGetBal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckbtnTal2aGetBal.UseVisualStyleBackColor = False
			Me.ckTal2a.AutoSize = True
			Me.ckTal2a.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckTal2a.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckTal2a.ForeColor = Global.System.Drawing.Color.Black
			Me.ckTal2a.Location = New Global.System.Drawing.Point(24, 37)
			Me.ckTal2a.Name = "ckTal2a"
			Me.ckTal2a.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckTal2a.Size = New Global.System.Drawing.Size(75, 17)
			Me.ckTal2a.TabIndex = 1013
			Me.ckTal2a.Text = "Arrange "
			Me.ckTal2a.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckTal2a.UseVisualStyleBackColor = False
			Me.btnTal2aTransferFromOrange.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTal2aTransferFromOrange.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTal2aTransferFromOrange.Location = New Global.System.Drawing.Point(315, 101)
			Me.btnTal2aTransferFromOrange.Name = "btnTal2aTransferFromOrange"
			Me.btnTal2aTransferFromOrange.Size = New Global.System.Drawing.Size(198, 51)
			Me.btnTal2aTransferFromOrange.TabIndex = 1012
			Me.btnTal2aTransferFromOrange.Text = "Transfer to Voda"
			Me.btnTal2aTransferFromOrange.UseVisualStyleBackColor = False
			Me.Label102.AutoSize = True
			Me.Label102.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label102.ForeColor = Global.System.Drawing.Color.Black
			Me.Label102.Location = New Global.System.Drawing.Point(453, 73)
			Me.Label102.Name = "Label102"
			Me.Label102.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label102.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label102.TabIndex = 1011
			Me.Label102.Text = "المبلغ"
			Me.txtTl2aOrangeValue.BackColor = Global.System.Drawing.Color.White
			Me.txtTl2aOrangeValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTl2aOrangeValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTl2aOrangeValue.Location = New Global.System.Drawing.Point(315, 59)
			Me.txtTl2aOrangeValue.Name = "txtTl2aOrangeValue"
			Me.txtTl2aOrangeValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTl2aOrangeValue.Size = New Global.System.Drawing.Size(132, 36)
			Me.txtTl2aOrangeValue.TabIndex = 1010
			Me.txtTl2aOrangeValue.Text = "30000"
			Me.txtTl2aOrangeValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTal2aTransferVoda.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTal2aTransferVoda.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTal2aTransferVoda.Location = New Global.System.Drawing.Point(24, 222)
			Me.btnTal2aTransferVoda.Name = "btnTal2aTransferVoda"
			Me.btnTal2aTransferVoda.Size = New Global.System.Drawing.Size(208, 51)
			Me.btnTal2aTransferVoda.TabIndex = 1009
			Me.btnTal2aTransferVoda.Text = "Transfer to Tal2a"
			Me.btnTal2aTransferVoda.UseVisualStyleBackColor = False
			Me.btnTal2aGetBal.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTal2aGetBal.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTal2aGetBal.Location = New Global.System.Drawing.Point(689, 220)
			Me.btnTal2aGetBal.Name = "btnTal2aGetBal"
			Me.btnTal2aGetBal.Size = New Global.System.Drawing.Size(198, 53)
			Me.btnTal2aGetBal.TabIndex = 1008
			Me.btnTal2aGetBal.Text = "استعلام عن رصيدالكاش"
			Me.btnTal2aGetBal.UseVisualStyleBackColor = False
			Me.Label86.AutoSize = True
			Me.Label86.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label86.ForeColor = Global.System.Drawing.Color.Black
			Me.Label86.Location = New Global.System.Drawing.Point(172, 150)
			Me.Label86.Name = "Label86"
			Me.Label86.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label86.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label86.TabIndex = 1006
			Me.Label86.Text = "المبلغ"
			Me.txtTl2aToVodaNumber.BackColor = Global.System.Drawing.Color.White
			Me.txtTl2aToVodaNumber.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTl2aToVodaNumber.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTl2aToVodaNumber.Location = New Global.System.Drawing.Point(24, 180)
			Me.txtTl2aToVodaNumber.MaxLength = 11
			Me.txtTl2aToVodaNumber.Name = "txtTl2aToVodaNumber"
			Me.txtTl2aToVodaNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTl2aToVodaNumber.Size = New Global.System.Drawing.Size(202, 36)
			Me.txtTl2aToVodaNumber.TabIndex = 1005
			Me.txtTl2aToVodaNumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTl2aVodaValue.BackColor = Global.System.Drawing.Color.White
			Me.txtTl2aVodaValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTl2aVodaValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTl2aVodaValue.Location = New Global.System.Drawing.Point(24, 136)
			Me.txtTl2aVodaValue.Name = "txtTl2aVodaValue"
			Me.txtTl2aVodaValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTl2aVodaValue.Size = New Global.System.Drawing.Size(132, 36)
			Me.txtTl2aVodaValue.TabIndex = 1002
			Me.txtTl2aVodaValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.tab365.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.tab365.Controls.Add(Me.chkTransGiftAutoSpVal365)
			Me.tab365.Controls.Add(Me.txtLoopSSD365_f)
			Me.tab365.Controls.Add(Me.txtLoopFSD365_f)
			Me.tab365.Controls.Add(Me.txtGetgft365_2)
			Me.tab365.Controls.Add(Me.chkAuto365EXE_f)
			Me.tab365.Controls.Add(Me.txtGetgft365_f)
			Me.tab365.Controls.Add(Me.btnApply36590_f)
			Me.tab365.Controls.Add(Me.txtLoopSSD365Gft)
			Me.tab365.Controls.Add(Me.txtLoopFSD365Gft)
			Me.tab365.Controls.Add(Me.chkNoCharge50)
			Me.tab365.Controls.Add(Me.chkAuto365Trans)
			Me.tab365.Controls.Add(Me.chk250int)
			Me.tab365.Controls.Add(Me.chkApply365)
			Me.tab365.Controls.Add(Me.chkAuto365EXE)
			Me.tab365.Controls.Add(Me.chkFast365)
			Me.tab365.Controls.Add(Me.btnAuto365)
			Me.tab365.Controls.Add(Me.txtGetgft365)
			Me.tab365.Controls.Add(Me.txtVCForceMony365)
			Me.tab365.Controls.Add(Me.btnTransGiftAutoSpVal365)
			Me.tab365.Controls.Add(Me.Label54)
			Me.tab365.Controls.Add(Me.txtTransNum2365Gft)
			Me.tab365.Controls.Add(Me.txtLoopSSD365)
			Me.tab365.Controls.Add(Me.txtLoopFSD365)
			Me.tab365.Controls.Add(Me.btnApply36590)
			Me.tab365.Controls.Add(Me.chkChargeOnSame365)
			Me.tab365.Controls.Add(Me.Label52)
			Me.tab365.Controls.Add(Me.Label53)
			Me.tab365.Controls.Add(Me.txtTransNum2365)
			Me.tab365.Controls.Add(Me.txtMonyMn365)
			Me.tab365.Controls.Add(Me.btnApply365)
			Me.tab365.Location = New Global.System.Drawing.Point(4, 22)
			Me.tab365.Name = "tab365"
			Me.tab365.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tab365.Size = New Global.System.Drawing.Size(934, 295)
			Me.tab365.TabIndex = 15
			Me.tab365.Text = "365"
			Me.chkTransGiftAutoSpVal365.AutoSize = True
			Me.chkTransGiftAutoSpVal365.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkTransGiftAutoSpVal365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkTransGiftAutoSpVal365.ForeColor = Global.System.Drawing.Color.RoyalBlue
			Me.chkTransGiftAutoSpVal365.Location = New Global.System.Drawing.Point(66, 227)
			Me.chkTransGiftAutoSpVal365.Name = "chkTransGiftAutoSpVal365"
			Me.chkTransGiftAutoSpVal365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkTransGiftAutoSpVal365.Size = New Global.System.Drawing.Size(49, 17)
			Me.chkTransGiftAutoSpVal365.TabIndex = 1046
			Me.chkTransGiftAutoSpVal365.Text = "عداد"
			Me.chkTransGiftAutoSpVal365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkTransGiftAutoSpVal365.UseVisualStyleBackColor = False
			Me.chkTransGiftAutoSpVal365.Visible = False
			Me.txtLoopSSD365_f.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSD365_f.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSD365_f.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSD365_f.Location = New Global.System.Drawing.Point(592, 22)
			Me.txtLoopSSD365_f.Name = "txtLoopSSD365_f"
			Me.txtLoopSSD365_f.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSD365_f.Size = New Global.System.Drawing.Size(47, 24)
			Me.txtLoopSSD365_f.TabIndex = 1045
			Me.txtLoopSSD365_f.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSD365_f.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSD365_f.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSD365_f.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSD365_f.Location = New Global.System.Drawing.Point(540, 22)
			Me.txtLoopFSD365_f.Name = "txtLoopFSD365_f"
			Me.txtLoopFSD365_f.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSD365_f.Size = New Global.System.Drawing.Size(46, 24)
			Me.txtLoopFSD365_f.TabIndex = 1044
			Me.txtLoopFSD365_f.Text = "1"
			Me.txtLoopFSD365_f.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtGetgft365_2.BackColor = Global.System.Drawing.Color.White
			Me.txtGetgft365_2.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGetgft365_2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGetgft365_2.Location = New Global.System.Drawing.Point(14, 139)
			Me.txtGetgft365_2.Name = "txtGetgft365_2"
			Me.txtGetgft365_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGetgft365_2.Size = New Global.System.Drawing.Size(214, 27)
			Me.txtGetgft365_2.TabIndex = 1043
			Me.txtGetgft365_2.Text = "*365*91#"
			Me.chkAuto365EXE_f.AutoSize = True
			Me.chkAuto365EXE_f.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkAuto365EXE_f.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAuto365EXE_f.ForeColor = Global.System.Drawing.Color.Black
			Me.chkAuto365EXE_f.Location = New Global.System.Drawing.Point(838, 18)
			Me.chkAuto365EXE_f.Name = "chkAuto365EXE_f"
			Me.chkAuto365EXE_f.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAuto365EXE_f.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkAuto365EXE_f.TabIndex = 1042
			Me.chkAuto365EXE_f.Text = "Auto"
			Me.chkAuto365EXE_f.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAuto365EXE_f.UseVisualStyleBackColor = False
			Me.txtGetgft365_f.BackColor = Global.System.Drawing.Color.White
			Me.txtGetgft365_f.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGetgft365_f.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGetgft365_f.Location = New Global.System.Drawing.Point(475, 51)
			Me.txtGetgft365_f.Name = "txtGetgft365_f"
			Me.txtGetgft365_f.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGetgft365_f.Size = New Global.System.Drawing.Size(164, 27)
			Me.txtGetgft365_f.TabIndex = 1041
			Me.txtGetgft365_f.Text = "*365*90#"
			Me.btnApply36590_f.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnApply36590_f.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnApply36590_f.Location = New Global.System.Drawing.Point(716, 42)
			Me.btnApply36590_f.Name = "btnApply36590_f"
			Me.btnApply36590_f.Size = New Global.System.Drawing.Size(175, 36)
			Me.btnApply36590_f.TabIndex = 1040
			Me.btnApply36590_f.Text = "تنفيذ"
			Me.btnApply36590_f.UseVisualStyleBackColor = False
			Me.txtLoopSSD365Gft.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.txtLoopSSD365Gft.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSD365Gft.ForeColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSD365Gft.Location = New Global.System.Drawing.Point(13, 242)
			Me.txtLoopSSD365Gft.Name = "txtLoopSSD365Gft"
			Me.txtLoopSSD365Gft.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSD365Gft.Size = New Global.System.Drawing.Size(50, 24)
			Me.txtLoopSSD365Gft.TabIndex = 1039
			Me.txtLoopSSD365Gft.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopSSD365Gft.Visible = False
			Me.txtLoopFSD365Gft.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.txtLoopFSD365Gft.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSD365Gft.ForeColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSD365Gft.Location = New Global.System.Drawing.Point(14, 217)
			Me.txtLoopFSD365Gft.Name = "txtLoopFSD365Gft"
			Me.txtLoopFSD365Gft.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSD365Gft.Size = New Global.System.Drawing.Size(49, 24)
			Me.txtLoopFSD365Gft.TabIndex = 1038
			Me.txtLoopFSD365Gft.Text = "1"
			Me.txtLoopFSD365Gft.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSD365Gft.Visible = False
			Me.chkNoCharge50.AutoSize = True
			Me.chkNoCharge50.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkNoCharge50.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkNoCharge50.ForeColor = Global.System.Drawing.Color.Black
			Me.chkNoCharge50.Location = New Global.System.Drawing.Point(492, 84)
			Me.chkNoCharge50.Name = "chkNoCharge50"
			Me.chkNoCharge50.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkNoCharge50.Size = New Global.System.Drawing.Size(141, 17)
			Me.chkNoCharge50.TabIndex = 1037
			Me.chkNoCharge50.Text = "ممنوع شحن الهدية 50"
			Me.chkNoCharge50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkNoCharge50.UseVisualStyleBackColor = False
			Me.chkNoCharge50.Visible = False
			Me.chkAuto365Trans.AutoSize = True
			Me.chkAuto365Trans.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkAuto365Trans.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAuto365Trans.ForeColor = Global.System.Drawing.Color.Black
			Me.chkAuto365Trans.Location = New Global.System.Drawing.Point(175, 225)
			Me.chkAuto365Trans.Name = "chkAuto365Trans"
			Me.chkAuto365Trans.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAuto365Trans.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkAuto365Trans.TabIndex = 1036
			Me.chkAuto365Trans.Text = "Auto"
			Me.chkAuto365Trans.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAuto365Trans.UseVisualStyleBackColor = False
			Me.chk250int.AutoSize = True
			Me.chk250int.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chk250int.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chk250int.Location = New Global.System.Drawing.Point(508, 110)
			Me.chk250int.Name = "chk250int"
			Me.chk250int.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chk250int.Size = New Global.System.Drawing.Size(124, 17)
			Me.chk250int.TabIndex = 1035
			Me.chk250int.Text = "علم على 250 وحدة"
			Me.chk250int.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chk250int.UseVisualStyleBackColor = False
			Me.chkApply365.AutoSize = True
			Me.chkApply365.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkApply365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkApply365.ForeColor = Global.System.Drawing.Color.Black
			Me.chkApply365.Location = New Global.System.Drawing.Point(838, 87)
			Me.chkApply365.Name = "chkApply365"
			Me.chkApply365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkApply365.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkApply365.TabIndex = 1026
			Me.chkApply365.Text = "Auto"
			Me.chkApply365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkApply365.UseVisualStyleBackColor = False
			Me.chkAuto365EXE.AutoSize = True
			Me.chkAuto365EXE.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkAuto365EXE.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAuto365EXE.ForeColor = Global.System.Drawing.Color.Black
			Me.chkAuto365EXE.Location = New Global.System.Drawing.Point(175, 48)
			Me.chkAuto365EXE.Name = "chkAuto365EXE"
			Me.chkAuto365EXE.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAuto365EXE.Size = New Global.System.Drawing.Size(53, 17)
			Me.chkAuto365EXE.TabIndex = 1025
			Me.chkAuto365EXE.Text = "Auto"
			Me.chkAuto365EXE.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAuto365EXE.UseVisualStyleBackColor = False
			Me.chkFast365.AutoSize = True
			Me.chkFast365.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkFast365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkFast365.Location = New Global.System.Drawing.Point(540, 137)
			Me.chkFast365.Name = "chkFast365"
			Me.chkFast365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkFast365.Size = New Global.System.Drawing.Size(99, 17)
			Me.chkFast365.TabIndex = 1024
			Me.chkFast365.Text = "استعلام سريع"
			Me.chkFast365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkFast365.UseVisualStyleBackColor = False
			Me.btnAuto365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAuto365.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAuto365.Location = New Global.System.Drawing.Point(14, 9)
			Me.btnAuto365.Name = "btnAuto365"
			Me.btnAuto365.Size = New Global.System.Drawing.Size(222, 33)
			Me.btnAuto365.TabIndex = 1023
			Me.btnAuto365.Text = "تشغيل ذكى استقبال وتحويل"
			Me.btnAuto365.UseVisualStyleBackColor = False
			Me.txtGetgft365.BackColor = Global.System.Drawing.Color.White
			Me.txtGetgft365.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGetgft365.ForeColor = Global.System.Drawing.Color.Black
			Me.txtGetgft365.Location = New Global.System.Drawing.Point(14, 101)
			Me.txtGetgft365.Name = "txtGetgft365"
			Me.txtGetgft365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtGetgft365.Size = New Global.System.Drawing.Size(214, 27)
			Me.txtGetgft365.TabIndex = 1022
			Me.txtGetgft365.Text = "*365*90#"
			Me.txtVCForceMony365.BackColor = Global.System.Drawing.Color.White
			Me.txtVCForceMony365.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtVCForceMony365.ForeColor = Global.System.Drawing.Color.Black
			Me.txtVCForceMony365.Location = New Global.System.Drawing.Point(13, 186)
			Me.txtVCForceMony365.Name = "txtVCForceMony365"
			Me.txtVCForceMony365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtVCForceMony365.Size = New Global.System.Drawing.Size(50, 27)
			Me.txtVCForceMony365.TabIndex = 1021
			Me.txtVCForceMony365.Text = "0"
			Me.txtVCForceMony365.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnTransGiftAutoSpVal365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnTransGiftAutoSpVal365.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnTransGiftAutoSpVal365.Location = New Global.System.Drawing.Point(65, 172)
			Me.btnTransGiftAutoSpVal365.Name = "btnTransGiftAutoSpVal365"
			Me.btnTransGiftAutoSpVal365.Size = New Global.System.Drawing.Size(163, 49)
			Me.btnTransGiftAutoSpVal365.TabIndex = 1020
			Me.btnTransGiftAutoSpVal365.Text = "شحن الهدية رصيد"
			Me.btnTransGiftAutoSpVal365.UseVisualStyleBackColor = False
			Me.Label54.AutoSize = True
			Me.Label54.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.Label54.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label54.ForeColor = Global.System.Drawing.Color.Black
			Me.Label54.Location = New Global.System.Drawing.Point(459, 195)
			Me.Label54.Name = "Label54"
			Me.Label54.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label54.Size = New Global.System.Drawing.Size(186, 17)
			Me.Label54.TabIndex = 1019
			Me.Label54.Text = "الخط مستقبل شحن الهدية "
			Me.txtTransNum2365Gft.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNum2365Gft.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNum2365Gft.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum2365Gft.Location = New Global.System.Drawing.Point(452, 221)
			Me.txtTransNum2365Gft.MaxLength = 11
			Me.txtTransNum2365Gft.Name = "txtTransNum2365Gft"
			Me.txtTransNum2365Gft.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum2365Gft.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtTransNum2365Gft.TabIndex = 1018
			Me.txtTransNum2365Gft.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopSSD365.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopSSD365.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopSSD365.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopSSD365.Location = New Global.System.Drawing.Point(181, 71)
			Me.txtLoopSSD365.Name = "txtLoopSSD365"
			Me.txtLoopSSD365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopSSD365.Size = New Global.System.Drawing.Size(47, 24)
			Me.txtLoopSSD365.TabIndex = 1017
			Me.txtLoopSSD365.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtLoopFSD365.BackColor = Global.System.Drawing.Color.Black
			Me.txtLoopFSD365.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.txtLoopFSD365.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtLoopFSD365.Location = New Global.System.Drawing.Point(129, 71)
			Me.txtLoopFSD365.Name = "txtLoopFSD365"
			Me.txtLoopFSD365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtLoopFSD365.Size = New Global.System.Drawing.Size(46, 24)
			Me.txtLoopFSD365.TabIndex = 1016
			Me.txtLoopFSD365.Text = "1"
			Me.txtLoopFSD365.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnApply36590.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnApply36590.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnApply36590.Location = New Global.System.Drawing.Point(14, 45)
			Me.btnApply36590.Name = "btnApply36590"
			Me.btnApply36590.Size = New Global.System.Drawing.Size(109, 50)
			Me.btnApply36590.TabIndex = 1015
			Me.btnApply36590.Text = "تنفيذ"
			Me.btnApply36590.UseVisualStyleBackColor = False
			Me.chkChargeOnSame365.AutoSize = True
			Me.chkChargeOnSame365.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkChargeOnSame365.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkChargeOnSame365.Location = New Global.System.Drawing.Point(454, 160)
			Me.chkChargeOnSame365.Name = "chkChargeOnSame365"
			Me.chkChargeOnSame365.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkChargeOnSame365.Size = New Global.System.Drawing.Size(175, 17)
			Me.chkChargeOnSame365.TabIndex = 1014
			Me.chkChargeOnSame365.Text = "شحن الهدية على نفس الرقم"
			Me.chkChargeOnSame365.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkChargeOnSame365.UseVisualStyleBackColor = False
			Me.Label52.AutoSize = True
			Me.Label52.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label52.ForeColor = Global.System.Drawing.Color.Black
			Me.Label52.Location = New Global.System.Drawing.Point(789, 165)
			Me.Label52.Name = "Label52"
			Me.Label52.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label52.Size = New Global.System.Drawing.Size(113, 17)
			Me.Label52.TabIndex = 1013
			Me.Label52.Text = "المبلغ المشحون"
			Me.Label53.AutoSize = True
			Me.Label53.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.Label53.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label53.ForeColor = Global.System.Drawing.Color.Black
			Me.Label53.Location = New Global.System.Drawing.Point(724, 198)
			Me.Label53.Name = "Label53"
			Me.Label53.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label53.Size = New Global.System.Drawing.Size(178, 17)
			Me.Label53.TabIndex = 1012
			Me.Label53.Text = "الخط مستقبل الرصيد  365"
			Me.txtTransNum2365.BackColor = Global.System.Drawing.Color.White
			Me.txtTransNum2365.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTransNum2365.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTransNum2365.Location = New Global.System.Drawing.Point(716, 221)
			Me.txtTransNum2365.MaxLength = 11
			Me.txtTransNum2365.Name = "txtTransNum2365"
			Me.txtTransNum2365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtTransNum2365.Size = New Global.System.Drawing.Size(187, 36)
			Me.txtTransNum2365.TabIndex = 1011
			Me.txtTransNum2365.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtMonyMn365.BackColor = Global.System.Drawing.Color.White
			Me.txtMonyMn365.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtMonyMn365.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMonyMn365.Location = New Global.System.Drawing.Point(716, 156)
			Me.txtMonyMn365.Name = "txtMonyMn365"
			Me.txtMonyMn365.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMonyMn365.Size = New Global.System.Drawing.Size(70, 36)
			Me.txtMonyMn365.TabIndex = 1010
			Me.txtMonyMn365.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnApply365.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnApply365.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnApply365.Location = New Global.System.Drawing.Point(716, 110)
			Me.btnApply365.Name = "btnApply365"
			Me.btnApply365.Size = New Global.System.Drawing.Size(175, 45)
			Me.btnApply365.TabIndex = 985
			Me.btnApply365.Text = "*365#"
			Me.btnApply365.UseVisualStyleBackColor = False
			Me.tabpoints.BackColor = Global.System.Drawing.Color.Red
			Me.tabpoints.Controls.Add(Me.txtRet07)
			Me.tabpoints.Controls.Add(Me.txtRet08)
			Me.tabpoints.Controls.Add(Me.chkCh8)
			Me.tabpoints.Controls.Add(Me.chkCh7)
			Me.tabpoints.Controls.Add(Me.txtPointsF)
			Me.tabpoints.Controls.Add(Me.txtPointsS)
			Me.tabpoints.Controls.Add(Me.btnAutoVC_ChargePoints)
			Me.tabpoints.Controls.Add(Me.Label69)
			Me.tabpoints.Controls.Add(Me.lblMainPoints)
			Me.tabpoints.Controls.Add(Me.Label71)
			Me.tabpoints.Controls.Add(Me.txtPointsValue)
			Me.tabpoints.Controls.Add(Me.lblNum8)
			Me.tabpoints.Controls.Add(Me.lblNum7)
			Me.tabpoints.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabpoints.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.tabpoints.Name = "tabpoints"
			Me.tabpoints.Padding = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.tabpoints.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabpoints.TabIndex = 19
			Me.tabpoints.Text = "Points"
			Me.txtRet07.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet07.Font = New Global.System.Drawing.Font("Arial", 10.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet07.ForeColor = Global.System.Drawing.Color.Cyan
			Me.txtRet07.Location = New Global.System.Drawing.Point(250, 179)
			Me.txtRet07.Multiline = True
			Me.txtRet07.Name = "txtRet07"
			Me.txtRet07.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet07.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet07.Size = New Global.System.Drawing.Size(192, 98)
			Me.txtRet07.TabIndex = 1076
			Me.txtRet08.BackColor = Global.System.Drawing.Color.Black
			Me.txtRet08.Font = New Global.System.Drawing.Font("Arial", 10.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRet08.ForeColor = Global.System.Drawing.Color.Cyan
			Me.txtRet08.Location = New Global.System.Drawing.Point(22, 180)
			Me.txtRet08.Multiline = True
			Me.txtRet08.Name = "txtRet08"
			Me.txtRet08.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtRet08.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.txtRet08.Size = New Global.System.Drawing.Size(193, 97)
			Me.txtRet08.TabIndex = 1075
			Me.chkCh8.AutoSize = True
			Me.chkCh8.Checked = True
			Me.chkCh8.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh8.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh8.Location = New Global.System.Drawing.Point(216, 154)
			Me.chkCh8.Name = "chkCh8"
			Me.chkCh8.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh8.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh8.TabIndex = 1074
			Me.chkCh8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh8.UseVisualStyleBackColor = True
			Me.chkCh7.AutoSize = True
			Me.chkCh7.Checked = True
			Me.chkCh7.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkCh7.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkCh7.Location = New Global.System.Drawing.Point(448, 154)
			Me.chkCh7.Name = "chkCh7"
			Me.chkCh7.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkCh7.Size = New Global.System.Drawing.Size(15, 14)
			Me.chkCh7.TabIndex = 1073
			Me.chkCh7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkCh7.UseVisualStyleBackColor = True
			Me.txtPointsF.BackColor = Global.System.Drawing.Color.Black
			Me.txtPointsF.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtPointsF.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtPointsF.Location = New Global.System.Drawing.Point(475, 18)
			Me.txtPointsF.Name = "txtPointsF"
			Me.txtPointsF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPointsF.Size = New Global.System.Drawing.Size(42, 28)
			Me.txtPointsF.TabIndex = 1071
			Me.txtPointsF.Text = "3"
			Me.txtPointsF.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtPointsS.BackColor = Global.System.Drawing.Color.Black
			Me.txtPointsS.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtPointsS.ForeColor = Global.System.Drawing.Color.Lime
			Me.txtPointsS.Location = New Global.System.Drawing.Point(429, 17)
			Me.txtPointsS.Name = "txtPointsS"
			Me.txtPointsS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPointsS.Size = New Global.System.Drawing.Size(40, 28)
			Me.txtPointsS.TabIndex = 1072
			Me.txtPointsS.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnAutoVC_ChargePoints.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoVC_ChargePoints.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnAutoVC_ChargePoints.Location = New Global.System.Drawing.Point(22, 17)
			Me.btnAutoVC_ChargePoints.Name = "btnAutoVC_ChargePoints"
			Me.btnAutoVC_ChargePoints.Size = New Global.System.Drawing.Size(197, 66)
			Me.btnAutoVC_ChargePoints.TabIndex = 1068
			Me.btnAutoVC_ChargePoints.Text = "شحن من كاش"
			Me.btnAutoVC_ChargePoints.UseVisualStyleBackColor = False
			Me.Label69.AutoSize = True
			Me.Label69.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label69.ForeColor = Global.System.Drawing.Color.Black
			Me.Label69.Location = New Global.System.Drawing.Point(279, 31)
			Me.Label69.Name = "Label69"
			Me.Label69.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label69.Size = New Global.System.Drawing.Size(45, 17)
			Me.Label69.TabIndex = 1067
			Me.Label69.Text = "المبلغ"
			Me.lblMainPoints.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.lblMainPoints.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblMainPoints.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblMainPoints.ForeColor = Global.System.Drawing.Color.Black
			Me.lblMainPoints.Location = New Global.System.Drawing.Point(420, 54)
			Me.lblMainPoints.Name = "lblMainPoints"
			Me.lblMainPoints.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblMainPoints.Size = New Global.System.Drawing.Size(202, 38)
			Me.lblMainPoints.TabIndex = 1066
			Me.lblMainPoints.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label71.AutoSize = True
			Me.Label71.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label71.ForeColor = Global.System.Drawing.Color.Black
			Me.Label71.Location = New Global.System.Drawing.Point(550, 31)
			Me.Label71.Name = "Label71"
			Me.Label71.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label71.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label71.TabIndex = 1065
			Me.Label71.Text = "الاساسى"
			Me.txtPointsValue.BackColor = Global.System.Drawing.Color.White
			Me.txtPointsValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtPointsValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtPointsValue.Location = New Global.System.Drawing.Point(255, 58)
			Me.txtPointsValue.Name = "txtPointsValue"
			Me.txtPointsValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtPointsValue.Size = New Global.System.Drawing.Size(84, 36)
			Me.txtPointsValue.TabIndex = 1064
			Me.txtPointsValue.Text = "10"
			Me.txtPointsValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblNum8.BackColor = Global.System.Drawing.Color.White
			Me.lblNum8.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblNum8.ForeColor = Global.System.Drawing.Color.Black
			Me.lblNum8.Location = New Global.System.Drawing.Point(22, 137)
			Me.lblNum8.MaxLength = 11
			Me.lblNum8.Name = "lblNum8"
			Me.lblNum8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum8.Size = New Global.System.Drawing.Size(187, 36)
			Me.lblNum8.TabIndex = 998
			Me.lblNum8.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblNum7.BackColor = Global.System.Drawing.Color.White
			Me.lblNum7.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.lblNum7.ForeColor = Global.System.Drawing.Color.Black
			Me.lblNum7.Location = New Global.System.Drawing.Point(255, 136)
			Me.lblNum7.MaxLength = 11
			Me.lblNum7.Name = "lblNum7"
			Me.lblNum7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblNum7.Size = New Global.System.Drawing.Size(187, 36)
			Me.lblNum7.TabIndex = 997
			Me.lblNum7.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.tabON.BackColor = Global.System.Drawing.Color.Red
			Me.tabON.Controls.Add(Me.btnONtopup)
			Me.tabON.Controls.Add(Me.btnONGift)
			Me.tabON.Controls.Add(Me.btnGetBal2ON)
			Me.tabON.Controls.Add(Me.btnAutoGet)
			Me.tabON.Controls.Add(Me.btnPic)
			Me.tabON.Controls.Add(Me.lblONnumQ)
			Me.tabON.Controls.Add(Me.lblONvQ)
			Me.tabON.Controls.Add(Me.lblONmcQ)
			Me.tabON.Controls.Add(Me.txtQryOrder)
			Me.tabON.Controls.Add(Me.lblONnum6)
			Me.tabON.Controls.Add(Me.txtONorder6)
			Me.tabON.Controls.Add(Me.lblONv6)
			Me.tabON.Controls.Add(Me.lblONmc6)
			Me.tabON.Controls.Add(Me.lblONnum5)
			Me.tabON.Controls.Add(Me.txtONorder5)
			Me.tabON.Controls.Add(Me.lblONv5)
			Me.tabON.Controls.Add(Me.lblONmc5)
			Me.tabON.Controls.Add(Me.lblONnum4)
			Me.tabON.Controls.Add(Me.txtONorder4)
			Me.tabON.Controls.Add(Me.lblONv4)
			Me.tabON.Controls.Add(Me.lblONmc4)
			Me.tabON.Controls.Add(Me.lblONnum3)
			Me.tabON.Controls.Add(Me.txtONorder3)
			Me.tabON.Controls.Add(Me.lblONv3)
			Me.tabON.Controls.Add(Me.lblONmc3)
			Me.tabON.Controls.Add(Me.lblONnum2)
			Me.tabON.Controls.Add(Me.txtONorder2)
			Me.tabON.Controls.Add(Me.lblONv2)
			Me.tabON.Controls.Add(Me.lblONmc2)
			Me.tabON.Controls.Add(Me.lblONnum1)
			Me.tabON.Controls.Add(Me.txtONorder1)
			Me.tabON.Controls.Add(Me.lblONed)
			Me.tabON.Controls.Add(Me.lblONv1)
			Me.tabON.Controls.Add(Me.lblONmc1)
			Me.tabON.Controls.Add(Me.ckOnOut)
			Me.tabON.Controls.Add(Me.btnOnOut)
			Me.tabON.Controls.Add(Me.Label64)
			Me.tabON.Controls.Add(Me.txtOnValue)
			Me.tabON.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabON.Name = "tabON"
			Me.tabON.Size = New Global.System.Drawing.Size(934, 295)
			Me.tabON.TabIndex = 18
			Me.tabON.Text = "ON"
			Me.btnONtopup.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnONtopup.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnONtopup.Location = New Global.System.Drawing.Point(558, 178)
			Me.btnONtopup.Name = "btnONtopup"
			Me.btnONtopup.Size = New Global.System.Drawing.Size(75, 53)
			Me.btnONtopup.TabIndex = 1093
			Me.btnONtopup.Text = "TopUP"
			Me.btnONtopup.UseVisualStyleBackColor = False
			Me.btnONGift.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnONGift.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnONGift.Location = New Global.System.Drawing.Point(558, 124)
			Me.btnONGift.Name = "btnONGift"
			Me.btnONGift.Size = New Global.System.Drawing.Size(75, 53)
			Me.btnONGift.TabIndex = 1092
			Me.btnONGift.Text = "Gift"
			Me.btnONGift.UseVisualStyleBackColor = False
			Me.btnGetBal2ON.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetBal2ON.Font = New Global.System.Drawing.Font("Tahoma", 8.75F, Global.System.Drawing.FontStyle.Bold)
			Me.btnGetBal2ON.Location = New Global.System.Drawing.Point(433, 206)
			Me.btnGetBal2ON.Name = "btnGetBal2ON"
			Me.btnGetBal2ON.Size = New Global.System.Drawing.Size(121, 40)
			Me.btnGetBal2ON.TabIndex = 1091
			Me.btnGetBal2ON.Text = "VF BAl"
			Me.btnGetBal2ON.UseVisualStyleBackColor = False
			Me.btnAutoGet.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnAutoGet.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAutoGet.Location = New Global.System.Drawing.Point(271, 93)
			Me.btnAutoGet.Name = "btnAutoGet"
			Me.btnAutoGet.Size = New Global.System.Drawing.Size(75, 59)
			Me.btnAutoGet.TabIndex = 1090
			Me.btnAutoGet.Text = "Auto Get"
			Me.btnAutoGet.UseVisualStyleBackColor = False
			Me.btnAutoGet.Visible = False
			Me.btnPic.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnPic.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPic.Location = New Global.System.Drawing.Point(252, 164)
			Me.btnPic.Name = "btnPic"
			Me.btnPic.Size = New Global.System.Drawing.Size(130, 39)
			Me.btnPic.TabIndex = 1089
			Me.btnPic.Text = "Export"
			Me.btnPic.UseVisualStyleBackColor = False
			Me.btnPic.Visible = False
			Me.lblONnumQ.AutoSize = True
			Me.lblONnumQ.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnumQ.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnumQ.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnumQ.Location = New Global.System.Drawing.Point(3, 250)
			Me.lblONnumQ.Name = "lblONnumQ"
			Me.lblONnumQ.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnumQ.Size = New Global.System.Drawing.Size(28, 17)
			Me.lblONnumQ.TabIndex = 1088
			Me.lblONnumQ.Text = "#1"
			Me.lblONvQ.AutoSize = True
			Me.lblONvQ.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONvQ.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONvQ.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONvQ.Location = New Global.System.Drawing.Point(191, 250)
			Me.lblONvQ.Name = "lblONvQ"
			Me.lblONvQ.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONvQ.Size = New Global.System.Drawing.Size(19, 17)
			Me.lblONvQ.TabIndex = 1087
			Me.lblONvQ.Text = "#"
			Me.lblONmcQ.AutoSize = True
			Me.lblONmcQ.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmcQ.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmcQ.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmcQ.Location = New Global.System.Drawing.Point(4, 271)
			Me.lblONmcQ.Name = "lblONmcQ"
			Me.lblONmcQ.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmcQ.Size = New Global.System.Drawing.Size(17, 17)
			Me.lblONmcQ.TabIndex = 1086
			Me.lblONmcQ.Text = "$"
			Me.txtQryOrder.BackColor = Global.System.Drawing.Color.White
			Me.txtQryOrder.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtQryOrder.ForeColor = Global.System.Drawing.Color.Black
			Me.txtQryOrder.Location = New Global.System.Drawing.Point(3, 204)
			Me.txtQryOrder.Name = "txtQryOrder"
			Me.txtQryOrder.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtQryOrder.Size = New Global.System.Drawing.Size(410, 36)
			Me.txtQryOrder.TabIndex = 1085
			Me.txtQryOrder.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONnum6.AutoSize = True
			Me.lblONnum6.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum6.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum6.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum6.Location = New Global.System.Drawing.Point(3, 171)
			Me.lblONnum6.Name = "lblONnum6"
			Me.lblONnum6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum6.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum6.TabIndex = 1084
			Me.lblONnum6.Text = "#6"
			Me.txtONorder6.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder6.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder6.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder6.Location = New Global.System.Drawing.Point(433, 171)
			Me.txtONorder6.MaxLength = 11
			Me.txtONorder6.Name = "txtONorder6"
			Me.txtONorder6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder6.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder6.TabIndex = 1083
			Me.txtONorder6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONv6.AutoSize = True
			Me.lblONv6.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv6.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv6.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv6.Location = New Global.System.Drawing.Point(385, 171)
			Me.lblONv6.Name = "lblONv6"
			Me.lblONv6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv6.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv6.TabIndex = 1081
			Me.lblONv6.Text = "#"
			Me.lblONmc6.AutoSize = True
			Me.lblONmc6.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc6.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc6.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc6.Location = New Global.System.Drawing.Point(167, 171)
			Me.lblONmc6.Name = "lblONmc6"
			Me.lblONmc6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc6.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc6.TabIndex = 1080
			Me.lblONmc6.Text = "$"
			Me.lblONnum5.AutoSize = True
			Me.lblONnum5.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum5.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum5.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum5.Location = New Global.System.Drawing.Point(3, 139)
			Me.lblONnum5.Name = "lblONnum5"
			Me.lblONnum5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum5.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum5.TabIndex = 1079
			Me.lblONnum5.Text = "#5"
			Me.txtONorder5.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder5.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder5.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder5.Location = New Global.System.Drawing.Point(433, 139)
			Me.txtONorder5.MaxLength = 11
			Me.txtONorder5.Name = "txtONorder5"
			Me.txtONorder5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder5.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder5.TabIndex = 1078
			Me.txtONorder5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONv5.AutoSize = True
			Me.lblONv5.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv5.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv5.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv5.Location = New Global.System.Drawing.Point(385, 139)
			Me.lblONv5.Name = "lblONv5"
			Me.lblONv5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv5.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv5.TabIndex = 1076
			Me.lblONv5.Text = "#"
			Me.lblONmc5.AutoSize = True
			Me.lblONmc5.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc5.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc5.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc5.Location = New Global.System.Drawing.Point(167, 139)
			Me.lblONmc5.Name = "lblONmc5"
			Me.lblONmc5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc5.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc5.TabIndex = 1075
			Me.lblONmc5.Text = "$"
			Me.lblONnum4.AutoSize = True
			Me.lblONnum4.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum4.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum4.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum4.Location = New Global.System.Drawing.Point(3, 107)
			Me.lblONnum4.Name = "lblONnum4"
			Me.lblONnum4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum4.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum4.TabIndex = 1074
			Me.lblONnum4.Text = "#4"
			Me.txtONorder4.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder4.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder4.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder4.Location = New Global.System.Drawing.Point(433, 107)
			Me.txtONorder4.MaxLength = 11
			Me.txtONorder4.Name = "txtONorder4"
			Me.txtONorder4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder4.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder4.TabIndex = 1073
			Me.txtONorder4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONv4.AutoSize = True
			Me.lblONv4.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv4.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv4.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv4.Location = New Global.System.Drawing.Point(385, 107)
			Me.lblONv4.Name = "lblONv4"
			Me.lblONv4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv4.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv4.TabIndex = 1071
			Me.lblONv4.Text = "#"
			Me.lblONmc4.AutoSize = True
			Me.lblONmc4.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc4.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc4.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc4.Location = New Global.System.Drawing.Point(167, 107)
			Me.lblONmc4.Name = "lblONmc4"
			Me.lblONmc4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc4.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc4.TabIndex = 1070
			Me.lblONmc4.Text = "$"
			Me.lblONnum3.AutoSize = True
			Me.lblONnum3.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum3.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum3.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum3.Location = New Global.System.Drawing.Point(3, 75)
			Me.lblONnum3.Name = "lblONnum3"
			Me.lblONnum3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum3.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum3.TabIndex = 1069
			Me.lblONnum3.Text = "#3"
			Me.txtONorder3.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder3.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder3.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder3.Location = New Global.System.Drawing.Point(433, 75)
			Me.txtONorder3.MaxLength = 11
			Me.txtONorder3.Name = "txtONorder3"
			Me.txtONorder3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder3.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder3.TabIndex = 1068
			Me.txtONorder3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONv3.AutoSize = True
			Me.lblONv3.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv3.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv3.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv3.Location = New Global.System.Drawing.Point(385, 75)
			Me.lblONv3.Name = "lblONv3"
			Me.lblONv3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv3.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv3.TabIndex = 1066
			Me.lblONv3.Text = "#"
			Me.lblONmc3.AutoSize = True
			Me.lblONmc3.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc3.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc3.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc3.Location = New Global.System.Drawing.Point(167, 75)
			Me.lblONmc3.Name = "lblONmc3"
			Me.lblONmc3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc3.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc3.TabIndex = 1065
			Me.lblONmc3.Text = "$"
			Me.lblONnum2.AutoSize = True
			Me.lblONnum2.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum2.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum2.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum2.Location = New Global.System.Drawing.Point(3, 43)
			Me.lblONnum2.Name = "lblONnum2"
			Me.lblONnum2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum2.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum2.TabIndex = 1064
			Me.lblONnum2.Text = "#2"
			Me.txtONorder2.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder2.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder2.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder2.Location = New Global.System.Drawing.Point(433, 43)
			Me.txtONorder2.MaxLength = 11
			Me.txtONorder2.Name = "txtONorder2"
			Me.txtONorder2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder2.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder2.TabIndex = 1063
			Me.txtONorder2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONv2.AutoSize = True
			Me.lblONv2.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv2.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv2.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv2.Location = New Global.System.Drawing.Point(385, 43)
			Me.lblONv2.Name = "lblONv2"
			Me.lblONv2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv2.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv2.TabIndex = 1061
			Me.lblONv2.Text = "#"
			Me.lblONmc2.AutoSize = True
			Me.lblONmc2.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc2.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc2.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc2.Location = New Global.System.Drawing.Point(167, 43)
			Me.lblONmc2.Name = "lblONmc2"
			Me.lblONmc2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc2.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc2.TabIndex = 1060
			Me.lblONmc2.Text = "$"
			Me.lblONnum1.AutoSize = True
			Me.lblONnum1.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONnum1.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONnum1.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONnum1.Location = New Global.System.Drawing.Point(3, 11)
			Me.lblONnum1.Name = "lblONnum1"
			Me.lblONnum1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONnum1.Size = New Global.System.Drawing.Size(39, 24)
			Me.lblONnum1.TabIndex = 1059
			Me.lblONnum1.Text = "#1"
			Me.txtONorder1.BackColor = Global.System.Drawing.Color.White
			Me.txtONorder1.Font = New Global.System.Drawing.Font("Tahoma", 13F, Global.System.Drawing.FontStyle.Bold)
			Me.txtONorder1.ForeColor = Global.System.Drawing.Color.Black
			Me.txtONorder1.Location = New Global.System.Drawing.Point(433, 11)
			Me.txtONorder1.MaxLength = 11
			Me.txtONorder1.Name = "txtONorder1"
			Me.txtONorder1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtONorder1.Size = New Global.System.Drawing.Size(119, 28)
			Me.txtONorder1.TabIndex = 1058
			Me.txtONorder1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblONed.AutoSize = True
			Me.lblONed.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONed.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONed.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONed.Location = New Global.System.Drawing.Point(561, 11)
			Me.lblONed.Name = "lblONed"
			Me.lblONed.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONed.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONed.TabIndex = 1057
			Me.lblONed.Text = "#"
			Me.lblONv1.AutoSize = True
			Me.lblONv1.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONv1.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONv1.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONv1.Location = New Global.System.Drawing.Point(385, 11)
			Me.lblONv1.Name = "lblONv1"
			Me.lblONv1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONv1.Size = New Global.System.Drawing.Size(26, 24)
			Me.lblONv1.TabIndex = 1056
			Me.lblONv1.Text = "#"
			Me.lblONmc1.AutoSize = True
			Me.lblONmc1.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.lblONmc1.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.lblONmc1.ForeColor = Global.System.Drawing.Color.Black
			Me.lblONmc1.Location = New Global.System.Drawing.Point(167, 11)
			Me.lblONmc1.Name = "lblONmc1"
			Me.lblONmc1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblONmc1.Size = New Global.System.Drawing.Size(23, 24)
			Me.lblONmc1.TabIndex = 1055
			Me.lblONmc1.Text = "$"
			Me.ckOnOut.AutoSize = True
			Me.ckOnOut.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.ckOnOut.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckOnOut.ForeColor = Global.System.Drawing.Color.Black
			Me.ckOnOut.Location = New Global.System.Drawing.Point(589, 45)
			Me.ckOnOut.Name = "ckOnOut"
			Me.ckOnOut.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckOnOut.Size = New Global.System.Drawing.Size(41, 17)
			Me.ckOnOut.TabIndex = 1054
			Me.ckOnOut.Text = "Au"
			Me.ckOnOut.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckOnOut.UseVisualStyleBackColor = False
			Me.btnOnOut.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnOnOut.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOnOut.Location = New Global.System.Drawing.Point(558, 43)
			Me.btnOnOut.Name = "btnOnOut"
			Me.btnOnOut.Size = New Global.System.Drawing.Size(75, 80)
			Me.btnOnOut.TabIndex = 1053
			Me.btnOnOut.Text = "Online Get"
			Me.btnOnOut.UseVisualStyleBackColor = False
			Me.Label64.AutoSize = True
			Me.Label64.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label64.ForeColor = Global.System.Drawing.Color.Black
			Me.Label64.Location = New Global.System.Drawing.Point(557, 268)
			Me.Label64.Name = "Label64"
			Me.Label64.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label64.Size = New Global.System.Drawing.Size(46, 17)
			Me.Label64.TabIndex = 1052
			Me.Label64.Text = "Value"
			Me.txtOnValue.BackColor = Global.System.Drawing.Color.White
			Me.txtOnValue.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtOnValue.ForeColor = Global.System.Drawing.Color.Black
			Me.txtOnValue.Location = New Global.System.Drawing.Point(433, 253)
			Me.txtOnValue.Name = "txtOnValue"
			Me.txtOnValue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtOnValue.Size = New Global.System.Drawing.Size(121, 36)
			Me.txtOnValue.TabIndex = 1051
			Me.txtOnValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.TabPage2.Controls.Add(Me.RBEts)
			Me.TabPage2.Controls.Add(Me.RBVoda)
			Me.TabPage2.Controls.Add(Me.btnApplyCards2)
			Me.TabPage2.Controls.Add(Me.btnApplyCards)
			Me.TabPage2.Controls.Add(Me.btnAddCards)
			Me.TabPage2.Controls.Add(Me.ckCards)
			Me.TabPage2.Controls.Add(Me.lblCardsQty)
			Me.TabPage2.Controls.Add(Me.cmbEvalue)
			Me.TabPage2.Controls.Add(Me.txtChSS)
			Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage2.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "TopUp"
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.TabPage8.Controls.Add(Me.lstNames)
			Me.TabPage8.Controls.Add(Me.lstNum)
			Me.TabPage8.Controls.Add(Me.btnRefreshMsg)
			Me.TabPage8.Controls.Add(Me.txtEnote)
			Me.TabPage8.Controls.Add(Me.txtSvrName)
			Me.TabPage8.Controls.Add(Me.txtSrvMsg)
			Me.TabPage8.Controls.Add(Me.txtMobnum)
			Me.TabPage8.Controls.Add(Me.btnSendSms)
			Me.TabPage8.Controls.Add(Me.Button1)
			Me.TabPage8.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage8.Name = "TabPage8"
			Me.TabPage8.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage8.TabIndex = 7
			Me.TabPage8.Text = "Services"
			Me.TabPage8.UseVisualStyleBackColor = True
			Me.lstNames.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNames.FormattingEnabled = True
			Me.lstNames.ItemHeight = 23
			Me.lstNames.Location = New Global.System.Drawing.Point(253, 14)
			Me.lstNames.Name = "lstNames"
			Me.lstNames.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNames.Size = New Global.System.Drawing.Size(216, 142)
			Me.lstNames.TabIndex = 972
			Me.lstNum.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstNum.FormattingEnabled = True
			Me.lstNum.ItemHeight = 23
			Me.lstNum.Location = New Global.System.Drawing.Point(475, 45)
			Me.lstNum.Name = "lstNum"
			Me.lstNum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstNum.Size = New Global.System.Drawing.Size(138, 96)
			Me.lstNum.TabIndex = 971
			Me.btnRefreshMsg.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnRefreshMsg.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRefreshMsg.Location = New Global.System.Drawing.Point(475, 15)
			Me.btnRefreshMsg.Name = "btnRefreshMsg"
			Me.btnRefreshMsg.Size = New Global.System.Drawing.Size(138, 27)
			Me.btnRefreshMsg.TabIndex = 970
			Me.btnRefreshMsg.Text = "تحديث الارقام"
			Me.btnRefreshMsg.UseVisualStyleBackColor = False
			Me.txtEnote.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.txtEnote.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnote.ForeColor = Global.System.Drawing.Color.Black
			Me.txtEnote.Location = New Global.System.Drawing.Point(14, 147)
			Me.txtEnote.Name = "txtEnote"
			Me.txtEnote.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnote.Size = New Global.System.Drawing.Size(233, 27)
			Me.txtEnote.TabIndex = 938
			Me.txtSvrName.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.txtSvrName.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSvrName.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSvrName.Location = New Global.System.Drawing.Point(14, 114)
			Me.txtSvrName.Name = "txtSvrName"
			Me.txtSvrName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSvrName.Size = New Global.System.Drawing.Size(233, 27)
			Me.txtSvrName.TabIndex = 937
			Me.txtSrvMsg.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.txtSrvMsg.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSrvMsg.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSrvMsg.Location = New Global.System.Drawing.Point(14, 79)
			Me.txtSrvMsg.Name = "txtSrvMsg"
			Me.txtSrvMsg.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtSrvMsg.Size = New Global.System.Drawing.Size(233, 27)
			Me.txtSrvMsg.TabIndex = 936
			Me.txtMobnum.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.txtMobnum.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMobnum.ForeColor = Global.System.Drawing.Color.Black
			Me.txtMobnum.Location = New Global.System.Drawing.Point(107, 47)
			Me.txtMobnum.Name = "txtMobnum"
			Me.txtMobnum.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtMobnum.Size = New Global.System.Drawing.Size(140, 27)
			Me.txtMobnum.TabIndex = 933
			Me.btnSendSms.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnSendSms.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSendSms.ForeColor = Global.System.Drawing.Color.Black
			Me.btnSendSms.Location = New Global.System.Drawing.Point(14, 14)
			Me.btnSendSms.Name = "btnSendSms"
			Me.btnSendSms.Size = New Global.System.Drawing.Size(233, 27)
			Me.btnSendSms.TabIndex = 935
			Me.btnSendSms.Text = "ارسال"
			Me.btnSendSms.UseVisualStyleBackColor = False
			Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.Button1.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.Location = New Global.System.Drawing.Point(34, 211)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(167, 27)
			Me.Button1.TabIndex = 932
			Me.Button1.Text = "اضافة ارقام الخدمات"
			Me.Button1.UseVisualStyleBackColor = False
			Me.TabPage9.Controls.Add(Me.btnPast)
			Me.TabPage9.Controls.Add(Me.Label22)
			Me.TabPage9.Controls.Add(Me.Label20)
			Me.TabPage9.Controls.Add(Me.dataViewGridQryChrg)
			Me.TabPage9.Controls.Add(Me.dataViewGridQryBal)
			Me.TabPage9.Controls.Add(Me.txtNumQry)
			Me.TabPage9.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage9.Name = "TabPage9"
			Me.TabPage9.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage9.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage9.TabIndex = 8
			Me.TabPage9.Text = "BalQry"
			Me.TabPage9.UseVisualStyleBackColor = True
			Me.btnPast.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnPast.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPast.Location = New Global.System.Drawing.Point(356, 9)
			Me.btnPast.Name = "btnPast"
			Me.btnPast.Size = New Global.System.Drawing.Size(61, 27)
			Me.btnPast.TabIndex = 1001
			Me.btnPast.Text = "لصق"
			Me.btnPast.UseVisualStyleBackColor = False
			Me.Label22.AutoSize = True
			Me.Label22.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label22.ForeColor = Global.System.Drawing.Color.Black
			Me.Label22.Location = New Global.System.Drawing.Point(10, 17)
			Me.Label22.Name = "Label22"
			Me.Label22.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label22.Size = New Global.System.Drawing.Size(62, 19)
			Me.Label22.TabIndex = 1000
			Me.Label22.Text = "الشحن"
			Me.Label20.AutoSize = True
			Me.Label20.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label20.ForeColor = Global.System.Drawing.Color.Black
			Me.Label20.Location = New Global.System.Drawing.Point(279, 17)
			Me.Label20.Name = "Label20"
			Me.Label20.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label20.Size = New Global.System.Drawing.Size(64, 19)
			Me.Label20.TabIndex = 999
			Me.Label20.Text = "الارصدة"
			Me.dataViewGridQryChrg.AllowUserToAddRows = False
			Me.dataViewGridQryChrg.AllowUserToDeleteRows = False
			Me.dataViewGridQryChrg.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle6.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle6.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGridQryChrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6
			Me.dataViewGridQryChrg.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle7.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle7.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle7.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle7.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle7.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGridQryChrg.DefaultCellStyle = dataGridViewCellStyle7
			Me.dataViewGridQryChrg.Location = New Global.System.Drawing.Point(9, 44)
			Me.dataViewGridQryChrg.Name = "dataViewGridQryChrg"
			Me.dataViewGridQryChrg.[ReadOnly] = True
			Me.dataViewGridQryChrg.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.dataViewGridQryChrg.RowHeadersWidth = 51
			Me.dataViewGridQryChrg.Size = New Global.System.Drawing.Size(268, 222)
			Me.dataViewGridQryChrg.TabIndex = 990
			Me.dataViewGridQryBal.AllowUserToAddRows = False
			Me.dataViewGridQryBal.AllowUserToDeleteRows = False
			Me.dataViewGridQryBal.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle8.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			dataGridViewCellStyle8.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle8.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle8.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle8.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle8.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGridQryBal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8
			Me.dataViewGridQryBal.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			dataGridViewCellStyle9.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle9.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle9.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle9.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle9.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle9.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle9.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dataViewGridQryBal.DefaultCellStyle = dataGridViewCellStyle9
			Me.dataViewGridQryBal.Location = New Global.System.Drawing.Point(283, 44)
			Me.dataViewGridQryBal.Name = "dataViewGridQryBal"
			Me.dataViewGridQryBal.[ReadOnly] = True
			Me.dataViewGridQryBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.dataViewGridQryBal.RowHeadersWidth = 51
			Me.dataViewGridQryBal.Size = New Global.System.Drawing.Size(335, 222)
			Me.dataViewGridQryBal.TabIndex = 989
			Me.txtNumQry.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.txtNumQry.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNumQry.ForeColor = Global.System.Drawing.Color.Black
			Me.txtNumQry.Location = New Global.System.Drawing.Point(423, 12)
			Me.txtNumQry.MaxLength = 11
			Me.txtNumQry.Name = "txtNumQry"
			Me.txtNumQry.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtNumQry.Size = New Global.System.Drawing.Size(194, 27)
			Me.txtNumQry.TabIndex = 737
			Me.TabPage10.Controls.Add(Me.lblSavePath)
			Me.TabPage10.Controls.Add(Me.btnSaveAS)
			Me.TabPage10.Controls.Add(Me.btnExport2)
			Me.TabPage10.Controls.Add(Me.btnQryQry)
			Me.TabPage10.Controls.Add(Me.lblQryTotal)
			Me.TabPage10.Controls.Add(Me.lstQryBal)
			Me.TabPage10.Controls.Add(Me.lstQryNumbers)
			Me.TabPage10.Controls.Add(Me.txtEnumsVCQry)
			Me.TabPage10.Controls.Add(Me.btnGetQry)
			Me.TabPage10.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage10.Name = "TabPage10"
			Me.TabPage10.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage10.Size = New Global.System.Drawing.Size(934, 295)
			Me.TabPage10.TabIndex = 9
			Me.TabPage10.Text = "GrpBalQry"
			Me.TabPage10.UseVisualStyleBackColor = True
			Me.lblSavePath.BackColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.lblSavePath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblSavePath.Font = New Global.System.Drawing.Font("Tahoma", 6.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSavePath.ForeColor = Global.System.Drawing.Color.Black
			Me.lblSavePath.Location = New Global.System.Drawing.Point(429, 216)
			Me.lblSavePath.Name = "lblSavePath"
			Me.lblSavePath.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblSavePath.Size = New Global.System.Drawing.Size(142, 38)
			Me.lblSavePath.TabIndex = 985
			Me.lblSavePath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnSaveAS.Location = New Global.System.Drawing.Point(373, 216)
			Me.btnSaveAS.Name = "btnSaveAS"
			Me.btnSaveAS.Size = New Global.System.Drawing.Size(45, 44)
			Me.btnSaveAS.TabIndex = 984
			Me.btnSaveAS.Text = "مكان الحفظ"
			Me.btnSaveAS.UseVisualStyleBackColor = True
			Me.btnExport2.Location = New Global.System.Drawing.Point(325, 216)
			Me.btnExport2.Name = "btnExport2"
			Me.btnExport2.Size = New Global.System.Drawing.Size(48, 44)
			Me.btnExport2.TabIndex = 983
			Me.btnExport2.Text = "تصدير"
			Me.btnExport2.UseVisualStyleBackColor = True
			Me.btnQryQry.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnQryQry.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnQryQry.Location = New Global.System.Drawing.Point(457, 49)
			Me.btnQryQry.Name = "btnQryQry"
			Me.btnQryQry.Size = New Global.System.Drawing.Size(102, 27)
			Me.btnQryQry.TabIndex = 982
			Me.btnQryQry.Text = "استعلام"
			Me.btnQryQry.UseVisualStyleBackColor = False
			Me.lblQryTotal.BackColor = Global.System.Drawing.Color.Yellow
			Me.lblQryTotal.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblQryTotal.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.lblQryTotal.ForeColor = Global.System.Drawing.Color.Black
			Me.lblQryTotal.Location = New Global.System.Drawing.Point(393, 83)
			Me.lblQryTotal.Name = "lblQryTotal"
			Me.lblQryTotal.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblQryTotal.Size = New Global.System.Drawing.Size(166, 27)
			Me.lblQryTotal.TabIndex = 981
			Me.lblQryTotal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lstQryBal.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstQryBal.FormattingEnabled = True
			Me.lstQryBal.ItemHeight = 23
			Me.lstQryBal.Location = New Global.System.Drawing.Point(182, 5)
			Me.lstQryBal.Name = "lstQryBal"
			Me.lstQryBal.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstQryBal.Size = New Global.System.Drawing.Size(124, 142)
			Me.lstQryBal.TabIndex = 973
			Me.lstQryNumbers.Font = New Global.System.Drawing.Font("Tahoma", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.lstQryNumbers.FormattingEnabled = True
			Me.lstQryNumbers.ItemHeight = 23
			Me.lstQryNumbers.Location = New Global.System.Drawing.Point(14, 5)
			Me.lstQryNumbers.Name = "lstQryNumbers"
			Me.lstQryNumbers.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstQryNumbers.Size = New Global.System.Drawing.Size(162, 142)
			Me.lstQryNumbers.TabIndex = 972
			Me.txtEnumsVCQry.BackColor = Global.System.Drawing.Color.White
			Me.txtEnumsVCQry.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEnumsVCQry.ForeColor = Global.System.Drawing.Color.Black
			Me.txtEnumsVCQry.Location = New Global.System.Drawing.Point(393, 14)
			Me.txtEnumsVCQry.Name = "txtEnumsVCQry"
			Me.txtEnumsVCQry.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtEnumsVCQry.Size = New Global.System.Drawing.Size(58, 27)
			Me.txtEnumsVCQry.TabIndex = 971
			Me.txtEnumsVCQry.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnGetQry.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetQry.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetQry.Location = New Global.System.Drawing.Point(457, 14)
			Me.btnGetQry.Name = "btnGetQry"
			Me.btnGetQry.Size = New Global.System.Drawing.Size(102, 27)
			Me.btnGetQry.TabIndex = 970
			Me.btnGetQry.Text = "هات الخطوط"
			Me.btnGetQry.UseVisualStyleBackColor = False
			Me.chkAutoMain.AutoSize = True
			Me.chkAutoMain.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAutoMain.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkAutoMain.Location = New Global.System.Drawing.Point(40, 128)
			Me.chkAutoMain.Name = "chkAutoMain"
			Me.chkAutoMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAutoMain.Size = New Global.System.Drawing.Size(182, 17)
			Me.chkAutoMain.TabIndex = 1013
			Me.chkAutoMain.Text = "اختيار تلقائى للاساسى التالى"
			Me.chkAutoMain.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAutoMain.UseVisualStyleBackColor = True
			Me.ckUseNextMain.AutoSize = True
			Me.ckUseNextMain.Checked = True
			Me.ckUseNextMain.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.ckUseNextMain.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckUseNextMain.ForeColor = Global.System.Drawing.Color.White
			Me.ckUseNextMain.Location = New Global.System.Drawing.Point(61, 145)
			Me.ckUseNextMain.Name = "ckUseNextMain"
			Me.ckUseNextMain.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckUseNextMain.Size = New Global.System.Drawing.Size(161, 17)
			Me.ckUseNextMain.TabIndex = 1051
			Me.ckUseNextMain.Text = "استعمال الاساسى التالى"
			Me.ckUseNextMain.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckUseNextMain.UseVisualStyleBackColor = True
			Me.chkUse365inprcss.AutoSize = True
			Me.chkUse365inprcss.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkUse365inprcss.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkUse365inprcss.Location = New Global.System.Drawing.Point(143, 247)
			Me.chkUse365inprcss.Name = "chkUse365inprcss"
			Me.chkUse365inprcss.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkUse365inprcss.Size = New Global.System.Drawing.Size(77, 17)
			Me.chkUse365inprcss.TabIndex = 1017
			Me.chkUse365inprcss.Text = "ادراج 365"
			Me.chkUse365inprcss.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkUse365inprcss.UseVisualStyleBackColor = False
			Me.chkUse365inprcss10.AutoSize = True
			Me.chkUse365inprcss10.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.chkUse365inprcss10.Enabled = False
			Me.chkUse365inprcss10.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkUse365inprcss10.Location = New Global.System.Drawing.Point(116, 230)
			Me.chkUse365inprcss10.Name = "chkUse365inprcss10"
			Me.chkUse365inprcss10.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkUse365inprcss10.Size = New Global.System.Drawing.Size(104, 17)
			Me.chkUse365inprcss10.TabIndex = 1048
			Me.chkUse365inprcss10.Text = "شحن ال5 ب10"
			Me.chkUse365inprcss10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkUse365inprcss10.UseVisualStyleBackColor = False
			Me.chkSqn.AutoSize = True
			Me.chkSqn.Checked = True
			Me.chkSqn.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkSqn.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkSqn.ForeColor = Global.System.Drawing.Color.White
			Me.chkSqn.Location = New Global.System.Drawing.Point(77, 162)
			Me.chkSqn.Name = "chkSqn"
			Me.chkSqn.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkSqn.Size = New Global.System.Drawing.Size(145, 17)
			Me.chkSqn.TabIndex = 1007
			Me.chkSqn.Text = "ممنوع التكرار لفودافون"
			Me.chkSqn.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkSqn.UseVisualStyleBackColor = True
			Me.chkTransferAllNormalVoda.AutoSize = True
			Me.chkTransferAllNormalVoda.BackColor = Global.System.Drawing.Color.Lime
			Me.chkTransferAllNormalVoda.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkTransferAllNormalVoda.Location = New Global.System.Drawing.Point(15, 111)
			Me.chkTransferAllNormalVoda.Name = "chkTransferAllNormalVoda"
			Me.chkTransferAllNormalVoda.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkTransferAllNormalVoda.Size = New Global.System.Drawing.Size(207, 17)
			Me.chkTransferAllNormalVoda.TabIndex = 1011
			Me.chkTransferAllNormalVoda.Text = "تحويل كامل الرصيد العادى من الكل"
			Me.chkTransferAllNormalVoda.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkTransferAllNormalVoda.UseVisualStyleBackColor = False
			Me.ckUse910.AutoSize = True
			Me.ckUse910.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.ckUse910.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckUse910.Location = New Global.System.Drawing.Point(81, 264)
			Me.ckUse910.Name = "ckUse910"
			Me.ckUse910.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckUse910.Size = New Global.System.Drawing.Size(139, 17)
			Me.ckUse910.TabIndex = 1016
			Me.ckUse910.Text = "استعمال كود *9*10#"
			Me.ckUse910.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckUse910.UseVisualStyleBackColor = False
			Me.chkChargeOnSame.AutoSize = True
			Me.chkChargeOnSame.BackColor = Global.System.Drawing.Color.Lime
			Me.chkChargeOnSame.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkChargeOnSame.Location = New Global.System.Drawing.Point(47, 94)
			Me.chkChargeOnSame.Name = "chkChargeOnSame"
			Me.chkChargeOnSame.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkChargeOnSame.Size = New Global.System.Drawing.Size(175, 17)
			Me.chkChargeOnSame.TabIndex = 1009
			Me.chkChargeOnSame.Text = "شحن الهدية على نفس الرقم"
			Me.chkChargeOnSame.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkChargeOnSame.UseVisualStyleBackColor = False
			Me.btnCancelTrans.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.btnCancelTrans.Font = New Global.System.Drawing.Font("Tahoma", 15F, Global.System.Drawing.FontStyle.Bold)
			Me.btnCancelTrans.Location = New Global.System.Drawing.Point(976, 4)
			Me.btnCancelTrans.Name = "btnCancelTrans"
			Me.btnCancelTrans.Size = New Global.System.Drawing.Size(190, 35)
			Me.btnCancelTrans.TabIndex = 984
			Me.btnCancelTrans.Text = "STOP"
			Me.btnCancelTrans.UseVisualStyleBackColor = False
			Me.btn3G.BackColor = Global.System.Drawing.Color.Green
			Me.btn3G.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btn3G.Location = New Global.System.Drawing.Point(173, 224)
			Me.btn3G.Name = "btn3G"
			Me.btn3G.Size = New Global.System.Drawing.Size(59, 25)
			Me.btn3G.TabIndex = 952
			Me.btn3G.Text = "3G Only"
			Me.btn3G.UseVisualStyleBackColor = False
			Me.chkStop.AutoSize = True
			Me.chkStop.BackColor = Global.System.Drawing.Color.FromArgb(255, 192, 192)
			Me.chkStop.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.chkStop.ForeColor = Global.System.Drawing.Color.FromArgb(192, 0, 0)
			Me.chkStop.Location = New Global.System.Drawing.Point(982, 12)
			Me.chkStop.Name = "chkStop"
			Me.chkStop.Size = New Global.System.Drawing.Size(60, 21)
			Me.chkStop.TabIndex = 975
			Me.chkStop.Text = "Stop"
			Me.chkStop.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkStop.UseVisualStyleBackColor = False
			Me.lblGifts01.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts01.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts01.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts01.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts01.Location = New Global.System.Drawing.Point(923, 71)
			Me.lblGifts01.Name = "lblGifts01"
			Me.lblGifts01.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts01.Size = New Global.System.Drawing.Size(47, 27)
			Me.lblGifts01.TabIndex = 976
			Me.lblGifts01.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifts02.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts02.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts02.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts02.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts02.Location = New Global.System.Drawing.Point(481, 71)
			Me.lblGifts02.Name = "lblGifts02"
			Me.lblGifts02.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts02.Size = New Global.System.Drawing.Size(37, 27)
			Me.lblGifts02.TabIndex = 977
			Me.lblGifts02.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifts03.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts03.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts03.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts03.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts03.Location = New Global.System.Drawing.Point(42, 71)
			Me.lblGifts03.Name = "lblGifts03"
			Me.lblGifts03.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts03.Size = New Global.System.Drawing.Size(37, 27)
			Me.lblGifts03.TabIndex = 978
			Me.lblGifts03.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifts04.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts04.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts04.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts04.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts04.Location = New Global.System.Drawing.Point(923, 247)
			Me.lblGifts04.Name = "lblGifts04"
			Me.lblGifts04.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts04.Size = New Global.System.Drawing.Size(47, 27)
			Me.lblGifts04.TabIndex = 979
			Me.lblGifts04.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifts05.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts05.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts05.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts05.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts05.Location = New Global.System.Drawing.Point(481, 247)
			Me.lblGifts05.Name = "lblGifts05"
			Me.lblGifts05.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts05.Size = New Global.System.Drawing.Size(37, 27)
			Me.lblGifts05.TabIndex = 980
			Me.lblGifts05.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifts06.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifts06.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifts06.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifts06.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifts06.Location = New Global.System.Drawing.Point(42, 247)
			Me.lblGifts06.Name = "lblGifts06"
			Me.lblGifts06.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifts06.Size = New Global.System.Drawing.Size(37, 27)
			Me.lblGifts06.TabIndex = 981
			Me.lblGifts06.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.SFD.DefaultExt = "*.jpg"
			Me.chkAutoDell.AutoSize = True
			Me.chkAutoDell.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAutoDell.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkAutoDell.Location = New Global.System.Drawing.Point(41, 77)
			Me.chkAutoDell.Name = "chkAutoDell"
			Me.chkAutoDell.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAutoDell.Size = New Global.System.Drawing.Size(181, 17)
			Me.chkAutoDell.TabIndex = 985
			Me.chkAutoDell.Text = "حذف تلقائى للرسائل المقروئة"
			Me.chkAutoDell.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAutoDell.UseVisualStyleBackColor = True
			Me.ODfile.FileName = "OFD"
			Me.lblGiftV1.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV1.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV1.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV1.Location = New Global.System.Drawing.Point(971, 71)
			Me.lblGiftV1.Name = "lblGiftV1"
			Me.lblGiftV1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV1.Size = New Global.System.Drawing.Size(36, 27)
			Me.lblGiftV1.TabIndex = 986
			Me.lblGiftV1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGiftV2.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV2.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV2.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV2.Location = New Global.System.Drawing.Point(519, 71)
			Me.lblGiftV2.Name = "lblGiftV2"
			Me.lblGiftV2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV2.Size = New Global.System.Drawing.Size(35, 27)
			Me.lblGiftV2.TabIndex = 988
			Me.lblGiftV2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGiftV3.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV3.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV3.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV3.Location = New Global.System.Drawing.Point(80, 71)
			Me.lblGiftV3.Name = "lblGiftV3"
			Me.lblGiftV3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV3.Size = New Global.System.Drawing.Size(35, 27)
			Me.lblGiftV3.TabIndex = 990
			Me.lblGiftV3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGiftV4.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV4.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV4.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV4.Location = New Global.System.Drawing.Point(971, 247)
			Me.lblGiftV4.Name = "lblGiftV4"
			Me.lblGiftV4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV4.Size = New Global.System.Drawing.Size(36, 27)
			Me.lblGiftV4.TabIndex = 992
			Me.lblGiftV4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGiftV5.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV5.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV5.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV5.Location = New Global.System.Drawing.Point(519, 247)
			Me.lblGiftV5.Name = "lblGiftV5"
			Me.lblGiftV5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV5.Size = New Global.System.Drawing.Size(35, 27)
			Me.lblGiftV5.TabIndex = 994
			Me.lblGiftV5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGiftV6.BackColor = Global.System.Drawing.Color.Black
			Me.lblGiftV6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGiftV6.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGiftV6.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGiftV6.Location = New Global.System.Drawing.Point(80, 247)
			Me.lblGiftV6.Name = "lblGiftV6"
			Me.lblGiftV6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGiftV6.Size = New Global.System.Drawing.Size(35, 27)
			Me.lblGiftV6.TabIndex = 996
			Me.lblGiftV6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal6.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal6.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal6.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal6.Location = New Global.System.Drawing.Point(117, 247)
			Me.lblGifttotal6.Name = "lblGifttotal6"
			Me.lblGifttotal6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal6.Size = New Global.System.Drawing.Size(103, 27)
			Me.lblGifttotal6.TabIndex = 1003
			Me.lblGifttotal6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal5.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal5.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal5.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal5.Location = New Global.System.Drawing.Point(555, 247)
			Me.lblGifttotal5.Name = "lblGifttotal5"
			Me.lblGifttotal5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal5.Size = New Global.System.Drawing.Size(103, 27)
			Me.lblGifttotal5.TabIndex = 1002
			Me.lblGifttotal5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal4.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal4.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal4.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal4.Location = New Global.System.Drawing.Point(1008, 247)
			Me.lblGifttotal4.Name = "lblGifttotal4"
			Me.lblGifttotal4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal4.Size = New Global.System.Drawing.Size(102, 27)
			Me.lblGifttotal4.TabIndex = 1001
			Me.lblGifttotal4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal3.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal3.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal3.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal3.Location = New Global.System.Drawing.Point(117, 71)
			Me.lblGifttotal3.Name = "lblGifttotal3"
			Me.lblGifttotal3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal3.Size = New Global.System.Drawing.Size(103, 27)
			Me.lblGifttotal3.TabIndex = 1000
			Me.lblGifttotal3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal2.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal2.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal2.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal2.Location = New Global.System.Drawing.Point(555, 71)
			Me.lblGifttotal2.Name = "lblGifttotal2"
			Me.lblGifttotal2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal2.Size = New Global.System.Drawing.Size(103, 27)
			Me.lblGifttotal2.TabIndex = 999
			Me.lblGifttotal2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGifttotal1.BackColor = Global.System.Drawing.Color.Black
			Me.lblGifttotal1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblGifttotal1.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblGifttotal1.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblGifttotal1.Location = New Global.System.Drawing.Point(1008, 71)
			Me.lblGifttotal1.Name = "lblGifttotal1"
			Me.lblGifttotal1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblGifttotal1.Size = New Global.System.Drawing.Size(102, 27)
			Me.lblGifttotal1.TabIndex = 998
			Me.lblGifttotal1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnRefreshComs.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.btnRefreshComs.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnRefreshComs.Location = New Global.System.Drawing.Point(6, 50)
			Me.btnRefreshComs.Name = "btnRefreshComs"
			Me.btnRefreshComs.Size = New Global.System.Drawing.Size(75, 37)
			Me.btnRefreshComs.TabIndex = 1004
			Me.btnRefreshComs.Text = "Coms"
			Me.btnRefreshComs.UseVisualStyleBackColor = False
			Me.btnGetSimsGifts.BackColor = Global.System.Drawing.Color.FromArgb(255, 224, 192)
			Me.btnGetSimsGifts.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGetSimsGifts.ForeColor = Global.System.Drawing.Color.Black
			Me.btnGetSimsGifts.Location = New Global.System.Drawing.Point(106, 126)
			Me.btnGetSimsGifts.Name = "btnGetSimsGifts"
			Me.btnGetSimsGifts.Size = New Global.System.Drawing.Size(126, 36)
			Me.btnGetSimsGifts.TabIndex = 1005
			Me.btnGetSimsGifts.Text = "اعادة تشغيل الهدايا"
			Me.btnGetSimsGifts.UseVisualStyleBackColor = False
			Me.btnGetInfo.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnGetInfo.Font = New Global.System.Drawing.Font("Arial Narrow", 7.25F, Global.System.Drawing.FontStyle.Bold)
			Me.btnGetInfo.ForeColor = Global.System.Drawing.Color.Black
			Me.btnGetInfo.Location = New Global.System.Drawing.Point(6, 262)
			Me.btnGetInfo.Name = "btnGetInfo"
			Me.btnGetInfo.Size = New Global.System.Drawing.Size(40, 24)
			Me.btnGetInfo.TabIndex = 1006
			Me.btnGetInfo.Text = "Inf"
			Me.btnGetInfo.UseVisualStyleBackColor = False
			Me.chkAutoRes.AutoSize = True
			Me.chkAutoRes.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkAutoRes.ForeColor = Global.System.Drawing.Color.Cyan
			Me.chkAutoRes.Location = New Global.System.Drawing.Point(40, 196)
			Me.chkAutoRes.Name = "chkAutoRes"
			Me.chkAutoRes.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkAutoRes.Size = New Global.System.Drawing.Size(182, 17)
			Me.chkAutoRes.TabIndex = 944
			Me.chkAutoRes.Text = "اعادة التشغيل التلقائى للمودم"
			Me.chkAutoRes.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkAutoRes.UseVisualStyleBackColor = True
			Me.chkDelSms.AutoSize = True
			Me.chkDelSms.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkDelSms.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkDelSms.ForeColor = Global.System.Drawing.Color.Black
			Me.chkDelSms.Location = New Global.System.Drawing.Point(159, 114)
			Me.chkDelSms.Name = "chkDelSms"
			Me.chkDelSms.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkDelSms.Size = New Global.System.Drawing.Size(41, 17)
			Me.chkDelSms.TabIndex = 1010
			Me.chkDelSms.Text = "Au"
			Me.chkDelSms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkDelSms.UseVisualStyleBackColor = False
			Me.chkReadsms.AutoSize = True
			Me.chkReadsms.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.chkReadsms.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkReadsms.ForeColor = Global.System.Drawing.Color.Black
			Me.chkReadsms.Location = New Global.System.Drawing.Point(156, 83)
			Me.chkReadsms.Name = "chkReadsms"
			Me.chkReadsms.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkReadsms.Size = New Global.System.Drawing.Size(41, 17)
			Me.chkReadsms.TabIndex = 1011
			Me.chkReadsms.Text = "Au"
			Me.chkReadsms.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkReadsms.UseVisualStyleBackColor = False
			Me.TabControl1.Controls.Add(Me.TabPage11)
			Me.TabControl1.Controls.Add(Me.TabPage15)
			Me.TabControl1.Controls.Add(Me.TabPage16)
			Me.TabControl1.Controls.Add(Me.TabPage17)
			Me.TabControl1.Controls.Add(Me.tabServer)
			Me.TabControl1.Location = New Global.System.Drawing.Point(1094, 393)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.TabControl1.Size = New Global.System.Drawing.Size(246, 322)
			Me.TabControl1.TabIndex = 1012
			Me.TabPage11.BackColor = Global.System.Drawing.Color.Black
			Me.TabPage11.Controls.Add(Me.btnSA)
			Me.TabPage11.Controls.Add(Me.btnDeSA)
			Me.TabPage11.Controls.Add(Me.txtInfo)
			Me.TabPage11.Controls.Add(Me.btnInvertSelection)
			Me.TabPage11.Controls.Add(Me.btnSADwn)
			Me.TabPage11.Controls.Add(Me.txtLoopF)
			Me.TabPage11.Controls.Add(Me.btnUp)
			Me.TabPage11.Controls.Add(Me.BtnOO)
			Me.TabPage11.Controls.Add(Me.txtLoopS)
			Me.TabPage11.Controls.Add(Me.btnVV)
			Me.TabPage11.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage11.Name = "TabPage11"
			Me.TabPage11.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage11.Size = New Global.System.Drawing.Size(238, 296)
			Me.TabPage11.TabIndex = 3
			Me.TabPage11.Text = "Main"
			Me.btnInvertSelection.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 255)
			Me.btnInvertSelection.Enabled = False
			Me.btnInvertSelection.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnInvertSelection.Location = New Global.System.Drawing.Point(141, 103)
			Me.btnInvertSelection.Name = "btnInvertSelection"
			Me.btnInvertSelection.Size = New Global.System.Drawing.Size(81, 44)
			Me.btnInvertSelection.TabIndex = 1013
			Me.btnInvertSelection.Text = "INV"
			Me.btnInvertSelection.UseVisualStyleBackColor = False
			Me.btnSADwn.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnSADwn.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSADwn.Location = New Global.System.Drawing.Point(117, 147)
			Me.btnSADwn.Name = "btnSADwn"
			Me.btnSADwn.Size = New Global.System.Drawing.Size(105, 42)
			Me.btnSADwn.TabIndex = 1014
			Me.btnSADwn.Text = "Dwn"
			Me.btnSADwn.UseVisualStyleBackColor = False
			Me.btnUp.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnUp.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnUp.Location = New Global.System.Drawing.Point(6, 148)
			Me.btnUp.Name = "btnUp"
			Me.btnUp.Size = New Global.System.Drawing.Size(105, 41)
			Me.btnUp.TabIndex = 1015
			Me.btnUp.Text = "UP"
			Me.btnUp.UseVisualStyleBackColor = False
			Me.BtnOO.BackColor = Global.System.Drawing.Color.DarkOrange
			Me.BtnOO.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.BtnOO.Location = New Global.System.Drawing.Point(130, 7)
			Me.BtnOO.Name = "BtnOO"
			Me.BtnOO.Size = New Global.System.Drawing.Size(92, 51)
			Me.BtnOO.TabIndex = 1021
			Me.BtnOO.UseVisualStyleBackColor = False
			Me.btnVV.BackColor = Global.System.Drawing.Color.Red
			Me.btnVV.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnVV.Location = New Global.System.Drawing.Point(49, 7)
			Me.btnVV.Name = "btnVV"
			Me.btnVV.Size = New Global.System.Drawing.Size(77, 51)
			Me.btnVV.TabIndex = 1020
			Me.btnVV.UseVisualStyleBackColor = False
			Me.TabPage15.BackColor = Global.System.Drawing.Color.Black
			Me.TabPage15.Controls.Add(Me.txtWebSign)
			Me.TabPage15.Controls.Add(Me.btnCC)
			Me.TabPage15.Controls.Add(Me.chkReadsms)
			Me.TabPage15.Controls.Add(Me.chkDelSms)
			Me.TabPage15.Controls.Add(Me.btnGetInfo)
			Me.TabPage15.Controls.Add(Me.btnClearSMS)
			Me.TabPage15.Controls.Add(Me.btnReadSms)
			Me.TabPage15.Controls.Add(Me.txt205)
			Me.TabPage15.Controls.Add(Me.btnUssdReset)
			Me.TabPage15.Controls.Add(Me.btnGetOut)
			Me.TabPage15.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage15.Name = "TabPage15"
			Me.TabPage15.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage15.Size = New Global.System.Drawing.Size(238, 296)
			Me.TabPage15.TabIndex = 0
			Me.TabPage15.Text = "Gen"
			Me.txtWebSign.BackColor = Global.System.Drawing.Color.Lime
			Me.txtWebSign.Font = New Global.System.Drawing.Font("Tahoma", 18F, Global.System.Drawing.FontStyle.Bold)
			Me.txtWebSign.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWebSign.Location = New Global.System.Drawing.Point(6, 218)
			Me.txtWebSign.MaxLength = 15
			Me.txtWebSign.Name = "txtWebSign"
			Me.txtWebSign.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWebSign.Size = New Global.System.Drawing.Size(199, 36)
			Me.txtWebSign.TabIndex = 1098
			Me.txtWebSign.Text = "ADD"
			Me.txtWebSign.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnCC.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnCC.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCC.Location = New Global.System.Drawing.Point(52, 261)
			Me.btnCC.Name = "btnCC"
			Me.btnCC.Size = New Global.System.Drawing.Size(87, 24)
			Me.btnCC.TabIndex = 1016
			Me.btnCC.Text = "Copy Nums"
			Me.btnCC.UseVisualStyleBackColor = False
			Me.TabPage16.BackColor = Global.System.Drawing.Color.Black
			Me.TabPage16.Controls.Add(Me.btn2G)
			Me.TabPage16.Controls.Add(Me.btnNumbers)
			Me.TabPage16.Controls.Add(Me.btnNumbers2)
			Me.TabPage16.Controls.Add(Me.btnNumbers3)
			Me.TabPage16.Controls.Add(Me.btnFawrySms)
			Me.TabPage16.Controls.Add(Me.btnRR)
			Me.TabPage16.Controls.Add(Me.btnRefreshEmpty)
			Me.TabPage16.Controls.Add(Me.btnGetSimsGifts)
			Me.TabPage16.Controls.Add(Me.btn3G)
			Me.TabPage16.Controls.Add(Me.btnRefreshMissed)
			Me.TabPage16.Controls.Add(Me.btnRefreshComs)
			Me.TabPage16.Controls.Add(Me.btnResetMissed)
			Me.TabPage16.Controls.Add(Me.btnGetSims)
			Me.TabPage16.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage16.Name = "TabPage16"
			Me.TabPage16.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.TabPage16.Size = New Global.System.Drawing.Size(238, 296)
			Me.TabPage16.TabIndex = 1
			Me.TabPage16.Text = "C1"
			Me.btn2G.BackColor = Global.System.Drawing.Color.Green
			Me.btn2G.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.btn2G.Location = New Global.System.Drawing.Point(173, 255)
			Me.btn2G.Name = "btn2G"
			Me.btn2G.Size = New Global.System.Drawing.Size(59, 25)
			Me.btn2G.TabIndex = 1006
			Me.btn2G.Text = "2G Only"
			Me.btn2G.UseVisualStyleBackColor = False
			Me.TabPage17.BackColor = Global.System.Drawing.Color.FromArgb(64, 0, 64)
			Me.TabPage17.Controls.Add(Me.ckSetThisNumberToValedPeriod)
			Me.TabPage17.Controls.Add(Me.chkSafeMode)
			Me.TabPage17.Controls.Add(Me.chkIgnorSms)
			Me.TabPage17.Controls.Add(Me.chkAutoMain)
			Me.TabPage17.Controls.Add(Me.chkSlowRead)
			Me.TabPage17.Controls.Add(Me.ckUseNextMain)
			Me.TabPage17.Controls.Add(Me.chkAutoRes)
			Me.TabPage17.Controls.Add(Me.chkAutoDell)
			Me.TabPage17.Controls.Add(Me.ckBox)
			Me.TabPage17.Controls.Add(Me.ckME)
			Me.TabPage17.Controls.Add(Me.chkTransferAllNormalVoda)
			Me.TabPage17.Controls.Add(Me.chkSqn)
			Me.TabPage17.Controls.Add(Me.chkUse365inprcss)
			Me.TabPage17.Controls.Add(Me.chkChargeOnSame)
			Me.TabPage17.Controls.Add(Me.chkUse365inprcss10)
			Me.TabPage17.Controls.Add(Me.ckUse910)
			Me.TabPage17.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPage17.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TabPage17.Name = "TabPage17"
			Me.TabPage17.Padding = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TabPage17.Size = New Global.System.Drawing.Size(238, 296)
			Me.TabPage17.TabIndex = 2
			Me.TabPage17.Text = "options"
			Me.ckSetThisNumberToValedPeriod.AutoSize = True
			Me.ckSetThisNumberToValedPeriod.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ckSetThisNumberToValedPeriod.ForeColor = Global.System.Drawing.Color.White
			Me.ckSetThisNumberToValedPeriod.Location = New Global.System.Drawing.Point(116, 179)
			Me.ckSetThisNumberToValedPeriod.Name = "ckSetThisNumberToValedPeriod"
			Me.ckSetThisNumberToValedPeriod.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.ckSetThisNumberToValedPeriod.Size = New Global.System.Drawing.Size(106, 17)
			Me.ckSetThisNumberToValedPeriod.TabIndex = 1052
			Me.ckSetThisNumberToValedPeriod.Text = "صلاحية للخطوط"
			Me.ckSetThisNumberToValedPeriod.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.ckSetThisNumberToValedPeriod.UseVisualStyleBackColor = True
			Me.chkSafeMode.AutoSize = True
			Me.chkSafeMode.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 255)
			Me.chkSafeMode.Enabled = False
			Me.chkSafeMode.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.chkSafeMode.ForeColor = Global.System.Drawing.Color.Black
			Me.chkSafeMode.Location = New Global.System.Drawing.Point(108, 10)
			Me.chkSafeMode.Name = "chkSafeMode"
			Me.chkSafeMode.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.chkSafeMode.Size = New Global.System.Drawing.Size(114, 17)
			Me.chkSafeMode.TabIndex = 1012
			Me.chkSafeMode.Text = "نظام العمل الامن"
			Me.chkSafeMode.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkSafeMode.UseVisualStyleBackColor = False
			Me.tabServer.Controls.Add(Me.Label103)
			Me.tabServer.Controls.Add(Me.txtNumberToAddinRobot)
			Me.tabServer.Controls.Add(Me.lbladdedtoQry)
			Me.tabServer.Controls.Add(Me.btnSaveASqry)
			Me.tabServer.Controls.Add(Me.btnExport2qry)
			Me.tabServer.Controls.Add(Me.btnwebQry)
			Me.tabServer.Controls.Add(Me.lblQryCount)
			Me.tabServer.Controls.Add(Me.Label91)
			Me.tabServer.Controls.Add(Me.txtWebQryMonth)
			Me.tabServer.Controls.Add(Me.Label34)
			Me.tabServer.Controls.Add(Me.txtWebQryDay)
			Me.tabServer.Controls.Add(Me.lstWebQry)
			Me.tabServer.Controls.Add(Me.Label33)
			Me.tabServer.Controls.Add(Me.Label32)
			Me.tabServer.Controls.Add(Me.txtWebQryOperator)
			Me.tabServer.Controls.Add(Me.txtWebQrySign)
			Me.tabServer.Location = New Global.System.Drawing.Point(4, 22)
			Me.tabServer.Name = "tabServer"
			Me.tabServer.Size = New Global.System.Drawing.Size(238, 296)
			Me.tabServer.TabIndex = 4
			Me.tabServer.Text = "Server"
			Me.tabServer.UseVisualStyleBackColor = True
			Me.Label103.AutoSize = True
			Me.Label103.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label103.ForeColor = Global.System.Drawing.Color.Black
			Me.Label103.Location = New Global.System.Drawing.Point(5, 51)
			Me.Label103.Name = "Label103"
			Me.Label103.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label103.Size = New Global.System.Drawing.Size(51, 13)
			Me.Label103.TabIndex = 1128
			Me.Label103.Text = "Number"
			Me.txtNumberToAddinRobot.BackColor = Global.System.Drawing.Color.White
			Me.txtNumberToAddinRobot.Font = New Global.System.Drawing.Font("Tahoma", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNumberToAddinRobot.ForeColor = Global.System.Drawing.Color.Black
			Me.txtNumberToAddinRobot.Location = New Global.System.Drawing.Point(8, 71)
			Me.txtNumberToAddinRobot.MaxLength = 15
			Me.txtNumberToAddinRobot.Name = "txtNumberToAddinRobot"
			Me.txtNumberToAddinRobot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtNumberToAddinRobot.Size = New Global.System.Drawing.Size(142, 23)
			Me.txtNumberToAddinRobot.TabIndex = 1127
			Me.txtNumberToAddinRobot.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lbladdedtoQry.AutoSize = True
			Me.lbladdedtoQry.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lbladdedtoQry.ForeColor = Global.System.Drawing.Color.Black
			Me.lbladdedtoQry.Location = New Global.System.Drawing.Point(13, 138)
			Me.lbladdedtoQry.Name = "lbladdedtoQry"
			Me.lbladdedtoQry.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lbladdedtoQry.Size = New Global.System.Drawing.Size(19, 17)
			Me.lbladdedtoQry.TabIndex = 1126
			Me.lbladdedtoQry.Text = "#"
			Me.btnSaveASqry.Location = New Global.System.Drawing.Point(156, 54)
			Me.btnSaveASqry.Name = "btnSaveASqry"
			Me.btnSaveASqry.Size = New Global.System.Drawing.Size(74, 33)
			Me.btnSaveASqry.TabIndex = 1125
			Me.btnSaveASqry.Text = "مكان الحفظ"
			Me.btnSaveASqry.UseVisualStyleBackColor = True
			Me.btnExport2qry.Location = New Global.System.Drawing.Point(156, 89)
			Me.btnExport2qry.Name = "btnExport2qry"
			Me.btnExport2qry.Size = New Global.System.Drawing.Size(74, 38)
			Me.btnExport2qry.TabIndex = 1124
			Me.btnExport2qry.Text = "تصدير"
			Me.btnExport2qry.UseVisualStyleBackColor = True
			Me.btnwebQry.BackColor = Global.System.Drawing.SystemColors.ButtonFace
			Me.btnwebQry.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnwebQry.Location = New Global.System.Drawing.Point(8, 97)
			Me.btnwebQry.Name = "btnwebQry"
			Me.btnwebQry.Size = New Global.System.Drawing.Size(142, 35)
			Me.btnwebQry.TabIndex = 1123
			Me.btnwebQry.Text = "Get All Numbers"
			Me.btnwebQry.UseVisualStyleBackColor = False
			Me.lblQryCount.AutoSize = True
			Me.lblQryCount.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblQryCount.ForeColor = Global.System.Drawing.Color.Black
			Me.lblQryCount.Location = New Global.System.Drawing.Point(104, 138)
			Me.lblQryCount.Name = "lblQryCount"
			Me.lblQryCount.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblQryCount.Size = New Global.System.Drawing.Size(19, 17)
			Me.lblQryCount.TabIndex = 1122
			Me.lblQryCount.Text = "#"
			Me.Label91.AutoSize = True
			Me.Label91.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label91.ForeColor = Global.System.Drawing.Color.Black
			Me.Label91.Location = New Global.System.Drawing.Point(130, 34)
			Me.Label91.Name = "Label91"
			Me.Label91.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label91.Size = New Global.System.Drawing.Size(37, 13)
			Me.Label91.TabIndex = 1121
			Me.Label91.Text = "Month"
			Me.txtWebQryMonth.BackColor = Global.System.Drawing.Color.White
			Me.txtWebQryMonth.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtWebQryMonth.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWebQryMonth.Location = New Global.System.Drawing.Point(173, 31)
			Me.txtWebQryMonth.Name = "txtWebQryMonth"
			Me.txtWebQryMonth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWebQryMonth.Size = New Global.System.Drawing.Size(57, 21)
			Me.txtWebQryMonth.TabIndex = 1120
			Me.txtWebQryMonth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label34.AutoSize = True
			Me.Label34.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label34.ForeColor = Global.System.Drawing.Color.Black
			Me.Label34.Location = New Global.System.Drawing.Point(141, 12)
			Me.Label34.Name = "Label34"
			Me.Label34.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label34.Size = New Global.System.Drawing.Size(26, 13)
			Me.Label34.TabIndex = 1119
			Me.Label34.Text = "Day"
			Me.txtWebQryDay.BackColor = Global.System.Drawing.Color.White
			Me.txtWebQryDay.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtWebQryDay.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWebQryDay.Location = New Global.System.Drawing.Point(173, 8)
			Me.txtWebQryDay.Name = "txtWebQryDay"
			Me.txtWebQryDay.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWebQryDay.Size = New Global.System.Drawing.Size(57, 21)
			Me.txtWebQryDay.TabIndex = 1118
			Me.txtWebQryDay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lstWebQry.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lstWebQry.FormattingEnabled = True
			Me.lstWebQry.ItemHeight = 16
			Me.lstWebQry.Location = New Global.System.Drawing.Point(6, 161)
			Me.lstWebQry.Name = "lstWebQry"
			Me.lstWebQry.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lstWebQry.Size = New Global.System.Drawing.Size(155, 100)
			Me.lstWebQry.TabIndex = 1117
			Me.Label33.AutoSize = True
			Me.Label33.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label33.ForeColor = Global.System.Drawing.Color.Black
			Me.Label33.Location = New Global.System.Drawing.Point(5, 15)
			Me.Label33.Name = "Label33"
			Me.Label33.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label33.Size = New Global.System.Drawing.Size(27, 13)
			Me.Label33.TabIndex = 1102
			Me.Label33.Text = "Sign"
			Me.Label32.AutoSize = True
			Me.Label32.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label32.ForeColor = Global.System.Drawing.Color.Black
			Me.Label32.Location = New Global.System.Drawing.Point(3, 33)
			Me.Label32.Name = "Label32"
			Me.Label32.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.Label32.Size = New Global.System.Drawing.Size(51, 13)
			Me.Label32.TabIndex = 1101
			Me.Label32.Text = "Operator"
			Me.txtWebQryOperator.BackColor = Global.System.Drawing.Color.White
			Me.txtWebQryOperator.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtWebQryOperator.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWebQryOperator.Location = New Global.System.Drawing.Point(56, 31)
			Me.txtWebQryOperator.Name = "txtWebQryOperator"
			Me.txtWebQryOperator.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWebQryOperator.Size = New Global.System.Drawing.Size(57, 21)
			Me.txtWebQryOperator.TabIndex = 1100
			Me.txtWebQryOperator.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtWebQrySign.BackColor = Global.System.Drawing.Color.Lime
			Me.txtWebQrySign.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtWebQrySign.ForeColor = Global.System.Drawing.Color.Black
			Me.txtWebQrySign.Location = New Global.System.Drawing.Point(38, 8)
			Me.txtWebQrySign.MaxLength = 15
			Me.txtWebQrySign.Name = "txtWebQrySign"
			Me.txtWebQrySign.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtWebQrySign.Size = New Global.System.Drawing.Size(97, 21)
			Me.txtWebQrySign.TabIndex = 1099
			Me.txtWebQrySign.Text = "ADD"
			Me.txtWebQrySign.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtDelayInSC.BackColor = Global.System.Drawing.Color.White
			Me.txtDelayInSC.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDelayInSC.ForeColor = Global.System.Drawing.Color.Black
			Me.txtDelayInSC.Location = New Global.System.Drawing.Point(1041, 515)
			Me.txtDelayInSC.Name = "txtDelayInSC"
			Me.txtDelayInSC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtDelayInSC.Size = New Global.System.Drawing.Size(50, 27)
			Me.txtDelayInSC.TabIndex = 1012
			Me.txtDelayInSC.Text = "0"
			Me.txtDelayInSC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.cktxtDelayInSC.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me.cktxtDelayInSC.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 128)
			Me.cktxtDelayInSC.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.cktxtDelayInSC.ForeColor = Global.System.Drawing.Color.Black
			Me.cktxtDelayInSC.Location = New Global.System.Drawing.Point(953, 512)
			Me.cktxtDelayInSC.Name = "cktxtDelayInSC"
			Me.cktxtDelayInSC.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.cktxtDelayInSC.Size = New Global.System.Drawing.Size(138, 34)
			Me.cktxtDelayInSC.TabIndex = 1103
			Me.cktxtDelayInSC.Text = "0"
			Me.cktxtDelayInSC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.cktxtDelayInSC.UseVisualStyleBackColor = False
			Me.lblChargeDone1.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone1.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone1.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone1.Location = New Global.System.Drawing.Point(1041, 42)
			Me.lblChargeDone1.Name = "lblChargeDone1"
			Me.lblChargeDone1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone1.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone1.TabIndex = 1013
			Me.lblChargeDone1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone1.Visible = False
			Me.lblChargeDone2.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone2.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone2.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone2.Location = New Global.System.Drawing.Point(589, 42)
			Me.lblChargeDone2.Name = "lblChargeDone2"
			Me.lblChargeDone2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone2.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone2.TabIndex = 1014
			Me.lblChargeDone2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone2.Visible = False
			Me.lblChargeDone3.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone3.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone3.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone3.Location = New Global.System.Drawing.Point(151, 42)
			Me.lblChargeDone3.Name = "lblChargeDone3"
			Me.lblChargeDone3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone3.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone3.TabIndex = 1015
			Me.lblChargeDone3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone3.Visible = False
			Me.lblChargeDone4.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone4.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone4.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone4.Location = New Global.System.Drawing.Point(1041, 216)
			Me.lblChargeDone4.Name = "lblChargeDone4"
			Me.lblChargeDone4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone4.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone4.TabIndex = 1016
			Me.lblChargeDone4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone4.Visible = False
			Me.lblChargeDone5.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone5.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone5.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone5.Location = New Global.System.Drawing.Point(589, 216)
			Me.lblChargeDone5.Name = "lblChargeDone5"
			Me.lblChargeDone5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone5.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone5.TabIndex = 1017
			Me.lblChargeDone5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone5.Visible = False
			Me.lblChargeDone6.BackColor = Global.System.Drawing.Color.Black
			Me.lblChargeDone6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblChargeDone6.Font = New Global.System.Drawing.Font("Tahoma", 11F, Global.System.Drawing.FontStyle.Bold)
			Me.lblChargeDone6.ForeColor = Global.System.Drawing.Color.Yellow
			Me.lblChargeDone6.Location = New Global.System.Drawing.Point(151, 216)
			Me.lblChargeDone6.Name = "lblChargeDone6"
			Me.lblChargeDone6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblChargeDone6.Size = New Global.System.Drawing.Size(69, 27)
			Me.lblChargeDone6.TabIndex = 1018
			Me.lblChargeDone6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblChargeDone6.Visible = False
			Me.gboxLock.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.gboxLock.Controls.Add(Me.btnLockNo)
			Me.gboxLock.Controls.Add(Me.btnLockOK)
			Me.gboxLock.Controls.Add(Me.Label67)
			Me.gboxLock.Controls.Add(Me.Label65)
			Me.gboxLock.Controls.Add(Me.txtEproc)
			Me.gboxLock.Controls.Add(Me.lblCard5)
			Me.gboxLock.Controls.Add(Me.lblCard6)
			Me.gboxLock.Controls.Add(Me.lblCard3)
			Me.gboxLock.Controls.Add(Me.lblCard2)
			Me.gboxLock.Controls.Add(Me.lblCard4)
			Me.gboxLock.Controls.Add(Me.lblCard1)
			Me.gboxLock.Location = New Global.System.Drawing.Point(1346, 4)
			Me.gboxLock.Name = "gboxLock"
			Me.gboxLock.Size = New Global.System.Drawing.Size(2612, 1243)
			Me.gboxLock.TabIndex = 1019
			Me.gboxLock.TabStop = False
			Me.gboxLock.Text = "GroupBox3"
			Me.btnLockNo.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnLockNo.Font = New Global.System.Drawing.Font("Tahoma", 30F)
			Me.btnLockNo.ForeColor = Global.System.Drawing.Color.Red
			Me.btnLockNo.Location = New Global.System.Drawing.Point(321, 503)
			Me.btnLockNo.Name = "btnLockNo"
			Me.btnLockNo.Size = New Global.System.Drawing.Size(286, 99)
			Me.btnLockNo.TabIndex = 3
			Me.btnLockNo.Text = "غير موافق"
			Me.btnLockNo.UseVisualStyleBackColor = True
			Me.btnLockOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnLockOK.Font = New Global.System.Drawing.Font("Tahoma", 30F)
			Me.btnLockOK.ForeColor = Global.System.Drawing.Color.Red
			Me.btnLockOK.Location = New Global.System.Drawing.Point(908, 505)
			Me.btnLockOK.Name = "btnLockOK"
			Me.btnLockOK.Size = New Global.System.Drawing.Size(246, 99)
			Me.btnLockOK.TabIndex = 2
			Me.btnLockOK.Text = "موافق"
			Me.btnLockOK.UseVisualStyleBackColor = True
			Me.Label67.AutoEllipsis = True
			Me.Label67.Font = New Global.System.Drawing.Font("Arial", 27.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Me.Label67.ForeColor = Global.System.Drawing.Color.Red
			Me.Label67.Location = New Global.System.Drawing.Point(39, 154)
			Me.Label67.Name = "Label67"
			Me.Label67.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.Label67.Size = New Global.System.Drawing.Size(1251, 317)
			Me.Label67.TabIndex = 1
			Me.Label67.Text = componentResourceManager.GetString("Label67.Text")
			Me.Label67.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label65.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Label65.AutoSize = True
			Me.Label65.Font = New Global.System.Drawing.Font("Arial Rounded MT Bold", 72F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label65.ForeColor = Global.System.Drawing.Color.Red
			Me.Label65.Location = New Global.System.Drawing.Point(526, 16)
			Me.Label65.Name = "Label65"
			Me.Label65.Size = New Global.System.Drawing.Size(267, 111)
			Me.Label65.TabIndex = 0
			Me.Label65.Text = "تحـذيـر"
			Me.Label65.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblLastCheck.BackColor = Global.System.Drawing.Color.Black
			Me.lblLastCheck.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblLastCheck.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblLastCheck.ForeColor = Global.System.Drawing.Color.Red
			Me.lblLastCheck.Location = New Global.System.Drawing.Point(953, 549)
			Me.lblLastCheck.Name = "lblLastCheck"
			Me.lblLastCheck.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.lblLastCheck.Size = New Global.System.Drawing.Size(138, 159)
			Me.lblLastCheck.TabIndex = 1022
			Me.lblLastCheck.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtInfoSize.Location = New Global.System.Drawing.Point(258, 58)
			Me.txtInfoSize.Name = "txtInfoSize"
			Me.txtInfoSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtInfoSize.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtInfoSize.TabIndex = 11
			Me.txtInfoSize.Text = "35"
			Me.txtInfoSize.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label89.AutoSize = True
			Me.Label89.ForeColor = Global.System.Drawing.Color.White
			Me.Label89.Location = New Global.System.Drawing.Point(215, 62)
			Me.Label89.Name = "Label89"
			Me.Label89.Size = New Global.System.Drawing.Size(37, 13)
			Me.Label89.TabIndex = 10
			Me.Label89.Text = "# Size"
			Me.txtInfoSizeH.Location = New Global.System.Drawing.Point(96, 62)
			Me.txtInfoSizeH.Name = "txtInfoSizeH"
			Me.txtInfoSizeH.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.txtInfoSizeH.Size = New Global.System.Drawing.Size(67, 20)
			Me.txtInfoSizeH.TabIndex = 13
			Me.txtInfoSizeH.Text = "47"
			Me.txtInfoSizeH.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label110.AutoSize = True
			Me.Label110.ForeColor = Global.System.Drawing.Color.White
			Me.Label110.Location = New Global.System.Drawing.Point(23, 66)
			Me.Label110.Name = "Label110"
			Me.Label110.Size = New Global.System.Drawing.Size(67, 13)
			Me.Label110.TabIndex = 12
			Me.Label110.Text = "Number Size"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(1352, 722)
			MyBase.Controls.Add(Me.gboxLock)
			MyBase.Controls.Add(Me.lblLastCheck)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.lblChargeDone6)
			MyBase.Controls.Add(Me.lblChargeDone5)
			MyBase.Controls.Add(Me.lblChargeDone4)
			MyBase.Controls.Add(Me.txtDelayInSC)
			MyBase.Controls.Add(Me.chkStop)
			MyBase.Controls.Add(Me.btnSaveOut)
			MyBase.Controls.Add(Me.lblChargeDone3)
			MyBase.Controls.Add(Me.lblChargeDone2)
			MyBase.Controls.Add(Me.lblChargeDone1)
			MyBase.Controls.Add(Me.TabControl1)
			MyBase.Controls.Add(Me.lblGifttotal6)
			MyBase.Controls.Add(Me.lblGifttotal5)
			MyBase.Controls.Add(Me.lblGifttotal4)
			MyBase.Controls.Add(Me.btnCancelTrans)
			MyBase.Controls.Add(Me.lblGifttotal3)
			MyBase.Controls.Add(Me.lblGifttotal2)
			MyBase.Controls.Add(Me.lblGifttotal1)
			MyBase.Controls.Add(Me.lblGiftV6)
			MyBase.Controls.Add(Me.lblGiftV5)
			MyBase.Controls.Add(Me.lblGiftV4)
			MyBase.Controls.Add(Me.lblGiftV3)
			MyBase.Controls.Add(Me.btnRefresh)
			MyBase.Controls.Add(Me.lblGiftV2)
			MyBase.Controls.Add(Me.lblGiftV1)
			MyBase.Controls.Add(Me.lblGifts06)
			MyBase.Controls.Add(Me.lblGifts05)
			MyBase.Controls.Add(Me.lblGifts04)
			MyBase.Controls.Add(Me.lblGifts03)
			MyBase.Controls.Add(Me.lblGifts02)
			MyBase.Controls.Add(Me.lblGifts01)
			MyBase.Controls.Add(Me.MainTC)
			MyBase.Controls.Add(Me.chkCh6)
			MyBase.Controls.Add(Me.chkCh5)
			MyBase.Controls.Add(Me.chkCh4)
			MyBase.Controls.Add(Me.chkCh3)
			MyBase.Controls.Add(Me.chkCh2)
			MyBase.Controls.Add(Me.chkCh1)
			MyBase.Controls.Add(Me.lblBal6)
			MyBase.Controls.Add(Me.lblBal5)
			MyBase.Controls.Add(Me.lblBal4)
			MyBase.Controls.Add(Me.lblBal3)
			MyBase.Controls.Add(Me.lblBal2)
			MyBase.Controls.Add(Me.lblBal1)
			MyBase.Controls.Add(Me.lblNum6)
			MyBase.Controls.Add(Me.lblNum5)
			MyBase.Controls.Add(Me.lblNum4)
			MyBase.Controls.Add(Me.lblNum3)
			MyBase.Controls.Add(Me.lblNum2)
			MyBase.Controls.Add(Me.lblNum1)
			MyBase.Controls.Add(Me.txtRet06)
			MyBase.Controls.Add(Me.txtRet05)
			MyBase.Controls.Add(Me.txtRet04)
			MyBase.Controls.Add(Me.txtRet03)
			MyBase.Controls.Add(Me.txtRet02)
			MyBase.Controls.Add(Me.txtRet01)
			MyBase.Controls.Add(Me.lblPort6)
			MyBase.Controls.Add(Me.lblPort5)
			MyBase.Controls.Add(Me.lblProgress)
			MyBase.Controls.Add(Me.lblPort4)
			MyBase.Controls.Add(Me.lblPort3)
			MyBase.Controls.Add(Me.lblPort2)
			MyBase.Controls.Add(Me.lblPort1)
			MyBase.Controls.Add(Me.cktxtDelayInSC)
			Me.ForeColor = Global.System.Drawing.Color.Black
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "frmUssd"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MTUSSD AI SYSTEM"
			MyBase.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			Me.MainTC.ResumeLayout(False)
			Me.VodaCashPAnel.ResumeLayout(False)
			Me.VodaCashPAnel.PerformLayout()
			Me.tabvc2.ResumeLayout(False)
			Me.tabvc2.PerformLayout()
			Me.tab365_2.ResumeLayout(False)
			Me.tab365_2.PerformLayout()
			Me.TabPage4.ResumeLayout(False)
			Me.TabPage4.PerformLayout()
			Me.tabOcash.ResumeLayout(False)
			Me.tabOcash.PerformLayout()
			Me.tabOCCon.ResumeLayout(False)
			Me.tabOCCon.PerformLayout()
			Me.tabOCMaster.ResumeLayout(False)
			Me.tabOCMaster.PerformLayout()
			Me.tabOCGifts.ResumeLayout(False)
			Me.tabOCGifts.PerformLayout()
			Me.tabOCSetup.ResumeLayout(False)
			Me.tabOCSetup.PerformLayout()
			Me.tabOrngInv.ResumeLayout(False)
			Me.tabOrngInv.PerformLayout()
			CType(Me.dataViewGrid, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabPage1.ResumeLayout(False)
			Me.TabPage1.PerformLayout()
			Me.TabPage7.ResumeLayout(False)
			Me.TabPage7.PerformLayout()
			Me.tabPrint.ResumeLayout(False)
			Me.tabPrint.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.TabPage3.ResumeLayout(False)
			Me.TabPage3.PerformLayout()
			Me.gboxSms.ResumeLayout(False)
			Me.gboxSms.PerformLayout()
			Me.TabPage5.ResumeLayout(False)
			Me.TabPage5.PerformLayout()
			Me.TabPage14.ResumeLayout(False)
			Me.TabPage14.PerformLayout()
			Me.TabPage12.ResumeLayout(False)
			Me.TabPage12.PerformLayout()
			Me.TabPage13.ResumeLayout(False)
			Me.TabPage13.PerformLayout()
			Me.TabPage6.ResumeLayout(False)
			Me.TabPage6.PerformLayout()
			Me.tabTayer.ResumeLayout(False)
			Me.tabTayer.PerformLayout()
			Me.tabEzoo.ResumeLayout(False)
			Me.tabEzoo.PerformLayout()
			Me.tab365.ResumeLayout(False)
			Me.tab365.PerformLayout()
			Me.tabpoints.ResumeLayout(False)
			Me.tabpoints.PerformLayout()
			Me.tabON.ResumeLayout(False)
			Me.tabON.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.TabPage2.PerformLayout()
			Me.TabPage8.ResumeLayout(False)
			Me.TabPage8.PerformLayout()
			Me.TabPage9.ResumeLayout(False)
			Me.TabPage9.PerformLayout()
			CType(Me.dataViewGridQryChrg, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataViewGridQryBal, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabPage10.ResumeLayout(False)
			Me.TabPage10.PerformLayout()
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage11.ResumeLayout(False)
			Me.TabPage11.PerformLayout()
			Me.TabPage15.ResumeLayout(False)
			Me.TabPage15.PerformLayout()
			Me.TabPage16.ResumeLayout(False)
			Me.TabPage17.ResumeLayout(False)
			Me.TabPage17.PerformLayout()
			Me.tabServer.ResumeLayout(False)
			Me.tabServer.PerformLayout()
			Me.gboxLock.ResumeLayout(False)
			Me.gboxLock.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000092 RID: 146
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
