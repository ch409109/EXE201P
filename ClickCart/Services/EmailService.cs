using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ClickCart.Models;
using Microsoft.Extensions.Options;

namespace ClickCart.Services
{
	public class EmailService
	{
		private readonly EmailSettings _emailSettings;

		public EmailService(IOptions<EmailSettings> emailSettings)
		{
			_emailSettings = emailSettings.Value;
		}

		public async Task SendEmailAsync(string toEmail, string subject, string body)
		{
			try
			{
				using (var smtpClient = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.SmtpPort))
				{
					smtpClient.Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword);
					smtpClient.EnableSsl = true;

					var mailMessage = new MailMessage
					{
						From = new MailAddress(_emailSettings.SmtpUsername,"ClickCart"),
						Subject = subject,
						Body = body,
						IsBodyHtml = true
					};

					mailMessage.To.Add(toEmail);
					await smtpClient.SendMailAsync(mailMessage);
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Failed to send email: {ex.Message}", ex);
			}
		}
	}
}
