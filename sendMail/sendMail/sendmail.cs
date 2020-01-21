using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace sendMail
{
    public class sendmail
    {
        protected void send()
        {
            string emailTo = "eduarthajko1992@gmail.com";
            string emailFrom = "arifbucpapaj98@gmail.com";
            string emailCc = "asdf@asdf.asdf";
            string emailSubject = "asdf";
            string emailBody = "asdff test asdf";
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.sefin.it");


            mail.From = new MailAddress(emailFrom);

            mail.To.Add(emailTo);

            mail.Subject = emailSubject;
            mail.Body = emailBody;

            //SmtpServer.Port = ?;
            SmtpServer.Credentials = new System.Net.NetworkCredential("esmerald.aliaj@sefin.it", "Complex123");
            //SmtpServer.EnableSsl = true; // Sefin's smtp does not support ssl.

            try
            {
                SmtpServer.Send(mail);
                //to fix file lock when it has attachments
                mail.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught: {0}", ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine("Inner exception: {0}", ex.InnerException);
            }
        }
    }

}
}