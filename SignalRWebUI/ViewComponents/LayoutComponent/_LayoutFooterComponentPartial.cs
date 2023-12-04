using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutFooterComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
