using Microsoft.AspNetCore.Mvc;
using Project.Application.Abstractions;
using Project.Application.Models;
using Project.Core.Dtos;

namespace Project.API.Controllers;

[ApiController, Route("api/auth")]
public class AuthorizationController(IAuthorizationService authorizationService)
    : ControllerBase
{
    [HttpPost("login")]
    public async Task<ActionResult<TokenApiModel>> Login(LoginDto request)
    {
        var result = await authorizationService.Login(request);

        if (result.IsFailed)
            return BadRequest(result.Errors.Select(e => e.Message));

        return Ok(result.Value);
    }

    [HttpPost("registration")]
    public async Task<IActionResult> Registration(RegistrationDto request)
    {
        var result = await authorizationService.Registration(request);
        
        if (result.IsFailed)
            return BadRequest(result.Errors.Select(e => e.Message));

        return Ok(result.Value);
    }
}