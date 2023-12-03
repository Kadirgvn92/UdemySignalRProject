using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponent;

public class _LayoutHeaderPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
