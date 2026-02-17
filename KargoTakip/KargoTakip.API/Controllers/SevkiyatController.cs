using KargoTakip.Business.Abstract;
using KargoTakip.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace KargoTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SevkiyatController : ControllerBase
    {
        private readonly ISevkiyatService _sevkiyatService;

        public SevkiyatController(ISevkiyatService sevkiyatService)
        {
            _sevkiyatService = sevkiyatService;
        }

       
        [HttpGet]
        public async Task<IActionResult> GetAllShipments()
        {
            var values = await _sevkiyatService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShipment(Sevkiyat sevkiyat)
        {
            await _sevkiyatService.TAdd(sevkiyat);
            return Ok("Kargo başarıyla sisteme kaydedildi ve takip numarası oluşturuldu!");
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShipmentById(int id)
        {
            var value = await _sevkiyatService.TGetById(id);
            if (value == null) return NotFound("Kargo bulunamadı!");
            
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteShipment(int id)
        {
            var value = await _sevkiyatService.TGetById(id);
            if (value == null) return NotFound("Silinecek kargo bulunamadı!");
            _sevkiyatService.TDelete(value);
            return Ok("Kargo kaydı başarıyla silindi!");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateShipment(Sevkiyat sevkiyat)
        {
           _sevkiyatService.TUpdate(sevkiyat);
            return Ok("Kargo bilgileri başarıyla güncellendi!");
        }

       
    }
}