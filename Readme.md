<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603177/2022.2)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T314020)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ConsoleApplication1/Program.cs) (VB: [Program.vb](./VB/ConsoleApplication1/Program.vb))
<!-- default file list end -->
# How to Send a Report as HTML in an Email Body


This example demonstrates how to export a report to an email message and use the .NET Framework SMTP client to send email.

For this, call the [XtraReport.ExportToMail](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToMail(System.String-System.String-System.String)) method. This method returns an instance of the <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx">System.Net.Mail.MailMessage</a> class. The body of the resulting mail message contains a document in HTML format, optimized for email.

When a mail message is generated, initialize the [System.Net.Mail.SmtpClient](https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx) and call its **Send** method to send the message.



