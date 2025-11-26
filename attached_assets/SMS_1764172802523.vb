Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace MTUssd.SMS.Encoder
	' Token: 0x02000015 RID: 21
	Public Class SMS
		' Token: 0x06000ACA RID: 2762 RVA: 0x000061DE File Offset: 0x000043DE
		Public Sub New()
			Me.TP_MTI = 1
			Me.TP_RD = 0
			Me.TP_VPF = 16
		End Sub

		' Token: 0x170003E6 RID: 998
		' (get) Token: 0x06000ACB RID: 2763 RVA: 0x000C6B14 File Offset: 0x000C4D14
		' (set) Token: 0x06000ACC RID: 2764 RVA: 0x000C6B2C File Offset: 0x000C4D2C
		Public Property ServiceCenterNumber As String
			Get
				Return Me.SC_Number
			End Get
			Set(value As String)
				Dim flag As Boolean = Strings.InStr(value, "+", CompareMethod.Binary) <> 0
				If flag Then
					Me.SC_Number = "91"
				Else
					Me.SC_Number = "81"
				End If
				value = Strings.Mid(value, 2)
				Dim flag2 As Boolean = value.Length Mod 2 = 1
				If flag2 Then
					value += "F"
				End If
				Dim length As Integer = value.Length
				For i As Integer = 1 To length Step 2
					Dim ptr As String = Me.SC_Number
					Dim str As String = ptr
					Dim text As String = Strings.Mid(value, i, 2)
					Me.SC_Number = str + SMS.Swap(text)
				Next
				Me.SC_Number = SMS.ByteToHex(CByte(Math.Round(CDbl((Me.SC_Number.Length - 2)) / 2.0 + 1.0))) + Me.SC_Number
			End Set
		End Property

		' Token: 0x170003E7 RID: 999
		' (get) Token: 0x06000ACD RID: 2765 RVA: 0x000C6C04 File Offset: 0x000C4E04
		' (set) Token: 0x06000ACE RID: 2766 RVA: 0x000061FD File Offset: 0x000043FD
		Public Property TP_Status_Report_Request As SMS.ENUM_TP_SRI
			Get
				Return CType(Me.TP_SRR, SMS.ENUM_TP_SRI)
			End Get
			Set(value As SMS.ENUM_TP_SRI)
				' The following expression was wrapped in a checked-expression
				Me.TP_SRR = CByte(value)
			End Set
		End Property

		' Token: 0x170003E8 RID: 1000
		' (get) Token: 0x06000ACF RID: 2767 RVA: 0x000C6C1C File Offset: 0x000C4E1C
		' (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00006208 File Offset: 0x00004408
		Public Property TP_Message_Reference As Integer
			Get
				Return Me.TP_MR
			End Get
			Set(value As Integer)
				Me.TP_MR = value
			End Set
		End Property

		' Token: 0x170003E9 RID: 1001
		' (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000C6C34 File Offset: 0x000C4E34
		' (set) Token: 0x06000AD2 RID: 2770 RVA: 0x000C6C4C File Offset: 0x000C4E4C
		Public Property TP_Destination_Address As String
			Get
				Return Me.TP_DA
			End Get
			Set(value As String)
				Me.TP_DA = ""
				Dim flag As Boolean = Strings.InStr(value, "+", CompareMethod.Binary) <> 0
				If flag Then
					Dim ptr As String = Me.TP_DA
					Me.TP_DA = ptr + "91"
				Else
					Dim ptr As String = Me.TP_DA
					Me.TP_DA = ptr + "81"
				End If
				value = value.Replace("+", "")
				Me.TP_DA = Strings.Format(value.Length, "X2") + Me.TP_DA
				Dim flag2 As Boolean = value.Length Mod 2 = 1
				If flag2 Then
					value += "F"
				End If
				Dim length As Integer = value.Length
				For i As Integer = 1 To length Step 2
					Dim ptr As String = Me.TP_DA
					Dim str As String = ptr
					Dim text As String = Strings.Mid(value, i, 2)
					Me.TP_DA = str + SMS.Swap(text)
				Next
			End Set
		End Property

		' Token: 0x170003EA RID: 1002
		' (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000C6D34 File Offset: 0x000C4F34
		' (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00006212 File Offset: 0x00004412
		Public Property TP_Data_Coding_Scheme As SMS.ENUM_TP_DCS
			Get
				Return CType(Me.TP_DCS, SMS.ENUM_TP_DCS)
			End Get
			Set(value As SMS.ENUM_TP_DCS)
				' The following expression was wrapped in a checked-expression
				Me.TP_DCS = CByte(value)
			End Set
		End Property

		' Token: 0x170003EB RID: 1003
		' (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000C6D4C File Offset: 0x000C4F4C
		' (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0000621D File Offset: 0x0000441D
		Public Property TP_Validity_Period As SMS.ENUM_TP_VALID_PERIOD
			Get
				Return CType(Me.TP_VP, SMS.ENUM_TP_VALID_PERIOD)
			End Get
			Set(value As SMS.ENUM_TP_VALID_PERIOD)
				' The following expression was wrapped in a checked-expression
				Me.TP_VP = CByte(value)
			End Set
		End Property

		' Token: 0x170003EC RID: 1004
		' (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000C6D64 File Offset: 0x000C4F64
		' (set) Token: 0x06000AD8 RID: 2776 RVA: 0x000C6D7C File Offset: 0x000C4F7C
		Public Overridable Property TP_User_Data As String
			Get
				Return Me.TP_UD
			End Get
			Set(value As String)
				Dim tp_DCS As Byte = Me.TP_DCS
				If tp_DCS <> 0 Then
					If tp_DCS <> 8 Then
						Me.TP_UD = value
					Else
						' The following expression was wrapped in a checked-expression
						Me.TP_UDL = value.Length * 2
						Me.TP_UD = SMS.EncodeUCS2(value)
					End If
				Else
					Me.TP_UDL = value.Length
					Me.TP_UD = SMS.Encode7Bit(value)
				End If
			End Set
		End Property

		' Token: 0x06000AD9 RID: 2777 RVA: 0x000C6DE0 File Offset: 0x000C4FE0
		Public Shared Function CheckForEncoding(Content As String) As SMS.ENUM_TP_DCS
			Dim length As Integer = Content.Length
			For i As Integer = 1 To length
				Dim flag As Boolean = Strings.Asc(Strings.Mid(Content, i, 1)) < 0
				If flag Then
					Return SMS.ENUM_TP_DCS.UCS2
				End If
			Next
			Return SMS.ENUM_TP_DCS.DefaultAlphabet
		End Function

		' Token: 0x06000ADA RID: 2778 RVA: 0x000C6E20 File Offset: 0x000C5020
		Public Overridable Function GetSMSPDUCode() As String
			Dim flag As Boolean = Me.TP_DCS = 0
			If flag Then
				Dim flag2 As Boolean = Me.TP_UD.Length > 280
				If flag2 Then
					Throw New Exception("User Data is TOO LONG for SMS")
				End If
			End If
			Dim flag3 As Boolean = Me.TP_DCS = 8
			If flag3 Then
				Dim flag4 As Boolean = Me.TP_UD.Length > 280
				If flag4 Then
					Throw New Exception("User Data is TOO LONG for SMS")
				End If
			End If
			Dim str As String = Me.SC_Number
			str += Me.FirstOctet()
			str += Strings.Format(Me.TP_MR, "X2")
			str += Me.TP_DA
			str += Strings.Format(Me.TP_PID, "X2")
			str += Strings.Format(Me.TP_DCS, "X2")
			str += Strings.Format(Me.TP_VP, "X2")
			str += Strings.Format(Me.TP_UDL, "X2")
			Return str + Me.TP_UD
		End Function

		' Token: 0x06000ADB RID: 2779 RVA: 0x000C6F54 File Offset: 0x000C5154
		Public Overridable Function FirstOctet() As String
			Return SMS.ByteToHex(Me.TP_MTI + Me.TP_VPF + Me.TP_SRR + Me.TP_UDHI)
		End Function

		' Token: 0x06000ADC RID: 2780 RVA: 0x000C6F8C File Offset: 0x000C518C
		Public Shared Function ByteToHex(aByte As Byte) As String
			Return Strings.Format(aByte, "X2")
		End Function

		' Token: 0x06000ADD RID: 2781 RVA: 0x000C6FB0 File Offset: 0x000C51B0
		Public Shared Function Encode7Bit(Content As String) As String
			Dim array As Char() = Content.ToCharArray()
			Dim text As String
			For Each c As Char In array
				text = SMS.CharTo7Bits(c) + text
			Next
			Dim flag As Boolean = text.Length Mod 8 <> 0
			If flag Then
				Dim num As Integer = 8 - text.Length Mod 8
				For j As Integer = 1 To num
					text = "0" + text
				Next
			End If
			Dim num2 As Integer = text.Length - 8
			Dim text2 As String
			For j As Integer = num2 To 0 Step -8
				text2 += SMS.BitsToHex(Strings.Mid(text, j + 1, 8))
			Next
			Return text2
		End Function

		' Token: 0x06000ADE RID: 2782 RVA: 0x000C67E8 File Offset: 0x000C49E8
		Public Shared Function BitsToHex(Bits As String) As String
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Bits.Length - 1
			Dim num2 As Integer
			For i As Integer = 0 To num
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				num2 = CInt(Math.Round(CDbl(num2) + Conversion.Val(Strings.Mid(Bits, i + 1, 1)) * Math.Pow(2.0, CDbl((7 - i)))))
			Next
			Return Strings.Format(num2, "X2")
		End Function

		' Token: 0x06000ADF RID: 2783 RVA: 0x000C6850 File Offset: 0x000C4A50
		Public Shared Function CharTo7Bits(c As Char) As String
			Dim flag As Boolean = Operators.CompareString(Conversions.ToString(c), "@", False) = 0
			Dim result As String
			If flag Then
				result = "0000000"
			Else
				Dim num As Integer = 0
				Dim text As String
				Do
					' The following expression was wrapped in a unchecked-expression
					Dim flag2 As Boolean = (CLng(Strings.Asc(c)) And CLng(Math.Round(Math.Pow(2.0, CDbl(num))))) > 0L
					If flag2 Then
						text = "1" + text
					Else
						text = "0" + text
					End If
					num += 1
				Loop While num <= 6
				result = text
			End If
			Return result
		End Function

		' Token: 0x06000AE0 RID: 2784 RVA: 0x000C706C File Offset: 0x000C526C
		Public Shared Function EncodeUCS2(Content As String) As String
			Dim length As Integer = Content.Length
			Dim text As String
			For i As Integer = 1 To length
				Dim num As Integer = Strings.AscW(Strings.Mid(Content, i, 4))
				Dim str As String = Strings.Format(num, "X4")
				text += str
			Next
			Return text
		End Function

		' Token: 0x06000AE1 RID: 2785 RVA: 0x000C70C0 File Offset: 0x000C52C0
		Public Shared Function Swap(ByRef TwoBitStr As String) As String
			Dim array As Char() = TwoBitStr.ToCharArray()
			Dim c As Char = array(0)
			array(0) = array(1)
			array(1) = c
			Return(Conversions.ToString(array(0)) + Conversions.ToString(array(1))).ToString()
		End Function

		' Token: 0x0400043F RID: 1087
		Protected SC_Number As String

		' Token: 0x04000440 RID: 1088
		Protected TP_MTI As Byte

		' Token: 0x04000441 RID: 1089
		Protected TP_RD As Byte

		' Token: 0x04000442 RID: 1090
		Protected TP_VPF As Byte

		' Token: 0x04000443 RID: 1091
		Protected TP_UDHI As Byte

		' Token: 0x04000444 RID: 1092
		Protected TP_SRR As Byte

		' Token: 0x04000445 RID: 1093
		Protected TP_MR As Integer

		' Token: 0x04000446 RID: 1094
		Protected TP_DA As String

		' Token: 0x04000447 RID: 1095
		Protected TP_PID As Byte

		' Token: 0x04000448 RID: 1096
		Protected TP_DCS As Byte

		' Token: 0x04000449 RID: 1097
		Protected TP_VP As Byte

		' Token: 0x0400044A RID: 1098
		Protected TP_UDL As Integer

		' Token: 0x0400044B RID: 1099
		Protected TP_UD As String

		' Token: 0x02000016 RID: 22
		Public Enum ENUM_TP_VPF
			' Token: 0x0400044D RID: 1101
			Relative_Format = 16
		End Enum

		' Token: 0x02000017 RID: 23
		Public Enum ENUM_TP_SRI
			' Token: 0x0400044F RID: 1103
			Request_SMS_Report = 32
			' Token: 0x04000450 RID: 1104
			No_SMS_Report = 0
		End Enum

		' Token: 0x02000018 RID: 24
		Public Enum ENUM_TP_DCS
			' Token: 0x04000452 RID: 1106
			DefaultAlphabet
			' Token: 0x04000453 RID: 1107
			UCS2 = 8
		End Enum

		' Token: 0x02000019 RID: 25
		Public Enum ENUM_TP_VALID_PERIOD
			' Token: 0x04000455 RID: 1109
			OneHour = 11
			' Token: 0x04000456 RID: 1110
			ThreeHours = 29
			' Token: 0x04000457 RID: 1111
			SixHours = 71
			' Token: 0x04000458 RID: 1112
			TwelveHours = 143
			' Token: 0x04000459 RID: 1113
			OneDay = 167
			' Token: 0x0400045A RID: 1114
			OneWeek = 196
			' Token: 0x0400045B RID: 1115
			Maximum = 255
		End Enum
	End Class
End Namespace
