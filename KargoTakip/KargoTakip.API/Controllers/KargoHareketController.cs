using KargoTakip.Business.Abstract;
using KargoTakip.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KargoHareketController : ControllerBase
    {
        private readonly IKargoHareketService _kargoHareketService;

        public KargoHareketController(IKargoHareketService kargoHareketService)
        {
            _kargoHareketService = kargoHareketService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHareketlerByKod(string id)
        {
            var values = await _kargoHareketService.TGetHareketlerByTakipKodu(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddKargoHareket(KargoHareket kargoHareket)
        {
            await _kargoHareketService.TAdd(kargoHareket);
            return Ok("Kargo hareketi başarıyla eklendi.");
        }
        
    }
}