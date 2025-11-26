Imports System
Imports Microsoft.VisualBasic

Namespace MTUssd.SMS.Encoder
	' Token: 0x0200001A RID: 26
	Public Class ConcatenatedShortMessage
		Inherits SMS

		' Token: 0x06000AE3 RID: 2787 RVA: 0x000C7104 File Offset: 0x000C5304
		Public Function GetEMSPDUCode() As String()
			Dim tp_DCS As Byte = Me.TP_DCS
			If tp_DCS <> 0 Then
				If tp_DCS = 8 Then
					' The following expression was wrapped in a unchecked-expression
					Me.TotalMessages = CInt((CLng(Math.Round(CDbl(Me.TP_UD.Length) / 4.0)) / 66L + If(-If(((CDbl(Me.TP_UD.Length) / 4.0 Mod 66.0 = 0.0) > False), 1L, 0L), 1L, 0L)))
				End If
			Else
				' The following expression was wrapped in a unchecked-expression
				Me.TotalMessages = Me.TP_UD.Length / 266 - If(-If(((Me.TP_UD.Length Mod 266 = 0) > False), 1, 0), 1, 0)
			End If
			Dim array As String() = New String(Me.TotalMessages + 1 - 1) {}
			Me.TP_UDHI = 64
			Dim num As Integer = CInt(Math.Round(CDbl((VBMath.Rnd(1F) * 65536F))))
			Dim totalMessages As Integer = Me.TotalMessages
			For i As Integer = 0 To totalMessages
				Dim tp_DCS2 As Byte = Me.TP_DCS
				Dim text As String
				If tp_DCS2 <> 0 Then
					If tp_DCS2 = 8 Then
						text = Strings.Mid(Me.TP_UD, i * 66 * 4 + 1, 264)
					End If
				Else
					text = Strings.Mid(Me.TP_UD, i * 133 * 2 + 1, 266)
				End If
				array(i) = Me.SC_Number
				Dim array2 As String() = array
				Dim num2 As Integer = i
				Dim ptr As String = array2(num2)
				array2(num2) = ptr + Me.FirstOctet()
				Dim array3 As String() = array
				Dim num3 As Integer = i
				ptr = array3(num3)
				array3(num3) = ptr + Strings.Format(Me.TP_MR, "X2")
				Dim array4 As String() = array
				Dim num4 As Integer = i
				ptr = array4(num4)
				array4(num4) = ptr + Me.TP_DA
				Dim array5 As String() = array
				Dim num5 As Integer = i
				ptr = array5(num5)
				array5(num5) = ptr + Strings.Format(Me.TP_PID, "X2")
				Dim array6 As String() = array
				Dim num6 As Integer = i
				ptr = array6(num6)
				array6(num6) = ptr + Strings.Format(Me.TP_DCS, "X2")
				Dim array7 As String() = array
				Dim num7 As Integer = i
				ptr = array7(num7)
				array7(num7) = ptr + Strings.Format(Me.TP_VP, "X2")
				Dim flag As Boolean = Me.TP_DCS = 8
				If flag Then
					' The following expression was wrapped in a unchecked-expression
					Me.TP_UDL = CInt(Math.Round(CDbl(text.Length) / 2.0 + 6.0 + 1.0))
				End If
				Dim flag2 As Boolean = Me.TP_DCS = 0
				If flag2 Then
					Me.TP_UDL = CInt((CDbl(((text.Length + 14) * 4)) / 7.0))
				End If
				Dim array8 As String() = array
				Dim num8 As Integer = i
				ptr = array8(num8)
				array8(num8) = ptr + Strings.Format(Me.TP_UDL, "X2")
				Dim array9 As String() = array
				Dim num9 As Integer = i
				ptr = array9(num9)
				array9(num9) = ptr + "060804"
				Dim array10 As String() = array
				Dim num10 As Integer = i
				ptr = array10(num10)
				array10(num10) = ptr + Strings.Format(num, "X4")
				Dim array11 As String() = array
				Dim num11 As Integer = i
				ptr = array11(num11)
				array11(num11) = ptr + Strings.Format(Me.TotalMessages + 1, "X2")
				Dim array12 As String() = array
				Dim num12 As Integer = i
				ptr = array12(num12)
				array12(num12) = ptr + Strings.Format(i + 1, "X2")
				Dim array13 As String() = array
				Dim num13 As Integer = i
				ptr = array13(num13)
				array13(num13) = ptr + text
			Next
			Return array
		End Function

		' Token: 0x06000AE4 RID: 2788 RVA: 0x000C6F54 File Offset: 0x000C5154
		Public Overrides Function FirstOctet() As String
			Return SMS.ByteToHex(Me.TP_MTI + Me.TP_VPF + Me.TP_SRR + Me.TP_UDHI)
		End Function

		' Token: 0x0400045C RID: 1116
		Private TotalMessages As Integer
	End Class
End Namespace
