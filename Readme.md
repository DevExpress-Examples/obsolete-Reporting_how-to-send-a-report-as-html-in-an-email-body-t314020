<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ConsoleApplication1/Program.cs) (VB: [Program.vb](./VB/ConsoleApplication1/Program.vb))
<!-- default file list end -->
# How to Send a Report as HTML in an Email Body


This example demonstrates how to export a report to an email message and use the .NET Framework SMTP client to send email.

For this, call the [XtraReport.ExportToMail](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToMail(System.String-System.String-System.String)) method. This method returns an instance of the <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx">System.Net.Mail.MailMessage</a> class. The body of the resulting mail message contains a document in HTML format, optimized for email.

When a mail message is generated, initialize the [System.Net.Mail.SmtpClient](https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx) and call its **Send** method to send the message.



