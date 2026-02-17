using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
    [ViewComponent(Name = "_DashboardCharts")]
    public class _DashboardChartsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}