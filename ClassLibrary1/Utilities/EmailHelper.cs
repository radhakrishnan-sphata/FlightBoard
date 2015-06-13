
using System;
using System.Net.Mail;

namespace FlightBoard.Core.Utilities
{
    public static class EmailHelper
    {
        public static bool SendEmail(string toMail, string subject, string ContentBody)
        {
            try
            {
                MailMessage message = new MailMessage()
                {
                    Subject = subject,
                    Body = ContentBody,
                    IsBodyHtml = true
                };
                message.To.Add(new MailAddress(toMail));
                new SmtpClient().Send(message);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}