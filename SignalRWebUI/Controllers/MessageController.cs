using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers;
public class MessageController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
