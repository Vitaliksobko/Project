using MediatR;
using TaskHub.Core.Entities;

namespace TaskHub.Application.Features.Users.Queries;

public record GetUserByIdQuery(Guid Id) : IRequest<User>;
