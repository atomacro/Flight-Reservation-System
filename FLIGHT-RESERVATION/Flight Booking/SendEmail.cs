using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    internal class SendEmail
    {
        private readonly string _fromEmail = "airplaneticketing@gmail.com";
        private readonly string _fromPassword = "aumf pnoe cytk xdwc";
        private readonly SmtpClient _smtpClient;

        public SendEmail()
        {
            _smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(_fromEmail, _fromPassword),
                EnableSsl = true
            };
        }

        public async Task SendEmailAsync(string toEmail, string attachmentPath = null)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(_fromEmail);
                    mail.To.Add(toEmail);
                    mail.Subject = "Airplane Ticketing System - Ticket";
                    mail.Body = "<h1>Your ticket</h1><p>Please find your airplane booking ticket attached.</p>";
                    mail.IsBodyHtml = true;

                    if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                    {
                        mail.Attachments.Add(new Attachment(attachmentPath));
                    }

                    await _smtpClient.SendMailAsync(mail);
                    //MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

