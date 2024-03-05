using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Fusca.Dashboard.Services.Stiba;

namespace Fusca.Dashboard.WebApi.Controllers
{
    [ApiController]
    [Route("api/stiba")]
    public class StibaController : ControllerBase
    {
        private readonly IStibaService _stibaService;

        public StibaController(IStibaService stibaService)
        {
            _stibaService = stibaService;
        }

        //private readonly ILogger<StibaController> _logger;

        //public StibaController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        [Route("/participacao")]
        public async Task<IActionResult> ObterParticipacao()
        {
            return Ok(await _stibaService.ObterParticipacao());
        }

        [HttpGet]
        [Route("/participacaoArea")]
        public async Task<IActionResult> RequisitarPesquisaStibaArea()
        {
            return Ok(await _stibaService.RequisitarPesquisaStibaArea());
        }

    }
}