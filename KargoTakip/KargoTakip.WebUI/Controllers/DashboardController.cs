using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
