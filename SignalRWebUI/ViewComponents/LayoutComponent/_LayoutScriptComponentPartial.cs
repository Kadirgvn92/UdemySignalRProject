using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutScriptComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
