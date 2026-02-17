using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using KargoTakip.WebUI.Dtos;
using System.Net.Http;
using System.Text;

namespace KargoTakip.WebUI.Controllers
{
    public class AyarlarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AyarlarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            
            var responseMessage = await client.GetAsync("https://localhost:7092/api/Ayarlar");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultAyarlarDto>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}