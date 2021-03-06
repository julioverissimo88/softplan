using api_calculo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace api_calculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        private readonly string format = "0000.##";

        [HttpGet("calculajuros")]
        public async Task<IActionResult> GetCalculo(double valorinicial, int meses, [FromServices] ICalculaJurosService _service)
        {
            decimal resultado = await _service.JurosCompostos(valorinicial, meses);
            return Ok(new { resultado = resultado });
        }
    }
}