using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutSidebarPartialComponent : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
