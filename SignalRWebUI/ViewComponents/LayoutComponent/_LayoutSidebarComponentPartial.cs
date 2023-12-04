using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutSidebarComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
