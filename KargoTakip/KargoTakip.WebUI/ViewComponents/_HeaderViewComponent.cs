using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
    
    [ViewComponent(Name = "Header")]
    public class _HeaderViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}