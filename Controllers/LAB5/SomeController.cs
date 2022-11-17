using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.LAB4;
using WebApplication1.Services.LAB5;

namespace WebApplication1.Controllers.LAB4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}

