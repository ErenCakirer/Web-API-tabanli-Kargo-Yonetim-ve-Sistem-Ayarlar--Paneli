using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
    [ViewComponent(Name = "_DashboardRightSide")]
    public class _DashboardRightSideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}