using Project.Core.Abstractions;
using Project.Core.Entities;
using Project.infrastructure.Data;

namespace Project.Infrastructure.Repositories;

public class UserRepository(ProjectDbContext context)
    : BaseRepository<User>(context), IUserRepository
{
   
}