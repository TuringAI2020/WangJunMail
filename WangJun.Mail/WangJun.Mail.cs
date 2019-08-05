using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WangJun.Yun
{
    public class WangJunMail
    {
        protected SmtpClient smtp;

        public static WangJunMail GetInst(string smtphost,int port,bool ssl,string loginId,string password)
        {
            var inst = new WangJunMail();
            inst.smtp = new SmtpClient(smtphost, port);
            inst.smtp.EnableSsl = ssl;
            inst.smtp.Credentials = new NetworkCredential(loginId, password);
            return inst;

        }

        public RES Send(string sourceAddress,string targetAddress, string title,string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(sourceAddress);
                mail.To.Add(new MailAddress(targetAddress));
                mail.Subject = title;
                mail.Body = content;
                mail.IsBodyHtml = true;
                this.smtp.Send(mail);
                return RES.OK();
            }
            catch (Exception ex) {
                return RES.FAIL(ex.Message, ex.Message);
            }
        }
         
    }
}
