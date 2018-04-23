using System;
using System.Collections.Generic;
using System.Linq;
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
            using(SmtpClient client = new SmtpClient("mail.smtpclient.test", 25)) {
                using(MailMessage message = report.ExportToMail("sender@test.test",
                        "reciever1@test.test, reciever2@test.test, reciever3@test.test", "test")) {
                    client.Send(message);
                }
            }   
        }
    }
}
