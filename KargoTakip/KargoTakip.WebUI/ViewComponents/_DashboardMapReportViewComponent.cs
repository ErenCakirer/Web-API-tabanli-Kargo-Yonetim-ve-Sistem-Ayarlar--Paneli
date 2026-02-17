using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
    [ViewComponent(Name = "_DashboardMapReport")]
    public class _DashboardMapReportViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
