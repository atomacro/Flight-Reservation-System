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
                    mail.Body = $@"
                    <!DOCTYPE html>
                    <html lang=""en"">
                    <head>
                        <meta charset=""UTF-8"">
                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                        <title>Thank You</title>
                        <style>
                            body {{
                                margin: 0;
                                padding: 0;
                                font-family: Arial, sans-serif;
                                background-color: #f4f4f4;
                            }}
                            .email-container {{
                                max-width: 600px;
                                margin: 20px auto;
                                background: #ffffff;
                                border-radius: 8px;
                                box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
                                overflow: hidden;
                            }}
                            .header {{
                                background: #5e17eb;
                                color: #ffffff;
                                text-align: center;
                                padding: 20px;
                            }}
                            .header h1 {{
                                margin: 0;
                                font-size: 24px;
                            }}
                            .content {{
                                padding: 20px;
                                color: #333333;
                                line-height: 1.6;
                            }}
                            .content h2 {{
                                margin-top: 0;
                            }}
                            .footer {{
                                background: #f4f4f4;
                                text-align: center;
                                padding: 15px;
                                font-size: 14px;
                                color: #888888;
                            }}                      
                        </style>
                    </head>
                    <body>
                        <div class=""email-container"">
                            <!-- Header -->
                            <div class=""header"">
                                <h1>Thank You for Flying with Us!</h1>
                            </div>

                            <!-- Content -->
                            <div class=""content"">
                                <h2>Dear {Session.CurrentUserName},</h2>
                                <p>We appreciate you using our airplane ticketing system for your recent travel needs. It’s our pleasure to serve you and make your journey smooth and hassle-free.</p>
                                <p>If you have any questions or need further assistance, don’t hesitate to contact us.</p>
                                <p>Safe travels and we hope to serve you again soon!</p>
                            </div>

                            <!-- Footer -->
                            <div class=""footer"">
                                <p>© 2024 Airplane Ticketing System. All rights reserved.</p>                                
                            </div>
                        </div>
                    </body>
                    </html>";
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
            }
        }
    }
}

