using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;

namespace CashInBox
{
    class Email
    {
        public static bool EnviaMensagemEmail(string Destinatario, string Remetente, string Destinatario2, string Assunto, string enviaMensagem)
        {
            try
            {

                //Create Mail Message Object with content that you want to send with mail.
                System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage(Remetente, Destinatario,
                Assunto, enviaMensagem);
                MyMailMessage.CC.Add(Destinatario2);

                MyMailMessage.IsBodyHtml = false;

                //Proper Authentication Details need to be passed when sending email from gmail
                System.Net.NetworkCredential mailAuthentication = new
                System.Net.NetworkCredential(Remetente, "#errosts");

                //Smtp Mail server of Gmail is "smpt.gmail.com" and it uses port no. 587
                //For different server like yahoo this details changes and you can
                //get it from respective server.
                System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

                //Enable SSL
                mailClient.EnableSsl = true;

                mailClient.UseDefaultCredentials = false;

                mailClient.Credentials = mailAuthentication;

                mailClient.Send(MyMailMessage);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static string MontarMensagemErro(string message, string inner)
        {
            return "Mensagem: " + message + "\n\rInnerException: "+ inner;
        }
    }
}
