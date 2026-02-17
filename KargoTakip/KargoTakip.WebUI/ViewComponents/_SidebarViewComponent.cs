using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
   
    [ViewComponent(Name = "_SidebarViewComponent")]
    public class _SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}