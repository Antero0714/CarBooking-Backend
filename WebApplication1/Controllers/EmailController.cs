using Microsoft.AspNetCore.Mvc;
using WebApplication1.Abstractions;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    [HttpPost("send")]
    public async Task Send(
        [FromServices] IEmailService emailService,
        [FromForm] string to)
    {
        await emailService.SendAsync(to, "asd", "asd");
    }
}