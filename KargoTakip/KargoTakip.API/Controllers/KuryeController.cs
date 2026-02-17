using KargoTakip.Business.Abstract;
using KargoTakip.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using KargoTakip.API.Dtos;
using System.Threading.Tasks;

namespace KargoTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KuryeController : ControllerBase
    {
        private readonly IKuryeService _kuryeService;
        public KuryeController(IKuryeService kuryeService)
        {
            _kuryeService = kuryeService;
        }

        [HttpGet]
        public async Task<IActionResult> KuryeList()
        {
            var values = await _kuryeService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateKurye(Kurye kurye)
        {
            await _kuryeService.TAdd(kurye);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKurye(int id)
        {
            var value = await _kuryeService.TGetById(id);
            if (value == null) return NotFound();

            await _kuryeService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetKurye(int id)
        {
            var value = await _kuryeService.TGetById(id);
            if (value == null) return NotFound();
            return Ok(value);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKurye(int id, UpdateKuryeDto updateKuryeDto) 
        {
          
            var kurye = await _kuryeService.TGetById(id);
            if (kurye == null) return NotFound("Kurye bulunamadı.");

            kurye.AdSoyad = updateKuryeDto.AdSoyad;
            kurye.AracTipi = updateKuryeDto.AracTipi;
            kurye.Durum = updateKuryeDto.Durum;
          

            await _kuryeService.TUpdate(kurye);
            return Ok();
        }
    }
}