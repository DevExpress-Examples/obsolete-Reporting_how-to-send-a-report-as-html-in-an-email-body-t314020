# How to Send a Report as HTML in an Email Body

⛔ DEPRECATED. This example was deprecated. Visit the repositories that contain the actual information:

- [Reporting for WinForms - How to Use MailKit to Email a Report](https://github.com/DevExpress-Examples/reporting-winforms-mailkit-email-report-pdf)

The current repository will not be updated in the future.

------

This example demonstrates how to export a report to an email message and use the .NET Framework SMTP client to send email.

For this, call the [XtraReport.ExportToMail](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToMail(System.String-System.String-System.String)) method. This method returns an instance of the <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx">System.Net.Mail.MailMessage</a> class. The body of the resulting mail message contains a document in HTML format, optimized for email.

When a mail message is generated, initialize the [System.Net.Mail.SmtpClient](https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx) and call its **Send** method to send the message.

## Files to Look At

* [Program.cs](./CS/ConsoleApplication1/Program.cs) (VB: [Program.vb](./VB/ConsoleApplication1/Program.vb))

