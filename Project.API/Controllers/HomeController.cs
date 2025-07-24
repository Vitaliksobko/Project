using Microsoft.AspNetCore.Mvc;

namespace Project.API.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet("hello")]
    public ActionResult<string> GetHello()
    {
        return Ok("Hello, world!");
    }
}