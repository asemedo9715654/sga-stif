using Microsoft.Extensions.Hosting;
using MimeKit;
using sga_stif.Helper;
using sga_stif.Models;
using static System.Formats.Asn1.AsnWriter;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace sga_stif
{
	public class ServicoSgaStif : BackgroundService
	{
		private readonly ILogger<ServicoSgaStif> _logger;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public ServicoSgaStif(ILogger<ServicoSgaStif> logger, IServiceScopeFactory serviceScopeFactory)
		{
			_logger = logger;
			_serviceScopeFactory = serviceScopeFactory;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				using (var scope = _serviceScopeFactory.CreateScope())
				{
					_logger.LogInformation("BackgroundService is running at: {time}", DateTimeOffset.Now);
					var dbContext = scope.ServiceProvider.GetRequiredService<ContextoBaseDados>();
					var pegar100EmailsNaoEnviadosAinda = dbContext.EmailEnviado.Where(e=>e.JaFoiEnviado==false).Take(100);
					foreach (var item in pegar100EmailsNaoEnviadosAinda)
						EnviarEmail(item,dbContext);	
				}
				await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
			}
		}


		public ResultadoMetodo<string> EnviarEmail(EmailEnviado emailEnviado, ContextoBaseDados _context)
		{
			try
			{
				// Configurações do servidor SMTP
				string smtpServer = "mail.stif.cv";
				int smtpPort = 587;
				string smtpUsername = "contact@stif.cv";
				string smtpPassword = "Cont@2023";

				// Criando a mensagem de email
				var message = new MimeMessage();
				message.From.Add(new MailboxAddress("STIF", "contact@stif.cv"));
				message.Bcc.Add(new MailboxAddress("Ângelo Semedo", "vamp9278493cv@gmail.com"));
				//message.Bcc.Add(new MailboxAddress("Odailton Veiga", "pachecoveiga@gmail.com"));

				message.Bcc.Add(new MailboxAddress(emailEnviado.Nome + " " + emailEnviado.Apelido, emailEnviado.Email));

				message.Subject = emailEnviado.Assunto;
				// Corpo do email
				var builder = new BodyBuilder();
				builder.HtmlBody = emailEnviado.Corpo;

				message.Body = builder.ToMessageBody();
		
				using (var client = new SmtpClient())
				{
					client.Connect(smtpServer, smtpPort, false);
					client.Authenticate(smtpUsername, smtpPassword);
					client.Send(message);
					client.Disconnect(true);
				}
				emailEnviado.JaFoiEnviado = true;
				_context.EmailEnviado.Update(emailEnviado);
				_context.SaveChanges();

				return new ResultadoMetodo<string>("", "");
			}
			catch (Exception e)
			{
				emailEnviado.JaFoiEnviado = true;
				emailEnviado.Obs = e.Message;
				_context.EmailEnviado.Update(emailEnviado);
				_context.SaveChanges();
				_logger.LogError(e.Message);
				return new ResultadoMetodo<string>(e);
			}
		}
	}
}
