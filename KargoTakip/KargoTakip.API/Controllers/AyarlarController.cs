using KargoTakip.Business.Abstract;
using KargoTakip.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AyarlarController : ControllerBase
    {
        private readonly IAyarlarService _ayarlarService;

        public AyarlarController(IAyarlarService ayarlarService)
        {
            _ayarlarService = ayarlarService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAyarlar()
        {
            var values = await _ayarlarService.GetAllAsync();
            var setting = values.FirstOrDefault();
            return Ok(setting);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAyarlar(Ayarlar ayarlar)
        {
            await _ayarlarService.UpdateAsync(ayarlar);
            return Ok("Sistem ayarları başarıyla güncellendi.");
        }

        
        [HttpGet("CikisYap")]
        public IActionResult CikisYap()
        {
            return Ok("Oturum kapatma işlemi tetiklendi.");
        }
    }
}
