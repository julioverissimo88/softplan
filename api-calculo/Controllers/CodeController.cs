using Microsoft.AspNetCore.Mvc;

namespace api_calculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private readonly string githubUrl = "https://github.com/julioverissimo88/softplan.git";

        [HttpGet("showmethecode")]
        public IActionResult ShowMeThecode()
        {
            return Ok(githubUrl);
        }
    }
}