

namespace RafahiaBlazorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class SecuredController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok("Hello from secured controller");
        }
    }
}
