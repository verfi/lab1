using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.LAB4;
using WebApplication1.Services.LAB5;

namespace WebApplication1.Controllers.LAB4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.getLang();
        }
    }
}