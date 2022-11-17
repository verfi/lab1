using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.LAB3;

namespace WebApplication1.Controllers.LAB3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23, 23);
            rectangle.Width2 = 32;
            return rectangle.GetArea();
        }

        [HttpGet]
        public int GetSumArea()
        {
            var rectangle = new Rectangle(3, 3);
            var rectangle2 = new Rectangle(4, 4);
            return rectangle + rectangle2;
        }
    }
}
