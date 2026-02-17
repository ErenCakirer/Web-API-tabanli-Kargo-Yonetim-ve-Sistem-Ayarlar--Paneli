using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using KargoTakip.WebUI.Dtos;

namespace KargoTakip.WebUI.ViewComponents
{
    public class _DashboardStatisticsViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            // 1. Sevkiyat Verilerini Çek (Üst Kutular İçin)
            var responseSevkiyat = await client.GetAsync("https://localhost:7245/api/Sevkiyat");
            if (responseSevkiyat.IsSuccessStatusCode)
            {
                var jsonData = await responseSevkiyat.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSevkiyatDto>>(jsonData);

                ViewBag.ToplamKargo = values.Count();
                ViewBag.Hazirlanan = values.Count(x => x.Durum == "Hazırlanıyor");
                ViewBag.Yolda = values.Count(x => x.Durum == "Yolda");
                ViewBag.TeslimEdilen = values.Count(x => x.Durum == "Teslim Edildi");
            }

            // 2. Kurye Verilerini Çek (Sağ Sütun İçin)
            var responseKurye = await client.GetAsync("https://localhost:7245/api/Kurye");
            if (responseKurye.IsSuccessStatusCode)
            {
                var jsonDataKurye = await responseKurye.Content.ReadAsStringAsync();
                // Not: ResultKuryeDto isminde bir DTO'n olduğunu varsayıyoruz
                var kuryeler = JsonConvert.DeserializeObject<List<ResultKuryeDto>>(jsonDataKurye);
                ViewBag.ToplamKurye = kuryeler.Count();
                ViewBag.AktifKurye = kuryeler.Count(x => x.Durum == "Aktif");
            }

            // 3. Mesaj Verilerini Çek (Sağ Sütun İçin)
            var responseMesaj = await client.GetAsync("https://localhost:7245/api/Mesaj");
            if (responseMesaj.IsSuccessStatusCode)
            {
                var jsonDataMesaj = await responseMesaj.Content.ReadAsStringAsync();
                var mesajlar = JsonConvert.DeserializeObject<List<ResultMesajDto>>(jsonDataMesaj);
                ViewBag.ToplamMesaj = mesajlar.Count();
            }

            return View();
        }
    }
}