using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Project.Application.Abstractions;
using Project.Application.Models;
using Project.Core.Abstractions;
using Project.Core.Dtos;
using Project.Core.Entities;

namespace Project.Application.Features.Users.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<TokenApiModel>>
{
    private readonly IAuthorizationService _authService;

    public CreateUserCommandHandler(IAuthorizationService authService)
    {
        _authService = authService;
    }

    public async Task<Result<TokenApiModel>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var dto = new RegistrationDto
        {
            FirstName = request.FirstName,
            SecondName = request.SecondName,
            Email = request.Email,
            UserName = request.UserName,
            Password = request.Password
        };

        return await _authService.Registration(dto);
    }
}