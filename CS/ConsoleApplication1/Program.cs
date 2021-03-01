using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using DevExpress.XtraReports.UI;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            List<ReportData> list = new List<ReportData>();
            for(int i = 0; i < 10; i++)
                list.Add(new ReportData() { Value1 = i, Value2 = i, Value3 = i });

            XtraReport report = new XtraReport1() { DataSource = list };

            string SmtpHost = null;
            int SmtpPort = -1;
            if (string.IsNullOrEmpty(SmtpHost) || SmtpPort == -1)
            {
                System.Diagnostics.Debug.WriteLine("Please configure the SMTP server settings.");
                return;
            }

            string SmtpUserName = "Enter_Sender_User_Name";
            string SmtpUserPassword = "Enter_Sender_Password";

            using (var smtpClient = new SmtpClient(SmtpHost, SmtpPort))
            {
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = false;

                if (!string.IsNullOrEmpty(SmtpUserName))
                {
                    smtpClient.Credentials = new NetworkCredential(SmtpUserName, SmtpUserPassword);
                }
                using(MailMessage message = report.ExportToMail("someone@example.com",
                        "recipient1@example.com, recipient2@example.com, recipient3@example.com", "Enter_Message_Subject")) {
                    smtpClient.Send(message);
                }
            }   
        }
    }
}
