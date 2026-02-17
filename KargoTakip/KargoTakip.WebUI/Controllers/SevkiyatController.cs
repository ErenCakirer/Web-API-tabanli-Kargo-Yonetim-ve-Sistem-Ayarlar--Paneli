using KargoTakip.WebUI.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;


    public class SevkiyatController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public SevkiyatController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    
    [HttpGet]
    public async Task<IActionResult> Index(string? id)
    {
        
        if (string.IsNullOrEmpty(id))
        {
            return View(new List<ResultKargoHareketDto>());
        }

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7245/api/KargoHareket/{id}");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultKargoHareketDto>>(jsonData);
            return View(values);
        }
        return View(new List<ResultKargoHareketDto>());
    }

    [HttpGet]
    public IActionResult CreateShipment()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateShipment(KargoTakip.WebUI.Dtos.ResultSevkiyatDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var responseMessage = await client.PostAsync("https://localhost:7245/api/Sevkiyat", content);

        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "Home");
        }

        return View();
    }
    [HttpPost]
    public async Task<IActionResult> HareketEkle(KargoTakip.WebUI.Dtos.ResultKargoHareketDto dto)
    {
        var client = _httpClientFactory.CreateClient();

       
        dto.Tarih = DateTime.Now;

        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        
        var responseMessage = await client.PostAsync("https://localhost:7245/api/KargoHareket", content);

        if (responseMessage.IsSuccessStatusCode)
        {
            
            return RedirectToAction("Index", new { id = dto.TakipKodu });
        }

        return RedirectToAction("Index");
    }
}
