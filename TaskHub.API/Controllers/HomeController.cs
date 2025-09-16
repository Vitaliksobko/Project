using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskHub.Application.Features.Users.Commands;
using TaskHub.Application.Features.Users.Queries;
using TaskHub.Core.Entities;

namespace TaskHub.API.Controllers;

[ApiController]
[Route("api/user")]
public class HomeController : ControllerBase
{
    private readonly IMediator _mediator;

    public HomeController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> Get(Guid id)
    {
        var result = await _mediator.Send(new GetUserByIdQuery(id));
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command)
    {
        var id = await _mediator.Send(command);
        return Ok(id);
    }
}

