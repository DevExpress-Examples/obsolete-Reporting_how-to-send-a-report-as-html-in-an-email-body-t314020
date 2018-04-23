Imports System
Imports System.Collections.Generic
Imports System.Linq
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
            Using client As New SmtpClient("mail.smtpclient.test", 25)
                Using message As MailMessage = report.ExportToMail("sender@test.test", "reciever1@test.test, reciever2@test.test, reciever3@test.test", "test")
                    client.Send(message)
                End Using
            End Using
        End Sub
    End Class
End Namespace
