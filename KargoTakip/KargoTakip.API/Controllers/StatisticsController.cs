using KargoTakip.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMesajService _mesajService;
        private readonly IKuryeService _kuryeService;

        public StatisticsController(IMesajService mesajService, IKuryeService kuryeService)
        {
            _mesajService = mesajService;
            _kuryeService = kuryeService;
        }

        [HttpGet("GetTotalMesajCount")]
        public async Task<IActionResult> GetTotalMesajCount()
        {
            var values = await _mesajService.TGetListAll();
            return Ok(values.Count);
        }

        [HttpGet("GetTotalKuryeCount")]
        public async Task<IActionResult> GetTotalKuryeCount()
        {
            var values = await _kuryeService.TGetListAll();
            return Ok(values.Count);
        }
    }
}
