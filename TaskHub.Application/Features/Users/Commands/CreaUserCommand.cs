using FluentResults;
using MediatR;
using TaskHub.Application.Models;

namespace TaskHub.Application.Features.Users.Commands;

public record CreateUserCommand(
    string FirstName,
    string SecondName,
    string Email,
    string UserName,
    string Password) : IRequest<Result<TokenApiModel>>;