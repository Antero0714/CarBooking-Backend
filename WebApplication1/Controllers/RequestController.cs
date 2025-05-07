using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendRequest([FromForm] RequestForm requestForm)
        {
            return Ok();
        }
    }
}
