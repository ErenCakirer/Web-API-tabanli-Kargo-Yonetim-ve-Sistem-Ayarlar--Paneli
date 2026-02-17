using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using KargoTakip.WebUI.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KargoTakip.WebUI.ViewComponents
{
    [ViewComponent(Name = "_DashboardLatestOrders")]
    public class _DashboardLatestOrdersViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLatestOrdersViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            using (var client = new HttpClient(handler))
            {
              
                var responseMessage = await client.GetAsync("https://localhost:7245/api/Sevkiyat");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();

                    // DİKKAT: Eğer JSON boşsa veya hatalıysa burası patlamasın diye ayar ekliyoruz
                    var values = JsonConvert.DeserializeObject<List<ResultSevkiyatDto>>(jsonData);

                    // TEST: Eğer hala boş geliyorsa, manuel bir satır ekleyip View'a zorla gönderelim
                    if (values == null || values.Count == 0)
                    {
                        values = new List<ResultSevkiyatDto>
                {
                    new ResultSevkiyatDto { ID = 999, TakipNo = "DEBUG-1", Gönderen = "Hata Yok", Alıcı = "Veri Bekleniyor", Durum = "Kontrol Et", OluşturulmaTarihi = DateTime.Now }
                };
                    }
                    return View(values);
                }
                else
                {
                    // API'ye hiç ulaşamıyorsa burası çalışır
                    return View(new List<ResultSevkiyatDto> { new ResultSevkiyatDto { TakipNo = "API_BAGLANTI_HATASI" } });
                }
            }
        }
    }
}