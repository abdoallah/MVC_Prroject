using MVC_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Helper
{
    public static class MailSender
    {
        public static string SendMail(MailVM model)
        {
            try
            {
                //Register host name and port number
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                //Enable SSl
                smtp.EnableSsl = true;

                //Register Account that will send mails
                smtp.Credentials = new NetworkCredential("elgendya160@gmail.com", "@@@AAA321_321");


                smtp.Send("elgendya160@gmail.com", model.Email, model.Title, model.Message);

                var result = "Mail Sent Successfully";
                return result;
            }
            catch (Exception ex)
            {
                var result = "Faild";
                return result;  
            }
        }
    }
}
