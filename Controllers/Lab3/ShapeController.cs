using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Lab3;

namespace WebApplication1.Controllers.Lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(10, 10);
            return rectangle.GetArea();
        }

        [HttpGet]
        public int GetSumArea()
        {
            var rectangle = new Rectangle(5, 6);
            var rectangle2 = new Rectangle(2, 8);
            return rectangle + rectangle2;
        }
    }
}
