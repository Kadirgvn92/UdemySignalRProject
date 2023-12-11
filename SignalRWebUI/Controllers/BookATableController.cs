using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers;
public class BookATableController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
