using Microsoft.AspNetCore.Mvc;

namespace CadVeicular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Teste()
        {
            return Ok();
        }
    }
}
