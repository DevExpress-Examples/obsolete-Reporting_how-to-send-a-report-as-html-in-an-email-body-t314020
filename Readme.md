<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603177/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T314020)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ConsoleApplication1/Program.cs) (VB: [Program.vb](./VB/ConsoleApplication1/Program.vb))
<!-- default file list end -->
# How to send a report as HTML in an email body


<p>This example demonstrates how to export a report to an email message and use the mailing functionality of the .NET Framework to programmatically send the generated message to an arbitrary number of recipients using the required email settings. To accomplish this task, use the report's <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_ExportToMailtopic">ExportToMail</a> method. This method returns an instance of the <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx">System.Net.Mail.MailMessage</a> class. The body of the resulting mail message contains an HTML representation of the report contents optimized for sending using email.</p>
<p>After a mail message is generated, you can initialize a <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx">System.Net.Mail.SmtpClient</a> and call its <strong>SmtpClient.Send</strong> method to send the message.</p>

<br/>


