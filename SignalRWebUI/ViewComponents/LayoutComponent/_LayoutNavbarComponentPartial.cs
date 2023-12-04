using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutNavbarComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
