using Project.Core.Abstractions;
using Project.infrastructure.Data;

namespace Project.Infrastructure.Repositories;

public class UnitOfWork(
    ProjectDbContext context,
   
    Lazy<IUserRepository> userRepository) : IUnitOfWork
{
    

    public IUserRepository User => userRepository.Value;
    
   
    public async Task SaveAsync() => await  context.SaveChangesAsync();
}