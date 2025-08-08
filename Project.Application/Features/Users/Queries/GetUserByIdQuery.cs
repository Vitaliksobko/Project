using MediatR;
using Project.Core.Entities;

namespace Project.Application.Features.Users.Queries;

public record GetUserByIdQuery(Guid Id) : IRequest<User>;
