using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World";
        }
    }
}