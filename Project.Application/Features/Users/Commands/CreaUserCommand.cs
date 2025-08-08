using FluentResults;
using MediatR;
using Project.Application.Models;

namespace Project.Application.Features.Users.Commands;

public record CreateUserCommand(
    string FirstName,
    string SecondName,
    string Email,
    string UserName,
    string Password) : IRequest<Result<TokenApiModel>>;