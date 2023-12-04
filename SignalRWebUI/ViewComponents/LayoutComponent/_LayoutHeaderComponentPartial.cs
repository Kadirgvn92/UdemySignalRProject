using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutHeaderComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
