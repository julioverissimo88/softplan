using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly decimal taxaJuros = 0.01M;

        [HttpGet("taxaJuros")]
        public IActionResult GetTaxaJuros()
        {
            return Ok(taxaJuros);
        }
    }
}