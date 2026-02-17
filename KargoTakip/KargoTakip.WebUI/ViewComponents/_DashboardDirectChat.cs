using KargoTakip.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.WebUI.ViewComponents
{
    // [ViewComponent] attribute'u ile ismini tescilliyoruz
    [ViewComponent(Name = "_DashboardDirectChat")]
    public class _DashboardDirectChat : ViewComponent
    {
        private readonly IMesajService _mesajService;

        public _DashboardDirectChat(IMesajService mesajService)
        {
            _mesajService = mesajService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
          
            var values = await _mesajService.TGetListAll();
            return View(values);
        }
    }
}