using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HelloAspNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IOptions<MyOptions> _options;

        public HelloController(IOptions<MyOptions> options)
        {
            _options = options;
        }
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _options.Value.MyValue;
        }
    }
}