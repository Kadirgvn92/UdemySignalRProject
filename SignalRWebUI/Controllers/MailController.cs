using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalRWebUI.Dtos.MailDtos;

namespace SignalRWebUI.Controllers;
public class MailController : Controller
{
	[HttpGet]
	public IActionResult Index()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Index(CreateMailDto createMailDto)
	{
		MimeMessage mimeMessage = new MimeMessage();
		MailboxAddress mailboxAddressFrom = new MailboxAddress("BombBurger Rezervasyon", "kadirgvn92@gmail.com");
		mimeMessage.From.Add(mailboxAddressFrom);
		MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReceiverMail);
		mimeMessage.To.Add(mailboxAddressTo);

		var bodyBuilder = new BodyBuilder();
		bodyBuilder.HtmlBody = createMailDto.Body;
		mimeMessage.Body = bodyBuilder.ToMessageBody();

		mimeMessage.Subject = createMailDto.Subject;
		
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Connect("smtp.gmail.com",587,false);
		smtpClient.Authenticate("kadirgvn92@gmail.com", "oytz kefm nioc ccyu");

		smtpClient.Send(mimeMessage);
		smtpClient.Disconnect(true);

		return RedirectToAction("Index","Category");
	}

}
