Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace ConsoleApplication1
	Friend Class Program
		Shared Sub Main(ByVal args() As String)
			Dim list As New List(Of ReportData)()
			For i As Integer = 0 To 9
				list.Add(New ReportData() With {.Value1 = i, .Value2 = i, .Value3 = i})
			Next i

			Dim report As XtraReport = New XtraReport1() With {.DataSource = list}

			Dim SmtpHost As String = Nothing
			Dim SmtpPort As Integer = -1
			If String.IsNullOrEmpty(SmtpHost) OrElse SmtpPort = -1 Then
				System.Diagnostics.Debug.WriteLine("Please configure the SMTP server settings.")
				Return
			End If

			Dim SmtpUserName As String = "Enter_Sender_User_Name"
			Dim SmtpUserPassword As String = "Enter_Sender_Password"

			Using smtpClient = New SmtpClient(SmtpHost, SmtpPort)
				smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
				smtpClient.EnableSsl = False

				If Not String.IsNullOrEmpty(SmtpUserName) Then
					smtpClient.Credentials = New NetworkCredential(SmtpUserName, SmtpUserPassword)
				End If
				Using message As MailMessage = report.ExportToMail("someone@example.com", "recipient1@example.com, recipient2@example.com, recipient3@example.com", "Enter_Message_Subject")
					smtpClient.Send(message)
				End Using
			End Using
		End Sub
	End Class
End Namespace
