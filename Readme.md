<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ConsoleApplication1/Program.cs) (VB: [Program.vb](./VB/ConsoleApplication1/Program.vb))
<!-- default file list end -->
# How to send a report as HTML in an email body


<p>This example demonstrates how to export a report to an email message and use the mailing functionality of the .NET Framework to programmatically send the generated message to an arbitrary number of recipients using the required email settings. To accomplish this task, use the report's <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_ExportToMailtopic">ExportToMail</a> method. This method returns an instance of the <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx">System.Net.Mail.MailMessage</a> class. The body of the resulting mail message contains an HTML representation of the report contents optimized for sending using email.</p>
<p>After a mail message is generated, you can initialize a <a href="https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx">System.Net.Mail.SmtpClient</a> and call its <strong>SmtpClient.Send</strong> method to send the message.</p>

<br/>


