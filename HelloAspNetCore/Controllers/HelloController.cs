using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HelloAspNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private static readonly string InstanceName = Guid.NewGuid().ToString();
        private readonly IOptions<MyOptions> _options;

        public HelloController(IOptions<MyOptions> options)
        {
            _options = options;
        }
        
        [HttpGet]
        public ActionResult<object> Get()
        {
            return new
            {
                InstanceName = InstanceName,
                MyValue = _options.Value.MyValue
            };
        }
    }
}