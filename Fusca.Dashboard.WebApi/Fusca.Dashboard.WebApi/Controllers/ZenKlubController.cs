using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fusca.Dashboard.Services.ZenKlub;

namespace Fusca.Dashboard.WebApi.Controllers
{
    [Route("api/zenklub")]
    [ApiController]
    public class ZenKlubController : ControllerBase
    {
        private readonly IZenKlubService _zenKlubService;

        public ZenKlubController(IZenKlubService zenKlubService)
        {
            _zenKlubService = zenKlubService;
        }

        [HttpGet]
        [Route("/sessionsfactory")]
        public async Task<IActionResult> GetSessionsFactoryZenKlub()
        {
            return Ok(await _zenKlubService.GetSessionsFactoryZenKlub());
        }


        [HttpGet]
        [Route("/sessionstotal")]
        public async Task<IActionResult> GetSessionsTotalZenKlub()
        {
            return Ok(await _zenKlubService.GetSessionsTotal());
        }
    }
}
