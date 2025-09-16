using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class UserRepository(ProjectDbContext context)
    : BaseRepository<User>(context), IUserRepository
{
   
}