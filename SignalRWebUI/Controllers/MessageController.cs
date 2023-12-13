using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers;
public class MessageController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
	public IActionResult ClientUserCount()
	{
		return View();
	}
}
